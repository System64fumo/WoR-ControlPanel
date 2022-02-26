using Microsoft.Win32;
using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WoRCP;

class Theme
{
    #region Colors
    public static Color Acryliccolor = Color.FromArgb(175, 10, 10, 10);
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
            if (ThemeMode)
            {
                //Light theme
                Background = Color.FromArgb(243, 243, 243);
                Panel = Color.FromArgb(251, 251, 251);
                Text = Color.FromArgb(0, 0, 0);
                Inactive = Color.FromArgb(225, 225, 225);
                BrightPanel = Color.FromArgb(242, 242, 242);
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
        if (control.ForeColor == Color.White) { control.ForeColor = Text; }
        string color = control.BackColor.ToString().Remove(0, 16).Replace(", G=", ", ").Replace(", B=", ", ").Replace("]", "");
        switch (color)
        {
            case "50, 50, 65":
                control.BackColor = Accent;
                break;
            case "60, 60, 75":
                control.BackColor = BrightAccent;
                break;
            case "40, 40, 55":
                control.BackColor = DarkAccent;
                break;
            case "30, 30, 35":
                control.BackColor = Inactive;
                break;
            case "20, 20, 20":
                control.BackColor = Background;
                break;
            case "25, 25, 27":
                control.BackColor = Panel;
                break;
            case "35, 35, 40":
                control.BackColor = BrightPanel;
                break;
        }
        if (control.Tag == "Acrylic") { if (Transparency) EnableAcrylic(form, control); }
        if (control.HasChildren) { foreach (Control childControl in control.Controls) { Theme.Set(childControl); } }
    }
    #endregion

    #region Acrylic
    public static void EnableAcrylic(Form window, Control ctrl = null)
    {
        uint gradient;
        if (window is null) throw new ArgumentNullException(nameof(window));
        if (ThemeMode) { Acryliccolor = Color.FromArgb(180, 255, 255, 255); }
        gradient = ToAbgr(Acryliccolor);
        Color panelcolor = Color.FromArgb(Math.Min(255, ctrl.BackColor.R - 1), Math.Min(255, ctrl.BackColor.G - 1), ctrl.BackColor.B); ;
        window.TransparencyKey = panelcolor;
        ctrl.BackColor = panelcolor;
        var accentPolicy = new AccentPolicy
        {
            AccentState = ACCENT.ENABLE_ACRYLICBLURBEHIND,
            GradientColor = gradient
        };
        unsafe
        {
            SetWindowCompositionAttribute(
                new HandleRef(window, window.Handle),
                new WindowCompositionAttributeData
                {
                    Attribute = WCA.ACCENT_POLICY,
                    Data = & accentPolicy,
                    DataLength = Marshal.SizeOf<AccentPolicy>()
                });
        }
    }

    private static uint ToAbgr(Color color)
    {
        return ((uint)color.A << 24)
            | ((uint)color.B << 16)
            | ((uint)color.G << 8)
            | color.R;
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
