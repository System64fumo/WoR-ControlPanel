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
            //Set the tab's language
            SetLanguage();

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

        #region Language
        private void SetLanguage()
        {
            ProcessorLabel.Text = Language.Strings[34];
            MemoryLabel.Text = Language.Strings[35];
            FirmwareLabel.Text = Language.Strings[36];
            RevisionLabel.Text = Language.Strings[37];
            SerialLabel.Text = Language.Strings[38];
            AboutPanel.Title = Language.Strings[39];
            AboutPanel.LeftContent[0] = Language.Strings[40];
            AboutPanel.LeftContent[1] = Language.Strings[41];
            AboutPanel.LeftContent[2] = Language.Strings[42];
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
