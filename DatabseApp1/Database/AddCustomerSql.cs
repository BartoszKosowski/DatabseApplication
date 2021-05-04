using MySql.Data.MySqlClient;
using System;

namespace DatabaseApplication.Database
{
    class AddCustomerSql
    {
        private readonly SqlConnection connection;
        private readonly string[] addressDetails;
        private readonly string[] customerDetails;
        private string query;

        public AddCustomerSql()
        {
            this.connection = null;
            this.addressDetails = null;
            this.customerDetails = null;
        }

        public AddCustomerSql(SqlConnection connection, string[] addressDetails, string[] customerDetails)
        {
            this.connection = connection;
            this.addressDetails = addressDetails;
            this.customerDetails = customerDetails;
        }
        
        public bool IfConnectionExists()    //check if connection with database has been established
        {
            if(connection == null)
            {
                return false;
            }
            return true;
        }

        public void AddCustomer()   //create customer and insert into database 
        {
            AddAddress();
            int addressId = GetAddressId();
            connection.ConnectWithDatabase();
            connection.OpenConnection();
            query = string.Format("INSERT INTO customers (first_name,last_name,phone,address) VALUES (\"{0}\",\"{1}\",\"{2}\",\"{3}\");", customerDetails[0], customerDetails[1], customerDetails[2], addressId);
            MySqlCommand command = new MySqlCommand(query, connection.GetDatabaseConnection());
            command.ExecuteNonQuery();
            connection.CloseConnection();
        }

        private void AddAddress()
        {
            connection.ConnectWithDatabase();
            connection.OpenConnection();
            query = string.Format("INSERT INTO address (street,number,zip_code,city) VALUES (\"{0}\",\"{1}\",\"{2}\",\"{3}\");", addressDetails[0], addressDetails[1], addressDetails[2], addressDetails[3]);
            MySqlCommand command = new MySqlCommand(query, connection.GetDatabaseConnection());
            command.ExecuteNonQuery();
            connection.CloseConnection();
        }

        private int GetAddressId()
        {
            int id=0;
            connection.ConnectWithDatabase();
            connection.OpenConnection();
            string query = "SELECT id FROM address ORDER BY id DESC LIMIT 1;";
            MySqlCommand command = new MySqlCommand(query, connection.GetDatabaseConnection());
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Int32.TryParse(dataReader[0].ToString(), out id);
            }
            connection.CloseConnection();
            return id;
        }


    }
}
