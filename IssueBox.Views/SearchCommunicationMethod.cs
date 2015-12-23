using System.Collections.Generic;

using IssueBox.Models;
using IssueBox.Models.Infrastructure;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    /// <summary>
    /// 通信方式一覧・検索画面
    /// </summary>
    public partial class SearchCommunicationMethod : PanelBase
    {
        private List<CommunicationMethod> _comMethod = null;

        public override string MenuName { get { return "通信方式一覧・検索"; } }

        #region Default Constructor

        public SearchCommunicationMethod()
        {
            InitializeComponent();

            base.Condition = new Condition();
            this._comMethod = new List<CommunicationMethod>();

            //基底クラスで実装したコールバック関数でイベントフック
            this.Load += base.Form_Load;
            this.btnNew.Click += base.NewEntryButton_Click;
            this.btnSearch.Click += base.SearchButton_Click;
            this.grdList.CellDoubleClick += base.DataGridView_CellDoubleClick;
        }

        #endregion

        /// <summary>
        /// 初期化処理
        /// </summary>
        protected override void Initialize()
        {
            this.cmbEnable.DataSource = Constants.EnableList;
            this.cmbEnable.DataBindings.Add("SelectedValue", base.Condition, "EnableFlag");
            this.txtName.DataBindings.Add("Text", base.Condition, "Name");
            this.txtName.Focus();
        }

        /// <summary>
        /// データ読み込み
        /// </summary>
        protected override void ReadData()
        {
            try
            {
                this._comMethod = CommunicationMethod.FindCommunicationMethodBy(base.Condition);
            }
            catch
            {
                throw;
            }

            this.grdList.DataSource = this._comMethod;
        }
        
        /// <summary>
        /// 登録フォーム表示
        /// </summary>
        protected override void ShowEntryWindow()
        {
            using (var form = new EntryCommunicationMethod())
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
            using (var form = new EntryCommunicationMethod(this._comMethod[index]))
            {
                form.ShowDialog();
            }
        }
    }
}
