using System;
using System.Drawing;
using System.Windows.Forms;

namespace IssueBox.Views
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.ShowPanel();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ShowPanel()
        {
            //var panel = Activator.CreateInstance<SearchProject>();

            //this.Controls.Add(panel);
            //panel.Location = new Point(0, 0);
            //panel.Dock = DockStyle.Fill;
            //panel.BringToFront();
            //var form = new EntryMember();
            //var form = new EntryProject();
            //var form = new EntryProduct();
            //var form = new EntryCategory();
            var form = new EntryIssue();
            form.ShowDialog();
        }
    }
}
