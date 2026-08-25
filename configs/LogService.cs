using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace statwake
{
    /// <summary>
    /// Logging Service
    /// </summary>

    public class LogService
    {
        private readonly RichTextBox _output;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(
            IntPtr hWnd,
            int message,
            IntPtr wParam,
            IntPtr lParam);

        private const int WM_VSCROLL = 0x115;
        private const int SB_BOTTOM = 7;

        public LogService(RichTextBox output)
        {
            _output = output;
        }

        public void Post(
            string message,
            string prompt)
        {
            string formattedMessage =
                $"[ {DateTime.Now.ToLongTimeString()} ][+] " +
                $"{prompt}: {message}\n";

            AppendTypewriter(formattedMessage);
        }

        private void AppendTypewriter(
            string message)
        {
            foreach (char character in message)
            {
                _output.AppendText(
                    character.ToString());

                ScrollToBottom();
            }
        }

        private void ScrollToBottom()
        {
            SendMessage(
                _output.Handle,
                WM_VSCROLL,
                (IntPtr)SB_BOTTOM,
                IntPtr.Zero);
        }
    }
}
