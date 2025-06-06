using System.Globalization;
using System.Text.RegularExpressions;
using CRUD.Data;
using TextBox = System.Windows.Forms.TextBox;

namespace CRUD;

public partial class AddUser : Form
{
    // Object to call the class
    private Connection _conn = new Connection();
    private readonly Clients _clients = new( "", "", "", "", "", "", "");
    
    // Initialize general variables
    private readonly string[] _gender = ["Man", "Woman"];
    private string _id, _name, _lastName, _email, _phoneNumber, _birthday, _country;
    
    // patron regex para saber si solo se encuentran letras en una cadena
    private const string RegexPattern = "^(?:[a-zA-Z]+)?$";

    // form 1
    public AddUser()
    {
        InitializeComponent();
        PopulateCountrycmb();
        _id = _clients.Id;
        txbID.Text = _id;
    }

    // This function is in charge to check if the selected text is only an alphabetic character.
    private static bool ValidFormat(string format, TextBox txb)
    {
        bool matches = Regex.IsMatch(format, RegexPattern);
        if (matches) return true;
        MessageBox.Show(@"Please enter a valid input", @"Incorrect format", MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        txb.Clear();
        
        return false;
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

    // sex radios
    private void rdbMale_CheckedChanged(object sender, EventArgs e)
    {
        _clients.Gender = (rdbMale.Checked ? _gender[0] : null)!;
    }

    private void rdbFemale_CheckedChanged(object sender, EventArgs e)
    {
        _clients.Gender = (rdbFemale.Checked ? _gender[1] : null)!;
    }

    // back button
    private void btnBack_Click(object sender, EventArgs e)
    {
        MainMenu mainMenu = new MainMenu();
        this.Close();
    }

    private void dtpBirthday_ValueChanged(object sender, EventArgs e)
    {
        _birthday = dtpBirthday.Value.ToString("yyyy-MM-dd");
        _clients.Birthday = _birthday;
    }

    //populate the combobox with all the countries
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

    private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
    {
        _country = cmbPais.SelectedItem.ToString();
        _clients.Nationality = _country;
    }

    private void mtxbPhoneNumber_Enter(object sender, EventArgs e)
    {
        this.BeginInvoke((MethodInvoker)delegate ()
        {
            mtxbPhoneNumber.Select(0, 0);
        });
    }

    // this button is used to move the data from the program to the database
    // TODO: Check if the value of textboxes is empty and can be passed to the DataBase
    private void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            _conn.InsertData(_id, _clients.Name, _clients.LastName, _clients.Gender, _clients.Birthday, _clients.Nationality, _clients.PhoneNumber, _clients.EmailAddress);
            _clients.SendEmail(_name,_email);
            MessageBox.Show(@"Your information was stored successfully.",
                @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($@"Your request wasn't successfully done.
            Please check your information.",
                @"Error connecting to the server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Console.WriteLine(ex);
        }
    }
}