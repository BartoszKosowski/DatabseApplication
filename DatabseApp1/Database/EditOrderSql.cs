using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApplication.Database
{
    class EditOrderSql: EditSql
    {
        private int orderId;
        private DateTime orderDate;
        private DateTime expireDate;
        private string name;
        private string service;
        private string status;
        private string desc;

        public EditOrderSql()
        {
            connection = null;
            orderId = 0;
            orderDate = DateTime.MinValue;
            expireDate = DateTime.MinValue;
            service = null;
            status = "ACT";
            desc = null;
        }

        public EditOrderSql(SqlConnection connection, int orderId)
        {
            this.connection = connection;
            this.orderId = orderId;
            orderDate = DateTime.MinValue;
            expireDate = DateTime.MinValue;
            service = null;
            status = "ACT";
            desc = null;
        }

        public EditOrderSql(SqlConnection connection, int orderId, DateTime expireDate, string service, string status, string desc)
        {
            this.connection = connection;
            this.orderId = orderId;
            this.orderDate = DateTime.MinValue;
            this.expireDate = expireDate;
            this.service = service;
            this.status = status;
            this.desc = desc;
        }

        public void DeleteOrder()
        {
            query = string.Format("DELETE FROM orders WHERE id ={0};", orderId);
            Delete();
        }

        public void UpdateOrder()   
        {
            string formatedExpireDate = FormatDateTime();
            query = string.Format("UPDATE orders SET service_type = \"{0}\",expire_date = \"{1}\",description = \"{2}\", status=\"{3}\" WHERE id={4};", service, formatedExpireDate, desc, status, orderId);
            Update();
        }

        public void GetValuesFromOrders()
        {

            query = string.Format("SELECT c.first_name, c.last_name, o.* FROM orders o JOIN customers c ON o.customer = c.id WHERE o.id = {0}", orderId);
            GetValuesFromDatabase();
        }

        public void GetOrderDetails(out string[] details, out DateTime[] dates)
        {
            details = new string[4];
            details[0] = name;
            details[1] = service;
            details[2] = status;
            details[3] = desc;
            dates = new DateTime[2];
            dates[0] = orderDate;
            dates[1] = expireDate;
        }

        protected override void GetValues(MySqlDataReader reader)
        {
            while (reader.Read())
            {
                name = reader[0].ToString() + " " + reader[1].ToString();
                service = reader[4].ToString();
                orderDate = (DateTime)reader[5];
                expireDate = (DateTime)reader[6];
                desc = reader[7].ToString();
                status = reader[8].ToString();
            }
            reader.Close();
        }

        private string FormatDateTime()
        {
           string formatedExpireDate = expireDate.ToString("yyyy-MM-dd");
            return formatedExpireDate;
        }
    }
}
