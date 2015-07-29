using System;
using System.Data.SqlClient;
using System.Windows.Forms;

using IssueBox.Models;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    /// <summary>
    /// 単位設定画面
    /// </summary>
    public partial class EntryUnit : EntryFormBase
    {
        private Unit _unit = null;

        #region Constructors

        public EntryUnit()
            :this(new Unit())
        { }

        public EntryUnit(Unit unit)
        {
            InitializeComponent();

            this._unit = unit;
            this.txtName.DataBindings.Add("Text", this._unit, "Name");
            this.grpEnable.DataBindings.Add("Enable", this._unit, "EnableFlag");
        }

        #endregion

        /// <summary>
        /// 「保存」ボタンクリックイベント
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.Validation())
            {
                return;
            }

            try
            {
                this._unit.Save();
                MessageBox.Show("登録しました。");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Logger.Error(ex);
            }
        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        /// <returns>True:正常 / Flase:入力エラー</returns>
        private bool Validation()
        {
            this.errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(this.txtName.Text))
            {
                this.errorProvider1.SetError(this.txtName, this.txtName.AlertMessage);
                this.txtName.Focus();
                return false;
            }

            return true;
        }

        
    }
}
