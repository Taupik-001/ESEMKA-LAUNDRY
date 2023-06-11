using System;
using System.Collections.Generic;
using System.ComponentModel;
using Test.Service_Program;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Form_Application
{
    public partial class Transaction_Deposit_Form : Base_Form
    {
        private Add_Customer_Form modalDialog; // Declare an instance variable for the modal dialog form
        public Transaction_Deposit_Form()
        {
            InitializeComponent();

        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Toggle the modal dialog
            if (modalDialog == null || modalDialog.IsDisposed)
            {
                modalDialog = new Add_Customer_Form();
                modalDialog.ShowDialog();
            }
            else
            {
                modalDialog.Close();
                modalDialog.Dispose();
                modalDialog = null;
            }
        }

        private void Transaction_Deposit_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
