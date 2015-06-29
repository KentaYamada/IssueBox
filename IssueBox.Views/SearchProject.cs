using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

using IssueBox.Models;
using IssueBox.Models.Infrastructure;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    public partial class SearchProject : PanelBase
    {
        private ProjectCondition _cond = null;
        
        private List<Project> _projects = null;

        public SearchProject()
        {
            this._cond = new ProjectCondition();
            this._projects = new List<Project>();

            InitializeComponent();
        }

        private void SearchProject_Load(object sender, EventArgs e)
        {
            this.Initialize();

            try
            {
                this.SetProjects();
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
                this.SetProjects();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.ShowEntryWindow(new Project());

            try
            {
                this.SetProjects();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grdList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ShowEntryWindow(this._projects[e.RowIndex]);

            try
            {
                this.SetProjects();
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
            this.cmbEnable.SelectedValue = 0;
            this.txtName.DataBindings.Add("Text", this._cond, "Name");
            this.txtProjectID.DataBindings.Add("Text", this._cond, "ProjectID");
            this.txtProjectID.Focus();
        }

        /// <summary>
        /// 製品一覧設定
        /// </summary>
        private void SetProjects()
        {
            var model = new Project();

            try
            {
                this._projects = model.FindProjectsBy(this._cond);
            }
            catch
            {
                throw;
            }

            this.grdList.DataSource = this._projects;
        }

        /// <summary>
        /// カテゴリ設定画面表示
        /// </summary>
        /// <param name="project"></param>
        private void ShowEntryWindow(Project project)
        {
            using (var form = new EntryProject(project))
            {
                form.ShowDialog();
            }
        }
    }
}
