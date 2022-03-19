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
namespace WoRCP
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //Welcome to WoR CP!
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindow Window = new MainWindow();
            GetGreeting();              //Get current time greeting
            Theme.Initialize(Window);   //Initialize theme
            Configuration.Initialize(); //Initializes the config
            Application.Run(Window);    //Show the main window
        }

        //Methods
        #region Logging
        public static string LogOutput;
        public static void Log(string text) { LogOutput += text.Replace("\n",Environment.NewLine) + Environment.NewLine; Console.WriteLine(text); if (text.Contains("[Error]")) { MessageBox.Show(text); } }
        #endregion

        #region Greetings Text
        public static void GetGreeting()
        {
            int time = Convert.ToInt16(DateTime.Now.ToString("HH")); // Get the time in 24hr format
            
            // Check what time of day it is and adjust greeing accordingly
            if (time <= 12) { Configuration.Greeting = "Good Morning"; }
            else if (time >= 12) { Configuration.Greeting = "Good Afternoon"; }
            else if (time >= 17) { Configuration.Greeting = "Good Evening"; }
        }
        #endregion
    }
}
