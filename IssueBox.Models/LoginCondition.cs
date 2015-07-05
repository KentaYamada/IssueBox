using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueBox.Models
{
    /// <summary>
    /// ログイン条件モデル
    /// </summary>
    public class LoginCondition
    {
        /// <summary>ログインID</summary>
        public string LoginID { get; set; }

        /// <summary>ログインパスワード</summary>
        public string LoginPassWord { get; set; }

        #region Constructors

        public LoginCondition()
            :this("", "")
        {}

        public LoginCondition(string loginID, string loginPassword)
        {
            this.LoginID = loginID;
            this.LoginPassWord = loginPassword;
        }

        #endregion
    }
}
