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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            Dictionary<String, Object> header = new Dictionary<string, object>();
            header.Add("employee_id", txtId.Text);
            header.Add("name", txtname.Text);
            header.Add("position", txtposition.Text);
            header.Add("password", SecuritySupport.Encrypt(txtpass.Text));
            header.Add("usertype", cbxType.Text);
            sql.Append(DataSupport.GetInsert("[employees]", header));

            DataSupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
        }
    }
}
