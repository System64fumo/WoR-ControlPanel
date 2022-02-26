using System;
using System.Drawing;
using System.Windows.Forms;

namespace WoRCP.Tabs
{
    public partial class Performance : UserControl
    {
        //Main
        #region Loading and Initialization
        public Performance() { InitializeComponent(); }
        private void Performance_Load(object sender, EventArgs e)
        {
            ResourceReader.timer.Enabled = true;
            ThemeCharts();
            RoundCharts();
            UpdateCharts(sender, EventArgs.Empty);
            ResourceReader.timer.Tick += UpdateCharts;
            ResourceReader.Initialize();
            Program.Log("[Info] Charts Initialized succesfully");
        }
        private void InitializeCharts()
        {
            if (Configuration.Totalmemory != 0) { MemoryChart.ChartAreas[0].AxisY.Maximum = Configuration.Totalmemory; }
            for (int i = 0; i < CPUChart.ChartAreas[0].AxisX.Maximum; i++) CPUChart.Series[0].Points.AddY(0);
            for (int i = 0; i < MemoryChart.ChartAreas[0].AxisX.Maximum; i++) MemoryChart.Series[0].Points.AddY(0);
            for (int i = 0; i < TempratureChart.ChartAreas[0].AxisX.Maximum; i++) TempratureChart.Series[0].Points.AddY(0);
            for (int i = 0; i < ReadChart.ChartAreas[0].AxisX.Maximum; i++) ReadChart.Series[0].Points.AddY(0);
            for (int i = 0; i < WriteChart.ChartAreas[0].AxisX.Maximum; i++) WriteChart.Series[0].Points.AddY(0);
        }
        private void Performance_EnabledChanged(object sender, EventArgs e)
        {
            ResourceReader.timer.Tick -= UpdateCharts;
        }
        #endregion

        //Methods
        #region Updating the charts
        private void UpdateCharts(object sender, EventArgs e)
        {
            try
            {
                CPUUsage.Text = ResourceReader.CPU[9] + "%";
                MemoryUsage.Text = ResourceReader.Mem[9] + "/" + Configuration.Totalmemory + " GB";
                TempratureValue.Text = ResourceReader.Temprature[9] + "°";
                ReadUsage.Text = ResourceReader.DiskR[9] + " MBs";
                WriteUsage.Text = ResourceReader.DiskW[9] + " MBs";

                ResourceReader.UpdateChart(CPUChart, ResourceReader.CPU);
                ResourceReader.UpdateChart(MemoryChart, ResourceReader.Mem);
                ResourceReader.UpdateChart(TempratureChart, ResourceReader.Temprature);
                ResourceReader.UpdateChart(ReadChart, ResourceReader.DiskR);
                ResourceReader.UpdateChart(WriteChart, ResourceReader.DiskW);

            }
            catch
            {
                Program.Log("[Error] Failed to update charts");
            }
        }
        #endregion

        #region Theming
        private void RoundCharts()
        {
            RoundedCorners.Round(CPUChart, 5);
            RoundedCorners.Round(MemoryChart, 5);
            RoundedCorners.Round(TempratureChart, 5);
            RoundedCorners.Round(ReadChart, 5);
            RoundedCorners.Round(WriteChart, 5);
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
