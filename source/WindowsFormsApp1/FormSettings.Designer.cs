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
			this.panelLabel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbFrameBorder = new System.Windows.Forms.TextBox();
			this.tbLineBorder = new System.Windows.Forms.TextBox();
			this.tbFrameColerR = new System.Windows.Forms.TextBox();
			this.tbFrameColerG = new System.Windows.Forms.TextBox();
			this.tbFrameColerB = new System.Windows.Forms.TextBox();
			this.tbLineColerR = new System.Windows.Forms.TextBox();
			this.tbLineColerG = new System.Windows.Forms.TextBox();
			this.tbLineColerB = new System.Windows.Forms.TextBox();
			this.tbCaptureSizeY = new System.Windows.Forms.TextBox();
			this.tbCaptureSizeX = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnOpenFolderDiag = new System.Windows.Forms.Button();
			this.tbOutputPath = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.cbArrow = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panelLabel1
			// 
			this.panelLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
			this.panelLabel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLabel1.Location = new System.Drawing.Point(0, 0);
			this.panelLabel1.Name = "panelLabel1";
			this.panelLabel1.Size = new System.Drawing.Size(5, 220);
			this.panelLabel1.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.label7.Location = new System.Drawing.Point(54, 89);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 20);
			this.label7.TabIndex = 0;
			this.label7.Text = "Line Border";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(193, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Color";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label8.Location = new System.Drawing.Point(193, 89);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(42, 20);
			this.label8.TabIndex = 0;
			this.label8.Text = "Color";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.label1.Location = new System.Drawing.Point(54, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Frame Border";
			// 
			// tbFrameBorder
			// 
			this.tbFrameBorder.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbFrameBorder.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tbFrameBorder.Location = new System.Drawing.Point(153, 51);
			this.tbFrameBorder.MaxLength = 1;
			this.tbFrameBorder.Name = "tbFrameBorder";
			this.tbFrameBorder.Size = new System.Drawing.Size(34, 27);
			this.tbFrameBorder.TabIndex = 3;
			this.tbFrameBorder.Text = "1";
			this.tbFrameBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbFrameBorder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFrameBorder_KeyPress);
			// 
			// tbLineBorder
			// 
			this.tbLineBorder.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbLineBorder.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tbLineBorder.Location = new System.Drawing.Point(153, 85);
			this.tbLineBorder.MaxLength = 1;
			this.tbLineBorder.Name = "tbLineBorder";
			this.tbLineBorder.Size = new System.Drawing.Size(34, 27);
			this.tbLineBorder.TabIndex = 7;
			this.tbLineBorder.Text = "4";
			this.tbLineBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbLineBorder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbLineBorder_KeyPress);
			// 
			// tbFrameColerR
			// 
			this.tbFrameColerR.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbFrameColerR.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tbFrameColerR.Location = new System.Drawing.Point(239, 51);
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
			this.tbFrameColerG.Location = new System.Drawing.Point(281, 51);
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
			this.tbFrameColerB.Location = new System.Drawing.Point(323, 51);
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
			this.tbLineColerR.Location = new System.Drawing.Point(239, 85);
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
			this.tbLineColerG.Location = new System.Drawing.Point(281, 85);
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
			this.tbLineColerB.Location = new System.Drawing.Point(323, 85);
			this.tbLineColerB.MaxLength = 3;
			this.tbLineColerB.Name = "tbLineColerB";
			this.tbLineColerB.Size = new System.Drawing.Size(43, 27);
			this.tbLineColerB.TabIndex = 10;
			this.tbLineColerB.Text = "30";
			this.tbLineColerB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbLineColerB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbLineColerB_KeyPress);
			// 
			// tbCaptureSizeY
			// 
			this.tbCaptureSizeY.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbCaptureSizeY.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tbCaptureSizeY.Location = new System.Drawing.Point(185, 16);
			this.tbCaptureSizeY.MaxLength = 6;
			this.tbCaptureSizeY.Name = "tbCaptureSizeY";
			this.tbCaptureSizeY.Size = new System.Drawing.Size(47, 27);
			this.tbCaptureSizeY.TabIndex = 2;
			this.tbCaptureSizeY.Text = "300";
			this.tbCaptureSizeY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbCaptureSizeY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCaptureSizeY_KeyPress);
			// 
			// tbCaptureSizeX
			// 
			this.tbCaptureSizeX.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbCaptureSizeX.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tbCaptureSizeX.Location = new System.Drawing.Point(132, 16);
			this.tbCaptureSizeX.MaxLength = 6;
			this.tbCaptureSizeX.Name = "tbCaptureSizeX";
			this.tbCaptureSizeX.Size = new System.Drawing.Size(47, 27);
			this.tbCaptureSizeX.TabIndex = 1;
			this.tbCaptureSizeX.Text = "400";
			this.tbCaptureSizeX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbCaptureSizeX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCaptureSizeX_KeyPress);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.label9.Location = new System.Drawing.Point(54, 20);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(74, 20);
			this.label9.TabIndex = 0;
			this.label9.Text = "Initial Size";
			// 
			// btnOpenFolderDiag
			// 
			this.btnOpenFolderDiag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenFolderDiag.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnOpenFolderDiag.Location = new System.Drawing.Point(346, 146);
			this.btnOpenFolderDiag.Name = "btnOpenFolderDiag";
			this.btnOpenFolderDiag.Size = new System.Drawing.Size(27, 27);
			this.btnOpenFolderDiag.TabIndex = 12;
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
			this.tbOutputPath.Location = new System.Drawing.Point(23, 146);
			this.tbOutputPath.Name = "tbOutputPath";
			this.tbOutputPath.Size = new System.Drawing.Size(315, 27);
			this.tbOutputPath.TabIndex = 11;
			this.tbOutputPath.Text = "Desktop";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.btnCancel.Location = new System.Drawing.Point(314, 182);
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
			this.btnOK.Location = new System.Drawing.Point(248, 182);
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
			this.label3.Location = new System.Drawing.Point(22, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Output Path";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
			this.panel1.Controls.Add(this.cbArrow);
			this.panel1.Controls.Add(this.panelLabel1);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btnOpenFolderDiag);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.tbLineBorder);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.tbOutputPath);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.tbCaptureSizeY);
			this.panel1.Controls.Add(this.tbFrameBorder);
			this.panel1.Controls.Add(this.tbLineColerB);
			this.panel1.Controls.Add(this.tbFrameColerR);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.tbLineColerR);
			this.panel1.Controls.Add(this.tbFrameColerB);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.tbCaptureSizeX);
			this.panel1.Controls.Add(this.tbFrameColerG);
			this.panel1.Controls.Add(this.tbLineColerG);
			this.panel1.Controls.Add(this.btnOK);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(388, 220);
			this.panel1.TabIndex = 16;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icon_Line;
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox3.Location = new System.Drawing.Point(24, 86);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(23, 23);
			this.pictureBox3.TabIndex = 15;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icon_Capture;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(24, 20);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(23, 23);
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icon_Frame;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Location = new System.Drawing.Point(24, 54);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(23, 23);
			this.pictureBox2.TabIndex = 15;
			this.pictureBox2.TabStop = false;
			// 
			// cbArrow
			// 
			this.cbArrow.AutoSize = true;
			this.cbArrow.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.cbArrow.Location = new System.Drawing.Point(239, 115);
			this.cbArrow.Name = "cbArrow";
			this.cbArrow.Size = new System.Drawing.Size(66, 24);
			this.cbArrow.TabIndex = 0;
			this.cbArrow.TabStop = false;
			this.cbArrow.Text = "Arrow";
			this.cbArrow.UseVisualStyleBackColor = true;
			// 
			// FormSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(394, 226);
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelLabel1;
		public System.Windows.Forms.TextBox tbFrameBorder;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox tbLineBorder;
		public System.Windows.Forms.TextBox tbFrameColerB;
		public System.Windows.Forms.TextBox tbFrameColerG;
		public System.Windows.Forms.TextBox tbFrameColerR;
		public System.Windows.Forms.TextBox tbLineColerB;
		public System.Windows.Forms.TextBox tbLineColerG;
		public System.Windows.Forms.TextBox tbLineColerR;
		public System.Windows.Forms.TextBox tbCaptureSizeY;
		public System.Windows.Forms.TextBox tbCaptureSizeX;
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
	}
}