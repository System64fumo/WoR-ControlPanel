using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WoRCP.UI;

namespace WoRCP.Tabs
{
    public partial class Settings : UserControl
    {
        //TODO: Rewrite most of the stuff in this tab

        //Main
        #region Variables
        readonly string[] Res = { "1920x1080", "1680x1050", "1600x900", "1440x900", "1366x768", "1280x800", "1280x768", "1280x720", "1024x768", "800x600" };
        #endregion

        #region Loading and Initialization
        public Settings()
        {
            InitializeComponent();
            GPUFreqSlider.Enabled = Configuration.AdvancedOC;
            GPUMemSlider.Enabled = Configuration.AdvancedOC;
            OvervoltageSlider.Enabled = Configuration.AdvancedOC;
            ForceTurboToggle.Enabled = Configuration.AdvancedOC;
            WidthTB.Text = Screen.PrimaryScreen.Bounds.Width.ToString();
            HeightTB.Text = Screen.PrimaryScreen.Bounds.Height.ToString();
        }
        private async void Settings_Load(object sender, EventArgs e)
        {
            //Set the tab's language
            SetLanguage();

            //Update the wallpaper on the screen preview panel
            WallpaperpPreview();

            //Change glyphs
            IssuesIcon.Font = new Font(Theme.glyphs.Name, 20.25f);
            label5.Font = new Font(Theme.glyphs.Name, 48f);

            //Add a button for every resolution in the resolution list
            ConfigureResolutions();

            Configure();
        }
        #endregion

        #region Language
        private void SetLanguage()
        {
            SaveButton.ButtonText = Language.Strings[6];
            RefreshButton.ButtonText = Language.Strings[7];
            DefaultsButton.ButtonText = Language.Strings[8];

            OverclockingPanel.Title = Language.Strings[66];
            OverclockingPanel.LeftContent[0] = Language.Strings[67];
            OverclockingPanel.LeftContent[1] = Language.Strings[68];
            OverclockingPanel.LeftContent[2] = Language.Strings[69];
            OverclockingPanel.LeftContent[3] = Language.Strings[70];
            OverclockingPanel.LeftContent[4] = Language.Strings[71];

            DisplayPanel.Title = Language.Strings[72];
            DisplayPanel.LeftContent[4] = Language.Strings[73];
            DisplayPanel.LeftContent[5] = Language.Strings[74];
            DisplayPanel.LeftContent[5] = Language.Strings[75];

            OtherPanel.Title = Language.Strings[76];
            OtherPanel.LeftContent[1] = Language.Strings[77];
        }
        #endregion

        //Methods
        #region Resolution button
        private void SaveCustomRes_Click(object sender, EventArgs e)
        {
            //Getting information from the current selected button
            ConfigUtility.Width = WidthTB.Text;     //Get the selected Width from the textbox
            ConfigUtility.Height = HeightTB.Text;   //Get the selected Height from the textbox
            ConfigUtility.Refresh = RefreshTB.Text; //Get the selected Refresh rate from the textbox

            //Configuring ConfigUtility's resolution values
            ConfigUtility.Values[9] = ConfigUtility.Width + " " + ConfigUtility.Height + " " + ConfigUtility.Refresh; //Set the HDMI_CVT= line according to the new resolution information
            ConfigUtility.Values[10] = "2";     //Add to hdmi_mode=2 config.txt
            ConfigUtility.Values[11] = "87";    //Add hdmi_mode=87 to config.txt

            //Check if the selected resolution matches the current screen resolution, if it does then write null to the resolution lines in ConfigUtility
            if (ConfigUtility.Width == Screen.PrimaryScreen.Bounds.Width.ToString() && ConfigUtility.Height == Screen.PrimaryScreen.Bounds.Height.ToString())
            {
                ConfigUtility.Values[9] = null;
                ConfigUtility.Values[10] = null;
                ConfigUtility.Values[11] = null;
            }

            //After selection set every resolution button's color to Bright panel (Unselected)
            foreach (RoundedButton b in ResolutionList.Controls.OfType<RoundedButton>()) { b.Color = Theme.BrightPanel; }
            SaveButton.Color = Theme.Accent;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            //Theming
            foreach (RoundedButton b in ResolutionList.Controls.OfType<RoundedButton>()) { b.Color = Theme.BrightPanel; } //After selection set every resolution button's color to Bright panel (Unselected)
            RoundedButton button = (sender as RoundedButton); //Get the current selected button
            button.Color = Theme.Accent; //Set current selected button's color to Accent

            //Getting information from the current selected button
            ConfigUtility.Width = button.ButtonText.Remove(button.ButtonText.IndexOf("x"));     //Get the selected Width from the button
            ConfigUtility.Height = button.ButtonText.Replace(ConfigUtility.Width + "x", "");    //Get the selected Height from the button
            ConfigUtility.Refresh = "60";

            //Configuring ConfigUtility's resolution values
            ConfigUtility.Values[9] = ConfigUtility.Width + " " + ConfigUtility.Height + " " + ConfigUtility.Refresh; //Set the HDMI_CVT= line according to the new resolution information
            ConfigUtility.Values[10] = "2";     //Add to hdmi_mode=2 config.txt
            ConfigUtility.Values[11] = "87";    //Add hdmi_mode=87 to config.txt

            //Check if the selected resolution matches the current screen resolution, if it does then write null to the resolution lines in ConfigUtility
            if (ConfigUtility.Width == Screen.PrimaryScreen.Bounds.Width.ToString() && ConfigUtility.Height == Screen.PrimaryScreen.Bounds.Height.ToString())
            {
                ConfigUtility.Values[9] = null;
                ConfigUtility.Values[10] = null;
                ConfigUtility.Values[11] = null;
            }
            SaveButton.Color = Theme.Accent;
        }
        #endregion

