
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
            this.Tabcontainer = new System.Windows.Forms.Panel();
            this.RGBStrip = new System.Windows.Forms.PictureBox();
            this.SidePanel.SuspendLayout();
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
            this.SidePanel.Size = new System.Drawing.Size(175, 481);
            this.SidePanel.TabIndex = 0;
            this.SidePanel.Tag = "Acrylic";
            // 
            // Indicator
            // 
            this.Indicator.BackColor = System.Drawing.Color.Transparent;
            this.Indicator.color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.Indicator.Location = new System.Drawing.Point(0, 191);
            this.Indicator.Name = "Indicator";
            this.Indicator.rounding = 2;
            this.Indicator.Size = new System.Drawing.Size(4, 30);
            this.Indicator.TabIndex = 0;
            // 
            // PerformanceButton
            // 
            this.PerformanceButton.BackColor = System.Drawing.Color.Transparent;
            this.PerformanceButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PerformanceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PerformanceButton.FlatAppearance.BorderSize = 0;
            this.PerformanceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PerformanceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PerformanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PerformanceButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PerformanceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PerformanceButton.Location = new System.Drawing.Point(0, 181);
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
            this.PeripheralsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PeripheralsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PeripheralsButton.FlatAppearance.BorderSize = 0;
            this.PeripheralsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PeripheralsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PeripheralsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PeripheralsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PeripheralsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PeripheralsButton.Location = new System.Drawing.Point(0, 231);
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
            this.AppstoreButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AppstoreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AppstoreButton.FlatAppearance.BorderSize = 0;
            this.AppstoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AppstoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AppstoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppstoreButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AppstoreButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AppstoreButton.Location = new System.Drawing.Point(0, 281);
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
            this.AboutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AboutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutButton.Location = new System.Drawing.Point(0, 331);
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
            this.OverlayButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OverlayButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OverlayButton.FlatAppearance.BorderSize = 0;
            this.OverlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OverlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OverlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OverlayButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OverlayButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OverlayButton.Location = new System.Drawing.Point(0, 381);
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
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(0, 431);
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
            this.Greeting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Greeting.Image = ((System.Drawing.Image)(resources.GetObject("Greeting.Image")));
            this.Greeting.Location = new System.Drawing.Point(0, -20);
            this.Greeting.Name = "Greeting";
            this.Greeting.Size = new System.Drawing.Size(175, 175);
            this.Greeting.TabIndex = 2;
            this.Greeting.Text = "Good morning\r\nUser!";
            this.Greeting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Greeting.DoubleClick += new System.EventHandler(this.OpenDebugger);
            // 
            // Tabcontainer
            // 
            this.Tabcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabcontainer.Location = new System.Drawing.Point(175, 0);
            this.Tabcontainer.Name = "Tabcontainer";
            this.Tabcontainer.Size = new System.Drawing.Size(659, 481);
            this.Tabcontainer.TabIndex = 6;
            // 
            // RGBStrip
            // 
            this.RGBStrip.Image = ((System.Drawing.Image)(resources.GetObject("RGBStrip.Image")));
            this.RGBStrip.Location = new System.Drawing.Point(175, 0);
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
            this.ClientSize = new System.Drawing.Size(834, 481);
            this.Controls.Add(this.RGBStrip);
            this.Controls.Add(this.Tabcontainer);
            this.Controls.Add(this.SidePanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 520);
            this.MinimumSize = new System.Drawing.Size(850, 520);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SidePanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel Tabcontainer;
        private WoRCP.UI.RoundedPanel Indicator;
        private System.Windows.Forms.PictureBox RGBStrip;
        public System.Windows.Forms.Panel SidePanel;
    }
}

