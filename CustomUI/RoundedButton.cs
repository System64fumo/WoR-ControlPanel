using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WoRCP
{
    [DefaultEvent("Click")]
    public partial class RoundedButton : Panel
    {
        //Main
        #region Variables
        int rounding = Theme.ButtonRounding;
        string text = "Button";
        Color currentcolor = Theme.Accent;
        public event EventHandler Click;
        #endregion

        #region Properties
        [Category("Advanced")]
        public Color Color
        {
            get { return currentcolor; }
            set { currentcolor = value; this.Invalidate(); }
        }
        [Category("Advanced")]
        public string ButtonText
        {
            get { return text; }
            set { text = value; Button.Text = value; }
        }
        [Category("Advanced")]
        public int Rounding
        {
            get { return rounding; }
            set { rounding = value; this.Invalidate(); }
        }
        #endregion

        #region Loading and initialization
        public RoundedButton()
        {
            InitializeComponent();
            RoundedCorners.Round(Button,rounding + 2);
        }
        #endregion

        //Events
        #region Paint
        private void RoundedButton_Paint(object sender, PaintEventArgs e)
        {
            if (currentcolor == Color.FromArgb(50, 50, 65)) currentcolor = Theme.Accent;
            else if (currentcolor == Color.FromArgb(60, 60, 75)) currentcolor = Theme.BrightAccent;
            else if (currentcolor == Color.FromArgb(40, 40, 55)) currentcolor = Theme.DarkAccent;
            else if (currentcolor == Color.FromArgb(30, 30, 35) || currentcolor == Color.FromArgb(225, 225, 225)) currentcolor = Theme.Inactive;
            else if (currentcolor == Color.FromArgb(20, 20, 20) || currentcolor == Color.FromArgb(243, 243, 243)) currentcolor = Theme.Background;
            else if (currentcolor == Color.FromArgb(25, 25, 27) || currentcolor == Color.FromArgb(251, 251, 251)) currentcolor = Theme.Panel;
            else if (currentcolor == Color.FromArgb(35, 35, 40) || currentcolor == Color.FromArgb(242, 242, 242)) currentcolor = Theme.BrightPanel;
            RoundedCorners.Paint(e, this.Width, this.Height, Rounding, currentcolor);
            Button.BackColor = currentcolor;
            this.BackColor = Color.Transparent;
        }
        #endregion

        #region Click
        private void Button_Click(object sender, EventArgs e)
        {
            if (Click != null)
            {
                Click.Invoke(this, e);
            }
        }
        #endregion

        #region Size changed
        private void RoundedButton_SizeChanged(object sender, EventArgs e)
        {
            Button.Size = this.Size;
            RoundedCorners.Round(Button, rounding + 2);
        }
        #endregion
    }
}