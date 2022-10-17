
namespace Installer
{
    partial class WoRCPInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WoRCPInstaller));
            this.AcrylicPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BottomLabel = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.PathPanel = new WoRCP.UI.RoundedPanel();
            this.ChooseDirButton = new WoRCP.UI.RoundedButton();
            this.PathTextbox = new System.Windows.Forms.TextBox();
            this.InstallButton = new WoRCP.UI.RoundedButton();
            this.BottomPanel.SuspendLayout();
            this.PathPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AcrylicPanel
            // 
            this.AcrylicPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.AcrylicPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AcrylicPanel.Location = new System.Drawing.Point(0, 0);
            this.AcrylicPanel.Name = "AcrylicPanel";
            this.AcrylicPanel.Size = new System.Drawing.Size(577, 130);
            this.AcrylicPanel.TabIndex = 0;
            this.AcrylicPanel.Tag = "";
            this.AcrylicPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AcrylicPanel_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 10);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 53);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thank you for downloading WoR CP!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 177);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BottomLabel
            // 
            this.BottomLabel.AutoSize = true;
            this.BottomLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomLabel.Location = new System.Drawing.Point(5, 18);
            this.BottomLabel.Name = "BottomLabel";
            this.BottomLabel.Size = new System.Drawing.Size(95, 15);
            this.BottomLabel.TabIndex = 7;
            this.BottomLabel.Text = "Installation path:";
            this.BottomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.BottomPanel.Controls.Add(this.PathPanel);
            this.BottomPanel.Controls.Add(this.InstallButton);
            this.BottomPanel.Controls.Add(this.BottomLabel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 430);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(577, 50);
            this.BottomPanel.TabIndex = 4;
            // 
            // PathPanel
            // 
            this.PathPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathPanel.BackColor = System.Drawing.Color.Transparent;
            this.PathPanel.color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.PathPanel.Controls.Add(this.ChooseDirButton);
            this.PathPanel.Controls.Add(this.PathTextbox);
            this.PathPanel.Location = new System.Drawing.Point(106, 10);
            this.PathPanel.Name = "PathPanel";
            this.PathPanel.rounding = 5;
            this.PathPanel.Size = new System.Drawing.Size(355, 30);
            this.PathPanel.TabIndex = 5;
            // 
            // ChooseDirButton
            // 
            this.ChooseDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseDirButton.BackColor = System.Drawing.Color.Transparent;
            this.ChooseDirButton.ButtonText = "☰";
            this.ChooseDirButton.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ChooseDirButton.Glyph = false;
            this.ChooseDirButton.Location = new System.Drawing.Point(310, 1);
            this.ChooseDirButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChooseDirButton.Name = "ChooseDirButton";
            this.ChooseDirButton.Rounding = 5;
            this.ChooseDirButton.Size = new System.Drawing.Size(45, 30);
            this.ChooseDirButton.TabIndex = 6;
            this.ChooseDirButton.Click += new System.EventHandler(this.ChooseDirButton_Click);
            // 
            // PathTextbox
            // 
            this.PathTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.PathTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PathTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathTextbox.ForeColor = System.Drawing.Color.White;
            this.PathTextbox.Location = new System.Drawing.Point(10, 8);
            this.PathTextbox.Name = "PathTextbox";
            this.PathTextbox.Size = new System.Drawing.Size(297, 16);
            this.PathTextbox.TabIndex = 0;
            this.PathTextbox.Text = "C:\\Program Files\\WoR Control Panel";
            // 
            // InstallButton
            // 
            this.InstallButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InstallButton.BackColor = System.Drawing.Color.Transparent;
            this.InstallButton.ButtonText = "Install";
            this.InstallButton.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.InstallButton.Glyph = false;
            this.InstallButton.Location = new System.Drawing.Point(467, 10);
            this.InstallButton.Margin = new System.Windows.Forms.Padding(0);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Rounding = 5;
            this.InstallButton.Size = new System.Drawing.Size(100, 30);
            this.InstallButton.TabIndex = 3;
            this.InstallButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // WoRCPInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(577, 480);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AcrylicPanel);
            this.Controls.Add(this.BottomPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WoRCPInstaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installer";
            this.Load += new System.EventHandler(this.Installer_Load);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.PathPanel.ResumeLayout(false);
            this.PathPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private WoRCP.UI.RoundedButton InstallButton;
        private WoRCP.UI.RoundedPanel PathPanel;
        private System.Windows.Forms.TextBox PathTextbox;
        private WoRCP.UI.RoundedButton ChooseDirButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BottomLabel;
        private System.Windows.Forms.Panel BottomPanel;
        public System.Windows.Forms.Panel AcrylicPanel;
    }
}

