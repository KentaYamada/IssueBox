using System.Collections.Generic;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models
{
    /// <summary>
    /// 案件モデル
    /// </summary>
	public class Project
	{
        private SQLCommander _db = null;

		/// <summary>プロジェクトID(システム用)</summary>
        public int ID { get; set; }

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
            this.EnableFlag = false;
            this._db = new SQLCommander();
        }

        #endregion

        /// <summary>
        /// 案件一覧取得
        /// </summary>
        /// <param name="condition">検索条件</param>
        /// <returns>検索条件に合致した案件一覧</returns>
        public List<Project> FindProjectsBy(ProjectCondition condition)
        {
            string sql = @"SELECT
                               p.id             AS ID
                              ,p.project_id     AS ProjectID
                              ,p.name           AS Name
                              ,p.enable_flag    AS EnableFlag
                            FROM PROJECTS AS p
                            WHERE (p.name LIKE '%' + @Name +'%' OR @Name IS NULL)
                              AND (p.enable_flag = @EnableFlag OR @EnableFlag IS NULL)
                            ORDER BY p.id";

            try
            {
                return this._db.FindBy<Project, ProjectCondition>(sql, condition);
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
                return this._db.ExecuteStoredProcedure<Project>("SaveProject", this) > 0 ? true : false;
            }
            catch
            {
                throw;
            }
        }
    }
}
