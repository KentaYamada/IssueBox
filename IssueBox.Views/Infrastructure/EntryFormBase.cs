﻿using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace IssueBox.Views.Infrastructure
{
    public partial class EntryFormBase : Form
    {
        public EntryFormBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「戻る」ボタンクリックイベント
        /// </summary>
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// ロードイベント
        /// </summary>
        protected void Form_Load(object sender, EventArgs e)
        {
            try
            {
                this.Initialize();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                this.Alert();
            }
        }

        /// <summary>
        /// 「保存」ボタンクリックイベント
        /// </summary>
        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            if (!this.Validation()) { return; }

            bool result = false;
            string msg = "";

            try
            {
                result = this.Register();
                msg = result ? "登録しました。" : "登録失敗しました。";
            }
            catch (SqlException ex)
            {
                Logger.Error(ex);
                this.Alert();
            }

            MessageBox.Show(msg, "データ保存", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result)
            {
                this.Close();
                this.Dispose();
            }
        }


        private void Alert()
        {
            MessageBox.Show("システムエラーが発生しました。\nシステム管理者へ連絡して下さい。", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        /// <summary>
        /// コントロールバインドクリア
        /// </summary>
        /// <param name="controls">Formに配置したコントロール</param>
        protected void ClearBindings(Control.ControlCollection controls)
        {
            controls.OfType<Control>()
                    .ToList()
                    .ForEach(x => x.DataBindings.Clear());
        }

        protected virtual void Initialize() { }

        protected virtual bool Register() { throw new NotImplementedException("派生クラスで実装してください。"); }

        protected virtual bool Validation() { throw new NotImplementedException("派生クラスで実装してください。"); } 
    }
}
