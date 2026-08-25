namespace statwake
{
    partial class Overlay
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overlay));
            this.NameLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.DeathTitle = new System.Windows.Forms.Label();
            this.DeathLabel = new System.Windows.Forms.Label();
            this.dividerShadowPanel = new System.Windows.Forms.Panel();
            this.labelColorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Block Stock", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.NameLabel.Location = new System.Drawing.Point(353, 12);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 26);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NameLabel_MouseDown);
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Font = new System.Drawing.Font("Block Stock", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.ForeColor = System.Drawing.Color.DimGray;
            this.LevelLabel.Location = new System.Drawing.Point(272, 12);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(0, 26);
            this.LevelLabel.TabIndex = 0;
            this.LevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LevelLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LevelLabel_MouseDown);
            // 
            // DeathTitle
            // 
            this.DeathTitle.AutoSize = true;
            this.DeathTitle.Font = new System.Drawing.Font("Block Stock", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeathTitle.ForeColor = System.Drawing.Color.DimGray;
            this.DeathTitle.Location = new System.Drawing.Point(12, 12);
            this.DeathTitle.Name = "DeathTitle";
            this.DeathTitle.Size = new System.Drawing.Size(138, 26);
            this.DeathTitle.TabIndex = 0;
            this.DeathTitle.Text = "Deaths:";
            this.DeathTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeathTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DeathTitle_MouseDown);
            // 
            // DeathLabel
            // 
            this.DeathLabel.AutoSize = true;
            this.DeathLabel.Font = new System.Drawing.Font("Block Stock", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(80)))), ((int)(((byte)(70)))));
            this.DeathLabel.Location = new System.Drawing.Point(156, 12);
            this.DeathLabel.Name = "DeathLabel";
            this.DeathLabel.Size = new System.Drawing.Size(0, 26);
            this.DeathLabel.TabIndex = 0;
            this.DeathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeathLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DeathLabel_MouseDown);
            // 
            // dividerShadowPanel
            // 
            this.dividerShadowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dividerShadowPanel.Location = new System.Drawing.Point(257, 10);
            this.dividerShadowPanel.Name = "dividerShadowPanel";
            this.dividerShadowPanel.Size = new System.Drawing.Size(1, 31);
            this.dividerShadowPanel.TabIndex = 4;
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(719, 51);
            this.Controls.Add(this.dividerShadowPanel);
            this.Controls.Add(this.DeathTitle);
            this.Controls.Add(this.DeathLabel);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.NameLabel);
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Overlay";
            this.ShowInTaskbar = false;
            this.TransparencyKey = System.Drawing.Color.LimeGreen;
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Overlay_MouseWheel);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label DeathTitle;
        private System.Windows.Forms.Label DeathLabel;
        private System.Windows.Forms.Panel dividerShadowPanel;
        private System.Windows.Forms.ColorDialog labelColorDialog;
    }
}