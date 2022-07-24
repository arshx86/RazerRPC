#region

using System;
using System.Windows.Forms;
using RazerRPC.Util;
using Themer;

#endregion

namespace RazerRPC.Forms
{
    public partial class Settings : Form
    {
        // yep it's my framework :D
        // https://github.com/arshx86/Themer
        private readonly ThemerApplier theme_;

        public Settings(IntPtr callerHandle)
        {
            InitializeComponent();
            theme_ = new ThemerApplier(Handle);
            theme_.Apply(Properties.Settings.Default.Theme);
            SetAcryclic.Click += (s, e) => { SetAllTheme(Themes.Acrylic); };
            SetGlass.Click += (s, e) => { SetAllTheme(Themes.AeroGlass); };
            SetTransparent.Click += (s, e) => { SetAllTheme(Themes.Transparent); };
            SetNone.Click += (s, e) => { SetAllTheme(Themes.None); };
        }

        protected override void OnLoad(EventArgs e)
        {
            LoadSettings();
            base.OnLoad(e);
        }

        private void GoBack(object sender, EventArgs e)
        {
            SaveSettings();
            Fader.FadeOut(this, 60);
            Hide();
            new Client(null).Show();
        }

        private void ReSettings_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset settings/preferences?",
                    "Reset Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                DialogResult.Yes)
            {
                Fader.FadeOut(this, 60);
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
                Application.Restart();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Fader.FadeIn(this, 60);
        }

        private void SaveSettings()
        {
            var sett = Properties.Settings.Default;
            sett.RPCOn = rpcon.Checked;
            sett.RunAtStartup = startup.Checked;
            sett.AutoEffect = autoeffect.Checked;
            sett.Save();
        }

        private void LoadSettings()
        {
            var sett = Properties.Settings.Default;
            rpcon.Checked = sett.RPCOn;
            startup.Checked = sett.RunAtStartup;
            autoeffect.Checked = sett.AutoEffect;
            Tools.PutStartup(sett.RunAtStartup);
        }

        private void SetAllTheme(Themes theme)
        {
            theme_.Apply(theme);
            Properties.Settings.Default.Theme = theme;
        }
    }
}