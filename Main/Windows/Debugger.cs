using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WoRCP.UI;

namespace WoRCP
{
    public partial class Debugger : Form
    {
        //Main
        #region Loading and Initialization
        public Debugger() { InitializeComponent(); }
        private void Debugger_Load(object sender, EventArgs e)
        {
            string spacing = Program.Spacing(6);
            //Display the theme system's values in text
            ThemePanel.RightContent[0] = Theme.ThemeMode.ToString();
            ThemePanel.RightContent[1] = Theme.Transparency.ToString();
            ThemePanel.RightContent[2] = getRGB(Theme.BrightAccent) + spacing;
            ThemePanel.RightContent[3] = getRGB(Theme.Accent) + spacing;
            ThemePanel.RightContent[4] = getRGB(Theme.DarkAccent) + spacing;
            ThemePanel.RightContent[5] = getRGB(Theme.BrightPanel) + spacing;
            ThemePanel.RightContent[6] = getRGB(Theme.Inactive) + spacing;
            ThemePanel.RightContent[7] = getRGB(Theme.Panel) + spacing;
            ThemePanel.RightContent[8] = getRGB(Theme.Background) + spacing;

            //Change titlebar glyphs
            MinimizeButton.Font = new Font(Theme.glyphs.Name, 9.75f);
            CloseButton.Font = new Font(Theme.glyphs.Name, 9.75f);

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
