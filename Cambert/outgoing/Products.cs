using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework;
using System.Reflection;

namespace Cambert.outgoing
{
    public partial class Products : Form
    {
        private readonly BindingSource _bs = new BindingSource();
        public String mode = "";
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            display();
            DoubleBuffered(dataGridView1, true);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dataGridView1.EnableHeadersVisualStyles = false;
        }
        private void display()
        {
            _bs.DataSource = DataSupport.RunDataSet("  Select * from base_product order by customer_code asc").Tables[0];
            dataGridView1.DataSource = _bs;
        }
        public void DoubleBuffered(object obj, bool setting)
        {
            Type objType = obj.GetType();
            PropertyInfo pi = objType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(obj, setting, null);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _bs.Filter = "product_code LIKE '%" + txtSearch.Text + "%' or customer_code LIKE '%" + txtSearch.Text + "%' or description LIKE'%" + txtSearch.Text + "%'";
        }

        private void btnDeclare_Click(object sender, EventArgs e)
        {
            //selecsSales();
            DialogResult = DialogResult.OK;

        }
        private void selecsSales()
        {
            var dialog = new outgoing.Sales();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[colCheck.Name].Value))
                {
                    MessageBox.Show(row.Cells[colprodIndex.Name].Value.ToString());
                    Dictionary<String,Dictionary<String,String>> param = new Dictionary<String,Dictionary<String,String>>();
                    Dictionary<String, String> details = new Dictionary<string, string>();
                    details.Add(colprodIndex.Name, row.Cells[colProduct.Name].Value.ToString());
                    details.Add(colProduct.Name, row.Cells[colprodIndex.Name].Value.ToString());
                    details.Add(colDescription.Name, row.Cells[colDescription.Name].Value.ToString());
                    
                    param.Add(colprodIndex.Name, details);
                    
                    dialog.dataGridView1.Rows.Add(param);
                    DialogResult = DialogResult.OK;
                }
                
            }
        }
    }
}
