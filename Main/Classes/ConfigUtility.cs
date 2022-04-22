using System;
using System.IO;
using System.Linq;
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
        if (!File.Exists(path)) //Check if config.txt exists, else return an error
        {
            Program.Log("[Error] Failed to read: " + path);
            return;
        }

        Values = new string[checks.Length]; //Reset all values to null
        foreach (string line in File.ReadAllLines(path)) //For every line in Config.txt
        {
            foreach (string check in checks)
            {
                //Check if the line contains a check (Example: Arm_freq=Value)
                if (!line.Contains(check)) continue;

                //Replace the check with null leaving you with the check's value (Before: Arm_freq=Value, After: Value)
                Values[Array.IndexOf(checks, check)] = line.Replace(check, ""); 
            }

            //TODO: make this better if possible and by that i mean handle it in the loop above
            if (!line.Contains("hdmi_cvt=")) continue;
            Width = Values[9].Substring(0, Values[9].IndexOf(" ")).Replace(" ", "");
            Height = Values[9].Remove(0, Width.Length + 1).Substring(0, Values[9].IndexOf(" ")).Replace(" ", "");
            Refresh = Values[9].Remove(0, Width.Length + Height.Length + 2);
            Values[9] = null;
        }
        for (int i = 0; i < Values.Length; i++)
        {
            if (Values[i] == null) Values[i] = StockValues[i];
        }
    }
    #endregion

    #region Write Config.txt
    public static void Write()
    {
        if (!File.Exists(path)) //Check if config.txt exists, else return an error
        {
            Program.Log("[Error] Unable to write to config.txt");
            return;
        }

        string[] config = new string[0]; //New config.txt
        foreach (string i in File.ReadAllLines(path)) //For every line in config.txt
        {
            //TODO: Fix this mess
            //It was reverted because the new system didn't work as intended and kept on
            //deleting everything that worcp did not check for leaving you with a broken config
            if (
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
                config = config.Concat(new string[] { i }).ToArray();
            }
        }

        foreach (string check in checks)
        {
            //Check if the value is not null nor the stock value then write it tp Config.txt
            if (Values[Array.IndexOf(checks, check)] != null && Values[Array.IndexOf(checks, check)] != StockValues[Array.IndexOf(checks, check)].ToString())
            {
                config = config.Concat(new string[] { check + Values[Array.IndexOf(checks, check)] }).ToArray();
            }
        }
        StreamWriter sw = new StreamWriter(path);
        foreach (string i in config)
        {
            sw.WriteLine(i); //Save the new config.txt
        }
        sw.Close();
    }
    #endregion
}
