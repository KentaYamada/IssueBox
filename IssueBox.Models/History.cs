using System;
using System.Collections.Generic;

namespace IssueBox.Models
{
    /// <summary>
    /// 対応履歴
    /// </summary>
    public class History : ModelBase
    {
        public int IssueID { get; set; }

        public DateTime PostDate { get; set; }

        public string PostMemberName { get; set; }

        public string Comment { get; set; }

        #region Default Construcor

        public History()
        {
            this.IssueID = 0;
            this.PostDate = DateTime.Now;
            this.PostMemberName = "";
            this.Comment = "";
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="issueID">課題ID</param>
        /// <returns></returns>
        public static List<History> FindHistoriesBy(int issueID)
        {
            return ModelBase._db.ReadAny<History, History>("Exec FindHistoryBy @IssueID", new History() { IssueID = issueID });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return ModelBase._db.Execute<History>("Exec SaveHistory @PostDate, @IssueID, @PostMemberName, @Comment", this) > 0 ? true : false;
        }
    }
}
