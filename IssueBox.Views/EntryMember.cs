using System.Linq;

using IssueBox.Models;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    /// <summary>
    /// メンバー設定画面
    /// </summary>
    public partial class EntryMember : EntryFormBase
    {
        private Member _member;

        #region Constructors

        public EntryMember()
            :this(new Member())
        {}

        public EntryMember(Member member)
        {
            InitializeComponent();

            this._member = member;

            //基底クラスで実装したコールバック関数でイベントフック
            this.Load += base.Form_Load;
            this.btnSave.Click += base.RegisterButton_Click;
        }

        #endregion

        /// <summary>
        /// 初期設定
        /// </summary>
        protected override void Initialize()
        {
            base.ClearBindings(this.Controls);
            this.txtName.DataBindings.Add("Text", this._member, "Name");
            this.txtLoginID.DataBindings.Add("Text", this._member, "LoginID");
            this.txtLoginPW.DataBindings.Add("Text", this._member, "LoginPassword");
            this.grpEnable.DataBindings.Add("Enable", this._member, "EnableFlag");
            this.txtName.Focus();
        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        protected override bool Validation()
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

        /// <summary>
        /// 登録処理
        /// </summary>
        protected override bool Register()
        {
            bool result = false;

            try
            {
                result = this._member.Save();
            }
            catch
            {
                throw;
            }

            return result;
        }
    }
}
