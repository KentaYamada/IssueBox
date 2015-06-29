using System;
using System.Windows.Forms;
using IssueBox.Models;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    public partial class EntryProduct : EntryFormBase
    {
        private Product _product = null;

        public EntryProduct()
            :this(new Product())
        { }

        public EntryProduct(Product product)
        {
            InitializeComponent();

            this._product = product;
            this.txtName.DataBindings.Add("Text", this._product, "Name");
            this.grpEnable.DataBindings.Add("Enable", this._product, "EnableFlag");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.Validation()) { return; }

            try
            {
                this._product.Save();
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

            if (string.IsNullOrWhiteSpace(this.txtName.Text))
            {
                base.errorProvider1.SetError(this.txtName, this.txtName.AlertMessage);
                return false;
            }

            return true;
        }
    }
}
