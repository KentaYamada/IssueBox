using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IssueBox.Models;
using IssueBox.Models.Infrastructure;
using IssueBox.Views.Infrastructure;

namespace IssueBox.Views
{
    public partial class SearchIssue : PanelBase
    {

        private List<Issue> _issues = null;

        public SearchIssue()
        {
            InitializeComponent();
        }

        private void SearchIssue_Load(object sender, EventArgs e)
        {
            try
            {
                this.cmbCategories.DataSource = DropDownModel.FindAllData(TABLE_NAME.CATEGORIES);
                this.cmbProjects.DataSource = DropDownModel.FindAllData(TABLE_NAME.PROJECTS);
                this.cmbProducts.DataSource = DropDownModel.FindAllData(TABLE_NAME.PRODUCTS);
            }
            catch(SqlException ex)
            {
 
            }
        }

        private void Initialize()
        {
            
        }

    }
}
