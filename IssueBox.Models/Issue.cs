using System;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models
{
	/// <summary>
	/// 課題モデル
	/// </summary>
	public class Issue
	{
        private SQLCommander _db = null;

        /// <summary>課題ID</summary>
        public int ID { get; set; }

		/// <summary>案件ID</summary>
		public int ProjectID { get; set; }

		/// <summary>起票日</summary>
		public DateTime OriginationDate { get; set; }

        /// <summary>カテゴリID</summary>
        public int CategoryID { get; set; }

        /// <summary>製品ID</summary>
        public int ProductID { get; set; }

		/// <summary>起票者ID</summary>
		public int IssuingMemberID { get; set; }

		/// <summary>対応者ID</summary>
		public int? ResponcedMemberID { get; set; }

        /// <summary>確認者ID</summary>
        public int? CheckedMemberID { get; set; }

        /// <summary>期限</summary>
        public DateTime? Deadline { get; set; }

		/// <summary>課題ステータス</summary>
		public int Status { get; set; }

		/// <summary>対応内容</summary>
		public string Comment { get; set; }

        #region Default constructor

        public Issue()
        {
            this.ID = 0;
            this.ProjectID = 0;
            this.OriginationDate = DateTime.Now;
            this.CategoryID = 0;
            this.ProductID = 0;
            this.IssuingMemberID = 0;
            this.ResponcedMemberID = null;
            this.CheckedMemberID = null;
            this.Deadline = null;
            this.Status = 0;
            this.Comment = "";
            this._db = new SQLCommander();
        }

        #endregion

        /// <summary>
        /// 課題登録
        /// </summary>
        /// <returns>True:正常終了 / False:登録エラー</returns>
        public bool Save()
        {
            try
            {
                return this._db.ExecuteStoredProcedure<Issue>("SaveIssue", this) > 0 ? true : false;
            }
            catch
            {
                throw;
            }
        }
    }
}
