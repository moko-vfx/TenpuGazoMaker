using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		FrameForm frame;

		// 変数：キャプチャ用の枠線
		int capLineBorder = 4;
		Color capLineColor = Color.FromArgb(255, 40, 40);
		int capPosX = 30;
		int capPosY = 87;

		// 変数：デリゲート
		EditPicture EditMethod;

		// 変数：Undo用のバッファ
		Image imgOld = null;
		Image imgNow = null;

		// 変数：選択範囲
		bool lineMode = false;
		bool selecting = false;

		Point staPoint;
		Point endPoint;
		Point p0, p1, p2, p3;

		Color selectColor = Color.FromArgb(220, 80, 40);
		Graphics g;
		Pen linePen;

		Bitmap bm;


		//******************************//
		//								//
		//		　 フォーム関係　		//
		//								//
		//******************************//

		// Form1のコンストラクタ
		public Form1()
		{
			InitializeComponent();
		}

		// 起動時に実行
		private void Form1_Load(object sender, EventArgs e)
		{
			// 設定を入力
			Settings.InputSettings();

			// フォームのサイズを復元
			this.Width = Settings.formSizeX;
			this.Height = Settings.formSizeY;

			// PictureBoxにドラッグ＆ドロップを許可
			pbDraw.AllowDrop = true;
		}

		// 終了時に実行
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			// フォームのサイズを取得
			Settings.formSizeX = this.Width;
			Settings.formSizeY = this.Height;

			// 設定を出力
			Settings.OutputSettings();
		}

		//******************************//
		//								//
		//		　 　 ボタン	　		//
		//								//
		//******************************//

		// ボタン：デスクトップのキャプチャ枠表示
		private void BtnCapture_Click(object sender, EventArgs e)
		{
			ViewCaptureFrame();
		}

		// ボタン：画像の表示
		private void BtnView_Click(object sender, EventArgs e)
		{
			GetPicture();
		}

		// ボタン：選択範囲をトリミング
		private void BtnTrim_Click(object sender, EventArgs e)
		{
			EditMethod = TrimPicture;
			CheckPicture(EditMethod, 1, 1);
		}
		
		// ボタン：枠線描画
		private void BtnFrame_Click(object sender, EventArgs e)
		{
			EditMethod = DrawFrame;
			CheckPicture(EditMethod, 1, 1);
		}

		// ボタン：矩形ライン描画
		private void BtnQuad_Click(object sender, EventArgs e)
		{
			EditMethod = DrawQuad;
			CheckPicture(EditMethod, 1, 1);
		}
		
		// ボタン：ライン描画
		private void BtnLine_Click(object sender, EventArgs e)
		{
			ChangeLineMode();
		}
		
		// ボタン：アンドゥ/リドゥ
		private void BtnUndo_Click(object sender, EventArgs e)
		{
			Undo();
		}

		// ボタン：画像をクリップボードにコピー
		private void BtnCopy_Click(object sender, EventArgs e)
		{
			CopyToClipboard();
		}

		// ボタン：画像を保存
		private void BtnSave_Click(object sender, EventArgs e)
		{
			SavePicture();
		}

		// ボタン：画像を閉じる
		private void BtnClose_Click(object sender, EventArgs e)
		{
			EditMethod = ClosePicture;
			CheckPicture(EditMethod, 1, 1);
		}

		// ボタン：設定
		private void BtnSetting_Click(object sender, EventArgs e)
		{
			OpenSetting();
		}

		//******************************//
		//								//
		//		　 　 マウス	　		//
		//								//
		//******************************//

		// マウス：ドラッグ開始
		private void PbDraw_MouseDown(object sender, MouseEventArgs e)
		{
			// PictureBoxに画像がある場合
			if (pbDraw.Image != null)
			{
				// 座標を保存
				staPoint.X = cursorPos().X;
				staPoint.Y = cursorPos().Y;

				// ライン描画モード時
				if (lineMode)
				{
					// Undoのための画像バックアップ(Old)
					BackupImageOld();

					// 描画するImageオブジェクトを作成
					bm = new Bitmap(imgNow);
					//ImageオブジェクトのGraphicsオブジェクトを作成する
					g = Graphics.FromImage(bm);

					// Penオブジェクトの作成
					linePen = new Pen(Settings.lineColor, Settings.lineBorder);

					// 矢印設定を判定
					if (Settings.useArrow)
					{
						int i = Settings.lineBorder;

						// 矢印を描画する
						linePen.CustomEndCap = new AdjustableArrowCap(3, 3);
					}
					else
					{
						linePen.EndCap = LineCap.NoAnchor;
					}

					// スタイルを指定
					linePen.DashStyle = DashStyle.Solid;
				}
				// 選択範囲モード時
				else
				{
					// 描画するImageオブジェクトを作成
					// サイズだけ指定すると無色透明のキャンバスになる
					bm = new Bitmap(pbDraw.Width, pbDraw.Height);

					// Penオブジェクトの作成
					linePen = new Pen(selectColor, 2);

					// スタイルを指定
					linePen.DashStyle = DashStyle.Dot;
				}
			}
		}

		// マウス：ドラッグ中
		private void PbDraw_MouseMove(object sender, MouseEventArgs e)
		{
			// PictureBoxに画像がある場合
			if (pbDraw.Image != null)
			{
				// ライン描画モード時
				if (lineMode)
				{
					// マウスの左ボタンが押されている場合のみ処理
					if ((Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left)
					{
						// Shiftキーが押されていれば直線にする
						if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
						{
							// 比較のためにXとYの移動距離を算出
							int checkPosX = Math.Abs(cursorPos().X - staPoint.X);
							int checkPosY = Math.Abs(cursorPos().Y - staPoint.Y);

							// 角度を算出
							double d = 0.0;

							if (checkPosX != 0 && checkPosY != 0) // 0除算対策
							{
								// 角度を求める
								d = Math.Atan2(checkPosY, checkPosX);

								// ラジアンから度数に変換
								d = d * 180 / Math.PI;
							}

							// XとYのどちらが長いか比較する
							if (checkPosX >= checkPosY) // 横長の場合
							{
								if (40.0 < d && d < 50.0)
								{
									// 座標を取得
									// 開始位置に対して現在位置が正負どちらか判定して処理
									endPoint.X = cursorPos().X;
									endPoint.Y = staPoint.Y +
										(Math.Sign(cursorPos().Y - staPoint.Y) * checkPosX);
								}
								else
								{
									// 座標を取得
									endPoint.X = cursorPos().X;
									endPoint.Y = staPoint.Y;
								}
							}
							else // 縦長の場合
							{
								if (40.0 < d && d < 50.0)
								{
									// 座標を取得
									// 開始位置に対して現在位置が正負どちらか判定して処理
									endPoint.X = staPoint.X +
										(Math.Sign(cursorPos().X - staPoint.X) * checkPosY);
									endPoint.Y = cursorPos().Y;
								}
								else
								{
									// 座標を取得
									endPoint.X = staPoint.X;
									endPoint.Y = cursorPos().Y;
								}
							}
						}
						else
						{
							// 座標を取得
							endPoint.X = cursorPos().X;
							endPoint.Y = cursorPos().Y;
						}

						// 描画
						DrawLine(bm);
					}
				}
				// 選択範囲モード時
				else
				{
					// マウスの左ボタンが押されている場合のみ処理
					if ((Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left)
					{
						// Shiftキーが押されていれば直線にする
						if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
						{
							// 比較のためにXとYの移動距離を算出
							int checkPosX = Math.Abs(cursorPos().X - staPoint.X);
							int checkPosY = Math.Abs(cursorPos().Y - staPoint.Y);

							// XとYのどちらが長いか比較する
							if (checkPosX >= checkPosY) // 横長の場合
							{
								// 座標を取得
								// 開始位置に対して現在位置が正負どちらか判定して処理
								endPoint.X = cursorPos().X;
								endPoint.Y = staPoint.Y +
									(Math.Sign(cursorPos().Y - staPoint.Y) * checkPosX);
							}
							else // 縦長の場合
							{
								// 座標を取得
								// 開始位置に対して現在位置が正負どちらか判定して処理
								endPoint.X = staPoint.X +
									(Math.Sign(cursorPos().X - staPoint.X) * checkPosY);
								endPoint.Y = cursorPos().Y;
							}
						}
						else
						{
							// 座標を取得
							endPoint.X = cursorPos().X;
							endPoint.Y = cursorPos().Y;
						}

						// 選択範囲の描画
						DrawSelect(bm);
					}					
				}				
			}
		}

		// マウス：ドラッグ終了
		private void PbDraw_MouseUp(object sender, MouseEventArgs e)
		{
			// PictureBoxに画像がある場合
			if (pbDraw.Image != null)
			{
				// リソースを解放
				linePen.Dispose();
				g.Dispose();
				bm = null;

				// ライン描画モード時
				if (lineMode)
				{
					// Undoのための画像バックアップ(Now)
					BackupImageNow();
				}
				// 選択範囲モード時
				else
				{
					// 位置を判定して補正
					if (staPoint.X <= endPoint.X) // 左から右へ
					{
						if (staPoint.Y <= endPoint.Y) // 左上から右下へ
						{
							p0 = new Point(staPoint.X, staPoint.Y); // 上辺
							p1 = new Point(endPoint.X, staPoint.Y); // 底辺
							p2 = new Point(staPoint.X, endPoint.Y); // 左辺
							p3 = new Point(endPoint.X, endPoint.Y); // 右辺
						}
						else // 左下から右上へ
						{
							p0 = new Point(staPoint.X, endPoint.Y); // 上辺
							p1 = new Point(endPoint.X, endPoint.Y); // 底辺
							p2 = new Point(staPoint.X, staPoint.Y); // 左辺
							p3 = new Point(endPoint.X, staPoint.Y); // 右辺
						}
					}
					else // 右から左へ
					{
						if (staPoint.Y <= endPoint.Y) // 右上から左下へ
						{
							p0 = new Point(endPoint.X, staPoint.Y); // 上辺
							p1 = new Point(staPoint.X, staPoint.Y); // 底辺
							p2 = new Point(endPoint.X, endPoint.Y); // 左辺
							p3 = new Point(staPoint.X, endPoint.Y); // 右辺
						}
						else // 右下から左上へ
						{
							p0 = new Point(endPoint.X, endPoint.Y); // 上辺
							p1 = new Point(staPoint.X, endPoint.Y); // 底辺
							p2 = new Point(endPoint.X, staPoint.Y); // 左辺
							p3 = new Point(staPoint.X, staPoint.Y); // 右辺
						}
					}

					// 開始点と終了点にソートを反映
					staPoint = p0;
					endPoint = p3;

					// 選択範囲フラグON
					selecting = true;
				}
			}
		}

		// マウス：PictureBox内に入った時
		private void PbDraw_MouseEnter(object sender, EventArgs e)
		{
			// カーソルを変える
			if (lineMode)
			{
				pbDraw.Cursor = Cursors.Cross;
			}
		}
		
		// マウス：PictureBox内から出た時
		private void PbDraw_MouseLeave(object sender, EventArgs e)
		{
			// カーソルを元に戻す
			if (lineMode)
			{
				pbDraw.Cursor = Cursors.Default;
			}
		}

		// パネルへのドラッグ
		private void PnlBottom_DragEnter(object sender, DragEventArgs e)
		{
			// ドラッグされたデータ形式がファイルかどうか判定
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				// ファイルなら受け付ける
				e.Effect = DragDropEffects.All;
			}
			else
			{
				// ファイル以外は受け付けない
				e.Effect = DragDropEffects.None;
			}
		}
		// パネルへのドロップ
		private void PnlBottom_DragDrop(object sender, DragEventArgs e)
		{
			try
			{
				string[] filePass = (string[])e.Data.GetData(DataFormats.FileDrop);

				// 画像を取得
				Bitmap bmap = new Bitmap(filePass[0]);
				Image dropImage = new Bitmap(bmap);
				bmap.Dispose();

				// Undoのための画像バックアップ(Old)
				BackupImageOld();

				// PixtureBoxに表示
				pbDraw.Image = dropImage;

				// Undoのための画像バックアップ(Now)
				BackupImageNow();
			}
			catch (Exception)
			{
				MessageBox.Show("ドラッグ＆ドロップに失敗しました。" + "\r\n" +
								"一般的な画像ファイルかご確認ください。");
			}
		}
		
		// PictureBoxへのドラッグ
		private void PbDraw_DragEnter(object sender, DragEventArgs e)
		{
			// ドラッグされたデータ形式がファイルかどうか判定
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				// ファイルなら受け付ける
				e.Effect = DragDropEffects.All;
			}
			else
			{
				// ファイル以外は受け付けない
				e.Effect = DragDropEffects.None;
			}
		}
		// PictureBoxへのドロップ
		private void PbDraw_DragDrop(object sender, DragEventArgs e)
		{
			try
			{
				string[] filePass = (string[])e.Data.GetData(DataFormats.FileDrop);

				// 画像を取得
				Bitmap bmap = new Bitmap(filePass[0]);
				Image dropImage = new Bitmap(bmap);
				bmap.Dispose();

				// Undoのための画像バックアップ(Old)
				BackupImageOld();

				// PixtureBoxに表示
				pbDraw.Image = dropImage;

				// Undoのための画像バックアップ(Now)
				BackupImageNow();
			}
			catch (Exception)
			{
				MessageBox.Show("ドラッグ＆ドロップに失敗しました。" + "\r\n" +
								"一般的な画像ファイルかご確認ください。");
			}
		}

		// イベント：PixtureBoxのサイズが変わったタイミング
		private void PbDraw_SizeChanged(object sender, EventArgs e)
		{
			// PixtureBoxのサイズを表示
			lblSize.Text = "Image Size : W " +
				pbDraw.Width.ToString() + " / H " +
				pbDraw.Height.ToString();
		}

		//******************************//
		//								//
		//		　ショートカット		//
		//								//
		//******************************//

		// 全てのショートカットをフォームが受け取って実行する
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			// キャプチャ枠の表示
			if (e.Control && e.KeyCode == Keys.A)
			{
				ViewCaptureFrame();
			}

			// 画像貼り付け
			if (e.Control && e.KeyCode == Keys.V)
			{
				GetPicture();
			}

			// トリミング
			if (e.Control && e.KeyCode == Keys.T)
			{
				EditMethod = TrimPicture;
				CheckPicture(EditMethod, 1, 1);
			}

			// 枠描画
			if (e.Control && e.KeyCode == Keys.F)
			{
				EditMethod = DrawFrame;
				CheckPicture(EditMethod, 1, 1);
			}

			// 矩形ライン描画
			if (e.Control && e.KeyCode == Keys.Q)
			{
				EditMethod = DrawQuad;
				CheckPicture(EditMethod, 1, 1);
			}

			// ライン描画
			if (e.Control && e.KeyCode == Keys.L)
			{
				ChangeLineMode();
			}

			// Undo/Redo
			if (e.Control && e.KeyCode == Keys.Z)
			{
				Undo();
			}

			// コピー
			if (e.Control && e.KeyCode == Keys.C)
			{
				CopyToClipboard();
			}

			// 保存
			if (e.Control && e.KeyCode == Keys.S)
			{
				SavePicture();
			}

			// 閉じる
			if (e.Control && e.KeyCode == Keys.W)
			{
				EditMethod = ClosePicture;
				CheckPicture(EditMethod, 1, 1);
			}
		}

		//******************************//
		//								//
		//		　 　　関数		　		//
		//								//
		//******************************//

		private void ViewCaptureFrame()
		{
			// 矩形選択フォームの存在チェック
			if (frame != null) // ある場合
			{
				// 矩形選択フォームを閉じる
				frame.Close();

				frame = null;
			}
			else // 無い場合
			{
				// 矩形選択フォームを作成
				frame = new FrameForm();

				frame.ShowInTaskbar = false;			// タスクバーに表示させない
				frame.FrameBorderSize = capLineBorder;	// 線の太さ
				frame.FrameColor = capLineColor;		// 線の色
				frame.AllowedTransform = true;			// サイズ変更の可否
				frame.TopMost = true;					// 最前面に表示
				frame.Left = this.Left + capPosX;
				frame.Top = this.Top + capPosY;
				frame.Width = Settings.capFrameSizeX + (capLineBorder * 2); // 描画荒ぶる抑制用
				frame.Height = Settings.capFrameSizeY + (capLineBorder * 2); // 描画荒ぶる抑制用
				frame.StartPosition = FormStartPosition.Manual;

				frame.Show();

				frame.Width = Settings.capFrameSizeX + (capLineBorder * 2);
				frame.Height = Settings.capFrameSizeY + (capLineBorder * 2);
			}
		}

		private void GetPicture()
		{
			// frameフォームの存在チェック
			if (frame != null) // ある場合
			{
				// 矩形選択の背景を取得
				Image img = GetCaptureImage(new Rectangle(
									frame.Left + capLineBorder,
									frame.Top + capLineBorder,
									frame.Width - (capLineBorder * 2),
									frame.Height - (capLineBorder * 2)));

				// Undoのための画像バックアップ(Old)
				BackupImageOld();

				// PixtureBoxに表示
				pbDraw.Image = img;

				// Undoのための画像バックアップ(Now)
				BackupImageNow();

				// 選択範囲フラグOFF
				selecting = false;

				// ライン描画モード解除
				lineMode = false;

				// アイコン差し替え
				btnLine.BackgroundImage = Properties.Resources.icon_Line;

				// 矩形選択を閉じる
				//frame.Close();
			}
			else // 無い場合
			{
				//クリップボードにBitmapデータがあるか調べる
				if (Clipboard.ContainsImage())
				{
					//クリップボードにあるデータの取得
					Image img = Clipboard.GetImage();
					if (img != null)
					{
						// Undoのための画像バックアップ(Old)
						BackupImageOld();

						// PixtureBoxに表示
						pbDraw.Image = img;

						// Undoのための画像バックアップ(Now)
						BackupImageNow();

						// 選択範囲フラグOFF
						selecting = false;

						// ライン描画モード解除
						lineMode = false;

						// アイコン差し替え
						btnLine.BackgroundImage = Properties.Resources.icon_Line;
					}
				}
				else
				{
					MessageBox.Show("範囲選択するかクリップボードに画像を保存してください");
				}
			}
		}

		private void TrimPicture()
		{
			// 選択範囲が存在する時だけ処理
			if (selecting)
			{
				// 切り取るサイズをあらかじめ決めておく
				int sizeX = endPoint.X - staPoint.X;
				int sizeY = endPoint.Y - staPoint.Y;

				// 描画するImageオブジェクトを作成
				// サイズだけ指定すると無色透明のキャンバスになる
				Bitmap canvas = new Bitmap(sizeX, sizeY);
				//ImageオブジェクトのGraphicsオブジェクトを作成する
				g = Graphics.FromImage(canvas);

				// 画像のバックアップからImageを作成
				Bitmap img = new Bitmap(imgNow);

				// 切り取る範囲を決定
				Rectangle srcRect = new Rectangle(
					staPoint.X, staPoint.Y, sizeX, sizeY);
				// 描画の範囲を決定
				Rectangle desRect = new Rectangle(0, 0, srcRect.Width, srcRect.Height);

				// 画像の一部を描画
				g.DrawImage(img, desRect, srcRect, GraphicsUnit.Pixel);

				// リソースを解放
				g.Dispose();

				// PictureBoxに表示
				pbDraw.Image = canvas;
			}
			else
			{
				MessageBox.Show("画像内で選択範囲を作成してから実行してください。");
			}
		}

		private void DrawFrame()
		{
			// PictureBoxにある画像サイズでImageオブジェクトを作成する
			Bitmap canvas = new Bitmap(imgNow);

			// ImageオブジェクトのGraphicsオブジェクトを作成する
			Graphics g = Graphics.FromImage(canvas);

			// Penオブジェクトの作成
			SolidBrush sb = new SolidBrush(Settings.frameColor);
			int ib = Settings.frameBorder;

			// グレーの枠線を引く
			g.FillRectangle(sb, 0, 0,
							pbDraw.Width, ib); // 上辺

			g.FillRectangle(sb, 0, pbDraw.Height - ib,
							pbDraw.Width, ib); // 底辺

			g.FillRectangle(sb, 0, 0,
							ib, pbDraw.Height); // 左辺

			g.FillRectangle(sb, pbDraw.Width - ib, 0,
							ib, pbDraw.Height); //　右辺

			// リソースを解放する
			sb.Dispose();
			g.Dispose();

			// PictureBoxに表示する
			pbDraw.Image = canvas;
		}

		private void DrawQuad()
		{
			// 選択範囲が存在する時だけ処理
			if (selecting)
			{
				// 描画するImageオブジェクトを作成
				// サイズだけ指定すると無色透明のキャンバスになる
				Bitmap canvas = new Bitmap(imgNow);
				//ImageオブジェクトのGraphicsオブジェクトを作成する
				g = Graphics.FromImage(canvas);

				// Penオブジェクトの作成
				linePen = new Pen(Settings.lineColor, Settings.lineBorder);

				// スタイルを指定
				linePen.DashStyle = DashStyle.Solid;

				// 選択範囲の４頂点を代入
				initialize4Point();

				// ラインを描画
				g.DrawLine(linePen, p0, p1); // 上辺
				g.DrawLine(linePen, p2, p3); // 底辺
				g.DrawLine(linePen, p0, p2); // 左辺
				g.DrawLine(linePen, p1, p3); // 右辺

				// PictureBox1に表示
				pbDraw.Image = canvas;
			}
			else
			{
				MessageBox.Show("画像内で選択範囲を作成してから実行してください。");
			}
		}

		private void DrawLine(Bitmap canvas)
		{
			// 先にバックアップ画像で塗り潰す
			g.DrawImage(imgNow, 0, 0);

			// ラインを描画
			g.DrawLine(linePen, staPoint, endPoint);

			// PictureBox1に表示
			pbDraw.Image = canvas;
		}

		// 関数：選択範囲を描画
		private void DrawSelect(Bitmap canvas)
		{
			// ImageオブジェクトのGraphicsオブジェクトを作成
			g = Graphics.FromImage(bm);

			// 先にバックアップ画像で塗り潰す
			g.DrawImage(imgNow, 0, 0);

			// 選択範囲が画像の領域内に収まるようClamp
			posClamp();

			// 選択範囲の４頂点を代入
			initialize4Point();

			// ラインを描画
			g.DrawLine(linePen, p0, p1); // 上辺
			g.DrawLine(linePen, p2, p3); // 底辺
			g.DrawLine(linePen, p0, p2); // 左辺
			g.DrawLine(linePen, p1, p3); // 右辺

			// PictureBox1に表示
			pbDraw.Image = canvas;

			// リソースを解放
			// ドラッグ終了にも解放が入っているが毎フレーム解放した方が良さそう
			g.Dispose();
		}

		private void ChangeLineMode()
		{
			// PictureBoxにある画像の取得
			if (pbDraw.Image != null) // ある場合
			{
				// ライン描画モードの切り替えのみ行う
				if (lineMode)
				{
					lineMode = false;

					// アイコン差し替え
					btnLine.BackgroundImage = Properties.Resources.icon_Line;
				}
				else
				{
					lineMode = true;

					// アイコン差し替え
					btnLine.BackgroundImage = Properties.Resources.icon_Line_On;

					// PictureBoxに復元
					pbDraw.Image = imgNow;

					// 選択範囲フラグOFF
					selecting = false;
				}
			}
			else // 無い場合
			{
				MessageBox.Show("画像がありません。" + "\r\n" +
								"先に画像を取り込んでください。");
			}
		}

		private void Undo()
		{
			// 一時保存
			Image temp = imgOld;

			// バックアップ
			imgOld = imgNow;

			// バックアップ
			imgNow = temp;

			// PictureBoxに復元
			pbDraw.Image = imgNow;

			// 選択範囲フラグOFF
			selecting = false;
		}

		private void CopyToClipboard()
		{
			// Clipboardに画像をコピー
			Clipboard.SetImage(imgNow);
		}

		private void SavePicture()
		{
			// 現在時刻を取得
			DateTime dt = DateTime.Now;
			string s = dt.ToString("yyyyMMddHHmmss") + @".png";

			// PNGで指定先に出力
			imgNow.Save(Settings.outputPath + @"\" + s,
				System.Drawing.Imaging.ImageFormat.Png);
		}

		private void ClosePicture()
		{
			// PixtureBoxをクリア
			pbDraw.Image = null;
		}

		private void OpenSetting()
		{
			// 設定フォームを作成
			var form = new FormSettings();

			// オーナーウィンドウの真ん中に表示
			form.StartPosition = FormStartPosition.Manual;
			form.Location = new Point(this.Location.X + 33, this.Location.Y + 70);
			// 設定フォームをタスクバーに表示しない
			form.ShowInTaskbar = false;

			try
			{
				// 設定フォームをモーダルで開いて何のボタンで終了したかを受け取る
				DialogResult result = form.ShowDialog();

				// OK ボタンで閉じたとき
				if (result == DialogResult.OK)
				{
					Settings.capFrameSizeX = int.Parse(form.tbCaptureSizeX.Text);
					Settings.capFrameSizeY = int.Parse(form.tbCaptureSizeY.Text);
					Settings.frameBorder = int.Parse(form.tbFrameBorder.Text);
					Settings.lineBorder = int.Parse(form.tbLineBorder.Text);
					Settings.frameColor = Color.FromArgb(
							byte.Parse(form.tbFrameColerR.Text),
							byte.Parse(form.tbFrameColerG.Text),
							byte.Parse(form.tbFrameColerB.Text));
					Settings.lineColor = Color.FromArgb(
							byte.Parse(form.tbLineColerR.Text),
							byte.Parse(form.tbLineColerG.Text),
							byte.Parse(form.tbLineColerB.Text));
					Settings.outputPath = form.tbOutputPath.Text;
					Settings.useArrow = form.cbArrow.Checked;

					// 設定を出力
					Settings.OutputSettings();
				}
			}
			catch (Exception)
			{

				MessageBox.Show("設定に失敗しました。" + "\r\n" +
								"空欄を指定した可能性があります。");
			}

			// Disposeでフォームを解放
			form.Dispose();
		}

		// 関数：Undoのための画像バックアップ(Old)
		private void BackupImageOld()
		{
			// 直近の画像の状態をバックアップ
			imgOld = imgNow;
		}

		// 関数：Undoのための画像バックアップ(Now)
		private void BackupImageNow()
		{
			// 今の画像の状態をバックアップ
			imgNow = pbDraw.Image;
		}

		// 関数：ツール上に画像があるかどうか判定してデリゲートを実行
		private void CheckPicture(EditPicture E, int i1, int i2)
		{
			// PictureBoxにある画像の取得
			if (pbDraw.Image != null) // ある場合
			{
				// Undoのための画像バックアップ(Old)
				if (i1 == 1)
				{
					BackupImageOld();
				}
				
				// 関数を実行
				E.Invoke();

				// Undoのための画像バックアップ(Now)
				if (i2 == 1)
				{
					BackupImageNow();
				}

				// 選択範囲フラグOFF
				selecting = false;

				// ライン描画モード解除
				lineMode = false;

				// アイコン差し替え
				btnLine.BackgroundImage = Properties.Resources.icon_Line;
			}
			else // 無い場合
			{
				MessageBox.Show("画像がありません。" + "\r\n" +
								"先に画像を取り込んでください。");
			}
		}

		// デリゲート：画像を編集する関数
		delegate void EditPicture();

		// 関数：枠線フォームを作成
		private Image GetCaptureImage(Rectangle rect)
		{
			// 指定された範囲と同サイズのBitmapを作成する
			Image img = new Bitmap(
							rect.Width,
							rect.Height);

			// Bitmapにデスクトップのイメージを描画する
			using (Graphics g = Graphics.FromImage(img))
			{
				g.CopyFromScreen(
					rect.X,
					rect.Y,
					0,
					0,
					rect.Size,
					CopyPixelOperation.SourceCopy);
			}

			return img;
		}

		// 関数：カーソル位置を取得
		private Point cursorPos()
		{
			// 画面座標でカーソルの位置を取得
			Point p = Cursor.Position;
			// 画面座標からコントロール上の座標に変換
			Point cp = pbDraw.PointToClient(p);

			return cp;
		}

		// 関数：カーソルの領域オーバーを修正
		private void posClamp()
		{
			// 領域オーバーを修正
			if (endPoint.X < 0) endPoint.X = 0;
			if (endPoint.Y < 0) endPoint.Y = 0;
			int w = pbDraw.Width - 1;
			int h = pbDraw.Height - 1;
			if (endPoint.X > w) endPoint.X = w;
			if (endPoint.Y > h) endPoint.Y = h;
		}

		// 関数：選択範囲の４頂点を代入
		private void initialize4Point()
		{
			p0 = new Point(staPoint.X, staPoint.Y); // 上辺
			p1 = new Point(endPoint.X, staPoint.Y); // 底辺
			p2 = new Point(staPoint.X, endPoint.Y); // 左辺
			p3 = new Point(endPoint.X, endPoint.Y); // 右辺
		}
	}

	//----------------------------------------------------------//
	// クラス：枠線フォームを作成								//
	//															//
	// こちらの解説記事をそのまま参考にさせていただいています	//
	// https://qiita.com/nobi1234/items/63fe34701827aac5850a	//
	//----------------------------------------------------------//
	public partial class FrameForm : Form
	{
		private static readonly Color PrimaryTransparencyKey = Color.White;
		private static readonly Color SecondaryTransparencyKey = Color.Black;

		/// <summary>
		/// 選択範囲の位置と範囲です。
		/// </summary>
		[Category("配置"), Description("選択範囲の位置と範囲です")]
		public Rectangle SelectedWindow
		{
			get
			{
				var rect = this.Bounds;
				rect.Inflate(_FrameBorderSize * -1, _FrameBorderSize * -1);
				return rect;
			}
		}

		private Color _FrameColor = Color.Red;
		/// <summary>
		/// フレームの色です
		/// </summary>
		[Category("表示"), Description("フレームの色です")]
		[DefaultValue(typeof(Color), "Red")]
		public Color FrameColor
		{
			get { return _FrameColor; }
			set
			{
				_FrameColor = value;
				if (_FrameColor == PrimaryTransparencyKey)
					this.TransparencyKey = SecondaryTransparencyKey;
				else
					this.TransparencyKey = PrimaryTransparencyKey;
				this.Refresh();
			}
		}

		private int _FrameBorderSize = 5;
		/// <summary>
		/// フレームの線の太さです
		/// </summary>
		[Category("表示"), Description("フレームの線の太さです")]
		[DefaultValue(5)]
		public int FrameBorderSize
		{
			get { return _FrameBorderSize; }
			set
			{
				_FrameBorderSize = value;
				this.Refresh();
			}
		}

		/// <summary>
		/// フレームの変形を許可します
		/// </summary>
		[Category("動作"), Description("フレームの変形を許可します")]
		[DefaultValue(true)]
		public bool AllowedTransform { get; set; } = true;

		Point mousePoint; //マウス位置の一時記憶

		// FrameFormのコンストラクタ
		public FrameForm()
		{
			FormBorderStyle = FormBorderStyle.None;
			this.TransparencyKey = PrimaryTransparencyKey;

			// キーイベントのために追加
			this.KeyDown += new KeyEventHandler(this.FrameForm_KeyDown);
		}

		/// <summary>
		/// 枠だけ残して透明にする
		/// </summary>
		/// <param name="g"></param>
		void draw(Graphics g)
		{
			var rct = this.ClientRectangle;
			g.FillRectangle(new SolidBrush(FrameColor), rct);
			rct.Inflate(FrameBorderSize * -1, FrameBorderSize * -1);
			g.FillRectangle(new SolidBrush(TransparencyKey), rct);
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);

			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
			{
				//位置を記憶する
				mousePoint = new Point(e.X, e.Y);
			}
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (AllowedTransform)
			{
				if (e.X > Width * 2 / 3 && e.Y > Height * 1 / 2) //カーソルが右下なら
					frameTransform(e);
				else
					frameMove(e);
			}
			else
				frameMove(e);

			base.OnMouseMove(e);
		}

		void frameMove(MouseEventArgs e)
		{
			Cursor = Cursors.SizeAll;

			if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
			{
				this.Left += e.X - mousePoint.X;
				this.Top += e.Y - mousePoint.Y;
			}
		}

		void frameTransform(MouseEventArgs e)
		{
			if (AllowedTransform)
			{
				Cursor = Cursors.SizeNWSE;

				if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
				{

					this.Width += e.X - mousePoint.X;
					mousePoint.X += e.X - mousePoint.X;

					this.Height += e.Y - mousePoint.Y;
					mousePoint.Y += e.Y - mousePoint.Y;
				}
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			draw(e.Graphics);
			base.OnPaint(e);
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			this.Refresh();
		}


		// イベント：ショートカットキー
		private void FrameForm_KeyDown(object sender, KeyEventArgs e)
		{
			// コピー
			if (e.Control && e.KeyCode == Keys.C)
			{
				// 矩形選択の背景を取得
				Image img = GetCaptureImage(new Rectangle(
									this.Left + 4,
									this.Top + 4,
									this.Width - (4 * 2),
									this.Height - (4 * 2)));

				// Clipboardに画像をコピー
				Clipboard.SetImage(img);
			}

			// Ctrlが押されている
			if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
			{
				// サイズ変更
				if (e.KeyCode == Keys.Up)
				{
					this.Height--;
				}
				if (e.KeyCode == Keys.Down)
				{
					this.Height++;
				}
				if (e.KeyCode == Keys.Left)
				{
					this.Width--;
				}
				if (e.KeyCode == Keys.Right)
				{
					this.Width++;
				}
			}
			else
			{
				// 移動
				if (e.KeyCode == Keys.Up)
				{
					this.Top--;
				}
				if (e.KeyCode == Keys.Down)
				{
					this.Top++;
				}
				if (e.KeyCode == Keys.Left)
				{
					this.Left--;
				}
				if (e.KeyCode == Keys.Right)
				{
					this.Left++;
				}
			}
		}

		// 関数：枠線フォームを作成
		private Image GetCaptureImage(Rectangle rect)
		{
			// 指定された範囲と同サイズのBitmapを作成する
			Image img = new Bitmap(
							rect.Width,
							rect.Height);

			// Bitmapにデスクトップのイメージを描画する
			using (Graphics g = Graphics.FromImage(img))
			{
				g.CopyFromScreen(
					rect.X,
					rect.Y,
					0,
					0,
					rect.Size,
					CopyPixelOperation.SourceCopy);
			}

			return img;
		}
	}
}
