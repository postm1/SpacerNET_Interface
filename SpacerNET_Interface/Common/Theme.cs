using System;
using System.Drawing;

namespace SpacerUnion.Common
{
    public static class Theme
    {
        public static Color BgPanel   { get { return SystemColors.Control; } }
        public static Color BgInput   { get { return SystemColors.Window; } }
        public static Color FgPrimary { get { return SystemColors.ControlText; } }
        public static Color FgMuted   { get { return SystemColors.GrayText; } }
        public static Color Accent    { get { return Color.FromArgb(0, 120, 215); } }
        public static Color Warning   { get { return Color.FromArgb(220, 130, 0); } }
        public static Color Error     { get { return Color.FromArgb(200, 40, 40); } }

        public static int PaddingS { get { return 4; } }
        public static int PaddingM { get { return 8; } }
        public static int PaddingL { get { return 16; } }

        public static bool IsDark { get; set; }

        public static event Action ThemeChanged;

        public static void RaiseChanged()
        {
            var handler = ThemeChanged;
            if (handler != null) handler();
        }
    }
}
