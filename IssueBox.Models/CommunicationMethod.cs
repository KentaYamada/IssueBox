using System.Collections.Generic;

namespace IssueBox.Models
{
    /// <summary>
    /// 通信方式モデル
    /// </summary>
    public class CommunicationMethod : ModelBase
    {
        /// <summary>通信方式名</summary>
        public string Name { get; set; }

        /// <summary>データ有効可否</summary>
        public bool EnableFlag { get; set; }

        #region Default constructor

        public CommunicationMethod()
        {
            this.ID = 0;
            this.Name = "";
            this.EnableFlag = true;
        }

        #endregion

        /// <summary>
        /// 通信方式一覧取得
        /// </summary>
        /// <param name="condition">検索条件</param>
        /// <returns>検索条件に該当する通信方式一覧</returns>
        public static List<CommunicationMethod> FindCommunicationMethodBy(Condition condition)
        {
            return ModelBase._db.ReadAny<CommunicationMethod, Condition>("Exec FindCommunicationMethodBy @Name, @EnableFlag", condition);
        }

        /// <summary>
        /// 通信方式登録
        /// </summary>
        /// <returns>True:成功 / False:失敗</returns>
        public bool Save()
        {
            return ModelBase._db.Execute<CommunicationMethod>("Exec SaveCommunicationMethod @ID, @Name, @EnableFlag", this) > 0 ? true : false;
        }
    }
}
