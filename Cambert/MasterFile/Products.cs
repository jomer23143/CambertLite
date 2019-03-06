using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework;

namespace Cambert.MasterFile
{
    public partial class Products : Form
    {
        public static String mode = "";
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {

        }

        private void btnDeclare_Click(object sender, EventArgs e)
        {
            if (mode == "update")
            { update(); }
            else
            { saved(); }
        }
        private void saved()
        {
            StringBuilder sql = new StringBuilder();
            Dictionary<String, Object> header = new Dictionary<String, Object>();
            header.Add("product_code", txtproductCode.Text);
            header.Add("customer_code", txtCustCode.Text);
            header.Add("description", txtDescription.Text);
            sql.Append(DataSupport.GetInsert("base_product", header));

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (dataGridView1.Rows.IndexOf(row) == dataGridView1.Rows.Count - 1)
                    break;
                Dictionary<String, Object> details = new Dictionary<String, Object>();
                details.Add("product_code", txtproductCode.Text);
                if (string.IsNullOrEmpty(row.Cells[colUOM.Name].Value as string))
                { details.Add("uom", ""); }
                else
                { details.Add("uom", row.Cells[colUOM.Name].Value.ToString()); }
                if (string.IsNullOrEmpty(row.Cells[colUOM.Name].Value as string))
                { details.Add("quantity", ""); }
                else
                { details.Add("quantity", row.Cells[colQty.Name].Value.ToString()); }
                if (string.IsNullOrEmpty(row.Cells[colPriceType.Name].Value as string))
                { details.Add("priceType", ""); }
                else
                { details.Add("priceType", row.Cells[colPriceType.Name].Value.ToString()); }
                if (string.IsNullOrEmpty(row.Cells[colPriceType.Name].Value as string))
                { details.Add("price", ""); }
                else
                { details.Add("price", row.Cells[colPrice.Name].Value.ToString()); }
                sql.Append(DataSupport.GetInsert("base_price", details));

            }
            DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            MessageBox.Show("Success");
            DialogResult = DialogResult.OK;

        }
        private void update()
        {
            StringBuilder sql = new StringBuilder();
            var primary = new List<string>();
            Dictionary<String, Object> header = new Dictionary<String, Object>();
            header.Add("product_code", txtproductCode.Text);
            header.Add("description", txtDescription.Text);
            primary.Add("product_code");
            sql.Append(DataSupport.GetUpdate("base_product", header, primary));

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (dataGridView1.Rows.IndexOf(row) == dataGridView1.Rows.Count - 1)
                    break;
                var primarys = new List<string>();
                Dictionary<String, Object> details = new Dictionary<String, Object>();
                details.Add("product_code", txtproductCode.Text);
                if (string.IsNullOrEmpty(row.Cells[colUOM.Name].Value as string))
                { details.Add("uom", ""); }
                else
                { details.Add("uom", row.Cells[colUOM.Name].Value.ToString()); }
                if (string.IsNullOrEmpty(row.Cells[colUOM.Name].Value as string))
                { details.Add("quantity", ""); }
                else
                { details.Add("quantity", row.Cells[colQty.Name].Value.ToString()); }
                if (string.IsNullOrEmpty(row.Cells[colPriceType.Name].Value as string))
                { details.Add("priceType", ""); }
                else
                { details.Add("priceType", row.Cells[colPriceType.Name].Value.ToString()); }
                if (string.IsNullOrEmpty(row.Cells[colPriceType.Name].Value as string))
                { details.Add("price", ""); }
                else
                { details.Add("price", row.Cells[colPrice.Name].Value.ToString()); }
                primarys.Add("product_code"); primarys.Add("uom"); primarys.Add("priceType");
                if (FAQ.productPriceExist(txtproductCode.Text, row.Cells[colUOM.Name].Value.ToString(), row.Cells[colPriceType.Name].Value.ToString()))
                { sql.Append(DataSupport.GetUpdate("base_price", details, primarys)); }
                else
                { sql.Append(DataSupport.GetInsert("base_price", details)); }
            }
            DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            MessageBox.Show("updated");
            DialogResult = DialogResult.OK;
        }
    }
}
