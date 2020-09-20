namespace WindowsFormsApp1
{
	partial class FormResizePicture
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbWidth = new System.Windows.Forms.TextBox();
			this.tbHeight = new System.Windows.Forms.TextBox();
			this.cbRockHeight = new System.Windows.Forms.CheckBox();
			this.cbRockWidth = new System.Windows.Forms.CheckBox();
			this.cbLink = new System.Windows.Forms.CheckBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.pnlLeft = new System.Windows.Forms.Panel();
			this.pnlTop = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.pnlTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
			this.panel1.Controls.Add(this.tbWidth);
			this.panel1.Controls.Add(this.tbHeight);
			this.panel1.Controls.Add(this.cbRockHeight);
			this.panel1.Controls.Add(this.cbRockWidth);
			this.panel1.Controls.Add(this.cbLink);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.btnOK);
			this.panel1.Controls.Add(this.pnlLeft);
			this.panel1.Controls.Add(this.pnlTop);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(318, 131);
			this.panel1.TabIndex = 17;
			// 
			// tbWidth
			// 
			this.tbWidth.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbWidth.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tbWidth.Location = new System.Drawing.Point(113, 31);
			this.tbWidth.MaxLength = 5;
			this.tbWidth.Name = "tbWidth";
			this.tbWidth.Size = new System.Drawing.Size(60, 27);
			this.tbWidth.TabIndex = 1;
			this.tbWidth.Text = "127";
			this.tbWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip1.SetToolTip(this.tbWidth, "ヨコ幅を指定してください");
			this.tbWidth.Enter += new System.EventHandler(this.tbWidth_Enter);
			this.tbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWidth_KeyPress);
			this.tbWidth.Leave += new System.EventHandler(this.tbWidth_Leave);
			// 
			// tbHeight
			// 
			this.tbHeight.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbHeight.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tbHeight.Location = new System.Drawing.Point(184, 31);
			this.tbHeight.MaxLength = 5;
			this.tbHeight.Name = "tbHeight";
			this.tbHeight.Size = new System.Drawing.Size(60, 27);
			this.tbHeight.TabIndex = 2;
			this.tbHeight.Text = "127";
			this.tbHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip1.SetToolTip(this.tbHeight, "タテ幅を指定してください");
			this.tbHeight.Enter += new System.EventHandler(this.tbHeight_Enter);
			this.tbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHeight_KeyPress);
			this.tbHeight.Leave += new System.EventHandler(this.tbHeight_Leave);
			// 
			// cbRockHeight
			// 
			this.cbRockHeight.AutoSize = true;
			this.cbRockHeight.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.cbRockHeight.Location = new System.Drawing.Point(184, 63);
			this.cbRockHeight.Name = "cbRockHeight";
			this.cbRockHeight.Size = new System.Drawing.Size(59, 24);
			this.cbRockHeight.TabIndex = 0;
			this.cbRockHeight.TabStop = false;
			this.cbRockHeight.Text = "Rock";
			this.toolTip1.SetToolTip(this.cbRockHeight, "タテ幅の指定を固定します");
			this.cbRockHeight.UseVisualStyleBackColor = true;
			this.cbRockHeight.CheckedChanged += new System.EventHandler(this.cbRockHeight_CheckedChanged);
			// 
			// cbRockWidth
			// 
			this.cbRockWidth.AutoSize = true;
			this.cbRockWidth.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.cbRockWidth.Location = new System.Drawing.Point(115, 63);
			this.cbRockWidth.Name = "cbRockWidth";
			this.cbRockWidth.Size = new System.Drawing.Size(59, 24);
			this.cbRockWidth.TabIndex = 0;
			this.cbRockWidth.TabStop = false;
			this.cbRockWidth.Text = "Rock";
			this.toolTip1.SetToolTip(this.cbRockWidth, "ヨコ幅の指定を固定します");
			this.cbRockWidth.UseVisualStyleBackColor = true;
			this.cbRockWidth.CheckedChanged += new System.EventHandler(this.cbRockWidth_CheckedChanged);
			// 
			// cbLink
			// 
			this.cbLink.AutoSize = true;
			this.cbLink.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.cbLink.Location = new System.Drawing.Point(253, 34);
			this.cbLink.Name = "cbLink";
			this.cbLink.Size = new System.Drawing.Size(53, 24);
			this.cbLink.TabIndex = 0;
			this.cbLink.TabStop = false;
			this.cbLink.Text = "Link";
			this.toolTip1.SetToolTip(this.cbLink, "縦横比を保持します");
			this.cbLink.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icon_Scale;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(24, 33);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(23, 23);
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.btnCancel.Location = new System.Drawing.Point(244, 95);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(60, 28);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.label9.Location = new System.Drawing.Point(54, 36);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(50, 20);
			this.label9.TabIndex = 0;
			this.label9.Text = "Resize";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.btnOK.Location = new System.Drawing.Point(176, 95);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(60, 28);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// pnlLeft
			// 
			this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
			this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlLeft.Location = new System.Drawing.Point(0, 20);
			this.pnlLeft.Name = "pnlLeft";
			this.pnlLeft.Size = new System.Drawing.Size(5, 111);
			this.pnlLeft.TabIndex = 0;
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
			this.pnlTop.Controls.Add(this.label4);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(318, 20);
			this.pnlTop.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(12, 1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 18);
			this.label4.TabIndex = 0;
			this.label4.Text = "Resize Image";
			// 
			// FormResizePicture
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(318, 131);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "FormResizePicture";
			this.Text = "Resize Picture";
			this.Load += new System.EventHandler(this.FormResizePicture_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormResizePicture_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.CheckBox cbLink;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Panel pnlLeft;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ToolTip toolTip1;
		public System.Windows.Forms.CheckBox cbRockHeight;
		public System.Windows.Forms.CheckBox cbRockWidth;
		public System.Windows.Forms.TextBox tbWidth;
		public System.Windows.Forms.TextBox tbHeight;
	}
}