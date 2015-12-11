using System.Collections.Generic;

namespace IssueBox.Models
{
    /// <summary>
    /// 案件モデル
    /// </summary>
	public class Project : ModelBase
	{
        /// <summary>プロジェクトID</summary>
        public string ProjectID { get; set; }

		/// <summary>プロジェクト名</summary>
        public string Name { get; set; }

        /// <summary>利用製品ID</summary>
        public int? ProductID { get; set; }

        /// <summary>利用サービスID</summary>
        public int? ServiceID { get; set; }

        /// <summary>データ有効可否</summary>
        public bool EnableFlag { get; set; }

        #region Default constructor

        public Project()
        {
            this.ID = 0;
            this.ProjectID = "";
            this.Name = "";
            this.ProductID = null;
            this.ServiceID = null;
            this.EnableFlag = true;
        }

        #endregion

        /// <summary>
        /// 案件一覧取得
        /// </summary>
        /// <param name="condition">検索条件</param>
        /// <returns>検索条件に合致した案件一覧</returns>
        public static List<Project> FindProjectsBy(ProjectCondition condition)
        {
            return ModelBase._db.ReadAny<Project, ProjectCondition>("Exec FindProjectsBy @ProjectID, @Name, @EnableFlag", condition);
        }

        /// <summary>
        /// 案件ID重複チェック
        /// </summary>
        /// <param name="projectID">案件ID</param>
        /// <returns>検索結果</returns>
        public static long ProjectID_DoubleCheck(string projectID)
        {
            return ModelBase._db.ReadScalor<int, ProjectCondition>("select count(p.project_id) AS A from PROJECTS AS p WHERE p.project_id = @ProjectID", new ProjectCondition() { ProjectID = projectID });
        }

        /// <summary>
        /// 案件登録
        /// </summary>
        /// <returns></returns>
        public bool Save(List<EquipmentConfiguration> models)
        {
            return ModelBase._db.Execute<Project, EquipmentConfiguration>("Exec SaveProject @ID, @ProjectID, @Name, @ProductID, @ServiceID, @EnableFlag, @EquipmentConfigurations", this, models) > 0 ? true : false;
        }
    }
}
