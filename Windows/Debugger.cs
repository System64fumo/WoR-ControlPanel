using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WoRCP
{
    public partial class Debugger : Form
    {
        //Main
        #region Loading and Initialization
        public Debugger() { InitializeComponent(); }
        private void Debugger_Load(object sender, EventArgs e)
        {
            //Display the theme system's values in text
            ThemeMode.Text = Theme.ThemeMode.ToString();
            Transparency.Text = Theme.Transparency.ToString();
            BrightAccent.Text = getRGB(Theme.BrightAccent);
            Accent.Text = getRGB(Theme.Accent);
            DarkAccent.Text = getRGB(Theme.DarkAccent);
            Inactive.Text = getRGB(Theme.Inactive);
            Panel.Text = getRGB(Theme.Panel);
            Background.Text = getRGB(Theme.Background);
            BrightPanel.Text = getRGB(Theme.BrightPanel);

            //Read config
            LogTextBox.Text = Program.LogOutput;
        }
        #endregion

        #region Titlebar
        Point lastPoint;
        private void DragStart(object sender, MouseEventArgs e) { lastPoint = new Point(e.X, e.Y); }
        private void DragMove(object sender, MouseEventArgs e) { if (e.Button == MouseButtons.Left) { this.Left += e.X - lastPoint.X; this.Top += e.Y - lastPoint.Y; } }
        private void CloseButton_Click(object sender, System.EventArgs e) { this.Close(); Configuration.DebuggerOpen = false; }
        private void MinimizeButton_Click(object sender, System.EventArgs e) { WindowState = FormWindowState.Minimized; }
        #endregion

        //Methods
        #region Update the logger
        private void LogUpdater_Tick(object sender, EventArgs e)
        {
            LogTextBox.Text = Program.LogOutput;
        }
        #endregion

        #region Get RGB
        private string getRGB(Color color)
        {
            return (color.R + " " + color.G + " " + color.B).ToString();
        }
        #endregion

        //Controls
        #region Toggles
        private void AdvancedOCToggle_ToggledEvent(object sender, EventArgs e)
        {
            Configuration.AdvancedOC = AdvancedOCToggle.Toggled;
            MessageBox.Show("By enabling this setting you agree that you are putting your raspberry pi at risk.\nProceed at your own risk", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region Buttons
        private void SaveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A log has been created on your desktop" + Environment.NewLine + Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Log.txt" + Environment.NewLine + "If you had any issues with WoRCP or your Pi" + Environment.NewLine + "please send this log to the developer");
            StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Log.txt");
            sw.WriteLine(Program.LogOutput);
            sw.Close();
        }
        #endregion
    }
}
