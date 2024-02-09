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
        string[] Genero = { "Hombre", "Mujer" };
        string name, lastname, nationality, email;

        Data.Connection conn = new Data.Connection();
        Clientes clientes = new Clientes("", "", "", 0, "", 0);

        //patron regex para saber si solo se encuentran letras en una cadena
        string regexPattern = "^(?:[a-zA-Z]+)?$";
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
            return false;
        }

        private void txbFirstName_TextChanged(object sender, EventArgs e)
        {
            name = txbFirstName.Text;
            clientes.Nombre = name;
            if (clientes.Nombre == name)
            {
                lblCambiado.Visible = true;
            }

            if (ValidFormat(name, txbFirstName))
            {
                clientes.Nombre = name;
                if (clientes.Nombre == name)
                {
                    lblCambiado.Visible = true;
                }

            }
        }

        private void txbLastName_TextChanged(object sender, EventArgs e)
        {
            string lastName = txbLastName.Text;
            ValidFormat(lastName, txbLastName);
        }

        private void txbNationality_TextChanged(object sender, EventArgs e)
        {
            string nationality = txbNationality.Text;
            ValidFormat(nationality, txbNationality);
        }

        private void txbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = txbPhoneNumber.Text;

            // validar si es esta escribiendo un numero de telefono
            string regexPatternPhoneNumber = "^\\s?(?:\\d{3}-\\d{3}-\\d{4}|1 \\d{3}-\\d{3}-\\d{4})\\s?$";
            if (Regex.IsMatch(phoneNumber, regexPatternPhoneNumber))
            {
                MessageBox.Show("Please enter a valid input", "Incorrect format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPhoneNumber.Clear();
            }
        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txbEmail.Text;
            ValidFormat(email, txbEmail);
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            conn.connInsert(clientes.Nombre, clientes.Apellido, clientes.Genero,clientes.FechaNacimiento,clientes.phoneNumber);
        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
