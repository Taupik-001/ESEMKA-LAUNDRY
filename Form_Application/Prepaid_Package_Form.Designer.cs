namespace Test.Form_Application
{
    partial class Prepaid_Package_Form
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
            dtViewPrepaidPackage = new DataGridView();
            lbl_id = new Label();
            inp_id = new TextBox();
            lbl_name = new Label();
            lbl_email = new Label();
            lbl_phone = new Label();
            lbl_date = new Label();
            lbl_combo = new Label();
            inp_combo = new ComboBox();
            display_name = new Label();
            inp_numeric = new NumericUpDown();
            display_address = new Label();
            lbl_conpassword = new Label();
            btn_submit = new Button();
            inp_phone = new TextBox();
            link_add = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dtViewPrepaidPackage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inp_numeric).BeginInit();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_title.Location = new Point(411, 75);
            lbl_title.Margin = new Padding(4, 0, 4, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(216, 20);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Transaction Prepaid Package";
            // 
            // lbl_search
            // 
            lbl_search.AutoSize = true;
            lbl_search.Location = new Point(697, 91);
            lbl_search.Margin = new Padding(4, 0, 4, 0);
            lbl_search.Name = "lbl_search";
            lbl_search.Size = new Size(42, 15);
            lbl_search.TabIndex = 1;
            lbl_search.Text = "Search";
            // 
            // inp_search
            // 
            inp_search.Location = new Point(747, 83);
            inp_search.Margin = new Padding(4, 3, 4, 3);
            inp_search.Name = "inp_search";
            inp_search.Size = new Size(116, 23);
            inp_search.TabIndex = 2;
            // 
            // dtViewPrepaidPackage
            // 
            dtViewPrepaidPackage.AllowUserToResizeColumns = false;
            dtViewPrepaidPackage.AllowUserToResizeRows = false;
            dtViewPrepaidPackage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtViewPrepaidPackage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtViewPrepaidPackage.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtViewPrepaidPackage.Location = new Point(213, 112);
            dtViewPrepaidPackage.Margin = new Padding(4, 3, 4, 3);
            dtViewPrepaidPackage.Name = "dtViewPrepaidPackage";
            dtViewPrepaidPackage.ReadOnly = true;
            dtViewPrepaidPackage.RowHeadersVisible = false;
            dtViewPrepaidPackage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtViewPrepaidPackage.Size = new Size(650, 173);
            dtViewPrepaidPackage.TabIndex = 3;
            dtViewPrepaidPackage.CellContentClick += dtViewPrepaidPackage_CellContentClick;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(230, 322);
            lbl_id.Margin = new Padding(4, 0, 4, 0);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(107, 15);
            lbl_id.TabIndex = 4;
            lbl_id.Text = "Prepaid Package Id";
            // 
            // inp_id
            // 
            inp_id.Location = new Point(342, 319);
            inp_id.Margin = new Padding(4, 3, 4, 3);
            inp_id.Name = "inp_id";
            inp_id.Size = new Size(116, 23);
            inp_id.TabIndex = 5;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(230, 366);
            lbl_name.Margin = new Padding(4, 0, 4, 0);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(51, 15);
            lbl_name.TabIndex = 6;
            lbl_name.Text = "Package";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(230, 409);
            lbl_email.Margin = new Padding(4, 0, 4, 0);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(33, 15);
            lbl_email.TabIndex = 6;
            lbl_email.Text = "Price";
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Location = new Point(499, 327);
            lbl_phone.Margin = new Padding(4, 0, 4, 0);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(88, 15);
            lbl_phone.TabIndex = 6;
            lbl_phone.Text = "Phone Number";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Location = new Point(514, 409);
            lbl_date.Margin = new Padding(4, 0, 4, 0);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(49, 15);
            lbl_date.TabIndex = 6;
            lbl_date.Text = "Address";
            // 
            // lbl_combo
            // 
            lbl_combo.AutoSize = true;
            lbl_combo.Location = new Point(499, 288);
            lbl_combo.Margin = new Padding(4, 0, 4, 0);
            lbl_combo.Name = "lbl_combo";
            lbl_combo.Size = new Size(59, 15);
            lbl_combo.TabIndex = 6;
            lbl_combo.Text = "Customer";
            // 
            // inp_combo
            // 
            inp_combo.FormattingEnabled = true;
            inp_combo.Location = new Point(342, 363);
            inp_combo.Margin = new Padding(4, 3, 4, 3);
            inp_combo.Name = "inp_combo";
            inp_combo.Size = new Size(140, 23);
            inp_combo.TabIndex = 2;
            // 
            // display_name
            // 
            display_name.AutoSize = true;
            display_name.Location = new Point(599, 379);
            display_name.Margin = new Padding(4, 0, 4, 0);
            display_name.Name = "display_name";
            display_name.Size = new Size(47, 15);
            display_name.TabIndex = 6;
            display_name.Text = "[Name]";
            // 
            // inp_numeric
            // 
            inp_numeric.Location = new Point(342, 407);
            inp_numeric.Margin = new Padding(4, 3, 4, 3);
            inp_numeric.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            inp_numeric.Name = "inp_numeric";
            inp_numeric.Size = new Size(140, 23);
            inp_numeric.TabIndex = 0;
            // 
            // display_address
            // 
            display_address.AutoSize = true;
            display_address.Location = new Point(599, 409);
            display_address.Margin = new Padding(4, 0, 4, 0);
            display_address.Name = "display_address";
            display_address.Size = new Size(57, 15);
            display_address.TabIndex = 6;
            display_address.Text = "[Address]";
            // 
            // lbl_conpassword
            // 
            lbl_conpassword.AutoSize = true;
            lbl_conpassword.Location = new Point(524, 379);
            lbl_conpassword.Margin = new Padding(4, 0, 4, 0);
            lbl_conpassword.Name = "lbl_conpassword";
            lbl_conpassword.Size = new Size(39, 15);
            lbl_conpassword.TabIndex = 6;
            lbl_conpassword.Text = "Name";
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(370, 439);
            btn_submit.Margin = new Padding(4, 3, 4, 3);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(88, 27);
            btn_submit.TabIndex = 9;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // inp_phone
            // 
            inp_phone.Location = new Point(602, 319);
            inp_phone.Margin = new Padding(4, 3, 4, 3);
            inp_phone.Name = "inp_phone";
            inp_phone.Size = new Size(116, 23);
            inp_phone.TabIndex = 8;
            // 
            // link_add
            // 
            link_add.AutoSize = true;
            link_add.Location = new Point(602, 345);
            link_add.Name = "link_add";
            link_add.Size = new Size(132, 15);
            link_add.TabIndex = 11;
            link_add.TabStop = true;
            link_add.Text = "Not Found? Add New +";
            link_add.LinkClicked += link_add_LinkClicked;
            // 
            // Prepaid_Package_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 483);
            Controls.Add(link_add);
            Controls.Add(lbl_title);
            Controls.Add(lbl_search);
            Controls.Add(inp_search);
            Controls.Add(dtViewPrepaidPackage);
            Controls.Add(inp_id);
            Controls.Add(lbl_id);
            Controls.Add(lbl_name);
            Controls.Add(lbl_email);
            Controls.Add(lbl_phone);
            Controls.Add(inp_phone);
            Controls.Add(lbl_date);
            Controls.Add(inp_combo);
            Controls.Add(lbl_combo);
            Controls.Add(inp_numeric);
            Controls.Add(display_name);
            Controls.Add(display_address);
            Controls.Add(lbl_conpassword);
            Controls.Add(btn_submit);
            Margin = new Padding(5, 3, 5, 3);
            Name = "Prepaid_Package_Form";
            Text = "Manage Employee";
            Load += Prepaid_Package_Form_Load;
            Controls.SetChildIndex(btn_submit, 0);
            Controls.SetChildIndex(lbl_conpassword, 0);
            Controls.SetChildIndex(display_address, 0);
            Controls.SetChildIndex(display_name, 0);
            Controls.SetChildIndex(inp_numeric, 0);
            Controls.SetChildIndex(lbl_combo, 0);
            Controls.SetChildIndex(inp_combo, 0);
            Controls.SetChildIndex(lbl_date, 0);
            Controls.SetChildIndex(inp_phone, 0);
            Controls.SetChildIndex(lbl_phone, 0);
            Controls.SetChildIndex(lbl_email, 0);
            Controls.SetChildIndex(lbl_name, 0);
            Controls.SetChildIndex(lbl_id, 0);
            Controls.SetChildIndex(inp_id, 0);
            Controls.SetChildIndex(dtViewPrepaidPackage, 0);
            Controls.SetChildIndex(inp_search, 0);
            Controls.SetChildIndex(lbl_search, 0);
            Controls.SetChildIndex(lbl_title, 0);
            Controls.SetChildIndex(link_add, 0);
            ((System.ComponentModel.ISupportInitialize)dtViewPrepaidPackage).EndInit();
            ((System.ComponentModel.ISupportInitialize)inp_numeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_title;
        private Label lbl_search;
        private TextBox inp_search;
        private DataGridView dtViewPrepaidPackage;
        private TextBox inp_id;
        private Label lbl_id;
        private Label lbl_name;
        private Label lbl_email;
        private Label lbl_phone;
        private Label lbl_address;
        private Label lbl_date;
        private ComboBox inp_combo;
        private Label lbl_combo;
        private NumericUpDown inp_numeric;
        private Label display_name;
        private Label display_address;
        private Label lbl_conpassword;
        private Button btn_submit;
        private TextBox inp_phone;
        private LinkLabel link_add;
    }
}