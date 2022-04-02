using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WoRCP.UI
{
    public partial class CollapsiblePanel : Panel
    {
        //Main
        #region Variables
        private string icon = "";
        private string expander = "";
        private bool collapsed = true;
        private int rounding = Theme.PanelRounding;
        private int separators = 0;
        private string[] leftcontent = new string[0];
        private string[] rightcontent = new string[0];
        private Color panelcolor = Color.FromArgb(25, 25, 27);
        private Color currentcolor = Color.FromArgb(25, 25, 27);
        private readonly Font font = Theme.glyphs;
        private readonly Font textfont = new Font("Segoe UI", 9f);
        private string title = "Expandable panel";
        #endregion

        #region Properties
        [Category("Advanced")]
        public Color Color
        {
            get { return currentcolor; }
            set { currentcolor = value; panelcolor = value; Invalidate(); }
        }
        [Category("Advanced")]
        public int Rounding
        {
            get { return rounding; }
            set { rounding = value; Invalidate(); }
        }
        [Category("Advanced")]
        public bool Collapsed
        {
            get { return collapsed; }
            set
            {
                collapsed = value;

                if (separators == 0)
                {
                    if (value)
                    {

                        Height = 60;
                        Invalidate();
                    }
                    else
                    {
                        Height = MaximumSize.Height;
                        Invalidate();
                    }
                }
                else
                {
                    if (value)
                    {
                        expander = "";
                        Height = 60;
                        Invalidate();
                    }
                    else
                    {
                        expander = "";
                        Height = 60 + separators * 51;
                        Invalidate();
                    }
                }
            }

        }

        [Category("Advanced")]
        public string Icon
        {
            get { return icon; }
            set { icon = value; }
        }
        [Category("Advanced")]
        public string Title
        {
            get { return title; }
            set { title = value; Invalidate(); }
        }

        [Category("Advanced")]
        public string[] LeftContent
        {
            get { return leftcontent; }
            set
            {
                leftcontent = value;
                separators = leftcontent.Length;
                Height = 60 + separators * 51;
                Invalidate();
            }
        }
        [Category("Advanced")]
        public string[] RightContent
        {
            get { return rightcontent; }
            set { rightcontent = value; Invalidate(); }
        }
        #endregion

        #region Loading and Initialization
        public CollapsiblePanel()
        {
            InitializeComponent();
        }
        #endregion

        //Events
        #region Paint events
        private void CollapsiblePanel_Paint(object sender, PaintEventArgs e)
        {
            currentcolor = Theme.ReturnColor(currentcolor);
            RoundedCorners.Paint(e, Width, Height, Rounding, currentcolor);
            BackColor = Color.Transparent;

            SolidBrush drawBrush;
            if (Enabled) drawBrush = new SolidBrush(ForeColor);
            else drawBrush = new SolidBrush(Theme.Disabled);

            int septop = 60;
            for (int i = 0; i < leftcontent.Length; i++)
            {
                //Draw the left content
                if (leftcontent[i] != "") e.Graphics.DrawLine(new Pen(Theme.Background, 1), new Point(0, septop), new Point(Width, septop));
                e.Graphics.DrawString(leftcontent[i], textfont, drawBrush, 45, septop + 18);

                //Draw the right content
                if (i <= rightcontent.Length - 1)
                {
                    SizeF stringlength = e.Graphics.MeasureString(rightcontent[i], textfont);
                    e.Graphics.DrawString(rightcontent[i], textfont, new SolidBrush(Theme.Disabled), Width - stringlength.Width - 10, septop + 18);
                }

                septop += 51;
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            panelcolor = Theme.ReturnColor(panelcolor);
            RoundedCorners.Paint(e, Width, Height, Rounding, panelcolor);
            panel1.Width = Width;

            //Change the text's fore color to match the state of the Panel
            SolidBrush drawBrush;
            if (Enabled) drawBrush = new SolidBrush(ForeColor);
            else drawBrush = new SolidBrush(Theme.Disabled);

            //Draw text
            e.Graphics.DrawString(icon, font, drawBrush, 12, 21);
            e.Graphics.DrawString(title, panel1.Font, drawBrush, 45, 23);
            e.Graphics.DrawString(expander, new Font(font.Name, 10f), drawBrush, Width - 38, 23);
        }
        #endregion

        #region Hover events
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panelcolor = Color.FromArgb(panelcolor.R + 3, panelcolor.G + 3, panelcolor.B + 3);
            panel1.Invalidate();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panelcolor = Theme.Panel;
            panel1.Invalidate();
        }
        #endregion

        #region Click
        private void Panel1_Click(object sender, EventArgs e)
        {
            if (Enabled)
            {
                Collapsed = !Collapsed;
            }
        }
        #endregion
    }
}
