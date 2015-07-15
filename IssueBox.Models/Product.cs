using System.Collections.Generic;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models
{
    /// <summary>
    /// 製品モデル
    /// </summary>
    public class Product
    {
        private SQLCommander _db = null;

        /// <summary>製品ID</summary>
        public int ID { get; set; }

        /// <summary>製品名</summary>
        public string Name { get; set; }

        /// <summary>バージョン</summary>
        public string Version { get; set; }

        /// <summary>データ有効可否</summary>
        public bool EnableFlag { get; set; }

        #region Default constructor

        public Product()
        {
            this.ID = 0;
            this.Name = "";
            this.Version = "";
            this.EnableFlag = true;
            this._db = new SQLCommander();
        }

        #endregion

        /// <summary>
        /// 製品一覧取得
        /// </summary>
        /// <param name="condition">検索条件</param>
        /// <returns>検索条件に合致した製品一覧</returns>
        public static List<Product> FindProductsBy(Condition condition)
        {
            string sql = @"SELECT
                               p.id             AS ID
                              ,p.name           AS Name
                              ,p.[version]      AS [Version]
                              ,p.enable_flag    AS EnableFlag
                            FROM PRODUCTS AS p
                            WHERE (p.name LIKE '%' + @Name +'%' OR @Name IS NULL)
                              AND (p.enable_flag = dbo.IsBit(@EnableFlag) OR dbo.IsBit(@EnableFlag) IS NULL)
                            ORDER BY p.id";
            var model = new Product();

            try
            {
                return model._db.FindBy<Product, Condition>(sql, condition);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 製品登録
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            try
            {
                return this._db.ExecuteStoredProcedure<Product>("SaveProduct", this) > 0 ? true : false;
            }
            catch
            {
                throw;
            }
        }
    }
}
