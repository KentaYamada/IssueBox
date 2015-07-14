using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

using IssueBox.Models;
using IssueBox.Models.Infrastructure;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    public partial class SearchMember : PanelBase
    {
        private Condition _cond = null;

        private List<Member> _members = null;

        public SearchMember()
        {
            InitializeComponent();

            this._cond = new Condition();
            this._members = new List<Member>();
        }

        private void SearchMember_Load(object sender, EventArgs e)
        {
            this.Initialize();

            try
            {
                this.SetMembers();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Logger.Error(ex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.SetMembers();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Logger.Error(ex);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.ShowEntryWindow(new Member());

            try
            {
                this.SetMembers();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Logger.Error(ex);
            }
        }

        private void grdList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ShowEntryWindow(this._members[e.RowIndex]);

            try
            {
                this.SetMembers();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
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
        /// <param name="member"></param>
        private void ShowEntryWindow(Member member)
        {
            using (var form = new EntryMember(member))
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// メンバー一覧設定
        /// </summary>
        private void SetMembers()
        {
            try
            {
                this._members = Member.FindMembersBy(this._cond);
            }
            catch
            {
                throw;
            }

            this.grdList.DataSource = this._members;
        }
    }
}
