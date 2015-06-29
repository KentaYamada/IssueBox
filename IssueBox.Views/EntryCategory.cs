using System;
using System.Windows.Forms;
using IssueBox.Models;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    /// <summary>
    /// カテゴリ設定
    /// </summary>
    public partial class EntryCategory : EntryFormBase
    {
        private Category _category = null;

        public EntryCategory()
           : this(new Category())
        {}

        public EntryCategory(Category category)
        {
            
            InitializeComponent();

            this._category = category;
            this.txtName.DataBindings.Add("Text", this._category, "Name");
            this.grpEnable.DataBindings.Add("Enable", this._category, "EnableFlag");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.Validation()) 
            {
                return;
            }

            try
            {
                this._category.Save();
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
