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
            PositionChanged(Configuration.OverlayPos);
            OpacitySlider.Value = Configuration.OverlayOpacity;
            if (Configuration.OverlayEnabled) { OverlayToggle.Toggled = Configuration.OverlayEnabled; OverlayState.Text = "Enabled"; }
            if (!Configuration.OverlayMinimal) { ChartsToggle.Toggled = !Configuration.OverlayMinimal; ChartsState.Text = "Full"; }
            if (Configuration.OverlayRounded) { StyleToggle.Toggled = Configuration.OverlayRounded; StyleState.Text = "Rounded"; }
            if (Configuration.OverlayAlwaysOnTop) { AlwaysOnTopToggle.Toggled = Configuration.OverlayAlwaysOnTop; AlwaysOnTop.Text = "Enabled"; }
            if (Configuration.OverlayPortrait) { OrientationToggle.Toggled = Configuration.OverlayPortrait; Orientation.Text = "Portrait"; }
            if (ResourceReader.trayicon.Visible) { TrayIconToggle.Toggled = ResourceReader.trayicon.Visible; TrayIconState.Text = "Enabled"; }
            if (Configuration.MinimizeToTray) { MinimizeToTrayToggle.Toggled = Configuration.MinimizeToTray; MinimizeToTrayToggle.Enabled = Configuration.MinimizeToTray; MinimizeToTrayState.Text = "Enabled"; }
            if (ConfigUtility.Values[5] != null) { TempWarningToggle.Enabled = true; }
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
            Configuration.OverlayEnabled = OverlayToggle.Toggled;
            if (OverlayToggle.Toggled)
            {
                OverlayState.Text = "Enabled";
                Configuration.overlay = new OverlayWindow();
                PositionChanged(Configuration.OverlayPos);
                Configuration.overlay.Show();
            }
            else
            {
                OverlayState.Text = "Disabled";
                Configuration.overlay.Enabled = false;
                Configuration.overlay.Dispose();
            }
        }

        //Information appearance
        private void ChartsToggle_ToggledEvent(object sender, EventArgs e)
        {
            Configuration.OverlayMinimal = ChartsToggle.Toggled;
            Configuration.overlay.ChartType();
            PositionChanged(Configuration.OverlayPos);
            if (ChartsToggle.Toggled)
            {
                ChartsState.Text = "Full";
            }
            else
            {
                ChartsState.Text = "Minimal";
            }
        }

        //Always on top
        private void AlwaysOnTopToggle_ToggledEvent(object sender, EventArgs e)
        {
            Configuration.overlay.TopMost = AlwaysOnTopToggle.Toggled;
            Configuration.OverlayAlwaysOnTop = AlwaysOnTopToggle.Toggled;
            if (AlwaysOnTopToggle.Toggled)
            {
                AlwaysOnTop.Text = "Enabled";
            }
            else
            {
                AlwaysOnTop.Text = "Disabled";
            }
        }

        //Orientation
        private void OrientationToggle_ToggledEvent(object sender, EventArgs e)
        {
            Configuration.OverlayPortrait = OrientationToggle.Toggled;
            Configuration.overlay.Orientation();
            PositionChanged(Configuration.OverlayPos);
            if (OrientationToggle.Toggled)
            {
                Orientation.Text = "Portrait";
            }
            else
            {
                Orientation.Text = "Landscape";
            }
        }

        //Rounding appearance
        private void RoundedToggle_ToggledEvent(object sender, EventArgs e)
        {
            Configuration.OverlayRounded = StyleToggle.Toggled;
            Configuration.overlay.RoundCharts();
            if (StyleToggle.Toggled)
            {
                StyleState.Text = "Rounded";
            }
            else
            {
                StyleState.Text = "Flat";
            }
        }

        //Tray icon
        private void TrayIconToggle_ToggledEvent(object sender, EventArgs e)
        {
            ResourceReader.trayicon.Visible = TrayIconToggle.Toggled;
            MinimizeToTrayToggle.Enabled = TrayIconToggle.Toggled;
            if (TrayIconToggle.Toggled)
            {
                TrayIconState.Text = "Enabled";
            }
            else
            {
                TrayIconState.Text = "Disabled";
                MinimizeToTrayState.Text = "Disabled";
                MinimizeToTrayToggle.Toggled = false;
                Configuration.MinimizeToTray = false;
            }
        }

        //Minimize to tray
        private void MinimizeToTrayToggle_ToggledEvent(object sender, EventArgs e)
        {
            Configuration.MinimizeToTray = MinimizeToTrayToggle.Toggled;
            if (MinimizeToTrayToggle.Toggled)
            {
                MinimizeToTrayState.Text = "Enabled";
            }
            else
            {
                MinimizeToTrayState.Text = "Disabled";
            }
        }

        //Temp warning
        private void TempLimitToggle_ToggledEvent(object sender, EventArgs e)
        {
            Configuration.TrayTempWarning = TempWarningToggle.Toggled;
            if (TempWarningToggle.Toggled)
            {
                TempWarningState.Text = "Enabled";
            }
            else
            {
                TempWarningState.Text = "Disabled";
            }
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
