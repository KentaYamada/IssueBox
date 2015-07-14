using System.Collections.Generic;

namespace IssueBox.Models.Infrastructure
{
    /// <summary>
    /// 課題ステータス
    /// </summary>
    public enum TASK_STATUS
    {
        ORIGINATION = 1, //起票
        RESPONCING,      //対応中
        CHECKING,        //確認中
        DONE             //完了
    }

    /// <summary>
    /// テーブル名
    /// </summary>
    public enum TABLE_NAME
    {
        CATEGORIES = 0,  //カテゴリマスタ
        ISSUE,           //課題テーブル
        MEMBERS,         //メンバーマスタ
        PRODUCTS,        //製品マスタ
        PROJECTS         //案件マスタ
    }

    /// <summary>
    /// 定数クラス
    /// </summary>
    public class Constants
    {
        public static readonly List<DataEnable> EnableList = new List<DataEnable>()
        {
            new DataEnable(-1, "全て"),
            new DataEnable(1, "有効"),
            new DataEnable(0, "無効")
        };

        public class DataEnable
        {
            public int ID { get; set; }

            public string Value { get; set; }

            public DataEnable(int id, string value)
            {
                this.ID = id;
                this.Value = value;
            }
        }
    }
}
