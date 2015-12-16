using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

using IssueBox.Models;

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

        /// <summary>検索条件</summary>
        protected Condition Condition { get; set; }

        #region Default Construcotr

        public PanelBase()
        {
            InitializeComponent();
        }

        #endregion

        /// <summary>
        /// 初期化処理
        /// </summary>
        protected virtual void Initialize() { }

        /// <summary>
        /// データ読み込み
        /// </summary>
        protected virtual void ReadData() { }

        /// <summary>
        /// 登録フォーム表示
        /// </summary>
        /// <param name="form"></param>
        protected virtual void ShowEntryWindow(EntryFormBase form)
        {
            using(var f = form)
            {
                f.ShowDialog();
            }
        }

        /// <summary>
        /// 「検索」クリックイベント
        /// </summary>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.ReadData();
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
            }
        }
    }
}
