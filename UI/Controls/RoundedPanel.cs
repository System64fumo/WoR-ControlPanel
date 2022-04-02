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
            currentcolor = Theme.ReturnColor(currentcolor);
            RoundedCorners.Paint(e, Width, Height, Rounding, currentcolor);
            BackColor = Color.Transparent;
        }
        #endregion
    }
}