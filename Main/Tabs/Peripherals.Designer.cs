
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
            this.roundedPanel1 = new WoRCP.UI.RoundedPanel();
            this.SelectedPinLabel = new System.Windows.Forms.Label();
            this.GPIOLabel = new System.Windows.Forms.Label();
            this.PinArray = new System.Windows.Forms.FlowLayoutPanel();
            this.collapsiblePanel1 = new WoRCP.UI.CollapsiblePanel();
            this.PinModeState = new System.Windows.Forms.Label();
            this.PinModeToggle = new WoRCP.UI.Toggle();
            this.PinModeLabel = new System.Windows.Forms.Label();
            this.PinStateState = new System.Windows.Forms.Label();
            this.PinStateToggle = new WoRCP.UI.Toggle();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.ControlContainer.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.collapsiblePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlContainer
            // 
            this.ControlContainer.Controls.Add(this.roundedPanel1);
            this.ControlContainer.Controls.Add(this.collapsiblePanel1);
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
            this.roundedPanel1.Controls.Add(this.SelectedPinLabel);
            this.roundedPanel1.Controls.Add(this.GPIOLabel);
            this.roundedPanel1.Controls.Add(this.PinArray);
            this.roundedPanel1.Location = new System.Drawing.Point(10, 10);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.rounding = 10;
            this.roundedPanel1.Size = new System.Drawing.Size(640, 120);
            this.roundedPanel1.TabIndex = 0;
            // 
            // SelectedPinLabel
            // 
            this.SelectedPinLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedPinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.SelectedPinLabel.Location = new System.Drawing.Point(506, 10);
            this.SelectedPinLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SelectedPinLabel.Name = "SelectedPinLabel";
            this.SelectedPinLabel.Size = new System.Drawing.Size(124, 21);
            this.SelectedPinLabel.TabIndex = 40;
            this.SelectedPinLabel.Text = "No pin selected";
            this.SelectedPinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // collapsiblePanel1
            // 
            this.collapsiblePanel1.BackColor = System.Drawing.Color.Transparent;
            this.collapsiblePanel1.Collapsed = false;
            this.collapsiblePanel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.collapsiblePanel1.Controls.Add(this.PinModeState);
            this.collapsiblePanel1.Controls.Add(this.PinModeToggle);
            this.collapsiblePanel1.Controls.Add(this.PinModeLabel);
            this.collapsiblePanel1.Controls.Add(this.PinStateState);
            this.collapsiblePanel1.Controls.Add(this.PinStateToggle);
            this.collapsiblePanel1.Icon = "";
            this.collapsiblePanel1.LeftContent = new string[] {
        "Pin State"};
            this.collapsiblePanel1.Location = new System.Drawing.Point(10, 140);
            this.collapsiblePanel1.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.collapsiblePanel1.Name = "collapsiblePanel1";
            this.collapsiblePanel1.RightContent = new string[0];
            this.collapsiblePanel1.Rounding = 5;
            this.collapsiblePanel1.Size = new System.Drawing.Size(640, 111);
            this.collapsiblePanel1.TabIndex = 1;
            this.collapsiblePanel1.Title = "GPIO Controls";
            // 
            // PinModeState
            // 
            this.PinModeState.BackColor = System.Drawing.Color.Transparent;
            this.PinModeState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinModeState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.PinModeState.Location = new System.Drawing.Point(414, 112);
            this.PinModeState.Margin = new System.Windows.Forms.Padding(0);
            this.PinModeState.Name = "PinModeState";
            this.PinModeState.Size = new System.Drawing.Size(150, 49);
            this.PinModeState.TabIndex = 32;
            this.PinModeState.Text = "Input";
            this.PinModeState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PinModeToggle
            // 
            this.PinModeToggle.BackColor = System.Drawing.Color.Transparent;
            this.PinModeToggle.Location = new System.Drawing.Point(574, 128);
            this.PinModeToggle.Margin = new System.Windows.Forms.Padding(0);
            this.PinModeToggle.MaximumSize = new System.Drawing.Size(40, 20);
            this.PinModeToggle.MinimumSize = new System.Drawing.Size(40, 20);
            this.PinModeToggle.Name = "PinModeToggle";
            this.PinModeToggle.Size = new System.Drawing.Size(40, 20);
            this.PinModeToggle.TabIndex = 31;
            this.PinModeToggle.Toggled = false;
            this.PinModeToggle.ToggledEvent += new System.EventHandler(this.PinModeToggle_ToggledEvent);
            // 
            // PinModeLabel
            // 
            this.PinModeLabel.BackColor = System.Drawing.Color.Transparent;
            this.PinModeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinModeLabel.Location = new System.Drawing.Point(45, 111);
            this.PinModeLabel.Name = "PinModeLabel";
            this.PinModeLabel.Size = new System.Drawing.Size(179, 50);
            this.PinModeLabel.TabIndex = 30;
            this.PinModeLabel.Text = "Pin Mode";
            this.PinModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PinStateState
            // 
            this.PinStateState.BackColor = System.Drawing.Color.Transparent;
            this.PinStateState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinStateState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.PinStateState.Location = new System.Drawing.Point(414, 62);
            this.PinStateState.Margin = new System.Windows.Forms.Padding(0);
            this.PinStateState.Name = "PinStateState";
            this.PinStateState.Size = new System.Drawing.Size(150, 49);
            this.PinStateState.TabIndex = 29;
            this.PinStateState.Text = "Low";
            this.PinStateState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PinStateToggle
            // 
            this.PinStateToggle.BackColor = System.Drawing.Color.Transparent;
            this.PinStateToggle.Location = new System.Drawing.Point(574, 78);
            this.PinStateToggle.Margin = new System.Windows.Forms.Padding(0);
            this.PinStateToggle.MaximumSize = new System.Drawing.Size(40, 20);
            this.PinStateToggle.MinimumSize = new System.Drawing.Size(40, 20);
            this.PinStateToggle.Name = "PinStateToggle";
            this.PinStateToggle.Size = new System.Drawing.Size(40, 20);
            this.PinStateToggle.TabIndex = 28;
            this.PinStateToggle.Toggled = false;
            this.PinStateToggle.ToggledEvent += new System.EventHandler(this.PinStateToggle_ToggledEvent);
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
            this.VisibleChanged += new System.EventHandler(this.Peripherals_VisibleChanged);
            this.ControlContainer.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.collapsiblePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WoRCP.UI.RoundedPanel roundedPanel1;
        private System.Windows.Forms.FlowLayoutPanel ControlContainer;
        private System.Windows.Forms.Label GPIOLabel;
        private System.Windows.Forms.Label SelectedPinLabel;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.FlowLayoutPanel PinArray;
        private WoRCP.UI.CollapsiblePanel collapsiblePanel1;
        private System.Windows.Forms.Label PinStateState;
        private WoRCP.UI.Toggle PinStateToggle;
        private System.Windows.Forms.Label PinModeState;
        private WoRCP.UI.Toggle PinModeToggle;
        private System.Windows.Forms.Label PinModeLabel;
    }
}
