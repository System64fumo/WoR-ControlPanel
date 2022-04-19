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
        public static bool silent;

        [STAThread]
        static void Main(string[] args)
        {
            foreach (string i in args)
            {
                Console.WriteLine(i);
                if (i.Contains("/s")) silent = true;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WoRCPInstaller window = new WoRCPInstaller();
            Theme.Initialize(window,window.AcrylicPanel);
            Application.Run(window);

        }
    }
}
