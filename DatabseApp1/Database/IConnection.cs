namespace DatabaseApplication.Database
{
    interface IConnection
    {
        SqlConnection EstablishSqlConnection();
    }
}
