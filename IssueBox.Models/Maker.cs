using System.Collections.Generic;

namespace IssueBox.Models
{
    /// <summary>
    /// メーカーモデル
    /// </summary>
    public class Maker : ModelBase
    {
        /// <summary>型番</summary>
        public string Name { get; set; }

        /// <summary>データ有効可否</summary>
        public bool EnableFlag { get; set; }

        #region Default constructor

        public Maker()
        {
            this.ID = 0;
            this.Name = "";
            this.EnableFlag = true;
        }

        #endregion

        /// <summary>
        /// メーカー一覧取得
        /// </summary>
        /// <param name="condition">検索条件</param>
        /// <returns>検索条件に合致したメーカー一覧</returns>
        public static List<Maker> FindMakersBy(Condition condition)
        {
            try
            {
                return ModelBase._db.FindBy<Maker, Condition>("Exec FindMakersBy @Name, @EnableFlag", condition);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// メーカー情報保存
        /// </summary>
        /// <param name="equipments">機器情報一覧</param>
        /// <returns>True:成功 / False:異常</returns>
        public bool Save(List<Equipment> equipments)
        {
            try
            {
                return ModelBase._db.ExecuteStoredProcedure<Maker, Equipment>("SaveMaker", this, equipments) > 0 ? true : false;
            }
            catch
            {
                throw;
            }
        }
    }
}
