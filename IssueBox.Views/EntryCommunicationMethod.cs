using IssueBox.Models;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    /// <summary>
    /// 通信方式設定画面
    /// </summary>
    public partial class EntryCommunicationMethod : EntryFormBase
    {
        private CommunicationMethod _comMethod;

        #region Constructors

        public EntryCommunicationMethod()
            : this(new CommunicationMethod())
        {}

        public EntryCommunicationMethod(CommunicationMethod comMethod)
        {
            InitializeComponent();

            this._comMethod = comMethod;

            //基底クラスで実装したコールバック関数でイベントフック
            this.Load += base.Form_Load;
            this.btnSave.Click += base.RegisterButton_Click;
        }

        #endregion

        /// <summary>
        /// 初期化設定
        /// </summary>
        protected override void Initialize()
        {
            base.ClearBindings(this.Controls);
            this.txtName.DataBindings.Add("Text", this._comMethod, "Name");
            this.grpEnable.DataBindings.Add("Enable", this._comMethod, "EnableFlag");
            this.txtName.Focus();
        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        protected override bool Validation()
        {
            base.errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(this.txtName.Text))
            {
                base.errorProvider1.SetError(this.txtName, this.txtName.AlertMessage);
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
                result = this._comMethod.Save();
            }
            catch
            {
                throw;
            }

            return result;
        }
    }
}
