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
    /// メーカー一覧・検索画面
    /// </summary>
    public partial class SearchMaker : PanelBase
    {
        private List<Maker> _makers = null;

        #region Default Constructor

        public SearchMaker()
        {
            base.Condition = new Condition();
            this._makers = new List<Maker>();

            InitializeComponent();
        }

        #endregion

        /// <summary>
        /// フォームロードイベント
        /// </summary>
        private void SearchMaker_Load(object sender, EventArgs e)
        {
            this.cmbEnable.DataSource = Constants.EnableList;

            try
            {
                this.ReadData();
            }
            catch(SqlException ex)
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
                this.ReadData();
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
            }
        }

        /// <summary>
        /// 「新規登録」ボタンクリックイベント
        /// </summary>
        private void btnNew_Click(object sender, EventArgs e)
        {
            base.ShowEntryWindow(new EntryMaker(new Maker()));

            try
            {
                this.ReadData();
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
            }
        }

        /// <summary>
        /// セルダブルクリックイベント
        /// </summary>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            this.ShowEntryWindow(new EntryMaker(this._makers[e.RowIndex]));

            try
            {
                this.ReadData();
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
            }
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
    }
}
