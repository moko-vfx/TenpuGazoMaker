namespace WindowsFormsApp1
{
	partial class FormRightClick
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbArrow = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pnlLeft = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.tbLineBorder = new System.Windows.Forms.NumericUpDown();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbLineBorder)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
			this.panel1.Controls.Add(this.tbLineBorder);
			this.panel1.Controls.Add(this.cbArrow);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.pnlLeft);
			this.panel1.Location = new System.Drawing.Point(2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(266, 46);
			this.panel1.TabIndex = 17;
			// 
			// cbArrow
			// 
			this.cbArrow.AutoSize = true;
			this.cbArrow.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.cbArrow.Location = new System.Drawing.Point(192, 13);
			this.cbArrow.Name = "cbArrow";
			this.cbArrow.Size = new System.Drawing.Size(66, 24);
			this.cbArrow.TabIndex = 0;
			this.cbArrow.TabStop = false;
			this.cbArrow.Text = "Arrow";
			this.cbArrow.UseVisualStyleBackColor = true;
			this.cbArrow.CheckedChanged += new System.EventHandler(this.CbArrow_CheckedChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.label7.Location = new System.Drawing.Point(44, 14);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 20);
			this.label7.TabIndex = 0;
			this.label7.Text = "Line Border";
			// 
			// pnlLeft
			// 
			this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
			this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlLeft.Location = new System.Drawing.Point(0, 0);
			this.pnlLeft.Name = "pnlLeft";
			this.pnlLeft.Size = new System.Drawing.Size(5, 46);
			this.pnlLeft.TabIndex = 0;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icon_Line;
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox3.Location = new System.Drawing.Point(16, 11);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(23, 23);
			this.pictureBox3.TabIndex = 15;
			this.pictureBox3.TabStop = false;
			// 
			// tbLineBorder
			// 
			this.tbLineBorder.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbLineBorder.Location = new System.Drawing.Point(130, 11);
			this.tbLineBorder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.tbLineBorder.Name = "tbLineBorder";
			this.tbLineBorder.Size = new System.Drawing.Size(51, 24);
			this.tbLineBorder.TabIndex = 1;
			this.tbLineBorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbLineBorder.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.tbLineBorder.ValueChanged += new System.EventHandler(this.TbLineBorder_ValueChanged);
			// 
			// FormRightClick
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(270, 50);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "FormRightClick";
			this.Text = "FormRightClick";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRightClick_KeyDown);
			this.MouseLeave += new System.EventHandler(this.FormRightClick_MouseLeave);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbLineBorder)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.CheckBox cbArrow;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel pnlLeft;
		public System.Windows.Forms.NumericUpDown tbLineBorder;
	}
}