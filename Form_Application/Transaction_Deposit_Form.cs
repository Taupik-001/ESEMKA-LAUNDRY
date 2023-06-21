using System.Data;

namespace Test.Form_Application
{

    public partial class Transaction_Deposit_Form : Base_Form
    {
        private EsemkaContext context = new EsemkaContext();
        private int selectedId;
        private Add_Customer_Form? modalDialog; // Declare an instance variable for the modal dialog form
        private bool isRowSelected = false;

        public Transaction_Deposit_Form()
        {
            InitializeComponent();

        }

        private EsemkaContext context = new EsemkaContext();

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Toggle the modal dialog
            if (modalDialog == null || modalDialog.IsDisposed)
            {
                modalDialog = new Add_Customer_Form();
                modalDialog.ShowDialog();
            }
            else
            {
                modalDialog.Close();
                modalDialog.Dispose();
                modalDialog = null;
            }
        }



        private void Transaction_Deposit_Form_Load(object sender, EventArgs e)
        {
            Package_Form.ComBo(inp_service);
            listBox1.Visible = false;

            dtViewService.CellContentClick += dtViewService_CellContentClick;

            Customer defaultCustomer = new Customer { Id = 0, PhoneNumber = "" };
            List<Customer> listCustomer = context.Customers.ToList();

            listCustomer.Insert(0, defaultCustomer);

            inp_customer.DisplayMember = "PhoneNumber";
            inp_customer.ValueMember = "Id";
            inp_customer.DataSource = listCustomer;
            inp_customer.SelectedIndex = 0;

            // Set up ComboBox properties
            inp_customer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            inp_customer.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Remove the dropdown arrow and disable the dropdown list
            inp_customer.DropDownStyle = ComboBoxStyle.Simple;

            // Disable the vertical scrollbar
            inp_customer.IntegralHeight = false;
            inp_customer.MaxDropDownItems = 5; // Set the desired number of items to display

            // Adjust the height of the dropdown to fit the items
            inp_customer.DropDownHeight = inp_customer.ItemHeight * (inp_customer.MaxDropDownItems + 1);

        }
        private void inp_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer? selectedCustomer = inp_customer?.SelectedItem as Customer;
            if (selectedCustomer != null)
            {
                // Display the selected customer's name and address
                name_display.Text = selectedCustomer.Name;
                address_display.Text = selectedCustomer.Address;
            }
        }
        private void dtViewService_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtViewService.Columns["Action"].Index && e.RowIndex >= 0)
            {
                // Handle the button click for the clicked row
                // You can access the row using e.RowIndex and perform your desired actions
                // Get the row that was clicked
                DataGridViewRow clickedRow = dtViewService.Rows[e.RowIndex];

                // Remove the row from the DataGridView
                dtViewService.Rows.Remove(clickedRow);

                // Perform any other desired actions for deletion

                MessageBox.Show($"Button clicked for row {e.RowIndex}. Row deleted.");
            }
        }

        private void inp_phone_number_TextChanged(object sender, EventArgs e)
        {

        }
        private void inp_customer_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int IdService = inp_service.SelectedIndex;
            int Price = Convert.ToInt32(textBox1.Text);
            decimal Unit = inp_unit.Value;
            string Prepaid;
            decimal SubTotal;
            var NameService = context.Services.Find(IdService);

            if (NameService != null)
            {
                string Name = NameService.Name;
                if (checkBox1.Checked)
                {
                    Prepaid = Name;
                    SubTotal = 0;
                }
                else
                {
                    Prepaid = "";
                    SubTotal = Unit * Price;
                }

                DataTable dt = dtViewService.DataSource as DataTable;
                if (dt == null)
                {
                    dt = new DataTable();
                    dt.Columns.Add("Service");
                    dt.Columns.Add("Prepaid Package");
                    dt.Columns.Add("Price per Unit");
                    dt.Columns.Add("Total Unit");
                    dt.Columns.Add("Subtotal");
                    dtViewService.DataSource = dt;

                    DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn
                    {
                        Name = "Action",
                        HeaderText = "Action",
                        Text = "Delete",
                        UseColumnTextForButtonValue = true
                    };

                    dtViewService.Columns.Add(actionColumn);
                }

                DataRow newRow = dt.NewRow();

                newRow["Service"] = Name;
                newRow["Prepaid Package"] = Prepaid;
                newRow["Price per Unit"] = Price;
                newRow["Total Unit"] = Unit;
                newRow["Subtotal"] = SubTotal;

                dt.Rows.Add(newRow); // Add the new row to the DataTable
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int IdService = inp_service.SelectedIndex;
            int Price = Convert.ToInt32(textBox1.Text);
            decimal Unit = inp_unit.Value;
            string Prepaid;
            decimal SubTotal;
            var NameService = context.Services?.Find(IdService);

            if (NameService != null)
            {
                string? Name = NameService.Name;
                if (checkBox1.Checked)
                {
                    Prepaid = Name;
                    SubTotal = 0;
                }
                else
                {
                    Prepaid = "";
                    SubTotal = Unit * Price;
                }

                DataTable? dt = dtViewService.DataSource as DataTable;
                if (dt == null)
                {
                    dt = new DataTable();
                    dt.Columns.Add("Service");
                    dt.Columns.Add("Prepaid Package");
                    dt.Columns.Add("Price per Unit");
                    dt.Columns.Add("Total Unit");
                    dt.Columns.Add("Subtotal");
                    dtViewService.DataSource = dt;

                    DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn
                    {
                        Name = "Action",
                        HeaderText = "Action",
                        Text = "Delete",
                        UseColumnTextForButtonValue = true
                    };

                    dtViewService.Columns.Add(actionColumn);
                }

                DataRow newRow = dt.NewRow();

                newRow["Service"] = Name;
                newRow["Prepaid Package"] = Prepaid;
                newRow["Price per Unit"] = Price;
                newRow["Total Unit"] = Unit;
                newRow["Subtotal"] = Convert.ToInt32(SubTotal);

                dt.Rows.Add(newRow); // Add the new row to the DataTable
            }

        }

        private void dtViewService_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inp_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer? selectedCustomer = inp_customer?.SelectedItem as Customer;
            if (selectedCustomer != null)
            {
                // Display the selected customer's name and address
                name_display.Text = selectedCustomer.Name;
                address_display.Text = selectedCustomer.Address;
            }
        }
    }
}
