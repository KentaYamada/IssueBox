using System.Collections.Generic;

using IssueBox.Models;
using IssueBox.Models.Infrastructure;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    /// <summary>
    /// 案件一覧・検索画面
    /// </summary>
    public partial class SearchProject : PanelBase
    {
        private ProjectCondition _cond;
        private List<Project> _projects = null;

        public override string MenuName { get { return "案件一覧・検索"; }  }

        public SearchProject()
        {
            this._cond = new ProjectCondition();
            this._projects = new List<Project>();

            InitializeComponent();

            //基底クラスで実装したコールバック関数でイベントフック
            this.Load += base.Form_Load;
            this.btnNew.Click += base.NewEntryButton_Click;
            this.btnSearch.Click += base.SearchButton_Click;
            this.grdList.CellDoubleClick += base.DataGridView_CellDoubleClick;
        }

        /// <summary>
        /// 初期化処理
        /// </summary>
        protected override void Initialize()
        {
            this.cmbEnable.DataSource = Constants.EnableList;
            this.cmbEnable.DataBindings.Add("SelectedValue", this._cond, "EnableFlag");
            this.cmbEnable.SelectedValue = 0;
            this.txtName.DataBindings.Add("Text", this._cond, "Name");
            this.txtProjectID.DataBindings.Add("Text", this._cond, "ProjectID");
            this.txtProjectID.Focus();
        }

        /// <summary>
        /// データ読み込み
        /// </summary>
        protected override void ReadData()
        {
            try
            {
                this._projects = Project.FindProjectsBy(this._cond);
            }
            catch
            {
                throw;
            }

            this.grdList.DataSource = this._projects;
        }

        /// <summary>
        /// 登録フォーム表示
        /// </summary>
        protected override void ShowEntryWindow()
        {
            using (var form = new EntryProject())
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// 登録フォーム表示
        /// </summary>
        /// <param name="index">選択された行番号</param>
        protected override void ShowEntryWindow(int index)
        {
            using (var form = new EntryProject(this._projects[index]))
            {
                form.ShowDialog();
            }
        }
    }
}
