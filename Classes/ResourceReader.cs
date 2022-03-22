using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WoRCP
{
    class ResourceReader
    {
        //Main
        #region Variables
        public static double[] CPU = new double[10];
        public static double[] Mem = new double[10];
        public static double[] DiskR = new double[10];
        public static double[] DiskW = new double[10];
        public static double[] Temprature = new double[10];
        public static int test = 50;
        private static PerformanceCounter CPUUsage;
        private static PerformanceCounter Memory;
        private static PerformanceCounter DiskRead;
        private static PerformanceCounter DiskWrite;
        private static ManagementObject Temp;
        private static ManagementObjectSearcher searcher;
        public static Timer timer = new Timer();
        public static NotifyIcon trayicon = new NotifyIcon();
        private static bool CountersDefined = false;
        #endregion

        //Methods
        #region Initialization
        public static async void Initialize()
        {
            try
            {
                if (!CountersDefined)
                {
                    Program.Log("[Info] Defining resource counters... (This process might take a while)");
                    await Task.Run(() =>
                    {
                        CPUUsage = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
                        Memory = new PerformanceCounter("Memory", "Available MBytes", true);
                        DiskRead = new PerformanceCounter("LogicalDisk", "Disk Read Bytes/Sec", "_Total", true);
                        DiskWrite = new PerformanceCounter("LogicalDisk", "Disk Write Bytes/Sec", "_Total", true);
                        searcher = new ManagementObjectSearcher(@"root\CIMV2", "SELECT * FROM Win32_PerfFormattedData_Counters_ThermalZoneInformation");
                        Program.Log("[Info] Resource counters defined.");
                        CountersDefined = true;
                    });
                    trayicon.Click += Click;
                    timer.Tick += Tick;
                    timer.Enabled = true;
                    timer.Interval = 1000;
                }
                else
                {
                    Program.Log("[Warn] Resource counters are already defined.");
                }
            }
            catch
            {
                Process.Start("CMD", "/C lodctr /r");
                Program.Log("[Error] Failed to define counters attempting to fix \n Please relaunch the app, If this Error persists try contacting the developer");
            }
        }
        #endregion

        #region Reading
        private static void Tick(object sender, EventArgs e)
        {
            try
            {
                if (CountersDefined && Temprature != null)
                {
                    CPU = CPU.Concat(new[] { Math.Round(CPUUsage.NextValue()) }).ToArray();
                    Mem = Mem.Concat(new[] { Configuration.Totalmemory - Math.Round(Memory.NextValue() / 1024, 1) }).ToArray();
                    DiskR = DiskR.Concat(new[] { Math.Round(DiskRead.NextValue() / 1048576, 1) }).ToArray();
                    DiskW = DiskW.Concat(new[] { Math.Round(DiskWrite.NextValue() / 1048576, 1) }).ToArray();
                    Temp = searcher.Get().OfType<ManagementObject>().First();
                    Temprature = Temprature.Concat(new[] { (Convert.ToDouble(Temp.GetPropertyValue("HighPrecisionTemperature").ToString()) - 2732) / 10 }).ToArray();
                    if (trayicon.Visible) { changeTrayIcon(); }
                    if (CPU.Length > 10) { CPU = CPU.Skip(1).ToArray(); }
                    if (Mem.Length > 10) { Mem = Mem.Skip(1).ToArray(); }
                    if (DiskR.Length > 10) { DiskR = DiskR.Skip(1).ToArray(); }
                    if (DiskW.Length > 10) { DiskW = DiskW.Skip(1).ToArray(); }
                    if (Temprature.Length > 10) { Temprature = Temprature.Skip(1).ToArray(); }
                }
                else
                {
                    Program.Log("[Warn] Resource counters are undefined, Unable to read.");
                }
            }
            catch
            {
                timer.Enabled = false;
                Program.Log("[Error] An unexpected error has occured.");
            }
        }
        #endregion

        #region Charts
        public static void UpdateChart(Chart chart, double[] Value)
        {
            chart.Series[0].Points.Clear();
            foreach (double i in Value)
            {
                chart.Series[0].Points.AddY(i);
            }
        }
        #endregion

        #region Tray icon
        public static void changeTrayIcon()
        {
            var image = new Bitmap(32, 32);
            var graphics = Graphics.FromImage(image);
            SolidBrush forecolor = new SolidBrush(Theme.Text);
            if (Configuration.TrayTempWarning && Temprature[9] > Convert.ToInt32(ConfigUtility.Values[5]))
            {
                forecolor = new SolidBrush(Color.Red);
            }
            Font font = new Font("SegoeUI", 26, FontStyle.Regular, GraphicsUnit.Pixel);
            graphics.DrawString(Temprature[9].ToString(), font, forecolor, new Point(-2, 2));
            trayicon.Icon = ImageManipulation.CreateIcon(image);
        }
        public static void Click(object sender, EventArgs e)
        {
            Configuration.mainwindow.Show();
        }
        #endregion
    }
}
