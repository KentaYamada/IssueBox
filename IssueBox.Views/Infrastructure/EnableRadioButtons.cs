using System.Windows.Forms;

namespace IssueBox.Views.Infrastructure
{
    public partial class EnableRadioButtons : UserControl
    {
        public EnableRadioButtons()
        {
            InitializeComponent();
            this.rdoEnable.Checked = true;
            this.rdoDisable.Checked = false;
        }

        public bool Enable
        {
            get
            {
                return this.rdoEnable.Checked;
            }
            set
            {
                this.rdoEnable.Checked = value;
                this.rdoDisable.Checked = !value;
            }
        }
    }
}
