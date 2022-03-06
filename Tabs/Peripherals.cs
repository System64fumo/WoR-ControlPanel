using System;
using System.Device.Gpio;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WoRCP.Tabs
{
    public partial class Peripherals : UserControl
    {
        //Main
        #region Variables
        private GpioController gpio = null;
        private RoundedButton lastpin;
        private int[] PinNums = new int[] { 0, 0, 0, 0, 0, 18, 0, 23, 24, 0, 25, 8, 7, 0, 0, 12, 0, 16 ,20, 21,
                                            0, 2, 3, 4, 0, 17, 27, 22, 0, 10, 9, 11, 0, 0, 5, 6, 13, 19, 26,0 };
        int SelectedPin;

        #endregion

        #region Loading and Initialization
        public Peripherals()
        {
            InitializeComponent();

        }
        private void Peripherals_Load(object sender, EventArgs e)
        {
            if (Configuration.CPUArch == "ARM64")
            {
                initializeGPIO();
                addPins();
                ControlContainer.Visible = true;
            }
        }
        #endregion

        //Methods
        #region Initialize GPIO
        public void initializeGPIO()
        {
            try //Check if GPIO is supported
            {
                gpio = new GpioController();
                Program.Log("[Info] GPIO is working properly");
            }
            catch (NotSupportedException)
            {
                var result = MessageBox.Show("GPIO Error , Attempt to fix it ?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) { Process.Start("CMD", "sc config rhproxy start = demand"); }
                else { Program.Log("[Error] Unable to initialize GPIO"); }
            }
        }
        #endregion

        #region Add GPIO Pins
        public void addPins()
        {
            for (int i = 1; i <= PinNums.Length; i++) //TODO Replace this with a better system
            {
                try
                {
                    //GPIO Pin Style
                    RoundedButton pin = new RoundedButton();
                    pin.ButtonText = "";
                    pin.Size = new Size(28, 28);
                    pin.Font = new Font(pin.Font.Name, 10f);
                    pin.Margin = new Padding(0, 0, 3, 3);
                    pin.Rounding = 2;

                    if (PinNums[i - 1] != 0)
                    {
                        pin.ButtonText = PinNums[i - 1].ToString(); //Print GPIO Number on Pins
                        pin.Tag = PinNums[i - 1];
                        pin.Color = Theme.Accent;
                        if (!gpio.IsPinOpen(PinNums[i - 1]))
                        {
                            gpio.OpenPin(PinNums[i - 1], PinMode.Output);
                            gpio.Write(PinNums[i - 1], PinValue.Low);
                        }
                    }
                    else
                    {
                        pin.Color = Theme.Inactive;
                        pin.Enabled = false;
                    }
                    pin.Click += Btn_Click;
                    PinArray.Controls.Add(pin);
                }
                catch
                {
                    Program.Log("[Error] Unable to add pin number: " + PinNums[i - 1]);
                }
            }
        }
        #endregion

        #region Read pins
        private void readPins()
        {
            for (int i = 1; i <= 40; i++)
            {
                try //TODO Replace with a proper reading system
                {
                    if (PinNums[i - 1] != 0 && gpio.Read(PinNums[i - 1]).ToString() == "High")
                    {
                        MessageBox.Show("Pin: " + PinNums[i - 1] + " is High");
                    }
                    else if (PinNums[i - 1] != 0 && gpio.Read(PinNums[i - 1]).ToString() == "Low")
                    {
                        MessageBox.Show("Pin: " + PinNums[i - 1] + " is Low");
                    }
                }
                catch
                {
                    Program.Log("[Error] Unable to read pin number: " + PinNums[i - 1]);
                }
            }
        }
        #endregion

        #region PinClick
        private void Btn_Click(object sender, EventArgs e)
        {
            //Setup
            RoundedButton button = (sender as RoundedButton);
            SelectedPin = Convert.ToInt32(button.Tag);
            SelectedPinLabel.Text = "Selected pin: " + SelectedPin.ToString();

            //Check if the pin is Low or High
            PinStateState.Text = gpio.Read(SelectedPin).ToString();
            if (gpio.Read(SelectedPin).ToString() == "High")
            {
                PinStateToggle.Toggled = true;
            }
            else
            {
                PinStateToggle.Toggled = false;
            }

            //Check if the pin is an Input or an Output
            PinModeState.Text = gpio.GetPinMode(SelectedPin).ToString();
            if (gpio.GetPinMode(SelectedPin).ToString() == "Output")
            {
                PinModeToggle.Toggled = true;
            }
            else
            {
                PinModeToggle.Toggled = false;
            }
            PinStateToggle.Enabled = PinModeToggle.Toggled;

            //Pin theming
            button.Color = Theme.DarkAccent;
            button.Invalidate();
            if (lastpin != null)
            {
                lastpin.Color = Theme.Accent;
                lastpin.Invalidate();
            }
            lastpin = button;
        }
        #endregion

        #region Toggles

        private void PinStateToggle_ToggledEvent(object sender, EventArgs e)
        {
            if (gpio.Read(SelectedPin).ToString() == "High")
            {
                gpio.Write(SelectedPin, PinValue.Low);
            }
            else
            {
                gpio.Write(SelectedPin, PinValue.High);
            }
            PinStateState.Text = gpio.Read(SelectedPin).ToString();
        }

        private void PinModeToggle_ToggledEvent(object sender, EventArgs e)
        {
            if (gpio.GetPinMode(SelectedPin).ToString() == "Input")
            {
                gpio.SetPinMode(SelectedPin, PinMode.Output);
            }
            else
            {
                gpio.SetPinMode(SelectedPin, PinMode.Input);
            }
            PinModeState.Text = gpio.GetPinMode(SelectedPin).ToString();
            PinStateToggle.Enabled = PinModeToggle.Toggled;
        }
        #endregion

        #region Close pins on unload
        private void Peripherals_EnabledChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= PinNums.Length; i++)
            {
                try
                {
                    if (PinNums[i - 1] != 0)
                    {
                        if (gpio.IsPinOpen(PinNums[i - 1]))
                        {
                            gpio.ClosePin(PinNums[i - 1]);
                        }
                    }
                }
                catch
                {
                    Program.Log("[Error] Unable to close pin number: " + PinNums[i - 1]);
                }
            }
        }
        #endregion
    }
}
