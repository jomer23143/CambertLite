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

namespace Cambert.outgoing
{
    public partial class Sales : Form
    {
        String Business;
        public static string mode ="";
        public Sales()
        {
            InitializeComponent();
            //product();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            {
                var dt = DataSupport.RunDataSet("SELECT custCode FROM base_customer").Tables[0];
                foreach (DataRow row in dt.Rows)
                    cbxCustCode.Items.Add(row[0].ToString());
              
                
            }
            cbxPriceType.SelectedIndex = 0;
        }
        //private void product()
        //{
        //    //var dt = Framework.DataSupport.RunDataSet("SELECT product_code,(product_code +'-----'+[description])as Code FROM base_product").Tables[0];
        //    //DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn col = Framework.UIControlSupport.AddGridColumnComboEditable("product_code,[description]" setGridComboBox(dt, "product_code,[description]", "product_code", System.Windows.Forms.AutoCompleteSource.ListItems, System.Windows.Forms.AutoCompleteMode.SuggestAppend, System.Windows.Forms.ComboBoxStyle.DropDown);
        //    //DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn col = Framework.UIControlSupport.AddGridColumnComboEditable("product code,description", dt, "product_code,[description]", "product_code", 2, System.Windows.Forms.ComboBoxStyle.DropDown, 30, 500);
        //    //dataGridView1.Columns.Add(col);
        //    var dt = DataSupport.RunDataSet("SELECT product_code , description , customer_code,category  FROM base_product").Tables[0];
        //    DataTable tables = new DataTable();
        //    tables = dt;
        //    tables.Columns.Add("Product Code", typeof(String));
        //    tables.Columns.Add("Description", typeof(String));
        //    //colCode = UIControlSupport.setGridComboBox(dt, "product_code", "product_code", AutoCompleteSource.ListItems, AutoCompleteMode.SuggestAppend, ComboBoxStyle.DropDown);
        //    colCode.DataSource = tables;
        //    //colCode.DisplayMember = "product_code";
        //    //colCode.ValueMember = "product_code";
           
           
            
        //}
        //private void custCode()
        //{
           
        //    var dt = DataSupport.RunDataSet("SELECT customer_code FROM base_product").Tables[0];
        //    colCode.DataSource = dt;
        //    colCode.DisplayMember = "customer_code";
        //    colCode.ValueMember = "customer_code";
        //}
        private void btnDeclare_Click(object sender, EventArgs e)
        {
            bool status = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                if (String.IsNullOrEmpty(row.Cells[colUnit.Name].Value as string))
                {
                    
                    status = true;
                }
               

            }

            if (!status)
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
                resultRow = result.NewRow();
                resultRow["SI"] = txtSI.Text;
                resultRow["SIdate"] = txtSiDate.Text;
                resultRow["PO"] = txtPO.Text;
                resultRow["custName"] = txtCustName.Text;
                resultRow["address"] = txtAddress.Text;
                resultRow["business"] = Business;
                resultRow["Tin"] = txtTin.Text;
                resultRow["Terms"] = txtTerms.Text;
                result.Rows.Add(resultRow);
                foreach (DataGridViewRow dRow in dataGridView1.Rows)
                {
                    if (dataGridView1.Rows.IndexOf(dRow) == dataGridView1.Rows.Count - 1)
                        break;
                    resultRow = result.NewRow();
                    resultRow["productCode"] = dRow.Cells[colCode.Name].Value;
                    resultRow["description"] = dRow.Cells[colDescription.Name].Value;
                    resultRow["qty"] = dRow.Cells[colQty.Name].Value;
                    resultRow["unit"] = dRow.Cells[colUnit.Name].Value;
                    resultRow["price"] = dRow.Cells[colPrice.Name].Value;
                    resultRow["dics"] = dRow.Cells[colDisc.Name].Value;
                    resultRow["amount"] = dRow.Cells[colAmount.Name].Value;
                    result.Rows.Add(resultRow);
                }
                resultRow = result.NewRow();
                resultRow["totalAmount"] = Details[2].ToString();
                resultRow["vat"] = Details[1].ToString();
                resultRow["discount"] = Details[3].ToString();
                resultRow["amountDue"] = Details[0].ToString();
                result.Rows.Add(resultRow);
                var viewer = new Reports.ReportViewer();
                ReportDocument ReportDocs = new ReportDocument();
                ReportDocs = new Reports.SalesInvoice();
                ReportDocs.Database.Tables[0].SetDataSource(result);
                viewer.Viewer.ReportSource = ReportDocs;
                viewer.btnPrint.Visible = false;
                viewer.ShowDialog();


