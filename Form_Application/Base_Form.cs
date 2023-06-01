using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Base_Form : Form
    {
        public Base_Form()
        {
            InitializeComponent();
        }

        private void Base_Form_Load(object sender, EventArgs e)
        {
            timer1.Start();
            display_time.Text = DateTime.Now.ToString();
            display_username.Text = "Hello, " + Login_Form.recby;
            this.Hide();
            flowLayoutPanel1.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            display_username.Text = Login_Form.logout;
            this.Hide();
            Login_Form login = new Login_Form();
            login.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            display_time.Text = DateTime.Now.ToString();
            timer1.Start();

        }

        private void display_time_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_Laundry3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.flowLayoutPanel1.Visible == true)
            {
                this.flowLayoutPanel1.Visible = false;
            }
            else
            {
                this.flowLayoutPanel1.Visible = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Application.Employee_Form manage_employee = new Form_Application.Employee_Form();
            manage_employee.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}