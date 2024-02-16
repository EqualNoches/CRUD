using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using SwimsuitSystem.Data;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace SwimsuitSystem;

public partial class Form1 : Form
{
    // inicializacion de variables generales
    private readonly string[] _gender = { "Hombre", "Mujer" };
    private string _name, _lastName, _email, _phoneNumber, _birthday, _country;

    // Codigo que se encarga de obtener todos los nombres de los paises para ser introducidos en un combobox

    // objetos para llamar a las clases
    private readonly Connection _conn = new();
    private readonly Clientes _clients = new("", "", "", "", "", "", "");

    //patron regex para saber si solo se encuentran letras en una cadena
    private const string RegexPattern = "^(?:[a-zA-Z]+)?$";

    // form 1
    public Form1()
    {
        InitializeComponent();
        PupulateCountrycmb();
    }

    // Esta funcion se encarga de asegurar que solo hayan letras dentro de un textbox
    private bool ValidFormat(string format, TextBox txb)
    {
        var matches = Regex.IsMatch(format, RegexPattern);
        if (!matches)
        {
            MessageBox.Show(@"Please enter a valid input", @"Incorrect format", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            txb.Clear();
        }

        return true;
    }

    private void txbFirstName_TextChanged(object sender, EventArgs e)
    {
        _name = txbFirstName.Text;
        if (ValidFormat(_name, txbFirstName)) _clients.Nombre = _name;
    }

    private void txbLastName_TextChanged(object sender, EventArgs e)
    {
        _lastName = txbLastName.Text;
        if (ValidFormat(_lastName, txbLastName)) _clients.Apellido = _lastName;
    }


    private void mtxbPhoneNumber_TextChanged(object sender, EventArgs e)
    {
        _phoneNumber = mtxbPhoneNumber.Text;

        //validar si es esta escribiendo un numero de telefono
        string regexPatternPhoneNumber = "/^\\(?([0-9]{3})\\)?[-.\\s]?([0-9]{3})[-.\\s]?([0-9]{4})$/";
        if (Regex.IsMatch(_phoneNumber, regexPatternPhoneNumber))
        {
            MessageBox.Show(@"Please enter a valid input", "Incorrect format", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            mtxbPhoneNumber.Clear();
            _clients.phoneNumber = _phoneNumber;
        }
        else
        {
            _clients.phoneNumber = _phoneNumber;
        }
    }

    private void txbEmail_TextChanged(object sender, EventArgs e)
    {
        _email = txbEmail.Text;
        _clients.emailAddress = _email;
    }


    private void rdbMale_CheckedChanged(object sender, EventArgs e)
    {
        _clients.Genero = (rdbMale.Checked ? _gender[0] : null)!;
    }

    private void rdbFemale_CheckedChanged(object sender, EventArgs e)
    {
        _clients.Genero = (rdbFemale.Checked ? _gender[1] : null)!;
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        MainMenu mainMenu = new MainMenu();
        this.Close();
        mainMenu.Show();
    }

    private void dtpBirthday_ValueChanged(object sender, EventArgs e)
    {
        _birthday = dtpBirthday.Value.ToString("yyyy-MM-dd");
        _clients.Birthday = _birthday;
    }

    private void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            _conn.connInsert(_clients.Nombre, _clients.Apellido, _clients.Genero, _clients.Birthday,
                _clients.phoneNumber, _clients.emailAddress, _clients.Nationality);
            MessageBox.Show(
                @"Your information was stored successfully.
You will receive a confirmation message on the given address",
                @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($@"Your request wasn't successfully done.
Please check your information.",
                @"Error connecting to the server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Console.WriteLine(ex);
        }
    }

    private void PupulateCountrycmb()
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
}