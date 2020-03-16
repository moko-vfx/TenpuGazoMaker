namespace WindowsFormsApp1
{
	partial class FormSettings
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
			this.pnlLeft = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbFrameColerR = new System.Windows.Forms.TextBox();
			this.tbFrameColerG = new System.Windows.Forms.TextBox();
			this.tbFrameColerB = new System.Windows.Forms.TextBox();
			this.tbLineColerR = new System.Windows.Forms.TextBox();
			this.tbLineColerG = new System.Windows.Forms.TextBox();
			this.tbLineColerB = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnOpenFolderDiag = new System.Windows.Forms.Button();
			this.tbOutputPath = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbLineBorder = new System.Windows.Forms.NumericUpDown();
			this.tbFrameBorder = new System.Windows.Forms.NumericUpDown();
			this.tbCaptureSizeY = new System.Windows.Forms.NumericUpDown();
			this.tbCaptureSizeX = new System.Windows.Forms.NumericUpDown();
			this.cbArrow = new System.Windows.Forms.CheckBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pnlTop = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.rbEN = new System.Windows.Forms.RadioButton();
			this.rbJP = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbLineBorder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbFrameBorder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbCaptureSizeY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbCaptureSizeX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.pnlTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlLeft
			// 
			this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
			this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlLeft.Location = new System.Drawing.Point(0, 20);
			this.pnlLeft.Name = "pnlLeft";
			this.pnlLeft.Size = new System.Drawing.Size(5, 210);
			this.pnlLeft.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.label7.Location = new System.Drawing.Point(54, 104);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 20);
			this.label7.TabIndex = 0;
			this.label7.Text = "Border";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(167, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Color";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label8.Location = new System.Drawing.Point(167, 104);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(42, 20);
			this.label8.TabIndex = 0;
			this.label8.Text = "Color";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.label1.Location = new System.Drawing.Point(54, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Border";
			// 
			// tbFrameColerR
			// 
			this.tbFrameColerR.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbFrameColerR.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tbFrameColerR.Location = new System.Drawing.Point(213, 66);
			this.tbFrameColerR.MaxLength = 3;
			this.tbFrameColerR.Name = "tbFrameColerR";
			this.tbFrameColerR.Size = new System.Drawing.Size(43, 27);
			this.tbFrameColerR.TabIndex = 4;
			this.tbFrameColerR.Text = "127";
			this.tbFrameColerR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbFrameColerR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFrameColerR_KeyPress);
			// 
			// tbFrameColerG
			// 
			this.tbFrameColerG.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbFrameColerG.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tbFrameColerG.Location = new System.Drawing.Point(255, 66);
			this.tbFrameColerG.MaxLength = 3;
			this.tbFrameColerG.Name = "tbFrameColerG";
			this.tbFrameColerG.Size = new System.Drawing.Size(43, 27);
			this.tbFrameColerG.TabIndex = 5;
			this.tbFrameColerG.Text = "127";
			this.tbFrameColerG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbFrameColerG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFrameColerG_KeyPress);
			// 
			// tbFrameColerB
			// 
			this.tbFrameColerB.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbFrameColerB.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tbFrameColerB.Location = new System.Drawing.Point(297, 66);
			this.tbFrameColerB.MaxLength = 3;
			this.tbFrameColerB.Name = "tbFrameColerB";
			this.tbFrameColerB.Size = new System.Drawing.Size(43, 27);
			this.tbFrameColerB.TabIndex = 6;
			this.tbFrameColerB.Text = "127";
			this.tbFrameColerB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbFrameColerB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFrameColerB_KeyPress);
			// 
			// tbLineColerR
			// 
			this.tbLineColerR.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbLineColerR.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tbLineColerR.Location = new System.Drawing.Point(213, 100);
			this.tbLineColerR.MaxLength = 3;
			this.tbLineColerR.Name = "tbLineColerR";
			this.tbLineColerR.Size = new System.Drawing.Size(43, 27);
			this.tbLineColerR.TabIndex = 8;
			this.tbLineColerR.Text = "200";
			this.tbLineColerR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbLineColerR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbLineColerR_KeyPress);
			// 
			// tbLineColerG
			// 
			this.tbLineColerG.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbLineColerG.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tbLineColerG.Location = new System.Drawing.Point(255, 100);
			this.tbLineColerG.MaxLength = 3;
			this.tbLineColerG.Name = "tbLineColerG";
			this.tbLineColerG.Size = new System.Drawing.Size(43, 27);
			this.tbLineColerG.TabIndex = 9;
			this.tbLineColerG.Text = "30";
			this.tbLineColerG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbLineColerG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbLineColerG_KeyPress);
			// 
			// tbLineColerB
			// 
			this.tbLineColerB.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbLineColerB.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tbLineColerB.Location = new System.Drawing.Point(297, 100);
			this.tbLineColerB.MaxLength = 3;
			this.tbLineColerB.Name = "tbLineColerB";
			this.tbLineColerB.Size = new System.Drawing.Size(43, 27);
			this.tbLineColerB.TabIndex = 10;
			this.tbLineColerB.Text = "30";
			this.tbLineColerB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbLineColerB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbLineColerB_KeyPress_1);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.label9.Location = new System.Drawing.Point(54, 36);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(74, 20);
			this.label9.TabIndex = 0;
			this.label9.Text = "Initial Size";
			// 
			// btnOpenFolderDiag
			// 
			this.btnOpenFolderDiag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenFolderDiag.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnOpenFolderDiag.Location = new System.Drawing.Point(316, 158);
			this.btnOpenFolderDiag.Name = "btnOpenFolderDiag";
			this.btnOpenFolderDiag.Size = new System.Drawing.Size(27, 27);
			this.btnOpenFolderDiag.TabIndex = 0;
			this.btnOpenFolderDiag.TabStop = false;
			this.btnOpenFolderDiag.Text = "...";
			this.btnOpenFolderDiag.UseVisualStyleBackColor = true;
			this.btnOpenFolderDiag.Click += new System.EventHandler(this.BtnOpenFolderDiag_Click);
			// 
			// tbOutputPath
			// 
			this.tbOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbOutputPath.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbOutputPath.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tbOutputPath.Location = new System.Drawing.Point(23, 158);
			this.tbOutputPath.Name = "tbOutputPath";
			this.tbOutputPath.Size = new System.Drawing.Size(285, 27);
			this.tbOutputPath.TabIndex = 11;
			this.tbOutputPath.Text = "Desktop";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.btnCancel.Location = new System.Drawing.Point(284, 194);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(60, 28);
			this.btnCancel.TabIndex = 14;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.btnOK.Location = new System.Drawing.Point(216, 194);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(60, 28);
			this.btnOK.TabIndex = 13;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.label3.Location = new System.Drawing.Point(22, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Output Path";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
			this.panel1.Controls.Add(this.rbJP);
			this.panel1.Controls.Add(this.rbEN);
			this.panel1.Controls.Add(this.tbLineBorder);
			this.panel1.Controls.Add(this.tbFrameBorder);
			this.panel1.Controls.Add(this.tbCaptureSizeY);
			this.panel1.Controls.Add(this.tbCaptureSizeX);
			this.panel1.Controls.Add(this.cbArrow);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btnOpenFolderDiag);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.tbOutputPath);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.tbLineColerB);
			this.panel1.Controls.Add(this.tbFrameColerR);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.tbLineColerR);
			this.panel1.Controls.Add(this.tbFrameColerB);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.tbFrameColerG);
			this.panel1.Controls.Add(this.tbLineColerG);
			this.panel1.Controls.Add(this.btnOK);
			this.panel1.Controls.Add(this.pnlLeft);
			this.panel1.Controls.Add(this.pnlTop);
			this.panel1.Location = new System.Drawing.Point(2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(358, 230);
			this.panel1.TabIndex = 16;
			// 
			// tbLineBorder
			// 
			this.tbLineBorder.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbLineBorder.Location = new System.Drawing.Point(109, 101);
			this.tbLineBorder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.tbLineBorder.Name = "tbLineBorder";
			this.tbLineBorder.Size = new System.Drawing.Size(51, 24);
			this.tbLineBorder.TabIndex = 7;
			this.tbLineBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbLineBorder.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// tbFrameBorder
			// 
			this.tbFrameBorder.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbFrameBorder.Location = new System.Drawing.Point(109, 68);
			this.tbFrameBorder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.tbFrameBorder.Name = "tbFrameBorder";
			this.tbFrameBorder.Size = new System.Drawing.Size(51, 24);
			this.tbFrameBorder.TabIndex = 3;
			this.tbFrameBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbFrameBorder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// tbCaptureSizeY
			// 
			this.tbCaptureSizeY.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbCaptureSizeY.Location = new System.Drawing.Point(202, 33);
			this.tbCaptureSizeY.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.tbCaptureSizeY.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.tbCaptureSizeY.Name = "tbCaptureSizeY";
			this.tbCaptureSizeY.Size = new System.Drawing.Size(60, 24);
			this.tbCaptureSizeY.TabIndex = 2;
			this.tbCaptureSizeY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbCaptureSizeY.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			// 
			// tbCaptureSizeX
			// 
			this.tbCaptureSizeX.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbCaptureSizeX.Location = new System.Drawing.Point(134, 33);
			this.tbCaptureSizeX.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.tbCaptureSizeX.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.tbCaptureSizeX.Name = "tbCaptureSizeX";
			this.tbCaptureSizeX.Size = new System.Drawing.Size(60, 24);
			this.tbCaptureSizeX.TabIndex = 1;
			this.tbCaptureSizeX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbCaptureSizeX.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
			// 
			// cbArrow
			// 
			this.cbArrow.AutoSize = true;
			this.cbArrow.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.cbArrow.Location = new System.Drawing.Point(213, 128);
			this.cbArrow.Name = "cbArrow";
			this.cbArrow.Size = new System.Drawing.Size(66, 24);
			this.cbArrow.TabIndex = 0;
			this.cbArrow.TabStop = false;
			this.cbArrow.Text = "Arrow";
			this.cbArrow.UseVisualStyleBackColor = true;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icon_Line;
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox3.Location = new System.Drawing.Point(24, 101);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(23, 23);
			this.pictureBox3.TabIndex = 15;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icon_Capture;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(24, 33);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(23, 23);
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icon_Frame;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Location = new System.Drawing.Point(24, 69);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(23, 23);
			this.pictureBox2.TabIndex = 15;
			this.pictureBox2.TabStop = false;
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
			this.pnlTop.Controls.Add(this.label4);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(358, 20);
			this.pnlTop.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(12, 1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 18);
			this.label4.TabIndex = 0;
			this.label4.Text = "Settings";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.label5.Location = new System.Drawing.Point(22, 198);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "Language";
			// 
			// rbEN
			// 
			this.rbEN.AutoSize = true;
			this.rbEN.Checked = true;
			this.rbEN.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.rbEN.Location = new System.Drawing.Point(101, 197);
			this.rbEN.Name = "rbEN";
			this.rbEN.Size = new System.Drawing.Size(45, 24);
			this.rbEN.TabIndex = 16;
			this.rbEN.TabStop = true;
			this.rbEN.Text = "EN";
			this.rbEN.UseVisualStyleBackColor = true;
			// 
			// rbJP
			// 
			this.rbJP.AutoSize = true;
			this.rbJP.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.rbJP.Location = new System.Drawing.Point(149, 197);
			this.rbJP.Name = "rbJP";
			this.rbJP.Size = new System.Drawing.Size(41, 24);
			this.rbJP.TabIndex = 16;
			this.rbJP.Text = "JP";
			this.rbJP.UseVisualStyleBackColor = true;
			// 
			// FormSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(362, 234);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "FormSettings";
			this.Text = "Settings";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
			this.Load += new System.EventHandler(this.FormSettings_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSettings_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbLineBorder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbFrameBorder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbCaptureSizeY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbCaptureSizeX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlLeft;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox tbFrameColerB;
		public System.Windows.Forms.TextBox tbFrameColerG;
		public System.Windows.Forms.TextBox tbFrameColerR;
		public System.Windows.Forms.TextBox tbLineColerB;
		public System.Windows.Forms.TextBox tbLineColerG;
		public System.Windows.Forms.TextBox tbLineColerR;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnOpenFolderDiag;
		public System.Windows.Forms.TextBox tbOutputPath;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.CheckBox cbArrow;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.NumericUpDown tbCaptureSizeX;
		public System.Windows.Forms.NumericUpDown tbCaptureSizeY;
		public System.Windows.Forms.NumericUpDown tbLineBorder;
		public System.Windows.Forms.NumericUpDown tbFrameBorder;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.RadioButton rbJP;
		public System.Windows.Forms.RadioButton rbEN;
	}
}