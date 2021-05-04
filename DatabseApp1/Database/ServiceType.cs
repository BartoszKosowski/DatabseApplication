using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;


namespace DatabaseApplication.Database
{
    class ServiceType : ObservableCollection<string>
    {
        

        public ServiceType()    //get collection of service's types
        {
            ConnectionInfo connectionInfo = new ConnectionInfo("ConnectionFile.xml");
            string[] ConnectionInfoDetails= connectionInfo.GetConnectionInfo();
            SqlConnection connection = new SqlConnection(ConnectionInfoDetails[0], ConnectionInfoDetails[1], ConnectionInfoDetails[2], ConnectionInfoDetails[3], ConnectionInfoDetails[4]);
            string query = "SELECT type FROM service_type;";

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
