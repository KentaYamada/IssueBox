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
        public static List<Category> FindCategoriesBy(Condition condition)
        {
            return ModelBase._db.ReadAny<Category, Condition>("Exec FindCategoriesBy @Name, @EnableFlag", condition);
        }

        /// <summary>
        /// カテゴリ登録
        /// </summary>
        /// <returns>True:成功 / False:失敗</returns>
        public bool Save()
        {
            return ModelBase._db.Execute<Category>("Exec SaveCategory @ID, @Name, @EnableFlag", this) > 0 ? true : false;
        }
    }
}
