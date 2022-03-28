
namespace WoRCP
{
    partial class AppUI
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
            this.components = new System.ComponentModel.Container();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.AppName = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.ApplicationSize = new System.Windows.Forms.Label();
            this.InstallButton = new WoRCP.UI.RoundedButton();
            this.Animation = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ImagePanel
            // 
            this.ImagePanel.BackColor = System.Drawing.Color.Transparent;
            this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagePanel.Location = new System.Drawing.Point(44, 21);
            this.ImagePanel.Margin = new System.Windows.Forms.Padding(0);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(64, 64);
            this.ImagePanel.TabIndex = 0;
            this.ImagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ImagePanel_Paint);
            // 
            // AppName
            // 
            this.AppName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.ForeColor = System.Drawing.Color.White;
            this.AppName.Location = new System.Drawing.Point(10, 106);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(128, 20);
            this.AppName.TabIndex = 1;
            this.AppName.Text = "ApplicationName";
            // 
            // Category
            // 
            this.Category.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Category.Location = new System.Drawing.Point(10, 126);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(128, 20);
            this.Category.TabIndex = 2;
            this.Category.Text = "Category";
            // 
            // ApplicationSize
            // 
            this.ApplicationSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ApplicationSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationSize.ForeColor = System.Drawing.Color.White;
            this.ApplicationSize.Location = new System.Drawing.Point(7, 170);
            this.ApplicationSize.Name = "ApplicationSize";
            this.ApplicationSize.Size = new System.Drawing.Size(50, 20);
            this.ApplicationSize.TabIndex = 3;
            this.ApplicationSize.Text = "0MB";
            this.ApplicationSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InstallButton
            // 
            this.InstallButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InstallButton.BackColor = System.Drawing.Color.Transparent;
            this.InstallButton.ButtonText = "Install";
            this.InstallButton.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.InstallButton.Location = new System.Drawing.Point(67, 165);
            this.InstallButton.Margin = new System.Windows.Forms.Padding(0);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Rounding = 5;
            this.InstallButton.Size = new System.Drawing.Size(80, 30);
            this.InstallButton.TabIndex = 4;
            this.InstallButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // Animation
            // 
            this.Animation.Interval = 50;
            this.Animation.Tick += new System.EventHandler(this.Animation_Tick);
            // 
            // AppUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.InstallButton);
            this.Controls.Add(this.ApplicationSize);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.ImagePanel);
            this.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.Name = "AppUI";
            this.Size = new System.Drawing.Size(152, 200);
            this.Load += new System.EventHandler(this.AppUI_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AppUI_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label AppName;
        public System.Windows.Forms.Label Category;
        private System.Windows.Forms.Panel ImagePanel;
        public System.Windows.Forms.Label ApplicationSize;
        private WoRCP.UI.RoundedButton InstallButton;
        private System.Windows.Forms.Timer Animation;
    }
}
