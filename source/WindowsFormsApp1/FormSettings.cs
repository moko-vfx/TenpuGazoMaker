using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class FormSettings : Form
	{
		//******************************//
		//								//
		//		　 フォーム関係　		//
		//								//
		//******************************//

		// コンストラクタ
		public FormSettings()
		{
			InitializeComponent();
		}

		// 起動時に実行
		private void FormSettings_Load(object sender, EventArgs e)
		{
			tbCaptureSizeX.Text = Settings.capFrameSizeX.ToString();
			tbCaptureSizeY.Text = Settings.capFrameSizeY.ToString();
			tbFrameBorder.Text = Settings.frameBorder.ToString();
			tbLineBorder.Text = Settings.lineBorder.ToString();
			tbFrameColerR.Text = Settings.frameColor.R.ToString();
			tbFrameColerG.Text = Settings.frameColor.G.ToString();
			tbFrameColerB.Text = Settings.frameColor.B.ToString();
			tbLineColerR.Text = Settings.lineColor.R.ToString();
			tbLineColerG.Text = Settings.lineColor.G.ToString();
			tbLineColerB.Text = Settings.lineColor.B.ToString();
			tbOutputPath.Text = Settings.outputPath;
			cbArrow.Checked = Settings.useArrow;
		}

		// フォルダ選択ダイアログを開いてパスを入力
		private void BtnOpenFolderDiag_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbDialog = new FolderBrowserDialog();

			// ダイアログの説明文
			fbDialog.Description = "Select Output Folder";

			// デフォルトのフォルダ
			if (Directory.Exists(tbOutputPath.Text))
			{
				fbDialog.SelectedPath = tbOutputPath.Text;
			}
			else
			{
				fbDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			}

			// 「新しいフォルダーの作成する」ボタンを表示する
			fbDialog.ShowNewFolderButton = true;

			//フォルダを選択するダイアログを表示する
			if (fbDialog.ShowDialog() == DialogResult.OK)
			{
				tbOutputPath.Text = fbDialog.SelectedPath;
			}

			fbDialog.Dispose();
		}

		//******************************//
		//								//
		//		　　 イベント	　		//
		//								//
		//******************************//

		// ショートカットキー
		private void FormSettings_KeyDown(object sender, KeyEventArgs e)
		{
			// Escキーで閉じる
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		// イベント：フォームを閉じようとした時に数値が０かをチェック
		private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
		{
			string s0 = tbCaptureSizeX.Text;
			string s1 = tbCaptureSizeY.Text;
			string s2 = tbFrameBorder.Text;
			string s3 = tbLineBorder.Text;
			string s4 = tbFrameColerR.Text;
			string s5 = tbFrameColerG.Text;
			string s6 = tbFrameColerB.Text;
			string s7 = tbLineColerR.Text;
			string s8 = tbLineColerG.Text;
			string s9 = tbLineColerB.Text;

			int i0 = int.Parse(s0);
			int i1 = int.Parse(s1);
			int i2 = int.Parse(s2);
			int i3 = int.Parse(s3);

			if (i0 == 0 || i1 == 0 || i2 == 0 || i3 == 0)
			{
				MessageBox.Show("サイズや幅の指定を０にはできません。");

				// 閉じるのをキャンセル
				e.Cancel = true;
			}
		}

		//******************************//
		//		　数字入力に制限　		//
		//******************************//

		private void TbLineColerB_KeyPress(object sender, KeyPressEventArgs e)
		{
			// 0～9と、バックスペース以外の時は、イベントをキャンセルする
			if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
			{
				e.Handled = true;
			}
		}

		private void TbFrameColerR_KeyPress(object sender, KeyPressEventArgs e)
		{
			// 0～9と、バックスペース以外の時は、イベントをキャンセルする
			if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
			{
				e.Handled = true;
			}
		}

		private void TbFrameColerG_KeyPress(object sender, KeyPressEventArgs e)
		{
			// 0～9と、バックスペース以外の時は、イベントをキャンセルする
			if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
			{
				e.Handled = true;
			}
		}

		private void TbFrameColerB_KeyPress(object sender, KeyPressEventArgs e)
		{
			// 0～9と、バックスペース以外の時は、イベントをキャンセルする
			if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
			{
				e.Handled = true;
			}
		}

		private void TbLineColerR_KeyPress(object sender, KeyPressEventArgs e)
		{
			// 0～9と、バックスペース以外の時は、イベントをキャンセルする
			if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
			{
				e.Handled = true;
			}
		}

		private void TbLineColerG_KeyPress(object sender, KeyPressEventArgs e)
		{
			// 0～9と、バックスペース以外の時は、イベントをキャンセルする
			if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
			{
				e.Handled = true;
			}
		}

		private void TbLineColerB_KeyPress_1(object sender, KeyPressEventArgs e)
		{
			// 0～9と、バックスペース以外の時は、イベントをキャンセルする
			if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
			{
				e.Handled = true;
			}
		}
	}
}
