namespace Test.Form_Application
{
    partial class Package_Form
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataViewPackage = new DataGridView();
            search_input = new TextBox();
            packageId = new TextBox();
            serviceCom = new ComboBox();
            totalunitNum = new NumericUpDown();
            priceNum = new NumericUpDown();
            btn_cancel = new Button();
            btn_insert = new Button();
            btn_save = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataViewPackage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalunitNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(397, 78);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 11;
            label1.Text = "Manage Package";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(629, 96);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 12;
            label2.Text = "Search";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 316);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 13;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 350);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 14;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 383);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 15;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(198, 417);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 16;
            label6.Text = "label6";
            // 
            // dataViewPackage
            // 
            dataViewPackage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewPackage.Location = new Point(182, 122);
            dataViewPackage.Name = "dataViewPackage";
            dataViewPackage.RowTemplate.Height = 25;
            dataViewPackage.Size = new Size(606, 185);
            dataViewPackage.TabIndex = 17;
            dataViewPackage.CellContentClick += dataGridView1_CellContentClick;
            // 
            // search_input
            // 
            search_input.Location = new Point(688, 93);
            search_input.Name = "search_input";
            search_input.Size = new Size(100, 23);
            search_input.TabIndex = 18;
            search_input.TextChanged += search_input_TextChanged;
            // 
            // packageId
            // 
            packageId.Location = new Point(277, 313);
            packageId.Name = "packageId";
            packageId.Size = new Size(121, 23);
            packageId.TabIndex = 19;
            packageId.TextAlignChanged += packageId_TextAlignChanged;
            // 
            // serviceCom
            // 
            serviceCom.FormattingEnabled = true;
            serviceCom.Location = new Point(277, 347);
            serviceCom.Name = "serviceCom";
            serviceCom.Size = new Size(121, 23);
            serviceCom.TabIndex = 20;
            // 
            // totalunitNum
            // 
            totalunitNum.DecimalPlaces = 1;
            totalunitNum.Location = new Point(278, 381);
            totalunitNum.Name = "totalunitNum";
            totalunitNum.Size = new Size(120, 23);
            totalunitNum.TabIndex = 21;
            // 
            // priceNum
            // 
            priceNum.Location = new Point(278, 415);
            priceNum.Name = "priceNum";
            priceNum.Size = new Size(120, 23);
            priceNum.TabIndex = 22;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(558, 393);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 23;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            btn_insert.Location = new Point(434, 364);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(75, 23);
            btn_insert.TabIndex = 24;
            btn_insert.Text = "Insert";
            btn_insert.UseVisualStyleBackColor = true;
            btn_insert.Click += button9_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(477, 393);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 25;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(515, 364);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 26;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(596, 364);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 27;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // Package_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_save);
            Controls.Add(btn_insert);
            Controls.Add(btn_cancel);
            Controls.Add(priceNum);
            Controls.Add(totalunitNum);
            Controls.Add(serviceCom);
            Controls.Add(packageId);
            Controls.Add(search_input);
            Controls.Add(dataViewPackage);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Package_Form";
            Text = "Package_Form";
            Load += Package_Form_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(dataViewPackage, 0);
            Controls.SetChildIndex(search_input, 0);
            Controls.SetChildIndex(packageId, 0);
            Controls.SetChildIndex(serviceCom, 0);
            Controls.SetChildIndex(totalunitNum, 0);
            Controls.SetChildIndex(priceNum, 0);
            Controls.SetChildIndex(btn_cancel, 0);
            Controls.SetChildIndex(btn_insert, 0);
            Controls.SetChildIndex(btn_save, 0);
            Controls.SetChildIndex(btn_update, 0);
            Controls.SetChildIndex(btn_delete, 0);
            ((System.ComponentModel.ISupportInitialize)dataViewPackage).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalunitNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataViewPackage;
        private TextBox search_input;
        private TextBox packageId;
        private ComboBox serviceCom;
        private NumericUpDown totalunitNum;
        private NumericUpDown priceNum;
        private Button btn_cancel;
        private Button btn_insert;
        private Button btn_save;
        private Button btn_update;
        private Button btn_delete;
    }
}