        #region Wallpaper preview
        private void WallpaperpPreview()
        {
            try
            {
                Image Wallpaper = new Bitmap(Image.FromFile(Configuration.Wallpaper), new Size(Desktop.Width - 10, Desktop.Height - 10));
                Desktop.BackgroundImage = ImageManipulation.OverlayImage(Wallpaper, Desktop.BackgroundImage, 5, 5, 0, 0);
                Wallpaper.Dispose();
            }
            catch (Exception ex)
            {
                Program.Log("[Error] Unable to get wallpaper.");
                Program.Log("[Exception] " + ex);
            }
        }
        #endregion

        #region Resolution buttons
        private void ConfigureResolutions()
        {
            foreach (string R in Res)
            {
                RoundedButton Button = new RoundedButton
                {
                    Size = new Size(256, 35),
                    ButtonText = R,
                    Color = Theme.BrightPanel,
                    Margin = new Padding(0, 0, 0, 5)
                };
                Button.Click += Btn_Click;
                ResolutionList.Controls.Add(Button);
                string width = Button.ButtonText.Remove(Button.ButtonText.IndexOf("x"));
                string height = Button.ButtonText.Replace(width + "x", "");
            }
            CustomResolutionPanel.SendToBack();
        }
        #endregion

        #region Configure the controls
        private void Configure() //Sets the values of the sliders and toggles based on the config
        {
            try
            {
                if (Configuration.BootMounted)
                {
                    ConfigUtility.Read();
                    for (int i = 0; i < ConfigUtility.Values.Length; i++)
                    {
                        if (ConfigUtility.Values[i] != null)
                        {
                            int val = Convert.ToInt32(ConfigUtility.Values[i]);
                            switch (i)
                            {
                                case 0: //Arm_Freq=
                                    CPUSlider.Value = val / 1000.0;
                                    CPUFreq.Text = Math.Round(CPUSlider.Value, 1) + "GHz";
                                    break;
                                case 1: //GPU_Freq=
                                    GPUFreqSlider.Value = (val - 250) / 50;
                                    GPUFreq.Text = 250 + (GPUFreqSlider.Value * 50) + "MHz";
                                    break;
                                case 2: //GPU_Mem=
                                    GPUMemSlider.Value = val / 32.0;
                                    GPUMem.Text = GPUMemSlider.Value * 32 + "MB";
                                    break;
                                case 3: //Over_Voltage=
                                    OvervoltageSlider.Value = val;
                                    Overvoltage.Text = OvervoltageSlider.Value.ToString();
                                    break;
                                case 4: //Force_Turbo=
                                    ForceTurbo.Text = Language.State(Convert.ToBoolean(val));
                                    ForceTurboToggle.Toggled = Convert.ToBoolean(val);
                                    break;
                                case 5: //Temp_Limit=
                                        //TODO: Add temp limit GUI Option
                                    break;
                                case 6: //Disable_Overscan=
                                    DisplayPanel.RightContent[4] = Language.State(!Convert.ToBoolean(val)) + Program.Spacing(6);
                                    OverscanToggle.Toggled = !Convert.ToBoolean(val);
                                    break;
                                case 7: //Disable_Splash=
                                    DisplayPanel.RightContent[6] = Language.State(!Convert.ToBoolean(val)) + Program.Spacing(6);
                                    SplashToggle.Toggled = !Convert.ToBoolean(val);
                                    break;
                                case 8: //HDMI_Force_Hotplug=
                                    DisplayPanel.RightContent[5] = Language.State(Convert.ToBoolean(val)) + Program.Spacing(6);
                                    HotplugToggle.Toggled = Convert.ToBoolean(val);
                                    break;
                            }
                        }
                    }

                    //Set the config Viewer's text
                    Config.Text = "";
                    foreach (string i in File.ReadAllLines(ConfigUtility.path))
                    {
                        Config.Text += i + Environment.NewLine;
                    }

                    //Find the current screen resolution and make it's button highlighted
                    foreach (RoundedButton b in ResolutionList.Controls.OfType<RoundedButton>())
                    {
                        string width = b.ButtonText.Remove(b.ButtonText.IndexOf("x"));
                        string height = b.ButtonText.Replace(width + "x", "");
                        if (width == ConfigUtility.Width && height == ConfigUtility.Height)
                        {
                            b.Color = Theme.Accent;
                        }
                    }

                    //Change labels text
                    IssuesIcon.Text = "";
                    Issues.Text = Language.Strings[60];
                    BootMessageLabel.Text = Language.Strings[64] + " (B:)";
                    MountButton.ButtonText = Language.Strings[10];

                    //Check for any issues
                    checkConfig();
                }
                else
                {
                    IssuesIcon.Text = "";
                    PiLabel.Text = Language.Strings[55];
                    Issues.Text = Language.Strings[62];
                    Config.Text = Language.Strings[65];
                    BootMessageLabel.Text = Language.Strings[63];
                    MountButton.ButtonText = Language.Strings[9];
                }
                OverclockingPanel.Enabled = Configuration.BootMounted;
                DisplayPanel.Enabled = Configuration.BootMounted;
                OtherPanel.Enabled = Configuration.BootMounted;
            }
            catch (Exception ex)
            {
                Program.Log("[Exception] " + ex);
            }
        }
        #endregion

