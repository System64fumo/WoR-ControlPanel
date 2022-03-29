using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WoRCP.UI;

namespace WoRCP.Tabs
{
    public partial class About : UserControl
    {
        //Main
        #region Loading and Initalization
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            DeviceName.Text = Configuration.DeviceName;
            DeviceModel.Text = Configuration.DeviceModel;
            Processor.Text = Configuration.CPUName;
            Memory.Text = Configuration.Totalmemory.ToString() + "GB";
            Firmware.Text = Configuration.FirmwareVer;
            Revision.Text = Configuration.Revision;
            SerialNumber.Text = Configuration.SerialNo;
            AboutPanel.RightContent[0] = Configuration.Version;
            DeviceIcon.Font = new Font(Theme.glyphs.Name, 20.25f);
            if (Configuration.CPUArch == "ARM64")
            {
                DeviceIcon.Text = "";
                DeviceIcon.Image = Properties.Resources.PiLogo;
            }
        }
        #endregion

        //Controls
        #region Buttons
        private void DiscordLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.com/invite/jQCpfVK");
        }
        #endregion
    }
}
