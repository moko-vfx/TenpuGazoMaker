using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class FormResizePicture : Form
	{
		//******************************//
		//								//
		//		　 フォーム関係　		//
		//								//
		//******************************//

		int imageWidth;
		int imageHeight;

		// コンストラクタ
		public FormResizePicture(int w, int h)
		{
			InitializeComponent();

			imageWidth = w;
			imageHeight = h;
		}

		// 起動時に実行
		private void FormResizePicture_Load(object sender, EventArgs e)
		{
			ChangeLanguage();

			cbRockWidth.Checked = Settings.resizeRockWidth;
			cbRockHeight.Checked = Settings.resizeRockHeight;
			cbLink.Checked = Settings.resizeLink;

			// 連動あり
			if (cbLink.Checked)
			{
				// W・H どちらもON（完全固定）
				if (cbRockWidth.Checked && cbRockHeight.Checked)
				{
					tbWidth.Text = Settings.resizeWidth.ToString();
					tbHeight.Text = Settings.resizeHeight.ToString();
				}
				// W は固定（HはWに合わせて自動入力）
				else if (cbRockWidth.Checked && !cbRockHeight.Checked)
				{
					tbWidth.Text = Settings.resizeWidth.ToString();

					double d1 = double.Parse(tbWidth.Text) / (double)imageWidth;
					double d2 = (double)imageHeight * d1;

					tbHeight.Text = Math.Ceiling(d2).ToString();
				}
				else if (!cbRockWidth.Checked && cbRockHeight.Checked)
				{
					tbHeight.Text = Settings.resizeHeight.ToString();

					double d1 = double.Parse(tbHeight.Text) / (double)imageHeight;
					double d2 = (double)imageWidth * d1;

					tbWidth.Text = Math.Ceiling(d2).ToString();
				}
				else
				{
					tbWidth.Text = imageWidth.ToString();
					tbHeight.Text = imageHeight.ToString();
				}
			}
			else // 連動なし
			{
				if (cbRockWidth.Checked)
				{
					tbWidth.Text = Settings.resizeWidth.ToString();
				}
				else
				{
					tbWidth.Text = imageWidth.ToString();
				}

				if (cbRockHeight.Checked)
				{
					tbHeight.Text = Settings.resizeHeight.ToString();
				}
				else
				{
					tbHeight.Text = imageHeight.ToString();
				}
			}
		}

		//******************************//
		//								//
		//		　　 メソッド	　		//
		//								//
		//******************************//

		// 関数：ツールチップの言語切り替え
		private void ChangeLanguage()
		{
			if (Settings.useEnglish)
			{
				toolTip1.SetToolTip(tbWidth,
					"Specify the width of the width.");

				toolTip1.SetToolTip(tbHeight,
					"Specify the width of the height.");

				toolTip1.SetToolTip(cbLink,
					"Preserves the aspect ratio.");

				toolTip1.SetToolTip(cbRockWidth,
					"Fixes the width of the width.");

				toolTip1.SetToolTip(cbRockHeight,
					"Fixes the width of the column.");
			}
			else
			{
				toolTip1.SetToolTip(tbWidth,
					"ヨコ幅を指定してください。");

				toolTip1.SetToolTip(tbHeight,
					"タテ幅を指定してください。");

				toolTip1.SetToolTip(cbLink,
					"縦横比を保持します。");

				toolTip1.SetToolTip(cbRockWidth,
					"ヨコ幅の指定を固定します。");

				toolTip1.SetToolTip(cbRockHeight,
					"タテ幅の指定を固定します。");
			}
		}

		// 比率を計算
		private void CulcRetio(TextBox myTb, TextBox otherTb, CheckBox otherChkBox, int myImg, int otherImg)
		{
			// 連動あり
			if (cbLink.Checked)
			{
				// ロックされていない
				if (!otherChkBox.Checked)
				{
					double d1 = double.Parse(myTb.Text) / (double)myImg;
					double d2 = (double)otherImg * d1;

					otherTb.Text = Math.Ceiling(d2).ToString();
				}
			}
		}

		// キー入力時の処理
		private bool WhenKeyPress(KeyPressEventArgs e, TextBox tb)
		{
			// Enterキーでビープ音が鳴らないようにして選択状態にする
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;

				if (tb.Text == "0")
				{
					MessageBox.Show("１以上の値を入力してください");

					tb.SelectAll();
					return (false);
				}
				else
				{
					// ゼロパティングを打ち消す
					string s = tb.Text;
					tb.Text = s.TrimStart((char)'0');

					tb.SelectAll();
					return (true);
				}
			}
			else
			{
				// 0～9と、バックスペース以外の時は、イベントをキャンセルする
				if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
				{
					e.Handled = true;
				}

				return (false);
			}
		}

		// Rockが２つともONならLinkは解除する
		private void cbCheck()
		{
			if (cbRockWidth.Checked && cbRockHeight.Checked)
			{
				cbLink.Checked = false;
			}
		}

		//******************************//
		//								//
		//		　　 イベント	　		//
		//								//
		//******************************//

		private void tbWidth_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (WhenKeyPress(e, tbWidth))
			{
				CulcRetio(tbWidth, tbHeight, cbRockHeight, imageWidth, imageHeight);
			}
		}

		private void tbHeight_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (WhenKeyPress(e, tbHeight))
			{
				CulcRetio(tbHeight, tbWidth, cbRockWidth, imageHeight, imageWidth);
			}
		}

		// アクティブになったら選択状態
		private void tbWidth_Enter(object sender, EventArgs e)
		{
			tbWidth.SelectAll();
		}
		private void tbHeight_Enter(object sender, EventArgs e)
		{
			tbHeight.SelectAll();
		}

		// フォーカスが移った際に実行
		private void tbWidth_Leave(object sender, EventArgs e)
		{
			if (tbWidth.Text == "0")
			{
				MessageBox.Show("１以上の値を入力してください");

				// フォーカスを戻す必要がある
				tbWidth.Select();
			}
			else
			{
				// ゼロパティングを打ち消す
				string s = tbWidth.Text;
				tbWidth.Text = s.TrimStart((char)'0');

				CulcRetio(tbWidth, tbHeight, cbRockHeight, imageWidth, imageHeight);
			}
		}
		private void tbHeight_Leave(object sender, EventArgs e)
		{
			if (tbHeight.Text == "0")
			{
				MessageBox.Show("１以上の値を入力してください");

				// フォーカスを戻す必要がある
				tbHeight.Select();
			}
			else
			{
				// ゼロパティングを打ち消す
				string s = tbHeight.Text;
				tbHeight.Text = s.TrimStart((char)'0');

				CulcRetio(tbHeight, tbWidth, cbRockWidth, imageHeight, imageWidth);
			}
		}

		// Escキーでフォームを閉じる
		private void FormResizePicture_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		// Rockが２つともONならLinkは解除する
		private void cbRockWidth_CheckedChanged(object sender, EventArgs e)
		{
			cbCheck();
		}
		private void cbRockHeight_CheckedChanged(object sender, EventArgs e)
		{
			cbCheck();
		}
	}
}
