using System.Drawing;
using System.Windows.Forms;

namespace statwake
{

    // The main Overlay Form
    public partial class Overlay : Form
    {
        private readonly OverlayWindowMover windowMover;

        public Overlay()
        {
            InitializeComponent();
            windowMover = new OverlayWindowMover(this);

            SetupOverlayStyle();
            InitializeOverlayLabels();

            OverlaySettingsManager.LoadOverlayColors(NameLabel, LevelLabel, DeathLabel, DeathTitle);
            AdjustFormWidthToFitLabels();
        }

        private void SetupOverlayStyle()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.StartPosition = FormStartPosition.Manual;
            this.Width = 719;
            this.Height = 51;

            this.BackColor = Color.FromArgb(20, 20, 20);
            this.Opacity = 0.85D;
            this.DoubleBuffered = true;

            this.MouseDown += Overlay_MouseDown;
            this.MouseMove += Overlay_MouseMove;
            this.MouseUp += Overlay_MouseUp;
            this.MouseWheel += Overlay_MouseWheel;
            this.Paint += Overlay_Paint;
        }

        private void InitializeOverlayLabels()
        {
            foreach (Control control in new Control[] { NameLabel, LevelLabel, DeathLabel })
            {
                control.MouseDown += Overlay_MouseDown;
                control.MouseMove += Overlay_MouseMove;
                control.MouseUp += Overlay_MouseUp;
                control.MouseWheel += Overlay_MouseWheel;
                this.Controls.Add(control);
            }
        }

        private void Overlay_MouseDown(object sender, MouseEventArgs e) => windowMover.HandleMouseDown(e);
        private void Overlay_MouseMove(object sender, MouseEventArgs e) => windowMover.HandleMouseMove(e);
        private void Overlay_MouseUp(object sender, MouseEventArgs e) => windowMover.HandleMouseUp(e);
        private void Overlay_Paint(object sender, PaintEventArgs e) => windowMover.HandlePaint(e);

        private void Overlay_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                double step = 0.02;
                if (e.Delta > 0)
                {
                    this.Opacity += step;
                }
                else
                {
                    this.Opacity -= step;
                }

                if (this.Opacity < 0.10) this.Opacity = 0.10;
                if (this.Opacity > 1.0) this.Opacity = 1.0;
            }
        }

        public void UpdateStats(string name, string level, string deaths)
        {
            if (NameLabel != null) { NameLabel.Text = name; NameLabel.Invalidate(); }
            if (LevelLabel != null) { LevelLabel.Text = level; LevelLabel.Invalidate(); }
            if (DeathLabel != null) { DeathLabel.Text = deaths; DeathLabel.Invalidate(); }

            AdjustFormWidthToFitLabels();
        }

        public void AdjustFormWidthToFitLabels()
        {
            int rightMost = 0;

            foreach (Control ctrl in new Control[] { DeathTitle, DeathLabel, LevelLabel, NameLabel, dividerShadowPanel })
            {
                if (ctrl != null)
                {
                    int edge = ctrl.Right;
                    if (edge > rightMost)
                    {
                        rightMost = edge;
                    }
                }
            }

            int padding = 20;
            this.Width = rightMost + padding;
        }

        private void DeathTitle_MouseDown(object sender, MouseEventArgs e) => LabelColorPicker(sender, e);
        private void DeathLabel_MouseDown(object sender, MouseEventArgs e) => LabelColorPicker(sender, e);
        private void LevelLabel_MouseDown(object sender, MouseEventArgs e) => LabelColorPicker(sender, e);
        private void NameLabel_MouseDown(object sender, MouseEventArgs e) => LabelColorPicker(sender, e);

        private void LabelColorPicker(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && sender is Label label)
            {
                OverlayColorPickerHelper.OpenColorPicker(label, this);
            }
        }
    }
}