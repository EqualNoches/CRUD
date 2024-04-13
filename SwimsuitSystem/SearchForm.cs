using System.Data;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CRUD.Data;
using Microsoft.Data.SqlClient;

namespace CRUD
{
    public partial class SearchForm : Form
    {
        private readonly AddUser _user = new AddUser();
        readonly Connection _connection = new Connection();
        private readonly Clients _clients = new("", "", "", "", "", "", "");

        // Initialize general variables
        private readonly string[] _gender = ["Man", "Woman"];
        private string _id, _name, _lastName, _email, _phoneNumber, _birthday, _country;

        private int _index;
        private string _filteredSearch;
        private const string RegexPattern = "^(?:[a-zA-Z]+)?$";

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            PopulateCountrycmb();
            ShowData();

        }

        private static bool ValidFormat(string format, TextBox txb)
        {
            bool matches = Regex.IsMatch(format, RegexPattern);
            if (matches) return true;
            MessageBox.Show(@"Please enter a valid input", @"Incorrect format", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            txb.Clear();

            return false;
        }

        private static bool CheckRegex(string idSearch, TextBox txb)
        {
            const string regexPatternId = @"^\d{0,4}$";

            var matches = Regex.IsMatch(idSearch, regexPatternId);
            if (matches) return true;
            MessageBox.Show(@"Please enter a valid input", @"Incorrect format", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            txb.Clear();

            return false;
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            _id = txbID.Text;
            try
            {
                _connection.UpdateData(_id, _clients.Name, _clients.LastName, _clients.Gender, _clients.Birthday, _clients.Nationality, _clients.PhoneNumber, _clients.EmailAddress);
                _clients.SendUpdatedEmail(_name,_email);
                MessageBox.Show(@"The information was updated successfully",
                    @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
                ClearAll();
                
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
                ClearAll();
                ShowData();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _index = e.RowIndex;
            var id = dataGridView1.Rows[_index].Cells[0].Value.ToString();
            var name = dataGridView1.Rows[_index].Cells[1].Value.ToString();
            var lastname = dataGridView1.Rows[_index].Cells[2].Value.ToString();
            var gender = dataGridView1.Rows[_index].Cells[3].Value.ToString();
            var birthday = dataGridView1.Rows[_index].Cells[4].Value.ToString();
            var country = dataGridView1.Rows[_index].Cells[5].Value.ToString();
            var phoneNumber = dataGridView1.Rows[_index].Cells[6].Value.ToString();
            var emailAddress = dataGridView1.Rows[_index].Cells[7].Value.ToString();

            txbID.Text = id;
            txbFirstName.Text = name;
            txbLastName.Text = lastname;

            switch (gender)
            {
                case "Men":
                    rdbMale.Checked = true;
                    break;
                case "Woman":
                    rdbFemale.Checked = true;
                    break;
                default:
                    rdbMale.Checked = true;
                    break;
            }

            dtpBirthday.Text = birthday;

            cmbPais.Text = country;
            mtxbPhoneNumber.Text = phoneNumber;
            txbEmail.Text = emailAddress;
        }

        private void btnFilteredSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = _connection.SelectFilteredData(_filteredSearch);
            bindingSource1.DataSource = dt;
            dataGridView1.DataSource = bindingSource1;
        }

        private void ShowData()
        {
            DataTable dt = _connection.SelectData();
            bindingSource1.DataSource = dt;
            dataGridView1.DataSource = bindingSource1;
        }

        private void txbFilteredSearch_TextChanged(object sender, EventArgs e)
        {
            _filteredSearch = txbFilteredSearch.Text;
            if (CheckRegex(_filteredSearch, txbFilteredSearch) || !(_filteredSearch != null)) ;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PopulateCountrycmb()
        {
            var countries = new List<string>();
            var cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (var culture in cultures)
            {
                var region = new RegionInfo(culture.Name); // Pass culture name
                if (!countries.Contains(region.EnglishName)) countries.Add(region.EnglishName);
            }

            cmbPais.Items.AddRange(countries.ToArray());
        }
        private void txbFirstName_TextChanged(object sender, EventArgs e)
        {
            _name = txbFirstName.Text;
            if (ValidFormat(_name, txbFirstName) || _name != null) _clients.Name = _name;
        }

        private void txbLastName_TextChanged(object sender, EventArgs e)
        {
            _lastName = txbLastName.Text;
            if (ValidFormat(_lastName, txbLastName)) _clients.LastName = _lastName;
        }


        private void mtxbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            _phoneNumber = mtxbPhoneNumber.Text;
            _clients.PhoneNumber = _phoneNumber;
        }
        // take the data of the email textbox
        private void txbEmail_TextChanged(object sender, EventArgs e)
        {
            _email = txbEmail.Text;
            _clients.EmailAddress = _email;
        }

        // Gender radios
        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            _clients.Gender = (rdbMale.Checked ? _gender[0] : null)!;
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            _clients.Gender = (rdbFemale.Checked ? _gender[1] : null)!;
        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            _birthday = dtpBirthday.Value.ToString("yyyy-MM-dd");
            _clients.Birthday = _birthday;
        }
        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            _country = cmbPais.SelectedItem.ToString();
            _clients.Nationality = _country;
        }

        private void ClearAll()
        {
            txbID.Clear();
            txbFirstName.Clear();
            txbLastName.Clear();
            rdbMale.Checked = true;
            dtpBirthday.Refresh();
            cmbPais.ResetText();
            mtxbPhoneNumber.Clear();
            txbEmail.Clear();
        }
    }
}
