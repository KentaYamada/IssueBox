using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IssueBox.Models.Infrastructure;

namespace IssueBox.Models
{
    /// <summary>
    /// メーカーモデル
    /// </summary>
    public class Maker
    {
        private SQLCommander _db = null;

        /// <summary>メーカーID</summary>
        public int ID { get; set; }

        /// <summary>メーカー名</summary>
        public string Name { get; set; }

        /// <summary>データ有効可否</summary>
        public bool EnableFlag { get; set; }

        #region Default constructor

        public Maker()
        {
            this.ID = 0;
            this.Name = "";
            this.EnableFlag = true;
            this._db = new SQLCommander();
        }

        #endregion

        
        /// <summary>
        /// メーカー情報保存
        /// </summary>
        /// <param name="equipments">機器情報一覧</param>
        /// <returns>True:成功 / False:異常</returns>
        public bool Save(List<Equipment> equipments)
        {
            try
            {
                return this._db.ExecuteStoredProcedure<Maker, Equipment>("SaveMaker", this, equipments) > 0 ? true : false;
            }
            catch
            {
                throw;
            }
        }
    }
}
