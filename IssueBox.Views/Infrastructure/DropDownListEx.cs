using System.Windows.Forms;

namespace IssueBox.Views.Infrastructure
{
    public class DropDownListEx : ComboBox
    {
        public DropDownListEx()
            : base()
        {
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.DisplayMember = "Value";
            this.ValueMember = "ID";
        }
    }
}
