using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework;
using CrystalDecisions.CrystalReports.Engine;

namespace Cambert.MasterFile
{
    public partial class CustomerList : Form
    {
        private readonly BindingSource _bs = new BindingSource();
        public CustomerList()
        {
            InitializeComponent();
            Utils.SetConnectionDetails();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            display();
        }
        private void display()
        {
            _bs.DataSource = DataSupport.RunDataSet("Select custCode,customer,address,discount1,discount2,discount3,discount4,discount5 from base_customer").Tables[0];
            dataGridView1.DataSource = _bs;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dialog = new MasterFile.addcustomer();
            string code = dataGridView1.Rows[e.RowIndex].Cells[colCustCode.Name].Value.ToString();
            var dt = DataSupport.RunDataSet("Select * from base_customer where custCode = '" + code + "'").Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                dialog.txtcustCode.Text = row["custCode"].ToString();
                dialog.txtcustName.Text = row["customer"].ToString();
                dialog.txtaddress.Text = row["address"].ToString();
                dialog.txtbusiness.Text = row["businessStyle"].ToString();
                dialog.txtcontact.Text = row["contactNo"].ToString();
                dialog.txtpostCode.Text = row["postalCode"].ToString();
                dialog.txttin.Text = row["tinNo"].ToString();
                dialog.txtterms.Text = row["terms"].ToString();
                dialog.txtdisc1.Text = row["discount1"].ToString();
                dialog.txtdisc2.Text = row["discount2"].ToString();
                dialog.txtdisc3.Text = row["discount3"].ToString();
                dialog.txtdisc4.Text = row["discount4"].ToString();
                dialog.txtdisc5.Text = row["discount5"].ToString();
                dialog.txtzone.Text = row["zone"].ToString();
            }
            dialog.txtcustCode.ReadOnly = true;
            addcustomer.mode = "update";
            dialog.ShowDialog();
            display();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            _bs.Filter = "custCode LIKE '%" + txtSearch.Text + "%' or customer LIKE '%" + txtSearch.Text + "%'";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dialog = new MasterFile.addcustomer();
            addcustomer.mode = "";
            dialog.ShowDialog();
            display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.DataTable result = new System.Data.DataTable();
            result.Columns.Add(new DataColumn("custCode", typeof(String)));
            result.Columns.Add(new DataColumn("custName", typeof(String)));
            result.Columns.Add(new DataColumn("addres", typeof(String)));
            
            DataRow resultRow = result.NewRow();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                resultRow = result.NewRow();
                resultRow["custCode"] = row.Cells[colCustCode.Name].Value;
                resultRow["custName"] = row.Cells[colCustName.Name].Value;
                resultRow["addres"] = row.Cells[colAddress.Name].Value;
                result.Rows.Add(resultRow);
            }
            var viewer = new Reports.ReportViewer();
            ReportDocument ReportDocs = new ReportDocument();
            ReportDocs = new Reports.MasterFile.customer();
            ReportDocs.Database.Tables[0].SetDataSource(result);
            viewer.Viewer.ReportSource = ReportDocs;
            viewer.btnDeclare.Visible = false;
            viewer.ShowDialog();
        }
    }
}
