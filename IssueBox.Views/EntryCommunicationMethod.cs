using System;
using System.Windows.Forms;
using IssueBox.Models;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    /// <summary>
    /// カテゴリ設定
    /// </summary>
    public partial class EntryCommunicationMethod : EntryFormBase
    {
        private CommunicationMethod _comMethod = null;

        public EntryCommunicationMethod()
            : this(new CommunicationMethod())
        {}

        public EntryCommunicationMethod(CommunicationMethod category)
        {
            
            InitializeComponent();

            this._comMethod = category;
            this.txtName.DataBindings.Add("Text", this._comMethod, "Name");
            this.grpEnable.DataBindings.Add("Enable", this._comMethod, "EnableFlag");
        }

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        /// <returns></returns>
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
