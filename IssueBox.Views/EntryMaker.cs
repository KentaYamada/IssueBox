using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

using IssueBox.Models;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    /// <summary>
    /// メーカー設定画面
    /// </summary>
    public partial class EntryMaker : EntryFormBase
    {
        private Maker _maker = null;

        private List<Equipment> _equipments = null;

        #region Constructors

        public EntryMaker()
           : this(new Maker())
        {}

        public EntryMaker(Maker maker)
        {
            InitializeComponent();
            this.Initialize(maker, new List<Equipment>());
        }

        #endregion

        /// <summary>
        /// ロードイベント
        /// </summary>
        private void EntryMaker_Load(object sender, EventArgs e)
        {
            try
            {
                this._equipments = Equipment.FindEquipmentsBy(this._maker.ID);
            }
            catch(SqlException ex)
            {
                Logger.Error(ex);
                MessageBox.Show(ex.Message);
            }

            this.grdList.DataSource = new BindingList<Equipment>(this._equipments);
        }

        /// <summary>
        /// 初期化設定
        /// </summary>
        private void Initialize(Maker maker, List<Equipment> equipments)
        {
            base.ClearBindings(this.Controls);

            this._maker = null;
            this._maker = maker;
            this.txtName.DataBindings.Add("Text", this._maker, "Name");
            this.grpEnable.DataBindings.Add("Enable", this._maker, "EnableFlag");
            this.grdList.DataSource = new BindingList<Equipment>(equipments);
            this.txtName.Focus();
        }

        /// <summary>
        /// 「保存」ボタンクリックイベント
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this._maker.Save(this._equipments);
                MessageBox.Show("登録しました。");
                this.Initialize(new Maker(), new List<Equipment>());
            }
            catch(SqlException ex)
            {
                Logger.Error(ex);
            }
        }
    }
}
