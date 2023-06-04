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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.inp_search = new System.Windows.Forms.TextBox();
            this.dtViewEmployee = new System.Windows.Forms.DataGridView();
            this.lbl_id = new System.Windows.Forms.Label();
            this.inp_id = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.inp_name = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.inp_email = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.inp_phone = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.inp_address = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.inp_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_combo = new System.Windows.Forms.Label();
            this.inp_combo = new System.Windows.Forms.ComboBox();
            this.lbl_numeric = new System.Windows.Forms.Label();
            this.inp_numeric = new System.Windows.Forms.NumericUpDown();
            this.lbl_password = new System.Windows.Forms.Label();
            this.inp_password = new System.Windows.Forms.TextBox();
            this.lbl_conpassword = new System.Windows.Forms.Label();
            this.inp_conpassword = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.inp_date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(300, 50);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(125, 25);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Manage Employee";
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(560, 75);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(35, 13);
            this.lbl_search.TabIndex = 1;
            this.lbl_search.Text = "Search";
            // 
            // inp_search
            // 
            this.inp_search.Location = new System.Drawing.Point(620, 75);
            this.inp_search.Name = "inp_search";
            this.inp_search.Size = new System.Drawing.Size(100, 20);
            this.inp_search.TabIndex = 2;
            // 
            // dtViewEmployee
            // 
            this.dtViewEmployee.AllowUserToOrderColumns = false;
            this.dtViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; // Set the AutoSizeColumnsMode property
            this.dtViewEmployee.Location = new System.Drawing.Point(150, 100);
            this.dtViewEmployee.Name = "dtViewEmployee";
            this.dtViewEmployee.Size = new System.Drawing.Size(750, 150);
            this.dtViewEmployee.TabIndex = 3;
            this.dtViewEmployee.AutoGenerateColumns = false;
            this.dtViewEmployee.RowHeadersVisible = false;
            this.dtViewEmployee.ReadOnly = true;
            this.dtViewEmployee.AllowUserToResizeColumns = false;
            this.dtViewEmployee.AllowUserToResizeRows = false;
            this.dtViewEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtViewEmployee.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dtViewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtViewEmployee.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            this.dtViewEmployee.CellClick += dtViewEmployee_CellClick;

            //
            // lbl_id
            //
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(150, 250);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(35, 13);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Text = "Employee ID";
            // 
            // inp_id
            // 
            this.inp_id.Location = new System.Drawing.Point(200, 250);
            this.inp_id.Name = "inp_id";
            this.inp_id.Size = new System.Drawing.Size(100, 20);
            this.inp_id.TabIndex = 5;
            //
            // lbl_name
            //
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(150, 275);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Name";
            // 
            // inp_name
            // 
            this.inp_name.Location = new System.Drawing.Point(200, 275);
            this.inp_name.Name = "inp_name";
            this.inp_name.Size = new System.Drawing.Size(100, 20);
            this.inp_name.TabIndex = 7;
            //
            // lbl_email
            //
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(150, 300);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 6;
            this.lbl_email.Text = "Email";
            // 
            // inp_email
            // 
            this.inp_email.Location = new System.Drawing.Point(200, 300);
            this.inp_email.Name = "inp_email";
            this.inp_email.Size = new System.Drawing.Size(100, 20);
            this.inp_email.TabIndex = 6;
            //
            // lbl_phone
            //
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(150, 325);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(35, 13);
            this.lbl_phone.TabIndex = 6;
            this.lbl_phone.Text = "Phone Number";
            // 
            // inp_phone
            // 
            this.inp_phone.Location = new System.Drawing.Point(200, 325);
            this.inp_phone.Name = "inp_phone";
            this.inp_phone.Size = new System.Drawing.Size(100, 20);
            this.inp_phone.TabIndex = 7;
            //
            // lbl_address
            //
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(150, 350);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(35, 13);
            this.lbl_address.TabIndex = 6;
            this.lbl_address.Text = "Address";
            // 
            // inp_address
            // 
            this.inp_address.Location = new System.Drawing.Point(200, 350);
            this.inp_address.Name = "inp_address";
            this.inp_address.Size = new System.Drawing.Size(100, 20);
            this.inp_address.TabIndex = 8;
            //
            // lbl_date
            //
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(150, 375);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(35, 13);
            this.lbl_date.TabIndex = 6;
            this.lbl_date.Text = "Date of Birth";
            // 
            // inp_date
            // 
            this.inp_date.Location = new System.Drawing.Point(200, 375);
            this.inp_date.Name = "inp_date";
            this.inp_date.Size = new System.Drawing.Size(200, 20);
            this.inp_date.TabIndex = 10;
            //
            // lbl_combo
            //
            this.lbl_combo.AutoSize = true;
            this.lbl_combo.Location = new System.Drawing.Point(400, 250);
            this.lbl_combo.Name = "lbl_combo";
            this.lbl_combo.Size = new System.Drawing.Size(35, 13);
            this.lbl_combo.TabIndex = 6;
            this.lbl_combo.Text = "Job Title";
            //
            // inp_combo
            //
            this.inp_combo.FormattingEnabled = true;
            this.inp_combo.Location = new System.Drawing.Point(500, 250);
            this.inp_combo.Name = "inp_combo";
            this.inp_combo.Size = new System.Drawing.Size(121, 21);
            this.inp_combo.TabIndex = 2;
            // 
            // lbl_numeric
            //
            this.lbl_numeric.AutoSize = true;
            this.lbl_numeric.Location = new System.Drawing.Point(400, 275);
            this.lbl_numeric.Name = "lbl_numeric";
            this.lbl_numeric.Size = new System.Drawing.Size(35, 13);
            this.lbl_numeric.TabIndex = 6;
            this.lbl_numeric.Text = "Salary";
            //
            // inp_numeric
            //
            this.inp_numeric.Location = new System.Drawing.Point(500, 275);
            this.inp_numeric.Name = "inp_numeric";
            this.inp_numeric.Size = new System.Drawing.Size(120, 20);
            this.inp_numeric.TabIndex = 0;
            this.inp_numeric.Minimum = 0;
            this.inp_numeric.Maximum = 10000000; 
            //
            // lbl_password
            //
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(400, 300);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(35, 13);
            this.lbl_password.TabIndex = 6;
            this.lbl_password.Text = "Password";
            // 
            // inp_password
            // 
            this.inp_password.Location = new System.Drawing.Point(500, 300);
            this.inp_password.Name = "inp_password";
            this.inp_password.Size = new System.Drawing.Size(100, 20);
            this.inp_password.TabIndex = 8;
            //
            // lbl_conpassword
            //
            this.lbl_conpassword.AutoSize = true;
            this.lbl_conpassword.Location = new System.Drawing.Point(400, 325);
            this.lbl_conpassword.Name = "lbl_conpassword";
            this.lbl_conpassword.Size = new System.Drawing.Size(35, 13);
            this.lbl_conpassword.TabIndex = 6;
            this.lbl_conpassword.Text = "Confirm Password";
            // 
            // inp_conpassword
            // 
            this.inp_conpassword.Location = new System.Drawing.Point(500, 325);
            this.inp_conpassword.Name = "inp_conpassword";
            this.inp_conpassword.Size = new System.Drawing.Size(100, 20);
            this.inp_conpassword.TabIndex = 8;
            //
            // btn_insert
            //
            this.btn_insert.Location = new System.Drawing.Point(400, 350);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 9;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            //
            // btn_update
            //
            this.btn_update.Location = new System.Drawing.Point(475, 350);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            //
            // btn_delete
            //
            this.btn_delete.Location = new System.Drawing.Point(550, 350);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            //
            // btn_save
            //
            this.btn_save.Location = new System.Drawing.Point(450, 375);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            //
            // btn_cancel
            //
            this.btn_cancel.Location = new System.Drawing.Point(525, 375);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Transaction_Deposit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.inp_search);
            this.Controls.Add(this.dtViewEmployee);
            this.Controls.Add(this.inp_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.inp_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.inp_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.inp_phone);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.inp_address);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.inp_date);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.inp_combo);
            this.Controls.Add(this.lbl_combo);
            this.Controls.Add(this.inp_numeric);
            this.Controls.Add(this.lbl_numeric);
            this.Controls.Add(this.inp_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.inp_conpassword);
            this.Controls.Add(this.lbl_conpassword);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Name = "Transaction_Deposit_Form";
            this.Text = "Manage Employee";
            this.Load += new System.EventHandler(this.Manage_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox inp_search;
        private System.Windows.Forms.DataGridView dtViewEmployee;
        private System.Windows.Forms.TextBox inp_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox inp_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox inp_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox inp_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox inp_address;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.DateTimePicker inp_date;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.ComboBox inp_combo;
        private System.Windows.Forms.Label lbl_combo;
        private System.Windows.Forms.NumericUpDown inp_numeric;
        private System.Windows.Forms.Label lbl_numeric;
        private System.Windows.Forms.TextBox inp_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox inp_conpassword;
        private System.Windows.Forms.Label lbl_conpassword;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}