namespace Test
{
    partial class Main_Form
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Info;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(0, 58);
            label1.Name = "label1";
            label1.Size = new Size(933, 461);
            label1.TabIndex = 12;
            label1.Text = "Welcome";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(933, 519);
            Controls.Add(label1);
            Name = "Main_Form";
            Load += Main_Form_Load;
            Controls.SetChildIndex(label1, 0);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}