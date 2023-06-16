namespace Test.Form_Application
{
    partial class View_Transaction_Form
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
            dtHeader = new DataGridView();
            dtDetail = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            btnView = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dtHeader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtDetail).BeginInit();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_title.Location = new Point(452, 75);
            lbl_title.Margin = new Padding(4, 0, 4, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(130, 20);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "View Transaction";
            // 
            // lbl_search
            // 
            lbl_search.AutoSize = true;
            lbl_search.Location = new Point(673, 95);
            lbl_search.Margin = new Padding(4, 0, 4, 0);
            lbl_search.Name = "lbl_search";
            lbl_search.Size = new Size(42, 15);
            lbl_search.TabIndex = 1;
            lbl_search.Text = "Search";
            // 
            // inp_search
            // 
            inp_search.Location = new Point(723, 87);
            inp_search.Margin = new Padding(4, 3, 4, 3);
            inp_search.Name = "inp_search";
            inp_search.Size = new Size(116, 23);
            inp_search.TabIndex = 2;
            // 
            // dtHeader
            // 
            dtHeader.AllowUserToResizeColumns = false;
            dtHeader.AllowUserToResizeRows = false;
            dtHeader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtHeader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtHeader.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtHeader.Location = new Point(213, 116);
            dtHeader.Margin = new Padding(4, 3, 4, 3);
            dtHeader.Name = "dtHeader";
            dtHeader.ReadOnly = true;
            dtHeader.RowHeadersVisible = false;
            dtHeader.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtHeader.Size = new Size(648, 187);
            dtHeader.TabIndex = 3;
            // // 
            // // dtDetail
            // // 
            // dtDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // dtDetail.Columns.AddRange(new DataGridViewColumn[] { btnView });
            // dtDetail.Location = new Point(213, 331);
            // dtDetail.Name = "dtDetail";
            // dtDetail.RowTemplate.Height = 25;
            // dtDetail.Size = new Size(648, 176);
            // dtDetail.TabIndex = 11;
            // // 
            // // btnView
            // // 
            // btnView.HeaderText = "Action";
            // btnView.Name = "btnView";
            // Create a button column
            // DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            // Create a button column
            // DataGridViewButtonColumn btnView = new DataGridViewButtonColumn();
            //             btnView.HeaderText = "Action";
            //             btnView.Text = "Click Me";
            //             btnView.UseColumnTextForButtonValue = true;

            //             // Insert the button column at the last column position
            //             dtDetail.Columns.Insert(dtDetail.Columns.Count, btnView);

            //             // Adjust the size and position of the DataGridView
            //             dtDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //             dtDetail.Location = new Point(213, 331);
            //             dtDetail.Name = "dtDetail";
            //             dtDetail.RowTemplate.Height = 25;
            //             dtDetail.Size = new Size(648, 176);
            //             dtDetail.TabIndex = 11;
            //             // Create the button column
            // DataGridViewButtonColumn btnView = new DataGridViewButtonColumn();
            btnView.HeaderText = "Action";
            btnView.Text = "Click Me";
            btnView.UseColumnTextForButtonValue = true;

            // Insert the button column at the last column position
            

            // Adjust the size and position of the DataGridView
            dtDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtDetail.Location = new Point(213, 331);
            dtDetail.Name = "dtDetail";
            dtDetail.RowTemplate.Height = 25;
            dtDetail.Size = new Size(648, 176);
            dtDetail.TabIndex = 11;
            dtDetail.CellContentClick += dtDetail_CellContentClick;

            



            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 98);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 12;
            label2.Text = "Header Deposit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 313);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 13;
            label3.Text = "Detail Deposit";
            // 
            // View_Transaction_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 519);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtDetail);
            Controls.Add(lbl_title);
            Controls.Add(lbl_search);
            Controls.Add(inp_search);
            Controls.Add(dtHeader);
            Margin = new Padding(5, 3, 5, 3);
            Name = "View_Transaction_Form";
            Text = "Manage Employee";
            Load += View_Transaction_Form_Load;
            Controls.SetChildIndex(dtHeader, 0);
            Controls.SetChildIndex(inp_search, 0);
            Controls.SetChildIndex(lbl_search, 0);
            Controls.SetChildIndex(lbl_title, 0);
            Controls.SetChildIndex(dtDetail, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            ((System.ComponentModel.ISupportInitialize)dtHeader).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_title;
        private Label lbl_search;
        private TextBox inp_search;
        private DataGridView dtHeader;
        private DataGridView dtDetail;
        private Label label2;
        private Label label3;
        private DataGridViewButtonColumn btnView;
    }
}