using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Framework;

namespace Cambert.outgoing
{
    public partial class Dr : Form
    {
        String Business;
        public Dr()
        {
            InitializeComponent();
        }

        private void Dr_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            {
                var dt = DataSupport.RunDataSet("SELECT * FROM base_product").Tables[0];
                colCode.DataSource = dt;
                colCode.DisplayMember = "_prodIndex";
                colCode.ValueMember = "product_code";
            }
            {
                var dt = DataSupport.RunDataSet("SELECT custCode FROM base_customer").Tables[0];
                foreach (DataRow row in dt.Rows)
                    txtCustCode.Items.Add(row[0].ToString());
            }
            {
                
                    colbatch.Name += new KeyPressEventHandler(KeyBoardSupport.ForNumericOnly_KeyPress);
            }
        }

        private void txtDRNo_Validating(object sender, CancelEventArgs e)
        {
            if (FAQ.DrExist(txtDRNo.Text))
            {
                e.Cancel = true;
                txtDRNo.Focus();
                errorProvider1.SetError(txtDRNo, "DR No is Exist");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDRNo, null);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String id;
                String code = dataGridView1.Rows[e.RowIndex].Cells[colCode.Name].Value.ToString();
                var dt = DataSupport.RunDataSet("select * from base_product where product_code = '" + code + "'").Tables[0];
               
                foreach (DataRow row in dt.Rows)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[coldescription.Name].Value = row["description"].ToString();
                    dataGridView1.Rows[e.RowIndex].Cells[colprodIndex.Name].Value = row["_prodIndex"].ToString();
                }
            }
            catch
            { }
        }

        private void txtCustCode_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = DataSupport.RunDataSet("SELECT  * FROM base_customer where custCode = '" + txtCustCode.Text + "' ").Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    txtCustName.Text = row["customer"].ToString();
                    txtaddress.Text = row["address"].ToString();
                    txtTin.Text = row["tinNo"].ToString();
                    Business = row["businessStyle"].ToString();
                }
            }
            catch
            { }
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
            result.Columns.Add(new DataColumn("batch", typeof(int)));
            result.Columns.Add(new DataColumn("exDate", typeof(DateTime)));
            result.Columns.Add(new DataColumn("pack", typeof(String)));
            result.Columns.Add(new DataColumn("pcs", typeof(Decimal)));
            result.Columns.Add(new DataColumn("cases", typeof(int)));
            result.Columns.Add(new DataColumn("terms", typeof(String)));
            DataRow resultRow = result.NewRow();
            resultRow = result.NewRow();
            resultRow["dr"] = txtDRNo.Text;
            resultRow["drDate"] = txtDRDate.Text;
            resultRow["poNo"] = txtREf.Text;
            resultRow["custname"] = txtCustName.Text;
            resultRow["address"] = txtaddress.Text;
            resultRow["tin"] = txtTin.Text;
            resultRow["terms"] = txtTerms.Text;
            result.Rows.Add(resultRow);
            foreach (DataGridViewRow dRow in dataGridView1.Rows)
            {
                if (dataGridView1.Rows.IndexOf(dRow) == dataGridView1.Rows.Count - 1)
                    break;
                resultRow = result.NewRow();
                resultRow["productCode"] = dRow.Cells[colCode.Name].Value.ToString();
                resultRow["description"] = dRow.Cells[coldescription.Name].Value.ToString();
                if (string.IsNullOrEmpty(dRow.Cells[colbatch.Name].Value as string))
                { resultRow["batch"] = "0" ; }
                else
                { resultRow["batch"] = dRow.Cells[colbatch.Name].Value.ToString(); }
                if(dRow.Cells[colExdate.Name].Value == null)
                { resultRow["exDate"] = DBNull.Value; }
                else
                { resultRow["exDate"] = dRow.Cells[colExdate.Name].Value.ToString(); }
                resultRow["pack"] = dRow.Cells[colPack.Name].Value.ToString();
                resultRow["pcs"] = dRow.Cells[colpcs.Name].Value.ToString();
                resultRow["cases"] = dRow.Cells[colcases.Name].Value.ToString();
                result.Rows.Add(resultRow);
            }
            var viewer = new Reports.ReportViewer();
            ReportDocument ReportDocs = new ReportDocument();
            ReportDocs = new Reports.Dr();
            ReportDocs.Database.Tables[0].SetDataSource(result);
            viewer.Viewer.ReportSource = ReportDocs;
            viewer.btnPrint.Visible = false;
            viewer.ShowDialog(); 
            if (viewer._status == "save")
            { save(); DataSupport.UpdateMenuCode("DR"); clear(); }
        }
        private void save()
        {
            try
            {

                String DRID = DataSupport.GetNextMenuCodeInt("DR");
                StringBuilder sql = new StringBuilder();
                Dictionary<String, Object> header = new Dictionary<string, object>();
                header.Add("dr_Id", DRID);
                header.Add("drNo", txtDRNo.Text);
                header.Add("drDate", txtDRDate.Text);
                header.Add("poNo", txtREf.Text);
                header.Add("terms", txtTerms.Text);
                header.Add("typeOfStock", txtTypeOfStocks.Text);
                header.Add("custCode", txtCustCode.Text);
                header.Add("custName", txtCustName.Text);
                header.Add("address", txtaddress.Text);
                sql.Append(DataSupport.GetInsert("Global_drTrans", header));
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (dataGridView1.Rows.IndexOf(row) == dataGridView1.Rows.Count - 1)
                        break;

                    Dictionary<String, Object> detail = new Dictionary<String, Object>();
                    detail.Add("dr_Id", DRID);
                    detail.Add("product_code", row.Cells[colCode.Name].Value.ToString());
                    detail.Add("description", row.Cells[coldescription.Name].Value.ToString());
                    if (string.IsNullOrEmpty(row.Cells[colbatch.Name].Value as string))
                    { detail.Add("batchno", ""); }
                    else
                    { detail.Add("batchno", row.Cells[colbatch.Name].Value.ToString()); }
                    if (row.Cells[colExdate.Name].Value == null)
                    { detail.Add("expiryDate", DBNull.Value); }
                    else
                    { detail.Add("expiryDate", row.Cells[colExdate.Name].Value.ToString()); }
                    detail.Add("packSize", row.Cells[colPack.Name].Value.ToString());
                    detail.Add("pcs", row.Cells[colpcs.Name].Value.ToString());
                    detail.Add("cases", row.Cells[colcases.Name].Value.ToString());
                    sql.Append(DataSupport.GetInsert("Global_drTransDetails", detail));
                }
                DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
                MessageBox.Show("Saved");
                DialogResult = DialogResult.OK;
            }
            catch
            {
            }
        }

        private void txtREf_Validating(object sender, CancelEventArgs e)
        {
            if (FAQ.DrPOExist(txtREf.Text))
            {
                e.Cancel = true;
                txtREf.Focus();
                errorProvider1.SetError(txtREf, "PO No is Exist");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtREf, null);
            }
        }
        private void clear()
        {
            txtDRNo.Clear();
            txtREf.Clear();
            txtTypeOfStocks.SelectedIndex = -1;
            txtTin.Clear();
            txtTerms.SelectedIndex = -1;
            txtCustCode.SelectedIndex = -1;
            txtCustName.Clear();
            txtaddress.Clear();
            dataGridView1.Rows.Clear();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
