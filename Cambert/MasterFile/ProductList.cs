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
    public partial class ProductList : Form
    {
        private readonly BindingSource _bs = new BindingSource();
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            display();
        }
        private void display()
        {
            _bs.DataSource = DataSupport.RunDataSet("  Select * from base_product").Tables[0];
            dataGridView1.DataSource = _bs;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dialog = new MasterFile.Products();
            string code = dataGridView1.Rows[e.RowIndex].Cells[colCode.Name].Value.ToString();
            var dRow = DataSupport.RunDataSet("Select * from base_product  join base_price on base_price.product_code = base_product.product_code  where base_price.product_code ='" + code + "'").Tables[0];
            if (dRow.Rows.Count > 0)
            {
                foreach (DataRow row in dRow.Rows)
                {

                    dialog.txtproductCode.Text = row["product_code"].ToString();
                    dialog.txtCustCode.Text = row["customer_code"].ToString();
                    dialog.txtDescription.Text = row["description"].ToString();
                    dialog.dataGridView1.DataSource = DataSupport.RunDataSet("Select [uom],quantity,priceType,price from  base_price where product_code ='" + code + "'").Tables[0];
                }
            }
            else
            {
                var dt = DataSupport.RunDataSet("Select * from base_product  where product_code ='" + code + "'").Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    dialog.txtproductCode.Text = row["product_code"].ToString();
                    dialog.txtCustCode.Text = row["customer_code"].ToString();
                    dialog.txtDescription.Text = row["description"].ToString();
                }
            }

            Products.mode = "update";
            dialog.txtproductCode.ReadOnly = true;
            dialog.txtCustCode.ReadOnly = true;
            dialog.ShowDialog();
            display();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            _bs.Filter = "product_code LIKE '%" + txtSearch.Text + "%' or customer_code LIKE '%" + txtSearch.Text + "%' or description LIKE'%" + txtSearch.Text + "%'";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dialog = new MasterFile.Products();
            Products.mode = "";
            dialog.ShowDialog();
            display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.DataTable result = new System.Data.DataTable();
            result.Columns.Add(new DataColumn("productCode", typeof(String)));
            result.Columns.Add(new DataColumn("custCode", typeof(String)));
            result.Columns.Add(new DataColumn("description", typeof(String)));

            DataRow resultRow = result.NewRow();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                resultRow = result.NewRow();
                resultRow["productCode"] = row.Cells[colCode.Name].Value;
                resultRow["custCode"] = row.Cells[colName.Name].Value;
                resultRow["description"] = row.Cells[colDescription.Name].Value;
                result.Rows.Add(resultRow);
            }
            var viewer = new Reports.ReportViewer();
            ReportDocument ReportDocs = new ReportDocument();
            ReportDocs = new Reports.MasterFile.product();
            ReportDocs.Database.Tables[0].SetDataSource(result);
            viewer.Viewer.ReportSource = ReportDocs;
            viewer.btnDeclare.Visible = false;
            viewer.ShowDialog();
        }
    }
}
