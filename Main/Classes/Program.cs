/*
                     /$$      /$$           /$$$$$$$         /$$$$$$  /$$$$$$$ 
                    | $$  /$ | $$          | $$__  $$       /$$__  $$| $$__  $$
                    | $$ /$$$| $$  /$$$$$$ | $$  \ $$      | $$  \__/| $$  \ $$
                    | $$/$$ $$ $$ /$$__  $$| $$$$$$$/      | $$      | $$$$$$$/
                    | $$$$_  $$$$| $$  \ $$| $$__  $$      | $$      | $$____/ 
                    | $$$/ \  $$$| $$  | $$| $$  \ $$      | $$    $$| $$      
                    | $$/   \  $$|  $$$$$$/| $$  | $$      |  $$$$$$/| $$      
                    |__/     \__/ \______/ |__/  |__/       \______/ |__/      
*/
using System;
using System.IO;
using System.Windows.Forms;
using WoRCP.UI;

namespace WoRCP
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                //Welcome to WoR CP!
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                MainWindow Window = new MainWindow();
                Theme.Initialize(Window);   //Initialize theme
                Configuration.Initialize(); //Initializes the config
                Language.Initialize();      //Initialize the language
                checkSettings();            //Check the settings file
                Application.Run(Window);    //Show the main window
            }
            catch (Exception ex)
            {
                Log("[Critical Error] " + ex);
            }
            finally
            {
                MessageBox.Show("WoR Control panel has crashed unexpectedly.");
                MessageBox.Show("A log has been created on your desktop" + Environment.NewLine + Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Log.txt" + Environment.NewLine + "If you had any issues with WoRCP or your Pi" + Environment.NewLine + "please send this log to the developer");
                StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Log.txt");
                sw.WriteLine(LogOutput);
                sw.Close();
                // This code always executed even if application crashes.
            }
        }

        //Methods
        #region Logging
        public static string LogOutput;
        public static void Log(string text) { LogOutput += text.Replace("\n", Environment.NewLine) + Environment.NewLine; Console.WriteLine(text); if (text.Contains("[Error]")) { MessageBox.Show(text); } }
        #endregion

        #region Greetings Text
        public static string GetGreeting()
        {
            // Get the time in 24hr format
            int time = Convert.ToInt16(DateTime.Now.ToString("HH"));

            // Check what time of day it is and adjust greeing accordingly
            if (time >= 12) return Language.Strings[14];
            else if (time >= 17) return Language.Strings[15];
            return Language.Strings[13];

        }
        #endregion

        #region Spacing
        public static string Spacing(int amount)
        {
            return "".PadRight(amount, '⠀');
        }
        #endregion

        #region Check settings
        private static void checkSettings()
        {
            if (!File.Exists(Application.StartupPath + @"\Settings.ini")) return; //Check if settings.ini exists

            IniFile MyIni = new IniFile(Application.StartupPath + @"\Settings.ini");
            if (MyIni.KeyExists("StartMinimized", "Options"))
            {
                Configuration.MinimizeToTray = Convert.ToBoolean(MyIni.Read("StartMinimized", "Options"));
                ResourceReader.trayicon.Visible = Convert.ToBoolean(MyIni.Read("StartMinimized", "Options"));
                /*
                Configuration.OverlayEnabled = Convert.ToBoolean(MyIni.Read("Enabled", "Overlay"));
                if (Convert.ToBoolean(MyIni.Read("Enabled", "Overlay")))
                {
                    Configuration.overlay.StartPosition = FormStartPosition.Manual;
                    Configuration.overlay.Location = new System.Drawing.Point(Convert.ToInt32(ConfigUtility.Width) - Configuration.overlay.Width, 0);
                    Configuration.overlay.Show();
                }*/
            }
        }
        #endregion
    }
}
