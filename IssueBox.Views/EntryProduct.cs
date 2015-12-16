using System;
using System.Windows.Forms;
using IssueBox.Models;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    /// <summary>
    /// 製品設定画面
    /// </summary>
    public partial class EntryProduct : EntryFormBase
    {
        private Product _product;

        #region Constructors

        public EntryProduct()
            :this(new Product())
        { }

        public EntryProduct(Product product)
        {
            InitializeComponent();

            this._product = product;

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
            this.txtName.DataBindings.Add("Text", this._product, "Name");
            this.txtVersion.DataBindings.Add("Text", this._product, "Version");
            this.grpStatus.DataBindings.Add("SelectedStatus", this._product, "ProductType");
            this.grpEnable.DataBindings.Add("Enable", this._product, "EnableFlag");
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
                this.txtName.Focus();
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
                result = this._product.Save();
            }
            catch
            {
                throw;
            }

            if (result)
            {
                this._product = null;
                this._product = new Product();
            }

            return result;
        }
    }
}
