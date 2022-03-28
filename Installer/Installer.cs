using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer
{
    public partial class WoRCPInstaller : Form
    {
        //TODO Redo this whole form
        //Everything is currently a place holder

        //Main
        #region Variables
        readonly bool Internet = NetworkInterface.GetIsNetworkAvailable();
        private string Link = "https://github.com/AmirDahan/WoR-ControlPanel/releases/latest/download/ARM64.zip";
        private string AppPath = @"C:\Program Files\WoR Control Panel";
        private bool Installed;
        private bool UpdateAvailable = true;
        private readonly string DownloadPath = Path.GetTempPath() + @"\Download.zip";
        private Font font = new Font("Segoe UI", 32f);
        private SolidBrush DrawBrush;
        string AppName = "WoR ControlPanel";
        string ServerVersion = "V0.0.0";
        string LocalVersion = "V0.0.0";
        #endregion

        #region initialization
        public WoRCPInstaller()
        {
            InitializeComponent();
        }

        private async void Installer_Load(object sender, EventArgs e)
        {
            //Check if the application is installed
            if (Directory.Exists(AppPath))
            {
                Installed = true;
                ChooseDirButton.Enabled = false;
                InstallButton.Color = Color.FromArgb(235, 0, 65);
                InstallButton.ButtonText = "Uninstall";
            }

            //Initialization
            DrawBrush = new SolidBrush(WoRCP.UI.Theme.Text);
            WoRCP.UI.Theme.Initialize(this,AcrylicPanel);

            //Check if transperancy is enabled and change the titlebar color
            if (WoRCP.UI.Theme.Transparency)
            {
                WoRCP.UI.WindowUtils.changeTitlebarBackColor(this, WoRCP.UI.Theme.Inactive.R, WoRCP.UI.Theme.Inactive.G, WoRCP.UI.Theme.Inactive.B);
            }
            else
            {
                WoRCP.UI.WindowUtils.changeTitlebarBackColor(this, WoRCP.UI.Theme.Panel.R, WoRCP.UI.Theme.Panel.G, WoRCP.UI.Theme.Panel.B);
            }

            await Task.Run(() =>
            {
                try //Get app version
                {
                    if (Internet)
                    {
                        using (WebClient wc = new WebClient())
                        {
                            wc.DownloadFile(new Uri("https://raw.githubusercontent.com/AmirDahan/WoR-ControlPanel/main/Properties/AssemblyInfo.cs"), Application.StartupPath + @"\Version.txt");
                        }

                        foreach (string line in File.ReadAllLines(Application.StartupPath + @"\Version.txt"))
                        {
                            if (line.Contains("[assembly: AssemblyVersion(") && !line.Contains("//"))
                            {
                                ServerVersion = "V" + line.Remove(0, 28).Remove(5, 5);
                                AcrylicPanel.Invalidate();
                            }
                        }
                    }
                }
                catch
                {

                }
            });

            if (UpdateAvailable)
            {
                BottomLabel.Text = "An update is available! " + LocalVersion + " -> " + ServerVersion;
                InstallButton.ButtonText = "Update";
                PathPanel.Visible = false;
            }
        }
        #endregion

        #region Titlebar

        Point lastPoint;
        private void DragStart(object sender, MouseEventArgs e) { lastPoint = new Point(e.X, e.Y); }
        private void DragMove(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Left) { Left += e.X - lastPoint.X; Top += e.Y - lastPoint.Y; } }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.GetTempPath() + "list.txt")) { File.Delete(Path.GetTempPath() + "list.txt"); }
            Application.Exit();
        }
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        //Controls
        #region Buttons
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
                    ChooseDirButton.Enabled = true;
                    InstallButton.Color = WoRCP.UI.Theme.Accent;
                }
                else //Install app
                {
                    InstallButton.Enabled = false;
                    using (var client = new HttpClient())
                    {
                        InstallButton.ButtonText = "Installing";
                        InstallButton.Color = WoRCP.UI.Theme.BrightAccent;
                        ChooseDirButton.Enabled = false;
                        var uri = new Uri(Link);
                        if (File.Exists(DownloadPath)) { File.Delete(DownloadPath); }
                        await DownloadFileTaskAsync(client, uri, DownloadPath);
                        ZipFile.ExtractToDirectory(DownloadPath, AppPath);
                        File.Delete(DownloadPath);
                        InstallButton.ButtonText = "Uninstall";
                    }
                    InstallButton.Enabled = true;
                    InstallButton.Color = Color.FromArgb(235, 0, 65);
                }
                Installed = !Installed;
            }
            catch (Exception ex)
            {
                InstallButton.ButtonText = "Error";
                InstallButton.Enabled = false;
                InstallButton.Color = Color.FromArgb(235, 0, 65);
            }
        }

        private void ChooseDirButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                PathTextbox.Text = folderBrowserDialog1.SelectedPath + @"\WoR Control Panel";
            }
        }
        #endregion

        //Events
        #region Paint events
        private void AcrylicPanel_Paint(object sender, PaintEventArgs e)
        {
            SizeF AppNameSize = e.Graphics.MeasureString(AppName, font);
            e.Graphics.DrawString(AppName, font, DrawBrush, AcrylicPanel.Width / 2 - AppNameSize.Width / 2 + 26, AcrylicPanel.Height / 2 - AppNameSize.Height / 2);

            SizeF AppVersionSize = e.Graphics.MeasureString(ServerVersion, font);
            e.Graphics.DrawString(ServerVersion, new Font("Segoe UI Semibold", 9f), DrawBrush, AcrylicPanel.Width / 2 + AppNameSize.Width / 2 - AppVersionSize.Width / 2 + 26, AcrylicPanel.Height / 2 - AppNameSize.Height / 2 + 50);

            Image newImage = Properties.Resources.Icon;
            RectangleF srcRect = new RectangleF(0, 0, 96, 64);
            GraphicsUnit units = GraphicsUnit.Pixel;

            e.Graphics.DrawImage(newImage, AcrylicPanel.Width / 2 - 75 - AppNameSize.Width / 2, AcrylicPanel.Height / 2 - 28, srcRect, units);
        }
        #endregion

        #region Download file
        private async Task DownloadFileTaskAsync(HttpClient client, Uri uri, string FileName)
        {
            using (var s = await client.GetStreamAsync(uri))
            {
                using (var fs = new FileStream(FileName, FileMode.CreateNew))
                {
                    await s.CopyToAsync(fs);
                }
            }
        }
        #endregion
    }
}
