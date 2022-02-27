
namespace WoRCP.Tabs
{
    partial class Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new WoRCP.RoundedPanel();
            this.roundedPanel3 = new WoRCP.RoundedPanel();
            this.Config = new System.Windows.Forms.TextBox();
            this.roundedPanel2 = new WoRCP.RoundedPanel();
            this.SaveButton = new WoRCP.RoundedButton();
            this.DefaultsButton = new WoRCP.RoundedButton();
            this.RefreshButton = new WoRCP.RoundedButton();
            this.Issues = new System.Windows.Forms.Label();
            this.IssuesIcon = new System.Windows.Forms.Label();
            this.PiLabel = new System.Windows.Forms.Label();
            this.BootPartitionPanel = new WoRCP.RoundedPanel();
            this.MountButton = new WoRCP.RoundedButton();
            this.BootMessageLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OverclockingPanel = new WoRCP.CustomUI.CollapsiblePanel();
            this.CPUFreq = new System.Windows.Forms.Label();
            this.ForceTurboToggle = new WoRCP.CustomUI.Toggle();
            this.ForceTurbo = new System.Windows.Forms.Label();
            this.Overvoltage = new System.Windows.Forms.Label();
            this.GPUMem = new System.Windows.Forms.Label();
            this.GPUFreq = new System.Windows.Forms.Label();
            this.OvervoltageSlider = new WoRCP.Slider();
            this.GPUMemSlider = new WoRCP.Slider();
            this.GPUFreqSlider = new WoRCP.Slider();
            this.CPUSlider = new WoRCP.Slider();
            this.ForceTurboLabel = new System.Windows.Forms.Label();
            this.OvervoltageLabel = new System.Windows.Forms.Label();
            this.GPUMemLabel = new System.Windows.Forms.Label();
            this.GPUFreqLabel = new System.Windows.Forms.Label();
            this.CPUFreqLabel = new System.Windows.Forms.Label();
            this.DisplayPanel = new WoRCP.CustomUI.CollapsiblePanel();
            this.Desktop = new System.Windows.Forms.Panel();
            this.ResolutionListPanel = new WoRCP.RoundedPanel();
            this.ResolutionList = new System.Windows.Forms.FlowLayoutPanel();
            this.HotplugToggle = new WoRCP.CustomUI.Toggle();
            this.HotplugState = new System.Windows.Forms.Label();
            this.HotplugLabel = new System.Windows.Forms.Label();
            this.OverscanState = new System.Windows.Forms.Label();
            this.OverscanToggle = new WoRCP.CustomUI.Toggle();
            this.OverscanLabel = new System.Windows.Forms.Label();
            this.OtherPanel = new WoRCP.CustomUI.CollapsiblePanel();
            this.ConfigDocsButton = new WoRCP.RoundedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfigEditorButton = new WoRCP.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.BootPartitionPanel.SuspendLayout();
            this.OverclockingPanel.SuspendLayout();
            this.DisplayPanel.SuspendLayout();
            this.ResolutionListPanel.SuspendLayout();
            this.OtherPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.OverclockingPanel);
            this.flowLayoutPanel1.Controls.Add(this.DisplayPanel);
            this.flowLayoutPanel1.Controls.Add(this.OtherPanel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(681, 470);
            this.flowLayoutPanel1.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roundedPanel1);
            this.panel1.Controls.Add(this.BootPartitionPanel);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 242);
            this.panel1.TabIndex = 72;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.roundedPanel1.Controls.Add(this.roundedPanel3);
            this.roundedPanel1.Controls.Add(this.roundedPanel2);
            this.roundedPanel1.Controls.Add(this.Issues);
            this.roundedPanel1.Controls.Add(this.IssuesIcon);
            this.roundedPanel1.Controls.Add(this.PiLabel);
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.rounding = 5;
            this.roundedPanel1.Size = new System.Drawing.Size(440, 240);
            this.roundedPanel1.TabIndex = 66;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel3.color = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.roundedPanel3.Controls.Add(this.Config);
            this.roundedPanel3.Location = new System.Drawing.Point(10, 50);
            this.roundedPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.rounding = 5;
            this.roundedPanel3.Size = new System.Drawing.Size(420, 150);
            this.roundedPanel3.TabIndex = 78;
            // 
            // Config
            // 
            this.Config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.Config.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Config.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Config.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Config.Location = new System.Drawing.Point(5, 5);
            this.Config.Multiline = true;
            this.Config.Name = "Config";
            this.Config.ReadOnly = true;
            this.Config.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Config.Size = new System.Drawing.Size(432, 140);
            this.Config.TabIndex = 74;
            this.Config.Text = "Your config.txt will be shown here once you mount your boot partition";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel2.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.roundedPanel2.Controls.Add(this.SaveButton);
            this.roundedPanel2.Controls.Add(this.DefaultsButton);
            this.roundedPanel2.Controls.Add(this.RefreshButton);
            this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roundedPanel2.Location = new System.Drawing.Point(0, 210);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.rounding = 5;
            this.roundedPanel2.Size = new System.Drawing.Size(440, 30);
            this.roundedPanel2.TabIndex = 77;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.ButtonText = "Save";
            this.SaveButton.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveButton.Location = new System.Drawing.Point(0, 0);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Rounding = 5;
            this.SaveButton.Size = new System.Drawing.Size(146, 30);
            this.SaveButton.TabIndex = 74;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DefaultsButton
            // 
            this.DefaultsButton.BackColor = System.Drawing.Color.Transparent;
            this.DefaultsButton.ButtonText = "Defaults";
            this.DefaultsButton.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.DefaultsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DefaultsButton.Location = new System.Drawing.Point(294, 0);
            this.DefaultsButton.Margin = new System.Windows.Forms.Padding(0);
            this.DefaultsButton.Name = "DefaultsButton";
            this.DefaultsButton.Rounding = 5;
            this.DefaultsButton.Size = new System.Drawing.Size(146, 30);
            this.DefaultsButton.TabIndex = 76;
            this.DefaultsButton.Click += new System.EventHandler(this.DefaultsButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.ButtonText = "Refresh";
            this.RefreshButton.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.RefreshButton.Location = new System.Drawing.Point(145, 0);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Rounding = 5;
            this.RefreshButton.Size = new System.Drawing.Size(150, 30);
            this.RefreshButton.TabIndex = 75;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Issues
            // 
            this.Issues.AutoSize = true;
            this.Issues.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Issues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Issues.Location = new System.Drawing.Point(40, 27);
            this.Issues.Margin = new System.Windows.Forms.Padding(0);
            this.Issues.Name = "Issues";
            this.Issues.Size = new System.Drawing.Size(92, 15);
            this.Issues.TabIndex = 72;
            this.Issues.Text = "No issues found";
            // 
            // IssuesIcon
            // 
            this.IssuesIcon.Font = new System.Drawing.Font("Segoe Fluent Icons", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssuesIcon.ForeColor = System.Drawing.Color.White;
            this.IssuesIcon.Location = new System.Drawing.Point(10, 10);
            this.IssuesIcon.Margin = new System.Windows.Forms.Padding(0);
            this.IssuesIcon.Name = "IssuesIcon";
            this.IssuesIcon.Size = new System.Drawing.Size(30, 30);
            this.IssuesIcon.TabIndex = 71;
            this.IssuesIcon.Text = "";
            this.IssuesIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PiLabel
            // 
            this.PiLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PiLabel.Location = new System.Drawing.Point(40, 10);
            this.PiLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PiLabel.Name = "PiLabel";
            this.PiLabel.Size = new System.Drawing.Size(257, 30);
            this.PiLabel.TabIndex = 70;
            this.PiLabel.Text = "Your Pi is running at stock speeds";
            // 
            // BootPartitionPanel
            // 
            this.BootPartitionPanel.BackColor = System.Drawing.Color.Transparent;
            this.BootPartitionPanel.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.BootPartitionPanel.Controls.Add(this.MountButton);
            this.BootPartitionPanel.Controls.Add(this.BootMessageLabel);
            this.BootPartitionPanel.Controls.Add(this.label2);
            this.BootPartitionPanel.Controls.Add(this.label5);
            this.BootPartitionPanel.Location = new System.Drawing.Point(450, 1);
            this.BootPartitionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BootPartitionPanel.Name = "BootPartitionPanel";
            this.BootPartitionPanel.rounding = 5;
            this.BootPartitionPanel.Size = new System.Drawing.Size(190, 240);
            this.BootPartitionPanel.TabIndex = 67;
            // 
            // MountButton
            // 
            this.MountButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MountButton.BackColor = System.Drawing.Color.Transparent;
            this.MountButton.ButtonText = "Mount";
            this.MountButton.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.MountButton.Location = new System.Drawing.Point(10, 201);
            this.MountButton.Margin = new System.Windows.Forms.Padding(0);
            this.MountButton.Name = "MountButton";
            this.MountButton.Rounding = 5;
            this.MountButton.Size = new System.Drawing.Size(170, 31);
            this.MountButton.TabIndex = 73;
            this.MountButton.Click += new System.EventHandler(this.MountButton_Click);
            // 
            // BootMessageLabel
            // 
            this.BootMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BootMessageLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BootMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.BootMessageLabel.Location = new System.Drawing.Point(0, 120);
            this.BootMessageLabel.Name = "BootMessageLabel";
            this.BootMessageLabel.Size = new System.Drawing.Size(190, 70);
            this.BootMessageLabel.TabIndex = 71;
            this.BootMessageLabel.Text = "Please mount your boot partition\r\nto be able to overclock";
            this.BootMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 30);
            this.label2.TabIndex = 70;
            this.label2.Text = "Boot partition";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Segoe Fluent Icons", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 70);
            this.label5.TabIndex = 69;
            this.label5.Text = "";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OverclockingPanel
            // 
            this.OverclockingPanel.BackColor = System.Drawing.Color.Transparent;
            this.OverclockingPanel.Collapsed = true;
            this.OverclockingPanel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.OverclockingPanel.Controls.Add(this.CPUFreq);
            this.OverclockingPanel.Controls.Add(this.ForceTurboToggle);
            this.OverclockingPanel.Controls.Add(this.ForceTurbo);
            this.OverclockingPanel.Controls.Add(this.Overvoltage);
            this.OverclockingPanel.Controls.Add(this.GPUMem);
            this.OverclockingPanel.Controls.Add(this.GPUFreq);
            this.OverclockingPanel.Controls.Add(this.OvervoltageSlider);
            this.OverclockingPanel.Controls.Add(this.GPUMemSlider);
            this.OverclockingPanel.Controls.Add(this.GPUFreqSlider);
            this.OverclockingPanel.Controls.Add(this.CPUSlider);
            this.OverclockingPanel.Controls.Add(this.ForceTurboLabel);
            this.OverclockingPanel.Controls.Add(this.OvervoltageLabel);
            this.OverclockingPanel.Controls.Add(this.GPUMemLabel);
            this.OverclockingPanel.Controls.Add(this.GPUFreqLabel);
            this.OverclockingPanel.Controls.Add(this.CPUFreqLabel);
            this.OverclockingPanel.Enabled = false;
            this.OverclockingPanel.Icon = "";
            this.OverclockingPanel.Location = new System.Drawing.Point(10, 262);
            this.OverclockingPanel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.OverclockingPanel.Name = "OverclockingPanel";
            this.OverclockingPanel.PanelText = "Overclocking";
            this.OverclockingPanel.Rounding = 5;
            this.OverclockingPanel.Separators = 5;
            this.OverclockingPanel.Size = new System.Drawing.Size(640, 60);
            this.OverclockingPanel.TabIndex = 60;
            this.OverclockingPanel.Text = "Overclocking";
            // 
            // CPUFreq
            // 
            this.CPUFreq.BackColor = System.Drawing.Color.Transparent;
            this.CPUFreq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUFreq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.CPUFreq.Location = new System.Drawing.Point(277, 62);
            this.CPUFreq.Margin = new System.Windows.Forms.Padding(0);
            this.CPUFreq.Name = "CPUFreq";
            this.CPUFreq.Size = new System.Drawing.Size(150, 50);
            this.CPUFreq.TabIndex = 37;
            this.CPUFreq.Text = "1.5GHz";
            this.CPUFreq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ForceTurboToggle
            // 
            this.ForceTurboToggle.BackColor = System.Drawing.Color.Transparent;
            this.ForceTurboToggle.Enabled = false;
            this.ForceTurboToggle.Location = new System.Drawing.Point(590, 279);
            this.ForceTurboToggle.Margin = new System.Windows.Forms.Padding(0);
            this.ForceTurboToggle.MaximumSize = new System.Drawing.Size(40, 20);
            this.ForceTurboToggle.MinimumSize = new System.Drawing.Size(40, 20);
            this.ForceTurboToggle.Name = "ForceTurboToggle";
            this.ForceTurboToggle.Size = new System.Drawing.Size(40, 20);
            this.ForceTurboToggle.TabIndex = 31;
            this.ForceTurboToggle.Toggled = false;
            this.ForceTurboToggle.ToggledEvent += new System.EventHandler(this.ForceTurboToggle_ToggledEvent);
            // 
            // ForceTurbo
            // 
            this.ForceTurbo.BackColor = System.Drawing.Color.Transparent;
            this.ForceTurbo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForceTurbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ForceTurbo.Location = new System.Drawing.Point(430, 265);
            this.ForceTurbo.Margin = new System.Windows.Forms.Padding(0);
            this.ForceTurbo.Name = "ForceTurbo";
            this.ForceTurbo.Size = new System.Drawing.Size(150, 49);
            this.ForceTurbo.TabIndex = 25;
            this.ForceTurbo.Text = "Disabled";
            this.ForceTurbo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Overvoltage
            // 
            this.Overvoltage.BackColor = System.Drawing.Color.Transparent;
            this.Overvoltage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overvoltage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Overvoltage.Location = new System.Drawing.Point(277, 214);
            this.Overvoltage.Margin = new System.Windows.Forms.Padding(0);
            this.Overvoltage.Name = "Overvoltage";
            this.Overvoltage.Size = new System.Drawing.Size(150, 50);
            this.Overvoltage.TabIndex = 24;
            this.Overvoltage.Text = "0";
            this.Overvoltage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPUMem
            // 
            this.GPUMem.BackColor = System.Drawing.Color.Transparent;
            this.GPUMem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.GPUMem.Location = new System.Drawing.Point(277, 163);
            this.GPUMem.Margin = new System.Windows.Forms.Padding(0);
            this.GPUMem.Name = "GPUMem";
            this.GPUMem.Size = new System.Drawing.Size(150, 50);
            this.GPUMem.TabIndex = 23;
            this.GPUMem.Text = "32 MB";
            this.GPUMem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPUFreq
            // 
            this.GPUFreq.BackColor = System.Drawing.Color.Transparent;
            this.GPUFreq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUFreq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.GPUFreq.Location = new System.Drawing.Point(277, 112);
            this.GPUFreq.Margin = new System.Windows.Forms.Padding(0);
            this.GPUFreq.Name = "GPUFreq";
            this.GPUFreq.Size = new System.Drawing.Size(150, 50);
            this.GPUFreq.TabIndex = 22;
            this.GPUFreq.Text = "500 MHz";
            this.GPUFreq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OvervoltageSlider
            // 
            this.OvervoltageSlider.BackColor = System.Drawing.Color.Transparent;
            this.OvervoltageSlider.Double = false;
            this.OvervoltageSlider.Enabled = false;
            this.OvervoltageSlider.Location = new System.Drawing.Point(430, 224);
            this.OvervoltageSlider.Margin = new System.Windows.Forms.Padding(0);
            this.OvervoltageSlider.MaximumSize = new System.Drawing.Size(1000, 30);
            this.OvervoltageSlider.MaxValue = 16D;
            this.OvervoltageSlider.MinimumSize = new System.Drawing.Size(100, 30);
            this.OvervoltageSlider.MinValue = -16D;
            this.OvervoltageSlider.Name = "OvervoltageSlider";
            this.OvervoltageSlider.Size = new System.Drawing.Size(200, 30);
            this.OvervoltageSlider.TabIndex = 20;
            this.OvervoltageSlider.Value = 0D;
            this.OvervoltageSlider.ValueP = 50D;
            this.OvervoltageSlider.Selecting += new System.EventHandler(this.OvervoltageSlider_Selecting);
            // 
            // GPUMemSlider
            // 
            this.GPUMemSlider.BackColor = System.Drawing.Color.Transparent;
            this.GPUMemSlider.Double = false;
            this.GPUMemSlider.Enabled = false;
            this.GPUMemSlider.Location = new System.Drawing.Point(430, 173);
            this.GPUMemSlider.Margin = new System.Windows.Forms.Padding(0);
            this.GPUMemSlider.MaximumSize = new System.Drawing.Size(1000, 30);
            this.GPUMemSlider.MaxValue = 16D;
            this.GPUMemSlider.MinimumSize = new System.Drawing.Size(100, 30);
            this.GPUMemSlider.MinValue = 1D;
            this.GPUMemSlider.Name = "GPUMemSlider";
            this.GPUMemSlider.Size = new System.Drawing.Size(200, 30);
            this.GPUMemSlider.TabIndex = 19;
            this.GPUMemSlider.Value = 1D;
            this.GPUMemSlider.ValueP = 0D;
            this.GPUMemSlider.Selecting += new System.EventHandler(this.GPUMemSlider_Selecting);
            // 
            // GPUFreqSlider
            // 
            this.GPUFreqSlider.BackColor = System.Drawing.Color.Transparent;
            this.GPUFreqSlider.Double = false;
            this.GPUFreqSlider.Enabled = false;
            this.GPUFreqSlider.Location = new System.Drawing.Point(430, 122);
            this.GPUFreqSlider.Margin = new System.Windows.Forms.Padding(0);
            this.GPUFreqSlider.MaximumSize = new System.Drawing.Size(1000, 30);
            this.GPUFreqSlider.MaxValue = 10D;
            this.GPUFreqSlider.MinimumSize = new System.Drawing.Size(100, 30);
            this.GPUFreqSlider.MinValue = 0D;
            this.GPUFreqSlider.Name = "GPUFreqSlider";
            this.GPUFreqSlider.Size = new System.Drawing.Size(200, 30);
            this.GPUFreqSlider.TabIndex = 18;
            this.GPUFreqSlider.Value = 5D;
            this.GPUFreqSlider.ValueP = 50D;
            this.GPUFreqSlider.Selecting += new System.EventHandler(this.GPUFreqSlider_Selecting);
            // 
            // CPUSlider
            // 
            this.CPUSlider.BackColor = System.Drawing.Color.Transparent;
            this.CPUSlider.Double = true;
            this.CPUSlider.Location = new System.Drawing.Point(430, 71);
            this.CPUSlider.Margin = new System.Windows.Forms.Padding(0);
            this.CPUSlider.MaximumSize = new System.Drawing.Size(1000, 30);
            this.CPUSlider.MaxValue = 2.4D;
            this.CPUSlider.MinimumSize = new System.Drawing.Size(100, 30);
            this.CPUSlider.MinValue = 0.6D;
            this.CPUSlider.Name = "CPUSlider";
            this.CPUSlider.Size = new System.Drawing.Size(200, 30);
            this.CPUSlider.TabIndex = 17;
            this.CPUSlider.Value = 1.5D;
            this.CPUSlider.ValueP = 50D;
            this.CPUSlider.Selecting += new System.EventHandler(this.CPUSlider_Selecting);
            // 
            // ForceTurboLabel
            // 
            this.ForceTurboLabel.BackColor = System.Drawing.Color.Transparent;
            this.ForceTurboLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForceTurboLabel.Location = new System.Drawing.Point(45, 265);
            this.ForceTurboLabel.Name = "ForceTurboLabel";
            this.ForceTurboLabel.Size = new System.Drawing.Size(179, 50);
            this.ForceTurboLabel.TabIndex = 16;
            this.ForceTurboLabel.Text = "Force Turbo";
            this.ForceTurboLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OvervoltageLabel
            // 
            this.OvervoltageLabel.BackColor = System.Drawing.Color.Transparent;
            this.OvervoltageLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OvervoltageLabel.Location = new System.Drawing.Point(45, 214);
            this.OvervoltageLabel.Name = "OvervoltageLabel";
            this.OvervoltageLabel.Size = new System.Drawing.Size(179, 50);
            this.OvervoltageLabel.TabIndex = 15;
            this.OvervoltageLabel.Text = "Over Voltage";
            this.OvervoltageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GPUMemLabel
            // 
            this.GPUMemLabel.BackColor = System.Drawing.Color.Transparent;
            this.GPUMemLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUMemLabel.Location = new System.Drawing.Point(45, 163);
            this.GPUMemLabel.Name = "GPUMemLabel";
            this.GPUMemLabel.Size = new System.Drawing.Size(179, 50);
            this.GPUMemLabel.TabIndex = 5;
            this.GPUMemLabel.Text = "GPU Memory";
            this.GPUMemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GPUFreqLabel
            // 
            this.GPUFreqLabel.BackColor = System.Drawing.Color.Transparent;
            this.GPUFreqLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUFreqLabel.Location = new System.Drawing.Point(45, 112);
            this.GPUFreqLabel.Name = "GPUFreqLabel";
            this.GPUFreqLabel.Size = new System.Drawing.Size(179, 50);
            this.GPUFreqLabel.TabIndex = 4;
            this.GPUFreqLabel.Text = "GPU Frequency";
            this.GPUFreqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUFreqLabel
            // 
            this.CPUFreqLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUFreqLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUFreqLabel.Location = new System.Drawing.Point(45, 61);
            this.CPUFreqLabel.Name = "CPUFreqLabel";
            this.CPUFreqLabel.Size = new System.Drawing.Size(179, 50);
            this.CPUFreqLabel.TabIndex = 1;
            this.CPUFreqLabel.Text = "CPU Frequency";
            this.CPUFreqLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.BackColor = System.Drawing.Color.Transparent;
            this.DisplayPanel.Collapsed = true;
            this.DisplayPanel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.DisplayPanel.Controls.Add(this.Desktop);
            this.DisplayPanel.Controls.Add(this.ResolutionListPanel);
            this.DisplayPanel.Controls.Add(this.HotplugToggle);
            this.DisplayPanel.Controls.Add(this.HotplugState);
            this.DisplayPanel.Controls.Add(this.HotplugLabel);
            this.DisplayPanel.Controls.Add(this.OverscanState);
            this.DisplayPanel.Controls.Add(this.OverscanToggle);
            this.DisplayPanel.Controls.Add(this.OverscanLabel);
            this.DisplayPanel.Enabled = false;
            this.DisplayPanel.Icon = "";
            this.DisplayPanel.Location = new System.Drawing.Point(10, 332);
            this.DisplayPanel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.DisplayPanel.MaximumSize = new System.Drawing.Size(640, 333);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.PanelText = "Display";
            this.DisplayPanel.Rounding = 5;
            this.DisplayPanel.Separators = 0;
            this.DisplayPanel.Size = new System.Drawing.Size(640, 60);
            this.DisplayPanel.TabIndex = 61;
            this.DisplayPanel.Text = "Display";
            // 
            // Desktop
            // 
            this.Desktop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Desktop.BackgroundImage")));
            this.Desktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Desktop.Location = new System.Drawing.Point(37, 62);
            this.Desktop.Name = "Desktop";
            this.Desktop.Size = new System.Drawing.Size(286, 160);
            this.Desktop.TabIndex = 0;
            // 
            // ResolutionListPanel
            // 
            this.ResolutionListPanel.BackColor = System.Drawing.Color.Transparent;
            this.ResolutionListPanel.color = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ResolutionListPanel.Controls.Add(this.ResolutionList);
            this.ResolutionListPanel.Location = new System.Drawing.Point(343, 62);
            this.ResolutionListPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ResolutionListPanel.Name = "ResolutionListPanel";
            this.ResolutionListPanel.rounding = 5;
            this.ResolutionListPanel.Size = new System.Drawing.Size(266, 160);
            this.ResolutionListPanel.TabIndex = 73;
            // 
            // ResolutionList
            // 
            this.ResolutionList.AutoScroll = true;
            this.ResolutionList.Location = new System.Drawing.Point(5, 5);
            this.ResolutionList.Margin = new System.Windows.Forms.Padding(0);
            this.ResolutionList.Name = "ResolutionList";
            this.ResolutionList.Size = new System.Drawing.Size(292, 150);
            this.ResolutionList.TabIndex = 0;
            // 
            // HotplugToggle
            // 
            this.HotplugToggle.BackColor = System.Drawing.Color.Transparent;
            this.HotplugToggle.Location = new System.Drawing.Point(569, 300);
            this.HotplugToggle.Margin = new System.Windows.Forms.Padding(0);
            this.HotplugToggle.MaximumSize = new System.Drawing.Size(40, 20);
            this.HotplugToggle.MinimumSize = new System.Drawing.Size(40, 20);
            this.HotplugToggle.Name = "HotplugToggle";
            this.HotplugToggle.Size = new System.Drawing.Size(40, 20);
            this.HotplugToggle.TabIndex = 29;
            this.HotplugToggle.Toggled = false;
            this.HotplugToggle.ToggledEvent += new System.EventHandler(this.HotplugToggle_ToggledEvent);
            // 
            // HotplugState
            // 
            this.HotplugState.BackColor = System.Drawing.Color.Transparent;
            this.HotplugState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotplugState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.HotplugState.Location = new System.Drawing.Point(409, 284);
            this.HotplugState.Margin = new System.Windows.Forms.Padding(0);
            this.HotplugState.Name = "HotplugState";
            this.HotplugState.Size = new System.Drawing.Size(150, 49);
            this.HotplugState.TabIndex = 28;
            this.HotplugState.Text = "Disabled";
            this.HotplugState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HotplugLabel
            // 
            this.HotplugLabel.BackColor = System.Drawing.Color.Transparent;
            this.HotplugLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotplugLabel.Location = new System.Drawing.Point(40, 283);
            this.HotplugLabel.Name = "HotplugLabel";
            this.HotplugLabel.Size = new System.Drawing.Size(179, 50);
            this.HotplugLabel.TabIndex = 27;
            this.HotplugLabel.Text = "Hotplug";
            this.HotplugLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OverscanState
            // 
            this.OverscanState.BackColor = System.Drawing.Color.Transparent;
            this.OverscanState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverscanState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.OverscanState.Location = new System.Drawing.Point(409, 233);
            this.OverscanState.Margin = new System.Windows.Forms.Padding(0);
            this.OverscanState.Name = "OverscanState";
            this.OverscanState.Size = new System.Drawing.Size(150, 49);
            this.OverscanState.TabIndex = 26;
            this.OverscanState.Text = "Disabled";
            this.OverscanState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OverscanToggle
            // 
            this.OverscanToggle.BackColor = System.Drawing.Color.Transparent;
            this.OverscanToggle.Location = new System.Drawing.Point(569, 249);
            this.OverscanToggle.Margin = new System.Windows.Forms.Padding(0);
            this.OverscanToggle.MaximumSize = new System.Drawing.Size(40, 20);
            this.OverscanToggle.MinimumSize = new System.Drawing.Size(40, 20);
            this.OverscanToggle.Name = "OverscanToggle";
            this.OverscanToggle.Size = new System.Drawing.Size(40, 20);
            this.OverscanToggle.TabIndex = 17;
            this.OverscanToggle.Toggled = false;
            this.OverscanToggle.ToggledEvent += new System.EventHandler(this.OverscanToggle_ToggledEvent);
            // 
            // OverscanLabel
            // 
            this.OverscanLabel.BackColor = System.Drawing.Color.Transparent;
            this.OverscanLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverscanLabel.Location = new System.Drawing.Point(40, 232);
            this.OverscanLabel.Name = "OverscanLabel";
            this.OverscanLabel.Size = new System.Drawing.Size(179, 50);
            this.OverscanLabel.TabIndex = 16;
            this.OverscanLabel.Text = "Overscan";
            this.OverscanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OtherPanel
            // 
            this.OtherPanel.BackColor = System.Drawing.Color.Transparent;
            this.OtherPanel.Collapsed = true;
            this.OtherPanel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.OtherPanel.Controls.Add(this.ConfigDocsButton);
            this.OtherPanel.Controls.Add(this.label3);
            this.OtherPanel.Controls.Add(this.ConfigEditorButton);
            this.OtherPanel.Controls.Add(this.label1);
            this.OtherPanel.Enabled = false;
            this.OtherPanel.Icon = "";
            this.OtherPanel.Location = new System.Drawing.Point(10, 402);
            this.OtherPanel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.OtherPanel.Name = "OtherPanel";
            this.OtherPanel.PanelText = "Other";
            this.OtherPanel.Rounding = 5;
            this.OtherPanel.Separators = 2;
            this.OtherPanel.Size = new System.Drawing.Size(640, 60);
            this.OtherPanel.TabIndex = 62;
            this.OtherPanel.Text = "Other";
            // 
            // ConfigDocsButton
            // 
            this.ConfigDocsButton.BackColor = System.Drawing.Color.Transparent;
            this.ConfigDocsButton.ButtonText = "View";
            this.ConfigDocsButton.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ConfigDocsButton.Location = new System.Drawing.Point(530, 121);
            this.ConfigDocsButton.Margin = new System.Windows.Forms.Padding(0);
            this.ConfigDocsButton.Name = "ConfigDocsButton";
            this.ConfigDocsButton.Rounding = 5;
            this.ConfigDocsButton.Size = new System.Drawing.Size(100, 30);
            this.ConfigDocsButton.TabIndex = 10;
            this.ConfigDocsButton.Click += new System.EventHandler(this.ConfigDocsButton_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 50);
            this.label3.TabIndex = 9;
            this.label3.Text = "Config.txt Documentation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConfigEditorButton
            // 
            this.ConfigEditorButton.BackColor = System.Drawing.Color.Transparent;
            this.ConfigEditorButton.ButtonText = "Edit";
            this.ConfigEditorButton.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ConfigEditorButton.Location = new System.Drawing.Point(530, 71);
            this.ConfigEditorButton.Margin = new System.Windows.Forms.Padding(0);
            this.ConfigEditorButton.Name = "ConfigEditorButton";
            this.ConfigEditorButton.Rounding = 5;
            this.ConfigEditorButton.Size = new System.Drawing.Size(100, 30);
            this.ConfigEditorButton.TabIndex = 5;
            this.ConfigEditorButton.Click += new System.EventHandler(this.ConfigEditorButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Config.txt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(660, 470);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.BootPartitionPanel.ResumeLayout(false);
            this.OverclockingPanel.ResumeLayout(false);
            this.DisplayPanel.ResumeLayout(false);
            this.ResolutionListPanel.ResumeLayout(false);
            this.OtherPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUI.CollapsiblePanel OtherPanel;
        private CustomUI.CollapsiblePanel DisplayPanel;
        private CustomUI.CollapsiblePanel OverclockingPanel;
        private System.Windows.Forms.Label ForceTurbo;
        private System.Windows.Forms.Label Overvoltage;
        private System.Windows.Forms.Label GPUMem;
        private System.Windows.Forms.Label GPUFreq;
        private Slider OvervoltageSlider;
        private Slider GPUMemSlider;
        private Slider GPUFreqSlider;
        private Slider CPUSlider;
        private System.Windows.Forms.Label ForceTurboLabel;
        private System.Windows.Forms.Label OvervoltageLabel;
        private System.Windows.Forms.Label GPUMemLabel;
        private System.Windows.Forms.Label GPUFreqLabel;
        private System.Windows.Forms.Label CPUFreqLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomUI.Toggle ForceTurboToggle;
        private RoundedPanel BootPartitionPanel;
        private System.Windows.Forms.Label CPUFreq;
        private System.Windows.Forms.Label BootMessageLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private RoundedPanel roundedPanel1;
        private CustomUI.Toggle HotplugToggle;
        private System.Windows.Forms.Label HotplugState;
        private System.Windows.Forms.Label HotplugLabel;
        private System.Windows.Forms.Label OverscanState;
        private CustomUI.Toggle OverscanToggle;
        private System.Windows.Forms.Label OverscanLabel;
        private System.Windows.Forms.Label Issues;
        private System.Windows.Forms.Label IssuesIcon;
        private System.Windows.Forms.Label PiLabel;
        private System.Windows.Forms.Panel panel1;
        private RoundedButton SaveButton;
        private RoundedButton DefaultsButton;
        private RoundedButton RefreshButton;
        private RoundedPanel roundedPanel2;
        private RoundedButton MountButton;
        private RoundedPanel roundedPanel3;
        private RoundedPanel ResolutionListPanel;
        private System.Windows.Forms.FlowLayoutPanel ResolutionList;
        private System.Windows.Forms.Panel Desktop;
        private RoundedButton ConfigEditorButton;
        private System.Windows.Forms.Label label1;
        private RoundedButton ConfigDocsButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Config;
    }
}
