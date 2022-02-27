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
            GetGreeting();             //Get current time greeting
            Theme.Initialize(Window);  //Initialize theme
            Application.Run(Window);   //Show the main window
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

        #region Read Config.txt
        public static void ReadConfig()
        {
            if (File.Exists(@"B:\Config.txt")) // Make sure file exists before we try to read it
            {
                string[] lines = File.ReadAllLines(@"B:\Config.txt"); // Read the file line by line
                foreach (string i in lines) // Iterate through each line
                {                  
                    //This is terrible
                    // The following if statements search for config.txt options and delete them

                    if (i.Contains("disable_overscan="))
                    {
                        Configuration.disableoverscan = i.Replace("disable_overscan=", "");
                    }
                    if (i.Contains("hdmi_force_hotplug="))
                    {
                        Configuration.forcehotplug = i.Replace("hdmi_force_hotplug=", "");
                    }
                    if (i.Contains("disable_splash="))
                    {
                        Configuration.disablesplash = i.Replace("disable_splash=", "");
                    }
                    if (i.Contains("arm_freq="))
                    {
                        Configuration.armfreq = i.Replace("arm_freq=", "");
                    }
                    if (i.Contains("gpu_freq="))
                    {
                        Configuration.gpufreq = i.Replace("gpu_freq=", "");
                    }
                    if (i.Contains("gpu_mem="))
                    {
                        Configuration.gpumem = i.Replace("gpu_mem=", "");
                    }
                    if (i.Contains("over_voltage="))
                    {
                        Configuration.overvoltage = i.Replace("over_voltage=", "");
                    }
                    if (i.Contains("force_turbo="))
                    {
                        Configuration.forceturbo = i.Replace("force_turbo=", "");
                    }
                    if (i.Contains("hdmi_cvt="))
                    {
                        string line = i.Replace("hdmi_cvt=", "");
                        Configuration.Video = true;
                        Configuration.width = line.Remove(line.IndexOf(" "));
                        line = line.Replace(Configuration.width + " ", "");
                        Configuration.height = line.Remove(line.IndexOf(" "));
                        line = line.Replace(Configuration.height + " ", "");
                        Configuration.refresh = line;
                    }
                }
            }
            else
            {
                // Do this we can't find the file
                Log("[Error] Unable to find config.txt");
            }
        }
        #endregion

        #region Write Config.txt
        public static void WriteConfig()
        {
            if (File.Exists(@"B:\Config.txt")) // Making sure config.txt exists and boot partition is mounted
            {
                Configuration.config = "";
                foreach (string i in File.ReadAllLines(@"B:\Config.txt")) // Read the file line by line
                {
                    if (
                        // Following if statements make sure that config.txt DOES NOT have the configuration options already set
                        !i.Contains("arm_freq=") &&
                        !i.Contains("gpu_freq=") &&
                        !i.Contains("gpu_mem=") &&
                        !i.Contains("over_voltage=") &&
                        !i.Contains("force_turbo=") &&
                        !i.Contains("hdmi_cvt=") &&
                        !i.Contains("hdmi_group=") &&
                        !i.Contains("hdmi_mode=") &&
                        !i.Contains("disable_overscan=") &&
                        !i.Contains("disable_splash=") &&
                        !i.Contains("hdmi_force_hotplug=")
                        )
                    {
                        Configuration.config += i + Environment.NewLine;
                    }
                }
                try
                {
                    Configuration.config = Configuration.config.Substring(0, Configuration.config.Length - 2);
                }
                catch { }

                // Write the configuration options to the configuration  class
                if (Configuration.disableoverscan != null) { Configuration.config += "disable_overscan=" + Configuration.disableoverscan + "\n"; }
                if (Configuration.disablesplash != null) { Configuration.config += "disable_splash=" + Configuration.disablesplash + "\n"; }
                if (Configuration.armfreq != null) { Configuration.config += "arm_freq=" + Configuration.armfreq + "\n"; }
                if (Configuration.gpufreq != null) { Configuration.config += "gpu_freq=" + Configuration.gpufreq + "\n"; }
                if (Configuration.gpumem != null) { Configuration.config += "gpu_mem=" + Configuration.gpumem + "\n"; }
                if (Configuration.overvoltage != null) { Configuration.config += "over_voltage=" + Configuration.overvoltage + "\n"; }
                if (Configuration.forceturbo != null) { Configuration.config += "force_turbo=" + Configuration.forceturbo + "\n"; ; }
                if (Configuration.forcehotplug != null) { Configuration.config += "hdmi_force_hotplug=" + Configuration.forcehotplug + "\n"; }
                if (Configuration.Video) { Configuration.config += "hdmi_cvt=" + Configuration.width + " " + Configuration.height + " " + Configuration.refresh + "\nhdmi_group=2\nhdmi_mode=87\n"; }

                StreamWriter sw = new StreamWriter(@"B:\Config.txt"); // Call a streamwriter instance on config.txt so we can write our lines
                sw.WriteLine(Configuration.config); // Write lines the lines from our configuration class to config.txt
                sw.Close(); // Close the file for writing and free the memory
            }
            else
            {
                Log("[Error] Unable to write to config.txt");
            }
        }
        #endregion
    }
}
