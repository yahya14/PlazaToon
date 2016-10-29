namespace PlazaToon
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sizeLabel = new System.Windows.Forms.Label();
            this.ModgroupBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.zScaleLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.z2label = new System.Windows.Forms.Label();
            this.yScaleLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.x2ScaleLabel = new System.Windows.Forms.Label();
            this.xScaleLabel = new System.Windows.Forms.Label();
            this.masterLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.masternumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.locnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.locnumericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.locnumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.creditLabel = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // TCPBox
            // 
            this.TCPBox.Controls.Add(this.DisconnButton);
            this.TCPBox.Controls.Add(this.ConnectButton);
            this.TCPBox.Controls.Add(this.IPBox);
            this.TCPBox.Location = new System.Drawing.Point(3, 8);
            this.TCPBox.Name = "TCPBox";
            this.TCPBox.Size = new System.Drawing.Size(398, 48);
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
            this.DisconnButton.Location = new System.Drawing.Point(269, 17);
            this.DisconnButton.Name = "DisconnButton";
            this.DisconnButton.Size = new System.Drawing.Size(120, 23);
            this.DisconnButton.TabIndex = 2;
            this.DisconnButton.Text = "Disconnect";
            this.DisconnButton.UseVisualStyleBackColor = false;
            this.DisconnButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DisconnButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(200)))), ((int)(((byte)(92)))));
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConnectButton.Location = new System.Drawing.Point(131, 17);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(120, 23);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect";
            this.toolTip1.SetToolTip(this.ConnectButton, "* right click to reset all saved values");
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ConnectButton_Click);
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(8, 19);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(115, 20);
            this.IPBox.TabIndex = 0;
            this.IPBox.Text = "192.168.2.4";
            // 
            // NPCcomboBox
            // 
            this.NPCcomboBox.FormattingEnabled = true;
            this.NPCcomboBox.Items.AddRange(new object[] {
            "Callie",
            "Callie\'s Chair",
            "Marie",
            "Marie\'s Chair",
            "Judd",
            "Spyke",
            "Tree"});
            this.NPCcomboBox.Location = new System.Drawing.Point(15, 29);
            this.NPCcomboBox.Name = "NPCcomboBox";
            this.NPCcomboBox.Size = new System.Drawing.Size(141, 21);
            this.NPCcomboBox.TabIndex = 10;
            this.NPCcomboBox.Text = "Callie";
            this.NPCcomboBox.SelectedIndexChanged += new System.EventHandler(this.NPCcomboBox_SelectedIndexChanged);
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
            this.numericUpDown1.Location = new System.Drawing.Point(30, 92);
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
            this.numericUpDown2.Location = new System.Drawing.Point(30, 120);
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
            this.numericUpDown3.Location = new System.Drawing.Point(140, 92);
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
            this.numericUpDown5.Location = new System.Drawing.Point(250, 120);
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
            this.numericUpDown4.Location = new System.Drawing.Point(250, 92);
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
            this.sizeLabel.Location = new System.Drawing.Point(12, 62);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(77, 13);
            this.sizeLabel.TabIndex = 11;
            this.sizeLabel.Text = "Scale Modifier:";
            // 
            // ModgroupBox
            // 
            this.ModgroupBox.Controls.Add(this.label10);
            this.ModgroupBox.Controls.Add(this.zScaleLabel);
            this.ModgroupBox.Controls.Add(this.label9);
            this.ModgroupBox.Controls.Add(this.z2label);
            this.ModgroupBox.Controls.Add(this.yScaleLabel);
            this.ModgroupBox.Controls.Add(this.label);
            this.ModgroupBox.Controls.Add(this.x2ScaleLabel);
            this.ModgroupBox.Controls.Add(this.xScaleLabel);
            this.ModgroupBox.Controls.Add(this.masterLabel);
            this.ModgroupBox.Controls.Add(this.label7);
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
            this.ModgroupBox.Location = new System.Drawing.Point(3, 59);
            this.ModgroupBox.Name = "ModgroupBox";
            this.ModgroupBox.Size = new System.Drawing.Size(398, 245);
            this.ModgroupBox.TabIndex = 8;
            this.ModgroupBox.TabStop = false;
            this.ModgroupBox.Text = "Control";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(290, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "Z";
            // 
            // zScaleLabel
            // 
            this.zScaleLabel.AutoSize = true;
            this.zScaleLabel.BackColor = System.Drawing.SystemColors.Control;
            this.zScaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.zScaleLabel.ForeColor = System.Drawing.Color.Gray;
            this.zScaleLabel.Location = new System.Drawing.Point(290, 78);
            this.zScaleLabel.Name = "zScaleLabel";
            this.zScaleLabel.Size = new System.Drawing.Size(11, 12);
            this.zScaleLabel.TabIndex = 12;
            this.zScaleLabel.Text = "Z";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(180, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "Y";
            // 
            // z2label
            // 
            this.z2label.AutoSize = true;
            this.z2label.BackColor = System.Drawing.SystemColors.Control;
            this.z2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.z2label.ForeColor = System.Drawing.Color.Gray;
            this.z2label.Location = new System.Drawing.Point(290, 142);
            this.z2label.Name = "z2label";
            this.z2label.Size = new System.Drawing.Size(18, 12);
            this.z2label.TabIndex = 12;
            this.z2label.Text = "Z 2";
            // 
            // yScaleLabel
            // 
            this.yScaleLabel.AutoSize = true;
            this.yScaleLabel.BackColor = System.Drawing.SystemColors.Control;
            this.yScaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.yScaleLabel.ForeColor = System.Drawing.Color.Gray;
            this.yScaleLabel.Location = new System.Drawing.Point(180, 78);
            this.yScaleLabel.Name = "yScaleLabel";
            this.yScaleLabel.Size = new System.Drawing.Size(10, 12);
            this.yScaleLabel.TabIndex = 12;
            this.yScaleLabel.Text = "Y";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.Control;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label.ForeColor = System.Drawing.Color.Gray;
            this.label.Location = new System.Drawing.Point(70, 199);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(11, 12);
            this.label.TabIndex = 11;
            this.label.Text = "X";
            // 
            // x2ScaleLabel
            // 
            this.x2ScaleLabel.AutoSize = true;
            this.x2ScaleLabel.BackColor = System.Drawing.SystemColors.Control;
            this.x2ScaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.x2ScaleLabel.ForeColor = System.Drawing.Color.Gray;
            this.x2ScaleLabel.Location = new System.Drawing.Point(70, 142);
            this.x2ScaleLabel.Name = "x2ScaleLabel";
            this.x2ScaleLabel.Size = new System.Drawing.Size(18, 12);
            this.x2ScaleLabel.TabIndex = 11;
            this.x2ScaleLabel.Text = "X 2";
            // 
            // xScaleLabel
            // 
            this.xScaleLabel.AutoSize = true;
            this.xScaleLabel.BackColor = System.Drawing.SystemColors.Control;
            this.xScaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.xScaleLabel.ForeColor = System.Drawing.Color.Gray;
            this.xScaleLabel.Location = new System.Drawing.Point(70, 78);
            this.xScaleLabel.Name = "xScaleLabel";
            this.xScaleLabel.Size = new System.Drawing.Size(11, 12);
            this.xScaleLabel.TabIndex = 11;
            this.xScaleLabel.Text = "X";
            // 
            // masterLabel
            // 
            this.masterLabel.AutoSize = true;
            this.masterLabel.BackColor = System.Drawing.SystemColors.Control;
            this.masterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.masterLabel.ForeColor = System.Drawing.Color.Gray;
            this.masterLabel.Location = new System.Drawing.Point(157, 142);
            this.masterLabel.Name = "masterLabel";
            this.masterLabel.Size = new System.Drawing.Size(60, 12);
            this.masterLabel.TabIndex = 11;
            this.masterLabel.Text = "Master Scale";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Coordinates Modifier:";
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
            this.masternumericUpDown.Location = new System.Drawing.Point(140, 120);
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
            this.locnumericUpDown1.Location = new System.Drawing.Point(30, 213);
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
            this.locnumericUpDown3.Location = new System.Drawing.Point(250, 213);
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
            this.locnumericUpDown2.Location = new System.Drawing.Point(140, 213);
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
            this.creatorLabel.ForeColor = System.Drawing.Color.Gray;
            this.creatorLabel.Location = new System.Drawing.Point(331, 307);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(64, 13);
            this.creatorLabel.TabIndex = 13;
            this.creatorLabel.Text = "By Yahya14";
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.ForeColor = System.Drawing.Color.Gray;
            this.creditLabel.Location = new System.Drawing.Point(0, 307);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(235, 13);
            this.creditLabel.TabIndex = 13;
            this.creditLabel.Text = "Credits to Amibu, Splatonka, and CosmoCortney.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 324);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.creatorLabel);
            this.Controls.Add(this.ModgroupBox);
            this.Controls.Add(this.TCPBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PlazaToon v0.2";
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
        private System.Windows.Forms.ToolTip toolTip1;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.Label creditLabel;
    }
}

