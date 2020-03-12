namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pnlTop = new System.Windows.Forms.Panel();
			this.btnCapture = new System.Windows.Forms.Button();
			this.btnTrim = new System.Windows.Forms.Button();
			this.btnView = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnLine = new System.Windows.Forms.Button();
			this.btnSetting = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnQuad = new System.Windows.Forms.Button();
			this.btnCopy = new System.Windows.Forms.Button();
			this.btnFrame = new System.Windows.Forms.Button();
			this.btnUndo = new System.Windows.Forms.Button();
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.pbLine = new System.Windows.Forms.PictureBox();
			this.pbDraw = new System.Windows.Forms.PictureBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.lblSize = new System.Windows.Forms.Label();
			this.pnlInfo = new System.Windows.Forms.Panel();
			this.pnlColor2 = new System.Windows.Forms.Panel();
			this.pnlColor1 = new System.Windows.Forms.Panel();
			this.pnlTop.SuspendLayout();
			this.pnlBottom.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDraw)).BeginInit();
			this.pnlInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.pnlTop.Controls.Add(this.btnCapture);
			this.pnlTop.Controls.Add(this.btnTrim);
			this.pnlTop.Controls.Add(this.btnView);
			this.pnlTop.Controls.Add(this.btnSave);
			this.pnlTop.Controls.Add(this.btnLine);
			this.pnlTop.Controls.Add(this.btnSetting);
			this.pnlTop.Controls.Add(this.btnClose);
			this.pnlTop.Controls.Add(this.btnQuad);
			this.pnlTop.Controls.Add(this.btnCopy);
			this.pnlTop.Controls.Add(this.btnFrame);
			this.pnlTop.Controls.Add(this.btnUndo);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(419, 40);
			this.pnlTop.TabIndex = 2;
			// 
			// btnCapture
			// 
			this.btnCapture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnCapture.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icon_Capture;
			this.btnCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnCapture.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.btnCapture.FlatAppearance.BorderSize = 0;
			this.btnCapture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnCapture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCapture.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnCapture.Location = new System.Drawing.Point(14, 9);
			this.btnCapture.Name = "btnCapture";
			this.btnCapture.Size = new System.Drawing.Size(23, 23);
			this.btnCapture.TabIndex = 0;
			this.btnCapture.TabStop = false;
			this.toolTip1.SetToolTip(this.btnCapture, "キャプチャするための枠を表示/非表示します。\r\n枠は大きさを自由に変えられます。\r\n[ ショートカットキー：Ctrl + A ]");
			this.btnCapture.UseVisualStyleBackColor = false;
			this.btnCapture.Click += new System.EventHandler(this.BtnCapture_Click);
			// 
			// btnTrim
			// 
			this.btnTrim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnTrim.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icon_Trim;
			this.btnTrim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnTrim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.btnTrim.FlatAppearance.BorderSize = 0;
			this.btnTrim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnTrim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnTrim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTrim.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnTrim.Location = new System.Drawing.Point(86, 9);
			this.btnTrim.Name = "btnTrim";
			this.btnTrim.Size = new System.Drawing.Size(23, 23);
			this.btnTrim.TabIndex = 0;
			this.btnTrim.TabStop = false;
			this.toolTip1.SetToolTip(this.btnTrim, "画像上の選択範囲をトリミングします。\r\n[ ショートカットキー：Ctrl + T ]");
			this.btnTrim.UseVisualStyleBackColor = false;
			this.btnTrim.Click += new System.EventHandler(this.BtnTrim_Click);
			// 
			// btnView
			// 
			this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnView.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icon_View;
			this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.btnView.FlatAppearance.BorderSize = 0;
			this.btnView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnView.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnView.Location = new System.Drawing.Point(50, 9);
			this.btnView.Name = "btnView";
			this.btnView.Size = new System.Drawing.Size(23, 23);
			this.btnView.TabIndex = 0;
			this.btnView.TabStop = false;
			this.toolTip1.SetToolTip(this.btnView, "キャプチャ枠を表示していれば枠内の背景をツールに取り込みます。\r\n[ ショートカットキー：Ctrl + D ]\r\n\r\n画像を直接ドラッグ＆ドロップしてもOKです。" +
        "\r\nまた、「Ctrl + V」でクリップボードの画像をツールに貼り付けます。");
			this.btnView.UseVisualStyleBackColor = false;
			this.btnView.Click += new System.EventHandler(this.BtnView_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnSave.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icon_Save;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnSave.Location = new System.Drawing.Point(302, 9);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(23, 23);
			this.btnSave.TabIndex = 0;
			this.btnSave.TabStop = false;
			this.toolTip1.SetToolTip(this.btnSave, "ツール上の画像をPNGで保存します。\r\n保存先は設定画面で指定できます。\r\n[ ショートカットキー：Ctrl + S ]");
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// btnLine
			// 
			this.btnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnLine.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icon_Line;
			this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnLine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.btnLine.FlatAppearance.BorderSize = 0;
			this.btnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLine.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnLine.Location = new System.Drawing.Point(194, 9);
			this.btnLine.Name = "btnLine";
			this.btnLine.Size = new System.Drawing.Size(23, 23);
			this.btnLine.TabIndex = 0;
			this.btnLine.TabStop = false;
			this.toolTip1.SetToolTip(this.btnLine, "画像上でラインを引くモードになります。\r\n色と幅は設定画面で指定できます。\r\n[ ショートカットキー：Ctrl + L ]");
			this.btnLine.UseVisualStyleBackColor = false;
			this.btnLine.Click += new System.EventHandler(this.BtnLine_Click);
			// 
			// btnSetting
			// 
			this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnSetting.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icon_Set;
			this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.btnSetting.FlatAppearance.BorderSize = 0;
			this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSetting.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnSetting.Location = new System.Drawing.Point(374, 9);
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Size = new System.Drawing.Size(23, 23);
			this.btnSetting.TabIndex = 0;
			this.btnSetting.TabStop = false;
			this.toolTip1.SetToolTip(this.btnSetting, "設定画面を開きます。\r\n[ ショートカットキー：Esc ]");
			this.btnSetting.UseVisualStyleBackColor = false;
			this.btnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnClose.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icon_Close;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnClose.Location = new System.Drawing.Point(338, 9);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.TabStop = false;
			this.toolTip1.SetToolTip(this.btnClose, "ツール上の画像をクリアします。\r\n[ ショートカットキー：Ctrl + W ]");
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// btnQuad
			// 
			this.btnQuad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnQuad.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icon_Quad;
			this.btnQuad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnQuad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.btnQuad.FlatAppearance.BorderSize = 0;
			this.btnQuad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnQuad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnQuad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuad.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnQuad.Location = new System.Drawing.Point(158, 9);
			this.btnQuad.Name = "btnQuad";
			this.btnQuad.Size = new System.Drawing.Size(23, 23);
			this.btnQuad.TabIndex = 0;
			this.btnQuad.TabStop = false;
			this.toolTip1.SetToolTip(this.btnQuad, "画像上の選択範囲に枠線を描画します。\r\n色と幅は設定画面で指定できます。\r\n[ ショートカットキー：Ctrl + Q ]");
			this.btnQuad.UseVisualStyleBackColor = false;
			this.btnQuad.Click += new System.EventHandler(this.BtnQuad_Click);
			// 
			// btnCopy
			// 
			this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnCopy.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icon_Copy;
			this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.btnCopy.FlatAppearance.BorderSize = 0;
			this.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCopy.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnCopy.Location = new System.Drawing.Point(266, 9);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(23, 23);
			this.btnCopy.TabIndex = 0;
			this.btnCopy.TabStop = false;
			this.toolTip1.SetToolTip(this.btnCopy, "ツール上の画像をクリップボードにコピーします。\r\n[ ショートカットキー：Ctrl + C ]");
			this.btnCopy.UseVisualStyleBackColor = false;
			this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
			// 
			// btnFrame
			// 
			this.btnFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnFrame.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icon_Frame;
			this.btnFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnFrame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.btnFrame.FlatAppearance.BorderSize = 0;
			this.btnFrame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnFrame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFrame.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnFrame.Location = new System.Drawing.Point(122, 9);
			this.btnFrame.Name = "btnFrame";
			this.btnFrame.Size = new System.Drawing.Size(23, 23);
			this.btnFrame.TabIndex = 0;
			this.btnFrame.TabStop = false;
			this.toolTip1.SetToolTip(this.btnFrame, "取り込んだ画像の周囲に枠線を追加します。\r\n色と幅は設定画面で指定できます。\r\n[ ショートカットキー：Ctrl + F ]");
			this.btnFrame.UseVisualStyleBackColor = false;
			this.btnFrame.Click += new System.EventHandler(this.BtnFrame_Click);
			// 
			// btnUndo
			// 
			this.btnUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.btnUndo.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icon_Undo;
			this.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
			this.btnUndo.FlatAppearance.BorderSize = 0;
			this.btnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
			this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUndo.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnUndo.Location = new System.Drawing.Point(230, 9);
			this.btnUndo.Name = "btnUndo";
			this.btnUndo.Size = new System.Drawing.Size(23, 23);
			this.btnUndo.TabIndex = 0;
			this.btnUndo.TabStop = false;
			this.toolTip1.SetToolTip(this.btnUndo, "ツール上の画像の編集に対してUndo/Redoします。\r\n[ ショートカットキー：Ctrl + Z ]");
			this.btnUndo.UseVisualStyleBackColor = false;
			this.btnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
			// 
			// pnlBottom
			// 
			this.pnlBottom.AllowDrop = true;
			this.pnlBottom.AutoScroll = true;
			this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(61)))));
			this.pnlBottom.Controls.Add(this.pbLine);
			this.pnlBottom.Controls.Add(this.pbDraw);
			this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBottom.Location = new System.Drawing.Point(0, 40);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(419, 159);
			this.pnlBottom.TabIndex = 3;
			this.pnlBottom.DragDrop += new System.Windows.Forms.DragEventHandler(this.PnlBottom_DragDrop);
			this.pnlBottom.DragEnter += new System.Windows.Forms.DragEventHandler(this.PnlBottom_DragEnter);
			// 
			// pbLine
			// 
			this.pbLine.BackColor = System.Drawing.Color.Transparent;
			this.pbLine.Location = new System.Drawing.Point(0, 0);
			this.pbLine.Name = "pbLine";
			this.pbLine.Size = new System.Drawing.Size(20, 20);
			this.pbLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbLine.TabIndex = 1;
			this.pbLine.TabStop = false;
			this.pbLine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbLine_MouseDown);
			this.pbLine.MouseEnter += new System.EventHandler(this.PbLine_MouseEnter);
			this.pbLine.MouseLeave += new System.EventHandler(this.PbLine_MouseLeave);
			this.pbLine.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbLine_MouseMove);
			this.pbLine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbLine_MouseUp);
			// 
			// pbDraw
			// 
			this.pbDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
			this.pbDraw.Location = new System.Drawing.Point(0, 0);
			this.pbDraw.Name = "pbDraw";
			this.pbDraw.Size = new System.Drawing.Size(50, 50);
			this.pbDraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbDraw.TabIndex = 1;
			this.pbDraw.TabStop = false;
			this.pbDraw.SizeChanged += new System.EventHandler(this.PbDraw_SizeChanged);
			this.pbDraw.DragDrop += new System.Windows.Forms.DragEventHandler(this.PbDraw_DragDrop);
			this.pbDraw.DragEnter += new System.Windows.Forms.DragEventHandler(this.PbDraw_DragEnter);
			// 
			// lblSize
			// 
			this.lblSize.AutoSize = true;
			this.lblSize.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(145)))), ((int)(((byte)(142)))));
			this.lblSize.Location = new System.Drawing.Point(7, 3);
			this.lblSize.Name = "lblSize";
			this.lblSize.Size = new System.Drawing.Size(83, 18);
			this.lblSize.TabIndex = 0;
			this.lblSize.Text = "Image Size :";
			// 
			// pnlInfo
			// 
			this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(39)))));
			this.pnlInfo.Controls.Add(this.pnlColor2);
			this.pnlInfo.Controls.Add(this.pnlColor1);
			this.pnlInfo.Controls.Add(this.lblSize);
			this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlInfo.Location = new System.Drawing.Point(0, 199);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new System.Drawing.Size(419, 22);
			this.pnlInfo.TabIndex = 4;
			// 
			// pnlColor2
			// 
			this.pnlColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlColor2.BackColor = System.Drawing.Color.OrangeRed;
			this.pnlColor2.Location = new System.Drawing.Point(398, 7);
			this.pnlColor2.Name = "pnlColor2";
			this.pnlColor2.Size = new System.Drawing.Size(9, 9);
			this.pnlColor2.TabIndex = 1;
			// 
			// pnlColor1
			// 
			this.pnlColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlColor1.BackColor = System.Drawing.Color.Silver;
			this.pnlColor1.Location = new System.Drawing.Point(382, 7);
			this.pnlColor1.Name = "pnlColor1";
			this.pnlColor1.Size = new System.Drawing.Size(9, 9);
			this.pnlColor1.TabIndex = 1;
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 221);
			this.Controls.Add(this.pnlBottom);
			this.Controls.Add(this.pnlTop);
			this.Controls.Add(this.pnlInfo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(435, 100);
			this.Name = "Form1";
			this.Text = "Tenpu Gazo Maker v.1.02";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.pnlTop.ResumeLayout(false);
			this.pnlBottom.ResumeLayout(false);
			this.pnlBottom.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDraw)).EndInit();
			this.pnlInfo.ResumeLayout(false);
			this.pnlInfo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCapture;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.Button btnLine;
		private System.Windows.Forms.Button btnQuad;
		private System.Windows.Forms.Button btnFrame;
		private System.Windows.Forms.Button btnUndo;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.PictureBox pbDraw;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.Button btnTrim;
		private System.Windows.Forms.Button btnSetting;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label lblSize;
		private System.Windows.Forms.Panel pnlInfo;
		private System.Windows.Forms.PictureBox pbLine;
		private System.Windows.Forms.Panel pnlColor2;
		private System.Windows.Forms.Panel pnlColor1;
	}
}

