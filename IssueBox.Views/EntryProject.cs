using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

using IssueBox.Models;
using IssueBox.Models.Infrastructure;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    public partial class EntryProject : EntryFormBase
    {
        private Project _project = null;

        public EntryProject()
            :this(new Project())
        { }

        public EntryProject(Project project)
        {
            InitializeComponent();

            this._project = project;
            this.txtProjectID.DataBindings.Add("Text", this._project, "ProjectID");
            this.txtName.DataBindings.Add("Text", this._project, "Name");
            this.grpEnable.DataBindings.Add("Enable", this._project, "EnableFlag");
        }

        private void EntryProject_Load(object sender, EventArgs e)
        {
            try
            {
                this.cmbMaker.DataSource = DropDownModel.FindAllData(TABLE_NAME.MAKERS);
            }
            catch(SqlException ex)
            {
                Logger.Error(ex);
            }
        }

        private void cmbMaker_SelectedValueChanged(object sender, EventArgs e)
        {
            //ToDo:メーカーに紐づく機器一覧を表示
            try
            {
                int id = (int)this.cmbMaker.SelectedValue;
                this.lstEquipments.DisplayMember = "Name";
                this.lstEquipments.DataSource = Equipment.FindEquipmentsBy(id);
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                //ToDo:チェックされた機器情報をDgvに表示
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.Validation()) { return; }

            try
            {
                this._project.Save();
                MessageBox.Show("登録しました。");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        /// <returns></returns>
        private bool Validation()
        {
            base.errorProvider1.Clear();
            var target = this.Controls.OfType<TextBoxEx>()
                                      .Where(x => x.Required && string.IsNullOrWhiteSpace(x.Text))
                                      .OrderBy(x => x.TabIndex)
                                      .ToList();
            if (0 < target.Count)
            {
                base.errorProvider1.SetError(target[0], target[0].AlertMessage);
                return false;
            }

            return true;
        }
    }
}
