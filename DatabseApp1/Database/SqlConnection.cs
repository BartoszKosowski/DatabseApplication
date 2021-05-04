using MySql.Data.MySqlClient;

namespace DatabaseApplication.Database
{
    class SqlConnection
    {
        private MySqlConnection connection;
        protected string server;
        protected string user;
        protected string database;
        protected string port;
        protected string password;

        public SqlConnection(string server, string user, string password, string database, string port)
        {
            this.user = user;
            this.server = server;
            this.password = password;
            this.database = database;
            this.port = port;
        }


        public void ConnectWithDatabase()   //establish connection with database
        {
            string connString = string.Format("server={0};user={1};database={2};port={3};password={4}", server, user, database, port, password);
            connection = new MySqlConnection(connString);
        }

        public MySqlConnection GetDatabaseConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
