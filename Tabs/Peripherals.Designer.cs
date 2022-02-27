
namespace WoRCP.Tabs
{
    partial class Peripherals
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
            this.roundedPanel1 = new WoRCP.RoundedPanel();
            this.SelectedPin = new System.Windows.Forms.Label();
            this.GPIOLabel = new System.Windows.Forms.Label();
            this.PinArray = new System.Windows.Forms.FlowLayoutPanel();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.ControlContainer.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlContainer
            // 
            this.ControlContainer.Controls.Add(this.roundedPanel1);
            this.ControlContainer.Location = new System.Drawing.Point(0, 0);
            this.ControlContainer.Name = "ControlContainer";
            this.ControlContainer.Size = new System.Drawing.Size(660, 470);
            this.ControlContainer.TabIndex = 1;
            this.ControlContainer.Visible = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel1.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.roundedPanel1.Controls.Add(this.SelectedPin);
            this.roundedPanel1.Controls.Add(this.GPIOLabel);
            this.roundedPanel1.Controls.Add(this.PinArray);
            this.roundedPanel1.Location = new System.Drawing.Point(10, 10);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.rounding = 10;
            this.roundedPanel1.Size = new System.Drawing.Size(640, 120);
            this.roundedPanel1.TabIndex = 0;
            // 
            // SelectedPin
            // 
            this.SelectedPin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.SelectedPin.Location = new System.Drawing.Point(506, 10);
            this.SelectedPin.Margin = new System.Windows.Forms.Padding(0);
            this.SelectedPin.Name = "SelectedPin";
            this.SelectedPin.Size = new System.Drawing.Size(124, 21);
            this.SelectedPin.TabIndex = 40;
            this.SelectedPin.Text = "No pin selected";
            this.SelectedPin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPIOLabel
            // 
            this.GPIOLabel.AutoSize = true;
            this.GPIOLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPIOLabel.ForeColor = System.Drawing.Color.White;
            this.GPIOLabel.Location = new System.Drawing.Point(10, 10);
            this.GPIOLabel.Name = "GPIOLabel";
            this.GPIOLabel.Size = new System.Drawing.Size(80, 21);
            this.GPIOLabel.TabIndex = 39;
            this.GPIOLabel.Text = "GPIO Pins";
            // 
            // PinArray
            // 
            this.PinArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PinArray.Location = new System.Drawing.Point(10, 48);
            this.PinArray.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PinArray.Name = "PinArray";
            this.PinArray.Size = new System.Drawing.Size(620, 62);
            this.PinArray.TabIndex = 2;
            // 
            // WarningLabel
            // 
            this.WarningLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WarningLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.Location = new System.Drawing.Point(0, 0);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(660, 470);
            this.WarningLabel.TabIndex = 1;
            this.WarningLabel.Text = "This tab has been disabled.\r\nGPIO Functionality is only available on Raspberry Pi" +
    "\'s";
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Peripherals
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.ControlContainer);
            this.Controls.Add(this.WarningLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Peripherals";
            this.Size = new System.Drawing.Size(660, 470);
            this.Load += new System.EventHandler(this.Peripherals_Load);
            this.ControlContainer.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.FlowLayoutPanel ControlContainer;
        private System.Windows.Forms.Label GPIOLabel;
        private System.Windows.Forms.Label SelectedPin;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.FlowLayoutPanel PinArray;
    }
}
