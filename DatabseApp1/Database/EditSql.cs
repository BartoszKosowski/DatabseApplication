using MySql.Data.MySqlClient;

namespace DatabaseApplication.Database
{
    abstract class EditSql
    {
        protected SqlConnection connection;
        protected string query;

        protected void Delete()
        {
            connection.ConnectWithDatabase();
            connection.OpenConnection();
            MySqlCommand command = new MySqlCommand(query, connection.GetDatabaseConnection());
            command.ExecuteNonQuery();
            connection.CloseConnection();
        }
        protected void Update()
        {
            connection.ConnectWithDatabase();
            connection.OpenConnection();
            MySqlCommand command = new MySqlCommand(query, connection.GetDatabaseConnection());
            command.ExecuteNonQuery();
            connection.CloseConnection();
        }

        protected void SetQuery(string query)
        {
            this.query = query;
        }

        protected void GetValuesFromDatabase()
        {
            connection.ConnectWithDatabase();
            connection.OpenConnection();
            MySqlCommand command = new MySqlCommand(query, connection.GetDatabaseConnection());
            MySqlDataReader reader = command.ExecuteReader();
            GetValues(reader);
            connection.CloseConnection();
        }

        protected abstract void GetValues(MySqlDataReader reader);
    }
}
