using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        AppUI app = new AppUI();
        private string[] Apps = new string[] { };
        private string ListPath = Path.GetTempPath() + "list.txt";
        #endregion

        #region Loading and Initalization
        public Appstore()
        {
            InitializeComponent();
        }

        private async void Appstore_Load(object sender, EventArgs e)
        {
            //Set the tab's language
            SetLanguage();

            //Check if internet is available
            if (!NetworkInterface.GetIsNetworkAvailable()) return;

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
                    Program.Log($"[Exception] { ex }");
                }
            });
            if (!File.Exists(ListPath)) return;

            //Add apps to the appstore
            string[] lines = File.ReadAllLines(ListPath);
            foreach (string line in lines)
            {
                if (line.Contains("[Name]")) { app.AppName.Text = line.Remove(0, 7); }
                else if (line.Contains("[Category]")) { app.Category.Text = line.Remove(0, 11); }
                else if (line.Contains("[Icon]")) { app.Icon = line.Remove(0, 7); }
                else if (line.Contains("[Size]")) { app.ApplicationSize.Text = line.Remove(0, 7) + "MB"; }
                else if (line.Contains("[Link]")) { app.Link = line.Remove(0, 7); }
                else if (line.Contains("[Exe]")) { app.Executable = line.Remove(0, 6); }
                else if (line.Contains("[Path]")) { app.AppPath = line.Remove(0, 7); AddApp(); }
            }
            Program.Log($"[Info] Apps found: { Apps.Length }");
        }
        #endregion

        #region Language
        private void SetLanguage()
        {
            label1.Text = Language.Strings[32];
            label2.Text = Language.Strings[33];
        }
        #endregion

        //Methods
        #region Add application
        private void AddApp()
        {
            Theme.Set(app);
            Apps = Apps.Concat(new string[] { app.AppName.Text }).ToArray();
            Container.Controls.Add(app);
            Program.Log($"[Info] Added: { app.AppName.Text }  Link: { app.Link } Path: {app.AppPath}");
            app = new AppUI();
        }
        #endregion

        #region Paint
        private void Banner_Paint(object sender, PaintEventArgs e)
        {
            RoundedCorners.Round(Banner, 20);
        }
        #endregion
    }
}
