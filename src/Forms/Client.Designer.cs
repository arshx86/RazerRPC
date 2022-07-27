namespace RazerRPC.Forms
{
    partial class Client
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.card_panel_container = new Guna.UI2.WinForms.Guna2Panel();
            this.tsampt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.card_desc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.card_subtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.card_const_title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.card_pp_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.card_logo = new System.Windows.Forms.PictureBox();
            this.card_panel_header = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.nick = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.disc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.avatar_pp = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.borderlessf = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.equipmentsBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.subtitleBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2VProgressBar1 = new Guna.UI2.WinForms.Guna2VProgressBar();
            this.status = new Guna.UI2.WinForms.Guna2Button();
            this.tooltip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.addWith = new Guna.UI2.WinForms.Guna2Button();
            this.SwitchTimestamp = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.manual_save = new Guna.UI2.WinForms.Guna2Button();
            this.lg_gradient = new Guna.UI2.WinForms.Guna2Button();
            this.lg_green = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.lg_white = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.tooltip_special = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.card_panel_container.SuspendLayout();
            this.card_pp_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card_logo)).BeginInit();
            this.card_panel_header.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar_pp)).BeginInit();
            this.SuspendLayout();
            // 
            // card_panel_container
            // 
            this.card_panel_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.card_panel_container.BorderColor = System.Drawing.Color.Transparent;
            this.card_panel_container.BorderRadius = 12;
            this.card_panel_container.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.card_panel_container.BorderThickness = 2;
            this.card_panel_container.Controls.Add(this.tsampt);
            this.card_panel_container.Controls.Add(this.card_desc);
            this.card_panel_container.Controls.Add(this.card_subtitle);
            this.card_panel_container.Controls.Add(this.card_const_title);
            this.card_panel_container.Controls.Add(this.guna2HtmlLabel5);
            this.card_panel_container.Controls.Add(this.card_pp_panel);
            this.card_panel_container.Location = new System.Drawing.Point(30, 54);
            this.card_panel_container.Name = "card_panel_container";
            this.card_panel_container.Size = new System.Drawing.Size(200, 231);
            this.card_panel_container.TabIndex = 0;
            // 
            // tsampt
            // 
            this.tsampt.BackColor = System.Drawing.Color.Transparent;
            this.tsampt.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsampt.ForeColor = System.Drawing.Color.White;
            this.tsampt.IsContextMenuEnabled = false;
            this.tsampt.IsSelectionEnabled = false;
            this.tsampt.Location = new System.Drawing.Point(81, 208);
            this.tsampt.Name = "tsampt";
            this.tsampt.Size = new System.Drawing.Size(58, 15);
            this.tsampt.TabIndex = 54;
            this.tsampt.Text = "Timestamp";
            this.tsampt.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.tsampt.Visible = false;
            // 
            // card_desc
            // 
            this.card_desc.BackColor = System.Drawing.Color.Transparent;
            this.card_desc.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(193)))));
            this.card_desc.IsContextMenuEnabled = false;
            this.card_desc.IsSelectionEnabled = false;
            this.card_desc.Location = new System.Drawing.Point(81, 191);
            this.card_desc.Name = "card_desc";
            this.card_desc.Size = new System.Drawing.Size(56, 15);
            this.card_desc.TabIndex = 10;
            this.card_desc.Text = "Viper Mini";
            this.card_desc.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // card_subtitle
            // 
            this.card_subtitle.BackColor = System.Drawing.Color.Transparent;
            this.card_subtitle.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_subtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(193)))));
            this.card_subtitle.IsContextMenuEnabled = false;
            this.card_subtitle.IsSelectionEnabled = false;
            this.card_subtitle.Location = new System.Drawing.Point(81, 174);
            this.card_subtitle.Name = "card_subtitle";
            this.card_subtitle.Size = new System.Drawing.Size(38, 15);
            this.card_subtitle.TabIndex = 5;
            this.card_subtitle.Text = "Mouse";
            this.card_subtitle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // card_const_title
            // 
            this.card_const_title.BackColor = System.Drawing.Color.Transparent;
            this.card_const_title.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.card_const_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.card_const_title.IsContextMenuEnabled = false;
            this.card_const_title.IsSelectionEnabled = false;
            this.card_const_title.Location = new System.Drawing.Point(81, 153);
            this.card_const_title.Name = "card_const_title";
            this.card_const_title.Size = new System.Drawing.Size(36, 19);
            this.card_const_title.TabIndex = 9;
            this.card_const_title.Text = "Razer";
            this.card_const_title.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.IsContextMenuEnabled = false;
            this.guna2HtmlLabel5.IsSelectionEnabled = false;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(11, 128);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(98, 15);
            this.guna2HtmlLabel5.TabIndex = 7;
            this.guna2HtmlLabel5.Text = "PLAYING A GAME";
            // 
            // card_pp_panel
            // 
            this.card_pp_panel.Controls.Add(this.card_logo);
            this.card_pp_panel.Location = new System.Drawing.Point(8, 153);
            this.card_pp_panel.Name = "card_pp_panel";
            this.card_pp_panel.Size = new System.Drawing.Size(67, 70);
            this.card_pp_panel.TabIndex = 53;
            // 
            // card_logo
            // 
            this.card_logo.Image = global::RazerRPC.Properties.Resources.green;
            this.card_logo.Location = new System.Drawing.Point(1, 2);
            this.card_logo.Name = "card_logo";
            this.card_logo.Size = new System.Drawing.Size(65, 68);
            this.card_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card_logo.TabIndex = 8;
            this.card_logo.TabStop = false;
            this.tooltip_special.SetToolTip(this.card_logo, "RazerRPC");
            // 
            // card_panel_header
            // 
            this.card_panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
            this.card_panel_header.BorderRadius = 12;
            this.card_panel_header.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.card_panel_header.BorderThickness = 2;
            this.card_panel_header.Controls.Add(this.guna2Panel7);
            this.card_panel_header.Controls.Add(this.guna2Panel4);
            this.card_panel_header.Controls.Add(this.avatar_pp);
            this.card_panel_header.Location = new System.Drawing.Point(30, 54);
            this.card_panel_header.Name = "card_panel_header";
            this.card_panel_header.Size = new System.Drawing.Size(200, 119);
            this.card_panel_header.TabIndex = 1;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.Controls.Add(this.nick);
            this.guna2Panel7.Location = new System.Drawing.Point(0, 90);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(88, 22);
            this.guna2Panel7.TabIndex = 53;
            // 
            // nick
            // 
            this.nick.AutoSize = false;
            this.nick.BackColor = System.Drawing.Color.Transparent;
            this.nick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nick.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nick.ForeColor = System.Drawing.Color.White;
            this.nick.IsContextMenuEnabled = false;
            this.nick.IsSelectionEnabled = false;
            this.nick.Location = new System.Drawing.Point(0, 0);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(88, 22);
            this.nick.TabIndex = 5;
            this.nick.Text = "null";
            this.nick.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.tooltip.SetToolTip(this.nick, "oh, it\'s you");
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.disc);
            this.guna2Panel4.Location = new System.Drawing.Point(94, 90);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(106, 22);
            this.guna2Panel4.TabIndex = 53;
            // 
            // disc
            // 
            this.disc.AutoSize = false;
            this.disc.BackColor = System.Drawing.Color.Transparent;
            this.disc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.disc.ForeColor = System.Drawing.Color.DimGray;
            this.disc.IsContextMenuEnabled = false;
            this.disc.IsSelectionEnabled = false;
            this.disc.Location = new System.Drawing.Point(0, 0);
            this.disc.Name = "disc";
            this.disc.Size = new System.Drawing.Size(106, 22);
            this.disc.TabIndex = 6;
            this.disc.Text = "#0000";
            this.disc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // avatar_pp
            // 
            this.avatar_pp.ImageRotate = 0F;
            this.avatar_pp.Location = new System.Drawing.Point(68, 19);
            this.avatar_pp.Name = "avatar_pp";
            this.avatar_pp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.avatar_pp.Size = new System.Drawing.Size(64, 64);
            this.avatar_pp.TabIndex = 0;
            this.avatar_pp.TabStop = false;
            // 
            // borderlessf
            // 
            this.borderlessf.ContainerControl = this;
            this.borderlessf.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessf.TransparentWhileDrag = true;
            // 
            // equipmentsBox
            // 
            this.equipmentsBox.BackColor = System.Drawing.Color.Transparent;
            this.equipmentsBox.BorderColor = System.Drawing.Color.Indigo;
            this.equipmentsBox.BorderRadius = 4;
            this.equipmentsBox.BorderThickness = 2;
            this.equipmentsBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.equipmentsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentsBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(41)))));
            this.equipmentsBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.equipmentsBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.equipmentsBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.equipmentsBox.ForeColor = System.Drawing.Color.White;
            this.equipmentsBox.ItemHeight = 25;
            this.equipmentsBox.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.equipmentsBox.ItemsAppearance.SelectedFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.equipmentsBox.Location = new System.Drawing.Point(304, 164);
            this.equipmentsBox.Name = "equipmentsBox";
            this.equipmentsBox.Size = new System.Drawing.Size(155, 31);
            this.equipmentsBox.TabIndex = 1;
            this.equipmentsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.equipmentsBox.SelectedIndexChanged += new System.EventHandler(this.equipmentsBox_SelectedIndexChanged);
            this.equipmentsBox.MouseLeave += new System.EventHandler(this.EquipmentsUnhover);
            this.equipmentsBox.MouseHover += new System.EventHandler(this.EquipmentsHover);
            // 
            // subtitleBox
            // 
            this.subtitleBox.BackColor = System.Drawing.Color.Transparent;
            this.subtitleBox.BorderColor = System.Drawing.Color.Navy;
            this.subtitleBox.BorderRadius = 4;
            this.subtitleBox.BorderThickness = 2;
            this.subtitleBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.subtitleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subtitleBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(41)))));
            this.subtitleBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.subtitleBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.subtitleBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.subtitleBox.ForeColor = System.Drawing.Color.White;
            this.subtitleBox.ItemHeight = 25;
            this.subtitleBox.Items.AddRange(new object[] {
            "Gaming",
            "Idle",
            "For gamers, by gamers",
            "Mice",
            "Mouse",
            "Keyboard",
            "Headset"});
            this.subtitleBox.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.subtitleBox.ItemsAppearance.SelectedFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subtitleBox.Location = new System.Drawing.Point(517, 164);
            this.subtitleBox.Name = "subtitleBox";
            this.subtitleBox.Size = new System.Drawing.Size(155, 31);
            this.subtitleBox.TabIndex = 4;
            this.subtitleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.subtitleBox.SelectedIndexChanged += new System.EventHandler(this.subtitleBox_SelectedIndexChanged);
            this.subtitleBox.MouseLeave += new System.EventHandler(this.StateUnHover);
            this.subtitleBox.MouseHover += new System.EventHandler(this.StateHover);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Animated = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.CustomClick = true;
            this.Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.Exit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Exit.Location = new System.Drawing.Point(643, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 29);
            this.Exit.TabIndex = 45;
            this.Exit.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(590, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 46;
            // 
            // guna2VProgressBar1
            // 
            this.guna2VProgressBar1.BorderRadius = 10;
            this.guna2VProgressBar1.FillColor = System.Drawing.Color.Indigo;
            this.guna2VProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2VProgressBar1.Location = new System.Drawing.Point(257, 32);
            this.guna2VProgressBar1.Name = "guna2VProgressBar1";
            this.guna2VProgressBar1.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition;
            this.guna2VProgressBar1.ProgressColor = System.Drawing.Color.Indigo;
            this.guna2VProgressBar1.ProgressColor2 = System.Drawing.Color.BlueViolet;
            this.guna2VProgressBar1.Size = new System.Drawing.Size(14, 332);
            this.guna2VProgressBar1.TabIndex = 47;
            this.guna2VProgressBar1.Text = "guna2VProgressBar1";
            this.guna2VProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // status
            // 
            this.status.Animated = true;
            this.status.BorderColor = System.Drawing.Color.Transparent;
            this.status.BorderRadius = 9;
            this.status.BorderThickness = 1;
            this.status.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.status.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.status.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.status.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.status.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(30)))));
            this.status.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(30, 291);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(196, 28);
            this.status.TabIndex = 48;
            this.status.Text = "Initializing client";
            this.tooltip.SetToolTip(this.status, "This shows current client status");
            // 
            // tooltip
            // 
            this.tooltip.AllowLinksHandling = true;
            this.tooltip.BackColor = System.Drawing.Color.Black;
            this.tooltip.BorderColor = System.Drawing.Color.Indigo;
            this.tooltip.ForeColor = System.Drawing.Color.White;
            this.tooltip.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // addWith
            // 
            this.addWith.Animated = true;
            this.addWith.BackColor = System.Drawing.Color.Transparent;
            this.addWith.BorderColor = System.Drawing.Color.Transparent;
            this.addWith.BorderRadius = 6;
            this.addWith.BorderThickness = 1;
            this.addWith.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.addWith.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.addWith.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addWith.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addWith.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addWith.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addWith.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.addWith.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addWith.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.addWith.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(75)))));
            this.addWith.ImageSize = new System.Drawing.Size(30, 30);
            this.addWith.Location = new System.Drawing.Point(354, 214);
            this.addWith.Name = "addWith";
            this.addWith.PressedDepth = 10;
            this.addWith.Size = new System.Drawing.Size(127, 33);
            this.addWith.TabIndex = 55;
            this.addWith.Text = "Enable \"with\"";
            this.tooltip.SetToolTip(this.addWith, "Add \"with\" prefix to start of the equipment");
            this.addWith.Click += new System.EventHandler(this.addWith_Click);
            // 
            // SwitchTimestamp
            // 
            this.SwitchTimestamp.Animated = true;
            this.SwitchTimestamp.BackColor = System.Drawing.Color.Transparent;
            this.SwitchTimestamp.BorderColor = System.Drawing.Color.Transparent;
            this.SwitchTimestamp.BorderRadius = 6;
            this.SwitchTimestamp.BorderThickness = 1;
            this.SwitchTimestamp.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.SwitchTimestamp.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.SwitchTimestamp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SwitchTimestamp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SwitchTimestamp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SwitchTimestamp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SwitchTimestamp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.SwitchTimestamp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SwitchTimestamp.ForeColor = System.Drawing.Color.IndianRed;
            this.SwitchTimestamp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(75)))));
            this.SwitchTimestamp.ImageSize = new System.Drawing.Size(30, 30);
            this.SwitchTimestamp.Location = new System.Drawing.Point(487, 214);
            this.SwitchTimestamp.Name = "SwitchTimestamp";
            this.SwitchTimestamp.PressedDepth = 10;
            this.SwitchTimestamp.Size = new System.Drawing.Size(127, 33);
            this.SwitchTimestamp.TabIndex = 56;
            this.SwitchTimestamp.Text = "Enable Timestamp";
            this.tooltip.SetToolTip(this.SwitchTimestamp, "Display the elapsed time ");
            this.SwitchTimestamp.Click += new System.EventHandler(this.SwitchTimestamp_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Empty;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = global::RazerRPC.Properties.Resources.outgoing;
            this.guna2Button3.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button3.Location = new System.Drawing.Point(555, 122);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(80, 36);
            this.guna2Button3.TabIndex = 58;
            this.tooltip.SetToolTip(this.guna2Button3, "Prefix as subtitle");
            // 
            // manual_save
            // 
            this.manual_save.Animated = true;
            this.manual_save.BorderColor = System.Drawing.Color.Transparent;
            this.manual_save.BorderRadius = 9;
            this.manual_save.BorderThickness = 1;
            this.manual_save.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.manual_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.manual_save.Enabled = false;
            this.manual_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.manual_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.manual_save.ForeColor = System.Drawing.Color.White;
            this.manual_save.Location = new System.Drawing.Point(30, 325);
            this.manual_save.Name = "manual_save";
            this.manual_save.Size = new System.Drawing.Size(196, 28);
            this.manual_save.TabIndex = 54;
            this.manual_save.Text = "Save";
            this.tooltip.SetToolTip(this.manual_save, "Save RPC and look at your profile :)");
            this.manual_save.Visible = false;
            this.manual_save.Click += new System.EventHandler(this.manual_save_Click);
            // 
            // lg_gradient
            // 
            this.lg_gradient.Animated = true;
            this.lg_gradient.BackColor = System.Drawing.Color.Transparent;
            this.lg_gradient.BorderColor = System.Drawing.Color.Transparent;
            this.lg_gradient.BorderRadius = 6;
            this.lg_gradient.BorderThickness = 1;
            this.lg_gradient.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.lg_gradient.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.lg_gradient.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.lg_gradient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lg_gradient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lg_gradient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lg_gradient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lg_gradient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.lg_gradient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lg_gradient.ForeColor = System.Drawing.Color.White;
            this.lg_gradient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(75)))));
            this.lg_gradient.Image = global::RazerRPC.Properties.Resources.razer_gradient_81;
            this.lg_gradient.ImageSize = new System.Drawing.Size(30, 30);
            this.lg_gradient.Location = new System.Drawing.Point(563, 265);
            this.lg_gradient.Name = "lg_gradient";
            this.lg_gradient.PressedDepth = 10;
            this.lg_gradient.Size = new System.Drawing.Size(104, 33);
            this.lg_gradient.TabIndex = 51;
            this.lg_gradient.Text = "Gradient";
            this.tooltip.SetToolTip(this.lg_gradient, "Razer Gradient");
            this.lg_gradient.Click += new System.EventHandler(this.lg_gradient_Click);
            // 
            // lg_green
            // 
            this.lg_green.Animated = true;
            this.lg_green.BackColor = System.Drawing.Color.Transparent;
            this.lg_green.BorderColor = System.Drawing.Color.Transparent;
            this.lg_green.BorderRadius = 6;
            this.lg_green.BorderThickness = 1;
            this.lg_green.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.lg_green.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.lg_green.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.lg_green.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lg_green.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lg_green.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lg_green.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lg_green.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.lg_green.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lg_green.ForeColor = System.Drawing.Color.White;
            this.lg_green.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(75)))));
            this.lg_green.Image = global::RazerRPC.Properties.Resources.razer_green_8;
            this.lg_green.ImageSize = new System.Drawing.Size(30, 30);
            this.lg_green.Location = new System.Drawing.Point(434, 265);
            this.lg_green.Name = "lg_green";
            this.lg_green.PressedDepth = 10;
            this.lg_green.Size = new System.Drawing.Size(104, 33);
            this.lg_green.TabIndex = 50;
            this.lg_green.Text = "Green";
            this.tooltip.SetToolTip(this.lg_green, "Razer Original Green");
            this.lg_green.Click += new System.EventHandler(this.lg_green_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 6;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(55)))));
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(75)))));
            this.guna2Button2.Image = global::RazerRPC.Properties.Resources.settings;
            this.guna2Button2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button2.Location = new System.Drawing.Point(92, 360);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button2.PressedDepth = 10;
            this.guna2Button2.Size = new System.Drawing.Size(35, 33);
            this.guna2Button2.TabIndex = 54;
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tooltip.SetToolTip(this.guna2Button2, "Settings");
            this.guna2Button2.Click += new System.EventHandler(this.Settings_Click);
            // 
            // lg_white
            // 
            this.lg_white.Animated = true;
            this.lg_white.BackColor = System.Drawing.Color.Transparent;
            this.lg_white.BorderColor = System.Drawing.Color.Transparent;
            this.lg_white.BorderRadius = 6;
            this.lg_white.BorderThickness = 1;
            this.lg_white.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.lg_white.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.lg_white.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(40)))));
            this.lg_white.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lg_white.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lg_white.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lg_white.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lg_white.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(45)))));
            this.lg_white.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lg_white.ForeColor = System.Drawing.Color.White;
            this.lg_white.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(75)))));
            this.lg_white.Image = ((System.Drawing.Image)(resources.GetObject("lg_white.Image")));
            this.lg_white.ImageSize = new System.Drawing.Size(30, 30);
            this.lg_white.Location = new System.Drawing.Point(304, 265);
            this.lg_white.Name = "lg_white";
            this.lg_white.PressedDepth = 10;
            this.lg_white.Size = new System.Drawing.Size(104, 33);
            this.lg_white.TabIndex = 49;
            this.lg_white.Text = "White";
            this.tooltip.SetToolTip(this.lg_white, "Razer White");
            this.lg_white.Click += new System.EventHandler(this.lg_white_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(55)))));
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(19)))), ((int)(((byte)(75)))));
            this.guna2Button1.Image = global::RazerRPC.Properties.Resources.github;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(133, 360);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button1.PressedDepth = 10;
            this.guna2Button1.Size = new System.Drawing.Size(35, 33);
            this.guna2Button1.TabIndex = 52;
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tooltip.SetToolTip(this.guna2Button1, "Open Source ♥");
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.BorderRadius = 10;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Empty;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = global::RazerRPC.Properties.Resources.dotdotdot;
            this.guna2Button4.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button4.Location = new System.Drawing.Point(340, 122);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(80, 36);
            this.guna2Button4.TabIndex = 59;
            this.tooltip.SetToolTip(this.guna2Button4, "Connected devices to display in RPC");
            // 
            // tooltip_special
            // 
            this.tooltip_special.AllowLinksHandling = true;
            this.tooltip_special.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.tooltip_special.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.tooltip_special.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tooltip_special.ForeColor = System.Drawing.Color.White;
            this.tooltip_special.MaximumSize = new System.Drawing.Size(0, 0);
            this.tooltip_special.UseAnimation = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.IsContextMenuEnabled = false;
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(434, 54);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(99, 23);
            this.guna2HtmlLabel1.TabIndex = 55;
            this.guna2HtmlLabel1.Text = "RPC Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(381, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 10);
            this.panel1.TabIndex = 60;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.manual_save);
            this.Controls.Add(this.card_panel_header);
            this.Controls.Add(this.SwitchTimestamp);
            this.Controls.Add(this.addWith);
            this.Controls.Add(this.lg_gradient);
            this.Controls.Add(this.status);
            this.Controls.Add(this.equipmentsBox);
            this.Controls.Add(this.subtitleBox);
            this.Controls.Add(this.lg_green);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.lg_white);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2VProgressBar1);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.card_panel_container);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.Shown += new System.EventHandler(this.OnShown);
            this.Resize += new System.EventHandler(this.OnResize);
            this.card_panel_container.ResumeLayout(false);
            this.card_panel_container.PerformLayout();
            this.card_pp_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.card_logo)).EndInit();
            this.card_panel_header.ResumeLayout(false);
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatar_pp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel card_panel_container;
        private Guna.UI2.WinForms.Guna2Panel card_panel_header;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessf;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel disc;
        private Guna.UI2.WinForms.Guna2HtmlLabel nick;
        private Guna.UI2.WinForms.Guna2CirclePictureBox avatar_pp;
        private System.Windows.Forms.PictureBox card_logo;
        private Guna.UI2.WinForms.Guna2HtmlLabel card_desc;
        private Guna.UI2.WinForms.Guna2HtmlLabel card_subtitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel card_const_title;
        private Guna.UI2.WinForms.Guna2ComboBox equipmentsBox;
        private Guna.UI2.WinForms.Guna2Button lg_gradient;
        private Guna.UI2.WinForms.Guna2Button lg_green;
        private Guna.UI2.WinForms.Guna2Button lg_white;
        private Guna.UI2.WinForms.Guna2ComboBox subtitleBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox Exit;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Panel card_pp_panel;
        private Guna.UI2.WinForms.Guna2Button status;
        private Guna.UI2.WinForms.Guna2VProgressBar guna2VProgressBar1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip tooltip;
        private Guna.UI2.WinForms.Guna2HtmlToolTip tooltip_special;
        private Guna.UI2.WinForms.Guna2Button manual_save;
        private Guna.UI2.WinForms.Guna2Button SwitchTimestamp;
        private Guna.UI2.WinForms.Guna2Button addWith;
        private Guna.UI2.WinForms.Guna2HtmlLabel tsampt;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}

