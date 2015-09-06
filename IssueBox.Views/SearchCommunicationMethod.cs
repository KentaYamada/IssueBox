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
    public partial class SearchCommunicationMethod : PanelBase
    {
        private Condition _cond = null;

        private List<CommunicationMethod> _comMethod = null;

        #region Constructor

        public SearchCommunicationMethod()
        {
            InitializeComponent();

            this._cond = new Condition();
            this._comMethod = new List<CommunicationMethod>();
            this.btnSearch.Click += base.btnSearch_Click;
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
                this.SetReadData();
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
            this.ShowEntryWindow(new CommunicationMethod());

            try
            {
                this.SetReadData();
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
            }
        }

        /// <summary>
        /// 通信方式一覧取得
        /// </summary>
        protected override void SetReadData()
        {
            try
            {
                this._comMethod = CommunicationMethod.FindCommunicationMethodBy(this._cond);
            }
            catch
            {
                throw;
            }

            this.grdList.DataSource = this._comMethod;
        }

        /// <summary>
        /// セルダブルクリックイベント
        /// </summary>
        private void grdList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ShowEntryWindow(this._comMethod[e.RowIndex]);

            try
            {
                this.SetReadData();
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
        /// カテゴリ設定画面表示
        /// </summary>
        /// <param name="commMethod"></param>
        private void ShowEntryWindow(CommunicationMethod commMethod)
        {
            using (var form = new EntryCommunicationMethod(commMethod))
            {
                form.ShowDialog();
            }
        }
    }
}
