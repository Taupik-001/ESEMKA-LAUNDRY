using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Test.Form_Application
{
    public partial class Package_Form : Base_Form
    {
        private bool isInsert = false;
        private int selectedId { get; set; }
        private EsemkaContext context = new EsemkaContext();
        private bool isRowSelected = false;
        public Package_Form()
        {
            InitializeComponent();
        }
        private void enableField(bool enab)
        {
            packageId.Enabled = enab;
            serviceCom.Enabled = enab;
            totalunitNum.Enabled = enab;
            priceNum.Enabled = enab;
        }
        private void enableField(bool enab, bool noten)
        {
            btn_insert.Enabled = enab;
            btn_delete.Enabled = enab;
            btn_update.Enabled = enab;

            btn_cancel.Enabled = noten;
            btn_save.Enabled = noten;
        }
        private void ClearField()
        {
            packageId.Clear();
            serviceCom.SelectedIndex = 0;
            totalunitNum.Value = totalunitNum.Minimum;
            priceNum.Value = priceNum.Minimum;
        }
        private void DisplayToDataGridView()
        {
            List<Package>? packageList = context.Packages?
            .Include(e => e.Service)
            .ToList();
            dataViewPackage.DataSource = packageList?.Select(e => new
            {
                e.Id,
                ServiceName = e.Service?.Name,
                e.TotalUnit,
                e.Price
            }).ToList();
        }
        private void Package_Form_Load(object sender, EventArgs e)
        {
            enableField(false);
            enableField(true, false);

            DisplayToDataGridView();

            dataViewPackage.Columns["Id"].HeaderText = "Package Id";
            dataViewPackage.Columns["ServiceName"].HeaderText = "Service Name";
            dataViewPackage.Columns["TotalUnit"].HeaderText = "Total Unit";

            Service DefaultService = new Service { Id = 0, Name = "" };

            List<Service>? serviceList = context.Services?.ToList();
            serviceList?.Insert(0, DefaultService);

            serviceCom.DisplayMember = "Name";
            serviceCom.ValueMember = "Id";
            serviceCom.DataSource = serviceList;
            serviceCom.SelectedIndex = 0;

            serviceCom.DropDownStyle = ComboBoxStyle.DropDownList;

            dataViewPackage.CellClick += dataGridView1_CellClick;
            dataViewPackage.SelectionChanged += dataGridView1_SelectionChanged;
            dataViewPackage.RowHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
        }
        private void dataGridView1_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            // Cancel the sorting operation
            dataViewPackage.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataViewPackage.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);

                var packageList = context.Packages?.FirstOrDefault(e => e.Id == selectedId);

                if (packageList != null)
                {
                    packageId.Text = packageList.Id.ToString();
                    serviceCom.SelectedIndex = packageList.IdService;
                    totalunitNum.Value = packageList.TotalUnit;
                    priceNum.Value = packageList.Price;
                }
            }
        }
        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            isRowSelected = dataViewPackage.SelectedRows.Count > 0;
        }
        private void search_input_TextChanged(object sender, EventArgs e)
        {
            string InputSearch = search_input.Text.ToLower();
            var filteredData = context.Packages?
            .Where(
                e => e.Service.Name.ToLower().Contains(InputSearch) ||
                (e.TotalUnit.ToString().Contains(InputSearch)) ||
                (e.Price.ToString().Contains(InputSearch))
            )
            .Select(e => new
            {
                e.Id,
                e.Service.Name,
                e.TotalUnit,
                e.Price
            }).ToList();
            dataViewPackage.DataSource = filteredData;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ClearField();
            enableField(true);
            enableField(false, true);
            isInsert = true;
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            enableField(true);
            enableField(false, true);
            isInsert = false;
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!isRowSelected)
            {
                MessageBox.Show($"{"Please Select a row!"}{"No Row Selected!"}{MessageBoxButtons.OK}{MessageBoxIcon.Warning}");
                return;
            }
            DialogResult result = MessageBox.Show("Would you like to delete this data? ID : " + selectedId, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var DeleteData = context.Packages?.Find(selectedId);

                if (DeleteData != null)
                {
                    MessageBox.Show($"Delete completed for data Package with ID {selectedId}", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    context.Packages?.Remove(DeleteData);
                    context.SaveChanges();

                    DisplayToDataGridView();
                }
                else
                {
                    MessageBox.Show($"Deled failed for Package with ID : {selectedId}. ID Not Found", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(packageId.Text))
            {
                MessageBox.Show("Package ID cannot be Empty!");
                return false;
            }
            if (serviceCom.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Service");
                return false;
            }
            if (totalunitNum.Value == 0)
            {
                MessageBox.Show("Total Unit cannot be Empty!");
                return false;
            }
            if (priceNum.Value == 0)
            {
                MessageBox.Show("Price cannot be Empty!");
                return false;
            }
            return true;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int id = Convert.ToInt32(packageId.Text);
                int serviceId = serviceCom.SelectedIndex;
                int totalUnit = Convert.ToInt32(totalunitNum.Value);
                int price = Convert.ToInt32(priceNum.Value);

                var isIdUnique = context.Packages?.Find(id);

                if (isInsert)
                {
                    if (isIdUnique != null)
                    {
                        MessageBox.Show($"Unable to Insert data ID : {id} already exist. Please use Update button if you want to Update data!");
                        return;
                    }

                    var InsertData = new Package
                    {
                        IdService = serviceId,
                        TotalUnit = totalUnit,
                        Price = price
                    };

                    context.Packages?.Add(InsertData);
                    context.SaveChanges();
                    DisplayToDataGridView();
                    MessageBox.Show($"Success Insert data for ID : {InsertData.Id}");
                }
                else
                {
                    if (isIdUnique == null)
                    {
                        MessageBox.Show($"Unable to Update data ID : {id} not found. Please use Insert button if you want to Insert data!");
                        return;
                    }

                    isIdUnique.IdService = serviceId;
                    isIdUnique.TotalUnit = totalUnit;
                    isIdUnique.Price = price;

                    context.SaveChanges();
                    DisplayToDataGridView();
                    MessageBox.Show($"Success Update data for ID : {id}");
                }

                enableField(false);
                enableField(true, false);


            }

        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            enableField(false);
            enableField(true, false);
        }
        private void packageId_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
