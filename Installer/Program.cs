using System;
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
                if (i.Contains("--silent")) silent = true;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WoRCPInstaller window = new WoRCPInstaller();
            if (silent)
            {
                window.Hide();
                window.Visible = false;
                window.ShowInTaskbar = false;
            }
            else
            {
                Theme.Initialize(window, window.AcrylicPanel, 2);
            }

            Application.Run(window);

        }
    }
}
