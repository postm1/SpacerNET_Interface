using System.Drawing;
using System.Windows.Forms;

namespace SpacerUnion.Common
{
    public class DarkToolStripRenderer : ToolStripProfessionalRenderer
    {
        public DarkToolStripRenderer() : base(new DarkColors()) { }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = Theme.FgPrimary;
            base.OnRenderItemText(e);
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            e.ArrowColor = Theme.FgPrimary;
            base.OnRenderArrow(e);
        }

        private class DarkColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected               { get { return Theme.MenuHigh; } }
            public override Color MenuItemBorder                 { get { return Theme.Border; } }
            public override Color MenuItemSelectedGradientBegin  { get { return Theme.MenuHigh; } }
            public override Color MenuItemSelectedGradientEnd    { get { return Theme.MenuHigh; } }
            public override Color MenuItemPressedGradientBegin   { get { return Theme.BgPanel; } }
            public override Color MenuItemPressedGradientEnd     { get { return Theme.BgPanel; } }
            public override Color MenuStripGradientBegin         { get { return Theme.BgPanel; } }
            public override Color MenuStripGradientEnd           { get { return Theme.BgPanel; } }
            public override Color MenuBorder                     { get { return Theme.Border; } }
            public override Color ToolStripBorder                { get { return Theme.Border; } }
            public override Color ToolStripGradientBegin         { get { return Theme.BgPanel; } }
            public override Color ToolStripGradientEnd           { get { return Theme.BgPanel; } }
            public override Color ToolStripGradientMiddle        { get { return Theme.BgPanel; } }
            public override Color ToolStripDropDownBackground    { get { return Theme.BgPanel; } }
            public override Color ImageMarginGradientBegin       { get { return Theme.BgPanel; } }
            public override Color ImageMarginGradientEnd         { get { return Theme.BgPanel; } }
            public override Color ImageMarginGradientMiddle      { get { return Theme.BgPanel; } }
            public override Color SeparatorDark                  { get { return Theme.Border; } }
            public override Color SeparatorLight                 { get { return Theme.Border; } }
            public override Color StatusStripGradientBegin       { get { return Theme.BgPanel; } }
            public override Color StatusStripGradientEnd         { get { return Theme.BgPanel; } }
            public override Color ButtonSelectedHighlight        { get { return Theme.MenuHigh; } }
            public override Color ButtonSelectedHighlightBorder  { get { return Theme.Border; } }
            public override Color ButtonCheckedHighlight         { get { return Theme.MenuHigh; } }
            public override Color CheckBackground                { get { return Theme.MenuHigh; } }
            public override Color CheckSelectedBackground        { get { return Theme.MenuHigh; } }
            public override Color CheckPressedBackground         { get { return Theme.MenuHigh; } }
        }
    }
}
