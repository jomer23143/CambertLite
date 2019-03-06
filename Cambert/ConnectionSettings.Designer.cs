namespace Cambert
{
    partial class ConnectionSettings
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
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programsGrid = new System.Windows.Forms.DataGridView();
            this.colname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldbname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // programsGrid
            // 
            this.programsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.programsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colname,
            this.colServer,
            this.coluser,
            this.colpassword,
            this.coldbname});
            this.programsGrid.Location = new System.Drawing.Point(12, 27);
            this.programsGrid.Name = "programsGrid";
            this.programsGrid.Size = new System.Drawing.Size(916, 282);
            this.programsGrid.TabIndex = 7;
            this.programsGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.programsGrid_CellFormatting);
            // 
            // colname
            // 
            this.colname.HeaderText = "Name";
            this.colname.Name = "colname";
            // 
            // colServer
            // 
            this.colServer.HeaderText = "Server";
            this.colServer.Name = "colServer";
            // 
            // coluser
            // 
            this.coluser.HeaderText = "Username";
            this.coluser.Name = "coluser";
            // 
            // colpassword
            // 
            this.colpassword.HeaderText = "Password";
            this.colpassword.Name = "colpassword";
            // 
            // coldbname
            // 
            this.coldbname.HeaderText = "DB Name";
            this.coldbname.Name = "coldbname";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(678, 325);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(138, 32);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "&Test Connection";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(837, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 32);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ConnectionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 373);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.programsGrid);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ConnectionSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectionSettings";
            this.Load += new System.EventHandler(this.ConnectionSettings_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConnectionSettings_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.DataGridView programsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldbname;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnSave;
    }
}