using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WoRCP.Tabs;
using WoRCP.UI;

namespace WoRCP
{
    public partial class MainWindow : Form
    {
        //Main
        #region Variables
        private SolidBrush drawBrush;
        private bool PreviousThemeMode;
        #endregion

        #region Loading and Initialization
        public MainWindow()
        {
            InitializeComponent();
            Configuration.mainwindow = this;
            RGBStrip.SizeMode = PictureBoxSizeMode.StretchImage;
            if (AppDomain.CurrentDomain.FriendlyName == "RGBWoRCP.exe") Configuration.RGBMode = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //Set the Form's language
            SetLanguage();

            //Check if the app should be minimized on startup
            if (Configuration.MinimizeToTray)
            {
                ShowInTaskbar = false;
                Hide();
            }

            //Initial Logging
            Program.Log("[Info] Welcome to WoR Control Panel");
            Program.Log("[Info] Version: " + Configuration.Version);
            Program.Log("[Info] Windows: " + Configuration.Build);
            Program.Log("[Info] Running on: " + Configuration.DeviceName + " / " + Configuration.CPUArch);
            Program.Log("[Info] Custom theme: " + Theme.CustomTheme.ToString());
            Greeting.Text = Program.GetGreeting() + "\n" + Configuration.User + "!";

            //Easteregg
            RGBStrip.Visible = Configuration.RGBMode;

            //Theming
            drawBrush = new SolidBrush(Theme.Text);
            CloseButton.Font = new Font(Theme.glyphs.Name, 9.75f);
            MinimizeButton.Font = new Font(Theme.glyphs.Name, 9.75f);
            ResourceReader.changeTrayIcon();
            ChangeIcon();

            //Load the default tab
            LoadTab(new Performance(), 210);
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
            if (Configuration.MinimizeToTray)
            {
                this.Hide();
            }
            else
            {
                WindowState = FormWindowState.Minimized;
            }
        }
        #endregion

        #region Language
        private void SetLanguage()
        {
            PerformanceButton.Text = Program.Spacing(4) + Language.Strings[16];
            PeripheralsButton.Text = Program.Spacing(4) + Language.Strings[17];
            AppstoreButton.Text = Program.Spacing(4) + Language.Strings[18];
            AboutButton.Text = Program.Spacing(4) + Language.Strings[19];
            OverlayButton.Text = Program.Spacing(4) + Language.Strings[20];
            SettingsButton.Text = Program.Spacing(4) + Language.Strings[21];
        }
        #endregion

        //Methods
        #region Icon

        private void ChangeIcon()
        {
            Image Background;
            Image Waves = ImageManipulation.ToColorTone(Properties.Resources.Graph, Theme.Accent);
            if (Theme.ThemeMode)
            {
                Background = ImageManipulation.InvertColor(Properties.Resources.BackgroundDark);
            }
            else
            {
                Background = Properties.Resources.BackgroundDark;
            }
            Image img = ImageManipulation.OverlayImage(Background, Waves);
            Icon = ImageManipulation.CreateIcon((Bitmap)img);
            Background.Dispose();
            Waves.Dispose();
        }

        #endregion

        #region Tab switcher
        private void LoadTab(UserControl userctrl, int c)
        {
            try //Try to load the tabs
            {
                Program.Log("[Info] Loading" + userctrl.Name + " tab");
                if (Configuration.OverlayEnabled || ResourceReader.trayicon.Visible) ResourceReader.timer.Enabled = true;
                else ResourceReader.timer.Enabled = false;
                Theme.Set(userctrl);
                if (Tabcontainer.Controls.Count > 0)
                {
                    foreach (UserControl uc in Tabcontainer.Controls)
                    {
                        if (uc.ToString() != userctrl.ToString())
                        {

                            Tabcontainer.Controls.Add(userctrl);
                            uc.Visible = false;
                            uc.Dispose();
                        }
                    }
                }
                else
                {
                    Tabcontainer.Controls.Add(userctrl);
                }
                Indicator.Top = c;
                userctrl.Dock = DockStyle.Fill;
            }
            catch (Exception ex) //If a tab could not be loaded
            {
                Program.Log("[Error] Failed to load " + userctrl.ToString());
                Program.Log("[Exception] " + ex);
            }
        }
        #endregion

        //Controls
        #region Debugger
        private void OpenDebugger(object sender, EventArgs e)
        {
            Form Debug = new Debugger();
            Theme.Set(Debug);
            if (Configuration.DebuggerOpen == false) { Configuration.DebuggerOpen = true; Debug.Show(); }
        }
        #endregion

        #region Tab buttons
        private void PerformanceButton_Click(object sender, EventArgs e) { LoadTab(new Performance(), 210); }
        private void GPIOButton_Click(object sender, EventArgs e) { LoadTab(new Peripherals(), 260); }
        private void AppstoreButton_Click(object sender, EventArgs e) { LoadTab(new Appstore(), 310); }
        private void AboutButton_Click(object sender, EventArgs e) { LoadTab(new About(), 360); }
        private void OverlayButton_Click(object sender, EventArgs e) { LoadTab(new Overlay(), 410); }
        private void SettingsButton_Click(object sender, EventArgs e) { LoadTab(new Settings(), 460); }

        #endregion

        //Events
        #region Paint events

        private void PerformanceButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("", Theme.glyphs, drawBrush, 8, 14);
        }

        private void PeripheralsButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("", Theme.glyphs, drawBrush, 6, 14);
        }

        private void AppstoreButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("", new Font(Theme.glyphs.Name, 9.75f), drawBrush, 14, 14);
            e.Graphics.DrawString("", new Font(Theme.glyphs.Name, 15.5f), drawBrush, 8, 20);
        }

        private void AboutButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("", Theme.glyphs, drawBrush, 8, 14);
        }

        private void OverlayButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("", Theme.glyphs, drawBrush, 8, 14);
        }

        private void SettingsButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("", Theme.glyphs, drawBrush, 8, 14);
        }
        #endregion

        #region Focus/Unfocus
        private void MainWindow_Activated(object sender, EventArgs e)
        {
            //Change the program's theme when active
            Theme.Read();
            if (PreviousThemeMode != Theme.ThemeMode)
            {
                drawBrush = new SolidBrush(Theme.Text);
                Theme.Initialize(this);
                Theme.Set(Tabcontainer);
            }
            PreviousThemeMode = Theme.ThemeMode;

            //Make the sidepanel have acrylic when the window is in focus
            if (Theme.Transparency)
            {
                //TODO: Add animation
                SidePanel.BackColor = Theme.Panel;
                Theme.CurrentAccent = WindowUtils.ACCENT.ENABLE_ACRYLICBLURBEHIND;
                WindowUtils.EnableAcrylic(this, SidePanel, true);
            }
        }

        private void MainWindow_Deactivate(object sender, EventArgs e)
        {
            //Make the sidepanel opaque when the window is no longer in focus
            if (Theme.Transparency)
            {
                //TODO: Add animation
                SidePanel.BackColor = Theme.Panel;
                Theme.CurrentAccent = WindowUtils.ACCENT.DISABLED;
                WindowUtils.EnableAcrylic(this, SidePanel);
                TransparencyKey = Color.Empty;
            }
        }
        #endregion
    }
}