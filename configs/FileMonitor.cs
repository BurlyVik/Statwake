using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statwake
{
    // File Monitor/Watcher

    public class FileMonitor : IDisposable
    {
        private readonly Timer _timer;
        private readonly Func<Task> _onFileChanged;

        private string _filePath;
        private DateTime _lastWriteTime =
            DateTime.MinValue;

        private bool _isProcessing;

        public FileMonitor(
            int intervalMilliseconds,
            Func<Task> onFileChanged)
        {
            _onFileChanged = onFileChanged;

            _timer = new Timer
            {
                Interval = intervalMilliseconds
            };

            _timer.Tick += Timer_Tick;
        }

        public void Start(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                return;

            if (!File.Exists(filePath))
                return;

            _filePath = filePath;

            _lastWriteTime =
                File.GetLastWriteTime(_filePath);

            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        private async void Timer_Tick(
            object sender,
            EventArgs e)
        {
            if (_isProcessing)
                return;

            if (string.IsNullOrEmpty(_filePath))
                return;

            if (!File.Exists(_filePath))
                return;

            DateTime currentWriteTime =
                File.GetLastWriteTime(_filePath);

            if (currentWriteTime == _lastWriteTime)
                return;

            _isProcessing = true;
            _timer.Stop();

            try
            {
                _lastWriteTime = currentWriteTime;

                if (_onFileChanged != null)
                {
                    await _onFileChanged();
                }

                // Get the newest timestamp after processing.
                if (File.Exists(_filePath))
                {
                    _lastWriteTime =
                        File.GetLastWriteTime(_filePath);
                }
            }
            finally
            {
                _isProcessing = false;
                _timer.Start();
            }
        }

        public void Dispose()
        {
            _timer.Stop();
            _timer.Tick -= Timer_Tick;
            _timer.Dispose();
        }
    }
}
