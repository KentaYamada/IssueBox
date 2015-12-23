using System.Collections.Generic;
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
        private List<IssueSearch> _issues;
        private IssueCondition _condition;

        public override string MenuName { get { return "タスク一覧・検索"; } }

        public SearchIssue()
        {
            InitializeComponent();

            this._condition = new IssueCondition();
            this._issues = new List<IssueSearch>();

            //基底クラスで実装したコールバック関数でイベントフック
            this.Load += base.Form_Load;
            this.btnNew.Click += base.NewEntryButton_Click;
            this.btnSearch.Click += base.SearchButton_Click;
            this.grdList.CellDoubleClick += base.DataGridView_CellDoubleClick;
        }

        /// <summary>
        /// 初期設定
        /// </summary>
        protected override void Initialize()
        {
            try
            {
                //ToDo:検索条件の機能まとめる
                this.cmbCategories.DataSource = DropDownModel.FindAllData(TABLE_NAME.CATEGORIES);
                this.cmbProjects.DataSource = DropDownModel.FindAllData(TABLE_NAME.PROJECTS, false);
                this.cmbProducts.DataSource = DropDownModel.FindAllData(TABLE_NAME.PRODUCTS);
            }
            catch
            {
                throw;
            }

            this.cmbCategories.DataBindings.Add("SelectedValue", this._condition, "CategoryID");
            this.cmbProjects.DataBindings.Add("SelectedValue", this._condition, "ProjectID", true, DataSourceUpdateMode.OnValidation);
            this.cmbProducts.DataBindings.Add("SelectedValue", this._condition, "ProductID");
            this.dtDeadlineFrom.DataBindings.Add("GetDate", this._condition, "DeadlineFrom", true, DataSourceUpdateMode.OnValidation);
            this.dtDeadlineTo.DataBindings.Add("GetDate", this._condition, "DeadlineTo", true, DataSourceUpdateMode.OnValidation);
            //this.grpStatus.DataBindings.Add("SelectedStatus", this._condition, "Status");
        }

        /// <summary>
        /// データ読み込み
        /// </summary>
        protected override void ReadData()
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
        /// 登録フォーム表示
        /// </summary>
        protected override void ShowEntryWindow()
        {
            using (var form = new EntryIssue())
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
            using (var form = new EntryIssue(this._issues[index]))
            {
                form.ShowDialog();
            }
        }
    }
}
