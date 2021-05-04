using System;
using MySql.Data.MySqlClient;

namespace DatabaseApplication.Database
{
    class EditCustomerSql: EditSql
    {
        private string[] addressDetails;
        private string[] customerDetails;
        private int customerId;
        private int addressId;
        private int _addressId;

        public EditCustomerSql()
        {
            connection = null;
            addressDetails = null;
            customerDetails = null;
            customerId = 0;
        }

        public EditCustomerSql(SqlConnection connection, int customerId)
        {
            this.connection = connection;
            this.addressDetails = new string[4];
            this.customerDetails = new string[3];
            this.customerId = customerId;
        }

        public EditCustomerSql(SqlConnection connection, int customerId, string[] addressDetails, string[] customerDetails)
        {
            this.connection = connection;
            this.addressDetails = addressDetails;
            this.customerDetails = customerDetails;
            this.customerId = customerId;
        }

        public void DeleteCustomer()
        {
            query = string.Format("DELETE FROM customers WHERE id={0};", customerId);
            Delete();
        }
        public void UpdateCustomer()
        {
            query = string.Format("UPDATE customers SET first_name = \"{0}\",last_name = \"{1}\",phone = \"{2}\" WHERE id={3};", customerDetails[0], customerDetails[1], customerDetails[2], customerId);
            Update();
        }

        public void UpdateAddress()
        {
            query = string.Format("UPDATE address SET street = \"{0}\",number = \"{1}\",zip_code = \"{2}\",city=\"{3}\" WHERE id={4};", addressDetails[0], addressDetails[1], addressDetails[2], addressDetails[3], _addressId);
            Update();
        }

        public void GetValuesFromCustomers()
        {
            query = string.Format("SELECT * FROM customers c JOIN address a ON c.address = a.id WHERE c.id = {0}", customerId);
            GetValuesFromDatabase();
        }



        public string[] GetAddressDetails()
        {
            return addressDetails;
        }

        public string[] GetCustomerDetails()
        {
            return customerDetails;
        }

        protected override void GetValues(MySqlDataReader reader)
        {
            while (reader.Read())
            {
                int j = 0;
                for(int i = 1; i < 10; i++)
                {
                    if (i < 4)
                    {
                        customerDetails[j] = reader[i].ToString();
                        j++;
                    }
                    if (i == 5)
                    {
                        addressId = Int32.Parse(reader[i].ToString());
                        _addressId = addressId;
                    }
                    if (i > 5)
                    {
                        if (i == 6)
                            j = 0;
                        addressDetails[j] = reader[i].ToString();
                        j++;
                    }
                }
            }
            reader.Close();
        }
    }
}
