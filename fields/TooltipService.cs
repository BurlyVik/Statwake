using System;
using System.Windows.Forms;

namespace statwake
{
    
    // Tooltip management
    public class TooltipService : IDisposable
    {
        private readonly ToolTip _toolTip;

        public TooltipService()
        {
            _toolTip = new ToolTip();
        }

        public void Show(
            object sender,
            string message,
            int duration)
        {
            if (!(sender is Panel panel))
                return;

            _toolTip.Show(
                message,
                panel,
                panel.Width / 2,
                panel.Height / 2,
                duration);
        }

        public void Dispose()
        {
            _toolTip.Dispose();
        }
    }
}
