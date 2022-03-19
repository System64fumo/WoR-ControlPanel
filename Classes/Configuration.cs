using Microsoft.Win32;
using System;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace WoRCP
{
    class Configuration
    {
        #region Initialization
        public static void Initialize()
        {
            //TODO Update this
            //Set stock clocks according to the Pi Model
            switch (DeviceModel)
            {
                case "Raspberry Pi 4 Model B":
                    StockClocks = new int[] { 1500, 500 };
                    break;
                case "Raspberry Pi 3 Model B+":
                    StockClocks = new int[] { 1400, 400 };
                    break;
                case "Raspberry Pi 3 Model B":
                    StockClocks = new int[] { 1200, 400 };
                    break;
                default: //Unknown Pi
                    StockClocks = new int[] { 600, 250 };
                    break;
            }
        }
        #endregion

        #region Registry mess
        //User
        public static string Greeting;
        public static string User = Environment.UserName;
        public static string Wallpaper = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Control Panel\Desktop", "WallPaper", null);

        //Hardware
        public static string CPUName = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0", "ProcessorNameString", null);
        public static string CoreCount = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment", "NUMBER_OF_PROCESSORS", null);
        public static string CPUArch = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment", "PROCESSOR_ARCHITECTURE", null);
        public static int Totalmemory = Convert.ToInt32(new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / 1024 / 1024 / 1024 + 1);

        //Device
        public static string DeviceName = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\ComputerName\ActiveComputerName", "ComputerName", null);
        public static string DeviceModel = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BaseBoardProduct", null);
        public static string Revision = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BaseBoardVersion", null);
        public static string FirmwareVer = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BIOSVersion", null);
        public static string FirmwareDate = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BIOSReleaseDate", null);
        private static readonly ManagementObjectSearcher baseboardSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
        static public string SerialNo
        {
            get
            {
                try
                {
                    foreach (ManagementObject queryObj in baseboardSearcher.Get())
                    {
                        return queryObj["SerialNumber"].ToString();
                    }
                    return "";
                }
                catch { return "Error"; }
            }
        }
        //Windows
        public static string Edition = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", null);
        public static string Update = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "DisplayVersion", null);
        public static string Build = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentBuild", null);
        public static string Version = Application.ProductVersion.Remove(0, 2);
        #endregion

        #region WoR-CP Settings
        public static MainWindow mainwindow;
        public static bool UpdatesAvailable;
        public static bool DebuggerOpen;
        public static bool BootMounted = Directory.Exists(@"B:\");
        public static bool CountersDefined;
        public static bool Configfound = File.Exists(@"B:\Config.txt");
        public static bool AdvancedOC;
        public static bool TrayTempWarning;
        #endregion

        #region Appstore
        public static int ApplicationsFound = 0;
        #endregion

        #region Overlay
        public static OverlayWindow overlay = new OverlayWindow();
        public static int OverlayPos = 1;
        public static int OverlayOpacity = 90;
        public static bool OverlayEnabled;
        public static bool OverlayMinimal;
        public static bool OverlayAlwaysOnTop = true;
        public static bool OverlayRounded = true;
        public static bool OverlayPortrait = true;
        public static bool MinimizeToTray = false;
        #endregion

        //TODO Move all of this to ConfigUtility
        #region Config.txt
        public static int[] StockClocks = new int[2];
        #endregion

        #region Video
        public static string width = Screen.PrimaryScreen.Bounds.Width.ToString();
        public static string height = Screen.PrimaryScreen.Bounds.Height.ToString();
        public static string refresh = "60";
        #endregion
    }
}
