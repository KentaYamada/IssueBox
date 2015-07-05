using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

using IssueBox.Models;
using IssueBox.Models.Infrastructure;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
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
                this.cmbCategories.DataSource = DropDownModel.FindAllData(TABLE_NAME.CATEGORIES);
                this.cmbProjects.DataSource = DropDownModel.FindAllData(TABLE_NAME.PROJECTS);
                this.cmbProducts.DataSource = DropDownModel.FindAllData(TABLE_NAME.PRODUCTS);
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
            this.cmbProjects.DataBindings.Add("SelectedValue", this._condition, "ProjectID");
            this.cmbProducts.DataBindings.Add("SelectedValue", this._condition, "ProductID");
            this.dtDeadLine.DataBindings.Add("GetDate", this._condition, "Deadline", true, DataSourceUpdateMode.OnValidation);
            this.grpStatus.DataBindings.Add("SelectedStatus", this._condition, "Status");
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
            var model = new IssueSearch();

            try
            {
                this._issues = model.FindIssuesBy(this._condition);
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
    }
}
