namespace Test.Form_Application
{
    partial class Transaction_Deposit_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_title = new Label();
            textBox1 = new TextBox();
            dtViewService = new DataGridView();
            lbl_name = new Label();
            lbl_email = new Label();
            lbl_address = new Label();
            lbl_date = new Label();
            inp_service = new ComboBox();
            inp_customer = new ComboBox();
            inp_unit = new NumericUpDown();
            add_customer = new LinkLabel();
            listBox1 = new ListBox();
            panel1 = new Panel();
            address_display = new Label();
            name_display = new Label();
            label5 = new Label();
            label4 = new Label();
            inp_phone_number = new TextBox();
            lbl_totalun = new Label();
            label3 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            btn_add = new Button();
            btn_submit = new Button();
            lbl_total = new Label();
            lbl_estimation = new Label();
            ((System.ComponentModel.ISupportInitialize)dtViewService).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inp_unit).BeginInit();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_title.Location = new Point(420, 61);
            lbl_title.Margin = new Padding(4, 0, 4, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(151, 20);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Transaction Deposit";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(326, 235);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 2;
            // 
            // dtViewService
            // 
            // // Add columns to the DataGridView
            // dtViewService.Columns.Add("Service", "Service");
            // dtViewService.Columns.Add("Prepaid Package", "Prepaid Package");
            // dtViewService.Columns.Add("Price per Unit", "Price per Unit");
            // dtViewService.Columns.Add("Total Unit", "Total Unit");
            // dtViewService.Columns.Add("Subtotal", "Subtotal");
            // DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn
            // {
            //     Name = "Action",
            //     HeaderText = "Action",
            //     Text = "Delete",
            //     UseColumnTextForButtonValue = true
            // };
            // dtViewService.Columns.Add(actionColumn);


            // Additional properties
            dtViewService.AllowUserToResizeColumns = false;
            dtViewService.AllowUserToResizeRows = false;
            dtViewService.AllowUserToAddRows = false;
            dtViewService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtViewService.ColumnHeadersHeight = 50;
            dtViewService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtViewService.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtViewService.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtViewService.Location = new Point(479, 167);
            dtViewService.Margin = new Padding(4, 3, 4, 3);
            dtViewService.Name = "dtViewService";
            dtViewService.ReadOnly = true;
            dtViewService.RowHeadersVisible = false;
            dtViewService.Size = new Size(384, 223);
            dtViewService.TabIndex = 3;
            dtViewService.ColumnHeadersHeight = 50; // Set the desired height in pixels
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(215, 210);
            lbl_name.Margin = new Padding(4, 0, 4, 0);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(44, 15);
            lbl_name.TabIndex = 6;
            lbl_name.Text = "Service";

            // 
            // lbl_totalun
            // 
            lbl_totalun.AutoSize = true;
            lbl_totalun.Location = new Point(215, 265);
            lbl_totalun.Margin = new Padding(4, 0, 4, 0);
            lbl_totalun.Name = "lbl_totalun";
            lbl_totalun.Size = new Size(78, 15);
            lbl_totalun.TabIndex = 6;
            lbl_totalun.Text = "Total Unit";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(536, 413);
            lbl_address.Margin = new Padding(4, 0, 4, 0);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(67, 15);
            lbl_address.TabIndex = 6;
            lbl_address.Text = "Total Price :";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Location = new Point(505, 446);
            lbl_date.Margin = new Padding(4, 0, 4, 0);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(98, 15);
            lbl_date.TabIndex = 6;
            lbl_date.Text = "Estimation Time :";
            // 
            // inp_service
            // 
            inp_service.FormattingEnabled = true;
            inp_service.Location = new Point(326, 207);
            inp_service.Margin = new Padding(4, 3, 4, 3);
            inp_service.Name = "inp_service";
            inp_service.Size = new Size(140, 23);
            inp_service.TabIndex = 2;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(215, 235);
            lbl_email.Margin = new Padding(4, 0, 4, 0);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(78, 15);
            lbl_email.TabIndex = 6;
            lbl_email.Text = "Price Per Unit";
            //
            // textBox1
            //
            textBox1.Location = new Point(326, 235);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 2;
            // 
            // inp_unit
            // 
            inp_unit.DecimalPlaces = 1;
            inp_unit.Location = new Point(326, 265);
            inp_unit.Margin = new Padding(4, 3, 4, 3);
            inp_unit.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            inp_unit.Name = "inp_unit";
            inp_unit.Size = new Size(140, 23);
            inp_unit.TabIndex = 0;
            // 
            // add_customer
            // 
            add_customer.AutoSize = true;
            add_customer.Font = new Font("Arial", 10F, FontStyle.Underline, GraphicsUnit.Point);
            add_customer.ForeColor = Color.Blue;
            add_customer.Location = new Point(290, 137);
            add_customer.Margin = new Padding(4, 0, 4, 0);
            add_customer.Name = "add_customer";
            add_customer.Size = new Size(151, 16);
            add_customer.TabIndex = 10;
            add_customer.TabStop = true;
            add_customer.Text = "Not Found? Add New +";
            add_customer.LinkClicked += LinkLabel_LinkClicked;
            // 
            // panel1
            // 
            // panel1.Controls.Add(address_display);
            // panel1.Controls.Add(name_display);
            // panel1.Controls.Add(label5);
            // panel1.Controls.Add(label4);
            // panel1.Controls.Add(listBox1);
            // panel1.Controls.Add(inp_phone_number);
            // panel1.Controls.Add(label3);
            // panel1.Controls.Add(label2);
            // panel1.Controls.Add(add_customer);
            panel1.Location = new Point(182, 95);
            panel1.Name = "panel1";
            // panel1.Size = new Size(682, 65);
            panel1.Size = new Size(682, 65);
            panel1.TabIndex = 1;
            panel1.BorderStyle = BorderStyle.FixedSingle; // Set the border style to FixedSingle


            // 
            // address_display
            // 
            address_display.AutoSize = true;
            address_display.Location = new Point(554, 137);
            address_display.Name = "address_display";
            address_display.Size = new Size(57, 15);
            address_display.TabIndex = 15;
            address_display.Text = "[Address]";
            // 
            // name_display
            // 
            name_display.AutoSize = true;
            name_display.Location = new Point(554, 106);
            name_display.Name = "name_display";
            name_display.Size = new Size(47, 15);
            name_display.TabIndex = 14;
            name_display.Text = "[Name]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(479, 137);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 13;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 106);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 12;
            label4.Text = "Name";
            // 
            // inp_phone_number
            // 
            inp_phone_number.Location = new Point(200000, 110);
            inp_phone_number.Name = "inp_phone_number";
            inp_phone_number.Size = new Size(150, 23);
            inp_phone_number.TabIndex = 2;
            inp_phone_number.TextChanged += inp_phone_number_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(20000, 133);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 200);
            listBox1.TabIndex = 0;
            // 
            // inp_customer
            // 
            inp_customer.FormattingEnabled = true;
            inp_customer.Location = new Point(290, 110);
            inp_customer.Name = "inp_customer";
            inp_customer.Size = new Size(140, 23);
            inp_customer.TabIndex = 0;

            // inp_customer.DroppedDown = true;
            inp_customer.TextChanged += inp_customer_TextChanged;
            inp_customer.SelectedIndexChanged += inp_customer_SelectedIndexChanged;

            // 
            // listBox1
            // 
            // listBox1.FormattingEnabled = true;
            // listBox1.Location = new Point(290, 50);
            // listBox1.Name = "listBox1";
            // listBox1.Size = new Size(131, 300);
            // listBox1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 118);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 1;
            label3.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 95);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 0;
            label2.Text = "Customer";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(326, 294);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(135, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Use prepaid Package";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(730, 475);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(75, 23);
            btn_submit.TabIndex = 14;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(391, 329);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 14;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Location = new Point(658, 413);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(78, 15);
            lbl_total.TabIndex = 15;
            lbl_total.Text = "<total_price>";
            // 
            // lbl_estimation
            // 
            lbl_estimation.AutoSize = true;
            lbl_estimation.Location = new Point(658, 446);
            lbl_estimation.Name = "lbl_estimation";
            lbl_estimation.Size = new Size(108, 15);
            lbl_estimation.TabIndex = 16;
            lbl_estimation.Text = "<estimation_time>";
            // 
            // Transaction_Deposit_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 519);
            Controls.Add(panel1);
            Controls.Add(lbl_estimation);
            Controls.Add(lbl_total);
            Controls.Add(lbl_totalun);
            Controls.Add(btn_add);
            Controls.Add(btn_submit);
            Controls.Add(checkBox1);
            Controls.Add(listBox1);
            Controls.Add(lbl_title);
            Controls.Add(dtViewService);
            Controls.Add(lbl_name);
            Controls.Add(lbl_email);
            Controls.Add(lbl_address);
            Controls.Add(lbl_date);
            Controls.Add(inp_service);
            Controls.Add(inp_customer);
            Controls.Add(inp_unit);
            Controls.Add(address_display);
            Controls.Add(name_display);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(inp_phone_number);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(add_customer);
            Margin = new Padding(5, 3, 5, 3);
            Name = "Transaction_Deposit_Form";
            Text = "Manage Employee";
            Load += Transaction_Deposit_Form_Load;
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(lbl_totalun, 0);
            Controls.SetChildIndex(lbl_estimation, 0);
            Controls.SetChildIndex(lbl_total, 0);
            Controls.SetChildIndex(add_customer, 0);
            Controls.SetChildIndex(btn_add, 0);
            Controls.SetChildIndex(btn_submit, 0);
            Controls.SetChildIndex(checkBox1, 0);
            Controls.SetChildIndex(listBox1, 0);
            Controls.SetChildIndex(lbl_title, 0);
            Controls.SetChildIndex(dtViewService, 0);
            Controls.SetChildIndex(lbl_name, 0);
            Controls.SetChildIndex(lbl_email, 0);
            Controls.SetChildIndex(lbl_address, 0);
            Controls.SetChildIndex(lbl_date, 0);
            Controls.SetChildIndex(inp_service, 0);
            Controls.SetChildIndex(inp_customer, 0);
            Controls.SetChildIndex(inp_unit, 0);
            Controls.SetChildIndex(address_display, 0);
            Controls.SetChildIndex(name_display, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(listBox1, 0);
            Controls.SetChildIndex(inp_phone_number, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label2, 0);
            ((System.ComponentModel.ISupportInitialize)dtViewService).EndInit();
            ((System.ComponentModel.ISupportInitialize)inp_unit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_title;
        private DataGridView dtViewService;
        private TextBox inp_name;
        private Label lbl_name;
        private TextBox inp_email;
        private Label lbl_email;
        private TextBox inp_phone;
        private Label lbl_phone;
        private TextBox inp_address;
        private Label lbl_address;
        private DateTimePicker inp_date;
        private Label lbl_date;
        private ComboBox inp_service;
        private ComboBox inp_customer;

        private ListBox listBox1;

        private NumericUpDown inp_unit;
        private LinkLabel add_customer;
        private Panel panel1;
        private TextBox inp_phone_number;
        private Label label3;
        private Label label2;
        private Label address_display;
        private Label name_display;
        private Label label5;
        private Label label4;
        private Label lbl_totalun;
        private CheckBox checkBox1;
        private Button btn_add;
        private Button btn_submit;
        private TextBox textBox1;
        private Label lbl_total;
        private Label lbl_estimation;
    }
}