using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WoRCP.UI
{
    [DefaultEvent("Click")]
    public partial class RoundedButton : Panel
    {
        //Main
        #region Variables
        private int rounding = Theme.ButtonRounding;
        private string text = "Button";
        private Color currentcolor = Theme.Accent;
        private Font font = Theme.font;
        private bool glyph;
        private bool hovering;
        #endregion

        #region Properties
        [Category("Advanced")]
        public Color Color
        {
            get { return currentcolor; }
            set
            {
                if (hovering)
                {
                    currentcolor = Color.FromArgb(Theme.WithinRange(value.R + 10), Theme.WithinRange(value.G + 10), Theme.WithinRange(value.B + 10));
                    Invalidate();
                    return;
                }
                currentcolor = value;
                Invalidate();
            }
        }
        [Category("Advanced")]
        public string ButtonText
        {
            get { return text; }
            set { text = value; Invalidate(); }
        }
        [Category("Advanced")]
        public int Rounding
        {
            get { return rounding; }
            set { rounding = value; Invalidate(); }
        }
        [Category("Advanced")]
        public bool Glyph
        {
            get { return glyph; }
            set
            {
                glyph = value;
                if (font == Theme.font)  font = Theme.font;
                else font = Theme.glyphs;
                Invalidate();
            }
        }
        #endregion

        #region Loading and initialization
        public RoundedButton()
        {
            InitializeComponent();
        }
        #endregion

        //Events
        #region Paint
        private void RoundedButton_Paint(object sender, PaintEventArgs e)
        {
            currentcolor = Theme.ReturnColor(currentcolor);
            RoundedCorners.Paint(e, Width, Height, Rounding, currentcolor);
            BackColor = Color.Transparent;

            //Change the text's fore color to match the state of the Button
            SolidBrush drawBrush;
            if (Enabled) drawBrush = new SolidBrush(ForeColor);
            else drawBrush = new SolidBrush(Theme.Disabled);

            //Drawing the button's string
            SizeF TextSize = e.Graphics.MeasureString(text, font);
            e.Graphics.DrawString(text, font, drawBrush, Width / 2 - TextSize.Width / 2, Height / 2 - TextSize.Height / 2);
        }
        #endregion

        #region Size changed
        private void RoundedButton_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
        #endregion

        #region Hover events
        private void RoundedButton_MouseEnter(object sender, EventArgs e)
        {
            hovering = true;
            currentcolor = Color.FromArgb(Theme.WithinRange(currentcolor.R + 10), Theme.WithinRange(currentcolor.G + 10), Theme.WithinRange(currentcolor.B + 10));
            Invalidate();
        }

        private void RoundedButton_MouseLeave(object sender, EventArgs e)
        {
            hovering = false;
            currentcolor = Color.FromArgb(Theme.WithinRange(currentcolor.R - 10), Theme.WithinRange(currentcolor.G - 10), Theme.WithinRange(currentcolor.B - 10));
            Invalidate();
        }
        #endregion
    }
}