        #region Config checker
        private void checkConfig()
        {
            int armfreq = Convert.ToInt32(ConfigUtility.Values[0]);
            int gpufreq = Convert.ToInt32(ConfigUtility.Values[1]);
            int gpumem = Convert.ToInt32(ConfigUtility.Values[2]);
            int overvoltage = Convert.ToInt32(ConfigUtility.Values[3]);
            int forceturbo = Convert.ToInt32(ConfigUtility.Values[4]);
            int templimit = Convert.ToInt32(ConfigUtility.Values[5]);



            //Check if pi is overclocked or not
            if (armfreq == Convert.ToInt32(ConfigUtility.StockValues[0]))  //Stock
            {
                PiLabel.Text = Language.Strings[56];
                OverclockingPanel.Icon = "";
            }
            else if (armfreq > Convert.ToInt32(ConfigUtility.StockValues[0])) //Overclocked
            {
                PiLabel.Text = Language.Strings[57] +"(" + armfreq / 1000.0 + "GHz)";
                OverclockingPanel.Icon = "";
            }
            else if (armfreq < Convert.ToInt32(ConfigUtility.StockValues[0])) //Underclocked
            {
                PiLabel.Text = Language.Strings[58] + "(" + armfreq / 1000.0 + "GHz)";
                OverclockingPanel.Icon = "";
            }
            OverclockingPanel.Invalidate();
            Configuration.DeviceModel = "Raspberry Pi 4 Model B";
            if (armfreq > 2300 && Configuration.DeviceModel == "Raspberry Pi 4 Model B")
            {
                Issues.Text = Language.Strings[69];
            }
        }
        #endregion

        //Controls
        #region Buttons
        private void SaveButton_Click(object sender, EventArgs e)
        {
            ConfigUtility.Write();
            SaveButton.Color = Theme.Inactive;
            Configure();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Configure();
        }

        private void DefaultsButton_Click(object sender, EventArgs e)
        {
            ConfigUtility.Values = new string[ConfigUtility.Values.Length];
            ConfigUtility.Write();
            SaveButton.Color = Theme.Inactive;
            Configure();
        }

