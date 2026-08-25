using System.Drawing;
using System.Windows.Forms;

namespace statwake
{
    /// <summary>
    /// Control Shtoiling
    /// </summary>

    public static class ControlStyleHelper
    {
        private static readonly Color DefaultBackColor =
            Color.FromArgb(0, 20, 20, 20);

        private static readonly Color DefaultForeColor =
            Color.FromArgb(180, 180, 180);

        private static readonly Color HoverBackColor =
            Color.FromArgb(180, 70, 70);

        private static readonly Color HoverForeColor =
            Color.White;

        private static readonly Color ClickBackColor =
            Color.FromArgb(180, 226, 199, 119);

        private static readonly Color ClickForeColor =
            Color.Black;


        public static void SetHover(
            object sender,
            bool isHovering)
        {
            if (!(sender is Control control))
                return;

            if (isHovering)
            {
                control.BackColor = HoverBackColor;
                control.ForeColor = HoverForeColor;
            }
            else
            {
                SetDefault(control);
            }
        }


        public static void SetClick(
            object sender,
            bool isClicking)
        {
            if (!(sender is Control control))
                return;

            if (isClicking)
            {
                control.BackColor = ClickBackColor;
                control.ForeColor = ClickForeColor;
            }
            else
            {
                SetDefault(control);
            }
        }


        private static void SetDefault(Control control)
        {
            control.BackColor = DefaultBackColor;
            control.ForeColor = DefaultForeColor;
        }
    }
}
