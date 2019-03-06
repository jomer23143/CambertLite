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

namespace Cambert.Reports.Extracopy
{
    public partial class EXTRASALES : Form
    {
        public EXTRASALES()
        {
            InitializeComponent();
        }

        private void btnDeclare_Click(object sender, EventArgs e)
        {
            System.Data.DataTable result = new System.Data.DataTable();
            result.Columns.Add(new DataColumn("SI", typeof(String)));
            result.Columns.Add(new DataColumn("SIdate", typeof(DateTime)));
            result.Columns.Add(new DataColumn("PO", typeof(String)));
            result.Columns.Add(new DataColumn("custName", typeof(String)));
            result.Columns.Add(new DataColumn("address", typeof(String)));
            result.Columns.Add(new DataColumn("business", typeof(String)));
            result.Columns.Add(new DataColumn("Tin", typeof(String)));
            result.Columns.Add(new DataColumn("Terms", typeof(String)));
            result.Columns.Add(new DataColumn("productCode", typeof(String)));
            result.Columns.Add(new DataColumn("description", typeof(String)));
            result.Columns.Add(new DataColumn("qty", typeof(int)));
            result.Columns.Add(new DataColumn("unit", typeof(String)));
            result.Columns.Add(new DataColumn("price", typeof(Decimal)));
            result.Columns.Add(new DataColumn("dics", typeof(int)));
            result.Columns.Add(new DataColumn("amount", typeof(Decimal)));
            result.Columns.Add(new DataColumn("totalAmount", typeof(Decimal)));
            result.Columns.Add(new DataColumn("vat", typeof(Decimal)));
            result.Columns.Add(new DataColumn("discount", typeof(Decimal)));
            result.Columns.Add(new DataColumn("amountDue", typeof(Decimal)));
            DataRow resultRow = result.NewRow();
            var dt = DataSupport.RunDataSet("SELECT * FROM Global_ProductTrans  p join Global_ProductTransDetails d on p.outgoing_Id = d.outgoing_Id join base_customer c on p.custCode = c.custCode where p.siNo = '" + txtsI.Text + "'").Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                resultRow = result.NewRow();
                resultRow["SI"] = row["siNo"].ToString();
                resultRow["SIdate"] = row["sidate"].ToString();
                resultRow["PO"] = row["poNo"].ToString();
                resultRow["custName"] = row["custName"].ToString();
                resultRow["address"] = row["address"].ToString();
                resultRow["business"] = row["BusinessStyle"].ToString();
                resultRow["Tin"] = row["tinNo"].ToString();
                resultRow["Terms"] = row["terms"].ToString();
                resultRow["productCode"] = row["product_code"].ToString();
                resultRow["description"] = row["description"].ToString();
                resultRow["qty"] = row["qty"].ToString();
                resultRow["unit"] = row["uom"].ToString();
                resultRow["price"] = row["price"].ToString();
                resultRow["dics"] = row["dics"].ToString();
                resultRow["amount"] = row["amount"].ToString();
                resultRow["totalAmount"] = row["totalAmount"].ToString();
                resultRow["vat"] = row["vat"].ToString();
                resultRow["discount"] = row["discount"].ToString();
                resultRow["amountDue"] = row["AmountDue"].ToString();
                result.Rows.Add(resultRow);
            }
            var viewer = new Reports.ReportViewer();
            ReportDocument ReportDocs = new ReportDocument();
            if (cbxchoose.Text == "Extra Copy")
            {
                ReportDocs = new Reports.Extracopy.extraSI();
            }
            else
            {
                ReportDocs = new Reports.SalesInvoice();
            }
            ReportDocs.Database.Tables[0].SetDataSource(result);
            viewer.Viewer.ReportSource = ReportDocs;
            viewer.btnDeclare.Visible = false;
            viewer.ShowDialog();
        }
    }
}
