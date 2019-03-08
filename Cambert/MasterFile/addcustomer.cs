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
    public partial class addcustomer : Form
    {
        public static int id;
        public static String mode = "";
        public addcustomer()
        {
            InitializeComponent();
        }

        private void addcustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnDeclare_Click(object sender, EventArgs e)
        {
            if (mode == "update")
            { updated(); }
            else
            { saved(); }
        }
        private void saved()
        {
            StringBuilder sql = new StringBuilder();
            Dictionary<String, Object> header = new Dictionary<string, object>();
            header.Add("custCode", txtcustCode.Text);
            header.Add("customer", txtcustName.Text);
            header.Add("address", txtaddress.Text);
            header.Add("businessStyle", txtbusiness.Text);
            header.Add("contactNo", txtcontact.Text);
            header.Add("postalCode", txtpostCode.Text);
            header.Add("tinNo", txttin.Text);
            header.Add("terms", txtterms.Text);
            header.Add("discount1", txtdisc1.Text);
            header.Add("discount2", txtdisc2.Text);
            header.Add("discount3", txtdisc3.Text);
            header.Add("discount4", txtdisc4.Text);
            header.Add("discount5", txtdisc5.Text);
            header.Add("zone", txtzone.Text);
            header.Add("status", 1);
            sql.Append(DataSupport.GetInsert("base_customer", header));
            DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            MessageBox.Show("Saved");
            DialogResult = DialogResult.OK;
        }
        private void updated()
        {
            StringBuilder sql = new StringBuilder();
            var primary = new List<String>();
            Dictionary<String, Object> header = new Dictionary<string, object>();
            header.Add("_custIndex", id);
            header.Add("custCode", txtcustCode.Text);
            header.Add("customer", txtcustName.Text);
            header.Add("address", txtaddress.Text);
            header.Add("businessStyle", txtbusiness.Text);
            header.Add("contactNo", txtcontact.Text);
            header.Add("postalCode", txtpostCode.Text);
            header.Add("tinNo", txttin.Text);
            header.Add("terms", txtterms.Text);
            header.Add("discount1", txtdisc1.Text);
            header.Add("discount2", txtdisc2.Text);
            header.Add("discount3", txtdisc3.Text);
            header.Add("discount4", txtdisc4.Text);
            header.Add("discount5", txtdisc5.Text);
            header.Add("zone", txtzone.Text);
            header.Add("status", 1);
            primary.Add("_custIndex");
            sql.Append(DataSupport.GetUpdate("base_customer", header, primary));
            DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            MessageBox.Show("updated");
            DialogResult = DialogResult.OK;
        }
    }
}
