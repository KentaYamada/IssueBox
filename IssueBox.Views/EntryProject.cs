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
    /// <summary>
    /// 案件登録画面
    /// </summary>
    public partial class EntryProject : EntryFormBase
    {
        private Project _project;

        private List<Equipment> _equipments;

        private List<EquipmentConfiguration> _eqipConf;

        #region Constructors

        public EntryProject()
            :this(new Project())
        { }

        public EntryProject(Project project)
        {
            InitializeComponent();

            this._project = project;
            this._eqipConf = new List<EquipmentConfiguration>();

            //基底クラスで実装したコールバック関数でイベントフック
            this.Load += base.Form_Load;
            this.btnSave.Click += base.RegisterButton_Click;
        }

        #endregion

        /// <summary>
        /// 「メーカー」値変更イベント
        /// </summary>
        private void cmbMaker_SelectedValueChanged(object sender, EventArgs e)
        {
            this.lstEquipments.Items.Clear();

            try
            {
                this._equipments = Equipment.FindEquipmentsBy(Convert.ToInt32(this.cmbMaker.SelectedValue));
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
            }

            if (this._equipments.Count > 0)
            {
                this._equipments.ForEach(x => this.lstEquipments.Items.Add(x.Name));
            }
        }

        /// <summary>
        /// 機器ダブルクリックイベント
        /// </summary>
        private void lstEquipments_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstEquipments.SelectedIndex < 0) { return; }

            var model = new EquipmentConfiguration()
            {
                MakerName = this.cmbMaker.Text,
                EquipName = this.lstEquipments.SelectedItem.ToString(),
                Rating = this._equipments[this.lstEquipments.SelectedIndex].Rating
            };

            this._eqipConf.Add(model);
            this.grdDetail.DataSource = new BindingList<EquipmentConfiguration>(this._eqipConf);
        }

        /// <summary>
        /// 「削除」ボタンクリックイベント
        /// </summary>
        private void grdDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            if (!(sender is DataGridViewButtonCell)) { return; }

            try
            {
                if (this._eqipConf[e.RowIndex].ProjectID == 0)
                {
                    //新規データの場合はリストから削除
                    this._eqipConf.RemoveAt(e.RowIndex);
                }
                else
                {
                    //DBに登録されているデータはDelete文実行
                    this._eqipConf[e.RowIndex].DeleteEquipmentConfiguration();
                }
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
            }

            this.grdDetail.DataSource = new BindingList<EquipmentConfiguration>(this._eqipConf);
        }

        /// <summary>
        /// 初期化処理
        /// </summary>
        protected override void Initialize()
        {
            base.ClearBindings(this.Controls);

            try
            {
                this.cmbMaker.DataSource = DropDownModel.FindAllData(TABLE_NAME.MAKERS);
                this._eqipConf = EquipmentConfiguration.FindEquipmentConfigurationBy(this._project.ID);
            }
            catch
            {
                throw;
            }
            
            this.txtProjectID.DataBindings.Add("Text", this._project, "ProjectID");
            this.txtName.DataBindings.Add("Text", this._project, "Name");
            this.grpEnable.DataBindings.Add("Enable", this._project, "EnableFlag");
            this.grdDetail.DataSource = new BindingList<EquipmentConfiguration>(this._eqipConf);
        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        /// <returns></returns>
        protected override bool Validation()
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

            //案件ID重複チェック
            //登録モード(新規 or 更新)で重複チェックすべきか判定が必要
            //try
            //{
            //    var count = Project.ProjectID_DoubleCheck(this.txtProjectID.Text);
            //    if (count > 0)
            //    {
            //        MessageBox.Show("案件IDが重複しています。");
            //        this.txtProjectID.Focus();
            //        return false;
            //    }
            //}
            //catch
            //{
            //    throw;
            //}

            return true;
        }

        /// <summary>
        /// 登録処理
        /// </summary>
        /// <returns></returns>
        protected override bool Register()
        {
            bool result = false;

            try
            {
                result = this._project.Save(this._eqipConf);
            }
            catch
            {
                throw;
            }

            if (result)
            {
                this._project = null;
                this._project = new Project();
            }

            return result;
        }
    }
}
