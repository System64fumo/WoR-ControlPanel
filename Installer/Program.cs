using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using WoRCP.UI;

namespace Installer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WoRCPInstaller window = new WoRCPInstaller();
            Theme.Initialize(window,window.AcrylicPanel);
            Application.Run(window);
        }
    }
}
