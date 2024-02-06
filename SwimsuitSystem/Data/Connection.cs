using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace SwimsuitSystem.Data
{
    internal class Connection
    {
        Clientes clientes = new();

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

        public void dbConnection(MySqlConnection conn)
        {
            string sql = $"INSERT INTO clientes (nombre) values ({clientes.Nombre})";
            connOpen();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add($"{clientes.Nombre}", MySqlDbType.Text);
            cmd.Parameters[$"{clientes.Nombre}"].Value = sql;
            cmd.ExecuteNonQuery();
            connMaster.Close();
        }

    }
}
