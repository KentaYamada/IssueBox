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
            InitializeComponent();

            this._maker = maker;
            this._equipments = new List<Equipment>();
            this._comMethod = new List<DropDownModel>();

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
                this._equipments = Equipment.FindEquipmentsBy(this._maker.ID);
                this._comMethod = DropDownModel.FindAllData(TABLE_NAME.COMMUNICATION_METHOD);
            }
            catch
            {
                throw;
            }

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
        /// 入力チェック
        /// </summary>
        protected override bool Validation()
        {
            base.errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(this.txtName.Text))
            {
                base.errorProvider1.SetError(this.txtName, this.txtName.AlertMessage);
                return false;
            }

            //Todo:グリッド周りの入力チェック
            return true;
        }

        /// <summary>
        /// 登録処理
        /// </summary>
        protected override bool Register()
        {
            bool result = false;

            try
            {
                result = this._maker.Save(this._equipments);
            }
            catch
            {
                throw;
            }
           
            return result;
        }
    }
}
