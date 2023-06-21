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

            dtViewService.CellContentClick += dtViewService_CellContentClick;

            Customer defaultCustomer = new Customer { Id = 0, PhoneNumber = "" };
            List<Customer>? listCustomer = context.Customers?.ToList();

            listCustomer?.Insert(0, defaultCustomer);

            inp_customer.DisplayMember = "PhoneNumber";
            inp_customer.ValueMember = "Id";
            inp_customer.DataSource = listCustomer;

            // Set up ComboBox properties
            inp_customer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            inp_customer.AutoCompleteSource = AutoCompleteSource.ListItems;

            //Disable the vertical scrollbar
            inp_customer.IntegralHeight = false;
            inp_customer.MaxDropDownItems = 5; // Set the desired number of items to display

            //Adjust the height of the dropdown to fit the items
            inp_customer.DropDownHeight = inp_customer.ItemHeight * (inp_customer.MaxDropDownItems + 1);


            //inp_customer.DropDownStyle = ComboBoxStyle.Simple;

            dtViewService.CellClick += DtViewService_CellClick;
            dtViewService.SelectionChanged += DtViewService_SelectionChanged;

        }

        private void DtViewService_SelectionChanged(object? sender, EventArgs e)
        {
            isRowSelected = dtViewService.SelectedRows.Count > 0;
        }

        private int days = 24;

        private string dateEst { get; set; }
        private int IdService { get; set; }
        private int PriceUnit { get; set; }
        private decimal TotalUnit { get; set; }
        private int SubTotal { get; set; }

        private void DtViewService_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtViewService.Rows[e.RowIndex];
                string Service = row.Cells[0].Value.ToString();
                PriceUnit = Convert.ToInt32(row.Cells[2].Value);
                TotalUnit = Convert.ToDecimal(row.Cells[3].Value);
                SubTotal = Convert.ToInt32(row.Cells[4].Value);
                var serviceName = context.Services.FirstOrDefault(e => e.Name == Service);
                if (serviceName != null)
                {
                    IdService = serviceName.Id;
                }
                else
                {
                    MessageBox.Show("Data not found");
                }

                MessageBox.Show($"Cell Clicked {IdService}, {PriceUnit}, {TotalUnit}, {SubTotal}");
            }
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            var serviceCategory = context.Services.FirstOrDefault(e => e.Id == inp_service.SelectedIndex);

            int totalHour = serviceCategory.EstimationDuration;

            if (!isRowSelected)
            {
                MessageBox.Show("Please select a row in datagridView to Insert data");
                return;
            }

            if (inp_customer.SelectedIndex == 0)
            {
                MessageBox.Show("Please select customer data");
                return;
            }
            else
            {

            }

            if (serviceCategory.IdCategory == 1)
            {
                MessageBox.Show($"You are currently in data {serviceCategory.IdCategory}");

                dateEst = serviceCategory.EstimationDuration.ToString();
            }
            else
            {
                MessageBox.Show($"You are currently in data {serviceCategory.IdCategory}");
                dateEst = serviceCategory.EstimationDuration.ToString();
            }

            HeaderDeposit insertHeader = new HeaderDeposit
            {
                IdCustomer = inp_customer.SelectedIndex,
                IdEmployee = Login_Form.IdEmployee,
                TransactionDatetime = DateTime.Now,
                CompleteEstimationDatetime = DateTime.Now
            };

            int hour = totalHour % days;
            int day = totalHour / days;
            string output = $"{day} days 00:{hour}:00";
            label2.Text = output;
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
