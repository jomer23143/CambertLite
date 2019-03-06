namespace Cambert
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salesInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesInvoiceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryProcessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesInvoiceToolStripMenuItem,
            this.masterFileToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10);
            this.menuStrip1.Size = new System.Drawing.Size(511, 43);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salesInvoiceToolStripMenuItem
            // 
            this.salesInvoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesInvoiceToolStripMenuItem1,
            this.deliveryProcessingToolStripMenuItem});
            this.salesInvoiceToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesInvoiceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.salesInvoiceToolStripMenuItem.Name = "salesInvoiceToolStripMenuItem";
            this.salesInvoiceToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.salesInvoiceToolStripMenuItem.Text = "Transaction";
            // 
            // salesInvoiceToolStripMenuItem1
            // 
            this.salesInvoiceToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.salesInvoiceToolStripMenuItem1.Name = "salesInvoiceToolStripMenuItem1";
            this.salesInvoiceToolStripMenuItem1.Size = new System.Drawing.Size(212, 24);
            this.salesInvoiceToolStripMenuItem1.Text = "Sales Processing";
            this.salesInvoiceToolStripMenuItem1.Click += new System.EventHandler(this.salesInvoiceToolStripMenuItem1_Click);
            // 
            // deliveryProcessingToolStripMenuItem
            // 
            this.deliveryProcessingToolStripMenuItem.Name = "deliveryProcessingToolStripMenuItem";
            this.deliveryProcessingToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.deliveryProcessingToolStripMenuItem.Text = "Delivery Processing";
            this.deliveryProcessingToolStripMenuItem.Click += new System.EventHandler(this.deliveryProcessingToolStripMenuItem_Click);
            // 
            // masterFileToolStripMenuItem
            // 
            this.masterFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.productToolStripMenuItem});
            this.masterFileToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterFileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.masterFileToolStripMenuItem.Name = "masterFileToolStripMenuItem";
            this.masterFileToolStripMenuItem.Size = new System.Drawing.Size(100, 23);
            this.masterFileToolStripMenuItem.Text = "Master File";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesReportToolStripMenuItem,
            this.deliveryReportToolStripMenuItem,
            this.salesRegisterToolStripMenuItem,
            this.deliveryRegisterToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // salesReportToolStripMenuItem
            // 
            this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.salesReportToolStripMenuItem.Text = "Sales Report";
            this.salesReportToolStripMenuItem.Click += new System.EventHandler(this.salesReportToolStripMenuItem_Click);
            // 
            // deliveryReportToolStripMenuItem
            // 
            this.deliveryReportToolStripMenuItem.Name = "deliveryReportToolStripMenuItem";
            this.deliveryReportToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.deliveryReportToolStripMenuItem.Text = "Delivery Report";
            this.deliveryReportToolStripMenuItem.Click += new System.EventHandler(this.deliveryReportToolStripMenuItem_Click);
            // 
            // salesRegisterToolStripMenuItem
            // 
            this.salesRegisterToolStripMenuItem.Name = "salesRegisterToolStripMenuItem";
            this.salesRegisterToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.salesRegisterToolStripMenuItem.Text = "Sales Register";
            this.salesRegisterToolStripMenuItem.Click += new System.EventHandler(this.salesRegisterToolStripMenuItem_Click);
            // 
            // deliveryRegisterToolStripMenuItem
            // 
            this.deliveryRegisterToolStripMenuItem.Name = "deliveryRegisterToolStripMenuItem";
            this.deliveryRegisterToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.deliveryRegisterToolStripMenuItem.Text = "Delivery Register";
            this.deliveryRegisterToolStripMenuItem.Click += new System.EventHandler(this.deliveryRegisterToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 271);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMBERT LITE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenu_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salesInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesInvoiceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deliveryProcessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryRegisterToolStripMenuItem;
    }
}

