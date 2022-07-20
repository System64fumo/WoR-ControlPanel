using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WoRCP.UI
{
    public class Toggle : CheckBox
    {
        public Toggle()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            this.OnPaintBackground(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var path = new GraphicsPath())
            {
                //Draw toggle background
                int h = this.Height - 1;
                path.AddArc(0, 0, h, h, 90, 180);
                path.AddArc(this.Width - h - 1, 0, h, h, -90, 180);
                path.CloseFigure();
                e.Graphics.FillPath(Checked ? new SolidBrush(Theme.BrightAccent) : Brushes.Transparent, path);
                e.Graphics.DrawPath(new Pen(Checked ? new SolidBrush(Theme.BrightAccent) : new SolidBrush(Theme.Disabled)), path);

                //Draw toggle circle
                int pad = 6;
                var rect = Checked ? new Rectangle(Width - h + (pad / 2) - 1, pad / 2, h - pad, h - pad) : new Rectangle(pad / 2, pad / 2, h - pad, h - pad);
                e.Graphics.FillEllipse(Checked ? new SolidBrush(Color.FromArgb(Theme.Text.ToArgb() ^ 0xFFFFFF)) : new SolidBrush(Color.FromArgb(150, Theme.Text)), rect);
            }
        }
    }
}