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
    /// 単位一覧画面
    /// </summary>
    public partial class SearchUnit : PanelBase
    {
        private Condition _cond = null;

        private List<Unit> _units = null;

        #region Default constructor

        public SearchUnit()
        {
            InitializeComponent();

            this._cond = new Condition();
            this._units = new List<Unit>();
        }

        #endregion

        /// <summary>
        /// ロードイベント
        /// </summary>
        private void SearchUnit_Load(object sender, EventArgs e)
        {
            this.Initialize();

            try
            {
                this.SetUnits();
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
            this.ShowEntryWindow(new Unit());

            try
            {
                this.SetUnits();
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
                this.SetUnits();
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
            }
        }

        /// <summary>
        /// セルダブルクリックイベント
        /// </summary>
        private void grdList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            this.ShowEntryWindow(this._units[e.RowIndex]);

            try
            {
                this.SetUnits();
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
            }
        }

        /// <summary>
        /// 初期化処理
        /// </summary>
        private void Initialize()
        {
            this.cmbEnable.DataSource = Constants.EnableList;
            this.cmbEnable.DataBindings.Add("SelectedValue", this._cond, "EnableFlag");
            this.txtName.DataBindings.Add("Text", this._cond, "Name");
            this.txtName.Focus();
        }

        /// <summary>
        /// 単位一覧取得
        /// </summary>
        private void SetUnits()
        {
            try
            {
                this._units = Unit.FindUnitsBy(this._cond);
            }
            catch
            {
                throw;
            }

            this.grdList.DataSource = this._units;
        }

        /// <summary>
        /// カテゴリ設定画面表示
        /// </summary>
        /// <param name="unit"></param>
        private void ShowEntryWindow(Unit unit)
        {
            using (var form = new EntryUnit(unit))
            {
                form.ShowDialog();
            }
        }
    }
}
