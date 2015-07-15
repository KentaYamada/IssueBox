﻿using System.Collections.Generic;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Models
{
    /// <summary>
    /// メンバーモデル
    /// </summary>
	public class Member
	{
        private readonly SQLCommander _db;

        /// <summary>メンバーID</summary>
        public int ID { get; set; }

		/// <summary>メンバー名</summary>
        public string Name { get; set; }

        /// <summary>パスワード</summary>
        public string LoginID { get; set; }

		/// <summary>パスワード</summary>
        public string LoginPassword { get; set; }

        /// <summary>データ有効可否</summary>
        public bool EnableFlag { get; set; }

        #region Default constructor

        public Member()
        {
            this.ID = 0;
            this.Name = "";
            this.LoginID = "";
            this.LoginPassword = "";
            this.EnableFlag = true;
            this._db = new SQLCommander();
        }

        #endregion

        /// <summary>
        /// メンバー取得
        /// </summary>
        /// <param name="condition">検索条件</param>
        /// <returns>検索条件に合致したメンバー</returns>
        public static List<Member> FindMembersBy(Condition condition)
        {
            string sql = @"SELECT
                               m.id             AS ID
                              ,m.name           AS Name
                              ,m.login_id       AS LoginID
                              ,m.login_password AS LoginPassword
                              ,m.enable_flag    AS EnableFlag
                            FROM MEMBERS AS m
                            WHERE (m.name LIKE '%' + @Name +'%' OR @Name IS NULL)
                              AND (m.enable_flag = dbo.IsBit(@EnableFlag) OR dbo.IsBit(@EnableFlag) IS NULL)
                            ORDER BY m.id";
            var model = new Member();

            try
            {
                return model._db.FindBy<Member, Condition>(sql, condition);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// メンバー登録
        /// </summary>
        /// <returns>True:成功 / False:エラー</returns>
        public bool Save()
        {
            try
            {
                return this._db.ExecuteStoredProcedure<Member>("SaveMember", this) > 0 ? true : false;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// ログイン認証
        /// </summary>
        /// <param name="condition">ログイン情報</param>
        /// <returns>成功:メンバー情報 / 失敗:null</returns>
        public static Member LoginAuthorication(Member condition)
        {
            string sql = @"SELECT
                             m.name
                           FROM MEMBERS AS m
                           WHERE m.enable_flag = 'TRUE'
                             AND m.login_id = @LoginID
                             AND m.login_password = @LoginPassword";
            var model = new Member();
            try
            {
                return model._db.Find<Member, Member>(sql, condition);
            }
            catch
            {
                throw;
            }
        }
    }
}
