using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoRCP.UI;

namespace WoRCP
{
    partial class AppUI : UserControl
    {
        //Main
        #region Properties
        public string Link { get; set; }
        public string AppPath { get; set; }
        public string Executable { get; set; }
        public string Icon { get; set; }
        #endregion

        #region Variables
        private bool Installed;
        private readonly string DownloadPath = Path.GetTempPath() + "Download.zip";
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
                InstallButton.ButtonText = Language.Strings[5];
            }
            else
            {
                InstallButton.ButtonText = Language.Strings[4];
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
                    //Remove shortcut
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\" + Executable + ".lnk";
                    if (Executable.Contains(@"\"))
                    {
                        path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\" + Executable.Substring(Executable.LastIndexOf(@"\") + 1) + ".lnk";
                    }

                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }

                    InstallButton.Enabled = false;
                    Directory.Delete(AppPath, true);
                    InstallButton.ButtonText = Language.Strings[4];
                    InstallButton.Enabled = true;
                    InstallButton.Color = Theme.Inactive;
                    Program.Log("[Info] Succesfully uninstalled " + AppName.Text);
                }
                else //Install app
                {
                    //Installation process starts
                    InstallButton.Enabled = false;
                    Animation.Enabled = true;

                    //Start downloading the file
                    using (HttpClient client = new HttpClient())
                    {
                        Uri uri = new Uri(Link);
                        if (File.Exists(DownloadPath)) { File.Delete(DownloadPath); }
                        await DownloadFileTaskAsync(client, uri, DownloadPath);
                    }

                    //Extract the file to the destination
                    ZipFile.ExtractToDirectory(DownloadPath, AppPath);

                    //Delete the zip
                    File.Delete(DownloadPath);

                    //Create shortcut
                    IShellLink link = (IShellLink)new ShellLink();
                    link.SetPath(AppPath + @"\" + Executable + ".exe");
                    IPersistFile file = (IPersistFile)link;
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                    if (Executable.Contains(@"\"))
                    {
                        file.Save(Path.Combine(desktopPath, Executable.Substring(Executable.LastIndexOf(@"\") + 1) + ".lnk"), false);
                    }
                    else
                    {
                        file.Save(Path.Combine(desktopPath, Executable + ".lnk"), false);
                    }

                    //Finish
                    InstallButton.ButtonText = Language.Strings[5];
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
            using (Stream stream = await client.GetStreamAsync(uri))
            {
                //Create a new file from the filestream
                using (FileStream filestream = new FileStream(FileName, FileMode.CreateNew))
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
