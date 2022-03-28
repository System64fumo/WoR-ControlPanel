using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WoRCP.UI
{
    public class WindowUtils
    {
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);
        public static void flipTitlebar(Form form, bool value)
        {
            DwmSetWindowAttribute(form.Handle, 6, new[] { Convert.ToInt32(value) }, 4);
        }

        public static void changeAppTheme(Form form, bool value)
        {
            if (DwmSetWindowAttribute(form.Handle, 19, new[] { Convert.ToInt32(value) }, 4) != 0)
                DwmSetWindowAttribute(form.Handle, 20, new[] { Convert.ToInt32(value) }, 4);
        }
        public static void changeRounding(Form form, bool value)
        {
            DwmSetWindowAttribute(form.Handle, 33, new[] { Convert.ToInt32(!value) }, 4);
        }

        public static void changeBorderColor(Form form, int r, int g, int b)
        {
            DwmSetWindowAttribute(form.Handle, 34, new[] { r + (g * 256) + (b * 256 * 256) }, 4);
        }

        public static void changeTitlebarBackColor(Form form, int r, int g, int b)
        {
            DwmSetWindowAttribute(form.Handle, 35, new[] { r + (g * 256) + (b * 256 * 256) }, 4);
        }
        public static void changeTitlebarForeColor(Form form, int r, int g, int b)
        {
            DwmSetWindowAttribute(form.Handle, 36, new[] { r + (g * 256) + (b * 256 * 256) }, 4);
        }
    }
}
