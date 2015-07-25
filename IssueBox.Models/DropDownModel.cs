using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IssueBox.Models.Infrastructure;
namespace IssueBox.Models
{
    /// <summary>
    /// ドロップダウンリスト用モデル
    /// </summary>
    public class DropDownModel
    {
        private SQLCommander _db = null;

        public int ID { get; set; }

        public string Value { get; set; }

        public DropDownModel()
        {
            this.ID = 0;
            this.Value = "";
            this._db = new SQLCommander();
        }

        /// <summary>
        /// マスタデータ取得
        /// </summary>
        /// <param name="tablename"></param>
        /// <returns></returns>
        public static List<DropDownModel> FindAllData(TABLE_NAME tablename)
        {
            var model = new DropDownModel();
            string sql = string.Format(@"SELECT
                                            t.id   AS ID
                                           ,t.name AS Value
                                         FROM {0} AS t
                                         WHERE t.enable_flag = CONVERT(bit, 'TRUE')
                                         ORDER BY t.name", tablename.ToString());

            try
            {
                return model._db.FindAll<DropDownModel>(sql);
            }
            catch
            {
                throw;
            }
        }
    }
}
