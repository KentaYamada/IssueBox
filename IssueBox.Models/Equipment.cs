using System.Collections.Generic;

namespace IssueBox.Models
{
    public class Equipment : ModelBase
    {
        /// <summary>型番</summary>
        public string Name { get; set; }

        /// <summary>定格</summary>
        public double Rating { get; set; }

        /// <summary>メーカーID</summary>
        public int MakerID { get; set; }

        /// <summary>データ有効可否</summary>
        public bool EnableFlag { get; set; }

        #region Default constructor

        public Equipment()
        {
            this.ID = 0;
            this.Name = "";
            this.MakerID = 0;
            this.EnableFlag = true;
        }

        #endregion

        /// <summary>
        /// 機器一覧取得
        /// </summary>
        /// <param name="makerID">メーカーID</param>
        /// <returns>検索条件に合致した機器一覧</returns>
        public static List<Equipment> FindEquipmentsBy(int makerID)
        {
            try
            {
                return ModelBase._db.FindBy<Equipment, Maker>("Exec FindEquipmentsBy @ID", new Maker() { ID = makerID });
            }
            catch
            {
                throw;
            }
        }
    }
}
