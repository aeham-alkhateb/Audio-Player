namespace mml_audio2
{
    partial class frmAudio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAudio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMnuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMnuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.playMnuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMnuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.editMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeUpRatio = new System.Windows.Forms.ToolStripTextBox();
            this.fasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtSlow = new System.Windows.Forms.ToolStripTextBox();
            this.reverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.mergMnuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.deepMergMnuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.mergRatio = new System.Windows.Forms.ToolStripTextBox();
            this.lstProperties = new System.Windows.Forms.ListView();
            this.colPropertyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPropertyValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.openBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.resumeBtn = new System.Windows.Forms.Button();
            this.reverseBtn = new System.Windows.Forms.Button();
            this.fasterBtn = new System.Windows.Forms.Button();
            this.slowerBtn = new System.Windows.Forms.Button();
            this.vdownBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.vupBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.waveViewer1 = new NAudio.Gui.WaveViewer();
            this.mergAtTimeMnuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.mergTime = new System.Windows.Forms.ToolStripTextBox();
            this.resumBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeDownRatio = new System.Windows.Forms.ToolStripTextBox();
            this.channelMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.leftMnuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.rightMnuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMnu,
            this.ControlMnu,
            this.editMnu,
            this.mergMnu,
            this.channelMnu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(662, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMnu
            // 
            this.fileMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMnuBtn,
            this.saveMnuBtn});
            this.fileMnu.Name = "fileMnu";
            this.fileMnu.Size = new System.Drawing.Size(44, 24);
            this.fileMnu.Text = "&File";
            // 
            // openMnuBtn
            // 
            this.openMnuBtn.Name = "openMnuBtn";
            this.openMnuBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMnuBtn.Size = new System.Drawing.Size(216, 26);
            this.openMnuBtn.Text = "&Open";
            this.openMnuBtn.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveMnuBtn
            // 
            this.saveMnuBtn.Name = "saveMnuBtn";
            this.saveMnuBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMnuBtn.Size = new System.Drawing.Size(216, 26);
            this.saveMnuBtn.Text = "&Save";
            this.saveMnuBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // ControlMnu
            // 
            this.ControlMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playMnuBtn,
            this.stopMnuBtn,
            this.resumBtn});
            this.ControlMnu.Name = "ControlMnu";
            this.ControlMnu.Size = new System.Drawing.Size(70, 24);
            this.ControlMnu.Text = "&Control";
            this.ControlMnu.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // playMnuBtn
            // 
            this.playMnuBtn.Name = "playMnuBtn";
            this.playMnuBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.playMnuBtn.Size = new System.Drawing.Size(216, 26);
            this.playMnuBtn.Text = "&Play";
            this.playMnuBtn.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // stopMnuBtn
            // 
            this.stopMnuBtn.Name = "stopMnuBtn";
            this.stopMnuBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.stopMnuBtn.Size = new System.Drawing.Size(216, 26);
            this.stopMnuBtn.Text = "&Stop";
            this.stopMnuBtn.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // editMnu
            // 
            this.editMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volumeDownToolStripMenuItem,
            this.volumeUpToolStripMenuItem,
            this.fasterToolStripMenuItem,
            this.slowerToolStripMenuItem,
            this.reverseToolStripMenuItem});
            this.editMnu.Name = "editMnu";
            this.editMnu.Size = new System.Drawing.Size(47, 24);
            this.editMnu.Text = "&Edit";
            // 
            // volumeDownToolStripMenuItem
            // 
            this.volumeDownToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volumeDownRatio});
            this.volumeDownToolStripMenuItem.Name = "volumeDownToolStripMenuItem";
            this.volumeDownToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Down)));
            this.volumeDownToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.volumeDownToolStripMenuItem.Text = "Volume &Down";
            this.volumeDownToolStripMenuItem.Click += new System.EventHandler(this.volumeDownToolStripMenuItem_Click);
            // 
            // volumeUpToolStripMenuItem
            // 
            this.volumeUpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volumeUpRatio});
            this.volumeUpToolStripMenuItem.Name = "volumeUpToolStripMenuItem";
            this.volumeUpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Up)));
            this.volumeUpToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.volumeUpToolStripMenuItem.Text = "Volume &Up";
            this.volumeUpToolStripMenuItem.Click += new System.EventHandler(this.volumeUpToolStripMenuItem_Click);
            // 
            // volumeUpRatio
            // 
            this.volumeUpRatio.Name = "volumeUpRatio";
            this.volumeUpRatio.Size = new System.Drawing.Size(100, 27);
            this.volumeUpRatio.Text = "50";
            // 
            // fasterToolStripMenuItem
            // 
            this.fasterToolStripMenuItem.Name = "fasterToolStripMenuItem";
            this.fasterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fasterToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.fasterToolStripMenuItem.Text = "&Faster";
            this.fasterToolStripMenuItem.Click += new System.EventHandler(this.fasterToolStripMenuItem_Click);
            // 
            // slowerToolStripMenuItem
            // 
            this.slowerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtSlow});
            this.slowerToolStripMenuItem.Name = "slowerToolStripMenuItem";
            this.slowerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.slowerToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.slowerToolStripMenuItem.Text = "&Slower";
            this.slowerToolStripMenuItem.Click += new System.EventHandler(this.slowerToolStripMenuItem_Click);
            // 
            // TxtSlow
            // 
            this.TxtSlow.Name = "TxtSlow";
            this.TxtSlow.Size = new System.Drawing.Size(100, 27);
            this.TxtSlow.Text = "2";
            this.TxtSlow.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // reverseToolStripMenuItem
            // 
            this.reverseToolStripMenuItem.Name = "reverseToolStripMenuItem";
            this.reverseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.reverseToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.reverseToolStripMenuItem.Text = "&Reverse";
            this.reverseToolStripMenuItem.Click += new System.EventHandler(this.reverseToolStripMenuItem_Click);
            // 
            // mergMnu
            // 
            this.mergMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mergMnuBtn,
            this.deepMergMnuBtn,
            this.mergAtTimeMnuBtn});
            this.mergMnu.Name = "mergMnu";
            this.mergMnu.Size = new System.Drawing.Size(56, 24);
            this.mergMnu.Text = "&Merg";
            // 
            // mergMnuBtn
            // 
            this.mergMnuBtn.Name = "mergMnuBtn";
            this.mergMnuBtn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.M)));
            this.mergMnuBtn.Size = new System.Drawing.Size(252, 26);
            this.mergMnuBtn.Text = "&Merg";
            this.mergMnuBtn.Click += new System.EventHandler(this.mergToolStripMenuItem1_Click);
            // 
            // deepMergMnuBtn
            // 
            this.deepMergMnuBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mergRatio});
            this.deepMergMnuBtn.Name = "deepMergMnuBtn";
            this.deepMergMnuBtn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D)));
            this.deepMergMnuBtn.Size = new System.Drawing.Size(252, 26);
            this.deepMergMnuBtn.Text = "&Deep Merg";
            this.deepMergMnuBtn.Click += new System.EventHandler(this.deepMergToolStripMenuItem_Click);
            // 
            // mergRatio
            // 
            this.mergRatio.Name = "mergRatio";
            this.mergRatio.Size = new System.Drawing.Size(100, 27);
            this.mergRatio.Text = "2";
            // 
            // lstProperties
            // 
            this.lstProperties.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.lstProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPropertyName,
            this.colPropertyValue});
            this.lstProperties.HideSelection = false;
            this.lstProperties.Location = new System.Drawing.Point(16, 110);
            this.lstProperties.Margin = new System.Windows.Forms.Padding(4);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(633, 250);
            this.lstProperties.TabIndex = 1;
            this.lstProperties.UseCompatibleStateImageBehavior = false;
            this.lstProperties.View = System.Windows.Forms.View.Details;
            this.lstProperties.SelectedIndexChanged += new System.EventHandler(this.lstProperties_SelectedIndexChanged);
            // 
            // colPropertyName
            // 
            this.colPropertyName.Text = "Property";
            this.colPropertyName.Width = 111;
            // 
            // colPropertyValue
            // 
            this.colPropertyValue.Text = "Value";
            this.colPropertyValue.Width = 141;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 490);
            this.hScrollBar1.Maximum = 1000;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(662, 17);
            this.hScrollBar1.TabIndex = 2;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 507);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(662, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 20);
            this.lblStatus.Text = "status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(17, 20);
            this.lblTime.Text = "0";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // openBtn
            // 
            this.openBtn.Image = ((System.Drawing.Image)(resources.GetObject("openBtn.Image")));
            this.openBtn.Location = new System.Drawing.Point(16, 33);
            this.openBtn.Margin = new System.Windows.Forms.Padding(4);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(57, 47);
            this.openBtn.TabIndex = 4;
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Location = new System.Drawing.Point(79, 33);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(53, 47);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // playBtn
            // 
            this.playBtn.Image = ((System.Drawing.Image)(resources.GetObject("playBtn.Image")));
            this.playBtn.Location = new System.Drawing.Point(140, 33);
            this.playBtn.Margin = new System.Windows.Forms.Padding(4);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(52, 49);
            this.playBtn.TabIndex = 6;
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Image = ((System.Drawing.Image)(resources.GetObject("stopBtn.Image")));
            this.stopBtn.Location = new System.Drawing.Point(200, 36);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(48, 47);
            this.stopBtn.TabIndex = 7;
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // resumeBtn
            // 
            this.resumeBtn.Image = ((System.Drawing.Image)(resources.GetObject("resumeBtn.Image")));
            this.resumeBtn.Location = new System.Drawing.Point(253, 33);
            this.resumeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.resumeBtn.Name = "resumeBtn";
            this.resumeBtn.Size = new System.Drawing.Size(53, 53);
            this.resumeBtn.TabIndex = 8;
            this.resumeBtn.UseVisualStyleBackColor = true;
            this.resumeBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // reverseBtn
            // 
            this.reverseBtn.Image = ((System.Drawing.Image)(resources.GetObject("reverseBtn.Image")));
            this.reverseBtn.Location = new System.Drawing.Point(315, 37);
            this.reverseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.reverseBtn.Name = "reverseBtn";
            this.reverseBtn.Size = new System.Drawing.Size(52, 49);
            this.reverseBtn.TabIndex = 9;
            this.reverseBtn.UseVisualStyleBackColor = true;
            this.reverseBtn.Click += new System.EventHandler(this.reverseToolStripMenuItem_Click);
            // 
            // fasterBtn
            // 
            this.fasterBtn.Image = ((System.Drawing.Image)(resources.GetObject("fasterBtn.Image")));
            this.fasterBtn.Location = new System.Drawing.Point(375, 37);
            this.fasterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.fasterBtn.Name = "fasterBtn";
            this.fasterBtn.Size = new System.Drawing.Size(60, 49);
            this.fasterBtn.TabIndex = 10;
            this.fasterBtn.UseVisualStyleBackColor = true;
            this.fasterBtn.Click += new System.EventHandler(this.fasterToolStripMenuItem_Click);
            // 
            // slowerBtn
            // 
            this.slowerBtn.Image = ((System.Drawing.Image)(resources.GetObject("slowerBtn.Image")));
            this.slowerBtn.Location = new System.Drawing.Point(444, 33);
            this.slowerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.slowerBtn.Name = "slowerBtn";
            this.slowerBtn.Size = new System.Drawing.Size(60, 53);
            this.slowerBtn.TabIndex = 11;
            this.slowerBtn.UseVisualStyleBackColor = true;
            this.slowerBtn.Click += new System.EventHandler(this.slowerToolStripMenuItem_Click);
            // 
            // vdownBtn
            // 
            this.vdownBtn.Image = ((System.Drawing.Image)(resources.GetObject("vdownBtn.Image")));
            this.vdownBtn.Location = new System.Drawing.Point(512, 37);
            this.vdownBtn.Margin = new System.Windows.Forms.Padding(4);
            this.vdownBtn.Name = "vdownBtn";
            this.vdownBtn.Size = new System.Drawing.Size(53, 49);
            this.vdownBtn.TabIndex = 12;
            this.vdownBtn.UseVisualStyleBackColor = true;
            this.vdownBtn.Click += new System.EventHandler(this.volumeDownToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "open";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Save";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Play";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Stop";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Resume";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "resever";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "faster";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "slower";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(509, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "volum dw";
            // 
            // vupBtn
            // 
            this.vupBtn.Image = ((System.Drawing.Image)(resources.GetObject("vupBtn.Image")));
            this.vupBtn.Location = new System.Drawing.Point(573, 37);
            this.vupBtn.Margin = new System.Windows.Forms.Padding(4);
            this.vupBtn.Name = "vupBtn";
            this.vupBtn.Size = new System.Drawing.Size(52, 49);
            this.vupBtn.TabIndex = 22;
            this.vupBtn.UseVisualStyleBackColor = true;
            this.vupBtn.Click += new System.EventHandler(this.volumeUpToolStripMenuItem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(583, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "volum up";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // waveViewer1
            // 
            this.waveViewer1.Location = new System.Drawing.Point(20, 368);
            this.waveViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.waveViewer1.Name = "waveViewer1";
            this.waveViewer1.SamplesPerPixel = 128;
            this.waveViewer1.Size = new System.Drawing.Size(629, 112);
            this.waveViewer1.StartPosition = ((long)(0));
            this.waveViewer1.TabIndex = 24;
            this.waveViewer1.WaveStream = null;
            this.waveViewer1.Load += new System.EventHandler(this.waveViewer1_Load);
            // 
            // mergAtTimeMnuBtn
            // 
            this.mergAtTimeMnuBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mergTime});
            this.mergAtTimeMnuBtn.Name = "mergAtTimeMnuBtn";
            this.mergAtTimeMnuBtn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
            this.mergAtTimeMnuBtn.Size = new System.Drawing.Size(252, 26);
            this.mergAtTimeMnuBtn.Text = "Merg at &Time";
            this.mergAtTimeMnuBtn.Click += new System.EventHandler(this.mergAtTimeBtn_Click);
            // 
            // mergTime
            // 
            this.mergTime.Name = "mergTime";
            this.mergTime.Size = new System.Drawing.Size(100, 27);
            this.mergTime.Text = "1";
            // 
            // resumBtn
            // 
            this.resumBtn.Name = "resumBtn";
            this.resumBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.resumBtn.Size = new System.Drawing.Size(216, 26);
            this.resumBtn.Text = "&Resum";
            this.resumBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // volumeDownRatio
            // 
            this.volumeDownRatio.Name = "volumeDownRatio";
            this.volumeDownRatio.Size = new System.Drawing.Size(100, 27);
            this.volumeDownRatio.Text = "20";
            // 
            // channelMnu
            // 
            this.channelMnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftMnuBtn,
            this.rightMnuBtn});
            this.channelMnu.Name = "channelMnu";
            this.channelMnu.Size = new System.Drawing.Size(74, 24);
            this.channelMnu.Text = "&Channel";
            this.channelMnu.Click += new System.EventHandler(this.channelToolStripMenuItem_Click);
            // 
            // leftMnuBtn
            // 
            this.leftMnuBtn.Name = "leftMnuBtn";
            this.leftMnuBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
            this.leftMnuBtn.Size = new System.Drawing.Size(216, 26);
            this.leftMnuBtn.Text = "&Left";
            this.leftMnuBtn.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
            // 
            // rightMnuBtn
            // 
            this.rightMnuBtn.Name = "rightMnuBtn";
            this.rightMnuBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Right)));
            this.rightMnuBtn.Size = new System.Drawing.Size(216, 26);
            this.rightMnuBtn.Text = "&Right";
            this.rightMnuBtn.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // frmAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 532);
            this.Controls.Add(this.waveViewer1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.vupBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vdownBtn);
            this.Controls.Add(this.slowerBtn);
            this.Controls.Add(this.fasterBtn);
            this.Controls.Add(this.reverseBtn);
            this.Controls.Add(this.resumeBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.lstProperties);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAudio";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMnu;
        private System.Windows.Forms.ToolStripMenuItem openMnuBtn;
        private System.Windows.Forms.ListView lstProperties;
        private System.Windows.Forms.ColumnHeader colPropertyName;
        private System.Windows.Forms.ColumnHeader colPropertyValue;
        private System.Windows.Forms.ToolStripMenuItem ControlMnu;
        private System.Windows.Forms.ToolStripMenuItem playMnuBtn;
        private System.Windows.Forms.ToolStripMenuItem stopMnuBtn;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.ToolStripMenuItem editMnu;
        private System.Windows.Forms.ToolStripMenuItem volumeDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox TxtSlow;
        private System.Windows.Forms.ToolStripMenuItem mergMnu;
        private System.Windows.Forms.ToolStripMenuItem mergMnuBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button resumeBtn;
        private System.Windows.Forms.Button reverseBtn;
        private System.Windows.Forms.Button fasterBtn;
        private System.Windows.Forms.Button slowerBtn;
        private System.Windows.Forms.Button vdownBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button vupBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem saveMnuBtn;
        private System.Windows.Forms.ToolStripMenuItem deepMergMnuBtn;
        private System.Windows.Forms.ToolStripTextBox mergRatio;
        private NAudio.Gui.WaveViewer waveViewer1;
        private System.Windows.Forms.ToolStripTextBox volumeUpRatio;
        private System.Windows.Forms.ToolStripMenuItem mergAtTimeMnuBtn;
        private System.Windows.Forms.ToolStripTextBox mergTime;
        private System.Windows.Forms.ToolStripMenuItem resumBtn;
        private System.Windows.Forms.ToolStripTextBox volumeDownRatio;
        private System.Windows.Forms.ToolStripMenuItem channelMnu;
        private System.Windows.Forms.ToolStripMenuItem leftMnuBtn;
        private System.Windows.Forms.ToolStripMenuItem rightMnuBtn;
    }
}

