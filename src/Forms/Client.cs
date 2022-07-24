#region

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Message;
using Guna.UI2.WinForms;
using RazerRPC.Models;
using RazerRPC.Properties;
using RazerRPC.Util;
using Themer;

#endregion

namespace RazerRPC.Forms
{
    public partial class Client : Form
    {
        private static ThemerApplier theme_;
        private static DateTime TS_Unix;
        private static bool IsLoadFinished;
        private static bool IsSilent;
        private static string SelectedAsset = "razer_green";

        /// <summary>
        ///     Main RPC client to adjust RPC.
        /// </summary>
        private static DiscordRpcClient client = new DiscordRpcClient(Consts.APPID);

        /// <summary>
        ///     To store equipment name and index for the select box.
        /// </summary>
        private readonly Dictionary<string, int> Equipment = new Dictionary<string, int>();

        private Guna2Panel loadingPanel;

        public Client(string[] args)
        {

            theme_ = new ThemerApplier(Handle);
  
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            if (args?.Length > 0)
                /* Silent run enabled */
                if (args.Any(x => x.Contains("/silent")))
                {
                    IsSilent = true;
                    WindowState = FormWindowState.Minimized; // call OnResized() event to enable tray icon
                    ShowInTaskbar = false;
                    Task.Factory.StartNew(() =>
                    {
                        for (; ; )
                        {
                            Task.Delay(500);
                            if (!IsLoadFinished) continue;
                            ApplyRPC(false); // make sure rpc initialized
                            break;
                        }
                    });
                }
        }

