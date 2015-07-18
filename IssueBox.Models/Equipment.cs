using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
