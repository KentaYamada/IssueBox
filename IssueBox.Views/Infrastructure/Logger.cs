using System;
using System.Configuration;
using System.IO;
using System.Text;

namespace IssueBox.Views.Infrastructure
{
    public static class Logger
    {
        private static readonly string _confString = ConfigurationManager.AppSettings["LogPath"];

        private static readonly Encoding _enc = Encoding.GetEncoding("utf-8");

        private static void Write(string message, string name)
        {
            string fileName = string.Format("{0}\\{1}_{2}.log", _confString, DateTime.Now.ToString("yyyyMMdd"), name);

            if (!Directory.Exists(_confString)) 
            {
                Directory.CreateDirectory(_confString);
            }

            using (var stream = new StreamWriter(fileName, true, _enc))
            {
                stream.Write(message);
            }
        }
        
        /// <summary>
        /// エラーログ出力
        /// </summary>
        /// <param name="ex">例外クラス</param>
        public static void Error(Exception ex)
        {
            var sb = new StringBuilder();
            sb.Clear();
            sb.AppendLine(string.Format("エラーメッセージ:{0}", ex.Message));
            sb.AppendLine(string.Format("発生箇所:{0}", ex.TargetSite));
            sb.AppendLine(string.Format("スタックトレース:{0}", ex.StackTrace));

            //ログファイル書き込み
            Logger.Write(sb.ToString(), "error");
        }
    }
}
