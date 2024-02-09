using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimsuitSystem.Data
{
    internal class Clientes
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public int FechaNacimiento { get; set; }
        public string Nationality { get; set; }
        public int phoneNumber { get; set; }
        public string emailAddress { get; set; }

        public Clientes (string nombre, string apellido, string genero, int fechaNacimiento, string nationality, int phoneNumber, string emailAddress)
        {
            Nombre = nombre;
            Apellido = apellido;
            Genero = genero;
            FechaNacimiento = fechaNacimiento;
            Nationality = nationality;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
        }
    }
}
