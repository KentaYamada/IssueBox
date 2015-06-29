using System.Windows.Forms;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Views.Infrastructure
{
    public abstract class TaskStatusRadioButton : RadioButton, IStatus
    {
        public TaskStatusRadioButton()
            : base()
        { }

        public abstract TASK_STATUS Status { get; }
    }

    /// <summary>
    /// 起票ラジオボタン
    /// </summary>
    public class OriginationRadioButton : TaskStatusRadioButton
    {
        public override TASK_STATUS Status 
        {
            get
            {
                return TASK_STATUS.ORIGINATION;
            }
        }

        public OriginationRadioButton()
            :base()
        {
            base.Text = "起票";
        }
    }

    /// <summary>
    /// 対応中ラジオボタン
    /// </summary>
    public class ResponcingRadioButton : TaskStatusRadioButton
    {
        public override TASK_STATUS Status 
        {
            get
            {
                return TASK_STATUS.RESPONCING;
            }
        }

        public ResponcingRadioButton()
            :base()
        {
            base.Text = "対応中";
        }
    }

    /// <summary>
    /// 確認中ラジオボタン
    /// </summary>
    public class CheckingRadioButton : TaskStatusRadioButton
    {
        public override TASK_STATUS Status
        {
            get
            {
                return TASK_STATUS.CHECKING;
            }
        }

        public CheckingRadioButton()
            : base()
        {
            base.Text = "確認中";
        }
    }

    /// <summary>
    /// 完了ラジオボタン
    /// </summary>
    public class DoneRadioButton : TaskStatusRadioButton
    {
        public override TASK_STATUS Status
        {
            get
            {
                return TASK_STATUS.DONE;
            }
        }

        public DoneRadioButton()
            : base()
        {
            base.Text = "完了";
        }
    }
}
