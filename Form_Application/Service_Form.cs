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
    public partial class Service_Form : Base_Form
    {
        private bool isRowSelected = false;
        private int selectedId;
        public Service_Form()
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
            // Connection string
            SqlConnection con = ConnDatabase.Conn();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Employee.Id, Employee.Password, Employee.Name, Employee.Email, Employee.PhoneNumber, Employee.Address, Employee.DateofBirth, Job.Name AS JobTitle, Employee.Salary FROM Employee JOIN Job ON Employee.IdJob = Job.Id", con);
            // Datatable
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dtViewEmployee.DataSource = dt;

            // Collumn header each field from database
            dtViewEmployee.Columns.Add("Id", "Employee Id");
            dtViewEmployee.Columns.Add("Name", "Name");
            dtViewEmployee.Columns.Add("Email", "Email");
            dtViewEmployee.Columns.Add("PhoneNumber", "Phone Number");
            dtViewEmployee.Columns.Add("Address", "Address");
            dtViewEmployee.Columns.Add("DateofBirth", "Date of Birth");
            dtViewEmployee.Columns.Add("JobTitle", "Job Title");
            dtViewEmployee.Columns.Add("Salary", "Salary");

            foreach (DataGridViewColumn column in dtViewEmployee.Columns)
            {
                column.DataPropertyName = column.Name;
            }

            // Combo box display name job
            SqlDataAdapter sqa = new SqlDataAdapter("SELECT Id, Name FROM Job", con);

            DataTable dta = new DataTable();
            sqa.Fill(dta);

            DataTable newdta = new DataTable();
            newdta.Columns.Add("JobId");
            newdta.Columns.Add("Name");
            newdta.Rows.Add(0, "");

            newdta.Merge(dta);

            inp_combo.DisplayMember = "Name";
            inp_combo.ValueMember = "JobId";
            inp_combo.DataSource = newdta;

            inp_combo.SelectedIndex = 0;

            inp_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            con.Close();
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
                SqlConnection con = ConnDatabase.Conn();
                con.Open();
                SqlDataAdapter dt_Emp = new SqlDataAdapter("SELECT Employee.Id, Employee.Password, Employee.Name, Employee.Email, Employee.PhoneNumber, Employee.Address, Employee.DateofBirth, Employee.IdJob, Employee.Salary FROM Employee WHERE Employee.Id = @IdEmployee", con);
                dt_Emp.SelectCommand.Parameters.AddWithValue("@IdEmployee", selectedId);
                // 
                DataTable dt = new DataTable();
                dt_Emp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow DtField = dt.Rows[0];
                    inp_id.Text = DtField["Id"].ToString();
                    inp_password.Text = DtField["Password"].ToString();
                    inp_conpassword.Text = DtField["Password"].ToString();
                    inp_name.Text = DtField["Name"].ToString();
                    inp_email.Text = DtField["Email"].ToString();
                    inp_phone.Text = DtField["PhoneNumber"].ToString();
                    inp_address.Text = DtField["Address"].ToString();

                    string? dateOfBirthString = DtField["DateofBirth"]?.ToString();
                    DateTime dateOfBirth = dateOfBirthString != null ? DateTime.ParseExact(dateOfBirthString, "dd/MM/yyyy", CultureInfo.InvariantCulture) : DateTime.MinValue;
                    inp_date.Value = dateOfBirth;


                    inp_combo.SelectedIndex = Convert.ToInt32(DtField["IdJob"]);

                    decimal salary = Convert.ToDecimal(DtField["Salary"]);
                    inp_numeric.Value = Math.Floor(salary);
                }
                else
                {
                    inp_id.Text = string.Empty;
                    inp_name.Text = string.Empty;
                    inp_password.Text = string.Empty;
                    inp_conpassword.Text = string.Empty;
                    inp_email.Text = string.Empty;
                    inp_phone.Text = string.Empty;
                    inp_address.Text = string.Empty;
                    inp_date.Value = DateTime.Now;
                    inp_combo.SelectedIndex = 0;
                    inp_numeric.Value = 0;
                }
                con.Close();
            }
        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Cancel the sorting operation
            dtViewEmployee.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            EnabledField(true);
            EnabledField(false, true);
            ClearField();
            SqlConnection con = ConnDatabase.Conn();
            con.Open();
            SqlDataAdapter sqa = new SqlDataAdapter("INSERT INTO Employee VALUES", con);
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

            DialogResult result = MessageBox.Show("Do you want to perform the update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Perform the update logic...

                // Close the MessageBox
                MessageBox.Show("Update completed.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.Cancel)
            {
                // Close the MessageBox
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            EnabledField(false);
            EnabledField(true, false);
            MessageBox.Show($"{"Save"}");
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            EnabledField(false);
            EnabledField(true, false);
            MessageBox.Show($"{"Cancel"}");
        }
    }
}
