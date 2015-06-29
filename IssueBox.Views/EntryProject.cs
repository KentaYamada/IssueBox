using System;
using System.Linq;
using System.Windows.Forms;
using IssueBox.Models;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    public partial class EntryProject : EntryFormBase
    {
        private Project _project = null;

        public EntryProject()
            :this(new Project())
        { }

        public EntryProject(Project project)
        {
            InitializeComponent();

            this._project = project;
            this.txtProjectID.DataBindings.Add("Text", this._project, "ProjectID");
            this.txtName.DataBindings.Add("Text", this._project, "Name");
            this.grpEnable.DataBindings.Add("Enable", this._project, "EnableFlag");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.Validation()) { return; }

            try
            {
                this._project.Save();
                MessageBox.Show("登録しました。");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool Validation()
        {
            base.errorProvider1.Clear();
            var target = this.Controls.OfType<TextBoxEx>()
                                      .Where(x => x.Required && string.IsNullOrWhiteSpace(x.Text))
                                      .OrderBy(x => x.TabIndex)
                                      .ToList();
            if (0 < target.Count)
            {
                base.errorProvider1.SetError(target[0], target[0].AlertMessage);
                return false;
            }

            return true;
        }
    }
}
