
namespace IssueBox.Models
{
    /// <summary>
    /// 案件マスタ検索モデル
    /// </summary>
    public class ProjectCondition : Condition
    {
        public string ProjectID { get; set; }

        #region Default constructor

        public ProjectCondition()
            :base()
        {
            this.ProjectID = "";
        }

        #endregion
    }
}
