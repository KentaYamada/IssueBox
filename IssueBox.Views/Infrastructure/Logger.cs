using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueBox.Views.Infrastructure
{
    public static class Logger
    {
        private static readonly string _confString = ConfigurationManager.AppSettings["LogPath"];

        private static readonly Encoding _enc = Encoding.GetEncoding("utf-8");

        private static void Write(string message)
        {
            if (!Directory.Exists(_confString)) 
            {
                Directory.CreateDirectory(_confString);
            }

            string fileName = string.Format("{0}\\{1}.log", _confString, DateTime.Now.ToString("yyyyMMdd"));
            try
            {
                using (var stream = new StreamWriter(fileName, true, _enc))
                {
                    stream.Write(message);
                }
            }
            catch
            {
                throw;
            }
        }
        

        public static void Error(Exception ex)
        {
            var sb = new StringBuilder();
            sb.Length = 0;
            sb.AppendLine(string.Format("エラーメッセージ:{0}", ex.Message));
            sb.AppendLine(string.Format("発生箇所:{0}", ex.TargetSite));
            sb.AppendLine(string.Format("スタックトレース:{0}", ex.StackTrace));
            
            Logger.Write(sb.ToString());
        }
    }
}
