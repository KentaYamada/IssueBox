using System;
using System.Collections.Generic;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models
{
    /// <summary>
    /// 課題検索モデル
    /// </summary>
    public class IssueCondition
    {
        private SQLCommander _db = null;

        /// <summary>案件ID</summary>
        public string ProjectID { get; set; }

        /// <summary>製品ID</summary>
        public int ProductID { get; set; }
        
        /// <summary>期限</summary>
        public DateTime? DeadLine { get; set; }

        /// <summary>課題ステータス</summary>
        public int Status { get; set; }

        #region Default constructor

        public IssueCondition()
        {
            this.ProjectID = "";
            this.ProductID = 0;
            this.DeadLine = null;
            this.Status = 0;
            this._db = new SQLCommander();
        }

        #endregion

        
    }
}
