using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private bool Validation()
        {
            this.errorProvider1.Clear();

            var target = this.panel1.Controls.OfType<TextBoxEx>()
                            .Where(x => x.Required && string.IsNullOrEmpty(x.Text)).ToList();

            if (0 < target.Count)
            {
                this.errorProvider1.SetError(target[0], target[0].AlertMessage);
                return false;
            }

            return true;
        }
    }
}
