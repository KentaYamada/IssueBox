using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

using IssueBox.Models;
using IssueBox.Models.Infrastructure;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    /// <summary>
    /// カテゴリ一覧
    /// </summary>
    public partial class SearchCategory : PanelBase
    {
        private Condition _cond = null;

        private List<Category> _categories = null;

        #region Constructor

        public SearchCategory()
        {
            InitializeComponent();

            this._cond = new Condition();
            this._categories = new List<Category>();
        }

        #endregion

        /// <summary>
        /// フォームロードイベント
        /// </summary>
        private void SearchCategory_Load(object sender, EventArgs e)
        {
            this.Initialize();
            
            try
            {
                this.SetCategories();
            }
            catch (SqlException ex)
            {
                Debug.Print(ex.Message);
            }
        }

        /// <summary>
        /// 「新規登録」ボタンクリックイベント
        /// </summary>
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.ShowEntryWindow(new Category());

            try
            {
                this.SetCategories();
            }
            catch (SqlException ex)
            {
                Debug.Print(ex.Message);
            }
        }

        /// <summary>
        /// 「検索」ボタンクリックイベント
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.SetCategories();
            }
            catch (SqlException ex)
            {
                Debug.Print(ex.Message);
            }
        }

        /// <summary>
        /// セルダブルクリックイベント
        /// </summary>
        private void grdList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ShowEntryWindow(this._categories[e.RowIndex]);

            try
            {
                this.SetCategories();
            }
            catch (SqlException ex)
            {
                Debug.Print(ex.Message);
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
        /// カテゴリ一覧設定
        /// </summary>
        private void SetCategories()
        {
            var model = new Category();

            try
            {
                this._categories = model.FindByCategories(this._cond);
            }
            catch
            {
                throw;
            }

            this.grdList.DataSource = this._categories;
        }

        /// <summary>
        /// カテゴリ設定画面表示
        /// </summary>
        /// <param name="category"></param>
        private void ShowEntryWindow(Category category)
        {
            using (var form = new EntryCategory(category))
            {
                form.ShowDialog();
            }
        }
    }
}
