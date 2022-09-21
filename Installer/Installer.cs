using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer
{
    public partial class WoRCPInstaller : Form
    {
        //TODO: Redo this whole form
        //Everything is currently a place holder

        //Main
        #region Variables
        readonly bool Internet = NetworkInterface.GetIsNetworkAvailable();
        private readonly string Link = "https://github.com/AmirDahan/WoR-ControlPanel/releases/latest/download/WoRCP.zip";
        private readonly string Assemblyver = "https://raw.githubusercontent.com/AmirDahan/WoR-ControlPanel/main/Main/Properties/AssemblyInfo.cs";
        public static string CPUArch = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment", "PROCESSOR_ARCHITECTURE", null);
        private static readonly string Build = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentBuild", null);
        private bool Installed;
        private bool UpdateAvailable;
        private readonly string DownloadPath = Path.GetTempPath() + @"\Download.zip";
        private Font font = new Font("Segoe UI", 32f);
        private SolidBrush DrawBrush;
        string AppName = "WoR ControlPanel";
        string ServerVersion = string.Empty;
        string LocalVersion = string.Empty;
        string Version = string.Empty;
        #endregion

        #region initialization
        public WoRCPInstaller()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
        }

        private async void Installer_Load(object sender, EventArgs e)
        {
            if (Program.silent)
            {
                this.Hide();
                this.ShowInTaskbar = false;
                this.Visible = false;
            }
            //Check if the application is installed
            if (Directory.Exists(PathTextbox.Text))
            {
                Installed = true;
                ChooseDirButton.Enabled = false;
                InstallButton.Color = Color.FromArgb(235, 0, 65);
                InstallButton.ButtonText = "Uninstall";
            }

            DrawBrush = new SolidBrush(WoRCP.UI.Theme.Text);


            //Enable later
            //checkforupdate();
        }
        #endregion

        #region Titlebar

        Point lastPoint;
        private void DragStart(object sender, MouseEventArgs e) { lastPoint = new Point(e.X, e.Y); }
        private void DragMove(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Left) { Left += e.X - lastPoint.X; Top += e.Y - lastPoint.Y; } }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.GetTempPath() + "list.txt"))
                File.Delete(Path.GetTempPath() + "list.txt");
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
            /* Enable later
            if (UpdateAvailable)
            {
                update();
                return;
            }*/
            if (Installed)
                uninstall();
            else
                install();
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

            StringFormat stfm = new StringFormat();
            stfm.Alignment = StringAlignment.Far;
            SizeF AppVersionSize = e.Graphics.MeasureString(ServerVersion, font);
            e.Graphics.DrawString(Version, new Font("Segoe UI Semibold", 9f), DrawBrush, AcrylicPanel.Width / 2 + AppNameSize.Width / 2 - AppVersionSize.Width / 2 + 65, AcrylicPanel.Height / 2 - AppNameSize.Height / 2 + 50,stfm);

            Image newImage = Properties.Resources.Icon;
            RectangleF srcRect = new RectangleF(0, 0, 96, 64);
            GraphicsUnit units = GraphicsUnit.Pixel;

            e.Graphics.DrawImage(newImage, AcrylicPanel.Width / 2 - 75 - AppNameSize.Width / 2, AcrylicPanel.Height / 2 - 28, srcRect, units);
        }
        #endregion


        //TODO: improve install/uninstall process
        //Methods
        #region Install/Uninstall
        private async void install()
        {
            try
            {
                InstallButton.Enabled = false;
                using (HttpClient client = new HttpClient())
                {
                    InstallButton.ButtonText = "Installing";
                    InstallButton.Color = WoRCP.UI.Theme.BrightAccent;
                    ChooseDirButton.Enabled = false;
                    Uri uri = new Uri(Link);
                    if (File.Exists(DownloadPath)) { File.Delete(DownloadPath); }
                    await DownloadFileTaskAsync(client, uri, DownloadPath);
                    ZipFile.ExtractToDirectory(DownloadPath, PathTextbox.Text);
                    File.Delete(DownloadPath);
                    InstallButton.ButtonText = "Uninstall";
                }
                if (CPUArch == "ARM64" && Convert.ToInt32(Build) >= 22504)
                {
                    if (File.Exists(PathTextbox.Text + @"\WoRCP.exe"))
                    {
                        File.Delete(PathTextbox.Text + @"\WoRCP.exe");
                        FileInfo fi = new FileInfo(PathTextbox.Text + @"\WoRCParm64.exe");
                        fi.MoveTo(PathTextbox.Text + @"\WoRCP.exe");
                    }
                }
                else
                {
                    if (File.Exists(PathTextbox.Text + @"\WoRCParm64.exe"))
                    {
                        File.Delete(PathTextbox.Text + @"\WoRCParm64.exe");
                    }
                }
                //Create shortcut
                IShellLink link = (IShellLink)new ShellLink();
                link.SetPath(PathTextbox.Text + @"\WoRCP.exe");
                IPersistFile file = (IPersistFile)link;
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                file.Save(Path.Combine(desktopPath, "WoRCP.lnk"), false);


                InstallButton.Enabled = true;
                InstallButton.Color = Color.FromArgb(235, 0, 65);
                Installed = true;
            }
            catch (Exception ex)
            {
                InstallButton.ButtonText = "Error";
                InstallButton.Enabled = false;
                Installed = false;
                InstallButton.Color = Color.FromArgb(235, 0, 65);
                MessageBox.Show(ex.ToString());
            }
        }
        private async void uninstall()
        {
            InstallButton.Enabled = false;
            Directory.Delete(PathTextbox.Text, true);
            InstallButton.ButtonText = "Install";
            InstallButton.Enabled = true;
            ChooseDirButton.Enabled = true;
            InstallButton.Color = WoRCP.UI.Theme.Accent;
            Installed = false;

            //Remove shortcut
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\WoRCP.lnk";
            if (File.Exists(path)) File.Delete(path);
        }

        #endregion

        //TODO: finish writing
        #region Updates
        private async void checkforupdate()
        {
            if (!Internet) return;
            await Task.Run(() =>
            {
                try //Get app version
                {
                    var versionInfo = FileVersionInfo.GetVersionInfo(PathTextbox.Text + @"\WoRCP.exe");
                    string LocalVersion = versionInfo.FileVersion.Replace(".", "");

                    System.Net.WebClient wc = new System.Net.WebClient();
                    string[] webData = wc.DownloadString(Assemblyver).Split('\n');
                    foreach (string line in webData)
                        if (line.Contains("AssemblyVersion"))
                            ServerVersion = line;

                    ServerVersion = ServerVersion.Split('"')[1].Replace(".", "");

                    UpdateAvailable = Convert.ToInt32(ServerVersion) - 10 > Convert.ToInt32(LocalVersion);

                    Version = "v0." + (Convert.ToInt32(ServerVersion) - 10).ToString().Insert(1,".").Remove(3);
                    UpdateAvailable = true;

                    if (!UpdateAvailable) return;
                    Version = $"Local: v{LocalVersion.ToString().Insert(1, ".").Insert(3, ".").Remove(5)} -> Server: {Version}";
                    InstallButton.ButtonText = "Update";
                    InstallButton.Color = Color.LightSeaGreen;
                    AcrylicPanel.Invalidate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error");
                }
            });
        }
        private async void update()
        {
            Console.WriteLine("Updating...");
            uninstall();
            install();
            checkforupdate();
            Console.WriteLine("Updated.");
        }
        #endregion

        #region Download file
        private async Task DownloadFileTaskAsync(HttpClient client, Uri uri, string FileName)
        {
            using (Stream s = await client.GetStreamAsync(uri))
            {
                using (FileStream fs = new FileStream(FileName, FileMode.CreateNew))
                {
                    await s.CopyToAsync(fs);
                }
            }
        }
        #endregion

        #region Create shortcut
        [ComImport]
        [Guid("00021401-0000-0000-C000-000000000046")]
        internal class ShellLink
        {
        }

        [ComImport]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        [Guid("000214F9-0000-0000-C000-000000000046")]
        internal interface IShellLink
        {
            void GetPath([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszFile, int cchMaxPath, out IntPtr pfd, int fFlags);
            void GetIDList(out IntPtr ppidl);
            void SetIDList(IntPtr pidl);
            void GetDescription([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszName, int cchMaxName);
            void SetDescription([MarshalAs(UnmanagedType.LPWStr)] string pszName);
            void GetWorkingDirectory([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszDir, int cchMaxPath);
            void SetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr)] string pszDir);
            void GetArguments([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszArgs, int cchMaxPath);
            void SetArguments([MarshalAs(UnmanagedType.LPWStr)] string pszArgs);
            void GetHotkey(out short pwHotkey);
            void SetHotkey(short wHotkey);
            void GetShowCmd(out int piShowCmd);
            void SetShowCmd(int iShowCmd);
            void GetIconLocation([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszIconPath, int cchIconPath, out int piIcon);
            void SetIconLocation([MarshalAs(UnmanagedType.LPWStr)] string pszIconPath, int iIcon);
            void SetRelativePath([MarshalAs(UnmanagedType.LPWStr)] string pszPathRel, int dwReserved);
            void Resolve(IntPtr hwnd, int fFlags);
            void SetPath([MarshalAs(UnmanagedType.LPWStr)] string pszFile);
        }
        #endregion
    }
}
