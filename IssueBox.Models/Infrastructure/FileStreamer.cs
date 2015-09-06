using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace IssueBox.Models.Infrastructure
{
    /// <summary>
    /// ファイル入出力ユーティティ
    /// </summary>
    public static class FileStreamer
    {
        public static string ReadSql(string fileName)
        {
            return "";
        }

        private static void Write(string path, string value)
        {
            using (var stream = new StreamWriter(path, true, Encoding.GetEncoding("shift_jis")))
            {
                stream.Write(value);
            }
        }

        public static bool ExportCsv<TModel>(string path, List<TModel> models)
            where TModel : class
        {
            throw new NotImplementedException();
        }
    }
}
