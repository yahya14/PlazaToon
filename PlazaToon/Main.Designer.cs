namespace PlazaToon
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TCPBox = new System.Windows.Forms.GroupBox();
            this.DisconnButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.NPCcomboBox = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.ModgroupBox = new System.Windows.Forms.GroupBox();
            this.oneandtwoCheckBox = new System.Windows.Forms.CheckBox();
            this.loczLabel = new System.Windows.Forms.Label();
            this.zScaleLabel = new System.Windows.Forms.Label();
            this.locyLabel = new System.Windows.Forms.Label();
            this.z2label = new System.Windows.Forms.Label();
            this.yScaleLabel = new System.Windows.Forms.Label();
            this.locxLabel = new System.Windows.Forms.Label();
            this.x2ScaleLabel = new System.Windows.Forms.Label();
            this.xScaleLabel = new System.Windows.Forms.Label();
            this.masterLabel = new System.Windows.Forms.Label();
            this.coordLabel = new System.Windows.Forms.Label();
            this.masternumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.locnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.locnumericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.locnumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.multiLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rattataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comingSoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msgTimer = new System.Windows.Forms.Timer(this.components);
            this.pokeLocButton = new System.Windows.Forms.Button();
            this.pokeScaleButton = new System.Windows.Forms.Button();
            this.manualGroupBox = new System.Windows.Forms.GroupBox();
            this.pokeBothButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TCPBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.ModgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masternumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locnumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locnumericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locnumericUpDown2)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.manualGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCPBox
            // 
            this.TCPBox.Controls.Add(this.DisconnButton);
            this.TCPBox.Controls.Add(this.ConnectButton);
            this.TCPBox.Controls.Add(this.IPBox);
            this.TCPBox.Location = new System.Drawing.Point(3, 22);
            this.TCPBox.Name = "TCPBox";
            this.TCPBox.Size = new System.Drawing.Size(343, 48);
            this.TCPBox.TabIndex = 6;
            this.TCPBox.TabStop = false;
            this.TCPBox.Text = "TCPGecko Connection";
            // 
            // DisconnButton
            // 
            this.DisconnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DisconnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DisconnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DisconnButton.Location = new System.Drawing.Point(234, 17);
            this.DisconnButton.Name = "DisconnButton";
            this.DisconnButton.Size = new System.Drawing.Size(100, 22);
            this.DisconnButton.TabIndex = 2;
            this.DisconnButton.Text = "Disconnect";
            this.DisconnButton.UseVisualStyleBackColor = false;
            this.DisconnButton.Click += new System.EventHandler(this.DisconnButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(200)))), ((int)(((byte)(92)))));
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConnectButton.Location = new System.Drawing.Point(127, 17);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(100, 22);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(8, 19);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(110, 20);
            this.IPBox.TabIndex = 0;
            this.IPBox.Text = "192.168.2.4";
            this.IPBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IPBox_KeyDown);
            // 
            // NPCcomboBox
            // 
            this.NPCcomboBox.DropDownHeight = 304;
            this.NPCcomboBox.FormattingEnabled = true;
            this.NPCcomboBox.IntegralHeight = false;
            this.NPCcomboBox.Items.AddRange(new object[] {
            "Callie",
            "Callie\'s Chair",
            "Marie",
            "Marie\'s Chair",
            "Judd",
            "Spyke",
            "Sea Snails",
            "Train",
            "Amiibo Box",
            "Balloon",
            "Miiverse Post",
            "Arcade",
            "Manhole",
            "Weapon Sign",
            "Awning",
            "Main TV",
            "Great Zapfish",
            "Tree 1",
            "Tree 2",
            "Tree 3",
            "Tree 4",
            "Bird 1",
            "Bird 2",
            "Bird 3",
            "Bird 4",
            "Bird 5",
            "Dooris (Ammo Knights)",
            "Doory (Cooler Heads)",
            "Doorothy (Jelly Fresh)",
            "Doorian (Shrimp Kicks)",
            "Inkopolis Tower Door",
            "Battle Dojo Doors"});
            this.NPCcomboBox.Location = new System.Drawing.Point(10, 20);
            this.NPCcomboBox.Name = "NPCcomboBox";
            this.NPCcomboBox.Size = new System.Drawing.Size(141, 21);
            this.NPCcomboBox.TabIndex = 10;
            this.NPCcomboBox.Text = "Callie";
            this.NPCcomboBox.SelectedIndexChanged += new System.EventHandler(this.NPCcomboBox_SelectedIndexChanged);
            this.NPCcomboBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NPCcomboBox_MouseUp);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDown1.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(11, 79);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyUp);
            this.numericUpDown1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numericUpDown1_MouseUp);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDown2.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDown2.Location = new System.Drawing.Point(11, 107);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            this.numericUpDown2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown2_KeyUp);
            this.numericUpDown2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numericUpDown2_MouseUp);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDown3.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDown3.Location = new System.Drawing.Point(121, 79);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown3.TabIndex = 5;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            this.numericUpDown3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown3_KeyUp);
            this.numericUpDown3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numericUpDown3_MouseUp);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 2;
            this.numericUpDown5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDown5.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDown5.Location = new System.Drawing.Point(231, 107);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown5.TabIndex = 8;
            this.numericUpDown5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            this.numericUpDown5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown5_KeyUp);
            this.numericUpDown5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numericUpDown5_MouseUp);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 2;
            this.numericUpDown4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDown4.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDown4.Location = new System.Drawing.Point(231, 79);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown4.TabIndex = 9;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            this.numericUpDown4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown4_KeyUp);
            this.numericUpDown4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.numericUpDown4_MouseUp);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(8, 49);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(77, 13);
            this.sizeLabel.TabIndex = 11;
            this.sizeLabel.Text = "Scale Modifier:";
            // 
            // ModgroupBox
            // 
            this.ModgroupBox.Controls.Add(this.oneandtwoCheckBox);
            this.ModgroupBox.Controls.Add(this.loczLabel);
            this.ModgroupBox.Controls.Add(this.zScaleLabel);
            this.ModgroupBox.Controls.Add(this.locyLabel);
            this.ModgroupBox.Controls.Add(this.z2label);
            this.ModgroupBox.Controls.Add(this.yScaleLabel);
            this.ModgroupBox.Controls.Add(this.locxLabel);
            this.ModgroupBox.Controls.Add(this.x2ScaleLabel);
            this.ModgroupBox.Controls.Add(this.xScaleLabel);
            this.ModgroupBox.Controls.Add(this.masterLabel);
            this.ModgroupBox.Controls.Add(this.coordLabel);
            this.ModgroupBox.Controls.Add(this.sizeLabel);
            this.ModgroupBox.Controls.Add(this.NPCcomboBox);
            this.ModgroupBox.Controls.Add(this.numericUpDown4);
            this.ModgroupBox.Controls.Add(this.masternumericUpDown);
            this.ModgroupBox.Controls.Add(this.numericUpDown5);
            this.ModgroupBox.Controls.Add(this.locnumericUpDown1);
            this.ModgroupBox.Controls.Add(this.numericUpDown1);
            this.ModgroupBox.Controls.Add(this.locnumericUpDown3);
            this.ModgroupBox.Controls.Add(this.locnumericUpDown2);
            this.ModgroupBox.Controls.Add(this.numericUpDown3);
            this.ModgroupBox.Controls.Add(this.numericUpDown2);
            this.ModgroupBox.Location = new System.Drawing.Point(3, 71);
            this.ModgroupBox.Name = "ModgroupBox";
            this.ModgroupBox.Size = new System.Drawing.Size(343, 244);
            this.ModgroupBox.TabIndex = 8;
            this.ModgroupBox.TabStop = false;
            this.ModgroupBox.Text = "Control";
            // 
            // oneandtwoCheckBox
            // 
            this.oneandtwoCheckBox.AutoSize = true;
            this.oneandtwoCheckBox.Location = new System.Drawing.Point(11, 144);
            this.oneandtwoCheckBox.Name = "oneandtwoCheckBox";
            this.oneandtwoCheckBox.Size = new System.Drawing.Size(175, 17);
            this.oneandtwoCheckBox.TabIndex = 13;
            this.oneandtwoCheckBox.Text = "Control the two x- and z- as one";
            this.oneandtwoCheckBox.UseVisualStyleBackColor = true;
            // 
            // loczLabel
            // 
            this.loczLabel.AutoSize = true;
            this.loczLabel.BackColor = System.Drawing.SystemColors.Control;
            this.loczLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.loczLabel.ForeColor = System.Drawing.Color.Gray;
            this.loczLabel.Location = new System.Drawing.Point(271, 190);
            this.loczLabel.Name = "loczLabel";
            this.loczLabel.Size = new System.Drawing.Size(11, 12);
            this.loczLabel.TabIndex = 12;
            this.loczLabel.Text = "Z";
            this.loczLabel.Click += new System.EventHandler(this.loczLabel_Click);
            // 
            // zScaleLabel
            // 
            this.zScaleLabel.AutoSize = true;
            this.zScaleLabel.BackColor = System.Drawing.SystemColors.Control;
            this.zScaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.zScaleLabel.ForeColor = System.Drawing.Color.Gray;
            this.zScaleLabel.Location = new System.Drawing.Point(271, 65);
            this.zScaleLabel.Name = "zScaleLabel";
            this.zScaleLabel.Size = new System.Drawing.Size(11, 12);
            this.zScaleLabel.TabIndex = 12;
            this.zScaleLabel.Text = "Z";
            this.zScaleLabel.Click += new System.EventHandler(this.zScaleLabel_Click);
            // 
            // locyLabel
            // 
            this.locyLabel.AutoSize = true;
            this.locyLabel.BackColor = System.Drawing.SystemColors.Control;
            this.locyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.locyLabel.ForeColor = System.Drawing.Color.Gray;
            this.locyLabel.Location = new System.Drawing.Point(161, 190);
            this.locyLabel.Name = "locyLabel";
            this.locyLabel.Size = new System.Drawing.Size(10, 12);
            this.locyLabel.TabIndex = 12;
            this.locyLabel.Text = "Y";
            this.locyLabel.Click += new System.EventHandler(this.locyLabel_Click);
            // 
            // z2label
            // 
            this.z2label.AutoSize = true;
            this.z2label.BackColor = System.Drawing.SystemColors.Control;
            this.z2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.z2label.ForeColor = System.Drawing.Color.Gray;
            this.z2label.Location = new System.Drawing.Point(271, 129);
            this.z2label.Name = "z2label";
            this.z2label.Size = new System.Drawing.Size(18, 12);
            this.z2label.TabIndex = 12;
            this.z2label.Text = "Z 2";
            this.z2label.Click += new System.EventHandler(this.z2label_Click);
            // 
            // yScaleLabel
            // 
            this.yScaleLabel.AutoSize = true;
            this.yScaleLabel.BackColor = System.Drawing.SystemColors.Control;
            this.yScaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.yScaleLabel.ForeColor = System.Drawing.Color.Gray;
            this.yScaleLabel.Location = new System.Drawing.Point(161, 65);
            this.yScaleLabel.Name = "yScaleLabel";
            this.yScaleLabel.Size = new System.Drawing.Size(10, 12);
            this.yScaleLabel.TabIndex = 12;
            this.yScaleLabel.Text = "Y";
            this.yScaleLabel.Click += new System.EventHandler(this.yScaleLabel_Click);
            // 
            // locxLabel
            // 
            this.locxLabel.AutoSize = true;
            this.locxLabel.BackColor = System.Drawing.SystemColors.Control;
            this.locxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.locxLabel.ForeColor = System.Drawing.Color.Gray;
            this.locxLabel.Location = new System.Drawing.Point(51, 190);
            this.locxLabel.Name = "locxLabel";
            this.locxLabel.Size = new System.Drawing.Size(11, 12);
            this.locxLabel.TabIndex = 11;
            this.locxLabel.Text = "X";
            this.locxLabel.Click += new System.EventHandler(this.locxlabel_Click);
            // 
            // x2ScaleLabel
            // 
            this.x2ScaleLabel.AutoSize = true;
            this.x2ScaleLabel.BackColor = System.Drawing.SystemColors.Control;
            this.x2ScaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.x2ScaleLabel.ForeColor = System.Drawing.Color.Gray;
            this.x2ScaleLabel.Location = new System.Drawing.Point(51, 129);
            this.x2ScaleLabel.Name = "x2ScaleLabel";
            this.x2ScaleLabel.Size = new System.Drawing.Size(18, 12);
            this.x2ScaleLabel.TabIndex = 11;
            this.x2ScaleLabel.Text = "X 2";
            this.x2ScaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.x2ScaleLabel.Click += new System.EventHandler(this.x2ScaleLabel_Click);
            // 
            // xScaleLabel
            // 
            this.xScaleLabel.AutoSize = true;
            this.xScaleLabel.BackColor = System.Drawing.SystemColors.Control;
            this.xScaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.xScaleLabel.ForeColor = System.Drawing.Color.Gray;
            this.xScaleLabel.Location = new System.Drawing.Point(51, 65);
            this.xScaleLabel.Name = "xScaleLabel";
            this.xScaleLabel.Size = new System.Drawing.Size(11, 12);
            this.xScaleLabel.TabIndex = 11;
            this.xScaleLabel.Text = "X";
            this.xScaleLabel.Click += new System.EventHandler(this.xScaleLabel_Click);
            // 
            // masterLabel
            // 
            this.masterLabel.AutoSize = true;
            this.masterLabel.BackColor = System.Drawing.SystemColors.Control;
            this.masterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.masterLabel.ForeColor = System.Drawing.Color.Gray;
            this.masterLabel.Location = new System.Drawing.Point(138, 129);
            this.masterLabel.Name = "masterLabel";
            this.masterLabel.Size = new System.Drawing.Size(60, 12);
            this.masterLabel.TabIndex = 11;
            this.masterLabel.Text = "Master Scale";
            this.masterLabel.Click += new System.EventHandler(this.masterLabel_Click);
            // 
            // coordLabel
            // 
            this.coordLabel.AutoSize = true;
            this.coordLabel.Location = new System.Drawing.Point(8, 175);
            this.coordLabel.Name = "coordLabel";
            this.coordLabel.Size = new System.Drawing.Size(106, 13);
            this.coordLabel.TabIndex = 11;
            this.coordLabel.Text = "Coordinates Modifier:";
            // 
            // masternumericUpDown
            // 
            this.masternumericUpDown.DecimalPlaces = 2;
            this.masternumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masternumericUpDown.ForeColor = System.Drawing.Color.Blue;
            this.masternumericUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.masternumericUpDown.Location = new System.Drawing.Point(121, 107);
            this.masternumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.masternumericUpDown.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.masternumericUpDown.Name = "masternumericUpDown";
            this.masternumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.masternumericUpDown.TabIndex = 8;
            this.masternumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.masternumericUpDown.ValueChanged += new System.EventHandler(this.masternumericUpDown_ValueChanged);
            this.masternumericUpDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.masternumericUpDown_KeyUp);
            this.masternumericUpDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.masternumericUpDown_MouseUp);
            // 
            // locnumericUpDown1
            // 
            this.locnumericUpDown1.DecimalPlaces = 4;
            this.locnumericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.locnumericUpDown1.Location = new System.Drawing.Point(11, 204);
            this.locnumericUpDown1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.locnumericUpDown1.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.locnumericUpDown1.Name = "locnumericUpDown1";
            this.locnumericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.locnumericUpDown1.TabIndex = 2;
            this.locnumericUpDown1.Value = new decimal(new int[] {
            2427092,
            0,
            0,
            262144});
            this.locnumericUpDown1.ValueChanged += new System.EventHandler(this.locnumericUpDown1_ValueChanged);
            this.locnumericUpDown1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.locnumericUpDown1_KeyUp);
            this.locnumericUpDown1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.locnumericUpDown1_MouseUp);
            // 
            // locnumericUpDown3
            // 
            this.locnumericUpDown3.DecimalPlaces = 4;
            this.locnumericUpDown3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.locnumericUpDown3.Location = new System.Drawing.Point(231, 204);
            this.locnumericUpDown3.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.locnumericUpDown3.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.locnumericUpDown3.Name = "locnumericUpDown3";
            this.locnumericUpDown3.Size = new System.Drawing.Size(100, 20);
            this.locnumericUpDown3.TabIndex = 5;
            this.locnumericUpDown3.Value = new decimal(new int[] {
            1455591,
            0,
            0,
            -2147221504});
            this.locnumericUpDown3.ValueChanged += new System.EventHandler(this.locnumericUpDown3_ValueChanged);
            this.locnumericUpDown3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.locnumericUpDown3_KeyUp);
            this.locnumericUpDown3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.locnumericUpDown3_MouseUp);
            // 
            // locnumericUpDown2
            // 
            this.locnumericUpDown2.DecimalPlaces = 4;
            this.locnumericUpDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.locnumericUpDown2.Location = new System.Drawing.Point(121, 204);
            this.locnumericUpDown2.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.locnumericUpDown2.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.locnumericUpDown2.Name = "locnumericUpDown2";
            this.locnumericUpDown2.Size = new System.Drawing.Size(100, 20);
            this.locnumericUpDown2.TabIndex = 4;
            this.locnumericUpDown2.Value = new decimal(new int[] {
            66,
            0,
            0,
            0});
            this.locnumericUpDown2.ValueChanged += new System.EventHandler(this.locnumericUpDown2_ValueChanged);
            this.locnumericUpDown2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.locnumericUpDown2_KeyUp);
            this.locnumericUpDown2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.locnumericUpDown2_MouseUp);
            // 
            // creatorLabel
            // 
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.ForeColor = System.Drawing.Color.DimGray;
            this.creatorLabel.Location = new System.Drawing.Point(279, 365);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(64, 13);
            this.creatorLabel.TabIndex = 13;
            this.creatorLabel.Text = "By Yahya14";
            // 
            // multiLabel
            // 
            this.multiLabel.AutoSize = true;
            this.multiLabel.ForeColor = System.Drawing.Color.DimGray;
            this.multiLabel.Location = new System.Drawing.Point(6, 365);
            this.multiLabel.Name = "multiLabel";
            this.multiLabel.Size = new System.Drawing.Size(235, 13);
            this.multiLabel.TabIndex = 13;
            this.multiLabel.Text = "Credits to Amibu, Splatonka, CosmoCortney, etc.";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.autoModeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(351, 24);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "menuStrip";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreAllToolStripMenuItem,
            this.resetAllToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.DropDownClosed += new System.EventHandler(this.optionsToolStripMenuItem_DropDownClosed);
            this.optionsToolStripMenuItem.DropDownOpened += new System.EventHandler(this.optionsToolStripMenuItem_DropDownOpened);
            // 
            // restoreAllToolStripMenuItem
            // 
            this.restoreAllToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.restoreAllToolStripMenuItem.Name = "restoreAllToolStripMenuItem";
            this.restoreAllToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.restoreAllToolStripMenuItem.Text = "Reload All";
            this.restoreAllToolStripMenuItem.ToolTipText = "Reloads all NPC\'s scales and locations (use after loading screens)";
            this.restoreAllToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.resetAllToolStripMenuItem.Text = "Reset All";
            this.resetAllToolStripMenuItem.ToolTipText = "Resets all NPC\'s original scales and locations";
            this.resetAllToolStripMenuItem.Click += new System.EventHandler(this.resetAllToolStripMenuItem_Click);
            // 
            // autoModeToolStripMenuItem
            // 
            this.autoModeToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.autoModeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.autoModeToolStripMenuItem.Name = "autoModeToolStripMenuItem";
            this.autoModeToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.autoModeToolStripMenuItem.Text = "Auto Mode";
            this.autoModeToolStripMenuItem.Click += new System.EventHandler(this.autoModeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rattataToolStripMenuItem,
            this.comingSoonToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.DropDownClosed += new System.EventHandler(this.helpToolStripMenuItem_DropDownClosed);
            this.helpToolStripMenuItem.DropDownOpened += new System.EventHandler(this.helpToolStripMenuItem_DropDownOpened);
            // 
            // rattataToolStripMenuItem
            // 
            this.rattataToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rattataToolStripMenuItem.Name = "rattataToolStripMenuItem";
            this.rattataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rattataToolStripMenuItem.Text = "Visit Github";
            this.rattataToolStripMenuItem.Click += new System.EventHandler(this.rattataToolStripMenuItem_Click);
            // 
            // comingSoonToolStripMenuItem
            // 
            this.comingSoonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comingSoonToolStripMenuItem.Name = "comingSoonToolStripMenuItem";
            this.comingSoonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.comingSoonToolStripMenuItem.Text = "Tips and Tricks";
            this.comingSoonToolStripMenuItem.Click += new System.EventHandler(this.comingSoonToolStripMenuItem_Click);
            // 
            // msgTimer
            // 
            this.msgTimer.Interval = 1005;
            this.msgTimer.Tick += new System.EventHandler(this.msgTimer_Tick);
            // 
            // pokeLocButton
            // 
            this.pokeLocButton.Location = new System.Drawing.Point(204, 17);
            this.pokeLocButton.Name = "pokeLocButton";
            this.pokeLocButton.Size = new System.Drawing.Size(120, 23);
            this.pokeLocButton.TabIndex = 14;
            this.pokeLocButton.Text = "Poke Location";
            this.pokeLocButton.UseVisualStyleBackColor = true;
            this.pokeLocButton.Click += new System.EventHandler(this.pokeLocButton_Click);
            // 
            // pokeScaleButton
            // 
            this.pokeScaleButton.Location = new System.Drawing.Point(17, 17);
            this.pokeScaleButton.Name = "pokeScaleButton";
            this.pokeScaleButton.Size = new System.Drawing.Size(120, 23);
            this.pokeScaleButton.TabIndex = 14;
            this.pokeScaleButton.Text = "Poke Scale";
            this.pokeScaleButton.UseVisualStyleBackColor = true;
            this.pokeScaleButton.Click += new System.EventHandler(this.pokeScaleButton_Click);
            // 
            // manualGroupBox
            // 
            this.manualGroupBox.Controls.Add(this.pokeBothButton);
            this.manualGroupBox.Controls.Add(this.pokeScaleButton);
            this.manualGroupBox.Controls.Add(this.pokeLocButton);
            this.manualGroupBox.Location = new System.Drawing.Point(3, 316);
            this.manualGroupBox.Name = "manualGroupBox";
            this.manualGroupBox.Size = new System.Drawing.Size(343, 48);
            this.manualGroupBox.TabIndex = 17;
            this.manualGroupBox.TabStop = false;
            this.manualGroupBox.Text = "Apply";
            // 
            // pokeBothButton
            // 
            this.pokeBothButton.Location = new System.Drawing.Point(136, 17);
            this.pokeBothButton.Name = "pokeBothButton";
            this.pokeBothButton.Size = new System.Drawing.Size(69, 23);
            this.pokeBothButton.TabIndex = 16;
            this.pokeBothButton.Text = "Both";
            this.pokeBothButton.UseVisualStyleBackColor = true;
            this.pokeBothButton.Click += new System.EventHandler(this.pokeBothButton_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 2000;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 382);
            this.Controls.Add(this.manualGroupBox);
            this.Controls.Add(this.multiLabel);
            this.Controls.Add(this.creatorLabel);
            this.Controls.Add(this.ModgroupBox);
            this.Controls.Add(this.TCPBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "PlazaToon v0.6";
            this.TCPBox.ResumeLayout(false);
            this.TCPBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ModgroupBox.ResumeLayout(false);
            this.ModgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masternumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locnumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locnumericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locnumericUpDown2)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.manualGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TCPBox;
        private System.Windows.Forms.Button DisconnButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.ComboBox NPCcomboBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.GroupBox ModgroupBox;
        private System.Windows.Forms.Label masterLabel;
        private System.Windows.Forms.NumericUpDown locnumericUpDown1;
        private System.Windows.Forms.NumericUpDown locnumericUpDown3;
        private System.Windows.Forms.NumericUpDown locnumericUpDown2;
        private System.Windows.Forms.NumericUpDown masternumericUpDown;
        private System.Windows.Forms.Label zScaleLabel;
        private System.Windows.Forms.Label yScaleLabel;
        private System.Windows.Forms.Label xScaleLabel;
        private System.Windows.Forms.Label z2label;
        private System.Windows.Forms.Label x2ScaleLabel;
        private System.Windows.Forms.Label loczLabel;
        private System.Windows.Forms.Label locyLabel;
        private System.Windows.Forms.Label locxLabel;
        private System.Windows.Forms.Label coordLabel;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.Label multiLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Timer msgTimer;
        private System.Windows.Forms.CheckBox oneandtwoCheckBox;
        private System.Windows.Forms.Button pokeLocButton;
        private System.Windows.Forms.Button pokeScaleButton;
        private System.Windows.Forms.GroupBox manualGroupBox;
        private System.Windows.Forms.Button pokeBothButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem autoModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rattataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comingSoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllToolStripMenuItem;
    }
}

