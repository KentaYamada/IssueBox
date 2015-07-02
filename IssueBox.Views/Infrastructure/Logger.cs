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
        private static readonly string _confString = ConfigurationManager.AppSettings["Logger"];

        private static void Write(Exception ex)
        {
            if (!Directory.Exists(_confString)) 
            {
                Directory.CreateDirectory(_confString);
            }

            var sb = new StringBuilder();
            sb.Length = 0;
            sb.AppendLine("エラーメッセージ");
            sb.AppendLine(ex.Message);

        }
        

        public static void Error(Exception ex)
        {
            //ログファイル書き出し
            Logger.Write(ex);
        }
    }
}
