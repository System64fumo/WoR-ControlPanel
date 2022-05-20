using System;
using System.Windows.Forms;
using System.Device.I2c;

namespace WoRCP.Tabs
{
    public partial class ArgonOneFan: UserControl, IDisposable
    {
        // Main
        #region Variables
        private I2cDevice i2cDevice;
        private string offText = "Off";

        #endregion

        #region Loading and Initialization
        public ArgonOneFan()
        {
            InitializeComponent();
        }

        private void ArgonOneFan_Load(object sender, EventArgs e)
        {
            // SetLanguage();
        }

        private void ArgonOneFan_VisibleChanged(object sender, EventArgs e)
        {
            if (Configuration.CPUArch != "ARM64")
            {
                return;
            }

            if (Visible)
            {
                InitializeI2C();
            }
            else
            {
                DisposeI2C();
            }
        }
        #endregion

        #region Language
        private void SetLanguage()
        {
            // 95, 96, 97
            FanSpeedPanelPanel.Title = Language.Strings[95];
            FanSpeedPanelPanel.LeftContent[0] = Language.Strings[96];
            offText = Language.Strings[97];
            FanSpeedLabel.Text = offText;
        }
        #endregion
        // Methods
        #region Initialize and dispose I2C
        private void InitializeI2C()
        {
            try
            {
                if (i2cDevice == null)
                {
                    var busId = 1;
                    var deviceAddress = 0x1a;
                    var connectionSettings = new I2cConnectionSettings(busId, deviceAddress);
                    i2cDevice = I2cDevice.Create(connectionSettings);
                    FanSpeedSlider.Enabled = true;
                }
            }
            catch (Exception e)
            {
                FanSpeedSlider.Enabled = false;
                Program.Log("[Error] Unable to initialize I2C\n" + e.Message);
            }
        }

        private void DisposeI2C()
        {
            if (i2cDevice != null)
            {
                i2cDevice.Dispose();
                i2cDevice = null;
                FanSpeedSlider.Enabled = false;
            }
        }
        #endregion

        #region Slides selecting
        private void FanSpeedSlider_Selecting(object sender, EventArgs e)
        {
            // Update label
            var selectedSpeed = (byte)FanSpeedSlider.Value;
            if (selectedSpeed == 0)
            {
                FanSpeedLabel.Text = offText;
            }
            else
            {
                FanSpeedLabel.Text = selectedSpeed.ToString();
            }
        }

        private void FanSpeedSlider_Selected(object sender, EventArgs e)
        {
            // Update fan speed
            var selectedSpeed = (byte)FanSpeedSlider.Value;
            if (i2cDevice != null)
            {
                i2cDevice.Write(new byte[] { selectedSpeed });
            }
        }
        #endregion

    }
}
