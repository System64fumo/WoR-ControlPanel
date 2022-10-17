using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WoRCP.UI
{
    public partial class Slider : UserControl
    {
        //Main
        #region Variables
        float OutlineSize = 5;
        Point lastPoint;
        double CurrentValueP = 50;
        double CurrentValue = 50;
        double Max = 100;
        double Min = 0;
        bool doublevalue = false;
        public event EventHandler Selecting;
        public event EventHandler Selected;
        #endregion

        #region Properties
        [Category("Advanced")]
        public double Value
        {
            get { return CurrentValue; }
            set
            {
                if (doublevalue)
                {
                    CurrentValue = value;
                    CurrentValueP = ((value - Min) * 100) / (Max - Min);
                }
                else
                {
                    CurrentValue = (int)value;
                    CurrentValueP = (int)((value - Min) * 100) / (Max - Min);
                }
                double Value = (SliderBG.Width * CurrentValueP) / 100;
                SliderFiller.Width = Convert.ToInt32(Value);
                SliderKnob.Left = Convert.ToInt32(Value);
            }
        }
        [Category("Advanced")]
        public double ValueP
        {
            get { return CurrentValueP; }
            set
            {
                if (doublevalue)
                {
                    CurrentValueP = value;
                    CurrentValue = (value * (Max - Min) / 100) + Min;
                }
                else
                {
                    CurrentValueP = (int)value;
                    CurrentValue = (int)(value * (Max - Min) / 100) + Min;
                }
                double Value = (SliderBG.Width * value) / 100;
                SliderFiller.Width = Convert.ToInt32(Value);
                SliderKnob.Left = Convert.ToInt32(Value);
            }
        }
        [Category("Advanced")]
        public double MaxValue
        {
            get { return Max; }
            set
            {
                Max = value;
            }
        }
        [Category("Advanced")]
        public double MinValue
        {
            get { return Min; }
            set
            {
                Min = value;
            }
        }
        [Category("Advanced")]
        public bool Double
        {
            get { return doublevalue; }
            set { doublevalue = value; }
        }
        #endregion

        #region Loading and Initalization
        public Slider()
        {
            InitializeComponent();
            Value = CurrentValue;
            SliderFiller.BackColor = Theme.Accent;
        }
        #endregion

        //Events
        #region Knob
        private void SliderKnob_MouseDown(object sender, MouseEventArgs e) { if (Enabled == true) { OutlineSize = 6; lastPoint = new Point(e.X); SliderKnob.Invalidate(); } }
        private void SliderKnob_MouseMove(object sender, MouseEventArgs e)
        {
            if (Enabled == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    int x = Convert.ToInt32(SliderKnob.Location.ToString().Replace("{X=", "").Replace(",Y=" + SliderKnob.Location.Y.ToString() + "}", ""));
                    if (x >= 1 && x <= SliderBG.Width - 1) { SliderKnob.Left += e.X - lastPoint.X; }
                    if (x >= SliderBG.Width) { SliderKnob.Left += Math.Min(0, e.X - lastPoint.X); }
                    if (x <= 0) { SliderKnob.Left += Math.Max(0, e.X - lastPoint.X); }
                    if (SliderFiller.Width >= SliderBG.Width + 1) { SliderKnob.Left = SliderBG.Width; SliderFiller.Width = SliderBG.Width; }

                    if (SliderKnob.Left <= -1) { SliderKnob.Left = 0; }
                    SliderFiller.Width = x;
                    int val = (int)(0.5f + ((100f * SliderFiller.Width) / SliderBG.Width));
                    if (doublevalue)
                    {
                        CurrentValueP = Math.Min(100, val);
                        CurrentValue = ((CurrentValueP * (Max - Min)) / 100) + Min;
                    }
                    else
                    {
                        CurrentValueP = Math.Min(100, val);
                        CurrentValue = (int)((CurrentValueP * (Max - Min)) / 100) + Min;
                    }
                    Selecting?.Invoke(this, e);
                }
            }
        }
        private void SliderKnob_MouseUp(object sender, MouseEventArgs e)
        {
            if (Enabled == true)
            {
                OutlineSize = 3.5f;
                SliderKnob.Invalidate();
                int x = Convert.ToInt32(SliderKnob.Location.ToString().Replace("{X=", "").Replace(",Y=" + SliderKnob.Location.Y.ToString() + "}", ""));
                if (SliderFiller.Width >= SliderBG.Width) { SliderKnob.Left = SliderBG.Width; SliderFiller.Width = SliderBG.Width; }
                if (x <= 0) { SliderKnob.Left = 0; }
                int val = (int)(0.5f + ((100f * SliderFiller.Width) / SliderBG.Width));
                if (doublevalue)
                {
                    CurrentValueP = val;
                    CurrentValue = ((CurrentValueP * (Max - Min)) / 100) + Min;
                }
                else
                {
                    CurrentValueP = val;
                    CurrentValue = (int)((CurrentValueP * (Max - Min)) / 100) + Min;
                }
                Selected?.Invoke(this, e);
            }
        }

        private void SliderKnob_MouseLeave(object sender, EventArgs e) { if (Enabled) { OutlineSize = 5; SliderKnob.Invalidate(); } }
        private void SliderKnob_MouseEnter(object sender, EventArgs e) { if (Enabled) { OutlineSize = 3.5f; SliderKnob.Invalidate(); } }
        private void SliderKnob_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            // Create pen.
            Pen pen = new Pen(Theme.BrightPanel, OutlineSize);
            // Create rectangle for circle.
            Rectangle rect = new Rectangle(0, 0, 19, 19);
            if (Enabled)
                e.Graphics.FillEllipse(new SolidBrush(Theme.BrightAccent), rect);
            else
                e.Graphics.FillEllipse(new SolidBrush(Theme.Disabled), rect);
            // Draw circle.
            e.Graphics.DrawArc(pen, (pen.Width / 2) - 1, (pen.Width / 2) - 1, 19 - pen.Width + 2, 19 - pen.Width + 2, 0, 360);
        }
        #endregion

        #region Other
        private void Resized(object sender, EventArgs e) { Value = CurrentValue; }
        private void Slider_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                SliderFiller.BackColor = Theme.Accent;
            }
            else
            {
                SliderFiller.BackColor = Color.FromArgb(100, 100, 100);
            }
            SliderKnob.Invalidate();
        }

        private void SliderBG_Paint(object sender, PaintEventArgs e)
        {
            RoundedCorners.Paint(e, SliderBG.Width, SliderBG.Height, Theme.SliderBarRounding, Theme.Inactive);
        }
        #endregion
    }
}
