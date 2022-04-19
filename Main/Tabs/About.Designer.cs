
namespace WoRCP.Tabs
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.HardwarePanel = new WoRCP.UI.RoundedPanel();
            this.SerialNumber = new System.Windows.Forms.Label();
            this.SerialLabel = new System.Windows.Forms.Label();
            this.Revision = new System.Windows.Forms.Label();
            this.RevisionLabel = new System.Windows.Forms.Label();
            this.DeviceName = new System.Windows.Forms.Label();
            this.DeviceModel = new System.Windows.Forms.Label();
            this.DeviceIcon = new System.Windows.Forms.Label();
            this.Firmware = new System.Windows.Forms.Label();
            this.Memory = new System.Windows.Forms.Label();
            this.Processor = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.ProcessorLabel = new System.Windows.Forms.Label();
            this.FirmwareLabel = new System.Windows.Forms.Label();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.AboutPanel = new WoRCP.UI.CollapsiblePanel();
            this.DiscordLink = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.HardwarePanel.SuspendLayout();
            this.AboutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.HardwarePanel);
            this.flowLayoutPanel1.Controls.Add(this.AboutPanel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(681, 470);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // HardwarePanel
            // 
            this.HardwarePanel.BackColor = System.Drawing.Color.Transparent;
            this.HardwarePanel.color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.HardwarePanel.Controls.Add(this.SerialNumber);
            this.HardwarePanel.Controls.Add(this.SerialLabel);
            this.HardwarePanel.Controls.Add(this.Revision);
            this.HardwarePanel.Controls.Add(this.RevisionLabel);
            this.HardwarePanel.Controls.Add(this.DeviceName);
            this.HardwarePanel.Controls.Add(this.DeviceModel);
            this.HardwarePanel.Controls.Add(this.DeviceIcon);
            this.HardwarePanel.Controls.Add(this.Firmware);
            this.HardwarePanel.Controls.Add(this.Memory);
            this.HardwarePanel.Controls.Add(this.Processor);
            this.HardwarePanel.Controls.Add(this.MemoryLabel);
            this.HardwarePanel.Controls.Add(this.ProcessorLabel);
            this.HardwarePanel.Controls.Add(this.FirmwareLabel);
            this.HardwarePanel.Controls.Add(this.LogoPanel);
            this.HardwarePanel.Location = new System.Drawing.Point(10, 10);
            this.HardwarePanel.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.HardwarePanel.Name = "HardwarePanel";
            this.HardwarePanel.rounding = 5;
            this.HardwarePanel.Size = new System.Drawing.Size(640, 165);
            this.HardwarePanel.TabIndex = 3;
            // 
            // SerialNumber
            // 
            this.SerialNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.SerialNumber.Location = new System.Drawing.Point(90, 130);
            this.SerialNumber.Margin = new System.Windows.Forms.Padding(0);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(330, 20);
            this.SerialNumber.TabIndex = 77;
            this.SerialNumber.Text = "Unavailable";
            this.SerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SerialLabel
            // 
            this.SerialLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialLabel.Location = new System.Drawing.Point(10, 130);
            this.SerialLabel.Margin = new System.Windows.Forms.Padding(0);
            this.SerialLabel.Name = "SerialLabel";
            this.SerialLabel.Size = new System.Drawing.Size(80, 20);
            this.SerialLabel.TabIndex = 76;
            this.SerialLabel.Text = "Serial No";
            this.SerialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Revision
            // 
            this.Revision.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Revision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Revision.Location = new System.Drawing.Point(90, 110);
            this.Revision.Margin = new System.Windows.Forms.Padding(0);
            this.Revision.Name = "Revision";
            this.Revision.Size = new System.Drawing.Size(330, 20);
            this.Revision.TabIndex = 75;
            this.Revision.Text = "Unavailable";
            this.Revision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RevisionLabel
            // 
            this.RevisionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevisionLabel.Location = new System.Drawing.Point(10, 110);
            this.RevisionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.RevisionLabel.Name = "RevisionLabel";
            this.RevisionLabel.Size = new System.Drawing.Size(80, 20);
            this.RevisionLabel.TabIndex = 74;
            this.RevisionLabel.Text = "Revision";
            this.RevisionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeviceName
            // 
            this.DeviceName.AutoSize = true;
            this.DeviceName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.DeviceName.Location = new System.Drawing.Point(40, 28);
            this.DeviceName.Margin = new System.Windows.Forms.Padding(0);
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Size = new System.Drawing.Size(69, 13);
            this.DeviceName.TabIndex = 73;
            this.DeviceName.Text = "DeviceName";
            // 
            // DeviceModel
            // 
            this.DeviceModel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.DeviceModel.Location = new System.Drawing.Point(40, 10);
            this.DeviceModel.Margin = new System.Windows.Forms.Padding(0);
            this.DeviceModel.Name = "DeviceModel";
            this.DeviceModel.Size = new System.Drawing.Size(257, 30);
            this.DeviceModel.TabIndex = 71;
            this.DeviceModel.Text = "DeviceModel";
            // 
            // DeviceIcon
            // 
            this.DeviceIcon.Font = new System.Drawing.Font("Segoe Fluent Icons", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceIcon.Location = new System.Drawing.Point(10, 10);
            this.DeviceIcon.Margin = new System.Windows.Forms.Padding(0);
            this.DeviceIcon.Name = "DeviceIcon";
            this.DeviceIcon.Size = new System.Drawing.Size(30, 30);
            this.DeviceIcon.TabIndex = 20;
            this.DeviceIcon.Text = "";
            this.DeviceIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Firmware
            // 
            this.Firmware.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firmware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Firmware.Location = new System.Drawing.Point(90, 90);
            this.Firmware.Margin = new System.Windows.Forms.Padding(0);
            this.Firmware.Name = "Firmware";
            this.Firmware.Size = new System.Drawing.Size(330, 20);
            this.Firmware.TabIndex = 19;
            this.Firmware.Text = "Unavailable";
            this.Firmware.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Memory
            // 
            this.Memory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Memory.Location = new System.Drawing.Point(90, 70);
            this.Memory.Margin = new System.Windows.Forms.Padding(0);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(330, 20);
            this.Memory.TabIndex = 18;
            this.Memory.Text = "Unavailable";
            this.Memory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Processor
            // 
            this.Processor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Processor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Processor.Location = new System.Drawing.Point(90, 50);
            this.Processor.Margin = new System.Windows.Forms.Padding(0);
            this.Processor.Name = "Processor";
            this.Processor.Size = new System.Drawing.Size(330, 20);
            this.Processor.TabIndex = 17;
            this.Processor.Text = "Unavailable";
            this.Processor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLabel.Location = new System.Drawing.Point(10, 70);
            this.MemoryLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(80, 20);
            this.MemoryLabel.TabIndex = 16;
            this.MemoryLabel.Text = "Memory";
            this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProcessorLabel
            // 
            this.ProcessorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessorLabel.Location = new System.Drawing.Point(10, 50);
            this.ProcessorLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ProcessorLabel.Name = "ProcessorLabel";
            this.ProcessorLabel.Size = new System.Drawing.Size(80, 20);
            this.ProcessorLabel.TabIndex = 15;
            this.ProcessorLabel.Text = "Processor";
            this.ProcessorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirmwareLabel
            // 
            this.FirmwareLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirmwareLabel.Location = new System.Drawing.Point(10, 90);
            this.FirmwareLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FirmwareLabel.Name = "FirmwareLabel";
            this.FirmwareLabel.Size = new System.Drawing.Size(80, 20);
            this.FirmwareLabel.TabIndex = 14;
            this.FirmwareLabel.Text = "Firmware";
            this.FirmwareLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoPanel.BackgroundImage")));
            this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPanel.Location = new System.Drawing.Point(420, 0);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(220, 165);
            this.LogoPanel.TabIndex = 12;
            // 
            // AboutPanel
            // 
            this.AboutPanel.BackColor = System.Drawing.Color.Transparent;
            this.AboutPanel.Collapsed = true;
            this.AboutPanel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.AboutPanel.Controls.Add(this.DiscordLink);
            this.AboutPanel.Icon = "";
            this.AboutPanel.LeftContent = new string[] {
        "Version",
        "Discord",
        "Credits"};
            this.AboutPanel.Location = new System.Drawing.Point(10, 185);
            this.AboutPanel.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.RightContent = new string[] {
        "Unavailable",
        "",
        " Amir & Marcin"};
            this.AboutPanel.Rounding = 5;
            this.AboutPanel.Size = new System.Drawing.Size(640, 60);
            this.AboutPanel.TabIndex = 5;
            this.AboutPanel.Text = "About";
            this.AboutPanel.Title = "About";
            // 
            // DiscordLink
            // 
            this.DiscordLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscordLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.DiscordLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.DiscordLink.Location = new System.Drawing.Point(530, 112);
            this.DiscordLink.Name = "DiscordLink";
            this.DiscordLink.Size = new System.Drawing.Size(100, 50);
            this.DiscordLink.TabIndex = 20;
            this.DiscordLink.TabStop = true;
            this.DiscordLink.Text = "Join";
            this.DiscordLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DiscordLink.Click += new System.EventHandler(this.DiscordLink_Click);
            // 
            // About
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "About";
            this.Size = new System.Drawing.Size(660, 470);
            this.Load += new System.EventHandler(this.About_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.HardwarePanel.ResumeLayout(false);
            this.HardwarePanel.PerformLayout();
            this.AboutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel LogoPanel;
        private WoRCP.UI.RoundedPanel HardwarePanel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label FirmwareLabel;
        private System.Windows.Forms.Label Firmware;
        private System.Windows.Forms.Label Memory;
        private System.Windows.Forms.Label Processor;
        private System.Windows.Forms.Label ProcessorLabel;
        private System.Windows.Forms.Label DeviceIcon;
        private System.Windows.Forms.Label DeviceModel;
        private System.Windows.Forms.Label DeviceName;
        private System.Windows.Forms.Label SerialNumber;
        private System.Windows.Forms.Label SerialLabel;
        private System.Windows.Forms.Label Revision;
        private System.Windows.Forms.Label RevisionLabel;
        private WoRCP.UI.CollapsiblePanel AboutPanel;
        private System.Windows.Forms.LinkLabel DiscordLink;
    }
}
