using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using IssueBox.Models;
using IssueBox.Models.Infrastructure;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    /// <summary>
    /// メーカー設定画面
    /// </summary>
    public partial class EntryMaker : EntryFormBase
    {
        private Maker _maker;

        private List<Equipment> _equipments;

        private List<DropDownModel> _comMethod;

        #region Constructors

        public EntryMaker()
           : this(new Maker())
        {}

        public EntryMaker(Maker maker)
        {
            this._maker = maker;
            this._equipments = new List<Equipment>();
            this._comMethod = new List<DropDownModel>();

            InitializeComponent();
        }

        #endregion

        /// <summary>
        /// ロードイベント
        /// </summary>
        private void EntryMaker_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        /// <summary>
        /// 初期化設定
        /// </summary>
        private void Initialize()
        {
            base.ClearBindings(this.Controls);

            this._equipments = Equipment.FindEquipmentsBy(this._maker.ID);
            this._comMethod = DropDownModel.FindAllData(TABLE_NAME.COMMUNICATION_METHOD);

            this.txtName.DataBindings.Add("Text", this._maker, "Name");
            this.grpEnable.DataBindings.Add("Enable", this._maker, "EnableFlag");
            this.grdList.DataSource = new BindingList<Equipment>(this._equipments);

            var cell = this.grdList.Columns["CommunicationMethod"] as DataGridViewComboBoxColumn;
            cell.DisplayMember = "Value";
            cell.ValueMember = "ID";
            cell.DataPropertyName = "CommunicationMethodID";
            cell.DataSource = this._comMethod;

            this.txtName.Focus();
        }

        /// <summary>
        /// 「保存」ボタンクリックイベント
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result = this._maker.Save(this._equipments);
            string msg = result ? "登録しました。" : "登録失敗しました。";

            MessageBox.Show(msg);

            if (result)
            {
                this.Initialize();
            }
        }
    }
}
