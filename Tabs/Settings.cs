using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WoRCP.Tabs
{
    public partial class Settings : UserControl
    {
        //Main
        #region Variables
        double Freq;
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
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            //Wallpaper preview
            try
            {
                Image Wallpaper = new Bitmap(Image.FromFile(Configuration.Wallpaper), new Size(Desktop.Width - 10, Desktop.Height - 10));
                Desktop.BackgroundImage = ImageManipulation.OverlayImage(Wallpaper, Desktop.BackgroundImage, 5, 5, 0, 0);
                Wallpaper.Dispose();
            }
            catch
            {
                Program.Log("[Error] Unable to get wallpaper.");
            }

            //Add a button for every resolution in the resolution list
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
            MountCheck();
        }
        #endregion

        //Methods
        #region Resolution button
        private void Btn_Click(object sender, EventArgs e)
        {
            foreach (RoundedButton b in ResolutionList.Controls) { b.Color = Theme.BrightPanel; }
            RoundedButton button = (sender as RoundedButton);
            button.Color = Theme.Accent;
            string width = button.ButtonText.Remove(button.ButtonText.IndexOf("x"));
            string height = button.ButtonText.Replace(width + "x", "");
            Configuration.width = width;
            Configuration.height = height;
            Configuration.Video = true;
            if (width != Screen.PrimaryScreen.Bounds.Width.ToString() && height != Screen.PrimaryScreen.Bounds.Height.ToString())
            {
                Configuration.Video = true;
            }
            else
            {
                Configuration.Video = false;
            }
            Program.WriteConfig();
        }
        #endregion

        #region Configure the app
        private void Configure()
        {
            if (Configuration.configfound)
            {
                try
                {
                    Freq = (double.Parse(Configuration.armfreq));
                    CPUSlider.Value = Freq / 1000;
                    CPUFreq.Text = Math.Round(CPUSlider.Value, 1) + " GHz";

                    GPUFreqSlider.Value = ((int.Parse(Configuration.gpufreq) - 250) / 50);
                    GPUFreq.Text = 250 + (GPUFreqSlider.Value * 50) + " MHz";

                    GPUMemSlider.Value = (double.Parse(Configuration.gpumem)) / 32;
                    GPUMem.Text = GPUMemSlider.Value * 32 + " MB";

                    OvervoltageSlider.Value = (double.Parse(Configuration.overvoltage));
                    Overvoltage.Text = OvervoltageSlider.Value.ToString();
                }
                catch
                {
                    Program.Log("[Warn] Unable to read config assuming it's stock");
                }
                if (Configuration.disableoverscan == "0")
                {
                    OverscanState.Text = "Enabled";
                    OverscanToggle.Toggled = true;
                }
                if (Configuration.forcehotplug == "1")
                {
                    HotplugState.Text = "Enabled";
                    HotplugToggle.Toggled = true;
                }
                if (Configuration.forceturbo == "1")
                {
                    ForceTurbo.Text = "Enabled";
                    ForceTurboToggle.Toggled = true;
                }

                //Overclocking panel icon
                //TODO: Use percentage instead of static values to
                //check what the icon should look like.
                //For now it can assmue that every board is a Pi 4
                if (Freq <= 1100)
                { OverclockingPanel.Icon = ""; }
                if (1200 <= Freq && Freq <= 1700)
                { OverclockingPanel.Icon = ""; }
                if (Freq >= 1800)
                { OverclockingPanel.Icon = ""; }
                CheckOC();
            }
        }
        #endregion

        #region Boot partition checker
        private void MountCheck()
        {
            if (Configuration.BootMounted)
            {
                if (File.Exists(@"B:\Config.txt"))
                {
                    Configuration.configfound = true;
                    Config.Text = "";
                    try
                    {
                        foreach (string i in File.ReadAllLines(@"B:\Config.txt"))
                        {
                            Config.Text += i + Environment.NewLine;
                        }
                    }
                    catch
                    {
                        Program.Log("[Error] Unable to find config.txt");
                    }
                    IssuesIcon.Text = "";
                    Issues.Text = "No issues found";
                    BootMessageLabel.Text = "Your boot partition is mounted and can be accessed from \n Drive (B:)";
                    MountButton.ButtonText = "Unmount";
                    Program.ReadConfig();
                    CheckOC();
                    ResCheck();
                    Configure();
                }
            }
            else
            {
                IssuesIcon.Text = "";
                PiLabel.Text = "Unable to read config.txt";
                Issues.Text = "Boot partition is not mounted";
                Config.Text = "Your config.txt will be shown here once you mount your boot partition\n";
                BootMessageLabel.Text = "Please mount your boot partition \n to be able to overclock";
                MountButton.ButtonText = "Mount";
            }
            OverclockingPanel.Enabled = Configuration.BootMounted;
            DisplayPanel.Enabled = Configuration.BootMounted;
            OtherPanel.Enabled = Configuration.BootMounted;
        }
        #endregion

        #region Resolution checker
        private void ResCheck()
        {
            foreach (RoundedButton b in ResolutionList.Controls)
            {
                string width = b.ButtonText.Remove(b.ButtonText.IndexOf("x"));
                string height = b.ButtonText.Replace(width + "x", "");
                if (width == Configuration.width && height == Configuration.height)
                {
                    b.Color = Theme.Accent;
                }
            }
        }
        #endregion

        #region Overclock checker
        private void CheckOC()
        {
            if (Convert.ToInt32(Configuration.armfreq) > 2100 && Configuration.forceturbo != "1")
            {

            }
            //Check if pi is overclocked or not
            if (Convert.ToInt32(Configuration.armfreq) > Convert.ToInt32(Configuration.StockClock))
            {
                PiLabel.Text = "Your Pi is overclocked (" + Convert.ToDouble(Configuration.armfreq) / 1000 + "GHz)";
            }
            else if (Convert.ToInt32(Configuration.armfreq) < Convert.ToInt32(Configuration.StockClock))
            {
                PiLabel.Text = "Your Pi is underclocked (" + Convert.ToDouble(Configuration.armfreq) / 1000 + "GHz)";
            }
            else
            {
                PiLabel.Text = "Your Pi is running at stock speeds";
            }
        }
        #endregion

        //Controls
        #region Buttons
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Program.WriteConfig();
            SaveButton.Color = Theme.Inactive;
            MountCheck();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            MountCheck();
        }

        private void DefaultsButton_Click(object sender, EventArgs e)
        {
            //TODO: Replace this button with a different section to showcase
            //the current overclock instead of the config viewer
            //For now implement defaults for rpi 4
            Configuration.armfreq = "1500";
            Configuration.gpufreq = "500";
            Configuration.gpumem = "32";
            Configuration.overvoltage = "0";
            Configuration.forceturbo = "0";

            Program.WriteConfig();
            SaveButton.Color = Theme.BrightPanel;
            MountCheck();
            Configure();
        }

        private void MountButton_Click(object sender, EventArgs e)
        {
            if (Configuration.BootMounted) //Unmount boot partition
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
                Program.ReadConfig();
            }
            MountCheck();
        }

        private void ConfigEditorButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"B:\Config.txt");
        }

        private void ConfigDocsButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.raspberrypi.com/documentation/computers/config_txt.html");
        }
        #endregion

        #region Toggles
        private void ForceTurboToggle_ToggledEvent(object sender, EventArgs e)
        {
            if (ForceTurboToggle.Toggled) { ForceTurbo.Text = "Enabled"; }
            else { ForceTurbo.Text = "Disabled"; }
            Configuration.forceturbo = Convert.ToInt32(ForceTurboToggle.Toggled).ToString();
            SaveButton.Color = Theme.Accent;
        }
        private void OverscanToggle_ToggledEvent(object sender, EventArgs e)
        {
            if (OverscanToggle.Toggled) { OverscanState.Text = "Enabled"; }
            else { OverscanState.Text = "Disabled"; }
            Configuration.disableoverscan = Convert.ToInt32(!OverscanToggle.Toggled).ToString();
            SaveButton.Color = Theme.Accent;
        }

        private void HotplugToggle_ToggledEvent(object sender, EventArgs e)
        {
            if (HotplugToggle.Toggled) { HotplugState.Text = "Enabled"; }
            else { HotplugState.Text = "Disabled"; }
            Configuration.forcehotplug = Convert.ToInt32(HotplugToggle.Toggled).ToString();
            SaveButton.Color = Theme.Accent;
        }
        #endregion

        #region Sliders
        private void CPUSlider_Selecting(object sender, EventArgs e)
        {
            if (Configuration.AdvancedOC)
            {
                Configuration.armfreq = (Math.Round(CPUSlider.Value, 1) * 1000).ToString();
                CPUFreq.Text = Math.Round(CPUSlider.Value, 1) + " GHz";
                SaveButton.Color = Theme.Accent;
            }
            else
            {
                double armfreq = Math.Round(CPUSlider.Value, 1);
                Configuration.armfreq = (armfreq * 1000).ToString();
                if (armfreq >= 2.1)
                {
                    Configuration.forceturbo = "1"; ForceTurbo.Text = "Enabled";
                    ForceTurboToggle.Toggled = true;
                }
                else
                {
                    Configuration.forceturbo = "0"; ForceTurbo.Text = "Disabled";
                    ForceTurboToggle.Toggled = false;
                }
                Configuration.overvoltage = Convert.ToInt32((armfreq - 1.5) * (armfreq * 6.5)).ToString();
                OvervoltageSlider.Value = Convert.ToInt32(Configuration.overvoltage);
                Overvoltage.Text = Configuration.overvoltage;

                CPUFreq.Text = Math.Round(CPUSlider.Value, 1) + " GHz";
                SaveButton.Color = Theme.Accent;
            }
        }
        private void GPUFreqSlider_Selecting(object sender, EventArgs e)
        {
            Configuration.gpufreq = (250 + (GPUFreqSlider.Value * 50)).ToString();
            GPUFreq.Text = 250 + (GPUFreqSlider.Value * 50) + " MHz";
            SaveButton.Color = Theme.Accent;
        }
        private void GPUMemSlider_Selecting(object sender, EventArgs e)
        {
            Configuration.gpumem = (GPUMemSlider.Value * 32).ToString();
            GPUMem.Text = GPUMemSlider.Value * 32 + " MB";
            SaveButton.Color = Theme.Accent;
        }
        private void OvervoltageSlider_Selecting(object sender, EventArgs e)
        {
            Configuration.overvoltage = OvervoltageSlider.Value.ToString();
            Overvoltage.Text = OvervoltageSlider.Value.ToString();
            SaveButton.Color = Theme.Accent;
        }
        #endregion
    }
}