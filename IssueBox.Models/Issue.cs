using System;
using System.Collections.Generic;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models
{
	/// <summary>
	/// 課題モデル
	/// </summary>
	public class Issue : ModelBase
	{
		/// <summary>案件ID</summary>
		public int ProjectID { get; set; }

		/// <summary>起票日</summary>
		public DateTime OriginationDate { get; set; }

        /// <summary>カテゴリID</summary>
        public int CategoryID { get; set; }

        /// <summary>製品ID</summary>
        public int ProductID { get; set; }

		/// <summary>起票者ID</summary>
		public int IssuingMemberID { get; set; }

		/// <summary>対応者ID</summary>
		public int? ResponcedMemberID { get; set; }

        /// <summary>確認者ID</summary>
        public int? CheckedMemberID { get; set; }

        /// <summary>期限</summary>
        public DateTime? Deadline { get; set; }

		/// <summary>課題ステータス</summary>
		public int Status { get; set; }

        /// <summary>作業完了日</summary>
        public DateTime? FinishedDate { get; set; }

		/// <summary>対応内容</summary>
		public string Comment { get; set; }

        #region Default constructor

        public Issue()
        {
            this.ID = 0;
            this.ProjectID = 0;
            this.OriginationDate = DateTime.Now;
            this.CategoryID = 0;
            this.ProductID = 0;
            this.IssuingMemberID = 0;
            this.ResponcedMemberID = null;
            this.CheckedMemberID = null;
            this.Deadline = null;
            this.Status = 1;
            this.FinishedDate = null;
            this.Comment = "";
        }

        #endregion

        /// <summary>
        /// 課題登録
        /// </summary>
        /// <returns>True:正常終了 / False:登録エラー</returns>
        public bool Save()
        {
            return ModelBase._db.Execute<Issue>(@"Exec SaveIssue @ID, @ProjectID, @OriginationDate,
                                                                     @CategoryID, @ProductID, @IssuingMemberID,
                                                                     @ResponcedMemberID, @CheckedMemberID, @Deadline,
                                                                     @FinishedDate, @Status, @Comment",
                                                   this) > 0 ? true : false;
        }

        /// <summary>
        /// 課題一覧取得
        /// </summary>
        /// <param name="condition">検索条件</param>
        /// <returns>検索条件に合致した課題一覧</returns>
        public static List<IssueSearch> FindIssuesBy(IssueCondition condition)
        {
            #region FixMe ストアド化

            string sql = @"
                        DECLARE @Enable bit
                        SET @Enable = 'TRUE'
                        SELECT
                             i.id                  AS ID
                            ,i.project_id          AS ProjectID
                            ,prj.project_id        AS DispProjectID
                            ,prj.name              AS ProjectName
                            ,i.category_id         AS CategoryID
                            ,c.name                AS CategoryName
                            ,i.product_id          AS ProductID
                            ,prd.name              AS ProductName
                            ,i.issuing_member_id   AS IssuingMemberID
                            ,i.responced_member_id AS ResponcedMemberID
                            ,m.name                AS ResponcedMemberName
                            ,i.checked_member_id   AS CheckedMemberID
                            ,i.deadline            AS Deadline
                            ,i.[status]            AS [Status]
                            ,CASE i.[status]
                                WHEN 1 THEN '起票'
                                WHEN 2 THEN '対応中'
                                WHEN 3 THEN '確認中'
                                WHEN 4 THEN '完了'
                                ELSE ''
                             END AS DispStatus
                            ,i.finished_date       AS FinishedDate
                            ,i.comment             AS Comment
                        FROM ISSUES AS i
                        LEFT JOIN PROJECTS AS prj
                          ON i.project_id = prj.id
                         AND prj.enable_flag = @Enable
                        LEFT JOIN PRODUCTS AS prd
                          ON i.product_id = prd.id
                         AND prd.enable_flag = @Enable
                        LEFT JOIN MEMBERS AS m
                          ON i.responced_member_id = m.id
                         AND m.enable_flag = @Enable
                        LEFT JOIN CATEGORIES AS c
                          ON i.category_id = c.id
                         AND c.enable_flag = @Enable
                        WHERE (i.project_id = @ProjectID OR @ProjectID IS NULL)
                          --AND (i.product_id = @ProductID OR @ProductID IS NULL)
                          AND (i.deadline BETWEEN @DeadlineFrom AND @DeadlineTo
                               OR @DeadLineFrom IS NULL
                               OR @DeadLineTo IS NULL)
                          --AND (i.[status] = @Status OR @Status = 0)
                        ORDER BY i.id";

            #endregion

            var model = new Issue();

            try
            {
                return ModelBase._db.ReadAny<IssueSearch, IssueCondition>(sql, condition);
            }
            catch
            {
                throw;
            }
        }
    }
}
