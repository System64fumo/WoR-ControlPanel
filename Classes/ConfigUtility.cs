using System;
using System.IO;
using WoRCP;

class ConfigUtility //This class contains everything that's related to config.txt
{
    #region Variables
    public static string path = @"B:\Config.txt";
    public static string[] checks = { "arm_freq=", "gpu_freq=", "gpu_mem=", "over_voltage=", "force_turbo=", "temp_limit=", "disable_overscan=", "disable_splash=", "hdmi_force_hotplug=", "hdmi_cvt=", "hdmi_group=", "hdmi_mode=" };
    public static string[] Values = new string[checks.Length];
    public static string[] StockValues = new string[checks.Length];
    public static string Width, Height, Refresh;
    #endregion

    #region Read Config.txt
    public static void Read()
    {
        if (File.Exists(path)) //Check if Config.txt exists
        {
            Values = new string[checks.Length]; //Reset all values to null
            foreach (string line in File.ReadAllLines(path)) //For every line in Config.txt
            {
                foreach (string check in checks)
                {
                    if (line.Contains(check)) //Check if the line contains a check (Example: Arm_freq=Value)
                    {
                        Values[Array.IndexOf(checks, check)] = line.Replace(check, ""); //Replace the check with null leaving you with the check's value (Before: Arm_freq=Value, After: Value)
                    }
                }
                if (line.Contains("hdmi_cvt=")) //TODO move make this better if possible and by that i mean handle it in the loop above
                {
                    Width = Values[9].Substring(0, Values[9].IndexOf(" ")).Replace(" ", "");
                    Height = Values[9].Remove(0, Width.Length + 1).Substring(0, Values[9].IndexOf(" ")).Replace(" ", "");
                    Refresh = Values[9].Remove(0, Width.Length + Height.Length + 2);
                }
            }
        }
        else
        {
            Console.WriteLine("[Error] Failed to read: " + path);
        }
    }
    #endregion

    #region Write Config.txt
    public static void Write()
    {
        if (File.Exists(path)) //Check if config.txt exists
        {
            string config = ""; //New config.txt
            int checkcount = 0;
            foreach (string line in File.ReadAllLines(path)) //For every line in config.txt
            {
                foreach (string check in checks) //Add other unknown lines (Lines that don't have a check in ConfigUtility)
                {
                    if (!line.Contains(check)) checkcount++;
                }
                if (checkcount == checks.Length) config += line + Environment.NewLine;
            }

            foreach (string check in checks)
            {
                //Check if the value is not null nor the stock value then write it tp Config.txt
                if (Values[Array.IndexOf(checks, check)] != null && Values[Array.IndexOf(checks, check)] != StockValues[Array.IndexOf(checks, check)])
                {
                    config += check + Values[Array.IndexOf(checks, check)] + "\n";
                }
            }

            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(config); //Save the new config.txt
            sw.Close();
        }
        else
        {
            Program.Log("[Error] Unable to write to config.txt");
        }
    }
    #endregion
}
