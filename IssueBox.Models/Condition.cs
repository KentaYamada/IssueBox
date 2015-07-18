
namespace IssueBox.Models
{
    /// <summary>
    /// 共通検索条件モデル
    /// </summary>
    public class Condition
    {
        /// <summary>名称</summary>
        public string Name { get; set; }

        /// <summary>
        /// データ有効区分
        /// all:全て false:無効 true:有効
        /// </summary>
        public string EnableFlag { get; set; }

        #region Default constructor

        public Condition()
        {
            this.Name = "";
            this.EnableFlag = "all";
        }

        #endregion
    }
}
