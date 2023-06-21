using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore;

namespace Test.Form_Application
{
    public partial class Employee_Form : Base_Form
    {
        private bool isInsert = false;
        private EsemkaContext context = new EsemkaContext();
        private bool isRowSelected = false;
        private int selectedId { get; set; }
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
        private void DisplayToDataGridView()
        {
            List<Employee>? listEmployee = context.Employees?.Include(e => e.Job).ToList();
            dtViewEmployee.DataSource = listEmployee?.Select(e => new
            {
                e.Id,
                e.Name,
                e.Email,
                e.PhoneNumber,
                e.Address,
                e.DateOfBirth,
                NameJob = e.Job?.Name,
                e.Salary
            }).ToList();
        }
        private void Manage_Employee_Load(object sender, EventArgs e)
        {
            EnabledField(false);
            EnabledField(true, false);

            DisplayToDataGridView();

            // Define columns
            dtViewEmployee.Columns["Id"].HeaderText = "Employee Id";
            dtViewEmployee.Columns["PhoneNumber"].HeaderText = "Phone Number";
            dtViewEmployee.Columns["DateOfBirth"].HeaderText = "Date of Birth";
            dtViewEmployee.Columns["NameJob"].HeaderText = "Title Job";

            // Combo box display name job
            Job defaultJob = new Job { Id = 0, Name = "" };

            List<Job>? jobList = context.Jobs?.ToList();
            jobList?.Insert(0, defaultJob);

            inp_combo.DisplayMember = "Name";
            inp_combo.ValueMember = "Id";
            inp_combo.DataSource = jobList;
            inp_combo.SelectedIndex = 0;

            inp_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            dtViewEmployee.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            dtViewEmployee.SelectionChanged += dtViewEmployee_SelectionChanged; // Attach SelectionChanged event handler
            dtViewEmployee.CellClick += dtViewEmployee_CellClick;
        }
        private void inp_search_TextChanged(object sender, EventArgs e)
        {
            // Make textbox to Input Search String lower
            string searchText = inp_search.Text.ToLower();

            var filteredData = context.Employees?
                .Where(e => (e.Name != null && e.Name.ToLower().Contains(searchText)) ||
                    (e.PhoneNumber != null && e.PhoneNumber.ToLower().Contains(searchText)) ||
                    (e.Email != null && e.Email.ToLower().Contains(searchText)))
                .Select(e => new
                {
                    e.Id,
                    e.Name,
                    e.Email,
                    e.PhoneNumber,
                    e.Address,
                    e.DateOfBirth,
                    NameJob = e.Job != null ? e.Job.Name : null,
                    e.Salary
                })
                .ToList();
            dtViewEmployee.DataSource = filteredData;
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
                var EmployeesList = context.Employees?.FirstOrDefault(e => e.Id == selectedId);

                if (EmployeesList != null)
                {
                    inp_id.Text = EmployeesList.Id.ToString();
                    inp_password.Text = EmployeesList.Password;
                    inp_conpassword.Text = EmployeesList.Password;
                    inp_name.Text = EmployeesList.Name;
                    inp_email.Text = EmployeesList.Email;
                    inp_phone.Text = EmployeesList.PhoneNumber;
                    inp_address.Text = EmployeesList.Address;
                    inp_combo.SelectedIndex = EmployeesList.IdJob;
                    string formattedDate = EmployeesList.DateOfBirth.ToString("yyyy-MM-dd");
                    inp_date.Text = formattedDate;
                    inp_numeric.Value = Math.Floor(EmployeesList.Salary);
                }
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            // Cancel the sorting operation
            dtViewEmployee.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            
>>>>>>> 3c406e9311a38e4fe68d3e5dcc7be420a85b72ab
            ClearField();
            EnabledField(true);
            EnabledField(false, true);
            isInsert = true;
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
                isInsert = false;
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!isRowSelected)
            {
                MessageBox.Show($"{"Please select a row to delete."}{"No Row Selected"}{MessageBoxButtons.OK}{MessageBoxIcon.Warning}");
                return;
            }

            DialogResult result = MessageBox.Show("Would you like to delete this data Id : " + selectedId + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Perform the delete logic...
                var rowEffect = context.Employees?.Find(selectedId);
                // Close the MessageBox
                if (rowEffect != null)
                {
                    MessageBox.Show($"Delete completed for employee with ID {selectedId}!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Perform delete operation and check its success
                    context.Employees?.Remove(rowEffect);
                    context.SaveChanges();

                    // Update the DataGridView
                    DisplayToDataGridView();
                }
                else
                {
                    MessageBox.Show($"Delete failed for employee with ID {selectedId}.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int id = Convert.ToInt32(inp_id.Text);

                // Check if the ID exists in the database
                var isIdUnique = context.Employees?.Find(id);

                string name = inp_name.Text;
                string email = inp_email.Text;
                string number = inp_phone.Text;
                string address = inp_address.Text;
                string password = inp_password.Text;

                DateTime selectedDate = inp_date.Value;
                int numericValue = Convert.ToInt32(Math.Floor(inp_numeric.Value));
                int Selectedcombo = inp_combo.SelectedIndex;

                if (isInsert)
                {
                    if (isIdUnique != null)
                    {
                        MessageBox.Show($"Unable to insert data. ID {id} already exists. If you want to update data, please use the Update button.");
                        return;
                    }

                    //Insert data into the database
                    var insertData = new Employee
                    {
                        Password = password,
                        Name = name,
                        Email = email,
                        Address = address,
                        PhoneNumber = number,
                        DateOfBirth = selectedDate,
                        IdJob = Selectedcombo,
                        Salary = numericValue
                    };
                    context.Employees?.Add(insertData);
                    context.SaveChanges();
                    DisplayToDataGridView();
                    MessageBox.Show($"Success insert data for ID : {insertData.Id}");
                }
                else
                {
                    if (isIdUnique == null)
                    {
                        MessageBox.Show($"Unable to update data. ID {id} was not found. If you want to insert data, please use the Insert button.");
                        return;
                    }
                    // Update data in the database
                    isIdUnique.Name = name;
                    isIdUnique.Email = email;
                    isIdUnique.Password = password;
                    isIdUnique.PhoneNumber = number;
                    isIdUnique.Address = address;
                    isIdUnique.DateOfBirth = selectedDate;
                    isIdUnique.IdJob = Selectedcombo;
                    isIdUnique.Salary = numericValue;
                    context.SaveChanges();

                    DisplayToDataGridView();
                    MessageBox.Show($"Success Update data for ID : {id}");
                }
                EnabledField(false);
                EnabledField(true, false);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            EnabledField(false);
            EnabledField(true, false);
        }

        private void inp_id_TextChanged(object sender, EventArgs e)
        {

        }
        private void inp_search_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void dtViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
