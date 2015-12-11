using System.Collections.Generic;

namespace IssueBox.Models
{
    /// <summary>
    /// 製品モデル
    /// </summary>
    public class Product : ModelBase
    {
        /// <summary>製品名</summary>
        public string Name { get; set; }

        /// <summary>バージョン</summary>
        public string Version { get; set; }

        /// <summary>製品種別</summary>
        public int ProductType { get; set; }

        /// <summary>データ有効可否</summary>
        public bool EnableFlag { get; set; }

        #region Default constructor

        public Product()
        {
            this.ID = 0;
            this.Name = "";
            this.Version = "";
            this.ProductType = 1;
            this.EnableFlag = true;
        }

        #endregion

        /// <summary>
        /// サービス取得
        /// </summary>
        /// <returns></returns>
        public static List<Product> FindAllServices()
        {
            return ModelBase._db.ReadAll<Product>("Exec FindAllServices");
        }

        /// <summary>
        /// 製品一覧取得
        /// </summary>
        /// <param name="condition">検索条件</param>
        /// <returns>検索条件に合致した製品一覧</returns>
        public static List<Product> FindProductsBy(Condition condition)
        {
            return ModelBase._db.ReadAny<Product, Condition>("Exec FindProductsBy @Name, @EnableFlag", condition);
        }

        /// <summary>
        /// 製品登録
        /// </summary>
        /// <returns>True:成功 / False:失敗</returns>
        public bool Save()
        {
            return ModelBase._db.Execute<Product>("Exec SaveProduct @ID, @Name, @Version, @ProductType, @EnableFlag", this) > 0 ? true : false;
        }
    }
}
