using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SpacerUnion.Common
{
    public static class ThemeApplier
    {
        private static readonly HashSet<GroupBox> _gbHandlers = new HashSet<GroupBox>();
        private static readonly HashSet<TabControl> _tabHandlers = new HashSet<TabControl>();
        private static readonly HashSet<Form> _shownHooks = new HashSet<Form>();

        [DllImport("dwmapi.dll", PreserveSig = true)]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode, PreserveSig = true)]
        private static extern int SetWindowTheme(IntPtr hwnd, string subAppName, string subIdList);
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_LEGACY = 19;

        private static void TryDarkenNative(Control c)
        {
            if (!c.IsHandleCreated) return;
            try { SetWindowTheme(c.Handle, Theme.IsDark ? "DarkMode_Explorer" : null, null); }
            catch { }
        }

        public static void Apply(Form form)
        {
            if (form == null) return;
            ApplyToControl(form);
            ApplyRecursive(form);
            form.Invalidate(true);
            TryApplyTitleBar(form);
            HookShownReapply(form);
        }

        private static void TryApplyTitleBar(Form form)
        {
            if (form.IsHandleCreated && form.Visible)
            {
                SetTitleBarDark(form);
                return;
            }
            // Shown hook handles this too via HookShownReapply
        }

        private static void HookShownReapply(Form form)
        {
            if (_shownHooks.Contains(form)) return;
            _shownHooks.Add(form);
            form.Shown += (s, e) =>
            {
                try
                {
                    var f = (Form)s;
                    SetTitleBarDark(f);
                    // Re-apply controls — some forms reset BackColor or only realize handles in their own Show flow
                    ApplyToControl(f);
                    ApplyRecursive(f);
                    f.Invalidate(true);
                }
                catch { }
            };
        }

        private static void SetTitleBarDark(Form form)
        {
            int dark = Theme.IsDark ? 1 : 0;
            try
            {
                if (DwmSetWindowAttribute(form.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref dark, sizeof(int)) != 0)
                    DwmSetWindowAttribute(form.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE_LEGACY, ref dark, sizeof(int));
            }
            catch
            {
                // Pre-Win10-1809 or DWM disabled — caption stays light, no harm
            }
        }

        public static void ApplyAll(IEnumerable<Form> forms)
        {
            if (forms == null) return;
            foreach (var f in forms)
            {
                if (f != null) Apply(f);
            }
        }

        private static void ApplyRecursive(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                ApplyToControl(c);
                if (c.HasChildren) ApplyRecursive(c);
            }
        }

        private static void ApplyToControl(Control c)
        {
            if (c == null) return;

            if (c is TextBox)
            {
                var t = (TextBox)c;
                t.BackColor = Theme.BgInput;
                t.ForeColor = Theme.FgPrimary;
                t.BorderStyle = Theme.IsDark ? BorderStyle.FixedSingle : BorderStyle.Fixed3D;
                TryDarkenNative(t);
                return;
            }

            if (c is RichTextBox)
            {
                var rt = (RichTextBox)c;
                rt.BackColor = Theme.BgInput;
                rt.ForeColor = Theme.FgPrimary;
                rt.BorderStyle = Theme.IsDark ? BorderStyle.FixedSingle : BorderStyle.Fixed3D;
                TryDarkenNative(rt);
                return;
            }

            if (c is ListBox)
            {
                var lb = (ListBox)c;
                lb.BackColor = Theme.BgInput;
                lb.ForeColor = Theme.FgPrimary;
                lb.BorderStyle = Theme.IsDark ? BorderStyle.FixedSingle : BorderStyle.Fixed3D;
                TryDarkenNative(lb);
                return;
            }

            if (c is TreeView)
            {
                var tv = (TreeView)c;
                tv.BackColor = Theme.BgInput;
                tv.ForeColor = Theme.FgPrimary;
                tv.BorderStyle = Theme.IsDark ? BorderStyle.FixedSingle : BorderStyle.Fixed3D;
                TryDarkenNative(tv);
                return;
            }

            if (c is ListView)
            {
                var lv = (ListView)c;
                lv.BackColor = Theme.BgInput;
                lv.ForeColor = Theme.FgPrimary;
                TryDarkenNative(lv);
                return;
            }

            if (c is ComboBox)
            {
                var cb = (ComboBox)c;
                cb.BackColor = Theme.BgInput;
                cb.ForeColor = Theme.FgPrimary;
                cb.FlatStyle = Theme.IsDark ? FlatStyle.Flat : FlatStyle.Standard;
                TryDarkenNative(cb);
                return;
            }

            if (c is DataGridView || c is NumericUpDown)
            {
                c.BackColor = Theme.BgInput;
                c.ForeColor = Theme.FgPrimary;
                TryDarkenNative(c);
                return;
            }

            if (c is Button)
            {
                var b = (Button)c;
                b.BackColor = Theme.BgPanel;
                b.ForeColor = Theme.FgPrimary;
                b.UseVisualStyleBackColor = !Theme.IsDark;
                if (Theme.IsDark)
                {
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderColor = Theme.Border;
                }
                else
                {
                    b.FlatStyle = FlatStyle.Standard;
                }
                return;
            }

            if (c is MenuStrip || c is ToolStrip || c is StatusStrip)
            {
                var ts = (ToolStrip)c;
                ts.BackColor = Theme.BgPanel;
                ts.ForeColor = Theme.FgPrimary;
                ts.Renderer = Theme.IsDark
                    ? (ToolStripRenderer)new DarkToolStripRenderer()
                    : new ToolStripProfessionalRenderer();
                return;
            }

            if (c is GroupBox)
            {
                var gb = (GroupBox)c;
                gb.BackColor = Theme.BgPanel;
                gb.ForeColor = Theme.FgPrimary;
                if (!_gbHandlers.Contains(gb))
                {
                    gb.Paint += GroupBox_Paint;
                    _gbHandlers.Add(gb);
                }
                gb.Invalidate();
                return;
            }

            if (c is TabControl)
            {
                var tc = (TabControl)c;
                tc.BackColor = Theme.BgPanel;
                tc.ForeColor = Theme.FgPrimary;
                if (!_tabHandlers.Contains(tc))
                {
                    tc.DrawMode = TabDrawMode.Normal;
                    tc.Paint += TabControl_Paint;
                    _tabHandlers.Add(tc);
                }
                tc.Invalidate();
                return;
            }

            // Forms, panels, labels, checkboxes, radios — generic
            c.BackColor = Theme.BgPanel;
            c.ForeColor = Theme.FgPrimary;
        }

        private static void GroupBox_Paint(object sender, PaintEventArgs e)
        {
            if (!Theme.IsDark) return;

            var gb = (GroupBox)sender;
            var g = e.Graphics;

            using (var bg = new SolidBrush(gb.BackColor))
            {
                g.FillRectangle(bg, gb.ClientRectangle);
            }

            var textSize = string.IsNullOrEmpty(gb.Text)
                ? Size.Empty
                : g.MeasureString(gb.Text, gb.Font).ToSize();
            int top = textSize.Height / 2;

            var border = new Rectangle(0, top, gb.Width - 1, gb.Height - top - 1);
            using (var pen = new Pen(Theme.Border))
            {
                g.DrawRectangle(pen, border);
            }

            if (!string.IsNullOrEmpty(gb.Text))
            {
                var textRect = new Rectangle(8, 0, textSize.Width, textSize.Height);
                using (var bg = new SolidBrush(gb.BackColor))
                {
                    g.FillRectangle(bg, textRect);
                }
                using (var fg = new SolidBrush(gb.ForeColor))
                {
                    g.DrawString(gb.Text, gb.Font, fg, 8, 0);
                }
            }
        }

        private static void TabControl_Paint(object sender, PaintEventArgs e)
        {
            if (!Theme.IsDark) return;  // light mode: let WinForms draw with visual styles

            var tc = (TabControl)sender;
            var g = e.Graphics;

            // 1. Fill the tab strip background (the strip behind/between tab headers, plus margins around the page area)
            using (var bg = new SolidBrush(Theme.BgPanel))
            {
                g.FillRectangle(bg, tc.ClientRectangle);
            }

            // 2. Draw each tab header on top
            for (int i = 0; i < tc.TabCount; i++)
            {
                var rect = tc.GetTabRect(i);
                var page = tc.TabPages[i];
                var headerBg = i == tc.SelectedIndex ? Theme.MenuHigh : Theme.BgPanel;

                using (var bg = new SolidBrush(headerBg))
                    g.FillRectangle(bg, rect);
                using (var pen = new Pen(Theme.Border))
                    g.DrawRectangle(pen, rect.X, rect.Y, rect.Width - 1, rect.Height - 1);
                using (var fg = new SolidBrush(Theme.FgPrimary))
                {
                    var size = g.MeasureString(page.Text, tc.Font);
                    g.DrawString(page.Text, tc.Font, fg,
                        rect.Left + (rect.Width - size.Width) / 2,
                        rect.Top + (rect.Height - size.Height) / 2);
                }
            }

            // 3. Border around the displayed TabPage area
            if (tc.TabCount > 0 && tc.SelectedIndex >= 0)
            {
                var pageRect = tc.GetTabRect(tc.SelectedIndex);
                var contentTop = pageRect.Bottom;
                var contentRect = new Rectangle(0, contentTop, tc.Width - 1, tc.Height - contentTop - 1);
                using (var pen = new Pen(Theme.Border))
                    g.DrawRectangle(pen, contentRect);
            }
        }
    }
}
