﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private string PreviousTabName;
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
            ResourceReader.changeTrayIcon();
            ChangeIcon();

            //Load the default tab
            LoadTab(new Performance(), PerformanceButton);
        }
        #endregion

        #region Titlebar
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.crashed = false;
            if (File.Exists(Path.GetTempPath() + "list.txt")) { File.Delete(Path.GetTempPath() + "list.txt"); }
            Application.Exit();
        }

        private void OnMinimize()
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
        protected override void WndProc(ref Message m)
        {
            // Trap WM_SYSCOMMAND, SC_MINIMIZE
            if (m.Msg == 0x112 && m.WParam.ToInt32() == 0xf020)
            {
                OnMinimize();
                return;        // NOTE: delete if you still want the default behavior
            }
            base.WndProc(ref m);
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
        private void LoadTab(UserControl userctrl, Control button)
        {
            try //Try to load the tabs
            {
                //Check if the previous tab is the same as the new tab
                if (PreviousTabName == userctrl.Name) return;

                Program.Log("[Info] Loading" + userctrl.Name + " tab");
                PreviousTabName = userctrl.Name;

                //Subtle animation
                Indicator.Top += (button.Top + 10 - Indicator.Top) / 2;

                //Check if the loaded tab requires the resource reader
                if (Configuration.OverlayEnabled || ResourceReader.trayicon.Visible) ResourceReader.timer.Enabled = true;
                else ResourceReader.timer.Enabled = false;


                //Check if the tab containes more than 1 tab
                if (Tabcontainer.Controls.Count > 0)
                    Tabcontainer.Controls.Clear();

                //Position the indicator accordingly
                Indicator.Top = button.Top + 10;

                //Load the tab
                Theme.Set(userctrl);
                Tabcontainer.Controls.Add(userctrl);
                userctrl.Visible = true;
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
        private void PerformanceButton_Click(object sender, EventArgs e) { LoadTab(new Performance(), PerformanceButton); }
        private void GPIOButton_Click(object sender, EventArgs e) { LoadTab(new Peripherals(), PeripheralsButton); }
        private void AppstoreButton_Click(object sender, EventArgs e) { LoadTab(new Appstore(), AppstoreButton); }
        private void AboutButton_Click(object sender, EventArgs e) { LoadTab(new About(), AboutButton); }
        private void OverlayButton_Click(object sender, EventArgs e) { LoadTab(new Overlay(), OverlayButton); }
        private void SettingsButton_Click(object sender, EventArgs e) { LoadTab(new Settings(), SettingsButton); }

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
                Theme.Initialize(this,SidePanel, 1 + Convert.ToInt32(Theme.Transparency));
                Theme.Set(Tabcontainer);
            }
            PreviousThemeMode = Theme.ThemeMode;
        }
        #endregion
    }
}