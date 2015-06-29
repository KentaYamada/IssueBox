using System;
using System.Data.SqlClient;
using System.Windows.Forms;

using IssueBox.Models;
using IssueBox.Models.Infrastructure;

namespace IssueBox.Views
{
    public partial class EntryIssue : Form
    {
        private Issue _issue = null;

        public EntryIssue()
            : this(new Issue())
        { }

        public EntryIssue(Issue selectedModel)
        {
            InitializeComponent();

            this._issue = selectedModel;
        }

        /// <summary>
        /// フォームロードイベント
        /// </summary>
        private void EntryIssue_Load(object sender, EventArgs e)
        {
            try
            {
                this.cmbCategory.DataSource = DropDownModel.FindAllData(TABLE_NAME.CATEGORIES);
                this.cmbProject.DataSource = DropDownModel.FindAllData(TABLE_NAME.PROJECTS);
                this.cmbProduct.DataSource = DropDownModel.FindAllData(TABLE_NAME.PRODUCTS);
                this.cmbIssuingMember.DataSource = DropDownModel.FindAllData(TABLE_NAME.MEMBERS);
                this.cmbResponcedMember.DataSource = DropDownModel.FindAllData(TABLE_NAME.MEMBERS);
            }
            catch(Exception ex)
            {
 
            }

            this.Initialize();
        }

        private void Initialize()
        {
            this.cmbCategory.DataBindings.Add("SelectedValue", this._issue, "CategoryID");
            this.cmbIssuingMember.DataBindings.Add("SelectedValue", this._issue, "IssuingMemberID");
            this.cmbProject.DataBindings.Add("SelectedValue", this._issue, "ProjectID");
            this.cmbProduct.DataBindings.Add("SelectedValue", this._issue, "ProductID");
            this.cmbResponcedMember.DataBindings.Add("SelectedValue", this._issue, "ResponcedMemberID");
            this.dtDeadLine.DataBindings.Add("GetDate", this._issue, "Deadline", true, DataSourceUpdateMode.OnValidation);
            this.dtOrigination.DataBindings.Add("Value", this._issue, "OriginationDate");
            this.grpStatus.DataBindings.Add("SelectedStatus", this._issue, "Status");
            this.txtComment.DataBindings.Add("Text", this._issue, "Comment");
        }

        /// <summary>
        /// 「保存」ボタンクリックイベント
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this._issue.Save();
                MessageBox.Show("登録しました。");
            }
            catch(SqlException ex)
            {
                //TODO:エラーログ出力機能実装
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 「戻る」ボタンクリックイベント
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
