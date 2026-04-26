using System.Collections.Generic;
using System.Windows.Forms;

namespace SpacerUnion.Common
{
    public static class ToolTipManager
    {
        private static readonly ToolTip _tip = new ToolTip
        {
            ShowAlways   = true,
            AutoPopDelay = 10000,
            InitialDelay = 500,
            ReshowDelay  = 100
        };

        private static readonly Dictionary<Control, string> _bindings = new Dictionary<Control, string>();

        public static void Set(Control c, string locKey)
        {
            if (c == null || string.IsNullOrEmpty(locKey)) return;
            _bindings[c] = locKey;
            _tip.SetToolTip(c, Localizator.Get(locKey));
        }

        public static void Clear(Control c)
        {
            if (c == null) return;
            _bindings.Remove(c);
            _tip.SetToolTip(c, string.Empty);
        }

        public static void RetranslateAll()
        {
            foreach (var kv in _bindings)
            {
                _tip.SetToolTip(kv.Key, Localizator.Get(kv.Value));
            }
        }
    }
}
