using System.Configuration;
using Microsoft.Data.SqlClient;

namespace SwimsuitSystem.Data
{
    internal class Connection
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        SqlCommand command = null;

        public void InsertData(string name, string lastname, string gender, string Birthday, string country, string phoneNumber, string emailAddress)
        {
            connection.Open();
            command = new SqlCommand("addUser", connection);
            command.Parameters.AddWithValue("@client_name", name);
            command.Parameters.AddWithValue("@client_last_name", lastname);
            command.Parameters.AddWithValue("@client_gender", gender);
            command.Parameters.AddWithValue("@client_birthdate", Birthday);
            command.Parameters.AddWithValue("@client_birthplace", country);
            command.Parameters.AddWithValue("@client_phone_number", phoneNumber);
            command.Parameters.AddWithValue("client_email", emailAddress);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
