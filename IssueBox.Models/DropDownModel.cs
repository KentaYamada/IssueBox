using System.Collections.Generic;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models
{
    /// <summary>
    /// ドロップダウンリスト用モデル
    /// </summary>
    public class DropDownModel : ModelBase
    {
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

            try
            {
                data = ModelBase._db.ReadAny<DropDownModel, Condition>("exec FindAllDropDownList @Name", new Condition() { Name = tablename.ToString() });
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
