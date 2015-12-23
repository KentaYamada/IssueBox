using System.Collections.Generic;

using IssueBox.Models;
using IssueBox.Models.Infrastructure;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    /// <summary>
    /// メーカー一覧・検索画面
    /// </summary>
    public partial class SearchMaker : PanelBase
    {
        private List<Maker> _makers;

        public override string MenuName { get { return "メーカー一覧・検索"; } }

        #region Default Constructor

        public SearchMaker()
        {
            InitializeComponent();

            base.Condition = new Condition();
            this._makers = new List<Maker>();

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
                this._makers = Maker.FindMakersBy(base.Condition);
            }
            catch
            {
                throw;
            }

            this.grdList.DataSource = this._makers;
        }

        /// <summary>
        /// 登録フォーム表示
        /// </summary>
        protected override void ShowEntryWindow()
        {
            using (var form = new EntryMaker())
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
            using (var form = new EntryMaker(this._makers[index]))
            {
                form.ShowDialog();
            }
        }
    }
}
