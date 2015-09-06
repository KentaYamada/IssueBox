using System;
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
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
