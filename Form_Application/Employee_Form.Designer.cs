namespace Test.Form_Application
{
    partial class Employee_Form
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
            lbl_search = new Label();
            inp_search = new TextBox();
            dtViewEmployee = new DataGridView();
            lbl_id = new Label();
            inp_id = new TextBox();
            lbl_name = new Label();
            inp_name = new TextBox();
            lbl_email = new Label();
            inp_email = new TextBox();
            lbl_phone = new Label();
            inp_phone = new TextBox();
            lbl_address = new Label();
            inp_address = new TextBox();
            lbl_date = new Label();
            inp_date = new DateTimePicker();
            lbl_combo = new Label();
            inp_combo = new ComboBox();
            lbl_numeric = new Label();
            inp_numeric = new NumericUpDown();
            lbl_password = new Label();
            inp_password = new TextBox();
            lbl_conpassword = new Label();
            inp_conpassword = new TextBox();
            btn_insert = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_save = new Button();
            btn_cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dtViewEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inp_numeric).BeginInit();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_title.Location = new Point(348, 61);
            lbl_title.Margin = new Padding(4, 0, 4, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(176, 25);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Manage Employee";
            // 
            // lbl_search
            // 
            lbl_search.AutoSize = true;
            lbl_search.Location = new Point(642, 92);
            lbl_search.Margin = new Padding(4, 0, 4, 0);
            lbl_search.Name = "lbl_search";
            lbl_search.Size = new Size(42, 15);
            lbl_search.TabIndex = 1;
            lbl_search.Text = "Search";
            // 
            // inp_search
            // 
            inp_search.Location = new Point(705, 84);
            inp_search.Margin = new Padding(4, 3, 4, 3);
            inp_search.Name = "inp_search";
            inp_search.Size = new Size(116, 23);
            inp_search.TabIndex = 2;
            inp_search.TextChanged += inp_search_TextChanged;
            inp_search.KeyPress += inp_search_KeyPress;
            // 
            // dtViewEmployee
            // 
            dtViewEmployee.Location = new Point(183, 116);
            dtViewEmployee.Margin = new Padding(4, 3, 4, 3);
            dtViewEmployee.Name = "dtViewEmployee";
            dtViewEmployee.Size = new Size(638, 172);
            dtViewEmployee.TabIndex = 3;


            dtViewEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtViewEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtViewEmployee.RowHeadersVisible = false;
            dtViewEmployee.AllowUserToAddRows = false;
            // Set the height of the header row
            dtViewEmployee.ColumnHeadersHeight = 50; // Set the desired height in pixels

            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(183, 299);
            lbl_id.Margin = new Padding(4, 0, 4, 0);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(73, 15);
            lbl_id.TabIndex = 4;
            lbl_id.Text = "Employee ID";
            // 
            // inp_id
            // 
            inp_id.Location = new Point(279, 296);
            inp_id.Margin = new Padding(4, 3, 4, 3);
            inp_id.Name = "inp_id";
            inp_id.Size = new Size(116, 23);
            inp_id.TabIndex = 5;
            inp_id.TextChanged += inp_id_TextChanged;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(183, 327);
            lbl_name.Margin = new Padding(4, 0, 4, 0);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(39, 15);
            lbl_name.TabIndex = 6;
            lbl_name.Text = "Name";
            // 
            // inp_name
            // 
            inp_name.Location = new Point(279, 322);
            inp_name.Margin = new Padding(4, 3, 4, 3);
            inp_name.Name = "inp_name";
            inp_name.Size = new Size(116, 23);
            inp_name.TabIndex = 7;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(183, 354);
            lbl_email.Margin = new Padding(4, 0, 4, 0);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(36, 15);
            lbl_email.TabIndex = 6;
            lbl_email.Text = "Email";
            // 
            // inp_email
            // 
            inp_email.Location = new Point(279, 351);
            inp_email.Margin = new Padding(4, 3, 4, 3);
            inp_email.Name = "inp_email";
            inp_email.Size = new Size(116, 23);
            inp_email.TabIndex = 6;
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Location = new Point(183, 383);
            lbl_phone.Margin = new Padding(4, 0, 4, 0);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(88, 15);
            lbl_phone.TabIndex = 6;
            lbl_phone.Text = "Phone Number";
            // 
            // inp_phone
            // 
            inp_phone.Location = new Point(279, 380);
            inp_phone.Margin = new Padding(4, 3, 4, 3);
            inp_phone.Name = "inp_phone";
            inp_phone.Size = new Size(116, 23);
            inp_phone.TabIndex = 7;
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(183, 412);
            lbl_address.Margin = new Padding(4, 0, 4, 0);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(49, 15);
            lbl_address.TabIndex = 6;
            lbl_address.Text = "Address";
            // 
            // inp_address
            // 
            inp_address.Location = new Point(279, 409);
            inp_address.Margin = new Padding(4, 3, 4, 3);
            inp_address.Name = "inp_address";
            inp_address.Size = new Size(116, 23);
            inp_address.TabIndex = 8;
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Location = new Point(183, 447);
            lbl_date.Margin = new Padding(4, 0, 4, 0);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(73, 15);
            lbl_date.TabIndex = 6;
            lbl_date.Text = "Date of Birth";
            // 
            // inp_date
            // 
            inp_date.Location = new Point(267, 442);
            inp_date.Margin = new Padding(4, 3, 4, 3);
            inp_date.Name = "inp_date";
            inp_date.Size = new Size(233, 23);
            inp_date.TabIndex = 10;
            // 
            // lbl_combo
            // 
            lbl_combo.AutoSize = true;
            lbl_combo.Location = new Point(467, 296);
            lbl_combo.Margin = new Padding(4, 0, 4, 0);
            lbl_combo.Name = "lbl_combo";
            lbl_combo.Size = new Size(50, 15);
            lbl_combo.TabIndex = 6;
            lbl_combo.Text = "Job Title";
            // 
            // inp_combo
            // 
            inp_combo.FormattingEnabled = true;
            inp_combo.Location = new Point(583, 296);
            inp_combo.Margin = new Padding(4, 3, 4, 3);
            inp_combo.Name = "inp_combo";
            inp_combo.Size = new Size(140, 23);
            inp_combo.TabIndex = 2;
            // 
            // lbl_numeric
            // 
            lbl_numeric.AutoSize = true;
            lbl_numeric.Location = new Point(467, 325);
            lbl_numeric.Margin = new Padding(4, 0, 4, 0);
            lbl_numeric.Name = "lbl_numeric";
            lbl_numeric.Size = new Size(38, 15);
            lbl_numeric.TabIndex = 6;
            lbl_numeric.Text = "Salary";
            // 
            // inp_numeric
            // 
            inp_numeric.Location = new Point(584, 325);
            inp_numeric.Margin = new Padding(4, 3, 4, 3);
            inp_numeric.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            inp_numeric.Name = "inp_numeric";
            inp_numeric.Size = new Size(140, 23);
            inp_numeric.TabIndex = 0;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(467, 354);
            lbl_password.Margin = new Padding(4, 0, 4, 0);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(57, 15);
            lbl_password.TabIndex = 6;
            lbl_password.Text = "Password";
            // 
            // inp_password
            // 
            inp_password.Location = new Point(584, 351);
            inp_password.Margin = new Padding(4, 3, 4, 3);
            inp_password.Name = "inp_password";
            inp_password.Size = new Size(116, 23);
            inp_password.TabIndex = 8;
            // 
            // lbl_conpassword
            // 
            lbl_conpassword.AutoSize = true;
            lbl_conpassword.Location = new Point(467, 383);
            lbl_conpassword.Margin = new Padding(4, 0, 4, 0);
            lbl_conpassword.Name = "lbl_conpassword";
            lbl_conpassword.Size = new Size(104, 15);
            lbl_conpassword.TabIndex = 6;
            lbl_conpassword.Text = "Confirm Password";
            // 
            // inp_conpassword
            // 
            inp_conpassword.Location = new Point(584, 383);
            inp_conpassword.Margin = new Padding(4, 3, 4, 3);
            inp_conpassword.Name = "inp_conpassword";
            inp_conpassword.Size = new Size(116, 23);
            inp_conpassword.TabIndex = 8;
            // 
            // btn_insert
            // 
            btn_insert.Location = new Point(467, 409);
            btn_insert.Margin = new Padding(4, 3, 4, 3);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(88, 27);
            btn_insert.TabIndex = 9;
            btn_insert.Text = "Insert";
            btn_insert.UseVisualStyleBackColor = true;
            btn_insert.Click += btn_insert_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(563, 409);
            btn_update.Margin = new Padding(4, 3, 4, 3);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(88, 27);
            btn_update.TabIndex = 9;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(659, 409);
            btn_delete.Margin = new Padding(4, 3, 4, 3);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(88, 27);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(516, 442);
            btn_save.Margin = new Padding(4, 3, 4, 3);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(88, 27);
            btn_save.TabIndex = 9;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(612, 442);
            btn_cancel.Margin = new Padding(4, 3, 4, 3);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(88, 27);
            btn_cancel.TabIndex = 9;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // Employee_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 483);
            Controls.Add(lbl_title);
            Controls.Add(lbl_search);
            Controls.Add(inp_search);
            Controls.Add(dtViewEmployee);
            Controls.Add(inp_id);
            Controls.Add(lbl_id);
            Controls.Add(inp_name);
            Controls.Add(lbl_name);
            Controls.Add(inp_email);
            Controls.Add(lbl_email);
            Controls.Add(inp_phone);
            Controls.Add(lbl_phone);
            Controls.Add(inp_address);
            Controls.Add(lbl_address);
            Controls.Add(inp_date);
            Controls.Add(lbl_date);
            Controls.Add(inp_combo);
            Controls.Add(lbl_combo);
            Controls.Add(inp_numeric);
            Controls.Add(lbl_numeric);
            Controls.Add(inp_password);
            Controls.Add(lbl_password);
            Controls.Add(inp_conpassword);
            Controls.Add(lbl_conpassword);
            Controls.Add(btn_insert);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_save);
            Controls.Add(btn_cancel);
            Margin = new Padding(5, 3, 5, 3);
            Name = "Employee_Form";
            Text = "Manage Employee";
            Load += Manage_Employee_Load;
            Controls.SetChildIndex(btn_cancel, 0);
            Controls.SetChildIndex(btn_save, 0);
            Controls.SetChildIndex(btn_delete, 0);
            Controls.SetChildIndex(btn_update, 0);
            Controls.SetChildIndex(btn_insert, 0);
            Controls.SetChildIndex(lbl_conpassword, 0);
            Controls.SetChildIndex(inp_conpassword, 0);
            Controls.SetChildIndex(lbl_password, 0);
            Controls.SetChildIndex(inp_password, 0);
            Controls.SetChildIndex(lbl_numeric, 0);
            Controls.SetChildIndex(inp_numeric, 0);
            Controls.SetChildIndex(lbl_combo, 0);
            Controls.SetChildIndex(inp_combo, 0);
            Controls.SetChildIndex(lbl_date, 0);
            Controls.SetChildIndex(inp_date, 0);
            Controls.SetChildIndex(lbl_address, 0);
            Controls.SetChildIndex(inp_address, 0);
            Controls.SetChildIndex(lbl_phone, 0);
            Controls.SetChildIndex(inp_phone, 0);
            Controls.SetChildIndex(lbl_email, 0);
            Controls.SetChildIndex(inp_email, 0);
            Controls.SetChildIndex(lbl_name, 0);
            Controls.SetChildIndex(inp_name, 0);
            Controls.SetChildIndex(lbl_id, 0);
            Controls.SetChildIndex(inp_id, 0);
            Controls.SetChildIndex(dtViewEmployee, 0);
            Controls.SetChildIndex(inp_search, 0);
            Controls.SetChildIndex(lbl_search, 0);
            Controls.SetChildIndex(lbl_title, 0);
            ((System.ComponentModel.ISupportInitialize)dtViewEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)inp_numeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_title;
        private Label lbl_search;
        private TextBox inp_search;
        private DataGridView dtViewEmployee;
        private TextBox inp_id;
        private Label lbl_id;
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
        private ComboBox inp_combo;
        private Label lbl_combo;
        private NumericUpDown inp_numeric;
        private Label lbl_numeric;
        private TextBox inp_password;
        private Label lbl_password;
        private TextBox inp_conpassword;
        private Label lbl_conpassword;
        private Button btn_insert;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_save;
        private Button btn_cancel;
    }
}