using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace IssueBox.Views.Infrastructure
{
    [Browsable(false)]
    public partial class PanelBase : UserControl
    {
        private ErrorProvider _error = null;

        [Description("エラー表示するアイコン")]
        protected ErrorProvider ErrorIcon 
        {
            get
            {
                if (this._error == null)
                {
                    this._error = new ErrorProvider() { BlinkStyle = ErrorBlinkStyle.NeverBlink };
                    this._error.ContainerControl = this;
                }

                return this._error;
            } 
        }

        public PanelBase()
        {
            InitializeComponent();
        }

        protected virtual void SetReadData() { }

        //protected virtual void ShowEntryWindow() { }

        ///// <summary>
        ///// 「新規作成」クリックイベント
        ///// </summary>
        //protected void btnNew_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //ToDo:入力画面表示
        //        this.ShowEntryWindow();
        //    }
        //    catch(SqlException ex)
        //    {
        //        Logger.Error(ex);
        //    }
        //}

        /// <summary>
        /// 「検索」クリックイベント
        /// </summary>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.SetReadData();
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
            }
        }

        ///// <summary>
        ///// 行データ選択イベント
        ///// </summary>
        //protected void grdList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //ToDo:入力画面表示
        //    this.ShowEntryWindow();

        //    try
        //    {
        //        this.SetReadData();
        //    }
        //    catch (SqlException ex)
        //    {
        //        Logger.Error(ex);
        //    }
        //}
    }
}
