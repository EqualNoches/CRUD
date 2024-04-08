using System.Data;
using System.Windows.Forms;
using CRUD.Data;
using Microsoft.Data.SqlClient;

namespace CRUD
{
    public partial class SearchForm : Form
    {
        Connection _connection = new Connection();
        private int _index;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

            DataTable dt = _connection.SelectData("", "", "", "", "", "", "", "");
            bindingSource1.DataSource = dt;
            dataGridView1.DataSource = bindingSource1;

        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            string id, name, lastname, gender, birthday, country, phoneNumber, emailAddress;

            for (int item = 0; item < dataGridView1.Rows.Count; item++)
            {
                id = dataGridView1.Rows[item].Cells[0].Value.ToString();
                name = dataGridView1.Rows[item].Cells[1].Value.ToString();
                lastname = dataGridView1.Rows[item].Cells[2].Value.ToString(); ;
                gender = dataGridView1.Rows[item].Cells[3].Value.ToString();
                birthday = dataGridView1.Rows[item].Cells[4].Value.ToString();
                country = dataGridView1.Rows[item].Cells[5].Value.ToString();
                phoneNumber = dataGridView1.Rows[item].Cells[6].Value.ToString();
                emailAddress = dataGridView1.Rows[item].Cells[7].Value.ToString();


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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _index = e.RowIndex;
        }
    }
}
