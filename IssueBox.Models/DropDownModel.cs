using System.Collections.Generic;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models
{
    /// <summary>
    /// ドロップダウンリスト用モデル
    /// </summary>
    public class DropDownModel : ModelBase
    {
        public int ID { get; set; }

        public string Value { get; set; }

        #region Default constructor

        public DropDownModel()
        {
            this.ID = 0;
            this.Value = "";
        }

        #endregion

        /// <summary>
        /// マスタデータ取得
        /// </summary>
        /// <param name="tablename">テーブル名</param>
        /// <param name="required">必須可否</param>
        /// <returns>データが有効なマスタデータ</returns>
        public static List<DropDownModel> FindAllData(TABLE_NAME tablename, bool required = true)
        {
            var data = new List<DropDownModel>();
            string sql = string.Format(@"SELECT
                                            t.id   AS ID
                                           ,t.name AS Value
                                         FROM {0} AS t
                                         WHERE t.enable_flag = CONVERT(bit, 'TRUE')
                                         ORDER BY t.name", tablename.ToString());

            try
            {
                data = ModelBase._db.ReadAll<DropDownModel>(sql);
            }
            catch
            {
                throw;
            }

            if (0 < data.Count && !required)
            {
                //必須ではない場合、１行目に空データ追加
                data.Insert(0, new DropDownModel());
            }

            return data;
        }
    }
}
