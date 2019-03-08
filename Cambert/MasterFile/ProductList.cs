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
using System.Reflection;


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
            DoubleBuffered(dataGridView1, true);
        }
        public void DoubleBuffered(object obj, bool setting)
        {
            Type objType = obj.GetType();
            PropertyInfo pi = objType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(obj, setting, null);
        }
        private void display()
        {
            _bs.DataSource = DataSupport.RunDataSet("  Select * from base_product order by customer_code asc").Tables[0];
            dataGridView1.DataSource = _bs;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dialog = new MasterFile.Products();
                String index = dataGridView1.Rows[e.RowIndex].Cells[colindex.Name].Value.ToString(); 
                var dRow = DataSupport.RunDataSet(String.Format("Select * from base_price  where base_price.prodIndex = '{0}' ",index)).Tables[0];
                if (dRow.Rows.Count > 0)
                {
                    foreach (DataRow row in dRow.Rows)
                    {
                        dialog.txtproductCode.Text = row["product_code"].ToString();
                        dialog.txtCustCode.Text = row["customer_code"].ToString();
                        dialog.txtDescription.Text = row["description"].ToString();
                        Products.id = Convert.ToInt32(row["prodIndex"].ToString());
                        dialog.dataGridView1.DataSource = DataSupport.RunDataSet("Select [uom],quantity,priceType,price from  base_price join base_product on base_price.prodIndex = base_product._prodIndex where base_price.prodIndex ='" + index + "'").Tables[0];
                    }
                }
                else
                {
                    var dt = DataSupport.RunDataSet("Select * from base_product  where _prodIndex ='" + index + "'").Tables[0];
                    foreach (DataRow row in dt.Rows)
                    {
                        dialog.txtproductCode.Text = row["product_code"].ToString();
                        dialog.txtCustCode.Text = row["customer_code"].ToString();
                        dialog.txtDescription.Text = row["description"].ToString();
                        Products.id = Convert.ToInt32(row["_prodIndex"].ToString());
                    }
                }

                Products.mode = "update";
                dialog.ShowDialog();
                display();
            }
            catch (Exception ex)

            { MessageBox.Show(ex.Message); }
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
