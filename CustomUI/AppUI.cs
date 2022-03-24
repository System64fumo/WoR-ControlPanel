using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoRCP
{
    partial class AppUI : UserControl
    {
        //Main
        #region Variables
        public string Link = "";
        public string AppPath = "";
        public string Icon = "";
        private bool Installed = false;
        private readonly string DownloadPath = Path.GetTempPath() + @"\Download.zip";
        private readonly WebClient webClient = new WebClient();
        private bool AnimationState = true;
        private Color clr = Theme.BrightAccent;
        private SolidBrush drawBrush = new SolidBrush(Theme.Text);
        #endregion

        #region Loading and Initialization
        public AppUI()
        {
            InitializeComponent();
        }
        private async void AppUI_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {
                    ImagePanel.BackgroundImage = (Bitmap)DownloadImage(Icon);
                    ImagePanel.Invalidate();
                }
                catch (Exception ex)
                {
                    Program.Log("[Warn] Unable to download application background image");
                    Program.Log("[Exception] " + ex);
                }
            });
            if (Directory.Exists(AppPath)) //Check if the application is installed
            {
                Installed = true; InstallButton.Color = Theme.Accent;
                InstallButton.ButtonText = "Uninstall";
            }
        }
        #endregion

        //Events
        #region Setup
        private void AppUI_Paint(object sender, PaintEventArgs e) //Rounds the control
        {
            RoundedCorners.Paint(e, Width, Height, Theme.PanelRounding, Theme.Panel);
        }
        private Image DownloadImage(string fromUrl) //Downloads the app icon
        {
            using (Stream stream = webClient.OpenRead(fromUrl)) { return Image.FromStream(stream); }
        }
        #endregion

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
                    InstallButton.Enabled = false;
                    using (var client = new HttpClient())
                    {
                        InstallButton.ButtonText = "Installing";
                        var uri = new Uri(Link);
                        if (File.Exists(DownloadPath)) { File.Delete(DownloadPath); }
                        await DownloadFileTaskAsync(client, uri, DownloadPath);
                        ZipFile.ExtractToDirectory(DownloadPath, AppPath);
                        File.Delete(DownloadPath);
                        InstallButton.ButtonText = "Uninstall";
                    }
                    InstallButton.Enabled = true;
                    Program.Log("[Info] Succesfully installed " + AppName.Text);
                }
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
                clr = Color.FromArgb(255,Math.Max(0, clr.R - 5), Math.Max(0, clr.G - 5), Math.Max(0, clr.B - 5));
            }
            InstallButton.Color = clr;
        }
        #endregion

        //Methods
        #region Download app
        private async Task DownloadFileTaskAsync(HttpClient client, Uri uri, string FileName)
        {
            Animation.Enabled = true;
            using (var s = await client.GetStreamAsync(uri))
            {
                using (var fs = new FileStream(FileName, FileMode.CreateNew))
                {
                    await s.CopyToAsync(fs);
                }
            }
            Animation.Enabled = false;
        }
        #endregion

        #region Paint events

        private void ImagePanel_Paint(object sender, PaintEventArgs e)
        {
            if (ImagePanel.BackgroundImage == null)
            {
                e.Graphics.DrawString("●", new Font("Segoe UI", 110f), new SolidBrush(Theme.Inactive), -37, -85);
                e.Graphics.DrawString("?", new Font("Segoe UI", 30f), new SolidBrush(Theme.Text), 17, 5);
            }
        }
        #endregion
    }
}