        protected override void OnLoad(EventArgs e)
        {
            // CreateLoadingPanel();
            Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

            Fader.FadeIn(this, 60);
            if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly()?.Location)).Count() > 1)
            {
                // schedule for restart and kill other instances
                Application.Restart();
                Process.GetCurrentProcess().Kill();
            }

            LoadSettings();
            base.OnLoad(e);
        }

        private void Client_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.RPCOn)
            {
                status.Text = "RPC Disabled (hover)";
                tooltip.SetToolTip(status, "You are disabled the RPC. Re-enable it in settings > enabled.");
                nick.Text = "null";
                disc.Text = "0000";
                if (client.IsInitialized) client?.Deinitialize();
                return;
            }

            // refresh client
            if (client.IsInitialized)
            {
                client?.Deinitialize();
                client?.Dispose();
            }

            client = new DiscordRpcClient(Consts.APPID);
            client.OnReady += Client_OnReady;

            if (!client.Initialize())
            {
                MessageBox.Show("Failed to initialize client.");
                return;
            }

            subtitleBox.SelectedIndex = 0;
            status.Text = "Scanning razer equipments";

            /* scan razer equipments */
            int i = 0;

            try
            {
                RazerWrapper.GetMouses().ForEach(x => Equipment.Add(x, i++));
            }
            catch
            {
            }

            try
            {
                RazerWrapper.GetKeyboards().ForEach(x => Equipment.Add(x, i++));
            }
            catch
            {
            }

            try
            {
                RazerWrapper.GetHeadsets().ForEach(x => Equipment.Add(x, i++));
            }
            catch
            {
            }

            if (Equipment.Count == 0)
            {
                MessageBox.Show("Unable to find any razer product on your PC. Please try to update your razer driver, HID class and make sure it showing in device manager. If error continues, please open issue at github repo.", "Ups!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            foreach (var eq in Equipment) equipmentsBox.Items.Add(eq.Key);

            status.Text = "Preparing account";
            equipmentsBox.SelectedIndex = 0;
            IsLoadFinished = true;
            manual_save.Visible = !Properties.Settings.Default.AutoEffect;
            ApplyRPC();
        }

        private void Client_OnReady(object sender, ReadyMessage args)
        {
            // newtonsoft's parse is so that can't even parse your discriminiator if startswith 0
            // ie my discriminator is 0064 but it showing 64 only this is fault of newtonsoft
            // we should get it directly with our own parse

            DiscordUser user = IDLookup.LookupID(client.CurrentUser.ID);
            avatar_pp.ImageLocation = client.CurrentUser.GetAvatarURL(User.AvatarFormat.PNG, User.AvatarSize.x64);
            nick.Text = client.CurrentUser.Username;
            disc.Text = $"#{user.discriminator}";
            status.Text = "Ready";
            tooltip.SetToolTip(status, "RazerRPC is ready, " +
                                       $"{(Properties.Settings.Default.AutoEffect ? "your changes will affected to profile instantly." : "don't forget to save it to take effect. (AutoEffect disabled)")}");
        }

        /// <summary>
        ///     Save RPC settings.
        /// </summary>
        private void SaveSettings()
        {
            var settings = Properties.Settings.Default;
            settings.Desc = card_desc.Text;
            settings.Subtitle = card_subtitle.Text;
            settings.AssetArg = SelectedAsset;
            settings.EnableTS = tsampt.Visible;
            settings.AddWith = card_desc.Text.Contains("with ");
            settings.Save();
        }

        /// <summary>
        ///     Loads settings.
        /// </summary>
        private void LoadSettings()
        {
            var settings = Properties.Settings.Default;
            /* there are already saved settings */
            theme_.Apply(Properties.Settings.Default.Theme);
            if (settings.Theme != Themes.None)
            {
                // enhance vision
                card_panel_container.BackColor = this.BackColor;
                card_panel_header.BackColor = this.BackColor;

                /* Avoid text cluttering for labels and boxes */
                foreach (var label in this.Controls.OfType<Guna.UI2.WinForms.Guna2HtmlLabel>())
                {
                    label.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
                }
                foreach (var box in this.Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
                {
                    box.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
                }
                
            }

            if (settings.Subtitle != "")
            {
                card_subtitle.Text = settings.Subtitle;
                subtitleBox.Text = settings.Subtitle;

                // enable ts
                if (settings.EnableTS) SwitchTimestamp.PerformClick();

                // enable add "with"
                if (settings.AddWith) addWith.PerformClick();

                card_desc.Text = settings.Desc;
                SelectedAsset = settings.AssetArg;
                switch (SelectedAsset)
                {
                    case "razer_gradient":
                        lg_gradient.PerformClick();
                        break;
                    case "razer_white":
                        lg_white.PerformClick();
                        break;
                    case "razer_green":
                        lg_green.PerformClick();
                        break;
                }
            }
            else
            {
                card_desc.Text = "with Razer Products";
            }
        }

        /// <summary>
        ///     Applies a new RPC to the selected equipment.
        /// </summary>
        /// <param name="IsAutoSave">Whether this method calling from auto save.</param>
        private void ApplyRPC(bool IsAutoSave = true)
        {
            // don't allow live effect when disabled
            if (!Properties.Settings.Default.AutoEffect && IsAutoSave) return;
            status.Text = "Applying";
            var RPC = new RichPresence
            {
                Assets = new Assets
                {
                    LargeImageKey = SelectedAsset,
                    LargeImageText = "RazerRPC"
                },
                Details = card_subtitle.Text,
                State = card_desc.Text
            };

            // enable ts if selected
            if (tsampt.Visible)
                RPC.WithTimestamps(new Timestamps
                {
                    Start = TS_Unix,
                });
            client.SetPresence(RPC);
            status.Text = "Ready";
        }

        private void CreateLoadingPanel(bool Dispose = false)
        {
            if (Dispose)
            {
                Tools.Animate(loadingPanel, Tools.Effect.Blend, 100, 360);
                Controls.Remove(loadingPanel);
                loadingPanel?.Dispose();
                return;
            }

            // create loading panel from my old code
            loadingPanel = new Guna2Panel
            {
                BackColor = Color.FromArgb(23, 23, 34),
                Size = new Size(Width, Height),
                Anchor = AnchorStyles.None
            };

            /* actual panel */
            var loadingPic = new Guna2PictureBox
            {
                ImageLocation = "https://i.imgur.com/XGn4tdL.gif",
                SizeMode = PictureBoxSizeMode.CenterImage,
                Size = new Size(Width, Height),
                Location = new Point(ClientSize.Width / 2 - Size.Width / 2, ClientSize.Height / 2 - Size.Height / 2)
            };

            loadingPanel.Controls.Add(loadingPic);
            Controls.Add(loadingPanel);
            loadingPanel.BringToFront();
            loadingPanel.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/arshx86");
        }

        #region Events

        private void equipmentsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            card_desc.Text = $"{(Properties.Settings.Default.AddWith ? "with " : "")} {Equipment.First(x => x.Value == equipmentsBox.SelectedIndex).Key}";
            ApplyRPC();
        }

        private void subtitleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            card_subtitle.Text = $"{(string)subtitleBox.SelectedItem}";
            ApplyRPC();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Fader.FadeOutAndClose(this, 60);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Fader.FadeOut(this, 60);
            Hide();
            new Settings(Handle).Show();
        }

        private void OnShown(object sender, EventArgs e)
        {
            // hide form if /silent param called
            if (IsSilent)
            {
                Hide();
                return;
            }
            TopMost = true;
            Focus();
            Show();
            TopMost = false;
        }

        private async void manual_save_Click(object sender, EventArgs e)
        {
            ApplyRPC(false); // pass 'that is manual apply' flag
            manual_save.Text = ":)";
            await Task.Delay(1250);
            manual_save.Text = "Save";
        }

        /// <summary>
        ///     Flag to check if tray already created. To prevent from multiple trays.
        /// </summary>
        private static bool TRAY_ALREADY_CREATED;

        /// <summary>
        ///     Fired when form is minimized to create tray icon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnResize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized || TRAY_ALREADY_CREATED) return;

            var tray = new NotifyIcon
            {
                Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location),
                Visible = true,
                Text = "RazerRPC",
                ContextMenu = new ContextMenu
                {
                    MenuItems =
                    {
                        new MenuItem("Next Logo", (s, args) =>
                        {
                            string[] arr =
                            {
                                "razer_gradient",
                                "razer_white",
                                "razer_green"
                            };
                            SelectedAsset = arr[(Array.IndexOf(arr, SelectedAsset) + 1) % arr.Length];
                            ApplyRPC();
                        }),
                        new MenuItem("Edit RPC", (s, args) =>
                        {
                            ShowInTaskbar = true;
                            Show();
                            Focus();
                            BringToFront();
                        }),
                        new MenuItem("Exit", (s, args) =>
                        {
                            SaveSettings();
                            Environment.Exit(0);
                        })
                    }
                }
            };
            if (!IsSilent)
                // we shouldnt disturb him :) 
                tray.ShowBalloonTip(3000, "Minimized", "RazerRPC running in background to keep alive your RPC :)", ToolTipIcon.Info);
            TRAY_ALREADY_CREATED = true;
        }

        #endregion

        #region Logo Events

        private async void lg_white_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            SelectedAsset = "razer_white";
            Tools.Animate(card_pp_panel, Tools.Effect.Center, 120, 360);
            card_logo.Image = Resources.razer_white_8;
            Tools.Animate(card_pp_panel, Tools.Effect.Center, 120, 360);
            ApplyRPC();
        }

        private async void lg_green_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            SelectedAsset = "razer_green";
            Tools.Animate(card_pp_panel, Tools.Effect.Center, 120, 360);
            card_logo.Image = Resources.razer_green_8;
            Tools.Animate(card_pp_panel, Tools.Effect.Center, 120, 360);
            ApplyRPC();
        }

        private async void lg_gradient_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            SelectedAsset = "razer_gradient";
            Tools.Animate(card_pp_panel, Tools.Effect.Center, 120, 360);
            card_logo.Image = Resources.razer_gradient_81;
            Tools.Animate(card_pp_panel, Tools.Effect.Center, 120, 360);
            ApplyRPC();
        }

        #endregion

        #region Hover Handlers

        private void EquipmentsHover(object sender, EventArgs e)
        {
            card_desc.ForeColor = Color.Green;
        }

        private void EquipmentsUnhover(object sender, EventArgs e)
        {
            card_desc.ForeColor = Color.FromArgb(148, 155, 193);
        }

        private void StateHover(object sender, EventArgs e)
        {
            card_subtitle.ForeColor = Color.Green;
        }

        private void StateUnHover(object sender, EventArgs e)
        {
            card_subtitle.ForeColor = Color.FromArgb(148, 155, 193);
        }

        private void SwitchTimestamp_Click(object sender, EventArgs e)
        {
            if (tsampt.Visible)
            {
                TS_Unix = Process.GetCurrentProcess().StartTime.ToLocalTime();
                tsampt.Visible = false;
                SwitchTimestamp.Text = "Enable timestamp";
            }
            else
            {
                tsampt.Visible = true;
                tsampt.Text = "For X minutes";
                SwitchTimestamp.Text = "Disable Timestamp";
            }

            ApplyRPC();
        }

        private void addWith_Click(object sender, EventArgs e)
        {
            if (card_desc.Text.Contains("with"))
            {
                card_desc.Text = card_desc.Text.Replace("with ", "");
                addWith.Text = "Enable \"with\"";
            }
            else
            {
                card_desc.Text = card_desc.Text.Insert(0, "with ");
                addWith.Text = "Disable \"with\"";
            }

            ApplyRPC();
        }
    }

    #endregion
}