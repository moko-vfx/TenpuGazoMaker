using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			// Mutex名
			string mutexName = "TenpuGazoMaker";
			// Mutexオブジェクトを作成
			System.Threading.Mutex mutex = new System.Threading.Mutex(false, mutexName);

			bool hasHandle = false;
			try
			{
				try
				{
					// Mutexの所有権を要求
					hasHandle = mutex.WaitOne(0, false);
				}
				// .NET Framework 2.0以降の場合
				catch (System.Threading.AbandonedMutexException)
				{
					// 別のアプリケーションがMutexを解放しないで終了した時
					hasHandle = true;
				}
				// Mutexを取得したか
				if (hasHandle == false)
				{
					// 取得できなかった場合、すでに起動していると判断して終了
					MessageBox.Show("多重起動はできません。");
					return;
				}

				// Form1実行
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Form1());
			}
			finally
			{
				if (hasHandle)
				{
					// Mutexを解放
					mutex.ReleaseMutex();
				}
				mutex.Close();
			}
		}
	}
}
