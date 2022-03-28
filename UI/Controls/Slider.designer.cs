
namespace WoRCP.UI
{
    partial class Slider
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
            this.SliderBG = new System.Windows.Forms.Panel();
            this.SliderFiller = new System.Windows.Forms.Panel();
            this.SliderKnob = new System.Windows.Forms.Label();
            this.SliderBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // SliderBG
            // 
            this.SliderBG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SliderBG.BackColor = System.Drawing.Color.Transparent;
            this.SliderBG.Controls.Add(this.SliderFiller);
            this.SliderBG.Location = new System.Drawing.Point(10, 13);
            this.SliderBG.Margin = new System.Windows.Forms.Padding(0);
            this.SliderBG.Name = "SliderBG";
            this.SliderBG.Size = new System.Drawing.Size(180, 4);
            this.SliderBG.TabIndex = 0;
            this.SliderBG.Paint += new System.Windows.Forms.PaintEventHandler(this.SliderBG_Paint);
            // 
            // SliderFiller
            // 
            this.SliderFiller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.SliderFiller.Location = new System.Drawing.Point(0, 0);
            this.SliderFiller.Name = "SliderFiller";
            this.SliderFiller.Size = new System.Drawing.Size(100, 4);
            this.SliderFiller.TabIndex = 0;
            // 
            // SliderKnob
            // 
            this.SliderKnob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SliderKnob.BackColor = System.Drawing.Color.Transparent;
            this.SliderKnob.Cursor = System.Windows.Forms.Cursors.Default;
            this.SliderKnob.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.SliderKnob.ForeColor = System.Drawing.Color.Transparent;
            this.SliderKnob.Location = new System.Drawing.Point(90, 5);
            this.SliderKnob.Name = "SliderKnob";
            this.SliderKnob.Size = new System.Drawing.Size(20, 20);
            this.SliderKnob.TabIndex = 2;
            this.SliderKnob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SliderKnob.Paint += new System.Windows.Forms.PaintEventHandler(this.SliderKnob_Paint);
            this.SliderKnob.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SliderKnob_MouseDown);
            this.SliderKnob.MouseEnter += new System.EventHandler(this.SliderKnob_MouseEnter);
            this.SliderKnob.MouseLeave += new System.EventHandler(this.SliderKnob_MouseLeave);
            this.SliderKnob.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SliderKnob_MouseMove);
            this.SliderKnob.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SliderKnob_MouseUp);
            // 
            // Slider
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.SliderKnob);
            this.Controls.Add(this.SliderBG);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(1000, 30);
            this.MinimumSize = new System.Drawing.Size(100, 30);
            this.Name = "Slider";
            this.Size = new System.Drawing.Size(200, 30);
            this.EnabledChanged += new System.EventHandler(this.Slider_EnabledChanged);
            this.SizeChanged += new System.EventHandler(this.Resized);
            this.SliderBG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SliderBG;
        private System.Windows.Forms.Panel SliderFiller;
        private System.Windows.Forms.Label SliderKnob;
    }
}
