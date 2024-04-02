using System.Data;
using System.Windows.Forms;
using CRUD.Data;
using Microsoft.Data.SqlClient;

namespace CRUD
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void PopulateDataGrid()
        {
            

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            DataTable dt = connection.SelectData("", "", "", "", "", "", "", "");
            bindingSource1.DataSource = dt;
            dataGridView1.DataSource = bindingSource1;

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
