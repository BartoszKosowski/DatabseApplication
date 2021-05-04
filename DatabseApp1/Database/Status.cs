using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;


namespace DatabaseApplication.Database
{
    class Status: ObservableCollection<string>
    {
        public Status()
        {
            ConnectionInfo connectionInfo = new ConnectionInfo("ConnectionFile.xml");
            string[] ConnectionInfoDetails = connectionInfo.GetConnectionInfo();
            SqlConnection connection = new SqlConnection(ConnectionInfoDetails[0], ConnectionInfoDetails[1], ConnectionInfoDetails[2], ConnectionInfoDetails[3], ConnectionInfoDetails[4]);
            string query = "SELECT status FROM status;";

            connection.ConnectWithDatabase();
            connection.OpenConnection();
            MySqlCommand command = new MySqlCommand(query, connection.GetDatabaseConnection());
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Add(dataReader[0].ToString());
            }
            dataReader.Close();
            connection.CloseConnection();
        }
    }
}
