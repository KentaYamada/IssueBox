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

            this._category = category;

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
            this.txtName.DataBindings.Add("Text", this._category, "Name");
            this.grpEnable.DataBindings.Add("Enable", this._category, "EnableFlag");
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
                result = this._category.Save();
            }
            catch
            {
                throw;
            }

            return result;
        }
    }
}
