using Microsoft.Win32;
using System;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace WoRCP
{
    class Configuration
    {
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
        public static bool UpdatesAvailable = false;
        public static bool DebuggerOpen;
        public static bool BootMounted = Directory.Exists(@"B:\");
        public static bool CountersDefined;
        public static bool configfound;
        public static bool AdvancedOC;
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

        #region Config.txt
        public static string config;
        public static bool Video;
        public static string StockClock = "1500"; //For now assume that every pi is a pi 4
        #endregion

        #region Overclock
        public static string armfreq;
        public static string gpufreq;
        public static string gpumem;
        public static string overvoltage;
        public static string forceturbo;
        public static string templimit;
        #endregion

        #region Video
        public static string disableoverscan;
        public static string disablesplash;
        public static string forcehotplug;
        public static string width = Screen.PrimaryScreen.Bounds.Width.ToString();
        public static string height = Screen.PrimaryScreen.Bounds.Height.ToString();
        public static string refresh = "60";
        #endregion

        #region UpdateStockClock
        public static void UpdateStockClock()
        {
            if (CPUName == "BCM2711 (ARM Cortex-A72)")
            {
                StockClock = "1500";
            }

            else
            {
                StockClock = "1200";
            }
        }
        #endregion
    }
}
