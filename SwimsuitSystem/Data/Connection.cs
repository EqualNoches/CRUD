using System.Configuration;
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

        public void SelectData(string id, string name, string lastname, string gender, string birthday, string country,
            string phoneNumber, string emailAddress)
        {
            _connection.Open();
            _command = new SqlCommand("readUsers", _connection);
            SqlDataReader da = _command.ExecuteReader();
            while (da != null)
            {
                _command.Parameters.AddWithValue("@client_id", id);
                _command.Parameters.AddWithValue("@client_name", name);
                _command.Parameters.AddWithValue("@client_last_name", lastname);
                _command.Parameters.AddWithValue("@client_gender", gender);
                _command.Parameters.AddWithValue("@client_birthdate", birthday);
                _command.Parameters.AddWithValue("@client_birthplace", country);
                _command.Parameters.AddWithValue("@client_phone_number", phoneNumber);
                _command.Parameters.AddWithValue("client_email", emailAddress);
            }

            _command.CommandType = System.Data.CommandType.StoredProcedure;
            _command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
