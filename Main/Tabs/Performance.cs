using System;
using System.Drawing;
using System.Windows.Forms;
using WoRCP.UI;

namespace WoRCP.Tabs
{
    public partial class Performance : UserControl
    {
        //Main
        #region Loading and Initialization
        public Performance() { InitializeComponent(); }
        private void Performance_Load(object sender, EventArgs e)
        {
            //Set the tab's language
            SetLanguage();

            //Theming
            ThemeCharts();
            RoundCharts();

            //Initialize and start the resource reader's timer
            ResourceReader.Initialize();
            ResourceReader.timer.Enabled = true;

            //Setup
            UpdateCharts(sender, EventArgs.Empty);
            ResourceReader.timer.Tick += UpdateCharts;
            Program.Log("[Info] Charts Initialized succesfully");
        }
        #endregion

        #region Unloading
        //Get rid of the tick event when unloading the tab
        private void Performance_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible) return;
            ResourceReader.timer.Tick -= UpdateCharts;
        }
        #endregion

        #region Language
        private void SetLanguage()
        {
            CPULabel.Text = Language.Strings[22];
            MemoryLabel.Text = Language.Strings[23];
            TempratureLabel.Text = Language.Strings[24];
            ReadLabel.Text = Language.Strings[25];
            WriteLabel.Text = Language.Strings[26];
        }
        #endregion

        //Methods
        #region Updating the charts
        private void UpdateCharts(object sender, EventArgs e)
        {
            try
            {
                //Display system resource usage on the labels
                CPUUsage.Text = ResourceReader.CPU[9] + "%";
                MemoryUsage.Text = ResourceReader.Mem[9] + "/" + Configuration.Totalmemory + " GB";
                TempratureValue.Text = ResourceReader.Temprature[9] + "°";
                ReadUsage.Text = ResourceReader.DiskR[9] + " MBs";
                WriteUsage.Text = ResourceReader.DiskW[9] + " MBs";

                //Update the charts with the system resource usage
                ResourceReader.UpdateChart(CPUChart, ResourceReader.CPU);
                ResourceReader.UpdateChart(MemoryChart, ResourceReader.Mem);
                ResourceReader.UpdateChart(TempratureChart, ResourceReader.Temprature);
                ResourceReader.UpdateChart(ReadChart, ResourceReader.DiskR);
                ResourceReader.UpdateChart(WriteChart, ResourceReader.DiskW);

            }
            catch (Exception ex)
            {
                Program.Log("[Error] Failed to update charts");
                Program.Log("[Exception] " + ex);
            }
        }
        #endregion

        #region Theming
        private void RoundCharts()
        {
            RoundedCorners.Round(CPUChart, Theme.PanelRounding);
            RoundedCorners.Round(MemoryChart, Theme.PanelRounding);
            RoundedCorners.Round(TempratureChart, Theme.PanelRounding);
            RoundedCorners.Round(ReadChart, Theme.PanelRounding);
            RoundedCorners.Round(WriteChart, Theme.PanelRounding);
        }
        private void ThemeCharts()
        {
            CPUChart.Series[0].Color = Color.FromArgb(50, Theme.DarkAccent);
            CPUChart.Series[0].BorderColor = Theme.Accent;
            MemoryChart.Series[0].Color = Color.FromArgb(50, Theme.DarkAccent);
            MemoryChart.Series[0].BorderColor = Theme.Accent;
            TempratureChart.Series[0].Color = Color.FromArgb(50, Theme.DarkAccent);
            TempratureChart.Series[0].BorderColor = Theme.Accent;
            ReadChart.Series[0].Color = Color.FromArgb(50, Theme.DarkAccent);
            ReadChart.Series[0].BorderColor = Theme.Accent;
            WriteChart.Series[0].Color = Color.FromArgb(50, Theme.DarkAccent);
            WriteChart.Series[0].BorderColor = Theme.Accent;
        }
        #endregion
    }
}
