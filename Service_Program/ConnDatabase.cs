using System.Data.SqlClient;

namespace Test.Service_Program
{
    public static class ConnDatabase
    {
        public static SqlConnection Conn()
        {
            string serverName = "LAPTOP-DRD273ST\\SQLEXPRESS";
            string databaseName = "ESEMKA";
            string connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
    }
}
