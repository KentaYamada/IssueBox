using System.Collections.Generic;

namespace IssueBox.Models
{
    /// <summary>
    /// カテゴリモデル
    /// </summary>
    public class Category : ModelBase
    {
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
        }

        #endregion

        /// <summary>
        /// カテゴリ取得
        /// </summary>
        /// <param name="condition">検索条件</param>
        /// <returns>条件に合致するカテゴリ一覧</returns>
        public static List<Category> FindByCategories(Condition condition)
        {
            try
            {
                return ModelBase._db.FindBy<Category, Condition>("Exec FindCategoriesBy @Name, @EnableFlag", condition);
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
                return ModelBase._db.ExecuteStoredProcedure<Category>("SaveCategory", this) > 0 ? true : false;
            }
            catch
            {
                throw;
            }
        }
    }
}
