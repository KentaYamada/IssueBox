using System.Collections.Generic;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models
{
    public class IssueSearch : Issue
    {
        private SQLCommander _db = null;

        public string ProductName { get; set; }

        public string ProjectName { get; set; }

        public string ResponcedMemberName { get; set; }

        #region Default constructor

        public IssueSearch()
            : base()
        {
            this.ResponcedMemberName = "";
            this.ProductName = "";
            this.ProjectName = "";
            this._db = new SQLCommander();
        }

        #endregion

        /// <summary>
        /// 課題一覧取得
        /// </summary>
        /// <param name="condition">検索条件</param>
        /// <returns>検索条件に合致した課題一覧</returns>
        public List<IssueSearch> FindIssuesBy(IssueCondition condition)
        {
            #region SQL FixMe SQLファイル化 or else

            string sql = @"
                        DECLARE @Enable bit
                        SET @Enable = 'TRUE'
                        SELECT
                             i.id                  AS ID
                            ,i.project_id          AS ProjectID
                            ,prj.name              AS ProjectName
                            ,i.product_id          AS ProductID
                            ,prd.name              AS ProductName
                            ,i.responced_member_id AS ResponcedMemberID
                            ,m.name                AS ResponcedMemberName
                            ,i.deadline
                            ,CASE i.[status]
                                WHEN 1 THEN '起票'
                                WHEN 2 THEN '対応中'
                                WHEN 3 THEN '確認中'
                                WHEN 4 THEN '完了'
                                ELSE ''
                            END AS [Status]
                        FROM ISSUES AS i
                        LEFT JOIN PROJECTS AS prj
                          ON i.product_id = prj.project_id
                         AND prj.enable_flag = @Enable
                        LEFT JOIN PRODUCTS AS prd
                          ON i.product_id = prd.id
                         AND prd.enable_flag = @Enable
                        LEFT JOIN MEMBERS AS m
                          ON i.responced_member_id = m.id
                         AND m.enable_flag = @Enable
                        WHERE (i.product_id = @ProjectID OR @ProjectID IS NULL)
                          AND (i.product_id = @ProductID OR @ProductID IS NULL)
                          AND (i.deadline = @DeadLine OR @DeadLine IS NULL)
                          AND (i.[status] = @Status OR @Status = 0)
                        ORDER BY i.id";

            #endregion

            try
            {
                return this._db.FindBy<IssueSearch, IssueCondition>(sql, condition);
            }
            catch
            {
                throw;
            }
        }
    }
}
