using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WoRCP.UI
{
    public class RoundedCorners
    {
        #region Basic rounding
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr RoundedRectangle
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public static void Round(Control Ctrl, int Rounding)
        {
            Ctrl.Region = Region.FromHrgn(RoundedRectangle(0, 0, Ctrl.Width, Ctrl.Height, Rounding, Rounding));
        }
        #endregion

        #region Custom Rounding
        private static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0) { path.AddRectangle(bounds); return path; }

            // top left arc  
            path.AddArc(arc, 190, 70);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        private static void FillRoundedRectangle(Graphics graphics, Brush brush, Rectangle bounds, int cornerRadius)
        {
            using (GraphicsPath path = RoundedRect(bounds, cornerRadius)) { graphics.FillPath(brush, path); }
        }

        public static void Paint(PaintEventArgs e, int Width, int Height, int Rounding, Color color)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradientRectangle = new Rectangle(-1, -1, Width, Height);
            Brush b = new LinearGradientBrush(gradientRectangle, color, color, 0.0f);
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            FillRoundedRectangle(graphics, b, gradientRectangle, Rounding);
        }
        #endregion
    }
}
