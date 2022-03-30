using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoRCP.UI;

namespace WoRCP.Tabs
{
    public partial class Appstore : UserControl
    {
        //Main
        #region Variables
        private string ExtractLocation;
        private string Name;
        private string Background;
        private string Url;
        private string Executable;
        private string Category;
        private string AppSize;
        private string[] Items = new string[] { };
        private string ListPath = Path.GetTempPath() + "list.txt";
        #endregion

        #region Loading and Initalization
        public Appstore()
        {
            InitializeComponent();
        }

        private async void Appstore_Load(object sender, EventArgs e)
        {
            //Check if internet is available
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                Container.Visible = true;

                //Start downloading the list in the background
                await Task.Run(() =>
                {
                    try
                    {
                        using (WebClient wc = new WebClient())
                        {
                            wc.DownloadFile(new Uri("https://raw.githubusercontent.com/AmirDahan/WoR-CP-Apps/main/List.txt"), ListPath);
                        }
                    }
                    catch (Exception ex)
                    {
                        Container.Visible = false;
                        Program.Log("[Error] Unable to download the appstore list file.\n Please open the debugger and send the log to the developer.");
                        Program.Log("[Exception] " + ex);
                    }
                });

                //Add apps to the appstore
                if (File.Exists(ListPath))
                {
                    string[] lines = File.ReadAllLines(ListPath);
                    Configuration.ApplicationsFound = 0;
                    foreach (string line in lines)
                    {
                        if (line.Contains("[Name]")) { Name = line.Remove(0, 7); Configuration.ApplicationsFound += 1; }
                        if (line.Contains("[Category]")) { Category = line.Remove(0, 11); }
                        if (line.Contains("[Icon]")) { Background = line.Remove(0, 7); }
                        if (line.Contains("[Size]")) { AppSize = line.Remove(0, 7); }
                        if (line.Contains("[Link]")) { Url = line.Remove(0, 7); }
                        if (line.Contains("[Exe]")) { Executable = line.Remove(0, 6); }
                        if (line.Contains("[Path]")) { ExtractLocation = line.Remove(0, 7); AddApp(Name, Category, Background, Url,Executable, ExtractLocation, AppSize); }
                    }
                    Program.Log("[Info] Apps found: " + Configuration.ApplicationsFound);
                }
            }
        }
        #endregion

        //Methods
        #region Add application
        private void AddApp(string Name, string Category, string Icon, string Url,string exe, string Path, string Applicationsize)
        {
            AppUI app = new AppUI();
            Theme.Set(app);
            app.AppName.Text = Name;
            app.Category.Text = Category;
            app.Link = Url;
            app.Executable = exe;
            app.AppPath = Path;
            app.Icon = Icon;
            app.ApplicationSize.Text = Applicationsize + "MB";
            Items = new List<string>(Items) { Name }.ToArray();
            Container.Controls.Add(app);
            Program.Log("[Info] Added: " + Name + " Link: " + Url + " Path: " + Path);
        }
        #endregion
    }
}
