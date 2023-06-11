﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Test.Service_Program;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Net.Mail;


namespace Test.Form_Application
{
    public partial class Employee_Form : Base_Form
    {
        private bool isRowSelected = false;
        private int selectedId;
        public Employee_Form()
        {
            InitializeComponent();
        }
        // Enabled or Disable Field
        void EnabledField(bool field)
        {
            inp_id.Enabled = field;
            inp_name.Enabled = field;
            inp_email.Enabled = field;
            inp_phone.Enabled = field;
            inp_address.Enabled = field;
            inp_date.Enabled = field;
            inp_combo.Enabled = field;
            inp_numeric.Enabled = field;
            inp_password.Enabled = field;
            inp_conpassword.Enabled = field;
        }
        // Enabled or Disabled Button
        void EnabledField(bool button1, bool button2)
        {
            btn_insert.Enabled = button1;
            btn_update.Enabled = button1;
            btn_delete.Enabled = button1;

            btn_cancel.Enabled = button2;
            btn_save.Enabled = button2;
        }
        private bool ValidateInput()
        {
            // Check if all fields are filled
            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // Validate email format
            if (!IsValidEmail(inp_email.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate phone number format
            if (!IsValidPhoneNumber(inp_phone.Text))
            {
                MessageBox.Show("Please enter a valid phone number starting with '+'.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate password format
            if (!IsValidPassword(inp_password.Text))
            {
                MessageBox.Show("Please enter a valid password that consists of an alphabet, a numeric, and a symbol.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check if password and confirm password match
            if (inp_password.Text != inp_conpassword.Text)
            {
                MessageBox.Show("Password and confirm password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Check if Combo box doesnt Selected
            if (inp_combo.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a value from the combo box.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Chack if value for numeric is Only 0
            if (inp_numeric.Value == 0)
            {
                MessageBox.Show("Please input a value for the Salary.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        // Validate input email
        private bool IsValidEmail(string email)
        {
            try
            {
                // Attempt to create a MailAddress instance with the given email
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                // The email address is not in a valid format
                return false;
            }
        }

        // Validate phone number format
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Phone number must start with '+', followed by digits
            return phoneNumber.StartsWith("+") && phoneNumber.Skip(1).All(char.IsDigit);
        }

        // Validate password format using regular expression
        private bool IsValidPassword(string password)
        {
            // Regular expression pattern for password validation
            string pattern = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$";
            return Regex.IsMatch(password, pattern);
        }

        // List textbox field input
        private List<TextBox> textBoxes = new List<TextBox>();
        // To clear the field
        void ClearField()
        {
            textBoxes.Add(inp_id);
            textBoxes.Add(inp_name);
            textBoxes.Add(inp_email);
            textBoxes.Add(inp_phone);
            textBoxes.Add(inp_address);
            textBoxes.Add(inp_password);
            textBoxes.Add(inp_conpassword);

            inp_date.Value = DateTime.Now;
            inp_combo.SelectedIndex = 0;
            inp_numeric.Value = inp_numeric.Minimum;
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }
        }
        private void Manage_Employee_Load(object sender, EventArgs e)
        {
            EnabledField(false);
            EnabledField(true, false);

            DataTable? dt = Data_Access_Layer.JoinData("Employee", "Job");
            dtViewEmployee.AutoGenerateColumns = false;
            dtViewEmployee.DataSource = dt;
            dtViewEmployee.AllowUserToOrderColumns = false;
            dtViewEmployee.RowHeadersVisible = false;
            dtViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; // Set the AutoSizeColumnsMode property
            dtViewEmployee.ReadOnly = true;
            dtViewEmployee.AllowUserToResizeColumns = false;
            dtViewEmployee.AllowUserToResizeRows = false;
            dtViewEmployee.AllowUserToAddRows = false;
            dtViewEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtViewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            // Define columns
            dtViewEmployee.Columns.Add("Id", "Employee Id");
            dtViewEmployee.Columns.Add("Name", "Name");
            dtViewEmployee.Columns.Add("Email", "Email");
            dtViewEmployee.Columns.Add("PhoneNumber", "Phone Number");
            dtViewEmployee.Columns.Add("Address", "Address");
            dtViewEmployee.Columns.Add("DateofBirth", "Date of Birth");
            dtViewEmployee.Columns.Add("JobTitle", "Job Title");
            dtViewEmployee.Columns.Add("Salary", "Salary");
            //dtViewEmployee.Rows.RemoveAt(dtViewEmployee.Rows.Count - 1);

            foreach (DataGridViewColumn column in dtViewEmployee.Columns)
            {
                column.DataPropertyName = column.Name;
            }

            // Combo box display name job
            // Retrieve data from the database
            DataTable? dta = Data_Access_Layer.SelectData("Job");


            // Create a new DataTable and add columns
            DataTable newdta = new DataTable();
            newdta.Columns.Add("JobId");
            newdta.Columns.Add("Name");

            // Add an empty row as the default selection
            newdta.Rows.Add(0, "");

            // Merge the retrieved data into the new DataTable
            if (dta != null)
            {
                newdta.Merge(dta);
            }

            // Set up ComboBox properties
            inp_combo.DisplayMember = "Name";
            inp_combo.ValueMember = "JobId";
            inp_combo.DataSource = newdta;

            // Set the default selected index
            inp_combo.SelectedIndex = 0;

            // Set the ComboBox style
            inp_combo.DropDownStyle = ComboBoxStyle.DropDownList;

            dtViewEmployee.SelectionChanged += dtViewEmployee_SelectionChanged; // Attach SelectionChanged event handler
        }

        private void dtViewEmployee_SelectionChanged(object? sender, EventArgs e)
        {
            isRowSelected = dtViewEmployee.SelectedRows.Count > 0;
        }

        private void dtViewEmployee_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row's data ID
                DataGridViewRow row = dtViewEmployee.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);

                // Do something with the data ID...
                DataTable? dt = Data_Access_Layer.SelectDataWhere("Employee", selectedId);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow DtField = dt.Rows[0];
                    inp_id.Text = DtField["Id"].ToString();
                    inp_password.Text = DtField["Password"].ToString();
                    inp_conpassword.Text = DtField["Password"].ToString();
                    inp_name.Text = DtField["Name"].ToString();
                    inp_email.Text = DtField["Email"].ToString();
                    inp_phone.Text = DtField["PhoneNumber"].ToString();
                    inp_address.Text = DtField["Address"].ToString();
                    inp_combo.SelectedIndex = Convert.ToInt32(DtField["IdJob"]);

                    if (DateTime.TryParseExact(DtField["DateofBirth"].ToString(), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateOfBirth))
                    {
                        string formattedDate = dateOfBirth.ToString("yyyy-MM-dd");
                        inp_date.Text = formattedDate;
                    }

                    if (Decimal.TryParse(DtField["Salary"].ToString(), out decimal salary))
                    {
                        inp_numeric.Value = Math.Floor(salary);
                    }
                }
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Cancel the sorting operation
            dtViewEmployee.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            ClearField();
            EnabledField(true);
            EnabledField(false, true);
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!isRowSelected)
            {
                MessageBox.Show("Please select a row to update.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                EnabledField(true);
                EnabledField(false, true);
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!isRowSelected)
            {
                MessageBox.Show($"{"Please select a row to delete."}{"No Row Selected"}{MessageBoxButtons.OK}{MessageBoxIcon.Warning}");
                return;
            }

            DialogResult result = MessageBox.Show("Would you like to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Perform the delete logic...
                int idEmployee = Convert.ToInt32(inp_id.Text);
                int rowEffect = Data_Access_Layer.DeleteData("Employee", idEmployee);
                // Close the MessageBox
                if (rowEffect > 0)
                {
                    MessageBox.Show($"Delete completed for employee with ID {idEmployee}!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Perform delete operation and check its success

                    // Update the DataGridView
                    DataTable? dt = Data_Access_Layer.JoinData("Employee", "Job");
                    dtViewEmployee.DataSource = dt;
                }
                else
                {
                    MessageBox.Show($"Delete failed for employee with ID {idEmployee}.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int id = Convert.ToInt32(inp_id.Text);

                // Check if the ID exists in the database
                bool isIdUnique = Data_Access_Layer.IsCheckUnique("Employee", "Id", id);

                string name = inp_name.Text;
                string email = inp_email.Text;
                string number = inp_phone.Text;
                string address = inp_address.Text;
                string password = inp_password.Text;

                DateTime selectedDate = inp_date.Value;
                int numericValue = Convert.ToInt32(Math.Floor(inp_numeric.Value));
                int Selectedcombo = inp_combo.SelectedIndex;

                if (isIdUnique)
                {
                    //Insert data into the database
                    int insertResult = Data_Access_Layer.InsertDataEmployee("Employee", id, name, email, password, number, address, selectedDate, numericValue, Selectedcombo);
                    DataTable? dt = Data_Access_Layer.JoinData("Employee", "Job");
                    dtViewEmployee.DataSource = dt;
                    MessageBox.Show("Success!");
                    EnabledField(false);
                    EnabledField(true, false);
                }
                else
                {
                    // Update data in the database
                    int idValue = Convert.ToInt32(inp_id.Text);
                    int updateResult = Data_Access_Layer.UpdateData(idValue, name, email, password, number, address, selectedDate, numericValue, Selectedcombo);
                    DataTable? dt = Data_Access_Layer.JoinData("Employee", "Job");
                    dtViewEmployee.DataSource = dt;
                    MessageBox.Show($"Success Update!");
                    EnabledField(false);
                    EnabledField(true, false);
                    //{ idValue}
                    //{ name}
                    //{ email}
                    //{ password}
                    //{ number}
                    //{ address}
                    //{ selectedDate}
                    //{ numericValue}
                    //{ Selectedcombo}
                }
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearField();
            EnabledField(false);
            EnabledField(true, false);
        }

        private void inp_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void inp_search_TextChanged(object sender, EventArgs e)
        {
            DataTable? dt = Data_Access_Layer.JoinData("Employee", "Job");
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("name like '%{0}%' OR phonenumber like '%{0}%' OR email like '%{0}%'", inp_search.Text);
            dtViewEmployee.DataSource = dv.ToTable();
        }

        private void inp_search_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
