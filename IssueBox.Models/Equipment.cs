using System.Collections.Generic;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models
{
    public class Equipment
    {
        private SQLCommander _db = null;

        /// <summary>機器ID</summary>
        public int ID { get; set; }

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
            this._db = new SQLCommander();
        }

        #endregion

        /// <summary>
        /// 機器一覧取得
        /// </summary>
        /// <param name="makerID">メーカーID</param>
        /// <returns>検索条件に合致した機器一覧</returns>
        public static List<Equipment> FindEquipmentsBy(int makerID)
        {
            #region SQL
            string sql = @"SELECT
                           e.id          AS ID
                          ,e.name        AS Name
                          ,e.rating      AS Rating
                          ,e.maker_id    AS MakerID
                          ,e.enable_flag AS EnableFlag
                        FROM EQUIPMENTS AS e
                        WHERE e.maker_id = @ID
                        ORDER BY e.name";
            #endregion

            var condition = new Maker() { ID = makerID };
            var model = new Equipment();

            try
            {
                return model._db.FindBy<Equipment, Maker>(sql, condition);
            }
            catch
            {
                throw;
            }
        }
    }
}
