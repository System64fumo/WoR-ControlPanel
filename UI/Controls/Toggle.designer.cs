
namespace WoRCP.UI
{
    partial class Toggle
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
            this.ToggleKnob = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ToggleKnob
            // 
            this.ToggleKnob.Location = new System.Drawing.Point(3, 3);
            this.ToggleKnob.Name = "ToggleKnob";
            this.ToggleKnob.Size = new System.Drawing.Size(14, 14);
            this.ToggleKnob.TabIndex = 0;
            this.ToggleKnob.Click += new System.EventHandler(this.ToggleKnob_Click);
            this.ToggleKnob.Paint += new System.Windows.Forms.PaintEventHandler(this.ToggleKnob_Paint);
            // 
            // Toggle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ToggleKnob);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(40, 20);
            this.MinimumSize = new System.Drawing.Size(40, 20);
            this.Name = "Toggle";
            this.Size = new System.Drawing.Size(40, 20);
            this.EnabledChanged += new System.EventHandler(this.Toggle_EnabledChanged);
            this.Click += new System.EventHandler(this.Toggle_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Toggle_Paint);
            this.MouseEnter += new System.EventHandler(this.Toggle_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Toggle_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToggleKnob;
    }
}
