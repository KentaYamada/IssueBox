
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
        /// True:有効 / False:無効 / Null:全て
        /// </summary>
        public bool? EnableFlag { get; set; }

        #region Default constructor

        public Condition()
        {
            this.Name = "";
            this.EnableFlag = null;
        }

        #endregion
    }
}
