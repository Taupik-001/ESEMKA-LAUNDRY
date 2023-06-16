using System;
using System.Collections.Generic;
using System.ComponentModel;
using Test.Service_Program;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace Test.Form_Application
{
    public partial class Service_Form : Base_Form
    {
        private EsemkaContext context = new EsemkaContext();
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
            inp_category.Enabled = field;
            inp_unit.Enabled = field;
            inp_price.Enabled = field;
            inp_est.Enabled = field;
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


            if (inp_unit.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a value from the combo box.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (inp_price.Value == 0)
            {
                MessageBox.Show("Please input a value for the Salary.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (inp_category.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a value from the combo box.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (inp_est.Value == 0)
            {
                MessageBox.Show("Please input a value for the Salary.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // List textbox field input
        private List<TextBox> textBoxes = new List<TextBox>();
        // To clear the field
        void ClearField()
        {
            textBoxes.Add(inp_id);
            textBoxes.Add(inp_name);

            inp_category.SelectedIndex = 0;
            inp_unit.SelectedIndex = 0;
            inp_price.Value = inp_price.Minimum;
            inp_est.Value = inp_est.Minimum;
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }
        }
        // Update the DataGridView
        DataTable? dt = Data_Access_Layer.JoinData("Service", "Category", "Unit");
        private void Manage_Service_Load(object sender, EventArgs e)
        {
            EnabledField(false);
            EnabledField(true, false);

            dtViewService.DataSource = dt;
            dtViewService.AllowUserToOrderColumns = false;
            dtViewService.RowHeadersVisible = false;
            dtViewService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; // Set the AutoSizeColumnsMode property
            dtViewService.ReadOnly = true;
            dtViewService.AllowUserToResizeColumns = false;
            dtViewService.AllowUserToResizeRows = false;
            dtViewService.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtViewService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            List<Service>? serviceList = context.Services?
            .Include(e => e.Category)
            .Include(e => e.Unit)
            .ToList();

            dtViewService.DataSource = serviceList?.Select(e => new
            {
                e.Id,
                e.Name,
                Category = e.Category?.Name,
                Unit = e.Unit?.Name,
                Price = e.PriceUnit,
                e.EstimationDuration
            }
            ).ToList();

            dtViewService.Columns["Id"].HeaderText = "Service Id";
            dtViewService.Columns["Name"].HeaderText = "Service Name";
            dtViewService.Columns["EstimationDuration"].HeaderText = "Estimation Duration";



            // Combo box display name job
            Customer defaultCustomer = new Customer { Id = 0, Name = "" };
            Unit defaultUnit = new Unit { Id = 0, Name = "" };



            // Set the default selected index
            inp_category.SelectedIndex = 0;

            // Set the default selected index
            inp_unit.SelectedIndex = 0;

            // Set the ComboBox style
            inp_category.DropDownStyle = ComboBoxStyle.DropDownList;
            inp_unit.DropDownStyle = ComboBoxStyle.DropDownList;

            dtViewService.SelectionChanged += dtViewService_SelectionChanged; // Attach SelectionChanged event handler
        }

        private void dtViewService_SelectionChanged(object? sender, EventArgs e)
        {
            isRowSelected = dtViewService.SelectedRows.Count > 0;
        }
        private void dtViewService_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row's data ID
                DataGridViewRow row = dtViewService.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);

                // Do something with the data ID...
                DataTable? MDT = Data_Access_Layer.SelectDataWhere("Service", selectedId);

                if (MDT != null && MDT.Rows.Count > 0)
                {
                    DataRow DtField = MDT.Rows[0];
                    inp_id.Text = DtField["Id"].ToString();
                    inp_name.Text = DtField["Name"].ToString();
                    inp_category.SelectedIndex = Convert.ToInt32(DtField["IdCategory"]);
                    inp_unit.SelectedIndex = Convert.ToInt32(DtField["IdUnit"]);


                    if (Decimal.TryParse(DtField["PriceUnit"].ToString(), out decimal price))
                    {
                        inp_price.Value = Math.Floor(price);
                    }
                    if (Decimal.TryParse(DtField["EstimationDuration"].ToString(), out decimal estimation))
                    {
                        inp_est.Value = Math.Floor(estimation);
                    }
                }
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Cancel the sorting operation
            dtViewService.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
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
                int idService = Convert.ToInt32(inp_id.Text);
                int rowEffect = Data_Access_Layer.DeleteData("Service", idService);
                // Close the MessageBox
                if (rowEffect > 0)
                {
                    MessageBox.Show($"Delete completed for Service with ID {idService}!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Perform delete operation and check its success
                    DataTable? dt = Data_Access_Layer.JoinData("Service", "Category", "Unit");
                    dtViewService.DataSource = dt;
                }
                else
                {
                    MessageBox.Show($"Delete failed for Service with ID {idService}.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string id = inp_id.Text;

                // Check if the ID exists in the database
                bool isIdUnique = Data_Access_Layer.IsPhoneNumberUnique("Service", "Id", id);

                string name = inp_name.Text;

                int numericprice = Convert.ToInt32(Math.Floor(inp_price.Value));
                int numericest = Convert.ToInt32(Math.Floor(inp_est.Value));
                int Selectedcat = inp_category.SelectedIndex;
                int Selectedunt = inp_unit.SelectedIndex;

                if (isIdUnique)
                {
                    // Insert data into the database
                    int insertResult = Data_Access_Layer.InsertDataService("Service", id, name, Selectedcat, Selectedunt, numericprice, numericest);
                    DataTable? dt = Data_Access_Layer.JoinData("Service", "Category", "Unit");
                    dtViewService.DataSource = dt;
                    MessageBox.Show("Success!");
                    EnabledField(false);
                    EnabledField(true, false);
                }
                else
                {
                    // Update data in the database
                    int idValue = Convert.ToInt32(id);
                    int updateResult = Data_Access_Layer.UpdateService(idValue, name, Selectedcat, Selectedunt, numericprice, numericest);
                    DataTable? dt = Data_Access_Layer.JoinData("Service", "Category", "Unit");

                    dtViewService.DataSource = dt;
                    MessageBox.Show($"Success Update! {idValue}, {name}, {Selectedcat}, {Selectedunt}, {numericprice}, {numericest}");
                    EnabledField(false);
                    EnabledField(true, false);
                }


                // string message = $"ID: {id}\nName: {name}\nEmail: {email}\nPhone Number: {number}\nAddress: {address}\nPassword: {password}\nSelected Value: {inp_category.SelectedIndex}\nSelected Date: {selectedDate}\nNumeric Value: {numericValue}";

                // MessageBox.Show(message, "Field Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearField();
            EnabledField(false);
            EnabledField(true, false);
        }

        private void inp_search_TextChanged(object sender, EventArgs e)
        {
            //Name
            //Category
            //Unit
            //PriceUnit
            string Input_Search = inp_search.Text;
            //if (!string.IsNullOrWhiteSpace(Input_Search))
            //{
            //    var filterData = dt.AsEnumerable()
            //        .Where
            //        (
            //        row => row.Field<int>("PriceUnit").ToString().Contains(Input_Search)
            //        )
            //        .CopyToDataTable();
            //    dtViewService.DataSource = filterData;

            //}
            //else
            //{
            //    dtViewService.DataSource = dt;
            //}
            //string searchTerm = inp_search.Text;

            if (!string.IsNullOrWhiteSpace(Input_Search))
            {
                try
                {
                    DataTable? dt = Data_Access_Layer.JoinData("Service", "Category", "Unit");
                    if (dt != null)
                    {
                        // Filter the DataTable based on the entered search term
                        var filteredRows = dt.AsEnumerable()
                            .Where(
                                row => row.Field<string>("Name")?.ToString().Contains(Input_Search) == true ||
                                row.Field<string>("Category")?.ToString().Contains(Input_Search) == true ||
                                row.Field<string>("Unit")?.ToString().Contains(Input_Search) == true ||
                                row.Field<int>("PriceUnit").ToString().Contains(Input_Search) == true
                            )
                            .CopyToDataTable();

                        // Update the DataGridView with the filtered results
                        dtViewService.DataSource = filteredRows;
                    }

                }
                catch
                {
                    // MessageBox.Show("Data NOT FOUND");
                    // DataTable? dt = Data_Access_Layer.JoinData("Service", "Category", "Unit");
                    // Reset the DataGridView to the original data
                    dtViewService.DataSource = new DataTable();
                }
            }
            else
            {
                DataTable? dt = Data_Access_Layer.JoinData("Service", "Category", "Unit");
                // Reset the DataGridView to the original data
                dtViewService.DataSource = dt;
            }
            //DataView dv = dt.DefaultView;
            //dv.RowFilter = string.Format("name like '%{0}%' OR category like '%{0}%' OR unit like '%{0}%'", inp_search.Text);
            ////dv.RowFilter = string.Format("priceunit like '%{1}%'", inp_search.Text);
            //dtViewService.DataSource = dv.ToTable();
        }

        private void inp_search_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