                if (viewer._status == "save")
                {
                    saved();
                    DataSupport.UpdateMenuCode("INVOICE");
                    clear();
                }
            }
            else
            {

                    MessageBox.Show("uom is empty");

            }
        }
        private void saved()
        {
            try
            {
                
                String siId = DataSupport.GetNextMenuCodeInt("INVOICE");
                StringBuilder sql = new StringBuilder();
                Dictionary<String, Object> header = new Dictionary<string, object>();
                header.Add("outgoing_Id", siId);
                header.Add("siNo", txtSI.Text);
                header.Add("sidate", txtSiDate.Text);
                header.Add("poNo", txtPO.Text);
                header.Add("typeOfStock", cbxTypeOfSTocks.Text);
                header.Add("custCode", cbxCustCode.Text);
                header.Add("custName", txtCustName.Text);
                header.Add("terms", txtTerms.Text);
                header.Add("priceType", cbxPriceType.Text);
                header.Add("totalAmount", Details[2]);
                header.Add("discount", Details[3]);
                header.Add("vat", Details[1]);
                header.Add("AmountDue", Details[0]);
                sql.Append(DataSupport.GetInsert("Global_ProductTrans", header));
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (dataGridView1.Rows.IndexOf(row) == dataGridView1.Rows.Count - 1)
                        break;

                    Dictionary<String, Object> detail = new Dictionary<String, Object>();
                    detail.Add("outgoing_Id", siId);
                    detail.Add("prodIndex", row.Cells[colprodIndex.Name].Value.ToString());
                    detail.Add("product_code", row.Cells[colCode.Name].Value.ToString());
                    detail.Add("description", row.Cells[colDescription.Name].Value.ToString());
                    detail.Add("qty", row.Cells[colQty.Name].Value.ToString());
                    detail.Add("uom", row.Cells[colUnit.Name].Value.ToString());
                    detail.Add("price", row.Cells[colPrice.Name].Value.ToString());
                    detail.Add("dics", row.Cells[colDisc.Name].Value.ToString());
                    detail.Add("amount", row.Cells[colAmount.Name].Value.ToString());
                    sql.Append(DataSupport.GetInsert("Global_ProductTransDetails", detail));
                }
                DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
                MessageBox.Show("Saved");
                DialogResult = DialogResult.OK;
            }
            catch
            {
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String code = dataGridView1.Rows[e.RowIndex].Cells[colprodIndex.Name].Value.ToString();
                //var dt = DataSupport.RunDataSet("select * from base_product where _prodIndex = '" + code + "'").Tables[0];
                //if (e.ColumnIndex == dataGridView1.Columns[colCode.Name].Index)
                //{
                   
                //    foreach (DataRow row in dt.Rows)
                //    {
                //        dataGridView1.Rows[e.RowIndex].Cells[colDescription.Name].Value = row["description"].ToString();
                //    }
                //}
                String unit = dataGridView1.Rows[e.RowIndex].Cells[colUnit.Name].Value.ToString();
                var dts = DataSupport.RunDataSet("select * from base_price where prodIndex ='" + code + "' and  uom ='" + unit + "' and priceType ='" + cbxPriceType.Text + "'").Tables[0];
                if (e.ColumnIndex == dataGridView1.Columns[colUnit.Name].Index)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[colDisc.Name].Value = 0;
                    foreach (DataRow rows in dts.Rows)
                    {
                            dataGridView1.Rows[e.RowIndex].Cells[colPrice.Name].Value = rows["price"].ToString();    

                    }
                }
                if (dts.Rows.Count > 0)
                {

                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[colPrice.Name].Value=null;
                }
                compute();
            }
            catch
            { }
        }
        Double[] Details = new Double[4] { 0, 0, 0, 0 };
        private void compute()
        {
            Double total = 0.00;
            Double sum = 0;
            Double dics = 0;
            Double totaldics = 0;
            Double vat = 0;
            Double AmountDue = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                sum = Convert.ToDouble(row.Cells[colQty.Name].Value) * Convert.ToDouble(row.Cells[colPrice.Name].Value);
                //to get discount
                dics = (Convert.ToDouble(row.Cells[colDisc.Name].Value) / 100) * sum;
                //total discount
                totaldics += dics;
                txtDiscount.Text = String.Format("Discount :   " + totaldics.ToString());
                Details[3] = totaldics;
                //sum of unitprice
                row.Cells[colAmount.Name].Value = sum - dics;
                //sum of total amount
                total += Convert.ToDouble(row.Cells[colAmount.Name].Value.ToString());
                txtTotalA.Text = String.Format("Total Amount :   " + total.ToString());
                Details[2] = total;
                //get of vat
                vat = total * 0.12;
                txtVat.Text = String.Format("VAT :   " + vat.ToString());
                Details[1] = vat;
                //get totol amount Due
                AmountDue = total + vat;
                txtAmountD.Text = AmountDue.ToString();
                Details[0] = AmountDue;
            }
        }

        private void cbxCustCode_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = DataSupport.RunDataSet("SELECT  * FROM base_customer where custCode = '" + cbxCustCode.Text + "' ").Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    txtCustName.Text = row["customer"].ToString();
                    txtAddress.Text = row["address"].ToString();
                    txtTin.Text = row["tinNo"].ToString();
                    Business = row["businessStyle"].ToString();
                }
            }
            catch
            { }
        }

        private void txtSI_Validating(object sender, CancelEventArgs e)
        {
            if (FAQ.InvoiceExist(txtSI.Text))
            {
                e.Cancel = true;
                txtSI.Focus();
                errorProvider1.SetError(txtSI, "Invoice No is Exist");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSI, null);
            }
        }

        private void cbxPriceType_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                    row.Cells[colUnit.Name].Value = null;
                    row.Cells[colPrice.Name].Value = 0.00;
                    row.Cells[colAmount.Name].Value = 0.00;
              
            }

        }

        private void cbxPriceType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPO_Validating(object sender, CancelEventArgs e)
        {
            if (FAQ.INPoExist(txtPO.Text))
            {
                e.Cancel = true;
                txtPO.Focus();
                errorProvider1.SetError(txtPO, "PO No is Exist");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPO, null);
            }
        }
        private void clear()
        {
            txtSI.Clear();
            txtPO.Clear();
            cbxCustCode.SelectedIndex = -1;
            txtCustName.Clear();
            txtAddress.Clear();
            txtTin.Clear();
            txtTerms.SelectedIndex = -1;
            cbxPriceType.SelectedIndex = -1;
            cbxTypeOfSTocks.SelectedIndex = -1;
            dataGridView1.Rows.Clear();
            txtTotalA.Text = String.Format("Total Amount : 0.00 ");
            txtDiscount.Text = String.Format("Discount : 0.00 ");
            txtVat.Text = String.Format("Vat : 0.00 ");
            txtAmountD.Text = String.Format("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxProductCode_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns[colCode.Name].Index)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var dialog = new outgoing.Products())
            {
                dialog.ShowDialog();
                foreach (DataGridViewRow row in dialog.dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["colcheck"].Value))
                    {
                        var dt = DataSupport.RunDataSet("Select * from base_product where _prodIndex = '" + row.Cells["colprodIndex"].Value.ToString() + "'").Tables[0];
                        //MessageBox.Show(row.Cells["colproduct"].Value.ToString());
                        //Dictionary<String, Dictionary<String, String>> param = new Dictionary<String, Dictionary<String, String>>();
                        //Dictionary<String, String> details = new Dictionary<string, string>();
                        //details.Add("colprodIndex", row.Cells["colprodIndex"].Value.ToString());
                        //details.Add("colproduct", row.Cells["colproduct"].Value.ToString());
                        //details.Add("colDescription", row.Cells["colDescription"].Value.ToString());
                        //param.Add("colprodIndex", details);
                        foreach (DataRow data in dt.Rows)
                        {
                            //Object[] items = new Object[] { row.Cells["colprodIndex"].Value.ToString(), row.Cells["colproduct"].Value.ToString(), row.Cells["colDescription"].Value.ToString() };
                            Object[] items = new Object[] { data["_prodIndex"].ToString(),data["product_code"].ToString(),data["description"].ToString()};
                            dataGridView1.Rows.Add(items);
                            DialogResult = DialogResult.OK;
                        }
                    }

                }
            }
        }
    }
}
