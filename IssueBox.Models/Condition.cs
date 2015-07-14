
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
        /// -1:全て 0:無効 1:有効
        /// </summary>
        public int EnableFlag { get; set; }

        #region Default constructor

        public Condition()
        {
            this.Name = "";
            this.EnableFlag = -1;
        }

        #endregion
    }
}
