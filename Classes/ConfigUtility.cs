using System;
using System.IO;
using System.Linq;
using WoRCP;

class ConfigUtility
{
    #region Variables
    public static string path = @"C:\Config.txt";
    public static string[] Config;
    public static string[] checks = { "arm_freq=", "gpu_freq=", "gpu_mem=", "over_voltage=", "force_turbo=", "temp_limit=", "disable_overscan=", "disable_splash=", "hdmi_force_hotplug=", "hdmi_cvt=", "hdmi_group=", "hdmi_mode=" };
    public static string[] Values = new string[checks.Length];
    #endregion

    #region Read Config.txt
    public static void Read()
    {
        if (File.Exists(path))
        {
            Config = new string[0];
            string[] lines = File.ReadAllLines(path);
            Values = new string[checks.Length];
            foreach (string i in lines)
            {
                string line = i;
                foreach (string check in checks)
                {
                    if (line.Contains(check))
                    {
                        Values[Array.IndexOf(checks, check)] = line.Replace(check, "");
                        line = line.Replace(Values[Array.IndexOf(checks, check)].ToString(), "");
                    }
                }
                Config = Config.Append(line).ToArray();
                if (i.Contains("hdmi_cvt=")) //TODO move make this better if possible and by that i mean handle it in the loop above
                {
                    Configuration.width = Values[9].Substring(0, Values[9].IndexOf(" ")).Replace(" ", "");
                    Configuration.height = Values[9].Remove(0, Configuration.width.Length + 1).Substring(0, Values[9].IndexOf(" ")).Replace(" ", "");
                    Configuration.refresh = Values[9].Remove(0, Configuration.width.Length + Configuration.height.Length + 2);
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
        if (File.Exists(path))
        {
            string config = "";
            int checkcount = 0;
            foreach (string i in File.ReadAllLines(path))
            {
                foreach (string check in checks)
                {
                    if (!i.Contains(check)) checkcount++;
                }
                if (checkcount == checks.Length) config += i + Environment.NewLine;
            }

            foreach (string check in checks)
            {
                if (Values[Array.IndexOf(checks,check)] != null) config += check + Values[Array.IndexOf(checks, check)] + "\n";
            }

            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(config);
            sw.Close();
        }
        else
        {
            Program.Log("[Error] Unable to write to config.txt");
        }
    }
    #endregion
}
