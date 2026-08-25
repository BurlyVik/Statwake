using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using WpfClipboard = System.Windows.Clipboard;

namespace statwake
{
    
    /// <summary>
    /// Texbox control management
    /// </summary>
    public static class TextBoxHelper
    {
        [DllImport(
            "user32.dll",
            CharSet = CharSet.Auto)]
        private static extern bool HideCaret(
            IntPtr hWnd);

        public static void HideCaret(object sender)
        {
            if (sender is TextBox textBox)
            {
                HideCaret(textBox.Handle);
            }
        }

        public static async void CopyText(object sender)
        {
            if (!(sender is TextBox textBox))
                return;

            string originalText = textBox.Text;

            textBox.Parent?.Focus();

            WpfClipboard.SetText(originalText);

            textBox.Text = "Copied!";

            await Task.Delay(2000);

            if (textBox.Text == "Copied!")
            {
                textBox.Text = originalText;
            }
        }
    }
}
