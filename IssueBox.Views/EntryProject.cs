using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private List<Equipment> _equipments = null;

        private List<EquipmentConfiguration> _eqipConf = null;

        public EntryProject()
            :this(new Project())
        { }

        public EntryProject(Project project)
        {
            InitializeComponent();

            this._project = project;
            this._eqipConf = new List<EquipmentConfiguration>();
            this.txtProjectID.DataBindings.Add("Text", this._project, "ProjectID");
            this.txtName.DataBindings.Add("Text", this._project, "Name");
            this.grpEnable.DataBindings.Add("Enable", this._project, "EnableFlag");
            //this.grdDetail.DataSource = new BindingList<EquipmentConfiguration>(this._eqipConf);
        }

        private void EntryProject_Load(object sender, EventArgs e)
        {
            try
            {
                this.cmbMaker.DataSource = DropDownModel.FindAllData(TABLE_NAME.MAKERS);
                this._eqipConf = EquipmentConfiguration.FindEquipmentConfigurationBy(this._project.ID);
                this.grdDetail.DataSource = new BindingList<EquipmentConfiguration>(this._eqipConf);
            }
            catch(SqlException ex)
            {
                Logger.Error(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.Validation()) { return; }

            try
            {
                this._project.Save(this._eqipConf);
                MessageBox.Show("登録しました。");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbMaker_SelectedValueChanged(object sender, EventArgs e)
        {
            //ToDo:メーカーに紐づく機器一覧を表示
            this.lstEquipments.Items.Clear();

            try
            {
                int id = (int)this.cmbMaker.SelectedValue;
                this._equipments = Equipment.FindEquipmentsBy(id);
                this._equipments.ForEach(x => this.lstEquipments.Items.Add(x.Name));
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
            }
        }

        private void lstEquipments_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstEquipments.SelectedIndex < 0) { return; }

            var model = new EquipmentConfiguration()
            {
                MakerName = this.cmbMaker.Text,
                EquipName = this.lstEquipments.SelectedItem.ToString(),
                Rating = this._equipments[this.lstEquipments.SelectedIndex].Rating,
            };

            //↓↓↓Fix Me↓↓↓
            this._eqipConf.Add(model);
            this.grdDetail.DataSource = new BindingList<EquipmentConfiguration>(this._eqipConf);
            this.grdDetail.Update();
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
