using Microsoft.Win32;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;


namespace WoRCP.UI
{
    public class Theme
    {
        //TODO: Fix custom theme support
        //Current issue: when you switch from dark mode to light mode or vise versa when using a
        //custom theme it will break the theme

        #region Theme config
        //TODO: Move this to another class
        //TODO: Replace all of this with an array

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
        public static WindowUtils.ACCENT CurrentAccent = WindowUtils.ACCENT.ENABLE_ACRYLICBLURBEHIND;
        private static readonly string Build = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentBuild", null);
        public static Font glyphs = new Font("Segoe MDL2 Assets", 16f);
        public static Font font = new Font("Segoe UI", 9f);
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
                    LoadCustomTheme();
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
                        Text = Color.FromArgb(0, 0, 0);
                    }
                    else //Dark mode
                    {
                        Acryliccolor = Color.FromArgb(175, 0, 0, 0);
                        Inactive = Color.FromArgb(30, 30, 35);
                        Background = Color.FromArgb(20, 20, 20);
                        BrightPanel = Color.FromArgb(35, 35, 40);
                        Panel = Color.FromArgb(25, 25, 27);
                        Text = Color.FromArgb(255, 255, 255);
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
                //Get the background color of the control
                Color bcolor = Color.FromArgb(control.BackColor.R, control.BackColor.G, control.BackColor.B);

                //Get the forecolor of the control
                Color fcolor = Color.FromArgb(control.ForeColor.R, control.ForeColor.G, control.ForeColor.B);

                //Set fore color
                if (fcolor == Color.FromArgb(255, 255, 255) || fcolor == Color.FromArgb(0, 0, 0))
                {
                    control.ForeColor = Text;
                }

                //Set background color
                if (control.BackColor != Color.Transparent)
                {
                    control.BackColor = ReturnColor(bcolor);
                }

                //Check if the control has children
                if (control.HasChildren) { foreach (Control childControl in control.Controls) { Set(childControl); } }
            }
            catch (Exception)
            {

            }
        }
        #endregion

        #region Return correct color
        public static Color ReturnColor(Color color)
        {
/*                  No switches?
            ⠀⣞⢽⢪⢣⢣⢣⢫⡺⡵⣝⡮⣗⢷⢽⢽⢽⣮⡷⡽⣜⣜⢮⢺⣜⢷⢽⢝⡽⣝
            ⠸⡸⠜⠕⠕⠁⢁⢇⢏⢽⢺⣪⡳⡝⣎⣏⢯⢞⡿⣟⣷⣳⢯⡷⣽⢽⢯⣳⣫⠇
            ⠀⠀⢀⢀⢄⢬⢪⡪⡎⣆⡈⠚⠜⠕⠇⠗⠝⢕⢯⢫⣞⣯⣿⣻⡽⣏⢗⣗⠏⠀
            ⠀⠪⡪⡪⣪⢪⢺⢸⢢⢓⢆⢤⢀⠀⠀⠀⠀⠈⢊⢞⡾⣿⡯⣏⢮⠷⠁⠀⠀
            ⠀⠀⠀⠈⠊⠆⡃⠕⢕⢇⢇⢇⢇⢇⢏⢎⢎⢆⢄⠀⢑⣽⣿⢝⠲⠉⠀⠀⠀⠀
            ⠀⠀⠀⠀⠀⡿⠂⠠⠀⡇⢇⠕⢈⣀⠀⠁⠡⠣⡣⡫⣂⣿⠯⢪⠰⠂⠀⠀⠀⠀
            ⠀⠀⠀⠀⡦⡙⡂⢀⢤⢣⠣⡈⣾⡃⠠⠄⠀⡄⢱⣌⣶⢏⢊⠂⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⢝⡲⣜⡮⡏⢎⢌⢂⠙⠢⠐⢀⢘⢵⣽⣿⡿⠁⠁⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠨⣺⡺⡕⡕⡱⡑⡆⡕⡅⡕⡜⡼⢽⡻⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⣼⣳⣫⣾⣵⣗⡵⡱⡡⢣⢑⢕⢜⢕⡝⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⣴⣿⣾⣿⣿⣿⡿⡽⡑⢌⠪⡢⡣⣣⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⡟⡾⣿⢿⢿⢵⣽⣾⣼⣘⢸⢸⣞⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ⠀⠀⠀⠀⠁⠇⠡⠩⡫⢿⣝⡻⡮⣒⢽⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
*/
            Color newcolor = color;
            if (color == Color.FromArgb(50, 50, 65)) newcolor = Accent;
            else if (color == Color.FromArgb(60, 60, 75)) newcolor = BrightAccent;
            else if (color == Color.FromArgb(40, 40, 55)) newcolor = DarkAccent;
            else if (color == Color.FromArgb(30, 30, 35) || color == Color.FromArgb(225, 225, 225)) newcolor = Inactive;
            else if (color == Color.FromArgb(20, 20, 20) || color == Color.FromArgb(243, 243, 243)) newcolor = Background;
            else if (color == Color.FromArgb(25, 25, 27) || color == Color.FromArgb(251, 251, 251)) newcolor = Panel;
            else if (color == Color.FromArgb(35, 35, 40) || color == Color.FromArgb(242, 242, 242)) newcolor = BrightPanel;
            return newcolor;
        }
        #endregion

        #region Initialization
        public static void Initialize(Form mainform, Control acrylicpanel = null)
        {
            Read();
            Set(mainform);
            WindowUtils.ChangeAppTheme(mainform, !ThemeMode);

            //Change icons to match windows 10/11's iconography
            if (Convert.ToInt32(Build) >= 22000) glyphs = new Font("Segoe Fluent Icons", 16f);

            //Check if acrylic is enabled
            if (acrylicpanel != null && Transparency) WindowUtils.EnableAcrylic(mainform, acrylicpanel, true);
        }
        #endregion

        #region Custom theme
        private static void LoadCustomTheme()
        {
            IniFile MyIni = new IniFile(Application.StartupPath + @"\Theme.ini");
            string mode = "DarkMode";
            if (ThemeMode) mode = "LightMode";
            if (MyIni.KeyExists("Acryliccolor", mode))  Acryliccolor = ToColor(MyIni.Read("Acryliccolor", mode));
            if (MyIni.KeyExists("Inactive", mode))      Inactive = ToColor(MyIni.Read("Inactive", mode));
            if (MyIni.KeyExists("Background", mode))    Background = ToColor(MyIni.Read("Background", mode));
            if (MyIni.KeyExists("BrightPanel", mode))   BrightPanel = ToColor(MyIni.Read("BrightPanel", mode));
            if (MyIni.KeyExists("Panel", mode))         Panel = ToColor(MyIni.Read("Panel", mode));
            if (MyIni.KeyExists("Text", mode))          Text = ToColor(MyIni.Read("Text", mode));
        }
        private static Color ToColor(string str)
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

        #region Within range
        public static int WithinRange(int val)
        {
            return Math.Min(255, Math.Max(val, 0));
        }
        #endregion
    }
}
