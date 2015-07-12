
namespace IssueBox.Models
{
    /// <summary>
    /// 課題検索モデル
    /// </summary>
    public class IssueSearch : Issue
    {
        /// <summary>案件ID(表示)</summary>
        public string DispProjectID { get; set; }

        /// <summary>案件名</summary>
        public string ProjectName { get; set; }

        /// <summary>カテゴリ名</summary>
        public string CategoryName { get; set; }

        /// <summary>製品名</summary>
        public string ProductName { get; set; }

        /// <summary>対応者名</summary>
        public string ResponcedMemberName { get; set; }

        /// <summary>ステータス(表示用文字)</summary>
        public string DispStatus { get; set; }

        #region Default constructor

        public IssueSearch()
            : base()
        {
            this.DispProjectID = "";
            this.ProjectName = "";
            this.CategoryName = "";
            this.ProductName = "";
            this.ResponcedMemberName = "";
            this.DispStatus = "";
        }

        #endregion
    }
}
