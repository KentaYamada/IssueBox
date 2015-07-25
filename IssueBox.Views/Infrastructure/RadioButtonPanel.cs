using System.Linq;
using System.Windows.Forms;

namespace IssueBox.Views.Infrastructure
{
    public class RadioButtonPanel : Panel
    {
        public int SelectedStatus
        {
            get
            {
                var target = this.Controls.OfType<StatusRadioButtonAbstract>()
                                          .Where(x => x.Checked == true)
                                          .ToList();

                if (target.Count < 1)
                {
                    return -1;
                }

                return target[0].Status;
            }
            set
            {
                var target = this.Controls.OfType<StatusRadioButtonAbstract>()
                                                         .Where(x => x.Status == value)
                                                         .ToList();
                if (target.Count > 0)
                {
                    target[0].Checked = true;
                }
            }
        }

        public RadioButtonPanel()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }
    }
}
