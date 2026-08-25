using System;

namespace statwake
{
    /// <summary>
    /// Overlay Management
    /// </summary>

    public class OverlayManager : IDisposable
    {
        private Overlay _overlay;

        public bool IsVisible
        {
            get
            {
                return _overlay != null &&
                       !_overlay.IsDisposed;
            }
        }

        public void Show(
            string name,
            string level,
            string deaths)
        {
            if (IsVisible)
            {
                UpdateStats(name, level, deaths);
                return;
            }

            _overlay = new Overlay();

            UpdateStats(
                name,
                level,
                deaths);

            _overlay.Show();
        }

        public void Hide()
        {
            if (!IsVisible)
                return;

            _overlay.Close();
            _overlay = null;
        }

        public void UpdateStats(
            string name,
            string level,
            string deaths)
        {
            if (!IsVisible)
                return;

            _overlay.UpdateStats(
                name,
                level,
                deaths);
        }

        public void Dispose()
        {
            Hide();
        }
    }
}
