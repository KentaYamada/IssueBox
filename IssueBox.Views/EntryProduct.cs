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
        private Product _product = null;

        #region Constructors

        public EntryProduct()
            :this(new Product())
        { }

        public EntryProduct(Product product)
        {
            InitializeComponent();
            this.Initialize(product);
        }

        #endregion

        /// <summary>
        /// 「保存」ボタンクリックイベント
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.Validation()) { return; }

            try
            {
                this._product.Save();
                MessageBox.Show("登録しました。");
                this.Initialize(new Product());
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
        private void Initialize(Product product)
        {
            base.ClearBindings(this.Controls);

            this._product = null;
            this._product = product;
            this.txtName.DataBindings.Add("Text", this._product, "Name");
            this.txtVersion.DataBindings.Add("Text", this._product, "Version");
            this.grpStatus.DataBindings.Add("SelectedStatus", this._product, "ProductType");
            this.grpEnable.DataBindings.Add("Enable", this._product, "EnableFlag");
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
                this.txtName.Focus();
                return false;
            }

            return true;
        }
    }
}
