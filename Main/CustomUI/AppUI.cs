using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoRCP.UI;

namespace WoRCP
{
    partial class AppUI : UserControl
    {
        //Main
        #region Variables
        public string Link = "";
        public string AppPath = "";
        public string Icon = "";
        private bool Installed;
        private readonly string DownloadPath = Path.GetTempPath() + @"\Download.zip";
        private bool AnimationState = true;
        private Color clr = Theme.BrightAccent;
        #endregion

        #region Loading and Initialization
        public AppUI()
        {
            InitializeComponent();
        }
        private void AppUI_Load(object sender, EventArgs e)
        {
            //Check if the application is installed
            if (Directory.Exists(AppPath))
            {
                Installed = true;
                InstallButton.Color = Theme.Accent;
                InstallButton.ButtonText = "Uninstall";
            }
        }
        #endregion

        //Events
        #region Installation and Uninstallation
        private async void InstallButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Installed) //Uninstall app
                {
                    InstallButton.Enabled = false;
                    Directory.Delete(AppPath, true);
                    InstallButton.ButtonText = "Install";
                    InstallButton.Enabled = true;
                    InstallButton.Color = Theme.Inactive;
                    Program.Log("[Info] Succesfully uninstalled " + AppName.Text);
                }
                else //Install app
                {
                    //Installation process starts
                    InstallButton.Enabled = false;
                    InstallButton.ButtonText = "Installing";
                    Animation.Enabled = true;

                    //Start downloading the file
                    using (var client = new HttpClient())
                    {
                        var uri = new Uri(Link);
                        if (File.Exists(DownloadPath)) { File.Delete(DownloadPath); }
                        await DownloadFileTaskAsync(client, uri, DownloadPath);
                    }

                    //Extract the file to the destination
                    ZipFile.ExtractToDirectory(DownloadPath, AppPath);

                    //Delete the zip
                    File.Delete(DownloadPath);

                    //Finish
                    InstallButton.ButtonText = "Uninstall";
                    Animation.Enabled = false;
                    InstallButton.Color = Theme.Accent;
                    InstallButton.Enabled = true;
                    Program.Log("[Info] Succesfully installed " + AppName.Text);
                }
                //Toggle the application's installed state
                Installed = !Installed;
            }
            catch (Exception ex)
            {
                InstallButton.ButtonText = "Error";
                InstallButton.Enabled = false;
                Animation.Enabled = false;
                InstallButton.Color = Color.FromArgb(235, 0, 65);
                Program.Log("[Error] Unable to install " + AppName.Text);
                Program.Log("[Exception] " + ex);
            }
        }
        #endregion

        #region Download animation
        private void Animation_Tick(object sender, EventArgs e)
        {
            //TODO: replace this with a better system
            if (clr.R >= Theme.BrightAccent.R)
            {
                AnimationState = false;
            }
            if (clr.R <= Theme.DarkAccent.R)
            {
                AnimationState = true;
            }
            if (AnimationState)
            {
                clr = Color.FromArgb(255, Math.Min(255, clr.R + 5), Math.Min(255, clr.G + 5), Math.Min(255, clr.B + 5));
            }
            else
            {
                clr = Color.FromArgb(255, Math.Max(0, clr.R - 5), Math.Max(0, clr.G - 5), Math.Max(0, clr.B - 5));
            }
            InstallButton.Color = clr;
        }
        #endregion

        //Methods
        #region Download app
        private async Task DownloadFileTaskAsync(HttpClient client, Uri uri, string FileName)
        {
            //Get the file stream from the link
            using (var stream = await client.GetStreamAsync(uri))
            {
                //Create a new file from the filestream
                using (var filestream = new FileStream(FileName, FileMode.CreateNew))
                {
                    await stream.CopyToAsync(filestream);
                }
            }
        }
        #endregion

        #region Paint events
        private void AppUI_Paint(object sender, PaintEventArgs e) //Rounds the control
        {
            RoundedCorners.Paint(e, Width, Height, Theme.PanelRounding, Theme.Panel);
        }
        private async void ImagePanel_Paint(object sender, PaintEventArgs e)
        {
            if (ImagePanel.BackgroundImage == null)
            {
                //Attempt to get the background image of the app
                await Task.Run(() =>
                {
                    try
                    {
                        using (WebClient webclient = new WebClient())
                        {
                            using (Stream stream = webclient.OpenRead(Icon))
                            {
                                ImagePanel.BackgroundImage = Image.FromStream(stream);
                                ImagePanel.Invalidate();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        e.Graphics.DrawString("●", new Font("Segoe UI", 110f), new SolidBrush(Theme.Inactive), -37, -85);
                        e.Graphics.DrawString("?", new Font("Segoe UI", 30f), new SolidBrush(Theme.Text), 17, 5);
                        Program.Log("[Warn] Unable to download application background image");
                        Program.Log("[Exception] " + ex);
                    }
                });
            }
        }
        #endregion
    }
}
