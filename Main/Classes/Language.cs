using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoRCP
{
    internal class Language
    {
        public static string[] Strings = {
            "Enabled",
            "Disabled",
            "High",
            "Low",
            "Install",
            "Uninstall",
            "Save",
            "Refresh",
            "Defaults",
            "Mount",
            "Unmount",
            "Edit",
            "View",
            "Good Morning",
            "Good Afternoon",
            "Good Evening",
            "Performance",
            "Peripherals",
            "Applications",
            "About",
            "Overlay",
            "Settings",
            "Processor",
            "Memory",
            "Temperature",
            "Read",
            "Write",
            "This tab has been disabled.\nGPIO Functionality is only available on Raspberry Pi",
            "GPIO Pins",
            "No pin selected",
            "GPIO Controls",
            "Pin State",
            "Compatible with your device!",
            "Easily install Arm applications from WoR-CP with one click!",
            "Processor",
            "Memory",
            "Firmware",
            "Revision",
            "Serial No",
            "About",
            "Version",
            "Discord",
            "Credits",
            "Overlay",
            "Main overlay",
            "Always on top",
            "Appearance",
            "Opacity",
            "Rounded corners",
            "Charts",
            "Vertical",
            "Tray icon",
            "Show tray icon",
            "Minimize to tray",
            "Temperature warning",
            "Unable to read config.txt",
            "Your Pi is running at stock speeds",
            "Your Pi is overclocked",
            "Your Pi is underclocked",
            "Warning! Your overclock is too high, Your Raspberry Pi might not boot",
            "No issues found",
            "Issues found",
            "Boot partition is not mounted",
            "Please mount your boot partition\nto be able to overclock",
            "Your boot partition is mounted and can be accessed from \n Drive",
            "Your config.txt will be shown here once you mount your boot partition\n",
            "Overclocking",
            "CPU Frequency",
            "GPU Frequency",
            "GPU Memory",
            "Over Voltage",
            "Force Turbo",
            "Display",
            "Overscan",
            "Hotplug",
            "Splash",
            "Other",
            "Config.txt",
            "Documentation",
            "Theme",
            "Light mode",
            "Transparency",
            "Bright Accent",
            "Accent",
            "Dark Accent",
            "Bright Panel",
            "Inactive",
            "Panel",
            "Background",
            "Logs",
            "Save log to desktop",
            "Experimental",
            "Advanced overclocking",
            "By enabling this setting you agree that you are putting your Raspberry Pi at risk.\nProceed at your own risk",
            "Warning",

        };
        public static string State(bool state)
        {
            if (state) return Strings[0];
            return Strings[1];
        }
        public static void Initialize()
        {
            CultureInfo ci = CultureInfo.InstalledUICulture;
            string langfile = ci.Name.ToUpper() + ".txt";
            if (!File.Exists(Application.StartupPath + @"\Lang\" + langfile)) return;
            string[] lines = File.ReadAllLines(Application.StartupPath + @"\Lang\" + langfile);
            Strings = new string[0];
            foreach (string line in lines)
            {
                string newline = line;
                if (newline == string.Empty || newline == "\n" || newline == null || newline.Contains("//")) continue;
                if (newline.Contains(@"\n")) newline = newline.Replace(@"\n",Environment.NewLine);
                Strings = Strings.Append(newline).ToArray();
            }
        }
    }
}
