namespace Test
{
    partial class Base_Form
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            flowLayoutPanel2 = new FlowLayoutPanel();
            button1 = new Button();
            display_time = new Label();
            display_username = new Label();
            btn_logout = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(display_time);
            flowLayoutPanel2.Controls.Add(display_username);
            flowLayoutPanel2.Controls.Add(btn_logout);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(933, 58);
            flowLayoutPanel2.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(4, 3);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 27);
            button1.TabIndex = 3;
            button1.Text = "Toggle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // display_time
            // 
            display_time.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            display_time.AutoSize = true;
            display_time.BackColor = SystemColors.ButtonFace;
            display_time.Location = new Point(230, 9);
            display_time.Margin = new Padding(4, 0, 4, 0);
            display_time.Name = "display_time";
            display_time.Size = new Size(47, 15);
            display_time.TabIndex = 1;
            display_time.Text = "<time>";
            display_time.TextAlign = ContentAlignment.MiddleCenter;
            display_time.Click += display_time_Click;
            // 
            // display_username
            // 
            display_username.Anchor = AnchorStyles.Right;
            display_username.AutoSize = true;
            display_username.BackColor = SystemColors.ButtonFace;
            display_username.Location = new Point(285, 9);
            display_username.Margin = new Padding(4, 0, 4, 0);
            display_username.Name = "display_username";
            display_username.Size = new Size(75, 15);
            display_username.TabIndex = 0;
            display_username.Text = "<username>";
            // 
            // btn_logout
            // 
            btn_logout.Anchor = AnchorStyles.Right;
            btn_logout.Location = new Point(368, 3);
            btn_logout.Margin = new Padding(4, 3, 4, 3);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(88, 27);
            btn_logout.TabIndex = 2;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.Location = new Point(4, 178);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(122, 29);
            button7.TabIndex = 5;
            button7.Text = "View Transaction";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.Location = new Point(4, 143);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(121, 29);
            button6.TabIndex = 4;
            button6.Text = "Prepaid Package";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.Location = new Point(4, 108);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(140, 29);
            button5.TabIndex = 3;
            button5.Text = "Transaction Deposit";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Location = new Point(4, 73);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(125, 29);
            button4.TabIndex = 2;
            button4.Text = "Manage Package";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Location = new Point(4, 38);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(117, 29);
            button3.TabIndex = 1;
            button3.Text = "Manage Service";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(4, 3);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(134, 29);
            button2.TabIndex = 0;
            button2.Text = "Manage Employee";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 58);
            flowLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(175, 461);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(99, 6);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 4;
            label1.Text = "Esemka Laundry";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Base_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Base_Form";
            Text = "Main Menu";
            Load += Base_Form_Load;
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private Label display_time;
        private Label display_username;
        private Button btn_logout;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
    }
}