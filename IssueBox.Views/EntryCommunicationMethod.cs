using System;
using System.Windows.Forms;
using IssueBox.Models;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    /// <summary>
    /// 通信方式設定画面
    /// </summary>
    public partial class EntryCommunicationMethod : EntryFormBase
    {
        private CommunicationMethod _comMethod = null;

        #region Constructors

        public EntryCommunicationMethod()
            : this(new CommunicationMethod())
        {}

        public EntryCommunicationMethod(CommunicationMethod comMethod)
        {
            InitializeComponent();
            this.Initialize(comMethod);
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
                this._comMethod.Save();
                MessageBox.Show("登録しました。");
                this.Initialize(new CommunicationMethod());
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 初期化設定
        /// </summary>
        private void Initialize(CommunicationMethod comMethod)
        {
            base.ClearBindings(this.Controls);

            this._comMethod = null;
            this._comMethod = comMethod;
            this.txtName.DataBindings.Add("Text", this._comMethod, "Name");
            this.grpEnable.DataBindings.Add("Enable", this._comMethod, "EnableFlag");
            this.txtName.Focus();
        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        private bool Validation()
        {
            base.errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(this.txtName.Text))
            {
                base.errorProvider1.SetError(this.txtName, this.txtName.AlertMessage);
                return false;
            }

            return true;
        }
    }
}
