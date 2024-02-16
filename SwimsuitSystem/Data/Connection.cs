using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace SwimsuitSystem.Data
{
    internal class Connection
    {
        public static MySqlConnection connMaster = new MySqlConnection();

        static readonly string server = "127.0.0.1;";
        static readonly string dataBase = "sneakersdb;";
        static readonly string uid = "root;";
        static readonly string password = ";";        

        public static MySqlConnection dataSource()
        {
            connMaster = new MySqlConnection($"server = {server} database = {dataBase} Uid = {uid} password = {password} ");
            return connMaster;
        }

        public void connOpen()
        {
            dataSource();
            connMaster.Open();
        }

        public void connClose()
        {
            dataSource();
            connMaster.Close();
        }

        public void connInsert(string name,string lastname, string gender, string Birthday, string phoneNumber, string emailAddress, string country)
        {
           dataSource();
            string sql = $"INSERT INTO clientes (nombre, apellido,genero, fecha_nacimiento, numero_telefono, correo_electronico, pais_nacimiento) Values ('{name}','{lastname}', '{gender}', '{Birthday}', '{phoneNumber}', '{emailAddress}', '{country}')";
            connOpen();
            MySqlCommand cmd = new MySqlCommand(sql, connMaster); 
            cmd.ExecuteNonQuery();
            connMaster.Close();
        }

    }
}
