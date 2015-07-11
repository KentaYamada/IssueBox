using System;
using System.Data.SqlClient;
using System.Windows.Forms;

using IssueBox.Models;
using IssueBox.Models.Infrastructure;
using IssueBox.Views.Infrastructure;

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
                //FixMe:メンバー取得方法詳細決める
                this.cmbCategory.DataSource = DropDownModel.FindAllData(TABLE_NAME.CATEGORIES);
                this.cmbProject.DataSource = DropDownModel.FindAllData(TABLE_NAME.PROJECTS);
                this.cmbProduct.DataSource = DropDownModel.FindAllData(TABLE_NAME.PRODUCTS);
                this.cmbIssuingMember.DataSource = DropDownModel.FindAllData(TABLE_NAME.MEMBERS);
                this.cmbResponcedMember.DataSource = DropDownModel.FindAllData(TABLE_NAME.MEMBERS);
                this.cmbCheckedMember.DataSource = DropDownModel.FindAllData(TABLE_NAME.MEMBERS);
                this.Initialize();
            }
            catch(Exception ex)
            {
                Logger.Error(ex);
            }
        }

        private void Initialize()
        {
            this.cmbCategory.DataBindings.Add("SelectedValue", this._issue, "CategoryID", true, DataSourceUpdateMode.OnValidation);
            this.cmbIssuingMember.DataBindings.Add("SelectedValue", this._issue, "IssuingMemberID", true, DataSourceUpdateMode.OnValidation);
            this.cmbProject.DataBindings.Add("SelectedValue", this._issue, "ProjectID", true, DataSourceUpdateMode.OnValidation);
            this.cmbProduct.DataBindings.Add("SelectedValue", this._issue, "ProductID", true, DataSourceUpdateMode.OnValidation);
            this.cmbResponcedMember.DataBindings.Add("SelectedValue", this._issue, "ResponcedMemberID", true, DataSourceUpdateMode.OnValidation);
            this.cmbCheckedMember.DataBindings.Add("SelectedValue", this._issue, "CheckedMemberID", true, DataSourceUpdateMode.OnValidation);
            this.dtDeadLine.DataBindings.Add("GetDate", this._issue, "Deadline", true, DataSourceUpdateMode.OnValidation);
            this.dtOrigination.DataBindings.Add("Value", this._issue, "OriginationDate", true, DataSourceUpdateMode.OnValidation);
            this.grpStatus.DataBindings.Add("SelectedStatus", this._issue, "Status", true, DataSourceUpdateMode.OnValidation);
            this.dtFinishedDate.DataBindings.Add("GetDate", this._issue, "FinishedDate", true, DataSourceUpdateMode.OnValidation);
            this.txtComment.DataBindings.Add("Text", this._issue, "Comment", true, DataSourceUpdateMode.OnValidation);
            this.dtOrigination.Focus();
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
                Logger.Error(ex);
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
