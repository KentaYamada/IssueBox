using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            string panelName = (sender as ToolStripMenuItem).Name.Replace("menu", "");

            try
            {
                this.ShowPanel(panelName);
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
        private void ShowPanel(string panelName)
        {
            try
            {
                var type = Assembly.LoadFrom("IssueBox.Views.dll").GetTypes().Where(n => n.Name == panelName).First();
                var panel = Activator.CreateInstance(type) as PanelBase;
                this.Controls.Add(panel);
                panel.Location = new Point(0, 0);
                panel.Dock = DockStyle.Fill;
                panel.BringToFront();
            }
            catch
            {
                throw;
            }
        }
    }
}
