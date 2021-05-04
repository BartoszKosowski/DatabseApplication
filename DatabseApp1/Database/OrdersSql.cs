using System.Data;


namespace DatabaseApplication.Database
{
    class OrdersSql : CoreOperationsSql
    {
        private readonly int id;

        public OrdersSql()
        {
            connection = null;
            name = null;
            id = 0;
            query = string.Empty;
        }

        public OrdersSql(SqlConnection connection, string name)
        {
            this.connection = connection;
            this.name = name;
            id = 0;
            query = string.Empty;
        }

        public OrdersSql(SqlConnection connection, int id)
        {
            this.connection = connection;
            name = null;
            this.id = id;
            query = string.Empty;
        }

        public OrdersSql(SqlConnection connection, string name, int id)
        {
            this.connection = connection;
            this.name = name;
            this.id = id;
            query = string.Empty;
        }

        public DataTable GetAllOrders() //get all orders from databse
        {
            query = "SELECT s.id AS \"ID\", c.first_name AS \"First Name\", c.last_name AS \"Last Name\",s.service_type AS \"Service\"" +
                ",s.order_date AS \"Order Date\", s.expire_date AS \"Expire Date\", s.status AS \"Status\" from customers c JOIN orders s on s.customer = c.id;";

            return GetDataFromDatabase();
        }

        public DataTable GetOrdersByName()  //get customer orders by specified name
        {
            GetName();
            return GetDataFromDatabase();
        }

        public DataTable GetOrdersById()    //get order by ID
        {
            GetId();
            return GetDataFromDatabase();
        }

        public DataTable GetAvtiveOrdersByName()
        {
            GetName();
            return GetDataFromDatabase();
        }

        private void GetName()
        {
            if (CheckName())
            {
                string[] splitName = name.Split(' ');
                query = string.Format("SELECT s.id AS \"ID\", c.first_name AS \"First Name\", c.last_name AS \"Last Name\",s.service_type AS \"Service\"" +
                ",s.order_date AS \"Order Date\", s.expire_date AS \"Expire Date\", s.status AS \"Status\" from customers c JOIN orders s on s.customer = c.id" +
                " WHERE c.first_name LIKE \"{0}\" AND c.last_name LIKE \"%{1}%\";", splitName[0], splitName[1]);
            }
            else
            {
                query = string.Format("SELECT s.id AS \"ID\", c.first_name AS \"First Name\", c.last_name AS \"Last Name\",s.service_type AS \"Service\"" +
                ",s.order_date AS \"Order Date\", s.expire_date AS \"Expire Date\", s.status AS \"Status\" from customers c JOIN orders s on s.customer = c.id" +
                " WHERE c.first_name LIKE \"{0}\" OR c.last_name LIKE \"%{0}%\";", name);
            }
        }

        private void GetId()
        {
            query = string.Format("SELECT s.id AS \"ID\", c.first_name AS \"First Name\", c.last_name AS \"Last Name\",s.service_type AS \"Service\"" +
                ",s.order_date AS \"Order Date\", s.expire_date AS \"Expire Date\", s.status AS \"Status\" from customers c JOIN orders s on s.customer = c.id" +
                " WHERE s.id = {0};", id);
        }


    }
}
