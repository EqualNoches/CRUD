using CRUD.Data;

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
            Clients dbClients = new Clients("", "", "", "", "", "", "", "");
            dataGridView1.DataSource = dbClients.stTables.ToTable;

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
