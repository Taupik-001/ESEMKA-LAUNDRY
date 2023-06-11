using System;
using System.Collections.Generic;
using System.ComponentModel;
using Test.Service_Program;
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
                if (!phoneNumber.StartsWith("+"))
                {
                    MessageBox.Show("Phone number must start with a plus sign (+).");
                    isValid = false;
                }

                // Check if the remaining characters are numeric
                string numericPart = phoneNumber.Substring(1);
                if (!numericPart.All(char.IsDigit))
                {
                    MessageBox.Show("Phone number must contain only numeric characters.");
                    isValid = false;
                }

                // Check if the phone number is unique in the database
                bool isUnique = Data_Access_Layer.IsPhoneNumberUnique("Customer", "PhoneNumber", phoneNumber);
                if (!isUnique)
                {
                    MessageBox.Show("Phone number already exists in the database.");
                    isValid = false;
                }
            }

            return isValid;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                MessageBox.Show("Insert Completed");
                int InsertCustomer = Data_Access_Layer.InsertDataCustomer("Customer", inp_name.Text, inp_phone.Text, inp_address.Text);
                this.Close();
            }
        }
    }
}
