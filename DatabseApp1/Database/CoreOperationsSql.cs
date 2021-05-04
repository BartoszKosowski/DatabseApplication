using MySql.Data.MySqlClient;
using System.Data;


namespace DatabaseApplication.Database
{
    class CoreOperationsSql
    {
        protected SqlConnection connection;
        protected string name;
        protected string query;
        protected DataTable GetDataFromDatabase()
        {
            connection.ConnectWithDatabase();
            connection.OpenConnection();
            MySqlCommand command = new MySqlCommand(query, connection.GetDatabaseConnection());
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.CloseConnection();
            return dataTable;
        }


        protected bool CheckName()
        {
            if (name.Contains(" "))
                return true;
            return false;
        }
    }
}
