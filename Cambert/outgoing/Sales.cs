﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework;
using CrystalDecisions.CrystalReports.Engine;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.SuperGrid.Style;
using DevComponents.DotNetBar.SuperGrid;
using System.Collections;

namespace Cambert.outgoing
{
    public partial class Sales : Form
    {
        String Business;
        ComboBoxEx cmb = new ComboBoxEx();
        bool FormLoad;
        public Sales()
        {
            InitializeComponent();
            string[] orderArray = { "Asterids", "Eudicots", "Rosids" };
            grid.PrimaryGrid.Columns.Add(new GridColumn("colprodcode"));
            var dt = DataSupport.RunDataSet("SELECT _prodindex,product_code,customer_code FROM base_product").Tables[0];
            grid.PrimaryGrid.Columns["colprodcode"].EditorType = typeof(FragrantComboBox);
            grid.PrimaryGrid.Columns["colprodcode"].EditorParams = new object[] { dt, "product_code,customer_code", "_prodindex","product_code",AutoCompleteMode.SuggestAppend,AutoCompleteSource.ListItems };            
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            {
                product(); 
            }
            {
                var dt = DataSupport.RunDataSet("SELECT custCode FROM base_customer").Tables[0];
                foreach (DataRow row in dt.Rows)
                    cbxCustCode.Items.Add(row[0].ToString());
            }
            FormLoad = true;
        }
        private void product()
        {
            //var dt = DataSupport.RunDataSet("SELECT _prodindex,product_code,customer_code FROM base_product").Tables[0];
            //cmb = UIControlSupport.SetComboBoxEx(cmb, dt, "product_code,customer_code", "product_code", "_prodindex", AutoCompleteSource.ListItems, 
            //                                     AutoCompleteMode.SuggestAppend,ComboBoxStyle.DropDown,
            //                                     dataGridView1.Columns["colcode"].Width + 200, 250);
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
                clear();
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
                String code = dataGridView1.Rows[e.RowIndex].Cells[colCode.Name].Value.ToString();
                var dt = DataSupport.RunDataSet("select * from base_product where product_code = '" + code + "'").Tables[0];
                if (e.ColumnIndex == dataGridView1.Columns[colCode.Name].Index)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[colDescription.Name].Value = row["description"].ToString();
                    }
                }
                if (e.ColumnIndex == dataGridView1.Columns[colUnit.Name].Index)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[colDisc.Name].Value = 0;
                    String unit = dataGridView1.Rows[e.RowIndex].Cells[colUnit.Name].Value.ToString();
                    var dts = DataSupport.RunDataSet("select * from base_price where product_code ='" + code + "' and  uom ='" + unit + "' and priceType ='" + cbxPriceType.Text + "'").Tables[0];
                    foreach (DataRow rows in dts.Rows)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[colPrice.Name].Value = rows["price"].ToString();
                    }
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
                txtDiscount.Text = String.Format("Discount :   " + totaldics.ToString("C2"));
                Details[3] = totaldics;
                //sum of unitprice
                row.Cells[colAmount.Name].Value = sum - dics;
                //sum of total amount
                total += Convert.ToDouble(row.Cells[colAmount.Name].Value.ToString());
                txtTotalA.Text = String.Format("Total Amount :   " + total.ToString("C2"));
                Details[2] = total;
                //get of vat
                vat = total * 0.12;
                txtVat.Text = String.Format("VAT :   " + vat.ToString("C2"));
                Details[1] = vat;
                //get totol amount Due
                AmountDue = total + vat;
                txtAmountD.Text = AmountDue.ToString("C2");
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
            dataGridView1.Rows.Clear();
            product();
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
        //Clear
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

        private void cmb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (FormLoad)
            {             
                dataGridView1.CurrentCell.Value = cmb.Text;
                MessageBox.Show(cmb.Text);
                cmb.Visible = false;
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["colcode"].Index)
            {
                Rectangle tempRect = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                cmb.Location = tempRect.Location;
                cmb.Width = tempRect.Width;
                cmb.Visible = true;

            }
        }
    }
    internal class FragrantComboBox : GridComboBoxExEditControl
    {
        public FragrantComboBox(DataTable orderArray, String _DropDownColumns, String _ValueMember, String _DisplayMember, 
                                AutoCompleteMode _AutoCompleteMode, AutoCompleteSource _AutoCompleteSource)
        {
            DataSource = orderArray;
            ValueMember = _ValueMember;
            DisplayMember = _DisplayMember;
            AutoCompleteSource = _AutoCompleteSource;
            AutoCompleteMode = _AutoCompleteMode;
            DropDownColumns = _DropDownColumns;
        }
    }

}
