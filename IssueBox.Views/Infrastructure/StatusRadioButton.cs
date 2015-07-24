using System.Windows.Forms;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Views.Infrastructure
{
    /// <summary>
    /// ステータスインターフェース
    /// </summary>
    public interface IStatus
    {
        int Status { get; }
    }

    /// <summary>
    /// ステータス系ラジオボタン基底クラス
    /// </summary>
    public abstract class StatusRadioButtonAbstract : RadioButton, IStatus
    {
        public abstract int Status { get; }

        public StatusRadioButtonAbstract()
            : base()
        { }
    }

    /// <summary>
    /// 製品種別(製品)ラジオボタン
    /// </summary>
    public class ProductRadioButton : StatusRadioButtonAbstract
    {
        public override int Status { get { return (int)PRODUCT_TYPE.PRODUCT; } }

        public ProductRadioButton()
            : base()
        {
            this.Text = "製品";
        }
    }

    /// <summary>
    /// 製品種別(サービス)ラジオボタン
    /// </summary>
    public class ServiceRadioButton_New : StatusRadioButtonAbstract
    {
        public override int Status { get { return (int)PRODUCT_TYPE.SERVICE; } }

        public ServiceRadioButton_New()
            : base()
        {
            this.Text = "サービス";
        }
    }

    /// <summary>
    /// 起票ラジオボタン
    /// </summary>
    public class OriginationRadioButton : StatusRadioButtonAbstract
    {
        public override int Status { get { return (int)TASK_STATUS.ORIGINATION; } }

        public OriginationRadioButton()
            : base()
        {
            this.Text = "起票";
        }
    }

    /// <summary>
    /// 対応中ラジオボタン
    /// </summary>
    public class ResponcingRadioButton : StatusRadioButtonAbstract
    {
        public override int Status { get { return (int)TASK_STATUS.RESPONCING; } }

        public ResponcingRadioButton()
            :base()
        {
            this.Text = "対応中";
        }
    }

    /// <summary>
    /// 確認中ラジオボタン
    /// </summary>
    public class CheckingRadioButton : StatusRadioButtonAbstract
    {
        public override int Status { get { return (int)TASK_STATUS.CHECKING; } }

        public CheckingRadioButton()
            :base()
        {
            this.Text = "確認中";
        }
    }

    /// <summary>
    /// 完了ラジオボタン
    /// </summary>
    public class DoneRadioButton : StatusRadioButtonAbstract
    {
        public override int Status { get { return (int)TASK_STATUS.DONE; } }

        public DoneRadioButton()
            :base()
        {
            this.Text = "完了";
        }
    }
}
