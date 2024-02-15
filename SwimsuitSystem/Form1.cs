using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using SwimsuitSystem.Data;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace SwimsuitSystem
{
    public partial class Form1 : Form
    {
        // inicializacion de variables generales
        string[] Genero = { "Hombre", "Mujer" };
        string name, lastName, email, phoneNumber;

        // Codigo que se encarga de obtener todos los nombres de los paises para ser introducidos en un combobox
        public static List<string> GetAllCountrysNames()
        {
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            return cultures
                    .Select(cult => (new RegionInfo(cult.LCID)).DisplayName)
                    .Distinct()
                    .OrderBy(q => q)
                    .ToList();
        }

        // objetos para llamar a las clases
        Data.Connection conn = new Data.Connection();
        Clientes clientes = new Clientes("", "", "", 0, "", 0, "");

        //patron regex para saber si solo se encuentran letras en una cadena
        string regexPattern = "^(?:[a-zA-Z]+)?$";

        // form 1
        public Form1()
        {
            InitializeComponent();
        }

        // Esta funcion se encarga de asegurar que solo hayan letras dentro de un textbox
        public bool ValidFormat(string format, TextBox txb)
        {
            bool matches = Regex.IsMatch(format, regexPattern);
            if (!matches)
            {
                MessageBox.Show("Please enter a valid input", "Incorrect format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txb.Clear();
            }
            return true;
        }

        private void txbFirstName_TextChanged(object sender, EventArgs e)
        {
            name = txbFirstName.Text;
            if (ValidFormat(name, txbFirstName))
            {
                clientes.Nombre = name;
            }
        }

        private void txbLastName_TextChanged(object sender, EventArgs e)
        {
            lastName = txbLastName.Text;
            if (ValidFormat(lastName, txbLastName))
            {
                clientes.Apellido = lastName;
            }
        }


        private void txbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            phoneNumber = txbPhoneNumber.Text;

            // validar si es esta escribiendo un numero de telefono
            string regexPatternPhoneNumber = "/^\\(?([0-9]{3})\\)?[-.\\s]?([0-9]{3})[-.\\s]?([0-9]{4})$/";
            if (!Regex.IsMatch(phoneNumber, regexPatternPhoneNumber))
            {
                MessageBox.Show("Please enter a valid input", "Incorrect format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPhoneNumber.Clear();
            }

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {
            email = txbEmail.Text;
            clientes.emailAddress = email;
        }



        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMale.Checked)
            {
                clientes.Genero = Genero[0];
            }
            else
            {
                clientes.Genero = null;
            }
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFemale.Checked)
            {
                clientes.Genero = Genero[1];
            }
            else
            {
                clientes.Genero = null;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.connInsert(clientes.Nombre, clientes.Apellido, clientes.Genero, clientes.FechaNacimiento, clientes.phoneNumber, clientes.emailAddress);
                MessageBox.Show("Your information was stored successfully.\nYou will receive a confirmation message on the given address", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Your request wasn't successfull.\nPlease check your information.", "Error connecting to the server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }
        }
    }
}
