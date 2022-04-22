
namespace WoRCP
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.Indicator = new WoRCP.UI.RoundedPanel();
            this.PerformanceButton = new System.Windows.Forms.Button();
            this.PeripheralsButton = new System.Windows.Forms.Button();
            this.AppstoreButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.OverlayButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.Greeting = new System.Windows.Forms.Label();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Tabcontainer = new System.Windows.Forms.Panel();
            this.RGBStrip = new System.Windows.Forms.PictureBox();
            this.SidePanel.SuspendLayout();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGBStrip)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.SidePanel.Controls.Add(this.Indicator);
            this.SidePanel.Controls.Add(this.PerformanceButton);
            this.SidePanel.Controls.Add(this.PeripheralsButton);
            this.SidePanel.Controls.Add(this.AppstoreButton);
            this.SidePanel.Controls.Add(this.AboutButton);
            this.SidePanel.Controls.Add(this.OverlayButton);
            this.SidePanel.Controls.Add(this.SettingsButton);
            this.SidePanel.Controls.Add(this.Greeting);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(175, 500);
            this.SidePanel.TabIndex = 0;
            this.SidePanel.Tag = "Acrylic";
            // 
            // Indicator
            // 
            this.Indicator.BackColor = System.Drawing.Color.Transparent;
            this.Indicator.color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.Indicator.Location = new System.Drawing.Point(0, 210);
            this.Indicator.Name = "Indicator";
            this.Indicator.rounding = 2;
            this.Indicator.Size = new System.Drawing.Size(4, 30);
            this.Indicator.TabIndex = 0;
            // 
            // PerformanceButton
            // 
            this.PerformanceButton.BackColor = System.Drawing.Color.Transparent;
            this.PerformanceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PerformanceButton.FlatAppearance.BorderSize = 0;
            this.PerformanceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PerformanceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PerformanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PerformanceButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PerformanceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PerformanceButton.Location = new System.Drawing.Point(0, 200);
            this.PerformanceButton.Name = "PerformanceButton";
            this.PerformanceButton.Size = new System.Drawing.Size(175, 50);
            this.PerformanceButton.TabIndex = 0;
            this.PerformanceButton.Text = "           Performance";
            this.PerformanceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PerformanceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PerformanceButton.UseVisualStyleBackColor = false;
            this.PerformanceButton.Click += new System.EventHandler(this.PerformanceButton_Click);
            this.PerformanceButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PerformanceButton_Paint);
            // 
            // PeripheralsButton
            // 
            this.PeripheralsButton.BackColor = System.Drawing.Color.Transparent;
            this.PeripheralsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PeripheralsButton.FlatAppearance.BorderSize = 0;
            this.PeripheralsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PeripheralsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PeripheralsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PeripheralsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PeripheralsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PeripheralsButton.Location = new System.Drawing.Point(0, 250);
            this.PeripheralsButton.Name = "PeripheralsButton";
            this.PeripheralsButton.Size = new System.Drawing.Size(175, 50);
            this.PeripheralsButton.TabIndex = 1;
            this.PeripheralsButton.Text = "           Peripherals";
            this.PeripheralsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PeripheralsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PeripheralsButton.UseVisualStyleBackColor = false;
            this.PeripheralsButton.Click += new System.EventHandler(this.GPIOButton_Click);
            this.PeripheralsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.PeripheralsButton_Paint);
            // 
            // AppstoreButton
            // 
            this.AppstoreButton.BackColor = System.Drawing.Color.Transparent;
            this.AppstoreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AppstoreButton.FlatAppearance.BorderSize = 0;
            this.AppstoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AppstoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AppstoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppstoreButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AppstoreButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AppstoreButton.Location = new System.Drawing.Point(0, 300);
            this.AppstoreButton.Name = "AppstoreButton";
            this.AppstoreButton.Size = new System.Drawing.Size(175, 50);
            this.AppstoreButton.TabIndex = 2;
            this.AppstoreButton.Text = "           Applications";
            this.AppstoreButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AppstoreButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AppstoreButton.UseVisualStyleBackColor = false;
            this.AppstoreButton.Click += new System.EventHandler(this.AppstoreButton_Click);
            this.AppstoreButton.Paint += new System.Windows.Forms.PaintEventHandler(this.AppstoreButton_Paint);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutButton.Location = new System.Drawing.Point(0, 350);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(175, 50);
            this.AboutButton.TabIndex = 3;
            this.AboutButton.Text = "           About";
            this.AboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            this.AboutButton.Paint += new System.Windows.Forms.PaintEventHandler(this.AboutButton_Paint);
            // 
            // OverlayButton
            // 
            this.OverlayButton.BackColor = System.Drawing.Color.Transparent;
            this.OverlayButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OverlayButton.FlatAppearance.BorderSize = 0;
            this.OverlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OverlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OverlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverlayButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OverlayButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OverlayButton.Location = new System.Drawing.Point(0, 400);
            this.OverlayButton.Name = "OverlayButton";
            this.OverlayButton.Size = new System.Drawing.Size(175, 50);
            this.OverlayButton.TabIndex = 4;
            this.OverlayButton.Text = "           Overlay";
            this.OverlayButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OverlayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OverlayButton.UseVisualStyleBackColor = false;
            this.OverlayButton.Click += new System.EventHandler(this.OverlayButton_Click);
            this.OverlayButton.Paint += new System.Windows.Forms.PaintEventHandler(this.OverlayButton_Paint);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(0, 450);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(175, 50);
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.Text = "           Settings";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            this.SettingsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.SettingsButton_Paint);
            // 
            // Greeting
            // 
            this.Greeting.BackColor = System.Drawing.Color.Transparent;
            this.Greeting.Dock = System.Windows.Forms.DockStyle.Top;
            this.Greeting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Greeting.Image = ((System.Drawing.Image)(resources.GetObject("Greeting.Image")));
            this.Greeting.Location = new System.Drawing.Point(0, 0);
            this.Greeting.Name = "Greeting";
            this.Greeting.Size = new System.Drawing.Size(175, 190);
            this.Greeting.TabIndex = 2;
            this.Greeting.Text = "Good morning\r\nUser!";
            this.Greeting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Greeting.DoubleClick += new System.EventHandler(this.OpenDebugger);
            // 
            // TitleBar
            // 
            this.TitleBar.Controls.Add(this.MinimizeButton);
            this.TitleBar.Controls.Add(this.CloseButton);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(175, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(660, 30);
            this.TitleBar.TabIndex = 1;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragStart);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F);
            this.MinimizeButton.Location = new System.Drawing.Point(570, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(45, 30);
            this.MinimizeButton.TabIndex = 8;
            this.MinimizeButton.Text = "";
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
            this.CloseButton.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F);
            this.CloseButton.Location = new System.Drawing.Point(615, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 30);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Tabcontainer
            // 
            this.Tabcontainer.Location = new System.Drawing.Point(175, 27);
            this.Tabcontainer.Name = "Tabcontainer";
            this.Tabcontainer.Size = new System.Drawing.Size(660, 473);
            this.Tabcontainer.TabIndex = 6;
            // 
            // RGBStrip
            // 
            this.RGBStrip.Image = ((System.Drawing.Image)(resources.GetObject("RGBStrip.Image")));
            this.RGBStrip.Location = new System.Drawing.Point(175, 27);
            this.RGBStrip.Name = "RGBStrip";
            this.RGBStrip.Size = new System.Drawing.Size(660, 3);
            this.RGBStrip.TabIndex = 0;
            this.RGBStrip.TabStop = false;
            this.RGBStrip.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(835, 500);
            this.Controls.Add(this.RGBStrip);
            this.Controls.Add(this.Tabcontainer);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.SidePanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(835, 500);
            this.MinimumSize = new System.Drawing.Size(835, 500);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WoR Control Panel";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.Deactivate += new System.EventHandler(this.MainWindow_Deactivate);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SidePanel.ResumeLayout(false);
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RGBStrip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Greeting;
        private System.Windows.Forms.Button PerformanceButton;
        private System.Windows.Forms.Button PeripheralsButton;
        private System.Windows.Forms.Button AppstoreButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button OverlayButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel Tabcontainer;
        private WoRCP.UI.RoundedPanel Indicator;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.PictureBox RGBStrip;
    }
}