        private void MountButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(ConfigUtility.path)) //Unmount boot partition
            {
                Configuration.BootMounted = false;
                Process.Start("CMD", "/C mountvol B: /D");
                OverclockingPanel.Collapsed = true;
                DisplayPanel.Collapsed = true;
                OtherPanel.Collapsed = true;
            }
            else //Mount boot partition
            {
                Configuration.BootMounted = true;
                Process.Start("CMD", "/C mountvol B: /s");
                while (!Directory.Exists(@"B:\")) { } //Wait until boot partition is mounted
            }
            Configure();
        }

        private void ConfigEditorButton_Click(object sender, EventArgs e)
        {
            Process.Start(ConfigUtility.path);
        }

        private void ConfigDocsButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.raspberrypi.com/documentation/computers/config_txt.html");
        }
        #endregion

        #region Toggles
        private void ForceTurboToggle_ToggledEvent(object sender, EventArgs e)
        {
            ForceTurbo.Text =  Language.State(ForceTurboToggle.Toggled);
            ConfigUtility.Values[4] = Convert.ToInt32(ForceTurboToggle.Toggled).ToString();
            SaveButton.Color = Theme.Accent;
        }
        private void OverscanToggle_ToggledEvent(object sender, EventArgs e)
        {
            DisplayPanel.RightContent[4] = Language.State(OverscanToggle.Toggled) + Program.Spacing(6);
            ConfigUtility.Values[6] = Convert.ToInt32(!OverscanToggle.Toggled).ToString();
            SaveButton.Color = Theme.Accent;
            DisplayPanel.Invalidate();
        }

        private void HotplugToggle_ToggledEvent(object sender, EventArgs e)
        {
            DisplayPanel.RightContent[5] = Language.State(HotplugToggle.Toggled) + Program.Spacing(6);
            ConfigUtility.Values[8] = Convert.ToInt32(HotplugToggle.Toggled).ToString();
            SaveButton.Color = Theme.Accent;
            DisplayPanel.Invalidate();
        }

        private void SplashToggle_ToggledEvent(object sender, EventArgs e)
        {
            DisplayPanel.RightContent[6] = Language.State(SplashToggle.Toggled) + Program.Spacing(6);
            ConfigUtility.Values[7] = Convert.ToInt32(!SplashToggle.Toggled).ToString();
            SaveButton.Color = Theme.Accent;
            DisplayPanel.Invalidate();
        }
        #endregion

        #region Sliders
        private void CPUSlider_Selecting(object sender, EventArgs e)
        {
            if (Configuration.AdvancedOC)
            {
                ConfigUtility.Values[0] = (Math.Round(CPUSlider.Value, 1) * 1000).ToString();
                CPUFreq.Text = Math.Round(CPUSlider.Value, 1) + "GHz";
                SaveButton.Color = Theme.Accent;
            }
            else //Advanced overclocking
            {
                double armfreq = Math.Round(CPUSlider.Value, 1);
                ConfigUtility.Values[0] = (armfreq * 1000).ToString();
                if (armfreq >= 2.1) //Check if force turbo is required (TODO Fix for rpi 3)
                {
                    ConfigUtility.Values[4] = "1"; ForceTurbo.Text = "Enabled";
                    ForceTurboToggle.Toggled = true;
                }
                else
                {
                    ConfigUtility.Values[4] = "0"; ForceTurbo.Text = "Disabled";
                    ForceTurboToggle.Toggled = false;
                }
                ConfigUtility.Values[3] = Convert.ToInt32((armfreq - 1.5) * (armfreq * 6.5)).ToString();
                OvervoltageSlider.Value = Convert.ToInt32(ConfigUtility.Values[3]);
                Overvoltage.Text = ConfigUtility.Values[3];

                CPUFreq.Text = Math.Round(CPUSlider.Value, 1) + "GHz";
                SaveButton.Color = Theme.Accent;
            }
        }
        private void GPUFreqSlider_Selecting(object sender, EventArgs e)
        {
            ConfigUtility.Values[1] = (250 + (GPUFreqSlider.Value * 50)).ToString();
            GPUFreq.Text = 250 + (GPUFreqSlider.Value * 50) + "MHz";
            SaveButton.Color = Theme.Accent;
        }
        private void GPUMemSlider_Selecting(object sender, EventArgs e)
        {
            ConfigUtility.Values[2] = (GPUMemSlider.Value * 32).ToString();
            GPUMem.Text = GPUMemSlider.Value * 32 + "MB";
            SaveButton.Color = Theme.Accent;
        }
        private void OvervoltageSlider_Selecting(object sender, EventArgs e)
        {
            ConfigUtility.Values[3] = OvervoltageSlider.Value.ToString();
            Overvoltage.Text = OvervoltageSlider.Value.ToString();
            SaveButton.Color = Theme.Accent;
        }
        #endregion
    }
}