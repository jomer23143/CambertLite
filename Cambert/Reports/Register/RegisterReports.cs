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

namespace Cambert.Reports.Register
{
    public partial class RegisterReports : Form
    {
        public string Mode;
        private string _holder;
        public RegisterReports(String Action)
        {
            InitializeComponent();
            _holder = Action;
        }
        public RegisterReports()
        {
            InitializeComponent();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            if (Mode == "GOOD STOCKS")
            {
                SalesRegister();
            }
            else
            { DeliveryRegister(); }
        }
        private void SalesRegister()
        {
            System.Data.DataTable result = new System.Data.DataTable();
            result.Columns.Add(new DataColumn("SI", typeof(String)));
            result.Columns.Add(new DataColumn("SIdate", typeof(DateTime)));
            result.Columns.Add(new DataColumn("PO", typeof(String)));
            result.Columns.Add(new DataColumn("custName", typeof(String)));
            result.Columns.Add(new DataColumn("Terms", typeof(String)));
            result.Columns.Add(new DataColumn("totalAmount", typeof(Decimal)));
            result.Columns.Add(new DataColumn("type", typeof(String)));
            DataRow resultRow = result.NewRow();
            var dt = DataSupport.RunDataSet("Select * from Global_ProductTrans where typeOfStock ='" + typeS.Text + "' and siDate between '" + from.Text + "' and '" + to.Text + "'").Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                resultRow = result.NewRow();
                resultRow["SI"] = row["siNo"].ToString();
                resultRow["SIdate"] = row["sidate"].ToString();
                resultRow["PO"] = row["poNo"].ToString();
                resultRow["custName"] = row["custName"].ToString();
                resultRow["Terms"] = row["terms"].ToString();
                resultRow["totalAmount"] = row["totalAmount"].ToString();
                resultRow["type"] = row["typeOfStock"].ToString();
                result.Rows.Add(resultRow);
            }
            ReportDocument ReportDocs = new ReportDocument();
            ReportDocs = new Reports.Register.SalesRegister();
            ReportDocs.Database.Tables[0].SetDataSource(result);
            crystalReportViewer1.ReportSource = ReportDocs;
            crystalReportViewer1.Refresh();
        }
        private void DeliveryRegister()
        {
            System.Data.DataTable result = new System.Data.DataTable();
            result.Columns.Add(new DataColumn("dr", typeof(String)));
            result.Columns.Add(new DataColumn("drDate", typeof(DateTime)));
            result.Columns.Add(new DataColumn("poNo", typeof(String)));
            result.Columns.Add(new DataColumn("custname", typeof(String)));
            result.Columns.Add(new DataColumn("terms", typeof(String)));
            result.Columns.Add(new DataColumn("type", typeof(String)));
            DataRow resultRow = result.NewRow();
            var dt = DataSupport.RunDataSet("Select * from Global_drTrans where typeOfStock ='" + typeS.Text + "' and drDate between '" + from.Text + "' and '" + to.Text + "'").Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                resultRow = result.NewRow();
                resultRow["dr"] = row["drNo"].ToString();
                resultRow["drDate"] = row["drDate"].ToString();
                resultRow["poNo"] = row["poNo"].ToString();
                resultRow["custName"] = row["custName"].ToString();
                resultRow["terms"] = row["terms"].ToString();
                resultRow["type"] = row["typeOfStock"].ToString();
                result.Rows.Add(resultRow);
            }
            ReportDocument ReportDocs = new ReportDocument();
            ReportDocs = new Reports.Register.DrRegister();
            ReportDocs.Database.Tables[0].SetDataSource(result);
            crystalReportViewer1.ReportSource = ReportDocs;
            crystalReportViewer1.Refresh();
        }
        private void RegisterReports_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.PrintReport();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
