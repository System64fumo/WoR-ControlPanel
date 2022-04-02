using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WoRCP.UI
{
    public class WindowUtils
    {
        #region Imports
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);
        [DllImport("user32.dll")]
        private static extern int SetWindowCompositionAttribute(HandleRef hWnd, in WindowCompositionAttributeData data);
        #endregion

        #region Titlebar
        public static void FlipTitlebar(Form form, bool value)
        {
            DwmSetWindowAttribute(form.Handle, 6, new[] { Convert.ToInt32(value) }, 4);
        }
        public static void ChangeTitlebarBackColor(Form form, int r, int g, int b)
        {
            DwmSetWindowAttribute(form.Handle, 35, new[] { r + (g * 256) + (b * 256 * 256) }, 4);
        }
        public static void ChangeTitlebarForeColor(Form form, int r, int g, int b)
        {
            DwmSetWindowAttribute(form.Handle, 36, new[] { r + (g * 256) + (b * 256 * 256) }, 4);
        }
        #endregion

        #region Form
        public static void ChangeAppTheme(Form form, bool value)
        {
            if (DwmSetWindowAttribute(form.Handle, 19, new[] { Convert.ToInt32(value) }, 4) != 0)
            {
                DwmSetWindowAttribute(form.Handle, 20, new[] { Convert.ToInt32(value) }, 4);
            }
        }

        public static void ChangeRounding(Form form, bool value)
        {
            DwmSetWindowAttribute(form.Handle, 33, new[] { Convert.ToInt32(!value) }, 4);
        }

        public static void ChangeBorderColor(Form form, int r, int g, int b)
        {
            DwmSetWindowAttribute(form.Handle, 34, new[] { r + (g * 256) + (b * 256 * 256) }, 4);
        }
        #endregion

        #region Acrylic
        public static void EnableAcrylic(Form window, Control ctrl = null, bool changekey = false)
        {
            Color panelcolor = Color.FromArgb(Theme.WithinRange(ctrl.BackColor.R - 1), Theme.WithinRange(ctrl.BackColor.G - 1), Theme.WithinRange(ctrl.BackColor.B));
            ctrl.BackColor = panelcolor;
            AccentPolicy accentPolicy = new AccentPolicy
            {
                AccentState = Theme.CurrentAccent,
                GradientColor = ToRGBA(Theme.Acryliccolor)
            };
            unsafe
            {
                SetWindowCompositionAttribute(
                    new HandleRef(window, window.Handle),
                    new WindowCompositionAttributeData
                    {
                        Attribute = WCA.ACCENT_POLICY,
                        Data = &accentPolicy,
                        DataLength = Marshal.SizeOf<AccentPolicy>()
                    });
            }
            if (changekey)
            {
                window.TransparencyKey = panelcolor;
            }
        }

        private static uint ToRGBA(Color color)
        {
            return (uint)(color.R + (color.G * 256) + (color.B * 256 * 256) + (color.A * 256 * 256 * 256));
        }

        private unsafe struct WindowCompositionAttributeData
        {
            public WCA Attribute;
            public void* Data;
            public int DataLength;
        }

        private enum WCA { ACCENT_POLICY = 19 }

        public enum ACCENT
        {
            DISABLED = 0,
            ENABLE_GRADIENT = 1,
            ENABLE_TRANSPARENTGRADIENT = 2,
            ENABLE_BLURBEHIND = 3,
            ENABLE_ACRYLICBLURBEHIND = 4,
            INVALID_STATE = 5
        }

        private struct AccentPolicy
        {
            public ACCENT AccentState;
            public uint AccentFlags;
            public uint GradientColor;
            public uint AnimationId;
        }
        #endregion
    }
}
