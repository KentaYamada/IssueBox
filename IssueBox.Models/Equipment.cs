using System.Collections.Generic;

namespace IssueBox.Models
{
    /// <summary>
    /// 機器(PCS)モデル
    /// </summary>
    public class Equipment : ModelBase
    {
        /// <summary>型番</summary>
        public string Name { get; set; }

        /// <summary>定格</summary>
        public decimal Rating { get; set; }

        /// <summary>通信方式ID</summary>
        public int? CommunicationMethodID { get; set; }

        /// <summary>出力制御可否</summary>
        public bool OutputControlFlag { get; set; }

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
                return ModelBase._db.ReadAny<Equipment, Maker>("Exec FindEquipmentsBy @ID", new Maker() { ID = makerID });
            }
            catch
            {
                throw;
            }
        }
    }
}
