using Cyotek.Windows.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace statwake
{
    /// <summary>
    /// Handoles pop-up colors, saving and dialog color-wheel.
    /// </summary>
    public static class OverlayColorPickerHelper
    {
        public static void OpenColorPicker(Label label, Form parentForm)
        {
            if (label == null) return;

            using (var form = new Form())
            using (var wheel = new ColorWheel())
            {
                form.FormBorderStyle = FormBorderStyle.None;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowInTaskbar = false;
                form.TopMost = true;

                form.BackColor = Color.Magenta;
                form.TransparencyKey = Color.Magenta;
                form.ClientSize = new Size(260, 260);

                wheel.Dock = DockStyle.Fill;
                wheel.Color = label.ForeColor;
                wheel.BackColor = Color.Magenta;

                form.Controls.Add(wheel);

                bool dragging = false;
                Point dragStart = Point.Empty;
                Point formStart = Point.Empty;

                wheel.MouseDown += (s, args) =>
                {
                    if (args.Button == MouseButtons.Left &&
                        (Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                    {
                        dragging = true;
                        dragStart = Cursor.Position;
                        formStart = form.Location;

                        wheel.Cursor = Cursors.SizeAll;
                    }
                };

                wheel.MouseMove += (s, args) =>
                {
                    if (!dragging)
                        return;

                    Point current = Cursor.Position;

                    int dx = current.X - dragStart.X;
                    int dy = current.Y - dragStart.Y;

                    form.Location = new Point(
                        formStart.X + dx,
                        formStart.Y + dy);
                };

                wheel.MouseUp += (s, args) =>
                {
                    if (args.Button == MouseButtons.Left)
                    {
                        dragging = false;
                        wheel.Cursor = Cursors.Default;
                    }
                };

                wheel.MouseDown += (s, args) =>
                {
                    if (args.Button == MouseButtons.Right)
                    {
                        form.Close();
                    }
                };

                wheel.ColorChanged += (s, args) =>
                {
                    label.ForeColor = wheel.Color;
                };

                form.FormClosed += (s, args) =>
                {
                    OverlaySettingsManager.SaveLabelColor(label);
                };

                form.ShowDialog(parentForm);
            }
        }
    }
}