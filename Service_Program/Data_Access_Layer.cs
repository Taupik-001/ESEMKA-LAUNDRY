using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace Test.Service_Program
{
    public static class Data_Access_Layer
    {
        private static string serverName = "LOCALHOST\\SQLEXPRESS";
        private static string databaseName = "ESEMKA2023";
        private static string connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";

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
        public static bool IsPhoneNumberUnique(string table, string column, string phoneNumber)
        {
            // Construct the query to check if the phone number exists in the database
            string query = $"SELECT COUNT(*) FROM {table} WHERE {column} = {phoneNumber}";

            // Execute the query and get the result
            DataTable result = ExecuteQuery(query);

            // Check if the result contains any rows
            if (result != null && result.Rows.Count > 0)
            {
                // Get the count value from the first row and convert it to an integer
                int count = Convert.ToInt32(result.Rows[0][0]);

                // If the count is greater than 0, the phone number already exists
                return count == 0;
            }

            // Default to returning true if there is an error or no result
            return true;
        }
        public static bool IsCheckUnique(string table, string column, int id)
        {
            string query = $"SELECT COUNT(*) FROM {table} WHERE {column} = {id}";
            DataTable result = ExecuteQuery(query);
            if (result != null && result.Rows.Count > 0)
            {
                // Get the count value from the first row and convert it to an integer
                int count = Convert.ToInt32(result.Rows[0][0]);

                // If the count is greater than 0, the phone number already exists
                return count == 0;
            }

            // Default to returning true if there is an error or no result
            return true;
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
                    MessageBox.Show("Error executing non-query: " + ex.Message);
                    return -1;
                }
                finally
                {
                    connection.Close();
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
        public static DataTable? JoinData1(string firstTable, string secondTable)
        {
            string query = $"SELECT {firstTable}.*, {secondTable}.Name AS ServiceTitle " +
                           $"FROM {firstTable} JOIN {secondTable} ON {firstTable}.IdService = {secondTable}.Id";
            return ExecuteQuery(query);
        }
        public static DataTable? JoinData(string firstTable, string secondTable, string thirdTable)
        {
            string query = $"SELECT {firstTable}.*, {secondTable}.Name AS Category, {thirdTable}.Name AS Unit " +
                           $"FROM {firstTable} " +
                           $"JOIN {secondTable} ON {firstTable}.IdCategory = {secondTable}.Id " +
                           $"JOIN {thirdTable} ON {firstTable}.IdUnit = {thirdTable}.Id ";

            return ExecuteQuery(query);
        }
        public static DataTable? JoinData1(string firstTable, string secondTable, string thirdTable)
        {
            string query = $"SELECT {firstTable}.*, {secondTable}.Name AS CustomerTitle, {thirdTable}.IdService AS PackageTitle " +
                           $"FROM {firstTable} " +
                           $"JOIN {secondTable} ON {firstTable}.IdCustomer = {secondTable}.Id " +
                           $"JOIN {thirdTable} ON {firstTable}.IdPackage = {thirdTable}.Id ";
            //$"JOIN ";

            return ExecuteQuery(query);
        }
        public static DataTable? JoinData2(string firstTable, string secondTable, string thirdTable)
        {
            string query = $"SELECT {firstTable}.*, {secondTable}.Name AS CustomerTitle, {thirdTable}.Name AS EmployeeTitle " +
                           $"FROM {firstTable} " +
                           $"JOIN {secondTable} ON {firstTable}.IdCustomer = {secondTable}.Id " +
                           $"JOIN {thirdTable} ON {firstTable}.IdEmployee = {thirdTable}.Id ";
            //$"JOIN ";

            return ExecuteQuery(query);
        }
        public static DataTable? JoinData3(string firstTable, string secondTable, string thirdTable)
        {
            string query = $"SELECT {firstTable}.*, {secondTable}.Name AS ServiceName, {thirdTable}.Id AS PrepaidId " +
                           $"FROM {firstTable} " +
                           $"JOIN {secondTable} ON {firstTable}.IdService = {secondTable}.Id " +
                           $"JOIN {thirdTable} ON {firstTable}.IdPrepaidPackage = {thirdTable}.Id ";
            //$"JOIN ";

            return ExecuteQuery(query);
        }



        public static int UpdateData(int id, string name, string email, string password, string number, string address, DateTime selectedDate, int numericValue, int selectedCombo)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = "UPDATE Employee SET Name = @Name, Password = @Password, Email = @Email,  PhoneNumber = @PhoneNumber, DateofBirth = @DateOfBirth, Address = @Address, IdJob = @IdJob, Salary = @Salary WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PhoneNumber", number);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@DateOfBirth", selectedDate);
                    command.Parameters.AddWithValue("@IdJob", selectedCombo);
                    command.Parameters.AddWithValue("@Salary", numericValue);
                    command.Parameters.AddWithValue("@Id", id);

                    return command.ExecuteNonQuery();
                }
            }
        }

        public static int UpdateService(int id, string name, int value1, int value2, int value3, int value4)
        {
            string query = $"UPDATE Service SET Name = '{name}', IdCategory = {value1}, IdUnit = {value2}, PriceUnit = {value3}, EstimationDuration = {value4} WHERE Id = {id}";
            return ExecuteNonQuery(query);
        }


        public static int DeleteData(string tablName, int id)
        {
            string query = $"DELETE FROM {tablName} WHERE Id = {id}";
            return ExecuteNonQuery(query);
        }

        public static int InsertData(string nameTable, string columns1, string columns2, string columns3, string value1, string value2, string value3)
        {
            string query = $"INSERT INTO {nameTable} ({columns1}, {columns2}, {columns3}) VALUES ('{value1}', '{value2}')";
            return ExecuteNonQuery(query);
        }
        public static int InsertDataCustomer(string nameTable, string value1, string value2, string value3)
        {
            string query = $"INSERT INTO {nameTable} (Name, PhoneNumber, Address) VALUES ('{value1}', '{value2}', '{value3}')";
            return ExecuteNonQuery(query);
        }
        public static int InsertDataEmployee(string nameTable, int id, string name, string email, string password, string phoneNumber, string address, DateTime dateOfBirth, decimal salary, int jobId)
        {
            string query = $"SET IDENTITY_INSERT {nameTable} ON; " +
                           $"INSERT INTO {nameTable} (Id, Name, Email, Password, PhoneNumber, Address, DateofBirth, Salary, IdJob) " +
                           $"VALUES ({id}, '{name}', '{email}', '{password}', '{phoneNumber}', '{address}', '{dateOfBirth.ToString("yyyy-MM-dd")}', {salary}, {jobId}); " +
                           $"SET IDENTITY_INSERT {nameTable} OFF;";

            return ExecuteNonQuery(query);
        }
        public static int InsertDataService(string nameTable, string id, string name, int email, int password, int phoneNumber, int address)
        {
            string query = $"SET IDENTITY_INSERT {nameTable} ON; " +
                           $"INSERT INTO {nameTable} (Id, Name, IdCategory, IdUnit, PriceUnit, EstimationDuration) " +
                           $"VALUES ('{id}', '{name}', '{email}', '{password}', '{phoneNumber}', '{address}'); " +
                           $"SET IDENTITY_INSERT {nameTable} OFF;";

            return ExecuteNonQuery(query);
        }
        public static DataTable? SelectWhere(string columData1, string columData2)
        {
            string query = $"SELECT * FROM Employee WHERE Email = {columData1} AND Password = {columData2}";
            return ExecuteQuery(query);
        }


    }
}
