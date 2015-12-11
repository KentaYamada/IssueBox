using System;
using System.Threading;
using System.Windows.Forms;

using IssueBox.Views;
using IssueBox.Views.Infrastructure;

namespace IssueBox
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if DEBUG
            Application.Run(new MainWindow());
#else
            Application.Run(new Login());
#endif
        }

        /// <summary>
        /// 捕捉しきれない例外を補足するイベント
        /// </summary>
        public static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
#if DEBUG
            MessageBox.Show(e.Exception.Message);
#else
            //ユーザーにシステムエラーが発生したことを通知
            MessageBox.Show("システムエラーが発生しました。\nシステム管理者へお問い合わせ下さい。",
                            "システムエラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
#endif
            //エラーログ出力
            Logger.Error(e.Exception);
            Application.Exit();
        }
    }
}
