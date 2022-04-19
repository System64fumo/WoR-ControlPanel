using System;
using System.Drawing;
using System.Windows.Forms;
using WoRCP.UI;

namespace WoRCP.Tabs
{
    public partial class Overlay : UserControl
    {
        //Main
        #region Loading and Initalization
        public Overlay()
        {
            InitializeComponent();
        }

        private void Overlay_Load(object sender, EventArgs e)
        {
            //Set the tab's language
            SetLanguage();

            PositionChanged(Configuration.OverlayPos);
            OpacitySlider.Value = Configuration.OverlayOpacity;

            //Toggles
            OverlayToggle.Toggled = Configuration.OverlayEnabled;
            ChartsToggle.Toggled = Configuration.OverlayMinimal;
            StyleToggle.Toggled = Configuration.OverlayRounded;
            AlwaysOnTopToggle.Toggled = Configuration.OverlayAlwaysOnTop;
            OrientationToggle.Toggled = Configuration.OverlayPortrait;
            TrayIconToggle.Toggled = ResourceReader.trayicon.Visible;
            MinimizeToTrayToggle.Toggled = Configuration.MinimizeToTray;
            MinimizeToTrayToggle.Enabled = Configuration.MinimizeToTray;
            TempWarningToggle.Enabled = (ConfigUtility.Values[5] != "0");
        }
        #endregion

        #region Language
        private void SetLanguage()
        {
            collapsiblePanel1.Title = Language.Strings[43];
            collapsiblePanel1.LeftContent[0] = Language.Strings[44];
            collapsiblePanel1.LeftContent[1] = Language.Strings[45];

            collapsiblePanel3.Title = Language.Strings[46];
            collapsiblePanel3.LeftContent[0] = Language.Strings[47];
            collapsiblePanel3.LeftContent[1] = Language.Strings[48];
            collapsiblePanel3.LeftContent[2] = Language.Strings[49];
            collapsiblePanel3.LeftContent[3] = Language.Strings[50];

            collapsiblePanel2.Title = Language.Strings[51];
            collapsiblePanel2.LeftContent[0] = Language.Strings[52];
            collapsiblePanel2.LeftContent[1] = Language.Strings[53];
            collapsiblePanel2.LeftContent[2] = Language.Strings[54];

            OverlayState.Text = Language.State(Configuration.OverlayEnabled);
            ChartsState.Text = Language.State(Configuration.OverlayMinimal);
            StyleState.Text = Language.State(Configuration.OverlayRounded);
            AlwaysOnTop.Text = Language.State(Configuration.OverlayAlwaysOnTop);
            Orientation.Text = Language.State(Configuration.OverlayPortrait);
            MinimizeToTrayState.Text = Language.State(Configuration.MinimizeToTray);
            TrayIconState.Text = Language.State(ResourceReader.trayicon.Visible);
            TempWarningState.Text = Language.State(Configuration.TrayTempWarning);

        }
        #endregion

        //Methods
        #region Changing positions
        private void PositionChanged(int pos)
        {
            int width = Convert.ToInt32(ConfigUtility.Width);
            int height = Convert.ToInt32(ConfigUtility.Height);
            TopLeftBTN.Color = Theme.Accent;
            TopRightBTN.Color = Theme.Accent;
            BottomLeftBTN.Color = Theme.Accent;
            BottomRightBTN.Color = Theme.Accent;
            switch (pos)
            {
                case 1:
                    Configuration.OverlayPos = pos;
                    Configuration.overlay.Location = new Point(width - Configuration.overlay.Width, 0);
                    TopRightBTN.Color = Theme.DarkAccent;
                    break;
                case 2:
                    Configuration.OverlayPos = pos;
                    Configuration.overlay.Location = new Point(0, height - Configuration.overlay.Height);
                    BottomLeftBTN.Color = Theme.DarkAccent;
                    break;
                case 3:
                    Configuration.OverlayPos = pos;
                    Configuration.overlay.Location = new Point(width - Configuration.overlay.Width, height - Configuration.overlay.Height);
                    BottomRightBTN.Color = Theme.DarkAccent;
                    break;
                default:
                    Configuration.OverlayPos = pos;
                    Configuration.overlay.Location = new Point(0, 0);
                    TopLeftBTN.Color = Theme.DarkAccent;
                    break;
            }
        }
        #endregion

