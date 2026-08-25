namespace statwake
{
    partial class Config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.label14 = new System.Windows.Forms.Label();
            this.cmbCharacters = new System.Windows.Forms.ComboBox();
            this.btnShowHide = new System.Windows.Forms.Label();
            this.btnDialogBrowse = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbLevel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDeaths = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTime = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbGlobalOffset = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbBlockOffset = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbByteSize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbBitWidth = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbDataType = new System.Windows.Forms.TextBox();
            this.rtbStatusLog = new System.Windows.Forms.RichTextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSeparator3 = new System.Windows.Forms.Panel();
            this.panelSeparator2 = new System.Windows.Forms.Panel();
            this.panelSeparator1 = new System.Windows.Forms.Panel();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radTicker = new System.Windows.Forms.RadioButton();
            this.radToast = new System.Windows.Forms.RadioButton();
            this.radFloat = new System.Windows.Forms.RadioButton();
            this.radShowHide = new System.Windows.Forms.RadioButton();
            this.btnLogShowHide = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Source Code Pro SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.label14.Location = new System.Drawing.Point(15, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 23);
            this.label14.TabIndex = 11;
            this.label14.Text = "Profiles";
            // 
            // cmbCharacters
            // 
            this.cmbCharacters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.cmbCharacters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCharacters.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.cmbCharacters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.cmbCharacters.FormattingEnabled = true;
            this.cmbCharacters.Location = new System.Drawing.Point(105, 14);
            this.cmbCharacters.Name = "cmbCharacters";
            this.cmbCharacters.Size = new System.Drawing.Size(104, 28);
            this.cmbCharacters.TabIndex = 12;
            this.cmbCharacters.SelectedIndexChanged += new System.EventHandler(this.cmbCharacters_SelectedIndexChanged);
            // 
            // btnShowHide
            // 
            this.btnShowHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.btnShowHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnShowHide.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.btnShowHide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnShowHide.Location = new System.Drawing.Point(19, 589);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(143, 28);
            this.btnShowHide.TabIndex = 6;
            this.btnShowHide.Text = "Enable Overlay";
            this.btnShowHide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            this.btnShowHide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBrowse_MouseDown);
            this.btnShowHide.MouseEnter += new System.EventHandler(this.btnOverlay_MouseEnter);
            this.btnShowHide.MouseLeave += new System.EventHandler(this.btnOverlay_MouseLeave);
            this.btnShowHide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBrowse_MouseUp);
            // 
            // btnDialogBrowse
            // 
            this.btnDialogBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.btnDialogBrowse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnDialogBrowse.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.btnDialogBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnDialogBrowse.Location = new System.Drawing.Point(215, 14);
            this.btnDialogBrowse.Name = "btnDialogBrowse";
            this.btnDialogBrowse.Size = new System.Drawing.Size(85, 28);
            this.btnDialogBrowse.TabIndex = 6;
            this.btnDialogBrowse.Text = "Browse";
            this.btnDialogBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDialogBrowse.Click += new System.EventHandler(this.btnDialogBrowse_Click);
            this.btnDialogBrowse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBrowse_MouseDown);
            this.btnDialogBrowse.MouseEnter += new System.EventHandler(this.btnOverlay_MouseEnter);
            this.btnDialogBrowse.MouseLeave += new System.EventHandler(this.btnOverlay_MouseLeave);
            this.btnDialogBrowse.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBrowse_MouseUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Source Code Pro SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label15.Location = new System.Drawing.Point(15, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 23);
            this.label15.TabIndex = 7;
            this.label15.Text = "Stats";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(140)))));
            this.label12.Location = new System.Drawing.Point(20, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 21);
            this.label12.TabIndex = 8;
            this.label12.Text = "Name:";
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbName.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.txbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.txbName.Location = new System.Drawing.Point(105, 91);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(195, 24);
            this.txbName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(20, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Level:";
            // 
            // txbLevel
            // 
            this.txbLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.txbLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbLevel.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.txbLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.txbLevel.Location = new System.Drawing.Point(105, 121);
            this.txbLevel.Name = "txbLevel";
            this.txbLevel.Size = new System.Drawing.Size(195, 24);
            this.txbLevel.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(140)))));
            this.label4.Location = new System.Drawing.Point(20, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Deaths:";
            // 
            // txbDeaths
            // 
            this.txbDeaths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.txbDeaths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDeaths.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.txbDeaths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.txbDeaths.Location = new System.Drawing.Point(105, 151);
            this.txbDeaths.Name = "txbDeaths";
            this.txbDeaths.Size = new System.Drawing.Size(195, 24);
            this.txbDeaths.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(140)))));
            this.label3.Location = new System.Drawing.Point(20, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time(s):";
            // 
            // txbTime
            // 
            this.txbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.txbTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTime.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.txbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.txbTime.Location = new System.Drawing.Point(105, 181);
            this.txbTime.Name = "txbTime";
            this.txbTime.Size = new System.Drawing.Size(195, 24);
            this.txbTime.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Source Code Pro SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(160)))), ((int)(((byte)(110)))));
            this.label18.Location = new System.Drawing.Point(15, 228);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 23);
            this.label18.TabIndex = 7;
            this.label18.Text = "Parameters";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(140)))));
            this.label7.Location = new System.Drawing.Point(20, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "GlobalOffset:";
            // 
            // txbGlobalOffset
            // 
            this.txbGlobalOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.txbGlobalOffset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbGlobalOffset.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.txbGlobalOffset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.txbGlobalOffset.Location = new System.Drawing.Point(155, 260);
            this.txbGlobalOffset.Name = "txbGlobalOffset";
            this.txbGlobalOffset.Size = new System.Drawing.Size(145, 24);
            this.txbGlobalOffset.TabIndex = 2;
            this.txbGlobalOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbGlobalOffset.Click += new System.EventHandler(this.txbGlobalOffset_Click);
            this.txbGlobalOffset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txbGlobalOffset_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(140)))));
            this.label8.Location = new System.Drawing.Point(20, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "BlockOffset:";
            // 
            // txbBlockOffset
            // 
            this.txbBlockOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.txbBlockOffset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbBlockOffset.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.txbBlockOffset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.txbBlockOffset.Location = new System.Drawing.Point(155, 290);
            this.txbBlockOffset.Name = "txbBlockOffset";
            this.txbBlockOffset.Size = new System.Drawing.Size(145, 24);
            this.txbBlockOffset.TabIndex = 2;
            this.txbBlockOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbBlockOffset.Click += new System.EventHandler(this.txbBlockOffset_Click);
            this.txbBlockOffset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txbBlockOffset_MouseDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(140)))));
            this.label9.Location = new System.Drawing.Point(20, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "ByteSize:";
            // 
            // txbByteSize
            // 
            this.txbByteSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.txbByteSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbByteSize.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.txbByteSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.txbByteSize.Location = new System.Drawing.Point(155, 320);
            this.txbByteSize.Name = "txbByteSize";
            this.txbByteSize.Size = new System.Drawing.Size(145, 24);
            this.txbByteSize.TabIndex = 2;
            this.txbByteSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbByteSize.Click += new System.EventHandler(this.txbByteSize_Click);
            this.txbByteSize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txbByteSize_MouseDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(140)))));
            this.label10.Location = new System.Drawing.Point(20, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "BitWidth:";
            // 
            // txbBitWidth
            // 
            this.txbBitWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.txbBitWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbBitWidth.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.txbBitWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.txbBitWidth.Location = new System.Drawing.Point(155, 350);
            this.txbBitWidth.Name = "txbBitWidth";
            this.txbBitWidth.Size = new System.Drawing.Size(145, 24);
            this.txbBitWidth.TabIndex = 2;
            this.txbBitWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbBitWidth.Click += new System.EventHandler(this.txbBitWidth_Click);
            this.txbBitWidth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txbBitWidth_MouseDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(140)))));
            this.label11.Location = new System.Drawing.Point(20, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "DataType:";
            // 
            // txbDataType
            // 
            this.txbDataType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.txbDataType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDataType.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.txbDataType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.txbDataType.Location = new System.Drawing.Point(155, 380);
            this.txbDataType.Name = "txbDataType";
            this.txbDataType.Size = new System.Drawing.Size(145, 24);
            this.txbDataType.TabIndex = 2;
            this.txbDataType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbDataType.Click += new System.EventHandler(this.txbDataType_Click);
            this.txbDataType.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txbDataType_MouseDown);
            // 
            // rtbStatusLog
            // 
            this.rtbStatusLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(41)))));
            this.rtbStatusLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbStatusLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbStatusLog.Font = new System.Drawing.Font("Source Code Pro", 10F);
            this.rtbStatusLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(190)))), ((int)(((byte)(170)))));
            this.rtbStatusLog.Location = new System.Drawing.Point(0, 0);
            this.rtbStatusLog.Name = "rtbStatusLog";
            this.rtbStatusLog.Size = new System.Drawing.Size(3, 634);
            this.rtbStatusLog.TabIndex = 14;
            this.rtbStatusLog.Text = "";
            this.rtbStatusLog.WordWrap = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.panelMain.Controls.Add(this.rtbStatusLog);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(324, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(3, 634);
            this.panelMain.TabIndex = 19;
            // 
            // panelSeparator3
            // 
            this.panelSeparator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(65)))), ((int)(((byte)(40)))));
            this.panelSeparator3.Location = new System.Drawing.Point(15, 415);
            this.panelSeparator3.Name = "panelSeparator3";
            this.panelSeparator3.Size = new System.Drawing.Size(285, 1);
            this.panelSeparator3.TabIndex = 4;
            // 
            // panelSeparator2
            // 
            this.panelSeparator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(65)))), ((int)(((byte)(40)))));
            this.panelSeparator2.Location = new System.Drawing.Point(15, 218);
            this.panelSeparator2.Name = "panelSeparator2";
            this.panelSeparator2.Size = new System.Drawing.Size(285, 1);
            this.panelSeparator2.TabIndex = 17;
            // 
            // panelSeparator1
            // 
            this.panelSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(65)))), ((int)(((byte)(40)))));
            this.panelSeparator1.Location = new System.Drawing.Point(15, 50);
            this.panelSeparator1.Name = "panelSeparator1";
            this.panelSeparator1.Size = new System.Drawing.Size(285, 1);
            this.panelSeparator1.TabIndex = 18;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(21)))));
            this.panelSidebar.Controls.Add(this.panel3);
            this.panelSidebar.Controls.Add(this.panel2);
            this.panelSidebar.Controls.Add(this.panel4);
            this.panelSidebar.Controls.Add(this.panel1);
            this.panelSidebar.Controls.Add(this.radTicker);
            this.panelSidebar.Controls.Add(this.radToast);
            this.panelSidebar.Controls.Add(this.radFloat);
            this.panelSidebar.Controls.Add(this.radShowHide);
            this.panelSidebar.Controls.Add(this.label14);
            this.panelSidebar.Controls.Add(this.cmbCharacters);
            this.panelSidebar.Controls.Add(this.btnLogShowHide);
            this.panelSidebar.Controls.Add(this.btnShowHide);
            this.panelSidebar.Controls.Add(this.btnDialogBrowse);
            this.panelSidebar.Controls.Add(this.panelSeparator1);
            this.panelSidebar.Controls.Add(this.label1);
            this.panelSidebar.Controls.Add(this.label15);
            this.panelSidebar.Controls.Add(this.label12);
            this.panelSidebar.Controls.Add(this.txbName);
            this.panelSidebar.Controls.Add(this.label2);
            this.panelSidebar.Controls.Add(this.txbLevel);
            this.panelSidebar.Controls.Add(this.label4);
            this.panelSidebar.Controls.Add(this.txbDeaths);
            this.panelSidebar.Controls.Add(this.label3);
            this.panelSidebar.Controls.Add(this.txbTime);
            this.panelSidebar.Controls.Add(this.panelSeparator2);
            this.panelSidebar.Controls.Add(this.label18);
            this.panelSidebar.Controls.Add(this.label7);
            this.panelSidebar.Controls.Add(this.txbGlobalOffset);
            this.panelSidebar.Controls.Add(this.label8);
            this.panelSidebar.Controls.Add(this.txbBlockOffset);
            this.panelSidebar.Controls.Add(this.label9);
            this.panelSidebar.Controls.Add(this.txbByteSize);
            this.panelSidebar.Controls.Add(this.label10);
            this.panelSidebar.Controls.Add(this.txbBitWidth);
            this.panelSidebar.Controls.Add(this.label11);
            this.panelSidebar.Controls.Add(this.txbDataType);
            this.panelSidebar.Controls.Add(this.panelSeparator3);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(324, 634);
            this.panelSidebar.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(280, 553);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 20);
            this.panel3.TabIndex = 20;
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(280, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 20;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(280, 466);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 20);
            this.panel4.TabIndex = 20;
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(280, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 20);
            this.panel1.TabIndex = 20;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // radTicker
            // 
            this.radTicker.AutoSize = true;
            this.radTicker.Enabled = false;
            this.radTicker.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.radTicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(140)))));
            this.radTicker.Location = new System.Drawing.Point(24, 551);
            this.radTicker.Name = "radTicker";
            this.radTicker.Size = new System.Drawing.Size(76, 25);
            this.radTicker.TabIndex = 19;
            this.radTicker.Text = "Ticker";
            this.radTicker.UseVisualStyleBackColor = true;
            // 
            // radToast
            // 
            this.radToast.AutoSize = true;
            this.radToast.Enabled = false;
            this.radToast.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.radToast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(140)))));
            this.radToast.Location = new System.Drawing.Point(24, 522);
            this.radToast.Name = "radToast";
            this.radToast.Size = new System.Drawing.Size(108, 25);
            this.radToast.TabIndex = 19;
            this.radToast.Text = "Toast Only";
            this.radToast.UseVisualStyleBackColor = true;
            // 
            // radFloat
            // 
            this.radFloat.AutoSize = true;
            this.radFloat.Checked = true;
            this.radFloat.Enabled = false;
            this.radFloat.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.radFloat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(140)))));
            this.radFloat.Location = new System.Drawing.Point(24, 464);
            this.radFloat.Name = "radFloat";
            this.radFloat.Size = new System.Drawing.Size(68, 25);
            this.radFloat.TabIndex = 19;
            this.radFloat.TabStop = true;
            this.radFloat.Text = "Float";
            this.radFloat.UseVisualStyleBackColor = true;
            // 
            // radShowHide
            // 
            this.radShowHide.AutoSize = true;
            this.radShowHide.Enabled = false;
            this.radShowHide.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.radShowHide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(140)))));
            this.radShowHide.Location = new System.Drawing.Point(24, 493);
            this.radShowHide.Name = "radShowHide";
            this.radShowHide.Size = new System.Drawing.Size(100, 25);
            this.radShowHide.TabIndex = 19;
            this.radShowHide.Text = "Show/Hide";
            this.radShowHide.UseVisualStyleBackColor = true;
            // 
            // btnLogShowHide
            // 
            this.btnLogShowHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.btnLogShowHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnLogShowHide.Font = new System.Drawing.Font("Source Code Pro SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogShowHide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnLogShowHide.Location = new System.Drawing.Point(183, 589);
            this.btnLogShowHide.Name = "btnLogShowHide";
            this.btnLogShowHide.Size = new System.Drawing.Size(117, 28);
            this.btnLogShowHide.TabIndex = 6;
            this.btnLogShowHide.Text = "Show Log";
            this.btnLogShowHide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogShowHide.Click += new System.EventHandler(this.btnLogShowHide_Click);
            this.btnLogShowHide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBrowse_MouseDown);
            this.btnLogShowHide.MouseEnter += new System.EventHandler(this.btnOverlay_MouseEnter);
            this.btnLogShowHide.MouseLeave += new System.EventHandler(this.btnOverlay_MouseLeave);
            this.btnLogShowHide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBrowse_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Code Pro SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(15, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "LastWrite Display";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(327, 634);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Config";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Statwake";
            this.TopMost = true;
            this.panelMain.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label btnDialogBrowse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbGlobalOffset;
        private System.Windows.Forms.TextBox txbBlockOffset;
        private System.Windows.Forms.TextBox txbByteSize;
        private System.Windows.Forms.TextBox txbBitWidth;
        private System.Windows.Forms.TextBox txbDataType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbCharacters;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbLevel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbDeaths;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label btnShowHide;
        private System.Windows.Forms.RichTextBox rtbStatusLog;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelSeparator3;
        private System.Windows.Forms.Panel panelSeparator2;
        private System.Windows.Forms.Panel panelSeparator1;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.RadioButton radToast;
        private System.Windows.Forms.RadioButton radShowHide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radTicker;
        private System.Windows.Forms.Label btnLogShowHide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radFloat;
    }
}