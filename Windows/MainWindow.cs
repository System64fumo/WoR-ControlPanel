using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WoRCP.Tabs;

namespace WoRCP
{
    public partial class MainWindow : Form
    {
        //Main
        #region Variables
        private Font font = new Font("Segoe MDL2 Assets", 16f);
        private SolidBrush drawBrush;
        #endregion

        #region Loading and Initialization
        public MainWindow()
        {
            InitializeComponent();
            Configuration.mainwindow = this;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
            Program.Log("[Info] Welcome to WoR Control Panel");
            Program.Log("[Info] Version: " + Configuration.Version);
            Program.Log("[Info] Windows: " + Configuration.Build);
            Program.Log("[Info] Running on: " + Configuration.DeviceName + " / " + Configuration.CPUArch);
            Greeting.Text = Configuration.Greeting + "\n" + Configuration.User + "!";
            if (Convert.ToInt32(Configuration.Build) >= 22000)
            {
                font = new Font("Segoe Fluent Icons", 16f);
            }
            drawBrush = new SolidBrush(Theme.Text);
            CloseButton.Font = new Font(font.Name, 9.75f);
            MinimizeButton.Font = new Font(font.Name, 9.75f);
            LoadTab(new Performance(), 210);
            ResourceReader.changeTrayIcon();
            ChangeIcon();
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
                if (Configuration.OverlayEnabled || ResourceReader.trayicon.Visible) { ResourceReader.timer.Enabled = true; }
                if (Tabcontainer.Controls.Count > 0)
                {
                    foreach (UserControl uc in Tabcontainer.Controls)
                    {
                        if (uc.ToString() != userctrl.ToString())
                        {
                            Tabcontainer.Controls.Add(userctrl);
                            uc.Enabled = false;
                            uc.Dispose();
                        }
                    }
                }
                else
                {
                    Tabcontainer.Controls.Add(userctrl);
                }
                Theme.Set(userctrl);
                Indicator.Top = c;
                userctrl.Dock = DockStyle.Fill;
            }
            catch //If a tab could not be loaded
            {
                Program.Log("[Error] Failed to load " + userctrl.ToString());
            }
        }
        #endregion

        #region Paint events

        private void PerformanceButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("", font, drawBrush, 8, 16);
        }

        private void PeripheralsButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("", font, drawBrush, 6, 16);
        }

        private void AppstoreButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("", new Font(font.Name, 9.75f), drawBrush, 14, 16);
            e.Graphics.DrawString("", new Font(font.Name, 15.5f), drawBrush, 8, 20);
        }

        private void AboutButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("", font, drawBrush, 8, 16);
        }

        private void OverlayButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("", font, drawBrush, 8, 16);
        }

        private void SettingsButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("", font, drawBrush, 8, 16);
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

    }
}