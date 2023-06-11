using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Service_Program;

namespace Test.Form_Application
{
    public partial class Package_Form : Base_Form
    {
        public Package_Form()
        {
            InitializeComponent();
        }
        void enableField(bool enab, bool noten)
        {
            packageId.Enabled = enab;
            serviceCom.Enabled = enab;
            totalunitNum.Enabled = enab;
            priceNum.Enabled = enab;

            btn_insert.Enabled = enab;
            btn_delete.Enabled = enab;
            btn_update.Enabled = enab;
        }
        void ClearField()
        {
            packageId.Clear();
            serviceCom.SelectedIndex = 0;
            totalunitNum.Value = totalunitNum.Minimum;
            priceNum.Value = priceNum.Minimum;

        }
        private void Package_Form_Load(object sender, EventArgs e)
        {
            DataTable dt = Data_Access_Layer.JoinData1("Package", "Service");
            dataViewPackage.AutoGenerateColumns = false;
            dataViewPackage.DataSource = dt;

            dataViewPackage.Columns.Add("Id", "Package Id");
            dataViewPackage.Columns.Add("ServiceTitle", "Service Name");
            dataViewPackage.Columns.Add("TotalUnit", "Total Unit");
            dataViewPackage.Columns.Add("Price", "Price");
            //dtViewEmployee.Rows.RemoveAt(dtViewEmployee.Rows.Count - 1);

            foreach (DataGridViewColumn column in dataViewPackage.Columns)
            {
                column.DataPropertyName = column.Name;
            }
        }

        private void search_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void packageId_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
