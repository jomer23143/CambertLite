namespace Cambert.outgoing
{
    partial class Sales
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSI = new System.Windows.Forms.TextBox();
            this.cbxTypeOfSTocks = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSiDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTerms = new System.Windows.Forms.ComboBox();
            this.cbxPriceType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxProductCode = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxCustCode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtTotalA = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtAmountD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDeclare = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.colCode = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colPrice = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.colDisc = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.colAmount = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txtSI);
            this.groupBox1.Controls.Add(this.cbxTypeOfSTocks);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPO);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSiDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice Details";
            // 
            // txtSI
            // 
            this.txtSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSI.Location = new System.Drawing.Point(6, 35);
            this.txtSI.Name = "txtSI";
            this.txtSI.Size = new System.Drawing.Size(136, 20);
            this.txtSI.TabIndex = 1;
            this.txtSI.Validating += new System.ComponentModel.CancelEventHandler(this.txtSI_Validating);
            // 
            // cbxTypeOfSTocks
            // 
            this.cbxTypeOfSTocks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTypeOfSTocks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTypeOfSTocks.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxTypeOfSTocks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeOfSTocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTypeOfSTocks.FormattingEnabled = true;
            this.cbxTypeOfSTocks.Items.AddRange(new object[] {
            "GOOD STOCKS",
            "DAMAGE STOCKS"});
            this.cbxTypeOfSTocks.Location = new System.Drawing.Point(457, 35);
            this.cbxTypeOfSTocks.Name = "cbxTypeOfSTocks";
            this.cbxTypeOfSTocks.Size = new System.Drawing.Size(186, 21);
            this.cbxTypeOfSTocks.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type Of Stocks :";
            // 
            // txtPO
            // 
            this.txtPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPO.Location = new System.Drawing.Point(309, 35);
            this.txtPO.Name = "txtPO";
            this.txtPO.Size = new System.Drawing.Size(136, 20);
            this.txtPO.TabIndex = 3;
            this.txtPO.Validating += new System.ComponentModel.CancelEventHandler(this.txtPO_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "PO No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "SI Date :";
            // 
            // txtSiDate
            // 
            this.txtSiDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtSiDate.Location = new System.Drawing.Point(155, 35);
            this.txtSiDate.Name = "txtSiDate";
            this.txtSiDate.Size = new System.Drawing.Size(142, 20);
            this.txtSiDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "SI No :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.txtTerms);
            this.groupBox2.Controls.Add(this.cbxPriceType);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbxProductCode);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtCustName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbxCustCode);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTin);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(895, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Details";
            // 
            // txtTerms
            // 
            this.txtTerms.AutoCompleteCustomSource.AddRange(new string[] {
            "30 days",
            "60 days",
            "CWO",
            "COD"});
            this.txtTerms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTerms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerms.FormattingEnabled = true;
            this.txtTerms.Items.AddRange(new object[] {
            "30 days",
            "60 days",
            "CWO",
            "COD"});
            this.txtTerms.Location = new System.Drawing.Point(162, 82);
            this.txtTerms.Name = "txtTerms";
            this.txtTerms.Size = new System.Drawing.Size(135, 21);
            this.txtTerms.TabIndex = 17;
            // 
            // cbxPriceType
            // 
            this.cbxPriceType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxPriceType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPriceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPriceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPriceType.FormattingEnabled = true;
            this.cbxPriceType.Items.AddRange(new object[] {
            "LP WITH VAT",
            "LP WITHOUT VAT"});
            this.cbxPriceType.Location = new System.Drawing.Point(9, 123);
            this.cbxPriceType.Name = "cbxPriceType";
            this.cbxPriceType.Size = new System.Drawing.Size(137, 21);
            this.cbxPriceType.TabIndex = 2;
            this.cbxPriceType.SelectedIndexChanged += new System.EventHandler(this.cbxPriceType_SelectedIndexChanged);
            this.cbxPriceType.SelectedValueChanged += new System.EventHandler(this.cbxPriceType_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Price Type :";
            // 
            // cbxProductCode
            // 
            this.cbxProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProductCode.FormattingEnabled = true;
            this.cbxProductCode.Items.AddRange(new object[] {
            "Product Code",
            "Customer Code"});
            this.cbxProductCode.Location = new System.Drawing.Point(309, 81);
            this.cbxProductCode.Name = "cbxProductCode";
            this.cbxProductCode.Size = new System.Drawing.Size(135, 21);
            this.cbxProductCode.TabIndex = 1;
            this.cbxProductCode.SelectedValueChanged += new System.EventHandler(this.cbxProductCode_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(159, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Terms :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Use Product Code :";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(521, 37);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(359, 99);
            this.txtAddress.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(519, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Address :";
            // 
            // txtCustName
            // 
            this.txtCustName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(161, 37);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ReadOnly = true;
            this.txtCustName.Size = new System.Drawing.Size(347, 20);
            this.txtCustName.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(159, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Customer Name :";
            // 
            // cbxCustCode
            // 
            this.cbxCustCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCustCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCustCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCustCode.FormattingEnabled = true;
            this.cbxCustCode.Location = new System.Drawing.Point(11, 37);
            this.cbxCustCode.Name = "cbxCustCode";
            this.cbxCustCode.Size = new System.Drawing.Size(135, 21);
            this.cbxCustCode.TabIndex = 0;
            this.cbxCustCode.SelectedValueChanged += new System.EventHandler(this.cbxCustCode_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Customer Code :";
            // 
            // txtTin
            // 
            this.txtTin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTin.Location = new System.Drawing.Point(10, 82);
            this.txtTin.Name = "txtTin";
            this.txtTin.ReadOnly = true;
            this.txtTin.Size = new System.Drawing.Size(136, 20);
            this.txtTin.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tin No :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colDescription,
            this.colQty,
            this.colUnit,
            this.colPrice,
            this.colDisc,
            this.colAmount});
            this.dataGridView1.Location = new System.Drawing.Point(12, 221);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Size = new System.Drawing.Size(895, 195);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Controls.Add(this.txtTotalA);
            this.panel17.Controls.Add(this.txtVat);
            this.panel17.Controls.Add(this.txtDiscount);
            this.panel17.Location = new System.Drawing.Point(676, 419);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(231, 72);
            this.panel17.TabIndex = 58;
            // 
            // txtTotalA
            // 
            this.txtTotalA.AutoSize = true;
            this.txtTotalA.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.txtTotalA.Location = new System.Drawing.Point(20, 6);
            this.txtTotalA.Name = "txtTotalA";
            this.txtTotalA.Size = new System.Drawing.Size(102, 16);
            this.txtTotalA.TabIndex = 52;
            this.txtTotalA.Text = "Total Amount :  0.00";
            // 
            // txtVat
            // 
            this.txtVat.AutoSize = true;
            this.txtVat.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.txtVat.Location = new System.Drawing.Point(59, 47);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(62, 16);
            this.txtVat.TabIndex = 54;
            this.txtVat.Text = "VAT :  0.00";
            // 
            // txtDiscount
            // 
            this.txtDiscount.AutoSize = true;
            this.txtDiscount.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.txtDiscount.Location = new System.Drawing.Point(41, 26);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(81, 16);
            this.txtDiscount.TabIndex = 53;
            this.txtDiscount.Text = "Discount :  0.00";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.txtAmountD);
            this.panel14.Controls.Add(this.label14);
            this.panel14.Location = new System.Drawing.Point(676, 493);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(234, 38);
            this.panel14.TabIndex = 59;
            // 
            // txtAmountD
            // 
            this.txtAmountD.BackColor = System.Drawing.Color.White;
            this.txtAmountD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmountD.Location = new System.Drawing.Point(100, 13);
            this.txtAmountD.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmountD.Name = "txtAmountD";
            this.txtAmountD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAmountD.Size = new System.Drawing.Size(125, 13);
            this.txtAmountD.TabIndex = 5;
            this.txtAmountD.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Total Amount Due: ";
            // 
            // btnDeclare
            // 
            this.btnDeclare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeclare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(163)))));
            this.btnDeclare.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeclare.ForeColor = System.Drawing.Color.White;
            this.btnDeclare.Location = new System.Drawing.Point(796, 532);
            this.btnDeclare.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeclare.Name = "btnDeclare";
            this.btnDeclare.Size = new System.Drawing.Size(115, 40);
            this.btnDeclare.TabIndex = 3;
            this.btnDeclare.Text = "Save";
            this.btnDeclare.UseVisualStyleBackColor = false;
            this.btnDeclare.Click += new System.EventHandler(this.btnDeclare_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 60;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(676, 532);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 40);
            this.btnExit.TabIndex = 61;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // colCode
            // 
            this.colCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.colCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.colCode.DisplayMember = "Text";
            this.colCode.DropDownHeight = 106;
            this.colCode.DropDownWidth = 121;
            this.colCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colCode.HeaderText = "Product Code";
            this.colCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colCode.IntegralHeight = false;
            this.colCode.ItemHeight = 15;
            this.colCode.Name = "colCode";
            this.colCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colCode.Width = 150;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 300;
            // 
            // colQty
            // 
            // 
            // 
            // 
            this.colQty.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.colQty.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.colQty.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colQty.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.colQty.HeaderText = "Qty";
            this.colQty.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.colQty.Name = "colQty";
            this.colQty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colQty.Width = 50;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "Unit";
            this.colUnit.Items.AddRange(new object[] {
            "PCS",
            "CASES"});
            this.colUnit.Name = "colUnit";
            this.colUnit.Width = 70;
            // 
            // colPrice
            // 
            // 
            // 
            // 
            this.colPrice.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.colPrice.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.colPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colPrice.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPrice.HeaderText = "Price";
            this.colPrice.Increment = 1;
            this.colPrice.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.colPrice.Name = "colPrice";
            this.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDisc
            // 
            // 
            // 
            // 
            this.colDisc.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.colDisc.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.colDisc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colDisc.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.colDisc.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDisc.HeaderText = "Disc";
            this.colDisc.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.colDisc.Name = "colDisc";
            this.colDisc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDisc.Width = 50;
            // 
            // colAmount
            // 
            // 
            // 
            // 
            this.colAmount.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.colAmount.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.colAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colAmount.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Increment = 1;
            this.colAmount.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(919, 574);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeclare);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxTypeOfSTocks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtSiDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtSI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxPriceType;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cbxProductCode;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxCustCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeclare;
        private System.Windows.Forms.Panel panel14;
        public System.Windows.Forms.TextBox txtAmountD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel17;
        public System.Windows.Forms.Label txtTotalA;
        public System.Windows.Forms.Label txtVat;
        public System.Windows.Forms.Label txtDiscount;
        private System.Windows.Forms.ComboBox txtTerms;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colQty;
        private System.Windows.Forms.DataGridViewComboBoxColumn colUnit;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn colPrice;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colDisc;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn colAmount;
    }
}