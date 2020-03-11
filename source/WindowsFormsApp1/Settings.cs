using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	class Settings
	{
		//******************************//
		//								//
		//		　　ツール設定　		//
		//								//
		//******************************//

		// 定数
		public static string FILEPATH = @"settings.txt";

		// 変数：フォームの位置と大きさ
		public static int formSizeX;
		public static int formSizeY;

		// 変数：ツール設定
		public static int capFrameSizeX;
		public static int capFrameSizeY;
		public static int frameBorder;
		public static int lineBorder;
		public static Color frameColor;
		public static Color lineColor;
		public static string outputPath;
		public static bool useArrow;

		// 関数：初期化
		public static void Initialize()
		{
			formSizeX = 435;
			formSizeY = 240;
			capFrameSizeX = 220;
			capFrameSizeY = 170;
			frameBorder = 1;
			lineBorder = 4;
			frameColor = Color.FromArgb(127, 127, 127);
			lineColor = Color.FromArgb(255, 40, 40);
			outputPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			useArrow = false;
		}

		//******************************//
		//								//
		//		 設定の入出力保存　		//
		//								//
		//******************************//

		// 関数：ツール設定を読み込む
		public static void InputSettings()
		{
			// ツール設定ファイルがあるなら List に加えて返す
			if (File.Exists(FILEPATH))
			{
				// List作成
				List<string> list = new List<string>();

				// 入力
				using (StreamReader sr = new StreamReader(
					FILEPATH,
					Encoding.Default))
				{
					string s = "";

					// 1行ずつ読み込んで、末端(何もない行)まで繰り返す
					while ((s = sr.ReadLine()) != null)
					{
						// 先頭の7文字を削除する
						s = s.Remove(0, 7);

						list.Add(s);
					}
				}

				// ツール設定を読み込む
				try
				{
					// 各パラメータの復元
					formSizeX = int.Parse(list[0]);
					formSizeY = int.Parse(list[1]);
					capFrameSizeX = int.Parse(list[2]);
					capFrameSizeY = int.Parse(list[3]);
					frameBorder = int.Parse(list[4]);
					lineBorder = int.Parse(list[5]);
					frameColor = Color.FromArgb(
						byte.Parse(list[6]),
						byte.Parse(list[7]),
						byte.Parse(list[8]));
					lineColor = Color.FromArgb(
						byte.Parse(list[9]),
						byte.Parse(list[10]),
						byte.Parse(list[11]));
					outputPath = list[12];
					useArrow = bool.Parse(list[13]);
				}
				catch (Exception)
				{
					// 読み込み失敗
					MessageBox.Show(
						"設定ファイルの読み込みに失敗しました" + "\r\n" +
						"デフォルト設定を使用します");

					Initialize();
				}
			}
			// ツール設定ファイルが無い場合
			else
			{
				Initialize();
			}
		}

		// 関数：ツール設定を出力する
		public static void OutputSettings()
		{
			// 出力設定
			using (StreamWriter sw = new StreamWriter(
				FILEPATH,
				false,
				Encoding.Default))
			{
				// 改行記号
				string rn = "\r\n";

				// 1行分のデータ
				string data = "";

				// 1行に連結
				data =
					"[SizX] " + formSizeX.ToString() + rn +
					"[SizY] " + formSizeY.ToString() + rn +
					"[CAPX] " + capFrameSizeX.ToString() + rn +
					"[CAPY] " + capFrameSizeY.ToString() + rn +
					"[Fbor] " + frameBorder.ToString() + rn +
					"[Lbor] " + lineBorder.ToString() + rn +
					"[FCoR] " + frameColor.R.ToString() + rn +
					"[FCoG] " + frameColor.G.ToString() + rn +
					"[FCoB] " + frameColor.B.ToString() + rn +
					"[LCoR] " + lineColor.R.ToString() + rn +
					"[LCoG] " + lineColor.G.ToString() + rn +
					"[LCoB] " + lineColor.B.ToString() + rn +
					"[Path] " + outputPath + rn +
					"[Arow] " + useArrow.ToString();

				// 書き込む
				sw.WriteLine(data);
			}
		}
	}
}
