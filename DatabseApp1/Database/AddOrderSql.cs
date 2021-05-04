using MySql.Data.MySqlClient;
using System;

namespace DatabaseApplication.Database
{
    class AddOrderSql
    {
        private readonly SqlConnection connection;
        private readonly int customerId;
        private readonly string service;
        private readonly string desc;
        private readonly DateTime orderDate;
        private readonly DateTime expireDate;
        

        public AddOrderSql()
        {
            this.connection = null;
            this.customerId = 0;
            this.service = null;
            this.desc = null;
            this.orderDate = DateTime.Now.Date;
            this.expireDate = DateTime.Now.Date;
        }

        public AddOrderSql(SqlConnection connection, int customerId, string service, string desc, DateTime expireDate)
        {
            this.connection = connection;
            this.customerId = customerId;
            this.service = service;
            this.desc = desc;
            this.orderDate = DateTime.Now.Date;
            this.expireDate = expireDate;
        }  
        
        public void CreateOrder()   //Create new order and insert into database
        {
            connection.ConnectWithDatabase();
            connection.OpenConnection();
            string formatedOrderDate;
            string formatedExpireDate;
            FormatDateTime(out formatedOrderDate, out formatedExpireDate);
            string query =string.Format("INSERT INTO orders (customer, service_type, order_date, expire_date, description) VALUES (\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\");",customerId, service, formatedOrderDate, formatedExpireDate, desc);
            MySqlCommand command = new MySqlCommand(query, connection.GetDatabaseConnection());
            command.ExecuteNonQuery();
            connection.CloseConnection();
        }

        private void FormatDateTime(out string formatedOrderDate, out string formatedExpireDate)
        {
            formatedOrderDate = orderDate.ToString("yyyy-MM-dd");
            formatedExpireDate = expireDate.ToString("yyyy-MM-dd");
        }
    }
}
