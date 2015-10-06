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
    /// 課題検索
    /// </summary>
    public partial class SearchIssue : PanelBase
    {
        private List<IssueSearch> _issues = null;
        private IssueCondition _condition = null;

        public SearchIssue()
        {
            InitializeComponent();

            this._condition = new IssueCondition();
            this._issues = new List<IssueSearch>();
        }

        /// <summary>
        /// フォームロードイベント
        /// </summary>
        private void SearchIssue_Load(object sender, EventArgs e)
        {
            this.Initialize();

            try
            {
                //Fix Me:検索条件の仕様決める
                //this.cmbCategories.DataSource = DropDownModel.FindAllData(TABLE_NAME.CATEGORIES);
                this.cmbProjects.DataSource = DropDownModel.FindAllData(TABLE_NAME.PROJECTS, false);
                //this.cmbProducts.DataSource = DropDownModel.FindAllData(TABLE_NAME.PRODUCTS);
                this.SetIssues();
            }
            catch(SqlException ex)
            {
                Logger.Error(ex);
            }
        }

        /// <summary>
        /// 初期設定
        /// </summary>
        private void Initialize()
        {
            this.cmbCategories.DataBindings.Add("SelectedValue", this._condition, "CategoryID");
            this.cmbProjects.DataBindings.Add("SelectedValue", this._condition, "ProjectID", true, DataSourceUpdateMode.OnValidation);
            this.cmbProducts.DataBindings.Add("SelectedValue", this._condition, "ProductID");
            this.dtDeadlineFrom.DataBindings.Add("GetDate", this._condition, "DeadlineFrom", true, DataSourceUpdateMode.OnValidation);
            this.dtDeadlineTo.DataBindings.Add("GetDate", this._condition, "DeadlineTo", true, DataSourceUpdateMode.OnValidation);
            //this.grpStatus.DataBindings.Add("SelectedStatus", this._condition, "Status");
        }

        /// <summary>
        /// 「新規作成」ボタンクリックイベント
        /// </summary>
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.ShowEntryIssue(new IssueSearch());

            try
            {
                this.SetIssues();
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
            }
        }

        /// <summary>
        /// 「検索」ボタンクリックイベント
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.SetIssues();
            }
            catch(SqlException ex)
            {
                Logger.Error(ex); 
            }
        }

        /// <summary>
        /// 課題一覧セット
        /// </summary>
        private void SetIssues()
        {
            try
            {
                this._issues = Issue.FindIssuesBy(this._condition);
            }
            catch
            {
                throw;
            }

            this.grdList.DataSource = this._issues;
        }

        /// <summary>
        /// 課題登録画面表示
        /// </summary>
        private void ShowEntryIssue(IssueSearch model)
        {
            using (var form = new EntryIssue(model))
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// セルダブルクリックイベント
        /// </summary>
        private void grdList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            this.ShowEntryIssue(this._issues[e.RowIndex]);

            try
            {
                this.SetIssues();
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
            }
        }
    }
}
