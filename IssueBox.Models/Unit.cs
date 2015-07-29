using System.Collections.Generic;

namespace IssueBox.Models
{
    /// <summary>
    /// 単位モデル
    /// </summary>
    public class Unit : ModelBase
    {
        /// <summary>単位名</summary>
        public string Name { get; set; }

        /// <summary>データ有効可否</summary>
        public bool EnableFlag { get; set; }

        #region Default constructor

        public Unit()
        {
            this.ID = 0;
            this.Name = "";
            this.EnableFlag = true;
        }

        #endregion

        /// <summary>
        /// 単位一覧取得
        /// </summary>
        /// <param name="condition">検索条件</param>
        /// <returns></returns>
        public static List<Unit> FindUnitsBy(Condition condition)
        {
            try
            {
                return ModelBase._db.FindBy<Unit, Condition>("Exec FindUnitsBy @Name, @EnableFlag", condition);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// データ保存
        /// </summary>
        /// <returns>True:成功 / False:失敗</returns>
        public bool Save()
        {
            try
            {
                return ModelBase._db.ExecuteStoredProcedure<Unit>("SaveUnit", this) > 0 ? true : false;
            }
            catch
            {
                throw;
            }
        }
    }
}
