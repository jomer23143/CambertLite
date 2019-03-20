namespace Cambert.Reports.Extracopy
{
    partial class ExtraDRCopy
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
            this.btnDeclare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxchoose = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdr = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDeclare
            // 
            this.btnDeclare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeclare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(163)))));
            this.btnDeclare.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeclare.ForeColor = System.Drawing.Color.White;
            this.btnDeclare.Location = new System.Drawing.Point(233, 116);
            this.btnDeclare.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeclare.Name = "btnDeclare";
            this.btnDeclare.Size = new System.Drawing.Size(115, 40);
            this.btnDeclare.TabIndex = 7;
            this.btnDeclare.Text = "Preview";
            this.btnDeclare.UseVisualStyleBackColor = false;
            this.btnDeclare.Click += new System.EventHandler(this.btnDeclare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "DR No :";
            // 
            // cbxchoose
            // 
            this.cbxchoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxchoose.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxchoose.FormattingEnabled = true;
            this.cbxchoose.Items.AddRange(new object[] {
            "Regular Copy",
            "Extra Copy"});
            this.cbxchoose.Location = new System.Drawing.Point(144, 32);
            this.cbxchoose.Name = "cbxchoose";
            this.cbxchoose.Size = new System.Drawing.Size(202, 29);
            this.cbxchoose.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose :";
            // 
            // txtdr
            // 
            this.txtdr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtdr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtdr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdr.FormattingEnabled = true;
            this.txtdr.Location = new System.Drawing.Point(144, 76);
            this.txtdr.Name = "txtdr";
            this.txtdr.Size = new System.Drawing.Size(202, 27);
            this.txtdr.TabIndex = 10;
            // 
            // ExtraDRCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 173);
            this.Controls.Add(this.txtdr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxchoose);
            this.Controls.Add(this.btnDeclare);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExtraDRCopy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Reports";
            this.Load += new System.EventHandler(this.ExtraDRCopy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeclare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxchoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtdr;
    }
}