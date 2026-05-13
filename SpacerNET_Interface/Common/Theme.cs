using System;
using System.Drawing;

namespace SpacerUnion.Common
{
    public static class Theme
    {
        // Light variants
        private static readonly Color _lBgPanel  = SystemColors.Control;
        private static readonly Color _lBgInput  = SystemColors.Window;
        private static readonly Color _lFgPrim   = SystemColors.ControlText;
        private static readonly Color _lFgMuted  = SystemColors.GrayText;
        private static readonly Color _lAccent   = Color.FromArgb(0, 120, 215);
        private static readonly Color _lBorder   = Color.FromArgb(160, 160, 160);
        private static readonly Color _lMenuHigh = Color.FromArgb(204, 232, 255);

        // Dark variants
        private static readonly Color _dBgPanel  = Color.FromArgb(45, 45, 48);
        private static readonly Color _dBgInput  = Color.FromArgb(30, 30, 30);
        private static readonly Color _dFgPrim   = Color.FromArgb(241, 241, 241);
        private static readonly Color _dFgMuted  = Color.FromArgb(153, 153, 153);
        private static readonly Color _dAccent   = Color.FromArgb(0, 122, 204);
        private static readonly Color _dBorder   = Color.FromArgb(67, 67, 70);
        private static readonly Color _dMenuHigh = Color.FromArgb(62, 62, 64);

        public static Color BgPanel   { get { return IsDark ? _dBgPanel  : _lBgPanel; } }
        public static Color BgInput   { get { return IsDark ? _dBgInput  : _lBgInput; } }
        public static Color FgPrimary { get { return IsDark ? _dFgPrim   : _lFgPrim; } }
        public static Color FgMuted   { get { return IsDark ? _dFgMuted  : _lFgMuted; } }
        public static Color Accent    { get { return IsDark ? _dAccent   : _lAccent; } }
        public static Color Border    { get { return IsDark ? _dBorder   : _lBorder; } }
        public static Color MenuHigh  { get { return IsDark ? _dMenuHigh : _lMenuHigh; } }

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
