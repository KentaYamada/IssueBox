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

        /// <summary>データ有効可否</summary>
        public bool EnableFlag { get; set; }

        #region Default constructor

        public Project()
        {
            this.ID = 0;
            this.Name = "";
            this.ProjectID = "";
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
            try
            {
                return ModelBase._db.FindBy<Project, ProjectCondition>("Exec FindProjectsBy @ProjectID, @Name, @EnableFlag", condition);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 案件登録
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            try
            {
                return ModelBase._db.ExecuteStoredProcedure<Project>("SaveProject", this) > 0 ? true : false;
            }
            catch
            {
                throw;
            }
        }

        public bool Save(List<EquipmentConfiguration> models)
        {
            try
            {
                return ModelBase._db.ExecuteStoredProcedure<Project, EquipmentConfiguration>("SaveProject", this, models) > 0 ? true : false;
            }
            catch
            {
                throw;
            }
        }
    }
}
