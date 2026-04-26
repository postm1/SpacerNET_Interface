using System.Collections.Generic;
using System.Windows.Forms;

namespace SpacerUnion.Common
{
    public static class ThemeApplier
    {
        public static void Apply(Form form)
        {
            if (form == null) return;
            ApplyToControl(form);
            ApplyRecursive(form);
            form.Invalidate(true);
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

            if (c is TextBox || c is RichTextBox || c is ComboBox || c is ListBox || c is TreeView || c is DataGridView || c is NumericUpDown)
            {
                c.BackColor = Theme.BgInput;
                c.ForeColor = Theme.FgPrimary;
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

            // Forms, panels, group boxes, labels, checkboxes, radios — generic
            c.BackColor = Theme.BgPanel;
            c.ForeColor = Theme.FgPrimary;
        }
    }
}
