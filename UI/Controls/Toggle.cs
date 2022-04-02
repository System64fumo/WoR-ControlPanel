using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WoRCP.UI
{
    public partial class Toggle : UserControl
    {
        //Main
        #region Variables
        private bool toggled;
        Color color = Theme.Inactive;
        Color knobcolor = Color.White;
        public event EventHandler ToggledEvent;
        #endregion

        #region Properties
        [Category("Advanced")]
        public bool Toggled
        {
            get { return toggled; }
            set
            {
                toggled = value;
                if (toggled)
                {
                    color = Theme.Accent;
                    ToggleKnob.Left = 23;
                }
                else
                {
                    color = Theme.Inactive;
                    ToggleKnob.Left = 3;
                }
                if (!Enabled)
                {
                    color = Color.FromArgb(100, 100, 100);
                }
                Invalidate();
            }
        }
        #endregion

        #region Loading and initialization
        public Toggle()
        {
            InitializeComponent();
        }
        #endregion

        #region Toggle
        private void toggle()
        {
            if (toggled)
            {
                color = Theme.Inactive;
                ToggleKnob.Left = 3;
            }
            else
            {
                color = Theme.Accent;
                ToggleKnob.Left = 23;
            }
            toggled = !toggled;
            Invalidate();
            ToggledEvent?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        //Events
        #region Paint
        private void ToggleKnob_Paint(object sender, PaintEventArgs e) { RoundedCorners.Paint(e, ToggleKnob.Width, ToggleKnob.Height, 7, knobcolor); }
        private void Toggle_Paint(object sender, PaintEventArgs e) { RoundedCorners.Paint(e, 40, 20, Theme.ToggleRounding, color); }
        #endregion

        #region Click
        private void Toggle_Click(object sender, EventArgs e) { toggle(); }
        private void ToggleKnob_Click(object sender, EventArgs e) { toggle(); }
        #endregion

        #region Enabled Changed
        private void Toggle_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                knobcolor = Color.White;
                if (toggled) color = Theme.Accent;
                else color = Theme.Inactive;
                Invalidate();
            }
            else { knobcolor = Color.FromArgb(150, 150, 150); color = Color.FromArgb(100, 100, 100); Invalidate(); }
        }
        #endregion

        #region Hover events

        private void Toggle_MouseEnter(object sender, EventArgs e)
        {
            if (toggled) color = Theme.BrightAccent;
            else color = Theme.BrightPanel;
            Invalidate();
        }

        private void Toggle_MouseLeave(object sender, EventArgs e)
        {
            if (toggled) color = Theme.Accent;
            else color = Theme.Inactive;
            Invalidate();
        }
        #endregion
    }
}
