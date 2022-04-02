
namespace WoRCP.UI
{
    partial class RoundedButton
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
            this.SuspendLayout();
            // 
            // RoundedButton
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Size = new System.Drawing.Size(100, 30);
            this.SizeChanged += new System.EventHandler(this.RoundedButton_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RoundedButton_Paint);
            this.MouseEnter += new System.EventHandler(this.RoundedButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.RoundedButton_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
