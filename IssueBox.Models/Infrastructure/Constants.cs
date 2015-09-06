using System.Collections.Generic;

namespace IssueBox.Models.Infrastructure
{
    /// <summary>
    /// テーブル名
    /// </summary>
    public enum TABLE_NAME
    {
        CATEGORIES = 0,       //カテゴリマスタ
        COMMUNICATION_METHOD, //通信方式マスタ
        EQUIPMENTS,           //機器マスタ
        ISSUE,                //課題テーブル
        MAKERS,               //メーカーマスタ    
        MEMBERS,              //メンバーマスタ
        PRODUCTS,             //製品マスタ
        PROJECTS              //案件マスタ
    }

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
    /// 製品種別
    /// </summary>
    public enum PRODUCT_TYPE
    {
        PRODUCT = 1,  //製品
        SERVICE       //サービス
    }

    /// <summary>
    /// 定数クラス
    /// </summary>
    public class Constants
    {
        public static readonly List<DataEnable> EnableList = new List<DataEnable>()
        {
            new DataEnable("all", "全て"),
            new DataEnable("true", "有効"),
            new DataEnable("false", "無効")
        };

        public class DataEnable
        {
            public string ID { get; set; }

            public string Value { get; set; }

            public DataEnable(string id, string value)
            {
                this.ID = id;
                this.Value = value;
            }
        }
    }
}
