using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class FormRightClick : Form
	{
		//******************************//
		//								//
		//		　 フォーム関係　		//
		//								//
		//******************************//

		// コンストラクタ
		public FormRightClick()
		{
			InitializeComponent();

			// 親フォームのマウスイベントハンドラの割り当て
			SetEventHandler(this);
		}

		//******************************//
		//								//
		//		　 　イベント	　		//
		//								//
		//******************************//

		/// <summary>
		/// 子コントロールにMouseイベントハンドラを設定(再帰)
		/// </summary>
		private void SetEventHandler(Control objControl)
		{
			// イベントの設定
			// こちらの記事を参考にさせていただきました
			// https://todosoft.net/blog/?p=336
			if (objControl != this)
			{
				objControl.MouseDown += (sender, e) => this.OnMouseDown(e);
				objControl.MouseMove += (sender, e) => this.OnMouseMove(e);
				objControl.MouseUp += (sender, e) => this.OnMouseUp(e);
			}

			// さらに子コントロールを検出する
			if (objControl.Controls.Count > 0)
			{
				foreach (Control objChildControl in objControl.Controls)
				{
					SetEventHandler(objChildControl);
				}
			}
		}


		// 起動時に実行
		private void FormSettings_Load(object sender, EventArgs e)
		{
			tbLineBorder.Text = Settings.lineBorder.ToString();
			cbArrow.Checked = Settings.useArrow;
		}

		// 値が変わった時
		private void TbLineBorder_ValueChanged(object sender, EventArgs e)
		{
			Settings.lineBorder = (int)tbLineBorder.Value;
		}

		// チェックON/OFFが変わった時
		private void CbArrow_CheckedChanged(object sender, EventArgs e)
		{
			Settings.useArrow = cbArrow.Checked;
		}

		// マウスカーソルがフォームから出た時
		private void FormRightClick_MouseLeave(object sender, EventArgs e)
		{
			// 設定を出力
			Settings.OutputSettings();

			// フォームを隠す
			this.Hide();
		}

		// ショートカット
		private void FormRightClick_KeyDown(object sender, KeyEventArgs e)
		{
			// Escキーで閉じる
			if (e.KeyCode == Keys.Escape)
			{
				// サウンドを消す
				e.SuppressKeyPress = true;

				// 設定を出力
				Settings.OutputSettings();

				// フォームを隠す
				this.Hide();
			}
		}
	}
}