        //Controls
        #region Buttons
        //Change the position of the overlay
        private void TopLeftBTN_Click(object sender, EventArgs e) { PositionChanged(0); }
        private void TopRightBTN_Click(object sender, EventArgs e) { PositionChanged(1); }
        private void BottomLeftBTN_Click(object sender, EventArgs e) { PositionChanged(2); }
        private void BottomRightBTN_Click(object sender, EventArgs e) { PositionChanged(3); }
        #endregion

        #region Toggles
        //Overlay
        public void OverlayToggle_ToggledEvent(object sender, EventArgs e)
        {
            ResourceReader.timer.Enabled = TrayIconToggle.Toggled;
            Configuration.OverlayEnabled = OverlayToggle.Toggled;
            OverlayState.Text = Language.State(OverlayToggle.Toggled);
            if (!OverlayToggle.Toggled)
            {

                Configuration.overlay.Enabled = false;
                Configuration.overlay.Dispose();
                return;
            }

            Configuration.overlay = new OverlayWindow();
            PositionChanged(Configuration.OverlayPos);
            Configuration.overlay.Show();
        }

        //Information appearance
        private void ChartsToggle_ToggledEvent(object sender, EventArgs e)
        {
            Configuration.OverlayMinimal = ChartsToggle.Toggled;
            Configuration.overlay.ChartType();
            PositionChanged(Configuration.OverlayPos);
            ChartsState.Text = Language.State(ChartsToggle.Toggled);
        }

        //Always on top
        private void AlwaysOnTopToggle_ToggledEvent(object sender, EventArgs e)
        {
            Configuration.overlay.TopMost = AlwaysOnTopToggle.Toggled;
            Configuration.OverlayAlwaysOnTop = AlwaysOnTopToggle.Toggled;
            AlwaysOnTop.Text = Language.State(AlwaysOnTopToggle.Toggled);
        }

        //Orientation
        private void OrientationToggle_ToggledEvent(object sender, EventArgs e)
        {
            Configuration.OverlayPortrait = OrientationToggle.Toggled;
            Configuration.overlay.Orientation();
            PositionChanged(Configuration.OverlayPos);
            Orientation.Text = Language.State(OrientationToggle.Toggled);
        }

        //Rounding appearance
        private void RoundedToggle_ToggledEvent(object sender, EventArgs e)
        {
            Configuration.OverlayRounded = StyleToggle.Toggled;
            Configuration.overlay.RoundCharts();
            StyleState.Text = Language.State(StyleToggle.Toggled);
        }

        //Tray icon
        private void TrayIconToggle_ToggledEvent(object sender, EventArgs e)
        {
            ResourceReader.timer.Enabled = TrayIconToggle.Toggled;
            ResourceReader.trayicon.Visible = TrayIconToggle.Toggled;
            MinimizeToTrayToggle.Enabled = TrayIconToggle.Toggled;
            TrayIconState.Text = Language.State(TrayIconToggle.Toggled);
            if (!TrayIconToggle.Toggled)
            {
                MinimizeToTrayState.Text = "Disabled";
                MinimizeToTrayToggle.Toggled = false;
                Configuration.MinimizeToTray = false;
                return;
            }
        }

        //Minimize to tray
        private void MinimizeToTrayToggle_ToggledEvent(object sender, EventArgs e)
        {
            Configuration.MinimizeToTray = MinimizeToTrayToggle.Toggled;
            MinimizeToTrayState.Text = Language.State(MinimizeToTrayToggle.Toggled);
        }

        //Temp warning
        private void TempLimitToggle_ToggledEvent(object sender, EventArgs e)
        {
            Configuration.TrayTempWarning = TempWarningToggle.Toggled;
            TempWarningState.Text = Language.State(TempWarningToggle.Toggled);
        }
        #endregion

        #region Sliders
        //Opacity slider
        private void OpacitySlider_Selecting(object sender, EventArgs e)
        {
            OpacityState.Text = OpacitySlider.ValueP.ToString() + "%";
            Configuration.overlay.Opacity = OpacitySlider.Value / 100;
        }
        #endregion
    }
}
