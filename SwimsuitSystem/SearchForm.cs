using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CRUD.Data;
using Microsoft.Data.SqlClient;

namespace CRUD
{
    public partial class SearchForm : Form
    {
        Connection _connection = new Connection();
        private int _index;
        private string _filteredSearch;

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

            showData();

        }

        private static bool checkRegex(string idSearch, TextBox txb)
        {
            const string RegexPatternId = @"^\d{0,4}$";

            bool _matches = Regex.IsMatch(idSearch, RegexPatternId);
            if (_matches) return true;
            MessageBox.Show(@"Please enter a valid input", @"Incorrect format", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            txb.Clear();

            return false;
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            string id,
                name,
                lastname,
                gender,
                birthday,
                country,
                phoneNumber,
                emailAddress;
            _index = dataGridView1.CurrentCell.RowIndex;
            id = dataGridView1.Rows[_index].Cells[0].Value.ToString();
            name = dataGridView1.Rows[_index].Cells[1].Value.ToString();
            lastname = dataGridView1.Rows[_index].Cells[2].Value.ToString();
            gender = dataGridView1.Rows[_index].Cells[3].Value.ToString();
            birthday = dataGridView1.Rows[_index].Cells[4].Value.ToString();
            country = dataGridView1.Rows[_index].Cells[5].Value.ToString();
            phoneNumber = dataGridView1.Rows[_index].Cells[6].Value.ToString();
            emailAddress = dataGridView1.Rows[_index].Cells[7].Value.ToString();


            try
            {
                _connection.UpdateData(id, name, lastname, gender, birthday, country, phoneNumber, emailAddress);
                MessageBox.Show(@"The information was updated successfully",
                    @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _index = dataGridView1.CurrentCell.RowIndex;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            try
            {
                _connection.DeleteUser(id);
                MessageBox.Show(@"The information was updated successfully",
                    @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Rows.RemoveAt(_index);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }


        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _index = e.RowIndex;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFilteredSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = _connection.SelectFilteredData(_filteredSearch);
            bindingSource1.DataSource = dt;
            dataGridView1.DataSource = bindingSource1;
        }



        private void showData()
        {
            DataTable dt = _connection.SelectData();
            bindingSource1.DataSource = dt;
            dataGridView1.DataSource = bindingSource1;
        }

        private void txbFilteredSearch_TextChanged(object sender, EventArgs e)
        {
            _filteredSearch = txbFilteredSearch.Text;
            if (checkRegex(_filteredSearch, txbFilteredSearch) || _filteredSearch != null) ;
        }
    }
}
