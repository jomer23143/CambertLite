using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;

namespace Cambert.Reports
{
    public partial class ReportViewer : Form
    {
        private string _holder;
        public string _status = "back";
        public ReportViewer()
        {
            InitializeComponent();
        }

        public ReportViewer(String Action)
        {
            InitializeComponent();
            _holder = Action;
        }
        public CrystalReportViewer Viewer
        {
            get { return this.crystalReportViewer1; }
            set { this.crystalReportViewer1 = value; }
        }
        private void btnDeclare_Click(object sender, EventArgs e)
        {
            _status = "save";
            crystalReportViewer1.PrintReport();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.PrintReport();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
