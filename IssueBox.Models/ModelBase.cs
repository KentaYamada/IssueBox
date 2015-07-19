using IssueBox.Models.Infrastructure;

namespace IssueBox.Models
{
    /// <summary>
    /// 基底モデル
    /// </summary>
    public class ModelBase
    {
        /// <summary>DBコマンド</summary>
        protected static readonly SQLCommander _db = new SQLCommander();
        
        /// <summary>主キー</summary>
        public int ID { get; set; }
    }
}
