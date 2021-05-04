using System.Data;

namespace DatabaseApplication.Database
{
    class CustomersSql : CoreOperationsSql
    {
        public CustomersSql()
        {
            connection = null;
            name = null;
            query = string.Empty;
        }

        public CustomersSql(SqlConnection connection, string name)
        {
            this.connection = connection;
            this.name = name;
            query = string.Empty;
        }

        public DataTable GetAllCustomers()  //get all customers from database
        {
            query = "SELECT c.id AS \"ID\", c.first_name AS \"First Name\", c.last_name AS \"Last Name\", c.phone AS \"Phone\", " +
                "a.street AS \"Street\", a.number AS \"Number\", a.zip_code AS \"Zip Code\" , a.city AS \"City\" from customers c JOIN address a on c.address = a.id;";

            return GetDataFromDatabase();
        }

        public DataTable GetSpecifiedCustomer() //get specified customer from database
        {

            if (CheckName())
            {
                string[] splitName = name.Split(' ');
                query = string.Format("SELECT c.id AS \"ID\", c.first_name AS \"First Name\", c.last_name AS \"Last Name\", c.phone AS \"Phone\", " +
                "a.street AS \"Street\", a.number AS \"Number\", a.zip_code AS \"Zip Code\" , a.city AS \"City\" " +
                "from customers c JOIN address a on c.address = a.id WHERE c.first_name LIKE \"{0}\" AND c.last_name LIKE \"%{1}%\";", splitName[0], splitName[1]);
            }
            else
            {
                query = string.Format("SELECT c.id AS \"ID\", c.first_name AS \"First Name\", c.last_name AS \"Last Name\", c.phone AS \"Phone\", " +
                "a.street AS \"Street\", a.number AS \"Number\", a.zip_code AS \"Zip Code\" , a.city AS \"City\" " +
                "from customers c JOIN address a on c.address = a.id WHERE c.first_name LIKE \"{0}\" OR c.last_name LIKE \"%{0}%\";", name);
            }
            
            return GetDataFromDatabase();
        }


        
    }
}
