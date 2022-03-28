using System;
using System.Drawing;
using System.Windows.Forms;
using WoRCP.UI;

namespace WoRCP
{
    public partial class OverlayWindow : Form
    {
        //Main
        #region Variables
        public static Size ChartSize = new Size(200, 125);
        #endregion

        #region Loading and Initialization
        public OverlayWindow()
        {
            InitializeComponent();

        }

        private void OverlayWindow_Load(object sender, EventArgs e)
        {
            ResourceReader.timer.Enabled = true;
            ThemeOverlay();
            RoundCharts();
            UpdateCharts(sender, EventArgs.Empty);
            ResourceReader.Initialize();
            ResourceReader.timer.Tick += UpdateCharts;
            BackColor = Theme.Background;
            TransparencyKey = BackColor;
        }

        private void OverlayWindow_EnabledChanged(object sender, EventArgs e)
        {
            ResourceReader.timer.Tick -= UpdateCharts;
        }
        #endregion

        //Methods
        #region Theming
        private void ThemeOverlay()
        {
            CPULabel.ForeColor = Theme.Text;
            MemoryLabel.ForeColor = Theme.Text;
            TempratureLabel.ForeColor = Theme.Text;
            CPUChart.Series[0].Color = Color.FromArgb(50, Theme.DarkAccent);
            CPUChart.Series[0].BorderColor = Theme.Accent;
            MemoryChart.Series[0].Color = Color.FromArgb(50, Theme.DarkAccent);
            MemoryChart.Series[0].BorderColor = Theme.Accent;
            TempratureChart.Series[0].Color = Color.FromArgb(50, Theme.DarkAccent);
            TempratureChart.Series[0].BorderColor = Theme.Accent;
        }
        public void RoundCharts()
        {
            int rounding;
            if (Configuration.OverlayRounded) { rounding = Theme.PanelRounding; }
            else { rounding = 0; }
            RoundedCorners.Round(CPUChart, rounding);
            RoundedCorners.Round(MemoryChart, rounding);
            RoundedCorners.Round(TempratureChart, rounding);
            CPUPanel.rounding = rounding;
            MemPanel.rounding = rounding;
            TempPanel.rounding = rounding;
        }
        #endregion

        #region Updating charts

        private void UpdateCharts(object sender, EventArgs e)
        {
            try
            {
                CPUUsage.Text = ResourceReader.CPU[9] + "%";
                MemoryUsage.Text = ResourceReader.Mem[9] + "/" + Configuration.Totalmemory + "GB";
                TempratureValue.Text = ResourceReader.Temprature[9] + "°";

                ResourceReader.UpdateChart(CPUChart, ResourceReader.CPU);
                ResourceReader.UpdateChart(MemoryChart, ResourceReader.Mem);
                ResourceReader.UpdateChart(TempratureChart, ResourceReader.Temprature);
            }
            catch (Exception ex)
            {
                Program.Log("[Error] Failed to update charts");
                Program.Log("[Exception] " + ex);
            }
        }
        #endregion

        #region Customization
        public void ChartType()
        {
            int val = 41;
            if (Configuration.OverlayMinimal)
            {
                val = 125;
            }
            else
            {
                val = 41;
            }
            CPUPanel.Height = val;
            MemPanel.Height = val;
            TempPanel.Height = val;
            CPUChart.Visible = Configuration.OverlayMinimal;
            MemoryChart.Visible = Configuration.OverlayMinimal;
            TempratureChart.Visible = Configuration.OverlayMinimal;
            CPUPanel.Invalidate();
            MemPanel.Invalidate();
            TempPanel.Invalidate();
            Orientation();
        }

        public void Orientation()
        {
            if (Configuration.OverlayPortrait)
            {
                Size = new Size(CPUPanel.Width + 10, CPUPanel.Height + MemPanel.Height + TempPanel.Height + 20);
            }
            else
            {
                Size = new Size(CPUPanel.Width + MemPanel.Width + TempPanel.Width + 20, CPUPanel.Height + 10);
            }
        }
        #endregion
    }
}
