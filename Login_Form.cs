using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        public static string? username;
        public static string recby
        {
            get { return username ?? string.Empty; }
            set { username = value; }
        }
        public static string logout
        {
            get { username = null; return string.Empty; }
            set { username = null; }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            string serverName = "LAPTOP-DRD273ST\\SQLEXPRESS";
            string databaseName = "ESEMKA";
            string connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";
            SqlConnection con = new SqlConnection(connectionString);

            SqlDataAdapter sqa = new SqlDataAdapter("SELECT * FROM Employee WHERE Email = @Username AND Password = @Password", con);
            sqa.SelectCommand.Parameters.AddWithValue("@Username", input_username.Text);
            sqa.SelectCommand.Parameters.AddWithValue("@Password", input_password.Text);

            DataTable dt = new DataTable();
            sqa.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                recby = dt.Rows[0][2].ToString() ?? string.Empty;
                this.Hide();
                Main_Form main = new Main_Form();
                main.Show();
            }
            else
            {
                MessageBox.Show("Please Try Again, Your Data is not Valid!");
            }
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            input_username.Clear();
            input_password.Clear();
        }
    }
}
