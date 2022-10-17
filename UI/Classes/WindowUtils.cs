using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WoRCP.UI
{
    public class WindowUtils
    {
        #region Paramater Types
        public class ParameterTypes
        {

            /*[Flags]
            enum DWM_SYSTEMBACKDROP_TYPE
            {
                DWMSBT_MAINWINDOW = 2, // Mica
                DWMSBT_TRANSIENTWINDOW = 3, // Acrylic
                DWMSBT_TABBEDWINDOW = 4 // Tabbed
            }*/


            [Flags]
            public enum DWMWINDOWATTRIBUTE
            {
                DWMWA_NCRENDERING_ENABLED,
                DWMWA_NCRENDERING_POLICY,
                DWMWA_TRANSITIONS_FORCEDISABLED,
                DWMWA_ALLOW_NCPAINT,
                DWMWA_CAPTION_BUTTON_BOUNDS,
                DWMWA_NONCLIENT_RTL_LAYOUT,
                DWMWA_FORCE_ICONIC_REPRESENTATION,
                DWMWA_FLIP3D_POLICY,
                DWMWA_EXTENDED_FRAME_BOUNDS,
                DWMWA_HAS_ICONIC_BITMAP,
                DWMWA_DISALLOW_PEEK,
                DWMWA_EXCLUDED_FROM_PEEK,
                DWMWA_CLOAK,
                DWMWA_CLOAKED,
                DWMWA_FREEZE_REPRESENTATION,
                DWMWA_PASSIVE_UPDATE_MODE,
                DWMWA_USE_HOSTBACKDROPBRUSH,
                DWMWA_USE_IMMERSIVE_DARK_MODE = 20,
                DWMWA_WINDOW_CORNER_PREFERENCE = 33,
                DWMWA_BORDER_COLOR,
                DWMWA_CAPTION_COLOR,
                DWMWA_TEXT_COLOR,
                DWMWA_VISIBLE_FRAME_BORDER_THICKNESS,
                DWMWA_SYSTEMBACKDROP_TYPE,
                DWMWA_LAST
            }

            [StructLayout(LayoutKind.Sequential)]
            public struct MARGINS
            {
                public int cxLeftWidth;      // width of left border that retains its size
                public int cxRightWidth;     // width of right border that retains its size
                public int cyTopHeight;      // height of top border that retains its size
                public int cyBottomHeight;   // height of bottom border that retains its size
            };
        }
        #endregion

        #region Imports

        [DllImport("DwmApi.dll")]
        static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref ParameterTypes.MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        static extern int DwmSetWindowAttribute(IntPtr hwnd, ParameterTypes.DWMWINDOWATTRIBUTE dwAttribute, ref int pvAttribute, int cbAttribute);

        public static int ExtendFrame(IntPtr hwnd, ParameterTypes.MARGINS margins) => DwmExtendFrameIntoClientArea(hwnd, ref margins);

        public static int SetWindowAttribute(IntPtr hwnd, ParameterTypes.DWMWINDOWATTRIBUTE attribute, int parameter)
            => DwmSetWindowAttribute(hwnd, attribute, ref parameter, Marshal.SizeOf<int>());

        [DllImport("user32.dll")]
        private static extern int SetWindowCompositionAttribute(HandleRef hWnd, in WindowCompositionAttributeData data);
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
                window.TransparencyKey = panelcolor;
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
