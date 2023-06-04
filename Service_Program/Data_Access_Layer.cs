using System;
using System.Data;
using System.Data.SqlClient;

namespace Test.Service_Program
{
    public static class Data_Access_Layer
    {
        // private static string connectionString = "your_connection_string";
        private static string serverName = "LAPTOP-DRD273ST\\SQLEXPRESS";
        private static string databaseName = "ESEMKA2023";
        private static string connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
        // SqlConnection con = new SqlConnection(connectionString);

        private static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public static DataTable? ExecuteQuery(string query)
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error executing query: " + ex.Message);
                    return null;
                }
            }
        }

        public static int ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Handle the exception appropriately
                    Console.WriteLine("Error executing non-query: " + ex.Message);
                    return -1;
                }
            }
        }

        // Example methods for select, update, delete, and insert operations

        public static DataTable? SelectData(string NameTable)
        {
            string query = $"SELECT * FROM {NameTable}";
            return ExecuteQuery(query);
        }
        public static DataTable? SelectDataWhere(string NameTable, int IdCollumn)
        {
            string query = $"SELECT * FROM {NameTable} WHERE Id = {IdCollumn}";
            return ExecuteQuery(query);
        }

        public static DataTable? JoinData(string firstTable, string secondTable)
        {
            string query = $"SELECT {firstTable}.*, {secondTable}.Name AS JobTitle FROM {firstTable} JOIN {secondTable} ON {firstTable}.IdJob = {secondTable}.Id";
            return ExecuteQuery(query);
        }


        public static int UpdateData(int id, string newValue)
        {
            string query = $"UPDATE YourTable SET YourColumn = '{newValue}' WHERE Id = {id}";
            return ExecuteNonQuery(query);
        }

        public static int DeleteData(int id)
        {
            string query = $"DELETE FROM YourTable WHERE Id = {id}";
            return ExecuteNonQuery(query);
        }

        public static int InsertData(string value1, string value2)
        {
            string query = $"INSERT INTO YourTable (Column1, Column2) VALUES ('{value1}', '{value2}')";
            return ExecuteNonQuery(query);
        }
    }
}
