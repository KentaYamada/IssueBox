
namespace IssueBox.Models
{
    /// <summary>
    /// 課題検索モデル
    /// </summary>
    public class IssueSearch : Issue
    {
        /// <summary>製品名</summary>
        public string ProductName { get; set; }

        /// <summary>案件名</summary>
        public string ProjectName { get; set; }

        /// <summary>対応者名</summary>
        public string ResponcedMemberName { get; set; }

        /// <summary>ステータス(表示用文字)</summary>
        public string DispStatus { get; set; }

        #region Default constructor

        public IssueSearch()
            : base()
        {
            this.ResponcedMemberName = "";
            this.ProductName = "";
            this.ProjectName = "";
        }

        #endregion
    }
}
