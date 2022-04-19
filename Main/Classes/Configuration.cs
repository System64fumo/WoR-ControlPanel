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
            //Set stock clocks according to the Pi Model
            switch (DeviceModel)
            {
                case "Raspberry Pi 4 Model B":
                    ConfigUtility.StockValues = new string[] { "1500", "500", "32", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
                    break;
                case "Raspberry Pi 3 Model B+":
                    ConfigUtility.StockValues = new string[] { "1400", "400", "32", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
                    break;
                case "Raspberry Pi 3 Model B":
                    ConfigUtility.StockValues = new string[] { "1200", "400", "32", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
                    break;
                default: //Unknown Pi
                    ConfigUtility.StockValues = new string[] { "1500", "250", "32", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
                    break;
            }
            ConfigUtility.Values = ConfigUtility.StockValues;
            //Set default screen height and width
            ConfigUtility.Width = Screen.PrimaryScreen.Bounds.Width.ToString();
            ConfigUtility.Height = Screen.PrimaryScreen.Bounds.Height.ToString();
        }
        #endregion

        #region Registry mess
        //User
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
        public static string SerialNo
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
        public static string Version = Application.ProductVersion.Remove(5, 2);
        #endregion

        #region WoR-CP Settings
        public static MainWindow mainwindow;
        public static bool DebuggerOpen;
        public static bool BootMounted = Directory.Exists(@"B:\");
        public static bool AdvancedOC;
        public static bool TrayTempWarning;
        public static bool RGBMode;
        public static string LaunchMode;
        #endregion

        #region Overlay
        public static OverlayWindow overlay = new OverlayWindow();
        public static int OverlayPos = 1;
        public static int OverlayOpacity = 90;
        public static bool OverlayEnabled;
        public static bool OverlayMinimal = true;
        public static bool OverlayAlwaysOnTop = true;
        public static bool OverlayRounded = true;
        public static bool OverlayPortrait = true;
        public static bool MinimizeToTray;
        #endregion
    }
}
