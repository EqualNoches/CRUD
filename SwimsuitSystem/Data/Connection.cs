using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CRUD.Data
{
    internal class Connection
    {
        private readonly SqlConnection _connection =
            new(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        SqlCommand _command = null;

        public void InsertData(string id, string name, string lastname, string gender, string birthday, string country, string phoneNumber, string emailAddress)
        {
            _connection.Open();
            _command = new SqlCommand("addUser", _connection);
            _command.Parameters.AddWithValue("@client_id", id);
            _command.Parameters.AddWithValue("@client_name", name);
            _command.Parameters.AddWithValue("@client_last_name", lastname);
            _command.Parameters.AddWithValue("@client_gender", gender);
            _command.Parameters.AddWithValue("@client_birthdate", birthday);
            _command.Parameters.AddWithValue("@client_birthplace", country);
            _command.Parameters.AddWithValue("@client_phone_number", phoneNumber);
            _command.Parameters.AddWithValue("client_email", emailAddress);
            _command.CommandType = System.Data.CommandType.StoredProcedure;
            _command.ExecuteNonQuery();
            _connection.Close();
        }

        public DataTable SelectData()
        {
            DataTable dt = new DataTable();                                                                                                                                                                                                           
            _connection.Open();
            _command = new SqlCommand("readUsers", _connection);
            _command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(_command);
            da.Fill(dt);
            _command.ExecuteNonQuery();
            _connection.Close();
            return dt;
        }
        public DataTable SelectFilteredData(string id)
        {
            DataTable dt = new DataTable();                                                                                                                                                                                                           
            _connection.Open();
            _command = new SqlCommand("readUserFiltered", _connection);
            _command.Parameters.AddWithValue("@client_id", id);
            _command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(_command);
            da.Fill(dt);
            _command.ExecuteNonQuery();
            _connection.Close();
            return dt;
        }

        public void UpdateData(string id, string name, string lastname, string gender, string birthday, string country, string phoneNumber, string emailAddress)
        {
            _connection.Open();
            _command = new SqlCommand("updateUser", _connection);
            _command.Parameters.AddWithValue("@client_id", id);
            _command.Parameters.AddWithValue("@client_name", name);
            _command.Parameters.AddWithValue("@client_last_name", lastname);
            _command.Parameters.AddWithValue("@client_gender", gender);
            _command.Parameters.AddWithValue("@client_birthdate", birthday);
            _command.Parameters.AddWithValue("@client_birthplace", country);
            _command.Parameters.AddWithValue("@client_phone_number", phoneNumber);
            _command.Parameters.AddWithValue("client_email", emailAddress);
            _command.CommandType = System.Data.CommandType.StoredProcedure;
            _command.ExecuteNonQuery();
            _connection.Close();
        }

        public void DeleteUser(string id)
        {
            _connection.Open();
            _command = new SqlCommand("deleteUser", _connection);
            _command.Parameters.AddWithValue("@client_id", id);
            _command.CommandType = System.Data.CommandType.StoredProcedure;
            _command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
