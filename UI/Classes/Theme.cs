using Microsoft.Win32;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace WoRCP.UI
{
    public class Theme
    {
        #region Theme config
        //Color list                                                        |  Dark Mode  |  Light Mode |
        public static Color Acryliccolor = Color.FromArgb(175, 0, 0, 0); // | 0 0 0       | 255 255 255 |
        public static Color Accent = Color.FromArgb(50, 50, 65);         // | 50 50 65    | 50 50 65    |
        public static Color BrightAccent = Color.FromArgb(60, 60, 75);   // | 60 60 75    | 60 60 75    |
        public static Color DarkAccent = Color.FromArgb(40, 40, 55);     // | 40 40 55    | 40 40 55    |
        public static Color Inactive = Color.FromArgb(30, 30, 35);       // | 225 225 225 | 30 30 35    |
        public static Color Background = Color.FromArgb(20, 20, 20);     // | 250 250 250 | 20 20 20    |
        public static Color Panel = Color.FromArgb(25, 25, 27);          // | 230 230 230 | 25 25 27    |
        public static Color BrightPanel = Color.FromArgb(35, 35, 40);    // | 240 240 240 | 35 35 40    |
        public static Color Text = Color.FromArgb(255, 255, 255);        // | 0 0 0       | 255 255 255 |
        public static Color Disabled = Color.FromArgb(150, 150, 150);    // | 150 150 150 | 150 150 150 |

        public static bool ThemeMode = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", null));
        public static bool Transparency = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "EnableTransparency", null));
        public static Form form;
        public static ACCENT CurrentAccent = ACCENT.ENABLE_ACRYLICBLURBEHIND;
        private static string Build = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentBuild", null);
        public static Font glyphs = new Font("Segoe MDL2 Assets", 16f);
        public static bool CustomTheme;

        //Global rounding
        public static byte PanelRounding = 5;
        public static byte ToggleRounding = 10;
        public static byte ButtonRounding = 5;
        public static byte SliderBarRounding = 3;

        #endregion

        #region Read theme
        public static void Read()
        {
            //[Read theme]
            if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", null) == null)
            {

                MessageBox.Show("Unable to read Windows Theme" + Environment.NewLine + "Reverting to backup Theme", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Show warning
            }
            else
            {
                ThemeMode = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", null));

                //Check if a custom theme file exists
                if (File.Exists(Application.StartupPath + @"\Theme.ini"))
                {
                    CustomTheme = true;
                    loadCustomTheme();
                }
                else //Load the stock theme
                {
                    CustomTheme = false;
                    if (ThemeMode) //Light Mode
                    {
                        Acryliccolor = Color.FromArgb(175, 255, 255, 255);
                        Inactive = Color.FromArgb(225, 225, 225);
                        Background = Color.FromArgb(243, 243, 243);
                        BrightPanel = Color.FromArgb(242, 242, 242);
                        Panel = Color.FromArgb(251, 251, 251);
                        Text = Color.Black;
                    }
                    else //Dark mode
                    {
                        Acryliccolor = Color.FromArgb(175, 0, 0, 0);
                        Inactive = Color.FromArgb(30, 30, 35);
                        Background = Color.FromArgb(20, 20, 20);
                        BrightPanel = Color.FromArgb(35, 35, 40);
                        Panel = Color.FromArgb(25, 25, 27);
                        Text = Color.White;
                    }
                }
            }

            //[Read accent]
            if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\DWM", "ColorizationColor", null) == null)
            {
                MessageBox.Show("Unable to read Accent Color" + Environment.NewLine + "Reverting to backup Accent Color", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Show warning
            }
            else
            {
                int regValInt = (int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\DWM", "ColorizationColor", null);
                string regValHex = regValInt.ToString("X");
                string HexColor = regValHex.Remove(0, 2);
                byte r = byte.Parse(HexColor.Substring(0, 2), NumberStyles.AllowHexSpecifier);
                byte g = byte.Parse(HexColor.Substring(2, 2), NumberStyles.AllowHexSpecifier);
                byte b = byte.Parse(HexColor.Substring(4, 2), NumberStyles.AllowHexSpecifier);

                Accent = Color.FromArgb(r, g, b);
                DarkAccent = Color.FromArgb(Math.Max(0, r - 25), Math.Max(0, g - 25), Math.Max(0, b - 25));
                BrightAccent = Color.FromArgb(Math.Min(255, r + 25), Math.Min(255, g + 25), Math.Min(255, b + 25));
            }
        }
        #endregion

        #region Apply theme
        public static void Set(Control control) //This will check if your app contains any of the predefined colors and theme them accordingly
        {
            try
            {
                int r = control.BackColor.R;
                int g = control.BackColor.G;
                int b = control.BackColor.B;
                string color = r + ", " + g + ", " + b;

                //Set fore color
                if (control.ForeColor == Color.White || control.ForeColor == Color.Black) control.ForeColor = Text;

                //Set background color
                if (color == "50, 50, 65") control.BackColor = Accent;
                else if (color == "60, 60, 75") control.BackColor = BrightAccent;
                else if (color == "40, 40, 55") control.BackColor = DarkAccent;
                else if (color == "30, 30, 35" || color == "225, 225, 225") control.BackColor = Inactive;
                else if (color == "20, 20, 20" || color == "243, 243, 243") control.BackColor = Background;
                else if (color == "25, 25, 27" || color == "251, 251, 251") control.BackColor = Panel;
                else if (color == "35, 35, 40" || color == "242, 242, 242") control.BackColor = BrightPanel;

                //Check if the control has children
                if (control.HasChildren) { foreach (Control childControl in control.Controls) { Set(childControl); } }
            }
            catch (Exception)
            {

            }

        }
        #endregion

        #region Acrylic
        public static void EnableAcrylic(Form window, Control ctrl = null, bool changekey = false)
        {
            Color panelcolor = Color.FromArgb(Math.Min(255, ctrl.BackColor.R - 1), Math.Min(255, ctrl.BackColor.G - 1), ctrl.BackColor.B);
            ctrl.BackColor = panelcolor;
            AccentPolicy accentPolicy = new AccentPolicy
            {
                AccentState = CurrentAccent,
                GradientColor = ToRGBA(Acryliccolor)
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
            if (changekey) window.TransparencyKey = panelcolor;
        }

        private static uint ToRGBA(Color color)
        {
            return (uint)(color.R + (color.G * 256) + (color.B * 256 * 256) + (color.A * 256 * 256 * 256));
        }

        [DllImport("user32.dll")]
        private static extern int SetWindowCompositionAttribute(HandleRef hWnd, in WindowCompositionAttributeData data);

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

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

        #region Initialization
        public static void Initialize(Form mainform, Control acrylicpanel = null)
        {
            Read();
            Set(mainform);
            WindowUtils.changeAppTheme(mainform, !ThemeMode);

            //Change icons to match windows 10/11's iconography
            if (Convert.ToInt32(Build) >= 22000) glyphs = new Font("Segoe Fluent Icons", 16f);

            //Check if acrylic is enabled
            if (acrylicpanel != null && Transparency) EnableAcrylic(mainform, acrylicpanel, true);
        }
        #endregion

        #region Custom theme
        private static void loadCustomTheme()
        {
            IniFile MyIni = new IniFile(Application.StartupPath + @"\Theme.ini");
            string mode = "DarkMode";
            if (ThemeMode) mode = "LightMode";

            if (MyIni.KeyExists("Acryliccolor", mode))  Acryliccolor = toColor(MyIni.Read("Acryliccolor", mode));
            if (MyIni.KeyExists("Inactive", mode))      Inactive = toColor(MyIni.Read("Inactive", mode));
            if (MyIni.KeyExists("Background", mode))    Background = toColor(MyIni.Read("Background", mode));
            if (MyIni.KeyExists("BrightPanel", mode))   BrightPanel = toColor(MyIni.Read("BrightPanel", mode));
            if (MyIni.KeyExists("Text", mode))          Text = toColor(MyIni.Read("Text", mode));
        }
        private static Color toColor(string str)
        {
            string[] subs = str.Split(' ');
            byte r = Convert.ToByte(subs[0]);
            byte g = Convert.ToByte(subs[1]);
            byte b = Convert.ToByte(subs[2]);
            byte a = 255;
            if (subs.Length > 3) a = Convert.ToByte(subs[3]);
            return Color.FromArgb(a, r, g, b);
        }
        #endregion
    }
}
