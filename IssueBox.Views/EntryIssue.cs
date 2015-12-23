using System.Linq;
using System.Windows.Forms;

using IssueBox.Models;
using IssueBox.Models.Infrastructure;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    public partial class EntryIssue : EntryFormBase
    {
        private Issue _issue;

        #region Constructors

        public EntryIssue()
            : this(new Issue())
        { }

        public EntryIssue(Issue issue)
        {
            InitializeComponent();

            this._issue = issue;

            //基底クラスで実装したコールバック関数でイベントフック
            this.Load += base.Form_Load;
            this.btnSave.Click += base.RegisterButton_Click;
        }

        #endregion

        /// <summary>
        /// 初期化設定
        /// </summary>
        protected override void Initialize()
        {
            base.ClearBindings(this.Controls);

            try
            {
                this.cmbCategory.DataSource = DropDownModel.FindAllData(TABLE_NAME.CATEGORIES);
                this.cmbProject.DataSource = DropDownModel.FindAllData(TABLE_NAME.PROJECTS);
                this.cmbProduct.DataSource = DropDownModel.FindAllData(TABLE_NAME.PRODUCTS);
                this.cmbIssuingMember.DataSource = DropDownModel.FindAllData(TABLE_NAME.MEMBERS);
                this.cmbResponcedMember.DataSource = DropDownModel.FindAllData(TABLE_NAME.MEMBERS);
                this.cmbCheckedMember.DataSource = DropDownModel.FindAllData(TABLE_NAME.MEMBERS);
            }
            catch
            {
                throw;
            }

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

            if (TASK_STATUS.DONE == (TASK_STATUS)this._issue.Status)
            {
                //ステータスが「完了」の場合、編集不可とする
                this.Controls.OfType<Control>()
                             .Where(x => x.Name != "btnReturn")
                             .ToList()
                             .ForEach(x => x.Enabled = false);
            }

            this.dtOrigination.Focus();
        }


        /// <summary>
        /// 登録処理
        /// </summary>
        protected override bool Register()
        {
            bool result = false;

            try
            {
                result = this._issue.Save();
            }
            catch
            {
                throw;
            }

            if (result)
            {
                this._issue = null;
                this._issue = new Issue();
            }

            return result;
        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        protected override bool Validation()
        {
            return true;
        }
    }
}
