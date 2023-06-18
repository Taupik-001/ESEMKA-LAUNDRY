using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private bool isInsert = false;
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

        private void DisplayToDataGridView()
        {
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
            }).ToList();
        }
        private void Manage_Service_Load(object sender, EventArgs e)
        {
            EnabledField(false);
            EnabledField(true, false);

            dtViewService.AllowUserToOrderColumns = false;
            dtViewService.RowHeadersVisible = false;
            dtViewService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; // Set the AutoSizeColumnsMode property
            dtViewService.ReadOnly = true;
            dtViewService.AllowUserToResizeColumns = false;
            dtViewService.AllowUserToResizeRows = false;
            dtViewService.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtViewService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            DisplayToDataGridView();

            dtViewService.Columns["Id"].HeaderText = "Service Id";
            dtViewService.Columns["Name"].HeaderText = "Service Name";
            dtViewService.Columns["EstimationDuration"].HeaderText = "Estimation Duration";

            // Combo box display name job
            Category defaultCategory = new Category { Id = 0, Name = "" };
            List<Category>? ListCategory = context.Categorys?.ToList();
            ListCategory?.Insert(0, defaultCategory);
            inp_category.DisplayMember = "Name";
            inp_category.ValueMember = "Id";
            inp_category.DataSource = ListCategory;
            // Set the default selected index
            inp_category.SelectedIndex = 0;

            // Set the default selected index
            Unit defaultUnit = new Unit { Id = 0, Name = "" };
            List<Unit>? ListUnit = context.Units?.ToList();
            ListUnit?.Insert(0, defaultUnit);

            inp_unit.DisplayMember = "Name";
            inp_unit.ValueMember = "Id";
            inp_unit.DataSource = ListUnit;
            inp_unit.SelectedIndex = 0;

            // Set the ComboBox style
            inp_category.DropDownStyle = ComboBoxStyle.DropDownList;
            inp_unit.DropDownStyle = ComboBoxStyle.DropDownList;
            dtViewService.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            dtViewService.CellClick += dtViewService_CellClick;
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
                var ServiceData = context.Services?.FirstOrDefault(e => e.Id == selectedId);

                if (ServiceData != null)
                {
                    inp_id.Text = ServiceData.Id.ToString();
                    inp_name.Text = ServiceData.Name;
                    inp_category.SelectedIndex = ServiceData.IdCategory;
                    inp_unit.SelectedIndex = ServiceData.IdUnit;

                    inp_price.Value = ServiceData.PriceUnit;
                    inp_est.Value = ServiceData.EstimationDuration;
                }
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            // Cancel the sorting operation
            dtViewService.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            ClearField();
            EnabledField(true);
            EnabledField(false, true);
            isInsert = true;
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            isInsert = false;
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
            int idService = Convert.ToInt32(inp_id.Text);
            if (!isRowSelected)
            {
                MessageBox.Show($"{"Please select a row to delete."}{"No Row Selected"}{MessageBoxButtons.OK}{MessageBoxIcon.Warning}");
                return;
            }

            DialogResult result = MessageBox.Show($"Would you like to delete this data ID {idService} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Perform the delete logic...
                var rowEffect = context.Services?.Find(idService);

                // Close the MessageBox
                if (rowEffect != null)
                {
                    MessageBox.Show($"Delete completed for Service with ID {idService}!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Perform delete operation and check its success
                    context.Services?.Remove(rowEffect);
                    context.SaveChanges();

                    DisplayToDataGridView();
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
                int id = Convert.ToInt32(inp_id.Text);

                // Check if the ID exists in the database
                var isIdUnique = context.Services?.Find(id);

                string name = inp_name.Text;
                int numericprice = Convert.ToInt32(Math.Floor(inp_price.Value));
                int numericest = Convert.ToInt32(Math.Floor(inp_est.Value));
                int Selectedcat = inp_category.SelectedIndex;
                int Selectedunt = inp_unit.SelectedIndex;
                if (isInsert)
                {
                    if (isIdUnique != null)
                    {
                        MessageBox.Show($"Unable to insert data. ID {id} already exists. If you want to update data, please use the Update button.");
                        return;
                    }
                    var insertData = new Service
                    {
                        Name = name,
                        IdCategory = Selectedcat,
                        IdUnit = Selectedunt,
                        PriceUnit = numericprice,
                        EstimationDuration = numericest
                    };
                    context.Services?.Add(insertData);
                    context.SaveChanges();

                    DisplayToDataGridView();

                    MessageBox.Show($"Success Insert for ID : {insertData.Id}");
                }
                else
                {
                    if (isIdUnique == null)
                    {
                        MessageBox.Show($"Unable to update data. ID {id} was not found. If you want to insert data, please use the Insert button.");
                        return;
                    }
                    isIdUnique.Name = name;
                    isIdUnique.IdCategory = Selectedcat;
                    isIdUnique.IdUnit = Selectedunt;
                    isIdUnique.PriceUnit = numericprice;
                    isIdUnique.EstimationDuration = numericest;
                    // Update data in the database
                    context.SaveChanges();
                    DisplayToDataGridView();
                    MessageBox.Show($"Success Update for ID : {id}");
                }
                EnabledField(false);
                EnabledField(true, false);
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

            string Input_Search = inp_search.Text.ToLower();

            var filteredData = context.Services?
            .Where
            (
                e => e.Name != null && e.Name.ToLower().Contains(Input_Search) ||
                    (e.Category.Name.ToLower().Contains(Input_Search)) ||
                    (e.Unit.Name.ToLower().Contains(Input_Search)) ||
                    (e.PriceUnit.ToString().Contains(Input_Search))
            )
            .Select(e => new
            {
                e.Id,
                e.Name,
                Category = e.Category != null ? e.Category.Name : null,
                Unit = e.Unit != null ? e.Unit.Name : null,
                Price = e.PriceUnit,
                e.EstimationDuration
            }).ToList();

            dtViewService.DataSource = filteredData;
        }

        private void inp_search_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
