using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueBox.Views.Infrastructure
{
    public class DateMaskedTextBox : MaskedTextBox
    {
        /// <summary>
        /// 日付取得
        /// </summary>
        public DateTime? GetDate
        {
            get
            {
                //マスク文字列を取り除く
                this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                DateTime? dt = null;
                DateTime now = DateTime.Now;

                if (!string.IsNullOrEmpty(this.Text))
                {
                    this.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                    if (DateTime.TryParse(this.Text, out now))
                    {
                        dt = DateTime.Parse(this.Text);
                    }
                }

                return dt;
            }
            set
            {
                this.Text = Convert.ToString(value);
            }
        }

        public DateMaskedTextBox()
            : base("0000/00/00")
        { }
    }
}
