namespace Test.Form_Application
{
    partial class Service_Form
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
            dtViewService = new DataGridView();
            lbl_id = new Label();
            inp_id = new TextBox();
            lbl_name = new Label();
            inp_name = new TextBox();
            lbl_unit = new Label();
            inp_unit = new ComboBox();
            lbl_category = new Label();
            inp_category = new ComboBox();
            lbl_price = new Label();
            inp_price = new NumericUpDown();
            lbl_est = new Label();
            inp_est = new NumericUpDown();
            btn_insert = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_save = new Button();
            btn_cancel = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtViewService).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inp_price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inp_est).BeginInit();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_title.Location = new Point(400, 65);
            lbl_title.Margin = new Padding(4, 0, 4, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(155, 25);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Manage Service";
            // 
            // lbl_search
            // 
            lbl_search.AutoSize = true;
            lbl_search.Location = new Point(681, 87);
            lbl_search.Margin = new Padding(4, 0, 4, 0);
            lbl_search.Name = "lbl_search";
            lbl_search.Size = new Size(42, 15);
            lbl_search.TabIndex = 1;
            lbl_search.Text = "Search";
            // 
            // inp_search
            // 
            inp_search.Location = new Point(748, 84);
            inp_search.Margin = new Padding(4, 3, 4, 3);
            inp_search.Name = "inp_search";
            inp_search.Size = new Size(116, 23);
            inp_search.TabIndex = 2;
            inp_search.TextChanged += inp_search_TextChanged;
            inp_search.KeyPress += inp_search_KeyPress;
            // 
            // dtViewService
            // 
            dtViewService.Location = new Point(183, 116);
            dtViewService.Margin = new Padding(4, 3, 4, 3);
            dtViewService.Name = "dtViewService";
            dtViewService.Size = new Size(737, 173);
            dtViewService.TabIndex = 3;
            dtViewService.CellClick += dtViewService_CellClick;
            dtViewService.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(213, 312);
            lbl_id.Margin = new Padding(4, 0, 4, 0);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(58, 15);
            lbl_id.TabIndex = 4;
            lbl_id.Text = "Service ID";
            // 
            // inp_id
            // 
            inp_id.Location = new Point(300, 312);
            inp_id.Margin = new Padding(4, 3, 4, 3);
            inp_id.Name = "inp_id";
            inp_id.Size = new Size(116, 23);
            inp_id.TabIndex = 5;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(213, 341);
            lbl_name.Margin = new Padding(4, 0, 4, 0);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(79, 15);
            lbl_name.TabIndex = 6;
            lbl_name.Text = "Service Name";
            // 
            // inp_name
            // 
            inp_name.Location = new Point(300, 341);
            inp_name.Margin = new Padding(4, 3, 4, 3);
            inp_name.Name = "inp_name";
            inp_name.Size = new Size(116, 23);
            inp_name.TabIndex = 7;
            // 
            // lbl_unit
            // 
            lbl_unit.AutoSize = true;
            lbl_unit.Location = new Point(218, 426);
            lbl_unit.Margin = new Padding(4, 0, 4, 0);
            lbl_unit.Name = "lbl_unit";
            lbl_unit.Size = new Size(29, 15);
            lbl_unit.TabIndex = 6;
            lbl_unit.Text = "Unit";
            // 
            // inp_unit
            // 
            inp_unit.FormattingEnabled = true;
            inp_unit.Location = new Point(300, 423);
            inp_unit.Margin = new Padding(4, 3, 4, 3);
            inp_unit.Name = "inp_unit";
            inp_unit.Size = new Size(140, 23);
            inp_unit.TabIndex = 2;
            // 
            // lbl_category
            // 
            lbl_category.AutoSize = true;
            lbl_category.Location = new Point(213, 387);
            lbl_category.Margin = new Padding(4, 0, 4, 0);
            lbl_category.Name = "lbl_category";
            lbl_category.Size = new Size(55, 15);
            lbl_category.TabIndex = 6;
            lbl_category.Text = "Category";
            // 
            // inp_category
            // 
            inp_category.FormattingEnabled = true;
            inp_category.Location = new Point(300, 384);
            inp_category.Margin = new Padding(4, 3, 4, 3);
            inp_category.Name = "inp_category";
            inp_category.Size = new Size(140, 23);
            inp_category.TabIndex = 2;
            // 
            // lbl_price
            // 
            lbl_price.AutoSize = true;
            lbl_price.Location = new Point(467, 317);
            lbl_price.Margin = new Padding(4, 0, 4, 0);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(33, 15);
            lbl_price.TabIndex = 6;
            lbl_price.Text = "Price";
            // 
            // inp_price
            // 
            inp_price.Location = new Point(583, 317);
            inp_price.Margin = new Padding(4, 3, 4, 3);
            inp_price.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            inp_price.Name = "inp_price";
            inp_price.Size = new Size(140, 23);
            inp_price.TabIndex = 0;
            // 
            // lbl_est
            // 
            lbl_est.AutoSize = true;
            lbl_est.Location = new Point(467, 346);
            lbl_est.Margin = new Padding(4, 0, 4, 0);
            lbl_est.Name = "lbl_est";
            lbl_est.Size = new Size(71, 15);
            lbl_est.TabIndex = 6;
            lbl_est.Text = "Est Duration";
            // 
            // inp_est
            // 
            inp_est.Location = new Point(583, 346);
            inp_est.Margin = new Padding(4, 3, 4, 3);
            inp_est.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            inp_est.Name = "inp_est";
            inp_est.Size = new Size(140, 23);
            inp_est.TabIndex = 0;
            // 
            // btn_insert
            // 
            btn_insert.Location = new Point(467, 404);
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
            btn_update.Location = new Point(554, 404);
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
            btn_delete.Location = new Point(642, 404);
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
            btn_save.Location = new Point(525, 433);
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
            btn_cancel.Location = new Point(612, 433);
            btn_cancel.Margin = new Padding(4, 3, 4, 3);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(88, 27);
            btn_cancel.TabIndex = 9;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(748, 320);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 11;
            label1.Text = "/ Per Unit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(748, 349);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 12;
            label2.Text = "Hour(s)";
            // 
            // Service_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 467);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_title);
            Controls.Add(lbl_search);
            Controls.Add(inp_search);
            Controls.Add(dtViewService);
            Controls.Add(inp_id);
            Controls.Add(lbl_id);
            Controls.Add(inp_name);
            Controls.Add(lbl_name);
            Controls.Add(inp_unit);
            Controls.Add(lbl_unit);
            Controls.Add(inp_category);
            Controls.Add(lbl_category);
            Controls.Add(inp_price);
            Controls.Add(lbl_price);
            Controls.Add(inp_est);
            Controls.Add(lbl_est);
            Controls.Add(btn_insert);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_save);
            Controls.Add(btn_cancel);
            Margin = new Padding(5, 3, 5, 3);
            Name = "Service_Form";
            Text = "Esemka Laundry - Manage Service";
            Load += Manage_Service_Load;
            Controls.SetChildIndex(btn_cancel, 0);
            Controls.SetChildIndex(btn_save, 0);
            Controls.SetChildIndex(btn_delete, 0);
            Controls.SetChildIndex(btn_update, 0);
            Controls.SetChildIndex(btn_insert, 0);
            Controls.SetChildIndex(lbl_est, 0);
            Controls.SetChildIndex(inp_est, 0);
            Controls.SetChildIndex(lbl_price, 0);
            Controls.SetChildIndex(inp_price, 0);
            Controls.SetChildIndex(lbl_category, 0);
            Controls.SetChildIndex(inp_category, 0);
            Controls.SetChildIndex(lbl_unit, 0);
            Controls.SetChildIndex(inp_unit, 0);
            Controls.SetChildIndex(lbl_name, 0);
            Controls.SetChildIndex(inp_name, 0);
            Controls.SetChildIndex(lbl_id, 0);
            Controls.SetChildIndex(inp_id, 0);
            Controls.SetChildIndex(dtViewService, 0);
            Controls.SetChildIndex(inp_search, 0);
            Controls.SetChildIndex(lbl_search, 0);
            Controls.SetChildIndex(lbl_title, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            ((System.ComponentModel.ISupportInitialize)dtViewService).EndInit();
            ((System.ComponentModel.ISupportInitialize)inp_price).EndInit();
            ((System.ComponentModel.ISupportInitialize)inp_est).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_title;
        private Label lbl_search;
        private TextBox inp_search;
        private DataGridView dtViewService;
        private TextBox inp_id;
        private Label lbl_id;
        private TextBox inp_name;
        private Label lbl_name;
        private ComboBox inp_category;
        private Label lbl_category;
        private ComboBox inp_unit;
        private Label lbl_unit;
        private NumericUpDown inp_price;
        private Label lbl_price;
        private NumericUpDown inp_est;
        private Label lbl_est;
        private Button btn_insert;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_save;
        private Button btn_cancel;
        private Label label1;
        private Label label2;
    }
}