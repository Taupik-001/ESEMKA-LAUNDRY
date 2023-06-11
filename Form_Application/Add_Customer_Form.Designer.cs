namespace Test.Form_Application
{
    partial class Add_Customer_Form
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.inp_name = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.inp_phone = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.inp_address = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(75, 10);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(125, 25);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Add Customer";
            //
            // lbl_name
            //
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(50, 50);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Name";
            // 
            // inp_name
            // 
            this.inp_name.Location = new System.Drawing.Point(125, 50);
            this.inp_name.Name = "inp_name";
            this.inp_name.Size = new System.Drawing.Size(100, 20);
            this.inp_name.TabIndex = 7;
            //
            // lbl_phone
            //
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(50, 75);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(35, 13);
            this.lbl_phone.TabIndex = 6;
            this.lbl_phone.Text = "Phone Number";
            // 
            // inp_phone
            // 
            this.inp_phone.Location = new System.Drawing.Point(125, 75);
            this.inp_phone.Name = "inp_phone";
            this.inp_phone.Size = new System.Drawing.Size(100, 20);
            this.inp_phone.TabIndex = 7;
            //
            // lbl_address
            //
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(50, 100);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(35, 13);
            this.lbl_address.TabIndex = 6;
            this.lbl_address.Text = "Address";
            // 
            // inp_address
            // 
            this.inp_address.Location = new System.Drawing.Point(125, 100);
            this.inp_address.Name = "inp_address";
            this.inp_address.Size = new System.Drawing.Size(100, 20);
            this.inp_address.TabIndex = 8;
            //
            // btn_submit
            //
            this.btn_submit.Location = new System.Drawing.Point(125, 125);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 9;
            this.btn_submit.Text = "Save";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // Add_Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.inp_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.inp_phone);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.inp_address);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.btn_submit);
            this.Name = "Add_Customer_Form";
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox inp_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox inp_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox inp_address;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Button btn_submit;
    }
}