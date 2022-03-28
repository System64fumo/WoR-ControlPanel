
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
            this.collapsiblePanel2 = new WoRCP.UI.CollapsiblePanel();
            this.BrightPanel = new System.Windows.Forms.Label();
            this.BrightPanelPanel = new WoRCP.UI.RoundedPanel();
            this.Background = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Label();
            this.Inactive = new System.Windows.Forms.Label();
            this.DarkAccent = new System.Windows.Forms.Label();
            this.Accent = new System.Windows.Forms.Label();
            this.BrightAccent = new System.Windows.Forms.Label();
            this.PanelPanel = new WoRCP.UI.RoundedPanel();
            this.InactivePanel = new WoRCP.UI.RoundedPanel();
            this.DarkAccentPanel = new WoRCP.UI.RoundedPanel();
            this.AccentPanel = new WoRCP.UI.RoundedPanel();
            this.BackgroundPanel = new WoRCP.UI.RoundedPanel();
            this.BrightAccentPanel = new WoRCP.UI.RoundedPanel();
            this.Transparency = new System.Windows.Forms.Label();
            this.ThemeMode = new System.Windows.Forms.Label();
            this.collapsiblePanel3 = new WoRCP.UI.CollapsiblePanel();
            this.SaveButton = new WoRCP.UI.RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new WoRCP.UI.RoundedPanel();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.collapsiblePanel4 = new WoRCP.UI.CollapsiblePanel();
            this.AdvancedOCToggle = new WoRCP.UI.Toggle();
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
            this.collapsiblePanel2.Controls.Add(this.BrightPanelPanel);
            this.collapsiblePanel2.Controls.Add(this.Background);
            this.collapsiblePanel2.Controls.Add(this.Panel);
            this.collapsiblePanel2.Controls.Add(this.Inactive);
            this.collapsiblePanel2.Controls.Add(this.DarkAccent);
            this.collapsiblePanel2.Controls.Add(this.Accent);
            this.collapsiblePanel2.Controls.Add(this.BrightAccent);
            this.collapsiblePanel2.Controls.Add(this.PanelPanel);
            this.collapsiblePanel2.Controls.Add(this.InactivePanel);
            this.collapsiblePanel2.Controls.Add(this.DarkAccentPanel);
            this.collapsiblePanel2.Controls.Add(this.AccentPanel);
            this.collapsiblePanel2.Controls.Add(this.BackgroundPanel);
            this.collapsiblePanel2.Controls.Add(this.BrightAccentPanel);
            this.collapsiblePanel2.Controls.Add(this.Transparency);
            this.collapsiblePanel2.Controls.Add(this.ThemeMode);
            this.collapsiblePanel2.Icon = "";
            this.collapsiblePanel2.LeftContent = new string[] {
        "Light mode",
        "Transperancy",
        "Bright Accent",
        "Accent",
        "Dark Accent",
        "Bright Panel",
        "Inactive",
        "Panel",
        "Background"};
            this.collapsiblePanel2.Location = new System.Drawing.Point(10, 10);
            this.collapsiblePanel2.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.collapsiblePanel2.Name = "collapsiblePanel2";
            this.collapsiblePanel2.RightContent = new string[0];
            this.collapsiblePanel2.Rounding = 5;
            this.collapsiblePanel2.Size = new System.Drawing.Size(580, 60);
            this.collapsiblePanel2.TabIndex = 15;
            this.collapsiblePanel2.Text = "Theme";
            this.collapsiblePanel2.Title = "Theme";
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
            // collapsiblePanel3
            // 
            this.collapsiblePanel3.BackColor = System.Drawing.Color.Transparent;
            this.collapsiblePanel3.Collapsed = false;
            this.collapsiblePanel3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.collapsiblePanel3.Controls.Add(this.SaveButton);
            this.collapsiblePanel3.Controls.Add(this.label2);
            this.collapsiblePanel3.Controls.Add(this.roundedPanel1);
            this.collapsiblePanel3.Icon = "";
            this.collapsiblePanel3.LeftContent = new string[0];
            this.collapsiblePanel3.Location = new System.Drawing.Point(10, 80);
            this.collapsiblePanel3.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.collapsiblePanel3.MaximumSize = new System.Drawing.Size(580, 315);
            this.collapsiblePanel3.Name = "collapsiblePanel3";
            this.collapsiblePanel3.RightContent = new string[0];
            this.collapsiblePanel3.Rounding = 5;
            this.collapsiblePanel3.Size = new System.Drawing.Size(580, 315);
            this.collapsiblePanel3.TabIndex = 16;
            this.collapsiblePanel3.Text = "Logs";
            this.collapsiblePanel3.Title = "Logs";
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
            this.collapsiblePanel4.Icon = "";
            this.collapsiblePanel4.LeftContent = new string[] {
        "Advanced overclocking"};
            this.collapsiblePanel4.Location = new System.Drawing.Point(10, 405);
            this.collapsiblePanel4.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.collapsiblePanel4.Name = "collapsiblePanel4";
            this.collapsiblePanel4.RightContent = new string[0];
            this.collapsiblePanel4.Rounding = 5;
            this.collapsiblePanel4.Size = new System.Drawing.Size(581, 60);
            this.collapsiblePanel4.TabIndex = 17;
            this.collapsiblePanel4.Text = "Experimental";
            this.collapsiblePanel4.Title = "Experimental";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Timer LogUpdater;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private WoRCP.UI.CollapsiblePanel collapsiblePanel2;
        private System.Windows.Forms.Label Transparency;
        private System.Windows.Forms.Label ThemeMode;
        private WoRCP.UI.CollapsiblePanel collapsiblePanel3;
        private WoRCP.UI.RoundedPanel PanelPanel;
        private WoRCP.UI.RoundedPanel InactivePanel;
        private WoRCP.UI.RoundedPanel DarkAccentPanel;
        private WoRCP.UI.RoundedPanel AccentPanel;
        private WoRCP.UI.RoundedPanel BackgroundPanel;
        private WoRCP.UI.RoundedPanel BrightAccentPanel;
        private System.Windows.Forms.Label Background;
        private System.Windows.Forms.Label Panel;
        private System.Windows.Forms.Label Inactive;
        private System.Windows.Forms.Label DarkAccent;
        private System.Windows.Forms.Label Accent;
        private System.Windows.Forms.Label BrightAccent;
        private WoRCP.UI.RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label2;
        private WoRCP.UI.CollapsiblePanel collapsiblePanel4;
        private WoRCP.UI.Toggle AdvancedOCToggle;
        private System.Windows.Forms.Label BrightPanel;
        private WoRCP.UI.RoundedPanel BrightPanelPanel;
        private WoRCP.UI.RoundedButton SaveButton;
    }
}