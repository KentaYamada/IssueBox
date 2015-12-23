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
        /// <summary>案件ID</summary>
        public int? ProjectID { get; set; }

        /// <summary>製品ID</summary>
        public int ProductID { get; set; }

        /// <summary>カテゴリID</summary>
        public int CategoryID { get; set; }

        /// <summary>期限(開始)</summary>
        public DateTime? DeadlineFrom { get; set; }

        /// <summary>期限(終了)</summary>
        public DateTime? DeadlineTo { get; set; }

        /// <summary>課題ステータス</summary>
        public int Status { get; set; }

        #region Default constructor

        public IssueCondition()
        {
            this.ProjectID = null;
            this.ProductID = 0;
            this.DeadlineFrom = null;
            this.DeadlineTo = null;
            this.Status = 0;
        }

        #endregion
    }
}
