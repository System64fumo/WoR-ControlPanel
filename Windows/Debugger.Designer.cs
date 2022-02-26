
namespace WoRCP
{
    partial class Debugger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.LogUpdater = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.collapsiblePanel2 = new WoRCP.CustomUI.CollapsiblePanel();
            this.BrightPanel = new System.Windows.Forms.Label();
            this.BrightPanelLabel = new System.Windows.Forms.Label();
            this.BrightPanelPanel = new WoRCP.RoundedPanel();
            this.Background = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Label();
            this.Inactive = new System.Windows.Forms.Label();
            this.DarkAccent = new System.Windows.Forms.Label();
            this.Accent = new System.Windows.Forms.Label();
            this.BrightAccent = new System.Windows.Forms.Label();
            this.BackgroundLabel = new System.Windows.Forms.Label();
            this.PanelLabel = new System.Windows.Forms.Label();
            this.InactiveLabel = new System.Windows.Forms.Label();
            this.DarkAccentLabel = new System.Windows.Forms.Label();
            this.AccentLabel = new System.Windows.Forms.Label();
            this.BrightAccentLabel = new System.Windows.Forms.Label();
            this.PanelPanel = new WoRCP.RoundedPanel();
            this.InactivePanel = new WoRCP.RoundedPanel();
            this.DarkAccentPanel = new WoRCP.RoundedPanel();
            this.AccentPanel = new WoRCP.RoundedPanel();
            this.BackgroundPanel = new WoRCP.RoundedPanel();
            this.BrightAccentPanel = new WoRCP.RoundedPanel();
            this.Transparency = new System.Windows.Forms.Label();
            this.ThemeMode = new System.Windows.Forms.Label();
            this.TransparencyLabel = new System.Windows.Forms.Label();
            this.ThemeModeLabel = new System.Windows.Forms.Label();
            this.collapsiblePanel3 = new WoRCP.CustomUI.CollapsiblePanel();
            this.SaveButton = new WoRCP.RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new WoRCP.RoundedPanel();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.collapsiblePanel4 = new WoRCP.CustomUI.CollapsiblePanel();
            this.AdvancedOCToggle = new WoRCP.CustomUI.Toggle();
            this.AdvancedOCLabel = new System.Windows.Forms.Label();
            this.TitleBar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.collapsiblePanel2.SuspendLayout();
            this.collapsiblePanel3.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.collapsiblePanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TitleBar.Controls.Add(this.label1);
            this.TitleBar.Controls.Add(this.MinimizeButton);
            this.TitleBar.Controls.Add(this.CloseButton);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(600, 30);
            this.TitleBar.TabIndex = 2;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragStart);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = " WoR CP Debugger";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.Location = new System.Drawing.Point(510, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(45, 30);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = "";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(555, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 30);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LogUpdater
            // 
            this.LogUpdater.Enabled = true;
            this.LogUpdater.Interval = 1000;
            this.LogUpdater.Tick += new System.EventHandler(this.LogUpdater_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.collapsiblePanel2);
            this.flowLayoutPanel1.Controls.Add(this.collapsiblePanel3);
            this.flowLayoutPanel1.Controls.Add(this.collapsiblePanel4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(621, 478);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // collapsiblePanel2
            // 
            this.collapsiblePanel2.BackColor = System.Drawing.Color.Transparent;
            this.collapsiblePanel2.Collapsed = true;
            this.collapsiblePanel2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.collapsiblePanel2.Controls.Add(this.BrightPanel);
            this.collapsiblePanel2.Controls.Add(this.BrightPanelLabel);
            this.collapsiblePanel2.Controls.Add(this.BrightPanelPanel);
            this.collapsiblePanel2.Controls.Add(this.Background);
            this.collapsiblePanel2.Controls.Add(this.Panel);
            this.collapsiblePanel2.Controls.Add(this.Inactive);
            this.collapsiblePanel2.Controls.Add(this.DarkAccent);
            this.collapsiblePanel2.Controls.Add(this.Accent);
            this.collapsiblePanel2.Controls.Add(this.BrightAccent);
            this.collapsiblePanel2.Controls.Add(this.BackgroundLabel);
            this.collapsiblePanel2.Controls.Add(this.PanelLabel);
            this.collapsiblePanel2.Controls.Add(this.InactiveLabel);
            this.collapsiblePanel2.Controls.Add(this.DarkAccentLabel);
            this.collapsiblePanel2.Controls.Add(this.AccentLabel);
            this.collapsiblePanel2.Controls.Add(this.BrightAccentLabel);
            this.collapsiblePanel2.Controls.Add(this.PanelPanel);
            this.collapsiblePanel2.Controls.Add(this.InactivePanel);
            this.collapsiblePanel2.Controls.Add(this.DarkAccentPanel);
            this.collapsiblePanel2.Controls.Add(this.AccentPanel);
            this.collapsiblePanel2.Controls.Add(this.BackgroundPanel);
            this.collapsiblePanel2.Controls.Add(this.BrightAccentPanel);
            this.collapsiblePanel2.Controls.Add(this.Transparency);
            this.collapsiblePanel2.Controls.Add(this.ThemeMode);
            this.collapsiblePanel2.Controls.Add(this.TransparencyLabel);
            this.collapsiblePanel2.Controls.Add(this.ThemeModeLabel);
            this.collapsiblePanel2.Icon = "";
            this.collapsiblePanel2.Location = new System.Drawing.Point(10, 10);
            this.collapsiblePanel2.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.collapsiblePanel2.Name = "collapsiblePanel2";
            this.collapsiblePanel2.PanelText = "Theme";
            this.collapsiblePanel2.Rounding = 5;
            this.collapsiblePanel2.Separators = 9;
            this.collapsiblePanel2.Size = new System.Drawing.Size(580, 60);
            this.collapsiblePanel2.TabIndex = 15;
            this.collapsiblePanel2.Text = "Theme";
            // 
            // BrightPanel
            // 
            this.BrightPanel.BackColor = System.Drawing.Color.Transparent;
            this.BrightPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrightPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.BrightPanel.Location = new System.Drawing.Point(371, 317);
            this.BrightPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BrightPanel.Name = "BrightPanel";
            this.BrightPanel.Size = new System.Drawing.Size(150, 50);
            this.BrightPanel.TabIndex = 100;
            this.BrightPanel.Text = "Unavailable";
            this.BrightPanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BrightPanelLabel
            // 
            this.BrightPanelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrightPanelLabel.Location = new System.Drawing.Point(45, 317);
            this.BrightPanelLabel.Margin = new System.Windows.Forms.Padding(0);
            this.BrightPanelLabel.Name = "BrightPanelLabel";
            this.BrightPanelLabel.Size = new System.Drawing.Size(179, 50);
            this.BrightPanelLabel.TabIndex = 99;
            this.BrightPanelLabel.Text = "Bright Panel";
            this.BrightPanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BrightPanelPanel
            // 
            this.BrightPanelPanel.BackColor = System.Drawing.Color.Transparent;
            this.BrightPanelPanel.color = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.BrightPanelPanel.Location = new System.Drawing.Point(531, 321);
            this.BrightPanelPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BrightPanelPanel.Name = "BrightPanelPanel";
            this.BrightPanelPanel.rounding = 5;
            this.BrightPanelPanel.Size = new System.Drawing.Size(40, 40);
            this.BrightPanelPanel.TabIndex = 98;
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.Transparent;
            this.Background.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Background.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Background.Location = new System.Drawing.Point(371, 470);
            this.Background.Margin = new System.Windows.Forms.Padding(0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(150, 50);
            this.Background.TabIndex = 80;
            this.Background.Text = "Unavailable";
            this.Background.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Panel.Location = new System.Drawing.Point(371, 419);
            this.Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(150, 50);
            this.Panel.TabIndex = 79;
            this.Panel.Text = "Unavailable";
            this.Panel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Inactive
            // 
            this.Inactive.BackColor = System.Drawing.Color.Transparent;
            this.Inactive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inactive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Inactive.Location = new System.Drawing.Point(371, 368);
            this.Inactive.Margin = new System.Windows.Forms.Padding(0);
            this.Inactive.Name = "Inactive";
            this.Inactive.Size = new System.Drawing.Size(150, 50);
            this.Inactive.TabIndex = 78;
            this.Inactive.Text = "Unavailable";
            this.Inactive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DarkAccent
            // 
            this.DarkAccent.BackColor = System.Drawing.Color.Transparent;
            this.DarkAccent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DarkAccent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.DarkAccent.Location = new System.Drawing.Point(371, 265);
            this.DarkAccent.Margin = new System.Windows.Forms.Padding(0);
            this.DarkAccent.Name = "DarkAccent";
            this.DarkAccent.Size = new System.Drawing.Size(150, 50);
            this.DarkAccent.TabIndex = 77;
            this.DarkAccent.Text = "Unavailable";
            this.DarkAccent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Accent
            // 
            this.Accent.BackColor = System.Drawing.Color.Transparent;
            this.Accent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Accent.Location = new System.Drawing.Point(371, 214);
            this.Accent.Margin = new System.Windows.Forms.Padding(0);
            this.Accent.Name = "Accent";
            this.Accent.Size = new System.Drawing.Size(150, 50);
            this.Accent.TabIndex = 76;
            this.Accent.Text = "Unavailable";
            this.Accent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BrightAccent
            // 
            this.BrightAccent.BackColor = System.Drawing.Color.Transparent;
            this.BrightAccent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrightAccent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.BrightAccent.Location = new System.Drawing.Point(371, 163);
            this.BrightAccent.Margin = new System.Windows.Forms.Padding(0);
            this.BrightAccent.Name = "BrightAccent";
            this.BrightAccent.Size = new System.Drawing.Size(150, 50);
            this.BrightAccent.TabIndex = 75;
            this.BrightAccent.Text = "Unavailable";
            this.BrightAccent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BackgroundLabel
            // 
            this.BackgroundLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackgroundLabel.Location = new System.Drawing.Point(45, 470);
            this.BackgroundLabel.Margin = new System.Windows.Forms.Padding(0);
            this.BackgroundLabel.Name = "BackgroundLabel";
            this.BackgroundLabel.Size = new System.Drawing.Size(179, 50);
            this.BackgroundLabel.TabIndex = 74;
            this.BackgroundLabel.Text = "Background";
            this.BackgroundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelLabel
            // 
            this.PanelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelLabel.Location = new System.Drawing.Point(45, 419);
            this.PanelLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PanelLabel.Name = "PanelLabel";
            this.PanelLabel.Size = new System.Drawing.Size(179, 50);
            this.PanelLabel.TabIndex = 73;
            this.PanelLabel.Text = "Panel";
            this.PanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InactiveLabel
            // 
            this.InactiveLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InactiveLabel.Location = new System.Drawing.Point(45, 368);
            this.InactiveLabel.Margin = new System.Windows.Forms.Padding(0);
            this.InactiveLabel.Name = "InactiveLabel";
            this.InactiveLabel.Size = new System.Drawing.Size(179, 50);
            this.InactiveLabel.TabIndex = 72;
            this.InactiveLabel.Text = "Inactive";
            this.InactiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DarkAccentLabel
            // 
            this.DarkAccentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DarkAccentLabel.Location = new System.Drawing.Point(45, 265);
            this.DarkAccentLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DarkAccentLabel.Name = "DarkAccentLabel";
            this.DarkAccentLabel.Size = new System.Drawing.Size(179, 50);
            this.DarkAccentLabel.TabIndex = 71;
            this.DarkAccentLabel.Text = "Dark Accent";
            this.DarkAccentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AccentLabel
            // 
            this.AccentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccentLabel.Location = new System.Drawing.Point(45, 214);
            this.AccentLabel.Margin = new System.Windows.Forms.Padding(0);
            this.AccentLabel.Name = "AccentLabel";
            this.AccentLabel.Size = new System.Drawing.Size(179, 50);
            this.AccentLabel.TabIndex = 70;
            this.AccentLabel.Text = "Accent";
            this.AccentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BrightAccentLabel
            // 
            this.BrightAccentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrightAccentLabel.Location = new System.Drawing.Point(45, 163);
            this.BrightAccentLabel.Margin = new System.Windows.Forms.Padding(0);
            this.BrightAccentLabel.Name = "BrightAccentLabel";
            this.BrightAccentLabel.Size = new System.Drawing.Size(179, 50);
            this.BrightAccentLabel.TabIndex = 69;
            this.BrightAccentLabel.Text = "Bright Accent";
            this.BrightAccentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelPanel
            // 
            this.PanelPanel.BackColor = System.Drawing.Color.Transparent;
            this.PanelPanel.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.PanelPanel.Location = new System.Drawing.Point(531, 423);
            this.PanelPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PanelPanel.Name = "PanelPanel";
            this.PanelPanel.rounding = 5;
            this.PanelPanel.Size = new System.Drawing.Size(40, 40);
            this.PanelPanel.TabIndex = 68;
            // 
            // InactivePanel
            // 
            this.InactivePanel.BackColor = System.Drawing.Color.Transparent;
            this.InactivePanel.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.InactivePanel.Location = new System.Drawing.Point(531, 372);
            this.InactivePanel.Margin = new System.Windows.Forms.Padding(0);
            this.InactivePanel.Name = "InactivePanel";
            this.InactivePanel.rounding = 5;
            this.InactivePanel.Size = new System.Drawing.Size(40, 40);
            this.InactivePanel.TabIndex = 68;
            // 
            // DarkAccentPanel
            // 
            this.DarkAccentPanel.BackColor = System.Drawing.Color.Transparent;
            this.DarkAccentPanel.color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.DarkAccentPanel.Location = new System.Drawing.Point(531, 269);
            this.DarkAccentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DarkAccentPanel.Name = "DarkAccentPanel";
            this.DarkAccentPanel.rounding = 5;
            this.DarkAccentPanel.Size = new System.Drawing.Size(40, 40);
            this.DarkAccentPanel.TabIndex = 68;
            // 
            // AccentPanel
            // 
            this.AccentPanel.BackColor = System.Drawing.Color.Transparent;
            this.AccentPanel.color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.AccentPanel.Location = new System.Drawing.Point(531, 218);
            this.AccentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.AccentPanel.Name = "AccentPanel";
            this.AccentPanel.rounding = 5;
            this.AccentPanel.Size = new System.Drawing.Size(40, 40);
            this.AccentPanel.TabIndex = 68;
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundPanel.color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundPanel.Location = new System.Drawing.Point(531, 474);
            this.BackgroundPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.rounding = 5;
            this.BackgroundPanel.Size = new System.Drawing.Size(40, 40);
            this.BackgroundPanel.TabIndex = 66;
            // 
            // BrightAccentPanel
            // 
            this.BrightAccentPanel.BackColor = System.Drawing.Color.Transparent;
            this.BrightAccentPanel.color = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.BrightAccentPanel.Location = new System.Drawing.Point(531, 168);
            this.BrightAccentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BrightAccentPanel.Name = "BrightAccentPanel";
            this.BrightAccentPanel.rounding = 5;
            this.BrightAccentPanel.Size = new System.Drawing.Size(40, 40);
            this.BrightAccentPanel.TabIndex = 67;
            // 
            // Transparency
            // 
            this.Transparency.BackColor = System.Drawing.Color.Transparent;
            this.Transparency.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transparency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Transparency.Location = new System.Drawing.Point(420, 112);
            this.Transparency.Margin = new System.Windows.Forms.Padding(0);
            this.Transparency.Name = "Transparency";
            this.Transparency.Size = new System.Drawing.Size(150, 50);
            this.Transparency.TabIndex = 50;
            this.Transparency.Text = "Unavailable";
            this.Transparency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ThemeMode
            // 
            this.ThemeMode.BackColor = System.Drawing.Color.Transparent;
            this.ThemeMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ThemeMode.Location = new System.Drawing.Point(420, 61);
            this.ThemeMode.Margin = new System.Windows.Forms.Padding(0);
            this.ThemeMode.Name = "ThemeMode";
            this.ThemeMode.Size = new System.Drawing.Size(150, 50);
            this.ThemeMode.TabIndex = 49;
            this.ThemeMode.Text = "Unavailable";
            this.ThemeMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TransparencyLabel
            // 
            this.TransparencyLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransparencyLabel.Location = new System.Drawing.Point(45, 112);
            this.TransparencyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TransparencyLabel.Name = "TransparencyLabel";
            this.TransparencyLabel.Size = new System.Drawing.Size(179, 50);
            this.TransparencyLabel.TabIndex = 12;
            this.TransparencyLabel.Text = "Transparency";
            this.TransparencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ThemeModeLabel
            // 
            this.ThemeModeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeModeLabel.Location = new System.Drawing.Point(45, 61);
            this.ThemeModeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ThemeModeLabel.Name = "ThemeModeLabel";
            this.ThemeModeLabel.Size = new System.Drawing.Size(179, 50);
            this.ThemeModeLabel.TabIndex = 3;
            this.ThemeModeLabel.Text = "Theme mode";
            this.ThemeModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // collapsiblePanel3
            // 
            this.collapsiblePanel3.BackColor = System.Drawing.Color.Transparent;
            this.collapsiblePanel3.Collapsed = false;
            this.collapsiblePanel3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.collapsiblePanel3.Controls.Add(this.SaveButton);
            this.collapsiblePanel3.Controls.Add(this.label2);
            this.collapsiblePanel3.Controls.Add(this.roundedPanel1);
            this.collapsiblePanel3.Icon = "";
            this.collapsiblePanel3.Location = new System.Drawing.Point(10, 80);
            this.collapsiblePanel3.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.collapsiblePanel3.MaximumSize = new System.Drawing.Size(580, 315);
            this.collapsiblePanel3.Name = "collapsiblePanel3";
            this.collapsiblePanel3.PanelText = "Logs";
            this.collapsiblePanel3.Rounding = 5;
            this.collapsiblePanel3.Separators = 0;
            this.collapsiblePanel3.Size = new System.Drawing.Size(580, 315);
            this.collapsiblePanel3.TabIndex = 16;
            this.collapsiblePanel3.Text = "Logs";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.ButtonText = "Save";
            this.SaveButton.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.SaveButton.Location = new System.Drawing.Point(470, 271);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Rounding = 5;
            this.SaveButton.Size = new System.Drawing.Size(100, 30);
            this.SaveButton.TabIndex = 45;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 30);
            this.label2.TabIndex = 33;
            this.label2.Text = "Save log to desktop";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.color = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.roundedPanel1.Controls.Add(this.LogTextBox);
            this.roundedPanel1.Location = new System.Drawing.Point(10, 71);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.rounding = 5;
            this.roundedPanel1.Size = new System.Drawing.Size(560, 184);
            this.roundedPanel1.TabIndex = 27;
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.LogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogTextBox.ForeColor = System.Drawing.Color.White;
            this.LogTextBox.Location = new System.Drawing.Point(5, 5);
            this.LogTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.Size = new System.Drawing.Size(551, 174);
            this.LogTextBox.TabIndex = 10;
            // 
            // collapsiblePanel4
            // 
            this.collapsiblePanel4.BackColor = System.Drawing.Color.Transparent;
            this.collapsiblePanel4.Collapsed = true;
            this.collapsiblePanel4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.collapsiblePanel4.Controls.Add(this.AdvancedOCToggle);
            this.collapsiblePanel4.Controls.Add(this.AdvancedOCLabel);
            this.collapsiblePanel4.Icon = "";
            this.collapsiblePanel4.Location = new System.Drawing.Point(10, 405);
            this.collapsiblePanel4.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.collapsiblePanel4.Name = "collapsiblePanel4";
            this.collapsiblePanel4.PanelText = "Experimental";
            this.collapsiblePanel4.Rounding = 5;
            this.collapsiblePanel4.Separators = 1;
            this.collapsiblePanel4.Size = new System.Drawing.Size(581, 60);
            this.collapsiblePanel4.TabIndex = 17;
            this.collapsiblePanel4.Text = "Experimental";
            // 
            // AdvancedOCToggle
            // 
            this.AdvancedOCToggle.BackColor = System.Drawing.Color.Transparent;
            this.AdvancedOCToggle.Location = new System.Drawing.Point(530, 76);
            this.AdvancedOCToggle.Margin = new System.Windows.Forms.Padding(0);
            this.AdvancedOCToggle.MaximumSize = new System.Drawing.Size(40, 20);
            this.AdvancedOCToggle.MinimumSize = new System.Drawing.Size(40, 20);
            this.AdvancedOCToggle.Name = "AdvancedOCToggle";
            this.AdvancedOCToggle.Size = new System.Drawing.Size(40, 20);
            this.AdvancedOCToggle.TabIndex = 19;
            this.AdvancedOCToggle.Toggled = false;
            this.AdvancedOCToggle.ToggledEvent += new System.EventHandler(this.AdvancedOCToggle_ToggledEvent);
            // 
            // AdvancedOCLabel
            // 
            this.AdvancedOCLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdvancedOCLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvancedOCLabel.Location = new System.Drawing.Point(45, 61);
            this.AdvancedOCLabel.Name = "AdvancedOCLabel";
            this.AdvancedOCLabel.Size = new System.Drawing.Size(179, 50);
            this.AdvancedOCLabel.TabIndex = 18;
            this.AdvancedOCLabel.Text = "Advanced overclocking";
            this.AdvancedOCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Debugger
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(600, 506);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.TitleBar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Debugger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Debugger";
            this.Load += new System.EventHandler(this.Debugger_Load);
            this.TitleBar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.collapsiblePanel2.ResumeLayout(false);
            this.collapsiblePanel3.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.collapsiblePanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label ThemeModeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Timer LogUpdater;
        private System.Windows.Forms.Label TransparencyLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomUI.CollapsiblePanel collapsiblePanel2;
        private System.Windows.Forms.Label Transparency;
        private System.Windows.Forms.Label ThemeMode;
        private CustomUI.CollapsiblePanel collapsiblePanel3;
        private RoundedPanel PanelPanel;
        private RoundedPanel InactivePanel;
        private RoundedPanel DarkAccentPanel;
        private RoundedPanel AccentPanel;
        private RoundedPanel BackgroundPanel;
        private RoundedPanel BrightAccentPanel;
        private System.Windows.Forms.Label BackgroundLabel;
        private System.Windows.Forms.Label PanelLabel;
        private System.Windows.Forms.Label InactiveLabel;
        private System.Windows.Forms.Label DarkAccentLabel;
        private System.Windows.Forms.Label AccentLabel;
        private System.Windows.Forms.Label BrightAccentLabel;
        private System.Windows.Forms.Label Background;
        private System.Windows.Forms.Label Panel;
        private System.Windows.Forms.Label Inactive;
        private System.Windows.Forms.Label DarkAccent;
        private System.Windows.Forms.Label Accent;
        private System.Windows.Forms.Label BrightAccent;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label2;
        private CustomUI.CollapsiblePanel collapsiblePanel4;
        private CustomUI.Toggle AdvancedOCToggle;
        private System.Windows.Forms.Label AdvancedOCLabel;
        private System.Windows.Forms.Label BrightPanel;
        private System.Windows.Forms.Label BrightPanelLabel;
        private RoundedPanel BrightPanelPanel;
        private RoundedButton SaveButton;
    }
}