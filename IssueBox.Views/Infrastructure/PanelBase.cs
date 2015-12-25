using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

using IssueBox.Models;

namespace IssueBox.Views.Infrastructure
{
    [Browsable(false)]
    public partial class PanelBase : UserControl
    {
        private ErrorProvider _error = null;

        #region Properties

        /// <summary>エラーアイコン</summary>
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

        /// <summary>メニュー名</summary>
        public virtual string MenuName { get { throw new NotImplementedException("派生クラスで実装してください。"); } }

        #endregion

        #region Default Construcotr

        public PanelBase()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        /// <summary>
        /// ロードイベント
        /// </summary>
        protected void Form_Load(object sender, EventArgs e)
        {
            this.Initialize();

            try
            {
                this.ReadData();
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
                this.Alert();
            }
        }

        /// <summary>
        /// 「検索」ボタンクリックイベント
        /// </summary>
        protected void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ReadData();
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
                this.Alert();
            }
        }

        /// <summary>
        /// 「新規登録」ボタンクリックイベント
        /// </summary>
        protected void NewEntryButton_Click(object sender, EventArgs e)
        {
            this.ShowEntryWindow();

            try
            {
                this.ReadData();
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
                this.Alert();
            }
        }

        /// <summary>
        /// セルダブルクリックイベント
        /// </summary>
        protected void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ヘッダをダブルクリックすると例外が起きるので、例外防止のため必要
            if (e.RowIndex < 0) { return; }

            this.ShowEntryWindow(e.RowIndex);

            try
            {
                this.ReadData();
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
                this.Alert();
            }
        }

        #endregion

        private void Alert()
        {
            MessageBox.Show("システムエラーが発生しました。\nシステム管理者へ連絡して下さい。", "", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

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
        protected virtual void ShowEntryWindow() { }

        /// <summary>
        /// 登録フォーム表示
        /// </summary>
        /// <param name="index">選択された行番号</param>
        protected virtual void ShowEntryWindow(int index) { }
    }
}
