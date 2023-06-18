using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Prepaid_Package_Form : Base_Form
    {
        private Add_Customer_Form? modalDialog;
        public Prepaid_Package_Form()
        {
            InitializeComponent();
        }

        private void link_add_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
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

        private void btn_submit_Click(object sender, EventArgs e)
        {

        }

        private void dtViewPrepaidPackage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Prepaid_Package_Form_Load(object sender, EventArgs e)
        {
            DataTable? dt = new DataTable();
            dtViewPrepaidPackage.AutoGenerateColumns = false;
            dtViewPrepaidPackage.DataSource = dt;

            dtViewPrepaidPackage.Columns.Add("Id", "Id Package");
            dtViewPrepaidPackage.Columns.Add("CustomerTitle", "Customer Name");
            dtViewPrepaidPackage.Columns.Add("PackageTitle", "Package Name");
            dtViewPrepaidPackage.Columns.Add("Price", "Price");

            foreach (DataGridViewColumn column in dtViewPrepaidPackage.Columns)
            {
                column.DataPropertyName = column.Name;
            }
        }
    }
}
