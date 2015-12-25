using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using IssueBox.Models.Infrastructure;

namespace IssueBox.Models
{
    /// <summary>
    /// 基底モデル
    /// </summary>
    public class ModelBase
    {
        /// <summary>DBコマンド</summary>
        protected static readonly SQLCommander _db = new SQLCommander();
        
        /// <summary>主キー</summary>
        public int ID { get; set; }

        /// <summary>
        /// Model→CSV変換
        /// </summary>
        protected static string ModelsToCsv<TModel>(List<TModel> models)
            where TModel : class
        {
            var sb = new StringBuilder();
            sb.Clear();

            var columns = typeof(TModel).GetProperties().ToList();

            columns.ForEach(x => sb.AppendFormat("{0},", x.Name));
            sb.Remove(sb.Length - 1, 1).AppendLine();

            foreach (var model in models)
            {
                columns.ForEach(x => sb.AppendFormat("{0},", x.GetValue(model, null)));
                sb.Remove(sb.Length - 1, 1).AppendLine();
            }

            return sb.ToString();
        }
    }
}
