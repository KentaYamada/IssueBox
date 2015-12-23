using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

using IssueBox.Models;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    public partial class Login : Form
    {
        private Member _condition = null;

        public Login()
        {
            InitializeComponent();

            this._condition = new Member();
            this.txtLoginID.DataBindings.Add("Text", this._condition, "LoginID");
            this.txtLoginPW.DataBindings.Add("Text", this._condition, "LoginPassword");
        }

        /// <summary>
        /// 入力チェック
        /// </summary>
        /// <returns>True:正常 / False:エラー</returns>
        private bool Validation()
        {
            this.errorProvider1.Clear();

            var target = this.panel1.Controls.OfType<TextBoxEx>()
                            .Where(x => x.Required && string.IsNullOrEmpty(x.Text))
                            .OrderBy(x => x.TabIndex)
                            .ToList();

            if (0 < target.Count)
            {
                this.errorProvider1.SetError(target[0], target[0].AlertMessage);
                return false;
            }

            return true;
        }

        /// <summary>
        /// 「ログイン」ボタンクリックイベント
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this.Validation()) { return; }

            try
            {
                var model = Member.LoginAuthorication(this._condition);
                if (null != model)
                {
                    this.Visible = false;
                    using (var mw = new MainWindow(model.Name))
                    {
                        mw.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("ログイン認証に失敗しました。\r\nIDまたはパスワードを確認して下さい。");
                    this.txtLoginID.Focus();
                }

                this.Visible = true;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("システムエラーが発生しました。");
                Logger.Error(ex);
            }
        }

        /// <summary>
        /// 「終了」クリックイベント
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
