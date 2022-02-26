using System;
//using System.Device.Gpio;
using System.Diagnostics;
using System.Windows.Forms;

namespace WoRCP.Tabs
{
    public partial class Peripherals : UserControl
    {
        //public GpioController gpio = null;

        //Main
        #region Loading and Initialization
        public Peripherals()
        {
            InitializeComponent();
        }
        #endregion

        private void button1_Click(object sender, System.EventArgs e)
        {
            /*
            try
            { GPIO(); button1.Text = "GPIO : Active " + Environment.NewLine + "Selected Pin : None" + Environment.NewLine + Environment.NewLine + "Type" + Environment.NewLine + Environment.NewLine + "State" + Environment.NewLine + Environment.NewLine + ""; }
            catch (System.NotSupportedException)
            {
                var result = MessageBox.Show("GPIO Error , Attempt to fix it ?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) { Process.Start("CMD", "sc config rhproxy start = demand"); }
                else { button1.Text = "GPIO : Inactive " + Environment.NewLine + "Selected Pin : None" + Environment.NewLine + Environment.NewLine + "Type" + Environment.NewLine + Environment.NewLine + "State" + Environment.NewLine + Environment.NewLine + ""; }
            }*/
        }
        //public void GPIO() { gpio = new GpioController(); }
    }
}
