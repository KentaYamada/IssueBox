using System;
using System.Drawing;
using System.Windows.Forms;

using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    /// <summary>
    /// メインウィンドウ
    /// </summary>
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// メニューボタンクリックイベント
        /// </summary>
        private void menu_Click(object sender, EventArgs e)
        {
            try
            {
                this.ShowPanel();
            }
            catch(Exception ex)
            {
                Logger.Error(ex);
            }
        }

        /// <summary>
        /// 「ログアウト」クリックイベント
        /// </summary>
        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// 検索画面表示
        /// </summary>
        private void ShowPanel()
        {
            try
            {
                var panel = Activator.CreateInstance<SearchIssue>();
                this.Controls.Add(panel);
                panel.Location = new Point(0, 0);
                panel.Dock = DockStyle.Fill;
                panel.BringToFront();
            }
            catch
            {
                throw;
            }
            
            //var form = new EntryMember();
            //var form = new EntryProject();
            //var form = new EntryProduct();
            //var form = new EntryCategory();
            //var form = new EntryIssue();
            //form.ShowDialog();
        }
    }
}
