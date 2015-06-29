using System.ComponentModel;
using System.Windows.Forms;

namespace IssueBox.Views.Infrastructure
{
    [Browsable(true)]
    public class TextBoxEx : TextBox, IRequired
    {
        public TextBoxEx()
            :base()
        {
            this.AlertMessage = "";
            this.Required = false;
        }

        [Description("表示するエラーメッセージの設定、取得")]
        [DefaultValue("")]
        public string AlertMessage { get; set; }

        [Description("必須入力項目の設定、取得")]
        [DefaultValue(false)]
        public bool Required { get; set; }
    }
}
