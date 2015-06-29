using System;
using System.Linq;
using System.Windows.Forms;

using IssueBox.Models;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    public partial class EntryMember : EntryFormBase
    {
        private Member _member = null;

        #region Constructors

        public EntryMember()
            :this(new Member())
        {}

        public EntryMember(Member member)
        {
            InitializeComponent();

            this._member = member;
            this.txtName.DataBindings.Add("Text", this._member, "Name");
            this.txtLoginID.DataBindings.Add("Text", this._member, "LoginID");
            this.txtLoginPW.DataBindings.Add("Text", this._member, "LoginPassword");
            this.grpEnable.DataBindings.Add("Enable", this._member, "EnableFlag");
        }

        #endregion

        /// <summary>
        /// 「保存」ボタンクリックイベント
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.Validation())
            {
                return;
            }

            try
            {
                this._member.Save();
                MessageBox.Show("登録しました。");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        /// <returns>True:OK / False:Error</returns>
        private bool Validation()
        {
            base.errorProvider1.Clear();
            var target = this.Controls.OfType<TextBoxEx>()
                                      .Where(x => x.Required && string.IsNullOrWhiteSpace(x.Text))
                                      .OrderBy(x => x.TabIndex)
                                      .ToList();
            if (0 < target.Count)
            {
                base.errorProvider1.SetError(target[0], target[0].AlertMessage);
                return false;
            }

            return true;
        }
    }
}
