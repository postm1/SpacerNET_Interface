using System.Drawing;
using System.Windows.Forms;

namespace SpacerUnion.Common
{
    public static class ScreenUtils
    {
        public static Point ClampToVisibleScreen(Point loc, Size size)
        {
            var rect = new Rectangle(loc, size);
            foreach (var screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.IntersectsWith(rect)) return loc;
            }
            return new Point(100, 100);
        }
    }
}
