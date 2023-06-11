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
    public partial class View_Transaction_Form : Base_Form
    {
        public View_Transaction_Form()
        {
            InitializeComponent();
        }

        private void View_Transaction_Form_Load(object sender, EventArgs e)
        {
            DataTable dtD = Data_Access_Layer.JoinData3("DetailDeposit", "Service", "PrepaidPackage");
            dtDetail.AutoGenerateColumns = false;
            dtDetail.DataSource = dtD;
            //dtDetail.DataSource = dtD;
            dtDetail.Columns.Add("ServiceName", "Service Name");
            dtDetail.Columns.Add("PrepaidId", "Package Id");
            dtDetail.Columns.Add("PriceUnit", "Price Per Unit");
            dtDetail.Columns.Add("TotalUnit", "Total Unit");
            dtDetail.Columns.Add("CompletedDatetime", "Transaction Time");

            //dtDetail.Columns.Add("CompleteEstimationDateTime", "Completed Estimation Time");

            foreach (DataGridViewColumn column in dtDetail.Columns)
            {
                column.DataPropertyName = column.Name;
            }

            DataTable dtHead = Data_Access_Layer.JoinData2("HeaderDeposit", "Customer", "Employee");
            dtHeader.AutoGenerateColumns = false;
            dtHeader.DataSource = dtHead;
            dtHeader.Columns.Add("Id", "Id Package");
            dtHeader.Columns.Add("IdCustomer", "Customer Id");
            dtHeader.Columns.Add("CustomerTitle", "Customer Name");
            dtHeader.Columns.Add("EmployeeTitle", "Employee Name");
            dtHeader.Columns.Add("TransactionDateTime", "Transaction Time");
            dtHeader.Columns.Add("CompleteEstimationDateTime", "Completed Estimation Time");

            foreach (DataGridViewColumn column in dtHeader.Columns)
            {
                column.DataPropertyName = column.Name;
            }
        }
    }
}
