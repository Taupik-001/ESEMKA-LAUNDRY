using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Form_Application
{
    public partial class Employee_Form : Base_Form
    {
        public Employee_Form()
        {
            InitializeComponent();
        }

        private void Manage_Employee_Load(object sender, EventArgs e)
        {
            // SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=ESEMKA_LAUNDRY_LKS_2022;Integrated Security=True");
            // string serverName = "LAPTOP-DRD273ST\\SQLEXPRESS";
            // string databaseName = "ESEMKA";
            // string connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";
            // SqlConnection con = new SqlConnection(connectionString);
            // SqlDataAdapter sqa = new SqlDataAdapter("SELECT * FROM Employee", con);
            // DataTable dt = new DataTable();
            // sqa.Fill(dt);
            // dataGridView1.DataSource = dt;
            // dataGridView1.AutoGenerateColumns = false; // Disable automatic column generation
            // dataGridView1.DataSource = dt;

            // // Specify the column headers manually
            // dataGridView1.Columns["Id"].HeaderText = "Employee Id";
            // dataGridView1.Columns["Name"].HeaderText = "First Name";
            // dataGridView1.Columns["LastName"].HeaderText = "Last Name";
            // Add more columns if needed

            // Alternatively, you can use the column index to set the header
            // dataGridView1.Columns[0].HeaderText = "ID";
            // dataGridView1.Columns[1].HeaderText = "First Name";
            // dataGridView1.Columns[2].HeaderText = "Last Name";
            string serverName = "LAPTOP-DRD273ST\\SQLEXPRESS";
            string databaseName = "ESEMKA";
            string connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT Employee.Id, Employee.Name, Employee.Email, Employee.PhoneNumber, Employee.Address, Employee.DateOfBirth, Job.Name AS JobTitle, Employee.Salary FROM Employee JOIN Job ON Employee.IdJob = Job.Id", con))
            {
                con.Open();

                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
                dataGridView1.RowHeadersVisible = false;

                // dataGridView1.Columns["Id"].HeaderText = "Employee Id";
                dataGridView1.Columns.Add("Id", "Employee Id");
                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("Email", "Email");
                dataGridView1.Columns.Add("PhoneNumber", "Phone Number");
                dataGridView1.Columns.Add("Address", "Address");
                dataGridView1.Columns.Add("DateofBirth", "Date of Birth");
                dataGridView1.Columns.Add("JobTitle", "Job Title");
                dataGridView1.Columns.Add("Salary", "Salary");

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.DataPropertyName = column.Name;
                }
            }




        }
    }
}
