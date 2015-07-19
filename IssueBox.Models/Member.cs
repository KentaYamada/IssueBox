using System.Collections.Generic;

namespace IssueBox.Models
{
    /// <summary>
    /// メンバーモデル
    /// </summary>
	public class Member : ModelBase
	{
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
        }

        #endregion

        /// <summary>
        /// メンバー取得
        /// </summary>
        /// <param name="condition">検索条件</param>
        /// <returns>検索条件に合致したメンバー</returns>
        public static List<Member> FindMembersBy(Condition condition)
        {
            try
            {
                return ModelBase._db.FindBy<Member, Condition>("Exec FindMembersBy @Name, @EnableFlag", condition);
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
                return ModelBase._db.ExecuteStoredProcedure<Member>("SaveMember", this) > 0 ? true : false;
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
            try
            {
                return ModelBase._db.Find<Member, Member>("Exec LoginAuthorication @LoginID, @LoginPassword", condition);
            }
            catch
            {
                throw;
            }
        }
    }
}
