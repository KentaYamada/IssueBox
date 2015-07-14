using System.Collections.Generic;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models
{
    /// <summary>
    /// カテゴリモデル
    /// </summary>
    public class Category
    {
        private readonly SQLCommander _db;

        /// <summary>カテゴリID</summary>
        public int ID { get; set; }

        /// <summary>カテゴリ名</summary>
        public string Name { get; set; }

        /// <summary>データ有効可否</summary>
        public bool EnableFlag { get; set; }

        #region Default constructor

        public Category()
        {
            this.ID = 0;
            this.Name = "";
            this.EnableFlag = true;
            this._db = new SQLCommander();
        }

        #endregion

        /// <summary>
        /// カテゴリ取得
        /// </summary>
        /// <param name="condition">検索条件</param>
        /// <returns>条件に合致するカテゴリ一覧</returns>
        public static List<Category> FindByCategories(Condition condition)
        {
            string sql = @"SELECT
                             c.id          AS ID
                            ,c.name        AS Name
                            ,c.enable_flag AS EnableFlag
                        FROM CATEGORIES AS c
                        WHERE (c.name LIKE '%' + @Name + '%' OR @Name IS NULL)
                          AND (c.enable_flag = @EnableFlag OR @EnableFlag = -1)
                        ORDER BY c.id";
            var model = new Category();

            try
            {
                return model._db.FindBy<Category, Condition>(sql, condition);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// カテゴリ登録
        /// </summary>
        /// <returns>True:成功 / False:失敗</returns>
        public bool Save()
        {
            try
            {
                return this._db.ExecuteStoredProcedure<Category>("SaveCategory", this) > 0 ? true : false;
            }
            catch
            {
                throw;
            }
        }
    }
}
