using System;
using System.Drawing;
using System.Windows.Forms;

namespace statwake
{
    // Handles dragging, edge detection, snap indicators, and screen corner snapping
    public class OverlayWindowMover
    {
        private readonly Form targetForm;
        private bool isDragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private const int SnapDistance = 50;
        private int? lineX = null;
        private int? lineY = null;

        public OverlayWindowMover(Form form)
        {
            targetForm = form;
        }

        public void HandleMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = targetForm.Location;
            }
        }

        public void HandleMouseMove(MouseEventArgs e)
        {
            if (isDragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                targetForm.Location = Point.Add(dragFormPoint, new Size(diff));

                Screen currentScreen = Screen.FromControl(targetForm);
                Rectangle workingArea = currentScreen.WorkingArea;

                lineX = null;
                lineY = null;

                int leftDistance = targetForm.Location.X - workingArea.Left;
                if (leftDistance >= 0 && leftDistance < SnapDistance)
                {
                    lineX = leftDistance;
                }
                else
                {
                    int rightDistance = workingArea.Right - (targetForm.Location.X + targetForm.Width);
                    if (rightDistance >= 0 && rightDistance < SnapDistance)
                    {
                        lineX = targetForm.Width - rightDistance;
                    }
                }

                int topDistance = targetForm.Location.Y - workingArea.Top;
                if (topDistance >= 0 && topDistance < SnapDistance)
                {
                    lineY = topDistance;
                }
                else
                {
                    int bottomDistance = workingArea.Bottom - (targetForm.Location.Y + targetForm.Height);
                    if (bottomDistance >= 0 && bottomDistance < SnapDistance)
                    {
                        lineY = targetForm.Height - bottomDistance;
                    }
                }

                targetForm.Invalidate();
            }
        }

        public void HandleMouseUp(MouseEventArgs e)
        {
            if (isDragging)
            {
                isDragging = false;
                lineX = null;
                lineY = null;
                targetForm.Invalidate();

                SnapToCorners();
            }
        }

        public void HandlePaint(PaintEventArgs e)
        {
            using (Pen greenPen = new Pen(Color.FromArgb(46, 204, 113), 3))
            {
                if (lineX.HasValue)
                {
                    e.Graphics.DrawLine(greenPen, lineX.Value, 0, lineX.Value, targetForm.Height);
                }

                if (lineY.HasValue)
                {
                    e.Graphics.DrawLine(greenPen, 0, lineY.Value, targetForm.Width, lineY.Value);
                }
            }
        }

        private void SnapToCorners()
        {
            Screen currentScreen = Screen.FromControl(targetForm);
            Rectangle workingArea = currentScreen.WorkingArea;

            int targetX = targetForm.Location.X;
            int targetY = targetForm.Location.Y;

            if (Math.Abs(targetForm.Location.X - workingArea.Left) < SnapDistance)
            {
                targetX = workingArea.Left;
            }
            else if (Math.Abs((targetForm.Location.X + targetForm.Width) - workingArea.Right) < SnapDistance)
            {
                targetX = workingArea.Right - targetForm.Width;
            }

            if (Math.Abs(targetForm.Location.Y - workingArea.Top) < SnapDistance)
            {
                targetY = workingArea.Top;
            }
            else if (Math.Abs((targetForm.Location.Y + targetForm.Height) - workingArea.Bottom) < SnapDistance)
            {
                targetY = workingArea.Bottom - targetForm.Height;
            }

            targetForm.Location = new Point(targetX, targetY);
        }
    }
}