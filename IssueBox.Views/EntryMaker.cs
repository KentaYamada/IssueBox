using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IssueBox.Models;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
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
            this._maker = maker;
            this._equipments = new List<Equipment>();
        }

        #endregion

        /// <summary>
        /// ロードイベント
        /// </summary>
        private void EntryMaker_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtName.DataBindings.Add("Text", this._maker, "Name");
                this.grpEnable.DataBindings.Add("Enable", this._maker, "EnableFlag");
                this._equipments = Equipment.FindEquipmentsBy(this._maker.ID);
            }
            catch(SqlException ex)
            {
                Logger.Error(ex);
            }

            this.grdList.DataSource = new BindingList<Equipment>(this._equipments);
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
            }
            catch(SqlException ex)
            {
                Logger.Error(ex);
            }
        }
    }
}
