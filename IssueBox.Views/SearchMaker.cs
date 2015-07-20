using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

using IssueBox.Models;
using IssueBox.Models.Infrastructure;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    public partial class SearchMaker : PanelBase
    {
        private Condition _cond = null;

        private List<Maker> _makers = null;

        public SearchMaker()
        {
            InitializeComponent();

            this._cond = new Condition();
            this._makers = new List<Maker>();
        }

        private void SearchMaker_Load(object sender, EventArgs e)
        {
            try
            {
                this.cmbEnable.DataSource = Constants.EnableList;
                this.SetMakers();
            }
            catch(SqlException ex)
            {
                Logger.Error(ex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.SetMakers();
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.ShowEntryWindow(new Maker());

            try
            {
                this.SetMakers();
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            this.ShowEntryWindow(this._makers[e.RowIndex]);

            try
            {
                this.SetMakers();
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
            }
        }

        private void SetMakers()
        {
            try
            {
                this._makers = Maker.FindMakersBy(this._cond);
            }
            catch
            {
                throw;
            }

            this.grdList.DataSource = this._makers;
        }

        /// <summary>
        /// メーカー設定画面表示
        /// </summary>
        /// <param name="maker"></param>
        private void ShowEntryWindow(Maker maker)
        {
            using (var form = new EntryMaker())
            {
                form.ShowDialog();
            }
        }
    }
}
