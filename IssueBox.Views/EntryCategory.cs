using System;
using System.Windows.Forms;
using IssueBox.Models;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    /// <summary>
    /// カテゴリ設定画面
    /// </summary>
    public partial class EntryCategory : EntryFormBase
    {
        private Category _category;

        #region Constructors

        public EntryCategory()
           : this(new Category())
        {}

        public EntryCategory(Category category)
        {
            InitializeComponent();
            this.Initialize(category);
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
                this._category.Save();
                MessageBox.Show("登録しました。");

                this.Initialize(new Category());
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 初期設定
        /// </summary>
        private void Initialize(Category category)
        {
            base.ClearBindings(this.Controls);

            this._category = null;
            this._category = category;
            this.txtName.DataBindings.Add("Text", this._category, "Name");
            this.grpEnable.DataBindings.Add("Enable", this._category, "EnableFlag");
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
