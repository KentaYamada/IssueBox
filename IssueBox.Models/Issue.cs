﻿using System;
using System.Collections.Generic;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models
{
	/// <summary>
	/// 課題モデル
	/// </summary>
	public class Issue
	{
        private SQLCommander _db = null;

        /// <summary>課題ID</summary>
        public int ID { get; set; }

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
            this.Status = 0;
            this.FinishedDate = null;
            this.Comment = "";
            this._db = new SQLCommander();
        }

        #endregion

        /// <summary>
        /// 課題登録
        /// </summary>
        /// <returns>True:正常終了 / False:登録エラー</returns>
        public bool Save()
        {
            try
            {
                return this._db.ExecuteStoredProcedure<Issue>("SaveIssue", this) > 0 ? true : false;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 課題一覧取得
        /// </summary>
        /// <param name="condition">検索条件</param>
        /// <returns>検索条件に合致した課題一覧</returns>
        public static List<IssueSearch> FindIssuesBy(IssueCondition condition)
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
                            ,i.checked_member_id   AS CheckedMemberID
                            ,i.deadline
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
                          ON i.product_id = prj.project_id
                         AND prj.enable_flag = @Enable
                        LEFT JOIN PRODUCTS AS prd
                          ON i.product_id = prd.id
                         AND prd.enable_flag = @Enable
                        LEFT JOIN MEMBERS AS m
                          ON i.responced_member_id = m.id
                         AND m.enable_flag = @Enable
                        WHERE (i.project_id = @ProjectID OR @ProjectID IS NULL)
                          AND (i.product_id = @ProductID OR @ProductID IS NULL)
                          AND (i.deadline = @DeadLine OR @DeadLine IS NULL)
                          --AND (i.[status] = @Status OR @Status = 0)
                        ORDER BY i.id";

            #endregion

            var model = new Issue();

            try
            {
                return model._db.FindBy<IssueSearch, IssueCondition>(sql, condition);
            }
            catch
            {
                throw;
            }
        }
    }
}
