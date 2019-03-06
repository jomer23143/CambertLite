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
    public partial class ExtraDRCopy : Form
    {
        public ExtraDRCopy()
        {
            InitializeComponent();
        }

        private void btnDeclare_Click(object sender, EventArgs e)
        {
            System.Data.DataTable result = new System.Data.DataTable();
            result.Columns.Add(new DataColumn("dr", typeof(String)));
            result.Columns.Add(new DataColumn("drDate", typeof(DateTime)));
            result.Columns.Add(new DataColumn("poNo", typeof(String)));
            result.Columns.Add(new DataColumn("custname", typeof(String)));
            result.Columns.Add(new DataColumn("address", typeof(String)));
            result.Columns.Add(new DataColumn("tin", typeof(String)));
            result.Columns.Add(new DataColumn("productCode", typeof(String)));
            result.Columns.Add(new DataColumn("description", typeof(String)));
            result.Columns.Add(new DataColumn("batch", typeof(String)));
            result.Columns.Add(new DataColumn("exDate", typeof(DateTime)));
            result.Columns.Add(new DataColumn("pack", typeof(String)));
            result.Columns.Add(new DataColumn("pcs", typeof(Decimal)));
            result.Columns.Add(new DataColumn("cases", typeof(int)));
            result.Columns.Add(new DataColumn("terms", typeof(String)));
            DataRow resultRow = result.NewRow();
            var dt = DataSupport.RunDataSet("Select * from Global_drTrans dr join Global_drTransDetails D on dr.dr_Id = D.dr_Id join base_customer c on dr.custCode = c.custCode where dr.drNo = '" + txtdr.Text + "'").Tables[0];
            foreach(DataRow row in dt.Rows)
            {
                resultRow = result.NewRow();
                resultRow["dr"] = row["drNo"].ToString();
                resultRow["drDate"] = row["drDate"].ToString();
                resultRow["poNo"] = row["poNo"].ToString();
                resultRow["custname"] = row["custName"].ToString();
                resultRow["address"] = row["address"].ToString();
                resultRow["tin"] = row["tinNo"].ToString();
                resultRow["productCode"] = row["product_code"].ToString();
                resultRow["description"] = row["description"].ToString();
                resultRow["batch"] = row["batchno"].ToString();
                if (row["expiryDate"].ToString() == "")
                { resultRow["exDate"] = DBNull.Value; }
                else
                { resultRow["exDate"] = row["expiryDate"].ToString(); }
                resultRow["pack"] = row["packSize"].ToString();
                resultRow["pcs"] = row["pcs"].ToString();
                resultRow["cases"] = row["cases"].ToString();
                resultRow["terms"] = DBNull.Value;
                result.Rows.Add(resultRow);
            }
            var viewer = new Reports.ReportViewer();
            ReportDocument ReportDocs = new ReportDocument();
            if (cbxchoose.Text == "Extra Copy")
            {
                ReportDocs = new Reports.Extracopy.ExtraDr();
            }
            else
            {
                ReportDocs = new Reports.Dr();
            }
            ReportDocs.Database.Tables[0].SetDataSource(result);
            viewer.Viewer.ReportSource = ReportDocs;
            viewer.btnDeclare.Visible = false;
            viewer.ShowDialog();
        }
    }
}
