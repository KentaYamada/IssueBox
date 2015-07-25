using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

using IssueBox.Models;
using IssueBox.Models.Infrastructure;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    /// <summary>
    /// 製品検索
    /// </summary>
    public partial class SearchProduct : PanelBase
    {
        private Condition _cond = null;

        private List<Product> _products = null;

        public SearchProduct()
        {
            InitializeComponent();

            this._cond = new Condition();
            this._products = new List<Product>();
        }

        private void SearchProduct_Load(object sender, EventArgs e)
        {
            this.Initialize();

            try
            {
                this.SetProducts();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.SetProducts();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.ShowEntryWindow(new Product());

            try
            {
                this.SetProducts();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// セルダブルクリックイベント
        /// </summary>
        private void grdList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            this.ShowEntryWindow(this._products[e.RowIndex]);

            try
            {
                this.SetProducts();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 初期化処理
        /// </summary>
        private void Initialize()
        {
            this.cmbEnable.DataSource = Constants.EnableList;
            this.cmbEnable.DataBindings.Add("SelectedValue", this._cond, "EnableFlag");
            this.cmbEnable.SelectedIndex = 0;
            this.txtName.DataBindings.Add("Text", this._cond, "Name");
            this.txtName.Focus();
        }

        /// <summary>
        /// 製品一覧設定
        /// </summary>
        private void SetProducts()
        {
            try
            {
                this._products = Product.FindProductsBy(this._cond);
            }
            catch
            {
                throw;
            }

            this.grdList.DataSource = this._products;
        }

        /// <summary>
        /// カテゴリ設定画面表示
        /// </summary>
        /// <param name="product"></param>
        private void ShowEntryWindow(Product product)
        {
            using (var form = new EntryProduct(product))
            {
                form.ShowDialog();
            }
        }
    }
}
