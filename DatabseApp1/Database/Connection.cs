using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApplication.Database
{
    class Connection : IConnection
    {
        private string connectionFilePath;
        public Connection(string connectionFilePath)
        {
            this.connectionFilePath = connectionFilePath;
        }

        public SqlConnection EstablishSqlConnection()
        {
            ConnectionInfo connectionInfo = new ConnectionInfo(connectionFilePath);
            string[] ConnectionInfoDetails = connectionInfo.GetConnectionInfo();
            SqlConnection connection = new SqlConnection(ConnectionInfoDetails[0], ConnectionInfoDetails[1], ConnectionInfoDetails[2], ConnectionInfoDetails[3], ConnectionInfoDetails[4]);
            return connection;
        }
    }
}
