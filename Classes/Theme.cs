using Microsoft.Win32;
using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WoRCP;

class Theme
{
    #region Theme config
    //Color list                                                      |  Dark Mode  |  Light Mode |
    public static Color Acryliccolor = Color.FromArgb(175, 0,0,0); // | 0 0 0       | 255 255 255 |
    public static Color Accent = Color.FromArgb(50, 50, 65);       // | 50 50 65    | 50 50 65    |
    public static Color BrightAccent = Color.FromArgb(60, 60, 75); // | 60 60 75    | 60 60 75    |
    public static Color DarkAccent = Color.FromArgb(40, 40, 55);   // | 40 40 55    | 40 40 55    |
    public static Color Inactive = Color.FromArgb(30, 30, 35);     // | 225 225 225 | 30 30 35    |
    public static Color Background = Color.FromArgb(20, 20, 20);   // | 250 250 250 | 20 20 20    |
    public static Color Panel = Color.FromArgb(25, 25, 27);        // | 230 230 230 | 25 25 27    |
    public static Color BrightPanel = Color.FromArgb(35, 35, 40);  // | 240 240 240 | 35 35 40    |
    public static Color Text = Color.FromArgb(255, 255, 255);      // | 0 0 0       | 255 255 255 |
    public static Color Disabled = Color.FromArgb(150, 150, 150);  // | 150 150 150 | 150 150 150 |

    public static bool ThemeMode = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", null));
    public static bool Transparency = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "EnableTransparency", null));
    public static Form form;
    public static ACCENT CurrentAccent = ACCENT.ENABLE_ACRYLICBLURBEHIND;

    //Global rounding
    public static int PanelRounding = 5;
    public static int ToggleRounding = 10;
    public static int ButtonRounding = 5;
    public static int SliderBarRounding = 3;

    #endregion

    #region Read theme
    public static void Read()
    {
        //[Read theme]
        if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", null) == null)
        {
            Program.Log("[Error] Unable to read windows Theme");
            MessageBox.Show("Unable to read Windows Theme" + Environment.NewLine + "Reverting to backup Theme", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Show warning
        }
        else
        {
            ThemeMode = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", null));
            if (ThemeMode) //Light Mode
            {
                Acryliccolor = Color.FromArgb(175, 255, 255, 255);
                Background = Color.FromArgb(243, 243, 243);
                Panel = Color.FromArgb(251, 251, 251);
                Text = Color.Black;
                Inactive = Color.FromArgb(225, 225, 225);
                BrightPanel = Color.FromArgb(242, 242, 242);
            }
            else //Dark mode
            {
                Acryliccolor = Color.FromArgb(175, 0, 0, 0);
                Background = Color.FromArgb(20, 20, 20);
                Panel = Color.FromArgb(25, 25, 27);
                Text = Color.White;
                Inactive = Color.FromArgb(30, 30, 35);
                BrightPanel = Color.FromArgb(35, 35, 40);
            }
        }

        //[Read accent]
        if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\DWM", "ColorizationColor", null) == null)
        {
            Program.Log("[Error] Unable to read accent color");
            MessageBox.Show("Unable to read Accent Color" + Environment.NewLine + "Reverting to backup Accent Color", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Show warning
        }
        else
        {
            int regValInt = (int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\DWM", "ColorizationColor", null);
            var regValHex = regValInt.ToString("X");
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
        string color = control.BackColor.ToString().Remove(0, 16).Replace(", G=", ", ").Replace(", B=", ", ").Replace("]", "");

        //Set fore color
        if (control.ForeColor == Color.White || control.ForeColor == Color.Black) { control.ForeColor = Text; }

        //Set background color
        if (color == "50, 50, 65") control.BackColor = Accent;
        else if (color == "60, 60, 75") control.BackColor = BrightAccent;
        else if (color == "40, 40, 55") control.BackColor = DarkAccent;
        else if (color == "30, 30, 35" || color == "225, 225, 225") control.BackColor = Inactive;
        else if (color == "20, 20, 20" || color == "243, 243, 243") control.BackColor = Background;
        else if (color == "25, 25, 27" || color == "251, 251, 251") control.BackColor = Panel;
        else if (color == "35, 35, 40" || color == "242, 242, 242") control.BackColor = BrightPanel;

        //Check if the control is acrylic enabled
        if (control.Tag == "Acrylic") { if (Transparency) EnableAcrylic(form, control); }

        //Check if the control has children
        if (control.HasChildren) { foreach (Control childControl in control.Controls) { Set(childControl); } }
    }
    #endregion

    #region Acrylic
    public static void EnableAcrylic(Form window, Control ctrl = null, bool changekey = false)
    {
        if (window is null) throw new ArgumentNullException(nameof(window));
        Color panelcolor = Color.FromArgb(Math.Min(255, ctrl.BackColor.R - 1), Math.Min(255, ctrl.BackColor.G - 1), ctrl.BackColor.B);
        ctrl.BackColor = panelcolor;
        var accentPolicy = new AccentPolicy
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
    public static void Initialize(Form mainform)
    {
        form = mainform;
        Read();
        Set(form);
        if (!ThemeMode)
        {
            if (DwmSetWindowAttribute(form.Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(form.Handle, 20, new[] { 1 }, 4);
        }
    }
    #endregion
}
