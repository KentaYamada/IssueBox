using System.Linq;
using System.Windows.Forms;

using IssueBox.Models.Infrastructure;

namespace IssueBox.Views.Infrastructure
{
    public partial class StatusRadioButtons : UserControl
    {
        /// <summary>
        /// 選択されたステータス取得
        /// </summary>
        public int SelectedStatus
        {
            get
            {
                var target = this.Controls.OfType<TaskStatusRadioButton>()
                                          .Where(x => x.Checked == true)
                                          .ToList();
                return (int)((IStatus)target[0]).Status;
            }
            set
            {
                var target = this.Controls.OfType<TaskStatusRadioButton>()
                                          .Where(x => x.Status == (TASK_STATUS)value)
                                          .ToList();
                if(target.Count > 0)
                {
                    target[0].Checked = true;
                }
                else
                {
                    this.originationRadioButton1.Checked = true;
                }
            }
        }

        public StatusRadioButtons()
        {
            InitializeComponent();
        }
    }
}
