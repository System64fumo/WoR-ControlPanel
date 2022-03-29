using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WoRCP.UI
{
    public class RoundedPanel : Panel
    {
        //Main
        #region Variables
        int Rounding = Theme.PanelRounding;
        Color currentcolor = Theme.Panel;
        #endregion

        #region Properties
        [Category("Advanced")]
        public Color color
        {
            get { return currentcolor; }
            set { currentcolor = value; this.Invalidate(); }
        }
        [Category("Advanced")]
        public int rounding
        {
            get { return Rounding; }
            set { Rounding = value; this.Invalidate(); }
        }

        [Browsable(false)]
        public override Font Font { get => base.Font; set => base.Font = value; }
        [Browsable(false)]
        public override Color ForeColor { get => base.ForeColor; set => base.ForeColor = value; }
        [Browsable(false)]
        public override Color BackColor { get => base.BackColor; set => base.BackColor = value; }
        [Browsable(false)]
        public override Image BackgroundImage { get => base.BackgroundImage; set => base.BackgroundImage = value; }
        [Browsable(false)]
        public override ImageLayout BackgroundImageLayout { get => base.BackgroundImageLayout; set => base.BackgroundImageLayout = value; }
        #endregion

        //Events
        #region Paint
        protected override void OnPaint(PaintEventArgs e)
        {
            if (currentcolor == Color.FromArgb(50, 50, 65)) currentcolor = Theme.Accent;
            else if (currentcolor == Color.FromArgb(60, 60, 75)) currentcolor = Theme.BrightAccent;
            else if (currentcolor == Color.FromArgb(40, 40, 55)) currentcolor = Theme.DarkAccent;
            else if (currentcolor == Color.FromArgb(30, 30, 35) || currentcolor == Color.FromArgb(225, 225, 225)) currentcolor = Theme.Inactive;
            else if (currentcolor == Color.FromArgb(20, 20, 20) || currentcolor == Color.FromArgb(243, 243, 243)) currentcolor = Theme.Background;
            else if (currentcolor == Color.FromArgb(25, 25, 27) || currentcolor == Color.FromArgb(251, 251, 251)) currentcolor = Theme.Panel;
            else if (currentcolor == Color.FromArgb(35, 35, 40) || currentcolor == Color.FromArgb(242, 242, 242)) currentcolor = Theme.BrightPanel;
            RoundedCorners.Paint(e, Width, Height, Rounding, currentcolor);
            BackColor = Color.Transparent;
        }
        #endregion
    }
}