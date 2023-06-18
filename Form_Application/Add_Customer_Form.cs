using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Form_Application
{
    public partial class Add_Customer_Form : Form
    {
        public Add_Customer_Form()
        {
            InitializeComponent();
        }
        private bool ValidateInput()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(inp_name.Text) || string.IsNullOrEmpty(inp_address.Text))
            {
                MessageBox.Show("Please fill all fields.");
                isValid = false;
            }

            // Validate the phone number
            string phoneNumber = inp_phone.Text;
            if (!string.IsNullOrEmpty(phoneNumber))
            {
                // Remove any spaces or dashes from the input
                phoneNumber = phoneNumber.Replace(" ", "").Replace("-", "");

                // Check if the phone number starts with a plus sign (+)
                if (!phoneNumber.StartsWith("+") && phoneNumber.Skip(1).All(char.IsDigit))
                {
                    MessageBox.Show("Please enter a valid phone number starting with '+'.");
                    isValid = false;
                }
                EsemkaContext context = new EsemkaContext();
                // Check if the phone number is unique in the database
                var isUnique = context.Customers?.FirstOrDefault(e => e.PhoneNumber == phoneNumber);
                if (isUnique != null)
                {
                    MessageBox.Show("Phone number already exists.");
                    isValid = false;
                }
            }

            return isValid;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                EsemkaContext context = new EsemkaContext();
                var InsertData = new Customer
                {
                    Name = inp_name.Text,
                    PhoneNumber = inp_phone.Text,
                    Address = inp_address.Text
                };
                context.Customers?.Add(InsertData);
                context.SaveChanges();

                MessageBox.Show($"Insert for Customer with ID : {InsertData.Id} Completed");
                this.Close();
            }
        }
    }
}
