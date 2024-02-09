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

        static string server = "127.0.0.1;";
        static string dataBase = "sneakersdb;";
        static string uid = "root;";
        static string password = ";";        

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

        public void connInsert(string name,string lastname, string gender, int Birthday, int phoneNumber)
        {
           dataSource();
            string sql = $"INSERT INTO clientes (nombre, apellido,genero, fecha_naciemiento, numbero_telefono, correo_electronico) Values ('{name}',)";
            connOpen();
            MySqlCommand cmd = new MySqlCommand(sql, connMaster); 
            cmd.ExecuteNonQuery();
            connMaster.Close();
        }

    }
}
