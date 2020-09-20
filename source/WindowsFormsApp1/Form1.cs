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
		// 変数：フォーム
		FrameForm frame;
		FormRightClick miniSettingsForm;

		// 変数：キャプチャ用の枠線
		int capLineBorder = 4;
		Color capLineColor = Color.FromArgb(255, 40, 40);
		int capPosX = 30;
		int capPosY = 87;

		// 変数：デリゲート
		EditPicture EditMethod;

		// 変数：Undo/Redo用のバッファ
		Image imgOld = null;
		Image imgNow = null;

		// 変数：パンツール
		bool isDragging = false;
		bool isDrawingLine = false;
		bool isPan = false;
		bool downSpaceKey = false;
		Point posStart;

		// 変数：選択範囲の描画
		bool lineMode = false;
		bool selecting = false;

		Point staPoint;
		Point endPoint;
		Point p0, p1, p2, p3;

		Color selectColor = Color.FromArgb(220, 80, 40);
		int selectBorder = 2;
		Bitmap bm;
		Graphics g;
		Pen linePen;


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

			// カラーラベルに色を反映
			RefreshColor();

			// ツールチップに言語を反映
			ChangeLanguage();

			// PictureBoxにドラッグ＆ドロップを許可
			pbDraw.AllowDrop = true;
			//pbLine.AllowDrop = true;

			// ライン描画PictureBoxの親を背景PictureBoxに設定
			pbLine.Parent = pbDraw;

			// ミニ設定フォームのオブジェクトを生成
			miniSettingsForm = new FormRightClick();
			// ミニ設定フォームをタスクバーに表示しない
			miniSettingsForm.ShowInTaskbar = false;
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

		// ボタン：デスクトップのキャプチャフレーム表示
		private void BtnCapture_Click(object sender, EventArgs e)
		{
			ViewCaptureFrame();

			// ボタンを押した後にスペースキーでボタンをクリックさせない対処
			ActiveControl = null;
		}

		// ボタン：画像の表示
		private void BtnView_Click(object sender, EventArgs e)
		{
			GetPicture();

			// ボタンを押した後にスペースキーでボタンをクリックさせない対処
			ActiveControl = null;
		}

		// ボタン：選択範囲をトリミング
		private void BtnTrim_Click(object sender, EventArgs e)
		{
			EditMethod = TrimPicture;
			CheckPicture(EditMethod, 1, 1, true);

			// ボタンを押した後にスペースキーでボタンをクリックさせない対処
			ActiveControl = null;
		}
		
		// ボタン：枠線描画
		private void BtnFrame_Click(object sender, EventArgs e)
		{
			EditMethod = DrawFrame;
			CheckPicture(EditMethod, 1, 1, false);

			// ボタンを押した後にスペースキーでボタンをクリックさせない対処
			ActiveControl = null;
		}

		// ボタン：矩形ライン描画
		private void BtnQuad_Click(object sender, EventArgs e)
		{
			EditMethod = DrawQuad;
			CheckPicture(EditMethod, 1, 1, true);

			// ボタンを押した後にスペースキーでボタンをクリックさせない対処
			ActiveControl = null;
		}
		
		// ボタン：ライン描画
		private void BtnLine_Click(object sender, EventArgs e)
		{
			ChangeLineMode();

			// ボタンを押した後にスペースキーでボタンをクリックさせない対処
			ActiveControl = null;
		}

		// ボタン：画像サイズ変更
		private void btnScale_Click(object sender, EventArgs e)
		{
			EditMethod = ScalePicture;
			CheckPicture(EditMethod, 1, 1, false);

			// ボタンを押した後にスペースキーでボタンをクリックさせない対処
			ActiveControl = null;
		}

		// ボタン：アンドゥ/リドゥ
		private void BtnUndo_Click(object sender, EventArgs e)
		{
			Undo();

			// ボタンを押した後にスペースキーでボタンをクリックさせない対処
			ActiveControl = null;
		}

		// ボタン：画像をクリップボードにコピー
		private void BtnCopy_Click(object sender, EventArgs e)
		{
			CopyToClipboard();

			// ボタンを押した後にスペースキーでボタンをクリックさせない対処
			ActiveControl = null;
		}

		// ボタン：画像を保存
		private void BtnSave_Click(object sender, EventArgs e)
		{
			SavePicture();

			// ボタンを押した後にスペースキーでボタンをクリックさせない対処
			ActiveControl = null;
		}

		// ボタン：画像を閉じる
		private void BtnClose_Click(object sender, EventArgs e)
		{
			EditMethod = ClosePicture;
			CheckPicture(EditMethod, 1, 1, true);

			// ボタンを押した後にスペースキーでボタンをクリックさせない対処
			ActiveControl = null;
		}

		// ボタン：設定
		private void BtnSetting_Click(object sender, EventArgs e)
		{
			OpenSetting();

			// ボタンを押した後にスペースキーでボタンをクリックさせない対処
			ActiveControl = null;
		}

		//******************************//
		//								//
		//		　 　 マウス	　		//
		//								//
		//******************************//

		// マウス：ドラッグ開始
		private void PbLine_MouseDown(object sender, MouseEventArgs e)
		{
			// マウス右クリックが押された場合
			if (MouseButtons.Right == e.Button)
			{
				// カーソルの近くに表示
				miniSettingsForm.StartPosition = FormStartPosition.Manual;
				miniSettingsForm.Location = new Point(
					Cursor.Position.X - 55, Cursor.Position.Y - 23);

				// 最前面に表示
				miniSettingsForm.TopMost = true;

				// ミニ設定フォームを表示
				miniSettingsForm.Show();

				// アクティブにする
				miniSettingsForm.Activate();
			}
			else
			{
				// PictureBoxに画像がある場合
				if (pbDraw.Image != null)
				{
					// スペースキーを押している時（パン）
					if (downSpaceKey)
					{
						isDragging = true;
						posStart = e.Location;
						isPan = true;
					}
					// スペースキーを押していない時
					else
					{
						// スペースキーを押しても反応が無いようにする
						isDrawingLine = true;

						// 座標を保存
						staPoint.X = cursorPos().X;
						staPoint.Y = cursorPos().Y;

						// 描画するImageオブジェクトを作成
						// サイズだけ指定すると無色透明のキャンバスになる
						bm = new Bitmap(pbDraw.Width, pbDraw.Height);

						// ImageオブジェクトのGraphicsオブジェクトを作成
						g = Graphics.FromImage(bm);

						// ライン描画モード時
						if (lineMode)
						{
							// ドラッグしなかった時のために一旦座標を取得
							endPoint.X = cursorPos().X;
							endPoint.Y = cursorPos().Y;

							// Undoのための画像バックアップ(Old)
							BackupImageOld();

							// Penオブジェクトの作成
							linePen = new Pen(Settings.lineColor, Settings.lineBorder);

							// 矢印設定を判定
							if (Settings.useArrow)
							{
								int i = Settings.lineBorder;

								// ラインに矢印を設定する
								linePen.CustomEndCap = new AdjustableArrowCap(3, 3);
							}
							else
							{
								// ラインの矢印を除去する
								linePen.EndCap = LineCap.NoAnchor;
							}

							// スタイルを指定
							linePen.DashStyle = DashStyle.Solid;
						}
						// 選択範囲モード時
						else
						{
							// Penオブジェクトの作成
							linePen = new Pen(selectColor, selectBorder);

							// スタイルを指定
							linePen.DashStyle = DashStyle.Dot;
						}
					}
				}
			}
		}

		// マウス：ドラッグ中
		private void PbLine_MouseMove(object sender, MouseEventArgs e)
		{
			// PictureBoxに画像がある場合
			if (pbDraw.Image != null)
			{
				// スペースキーを押している時（パン）
				if (isDragging && downSpaceKey)
				{
					Point pos = new Point(
					e.Location.X - posStart.X,
					e.Location.Y - posStart.Y);

					pnlBottom.AutoScrollPosition = new Point(
						-pnlBottom.AutoScrollPosition.X - pos.X,
						-pnlBottom.AutoScrollPosition.Y - pos.Y);
				}
				// スペースキーを押していない時
				else
				{
					if (isPan == false)
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
								DrawLine();
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
								DrawSelect();
							}
						}
					}
				}
			}
		}

		// マウス：ドラッグ終了
		private void PbLine_MouseUp(object sender, MouseEventArgs e)
		{
			// PictureBoxに画像がある場合
			if (pbDraw.Image != null)
			{
				// スペースキーを押している時
				if (isDragging)
				{
					isDragging = false;
					isPan = false;
				}
				// スペースキーを押していない時
				else
				{
					// ライン描画モード時
					if (lineMode)
					{
						// 先にバックアップ画像で塗り潰す
						g.DrawImage(imgNow, 0, 0);

						// 今だけアンチエイリアスに設定
						g.SmoothingMode = SmoothingMode.AntiAlias;

						// ラインを描画
						g.DrawLine(linePen, staPoint, endPoint);

						// アンチエイリアス無しに戻す
						g.SmoothingMode = SmoothingMode.None;

						// ライン描画PictureBoxに表示
						pbDraw.Image = bm;

						// Undoのための画像バックアップ(Now)
						BackupImageNow();

						// 選択範囲の描画をクリア
						pbLine.Image = null;
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

					// スペースキーを押せるようライン描画終了を明示
					isDrawingLine = false;
				}
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

				// 選択範囲やライン描画周りの片付け
				CleanDrawSettings(true);
			}
			catch (Exception)
			{
				if (Settings.useEnglish)
				{
					MessageBox.Show(
						"Failed to drag & drop the image.\r\n" +
						"Please check the image is a popular format.");
				}
				else
				{
					MessageBox.Show(
						"ドラッグ＆ドロップに失敗しました\r\n" +
						"一般的な画像ファイルかご確認ください");
				}
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

				// 選択範囲やライン描画周りの片付け
				CleanDrawSettings(true);
			}
			catch (Exception)
			{
				if (Settings.useEnglish)
				{
					MessageBox.Show(
						"Failed to drag & drop the image.\r\n" +
						"Please check the image is a popular format.");
				}
				else
				{
					MessageBox.Show(
						"ドラッグ＆ドロップに失敗しました\r\n" +
						"一般的な画像ファイルかご確認ください");
				}
			}
		}

		// イベント：PixtureBox1のサイズが変わったタイミング
		private void PbDraw_SizeChanged(object sender, EventArgs e)
		{
			// PixtureBox1のサイズを表示
			lblSize.Text = "Image Size : W " +
				pbDraw.Width.ToString() + " / H " +
				pbDraw.Height.ToString();

			// ライン描画PictureBoxを同じサイズにする
			pbLine.Width = pbDraw.Width;
			pbLine.Height = pbDraw.Height;
		}


		//******************************//
		//								//
		//		　ショートカット		//
		//								//
		//******************************//

		// 全てのショートカットをフォームが受け取って実行する
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			// キャプチャフレームの表示
			if (e.Control && e.KeyCode == Keys.A)
			{
				ViewCaptureFrame();
			}

			// キャプチャフレームから画像を取り込む
			if (e.Control && e.KeyCode == Keys.D)
			{
				GetPicture();
			}

			// クリップボードから画像を取り込む
			if (e.Control && e.KeyCode == Keys.V)
			{
				GetPicFromCB();
			}

			// トリミング
			if (e.Control && e.KeyCode == Keys.T)
			{
				EditMethod = TrimPicture;
				CheckPicture(EditMethod, 1, 1, true);
			}

			// 枠描画
			if (e.Control && e.KeyCode == Keys.F)
			{
				EditMethod = DrawFrame;
				CheckPicture(EditMethod, 1, 1, false);
			}

			// 矩形ライン描画
			if (e.Control && e.KeyCode == Keys.Q)
			{
				EditMethod = DrawQuad;
				CheckPicture(EditMethod, 1, 1, true);
			}

			// ライン描画
			if (e.Control && e.KeyCode == Keys.L)
			{
				ChangeLineMode();
			}

			// 画像サイズ変更
			if (e.Control && e.KeyCode == Keys.R)
			{
				EditMethod = ScalePicture;
				CheckPicture(EditMethod, 1, 1, false);
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
				CheckPicture(EditMethod, 1, 1, true);
			}

			// 設定を開く
			if (e.KeyCode == Keys.Escape)
			{
				OpenSetting();
			}

			// スペースキーを押した時
			if (e.KeyCode == Keys.Space)
			{
				// 画像が存在してライン描画中じゃない場合は手のひらカーソルにする
				if (pbDraw != null && isDrawingLine == false)
				{
					pbDraw.Cursor = Cursors.Hand;
					downSpaceKey = true;
				}
			}
		}

		// スペースキーを離した時専用
		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			// 画像が存在してライン描画中じゃない場合は手のひらカーソルを解除する
			if (pbDraw != null && isDrawingLine == false && downSpaceKey == true)
			{
				if (lineMode)
				{
					// カーソルを十字型に変える
					pbDraw.Cursor = Cursors.Cross;
					downSpaceKey = false;
				}
				else
				{
					pbDraw.Cursor = Cursors.Default;
					downSpaceKey = false;
				}
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

		// キャプチャフレームから取り込み
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

				// 選択範囲やライン描画周りの片付け
				CleanDrawSettings(true);
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

						// 選択範囲やライン描画周りの片付け
						CleanDrawSettings(true);
					}
				}
				else
				{
					if (Settings.useEnglish)
					{
						MessageBox.Show(
							"Please show the capture frame\r\n" +
							"and position for capturing.");
					}
					else
					{
						MessageBox.Show("キャプチャ枠を表示して取り込み先を決めてください");
					}
				}
			}
		}

		// クリップボードから取り込み
		private void GetPicFromCB()
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

					// 選択範囲やライン描画周りの片付け
					CleanDrawSettings(true);
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
				Graphics g2 = Graphics.FromImage(canvas);

				// 画像のバックアップからImageを作成
				Bitmap img = new Bitmap(imgNow);

				// 切り取る範囲を決定
				Rectangle srcRect = new Rectangle(
					staPoint.X, staPoint.Y, sizeX, sizeY);
				// 描画の範囲を決定
				Rectangle desRect = new Rectangle(0, 0, srcRect.Width, srcRect.Height);

				// 画像の一部を描画
				g2.DrawImage(img, desRect, srcRect, GraphicsUnit.Pixel);

				// リソースを解放
				g2.Dispose();

				// PictureBoxに表示
				pbDraw.Image = canvas;
			}
			else
			{
				if (Settings.useEnglish)
				{
					MessageBox.Show("Please click after making the selection on the image.");
				}
				else
				{
					MessageBox.Show("画像内で選択範囲を作成してから実行してください。");
				}
			}
		}

		private void DrawFrame()
		{
			// PictureBoxにある画像サイズでImageオブジェクトを作成する
			Bitmap canvas = new Bitmap(imgNow);

			// ImageオブジェクトのGraphicsオブジェクトを作成する
			Graphics g2 = Graphics.FromImage(canvas);

			// Penオブジェクトの作成
			SolidBrush sb = new SolidBrush(Settings.frameColor);
			int ib = Settings.frameBorder;

			// グレーの枠線を引く
			g2.FillRectangle(sb, 0, 0,
							pbDraw.Width, ib); // 上辺

			g2.FillRectangle(sb, 0, pbDraw.Height - ib,
							pbDraw.Width, ib); // 底辺

			g2.FillRectangle(sb, 0, 0,
							ib, pbDraw.Height); // 左辺

			g2.FillRectangle(sb, pbDraw.Width - ib, 0,
							ib, pbDraw.Height); //　右辺

			// リソースを解放する
			sb.Dispose();
			g2.Dispose();

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
				Graphics g2 = Graphics.FromImage(canvas);

				// 選択範囲の４頂点を代入
				initialize4Point();

				// Penオブジェクトの作成
				SolidBrush sb = new SolidBrush(Settings.lineColor);
				int ib = Settings.lineBorder;

				int w = p1.X - p0.X; // 幅
				int h = p2.Y - p0.Y; // 高さ

				// グレーの枠線を引く
				g2.FillRectangle(sb, p0.X, p0.Y, w, ib);		// 上辺
				g2.FillRectangle(sb, p0.X, p2.Y - ib, w, ib);	// 底辺
				g2.FillRectangle(sb, p0.X, p0.Y, ib, h);		// 左辺
				g2.FillRectangle(sb, p1.X - ib, p0.Y, ib, h);	//　右辺

				// リソースを解放
				sb.Dispose();
				g2.Dispose();

				// PictureBox1に表示
				pbDraw.Image = canvas;
			}
			else
			{
				if (Settings.useEnglish)
				{
					MessageBox.Show("Please click after making the selection on the image.");
				}
				else
				{
					MessageBox.Show("画像内で選択範囲を作成してから実行してください。");
				}
			}
		}

		private void DrawLine()
		{
			// 前回のライン描画を一旦クリア
			g.Clear(Color.Transparent);

			// ラインを描画
			g.DrawLine(linePen, staPoint, endPoint);

			// ライン描画PictureBoxに表示
			pbLine.Image = bm;
		}

		// 関数：選択範囲を描画
		private void DrawSelect()
		{
			// 前回のライン描画を一旦クリア
			g.Clear(Color.Transparent);

			// 選択範囲が画像の領域内に収まるようClamp
			posClamp();

			// 選択範囲の４頂点を代入
			initialize4Point();

			// ラインを描画
			g.DrawLine(linePen, p0, p1); // 上辺
			g.DrawLine(linePen, p2, p3); // 底辺
			g.DrawLine(linePen, p0, p2); // 左辺
			g.DrawLine(linePen, p1, p3); // 右辺

			// ライン描画PictureBoxに表示
			pbLine.Image = bm;
		}

		// 関数：ライン描画モード変更
		private void ChangeLineMode()
		{
			// PictureBoxにある画像の取得
			if (pbDraw.Image != null) // ある場合
			{
				// ライン描画モードの切り替えのみ行う
				if (lineMode) // ON → OFF
				{
					LineModeOff();
				}
				else // OFF → ON
				{
					lineModeOn();
				}
			}
			else // 無い場合
			{
				if (Settings.useEnglish)
				{
					MessageBox.Show(
						"No image on this tool.\r\n" +
						"First of all, please capture an image.");
				}
				else
				{
					MessageBox.Show(
						"画像がありません\r\n" +
						"先に画像を取り込んでください");
				}
			}
		}
		// ライン描画モードON
		private void lineModeOn()
		{
			lineMode = true;

			// アイコン「ON」
			btnLine.BackgroundImage = Properties.Resources.icon_LineMode;

			// 選択範囲フラグOFF
			selecting = false;

			// 選択範囲の描画をクリア
			pbLine.Image = null;

			// カーソルを十字型に変える
			pbDraw.Cursor = Cursors.Cross;
		}
		// ライン描画モードOFF
		private void LineModeOff()
		{
			lineMode = false;

			// アイコン「OFF」
			btnLine.BackgroundImage = Properties.Resources.icon_Line;

			// カーソルを元に戻す
			pbDraw.Cursor = Cursors.Default;
		}

		// 画像サイズ変更
		private void ScalePicture()
		{
			// ミニ設定フォームを隠す
			miniSettingsForm.Hide();

			int w = imgNow.Width;
			int h = imgNow.Height;

			// 設定フォームを作成
			var form = new FormResizePicture(w, h);

			// オーナーウィンドウの真ん中に表示
			form.StartPosition = FormStartPosition.Manual;
			form.Location = new Point(this.Location.X + 80, this.Location.Y + 85);
			// 設定フォームをタスクバーに表示しない
			form.ShowInTaskbar = false;

			// 設定フォームをモーダルで開いて何のボタンで終了したかを受け取る
			DialogResult result = form.ShowDialog();

			// OK ボタンで閉じたとき
			if (result == DialogResult.OK)
			{
				Settings.resizeWidth = int.Parse(form.tbWidth.Text);
				Settings.resizeHeight = int.Parse(form.tbHeight.Text);
				Settings.resizeRockWidth = form.cbRockWidth.Checked;
				Settings.resizeRockHeight = form.cbRockHeight.Checked;
				Settings.resizeLink = form.cbLink.Checked;

				int newW = Settings.resizeWidth;
				int newH = Settings.resizeHeight;

				// 設定を出力
				Settings.OutputSettings();

				// 画像のリサイズ処理
				try
				{
					// PictureBoxにある画像サイズでImageオブジェクトを作成する
					Bitmap canvas = new Bitmap(imgNow, newW, newH);

					// ImageオブジェクトのGraphicsオブジェクトを作成する
					Graphics g = Graphics.FromImage(canvas);

					//補間方法として高品質双三次補間を指定する
					g.InterpolationMode = InterpolationMode.HighQualityBicubic;
					//画像を縮小して描画する
					g.DrawImage(imgNow, 0, 0, newW, newH);

					// リソースを解放する
					g.Dispose();

					// PictureBoxに表示する
					pbDraw.Image = canvas;
				}
				catch (Exception)
				{
					if (Settings.useEnglish)
					{
						MessageBox.Show("You failed to change the image size.");
					}
					else
					{
						MessageBox.Show("画像サイズの変更に失敗しました。");
					}
				}
			}

			// Disposeでフォームを解放
			form.Dispose();
		}

		private void Undo()
		{
			// 一時保存
			Image temp = imgOld; // tempを解放してはいけない（エラーが出る）

			// バックアップ
			imgOld = imgNow;

			// バックアップ
			imgNow = temp;

			// PictureBoxに復元
			pbDraw.Image = imgNow;

			// 選択範囲フラグOFF
			selecting = false;

			// 選択範囲の描画をクリア
			pbLine.Image = null;
		}

		private void CopyToClipboard()
		{
			// Clipboardに画像をコピー
			Clipboard.SetImage(imgNow);
		}

		private void SavePicture()
		{
			// PictureBoxにある画像の取得
			if (pbDraw.Image != null) // ある場合
			{
				// 現在時刻を取得
				DateTime dt = DateTime.Now;
				string s = dt.ToString("yyyyMMddHHmmss") + @".png";

				// PNGで指定先に出力
				imgNow.Save(Settings.outputPath + @"\" + s,
					System.Drawing.Imaging.ImageFormat.Png);
			}
			else // 無い場合
			{
				if (Settings.useEnglish)
				{
					MessageBox.Show(
						"No image on this tool.\r\n" +
						"First of all, please capture an image.");
				}
				else
				{
					MessageBox.Show(
						"画像がありません\r\n" +
						"先に画像を取り込んでください");
				}
			}
		}

		private void ClosePicture()
		{
			// PixtureBoxをクリア
			pbDraw.Image = null;

			// ツール下部の画像サイズ表示を無しにする
			ResetSize();
		}

		private void OpenSetting()
		{
			// ミニ設定フォームを隠す
			miniSettingsForm.Hide();

			// 設定フォームを作成
			var form = new FormSettings();

			// オーナーウィンドウの真ん中に表示
			form.StartPosition = FormStartPosition.Manual;
			form.Location = new Point(this.Location.X + 30, this.Location.Y + 50);
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
					Settings.useEnglish = form.rbEN.Checked;

					// 設定を出力
					Settings.OutputSettings();

					// カラーラベルに色を反映
					RefreshColor();

					// ツールチップに言語を反映
					ChangeLanguage();
				}
			}
			catch (Exception)
			{
				if (Settings.useEnglish)
				{
					MessageBox.Show(
						"Failed to set these parameters.\r\n" +
						"It's a high possibility that there is a blank parameter.");
				}
				else
				{
					MessageBox.Show(
						"設定に失敗しました\r\n" +
						"空欄を指定した可能性があります");
				}
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
		private void CheckPicture(EditPicture E, int i1, int i2, bool selectOff)
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

				// 選択範囲やライン描画周りの片付け
				CleanDrawSettings(selectOff);
			}
			else // 無い場合
			{
				if (Settings.useEnglish)
				{
					MessageBox.Show(
						"No image on this tool.\r\n" +
						"First of all, please capture an image.");
				}
				else
				{
					MessageBox.Show(
						"画像がありません\r\n" +
						"先に画像を取り込んでください");
				}
			}
		}

		// デリゲート：画像を編集する関数
		delegate void EditPicture();

		// 関数：選択範囲やライン描画周りの片付け
		private void CleanDrawSettings(bool selectOff)
		{
			// ライン描画モード解除
			lineMode = false;

			// ライン描画モードのアイコン差し替え
			btnLine.BackgroundImage = Properties.Resources.icon_Line;

			// カーソルをデフォルトに戻す
			pbDraw.Cursor = Cursors.Default;

			// 選択範囲を解除する場合
			if (selectOff)
			{
				// 選択範囲フラグOFF
				selecting = false;

				// 選択範囲の描画をクリア
				pbLine.Image = null;
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

		// 関数：カーソル位置を取得
		private Point cursorPos()
		{
			// 画面座標でカーソルの位置を取得
			Point p = Cursor.Position;
			// 画面座標からコントロール上の座標に変換
			Point cp = pbLine.PointToClient(p);

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

		// 関数：カラーラベルに色を反映
		private void RefreshColor()
		{
			pnlColor1.BackColor = Settings.frameColor;
			pnlColor2.BackColor = Settings.lineColor;
		}

		// 関数：ツールチップの言語切り替え
		private void ChangeLanguage()
		{
			if (Settings.useEnglish)
			{
				toolTip1.SetToolTip(btnCapture,
					"Show or hide the capture frame.\r\n" +
					"And you can change the frame size.\r\n" +
					"[ Ctrl + A ]");

				toolTip1.SetToolTip(btnView,
					"If the capture frame is shown,\r\n" +
					"you get background image in the frame.\r\n" +
					"[ Ctrl + D ]\r\n" +
					"\r\n" +
					"You can drop the image to this aplication.\r\n" +
					"In addition, You can paste the image from clipboard with Ctrl + V.");

				toolTip1.SetToolTip(btnTrim,
					"You can trim the image on this tool using the selection.\r\n" +
					"[ Ctrl + T ]");

				toolTip1.SetToolTip(btnFrame,
					"Draw line on the edge of the image.\r\n" +
					"You can change the color and border of line with the setting window.\r\n" +
					"[ Ctrl + F ]");

				toolTip1.SetToolTip(btnQuad,
					"Draw line on the edge of the selection.\r\n" +
					"You can change the color and border of line with the setting window.\r\n" +
					"[ Ctrl + Q ]");

				toolTip1.SetToolTip(btnLine,
					"Change the drawing line mode on this image or not.\r\n" +
					"You can change the color and border of line with the setting window.\r\n" +
					"[ Ctrl + L ]");

				toolTip1.SetToolTip(btnScale,
					"You can change the image size.\r\n" +
					"[ Ctrl + R ]");

				toolTip1.SetToolTip(btnUndo,
					"Undo your last editing the image.\r\n" +
					"[ Ctrl + Z ]");

				toolTip1.SetToolTip(btnCopy,
					"Paste the image on this tool to a clipboard.\r\n" +
					"[ Ctrl + C ]");

				toolTip1.SetToolTip(btnSave,
					"Save the image on this tool as a PNG file.\r\n" +
					"You can set the save location with the setting window.\r\n" +
					"[ Ctrl + S ]");

				toolTip1.SetToolTip(btnClose,
					"Clear the image on this tool.\r\n" +
					"[ Ctrl + W ]");

				toolTip1.SetToolTip(btnSetting,
					"Open the tool setting window.\r\n" +
					"[ Esc ]");
			}
			else
			{
				toolTip1.SetToolTip(btnCapture,
					"キャプチャするための枠を表示/非表示します。\r\n" +
					"枠は大きさを自由に変えられます。\r\n" +
					"[ Ctrl + A ]");

				toolTip1.SetToolTip(btnView,
					"キャプチャ枠を表示していれば枠内の背景をツールに取り込みます。\r\n" +
					"[ Ctrl + D ]\r\n" +
					"\r\n" +
					"画像を直接ドラッグ＆ドロップしてもOKです。\r\n" +
					"また、「Ctrl + V」でクリップボードの画像をツールに貼り付けます。");

				toolTip1.SetToolTip(btnTrim,
					"画像上の選択範囲をトリミングします。\r\n" +
					"[ Ctrl + T ]");

				toolTip1.SetToolTip(btnFrame,
					"取り込んだ画像の周囲に枠線を追加します。\r\n" +
					"色と幅は設定画面で指定できます。\r\n" +
					"[ Ctrl + F ]");

				toolTip1.SetToolTip(btnQuad,
					"画像上の選択範囲に枠線を描画します。\r\n" +
					"色と幅は設定画面で指定できます。\r\n" +
					"[ Ctrl + Q ]");

				toolTip1.SetToolTip(btnLine,
					"画像上でラインを引くモードになります。\r\n" +
					"色と幅は設定画面で指定できます。\r\n" +
					"[ Ctrl + L ]");

				toolTip1.SetToolTip(btnScale,
					"ツール上の画像のサイズを変更します。\r\n" +
					"[ Ctrl + R ]");

				toolTip1.SetToolTip(btnUndo,
					"ツール上の画像の編集に対してUndo/Redoします。\r\n" +
					"[ Ctrl + Z ]");

				toolTip1.SetToolTip(btnCopy,
					"ツール上の画像をクリップボードにコピーします。\r\n" +
					"[ Ctrl + C ]");

				toolTip1.SetToolTip(btnSave,
					"ツール上の画像をPNGで保存します。\r\n" +
					"保存先は設定画面で指定できます。\r\n" +
					"[ Ctrl + S ]");

				toolTip1.SetToolTip(btnClose,
					"ツール上の画像をクリアします。\r\n" +
					"[ Ctrl + W ]");

				toolTip1.SetToolTip(btnSetting,
					"設定画面を開きます。\r\n" +
					"[ Esc ]");
			}
		}

		// 関数：ツール下部の画像サイズ表示を無しにする
		private void ResetSize()
		{
			// PixtureBox1のサイズを表示
			lblSize.Text = "Image Size :";
		}


		//******************************//
		//								//
		//		　 アイコン変更	　		//
		//								//
		//******************************//

		private void BtnCapture_MouseEnter(object sender, EventArgs e)
		{
			btnCapture.BackgroundImage = Properties.Resources.icon_Capture_On;
		}
		private void BtnCapture_MouseLeave(object sender, EventArgs e)
		{
			btnCapture.BackgroundImage = Properties.Resources.icon_Capture;
		}

		private void BtnView_MouseEnter(object sender, EventArgs e)
		{
			btnView.BackgroundImage = Properties.Resources.icon_View_On;
		}
		private void BtnView_MouseLeave(object sender, EventArgs e)
		{
			btnView.BackgroundImage = Properties.Resources.icon_View;
		}

		private void BtnTrim_MouseEnter(object sender, EventArgs e)
		{
			btnTrim.BackgroundImage = Properties.Resources.icon_Trim_On;
		}
		private void BtnTrim_MouseLeave(object sender, EventArgs e)
		{
			btnTrim.BackgroundImage = Properties.Resources.icon_Trim;
		}

		private void BtnFrame_MouseEnter(object sender, EventArgs e)
		{
			btnFrame.BackgroundImage = Properties.Resources.icon_Frame_On;
		}
		private void BtnFrame_MouseLeave(object sender, EventArgs e)
		{
			btnFrame.BackgroundImage = Properties.Resources.icon_Frame;
		}

		private void BtnQuad_MouseEnter(object sender, EventArgs e)
		{
			btnQuad.BackgroundImage = Properties.Resources.icon_Quad_On;
		}
		private void BtnQuad_MouseLeave(object sender, EventArgs e)
		{
			btnQuad.BackgroundImage = Properties.Resources.icon_Quad;
		}

		private void BtnLine_MouseEnter(object sender, EventArgs e)
		{
			if (lineMode == false)
			{
				btnLine.BackgroundImage = Properties.Resources.icon_Line_On;
			}
		}
		private void BtnLine_MouseLeave(object sender, EventArgs e)
		{
			if (lineMode == false)
			{
				btnLine.BackgroundImage = Properties.Resources.icon_Line;
			}
		}

		private void btnScale_MouseEnter(object sender, EventArgs e)
		{
			btnScale.BackgroundImage = Properties.Resources.icon_Scale_On;
		}
		private void btnScale_MouseLeave(object sender, EventArgs e)
		{
			btnScale.BackgroundImage = Properties.Resources.icon_Scale;
		}

		private void BtnUndo_MouseEnter(object sender, EventArgs e)
		{
			btnUndo.BackgroundImage = Properties.Resources.icon_Undo_On;
		}
		private void BtnUndo_MouseLeave(object sender, EventArgs e)
		{
			btnUndo.BackgroundImage = Properties.Resources.icon_Undo;
		}

		private void BtnCopy_MouseEnter(object sender, EventArgs e)
		{
			btnCopy.BackgroundImage = Properties.Resources.icon_Copy_On;
		}
		private void BtnCopy_MouseLeave(object sender, EventArgs e)
		{
			btnCopy.BackgroundImage = Properties.Resources.icon_Copy;
		}

		private void BtnSave_MouseEnter(object sender, EventArgs e)
		{
			btnSave.BackgroundImage = Properties.Resources.icon_Save_On;
		}
		private void BtnSave_MouseLeave(object sender, EventArgs e)
		{
			btnSave.BackgroundImage = Properties.Resources.icon_Save;
		}

		private void BtnClose_MouseEnter(object sender, EventArgs e)
		{
			btnClose.BackgroundImage = Properties.Resources.icon_Close_On;
		}
		private void BtnClose_MouseLeave(object sender, EventArgs e)
		{
			btnClose.BackgroundImage = Properties.Resources.icon_Close;
		}

		private void BtnSetting_MouseEnter(object sender, EventArgs e)
		{
			btnSetting.BackgroundImage = Properties.Resources.icon_Set_On;
		}
		private void BtnSetting_MouseLeave(object sender, EventArgs e)
		{
			btnSetting.BackgroundImage = Properties.Resources.icon_Set;
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

			// 128*128サイズに縮小してコピー
			if (e.Control && e.KeyCode == Keys.X)
			{
				// 描画先とするImageオブジェクトを作成
				Bitmap canvas = new Bitmap(128, 128);
				// ImageオブジェクトのGraphicsオブジェクトを作成
				Graphics g = Graphics.FromImage(canvas);

				// 矩形選択の背景を取得
				Image img = GetCaptureImage(new Rectangle(
									this.Left + 4,
									this.Top + 4,
									this.Width - (4 * 2),
									this.Height - (4 * 2)));

				// 最近傍補間を指定
				g.InterpolationMode =InterpolationMode.HighQualityBilinear;
				// 画像を縮小
				g.DrawImage(img, 0, 0, 128, 128);

				// Clipboardに画像をコピー
				Clipboard.SetImage(canvas);

				// 解放
				img.Dispose();
				g.Dispose();
				canvas.Dispose();
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
