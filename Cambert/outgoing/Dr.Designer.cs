namespace Cambert.outgoing
{
    partial class Dr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTypeOfStocks = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtREf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDRDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDRNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTerms = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustCode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeclare = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.colCode = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colprodIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExdate = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colPack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpcs = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.colcases = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTypeOfStocks);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtREf);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDRDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDRNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "D.R Details";
            // 
            // txtTypeOfStocks
            // 
            this.txtTypeOfStocks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTypeOfStocks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtTypeOfStocks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTypeOfStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeOfStocks.FormattingEnabled = true;
            this.txtTypeOfStocks.Items.AddRange(new object[] {
            "GOOD STOCKS",
            "DAMAGE STOCKS"});
            this.txtTypeOfStocks.Location = new System.Drawing.Point(464, 36);
            this.txtTypeOfStocks.Name = "txtTypeOfStocks";
            this.txtTypeOfStocks.Size = new System.Drawing.Size(186, 21);
            this.txtTypeOfStocks.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type Of Stocks :";
            // 
            // txtREf
            // 
            this.txtREf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREf.Location = new System.Drawing.Point(314, 36);
            this.txtREf.Name = "txtREf";
            this.txtREf.Size = new System.Drawing.Size(136, 20);
            this.txtREf.TabIndex = 2;
            this.txtREf.Validating += new System.ComponentModel.CancelEventHandler(this.txtREf_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "PO/SO Ref :";
            // 
            // txtDRDate
            // 
            this.txtDRDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDRDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDRDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDRDate.Location = new System.Drawing.Point(162, 36);
            this.txtDRDate.Name = "txtDRDate";
            this.txtDRDate.Size = new System.Drawing.Size(142, 20);
            this.txtDRDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "D.R Date :";
            // 
            // txtDRNo
            // 
            this.txtDRNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDRNo.Location = new System.Drawing.Point(10, 36);
            this.txtDRNo.Name = "txtDRNo";
            this.txtDRNo.Size = new System.Drawing.Size(136, 20);
            this.txtDRNo.TabIndex = 0;
            this.txtDRNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtDRNo_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DR No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTerms);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtaddress);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtCustName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCustCode);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTin);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(895, 116);
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
            this.txtTerms.Location = new System.Drawing.Point(161, 82);
            this.txtTerms.Name = "txtTerms";
            this.txtTerms.Size = new System.Drawing.Size(135, 21);
            this.txtTerms.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(159, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Terms :";
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(521, 37);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(359, 65);
            this.txtaddress.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(519, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 10;
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
            this.label9.TabIndex = 6;
            this.label9.Text = "Customer Name :";
            // 
            // txtCustCode
            // 
            this.txtCustCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCustCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustCode.FormattingEnabled = true;
            this.txtCustCode.Location = new System.Drawing.Point(11, 37);
            this.txtCustCode.Name = "txtCustCode";
            this.txtCustCode.Size = new System.Drawing.Size(135, 21);
            this.txtCustCode.TabIndex = 0;
            this.txtCustCode.SelectedValueChanged += new System.EventHandler(this.txtCustCode_SelectedValueChanged);
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
            this.txtTin.TabIndex = 9;
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
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
            this.colprodIndex,
            this.coldescription,
            this.colbatch,
            this.colExdate,
            this.colPack,
            this.colpcs,
            this.colcases});
            this.dataGridView1.Location = new System.Drawing.Point(3, 191);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Size = new System.Drawing.Size(895, 182);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // btnDeclare
            // 
            this.btnDeclare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeclare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(163)))));
            this.btnDeclare.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeclare.ForeColor = System.Drawing.Color.White;
            this.btnDeclare.Location = new System.Drawing.Point(775, 377);
            this.btnDeclare.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeclare.Name = "btnDeclare";
            this.btnDeclare.Size = new System.Drawing.Size(115, 40);
            this.btnDeclare.TabIndex = 3;
            this.btnDeclare.Text = "Save";
            this.btnDeclare.UseVisualStyleBackColor = false;
            this.btnDeclare.Click += new System.EventHandler(this.btnDeclare_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(656, 378);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 40);
            this.btnExit.TabIndex = 62;
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
            // 
            // colprodIndex
            // 
            this.colprodIndex.HeaderText = "Column1";
            this.colprodIndex.Name = "colprodIndex";
            this.colprodIndex.Visible = false;
            // 
            // coldescription
            // 
            this.coldescription.HeaderText = "Description";
            this.coldescription.Name = "coldescription";
            this.coldescription.ReadOnly = true;
            this.coldescription.Width = 250;
            // 
            // colbatch
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N2";
            this.colbatch.DefaultCellStyle = dataGridViewCellStyle2;
            this.colbatch.HeaderText = "Batch No";
            this.colbatch.Name = "colbatch";
            this.colbatch.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colExdate
            // 
            // 
            // 
            // 
            this.colExdate.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.colExdate.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colExdate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colExdate.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colExdate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colExdate.HeaderText = "Expiry Date";
            this.colExdate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            // 
            // 
            // 
            // 
            // 
            // 
            this.colExdate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colExdate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.colExdate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colExdate.MonthCalendar.DisplayMonth = new System.DateTime(2019, 2, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.colExdate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colExdate.Name = "colExdate";
            // 
            // colPack
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colPack.DefaultCellStyle = dataGridViewCellStyle4;
            this.colPack.HeaderText = "Pack Size";
            this.colPack.Name = "colPack";
            // 
            // colpcs
            // 
            // 
            // 
            // 
            this.colpcs.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.colpcs.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.colpcs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colpcs.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.colpcs.DefaultCellStyle = dataGridViewCellStyle5;
            this.colpcs.HeaderText = "PCS";
            this.colpcs.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.colpcs.Name = "colpcs";
            this.colpcs.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colcases
            // 
            // 
            // 
            // 
            this.colcases.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.colcases.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.colcases.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colcases.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colcases.DefaultCellStyle = dataGridViewCellStyle6;
            this.colcases.HeaderText = "Cases/Inner Box";
            this.colcases.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.colcases.Name = "colcases";
            this.colcases.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Dr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 424);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeclare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Dr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dr";
            this.Load += new System.EventHandler(this.Dr_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtTypeOfStocks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtREf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtDRDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDRNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtCustCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeclare;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox txtTerms;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colprodIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbatch;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colExdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPack;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colpcs;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn colcases;
    }
}