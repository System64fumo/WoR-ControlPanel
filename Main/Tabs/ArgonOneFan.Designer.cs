namespace WoRCP.Tabs
{
    partial class ArgonOneFan
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
            this.ControlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.FanSpeedPanelPanel = new WoRCP.UI.CollapsiblePanel();
            this.FanSpeedLabel = new System.Windows.Forms.Label();
            this.FanSpeedSlider = new WoRCP.UI.Slider();
            this.ControlContainer.SuspendLayout();
            this.FanSpeedPanelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlContainer
            // 
            this.ControlContainer.Controls.Add(this.FanSpeedPanelPanel);
            this.ControlContainer.Location = new System.Drawing.Point(8, 8);
            this.ControlContainer.Name = "ControlContainer";
            this.ControlContainer.Size = new System.Drawing.Size(660, 470);
            this.ControlContainer.TabIndex = 2;
            this.ControlContainer.Visible = false;
            // 
            // FanSpeedPanelPanel
            // 
            this.FanSpeedPanelPanel.BackColor = System.Drawing.Color.Transparent;
            this.FanSpeedPanelPanel.Collapsed = false;
            this.FanSpeedPanelPanel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.FanSpeedPanelPanel.Controls.Add(this.FanSpeedLabel);
            this.FanSpeedPanelPanel.Controls.Add(this.FanSpeedSlider);
            this.FanSpeedPanelPanel.Icon = "";
            this.FanSpeedPanelPanel.LeftContent = new string[] {
        "Fan Speed"};
            this.FanSpeedPanelPanel.Location = new System.Drawing.Point(10, 0);
            this.FanSpeedPanelPanel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.FanSpeedPanelPanel.Name = "FanSpeedPanelPanel";
            this.FanSpeedPanelPanel.RightContent = new string[0];
            this.FanSpeedPanelPanel.Rounding = 5;
            this.FanSpeedPanelPanel.Size = new System.Drawing.Size(640, 111);
            this.FanSpeedPanelPanel.TabIndex = 62;
            this.FanSpeedPanelPanel.Title = "Argon One Fan Control";
            // 
            // FanSpeedLabel
            // 
            this.FanSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.FanSpeedLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FanSpeedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.FanSpeedLabel.Location = new System.Drawing.Point(277, 62);
            this.FanSpeedLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FanSpeedLabel.Name = "FanSpeedLabel";
            this.FanSpeedLabel.Size = new System.Drawing.Size(150, 50);
            this.FanSpeedLabel.TabIndex = 37;
            this.FanSpeedLabel.Text = "Off";
            this.FanSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FanSpeedSlider
            // 
            this.FanSpeedSlider.BackColor = System.Drawing.Color.Transparent;
            this.FanSpeedSlider.Double = false;
            this.FanSpeedSlider.Location = new System.Drawing.Point(430, 71);
            this.FanSpeedSlider.Margin = new System.Windows.Forms.Padding(0);
            this.FanSpeedSlider.MaximumSize = new System.Drawing.Size(1000, 30);
            this.FanSpeedSlider.MaxValue = 100D;
            this.FanSpeedSlider.MinimumSize = new System.Drawing.Size(100, 30);
            this.FanSpeedSlider.MinValue = 0D;
            this.FanSpeedSlider.Name = "FanSpeedSlider";
            this.FanSpeedSlider.Size = new System.Drawing.Size(200, 30);
            this.FanSpeedSlider.TabIndex = 17;
            this.FanSpeedSlider.Value = 0D;
            this.FanSpeedSlider.ValueP = 0D;
            // 
            // ArgonOneFan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.ControlContainer);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ArgonOneFan";
            this.Size = new System.Drawing.Size(660, 470);
            this.ControlContainer.ResumeLayout(false);
            this.FanSpeedPanelPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ControlContainer;
        private UI.CollapsiblePanel FanSpeedPanelPanel;
        private System.Windows.Forms.Label FanSpeedLabel;
        private UI.Slider FanSpeedSlider;
    }
}
