
namespace WoRCP.Tabs
{
    partial class Appstore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appstore));
            this.Container = new System.Windows.Forms.FlowLayoutPanel();
            this.roundedPanel1 = new WoRCP.UI.RoundedPanel();
            this.Banner = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Container.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.Banner.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.AutoScroll = true;
            this.Container.Controls.Add(this.roundedPanel1);
            this.Container.Location = new System.Drawing.Point(0, 3);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(681, 467);
            this.Container.TabIndex = 2;
            this.Container.Visible = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.color = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.roundedPanel1.Controls.Add(this.Banner);
            this.roundedPanel1.Location = new System.Drawing.Point(10, 10);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.rounding = 10;
            this.roundedPanel1.Size = new System.Drawing.Size(640, 220);
            this.roundedPanel1.TabIndex = 1;
            // 
            // Banner
            // 
            this.Banner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Banner.BackgroundImage")));
            this.Banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Banner.Controls.Add(this.label2);
            this.Banner.Controls.Add(this.label1);
            this.Banner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Banner.Location = new System.Drawing.Point(0, 0);
            this.Banner.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(640, 220);
            this.Banner.TabIndex = 0;
            this.Banner.Paint += new System.Windows.Forms.PaintEventHandler(this.Banner_Paint);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Easily install Arm applications from WoR-CP with one click!";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compatible with your device!";
            // 
            // Appstore
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.Container);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Appstore";
            this.Size = new System.Drawing.Size(660, 470);
            this.Load += new System.EventHandler(this.Appstore_Load);
            this.Container.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.Banner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private new System.Windows.Forms.FlowLayoutPanel Container;
        private System.Windows.Forms.Panel Banner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UI.RoundedPanel roundedPanel1;
    }
}
