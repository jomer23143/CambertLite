using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework;

namespace Cambert
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Utils.SetConnectionDetails();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new MasterFile.CustomerList();
            Openform(dialog);
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new MasterFile.ProductList();
            Openform(dialog);
        }

        private void salesInvoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var dialog = new outgoing.Sales();
            //dialog.Show();
            Openform(dialog);
        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (RegistrationSupport.userType.ToLower().Trim() == "admin")
            {
                if (e.Control && e.Shift && e.KeyCode == Keys.F12)
                {
                    var dialog = new MasterFile.Registration();
                    //dialog.ShowDialog();
                    Openform(dialog);
                }
            }
        }

        private void deliveryProcessingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new outgoing.Dr();
            //dialog.ShowDialog();
            Openform(dialog);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            menuStrip1.Renderer = new ExtensionColor.RendererToolStrip();
            
        }
        private void Openform(Form form)
        {
            form.MdiParent = this;
            form.Activate();
            form.Show();
            Refresh();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new Reports.Extracopy.EXTRASALES();
            Openform(dialog);
        }

        private void deliveryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new Reports.Extracopy.ExtraDRCopy();
            Openform(dialog);
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            var dailog = new Login();
            dailog.Show();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void salesRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new Reports.Register.RegisterReports();
            dialog.Mode = "GOOD STOCKS";
            dialog.Text = "Sales Register";
            Openform(dialog);
        }

        private void deliveryRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new Reports.Register.RegisterReports();
            dialog.Mode = "DAMAGE STOCKS";
            dialog.Text = "Delivery Register";
            Openform(dialog);
        }
    }
}
