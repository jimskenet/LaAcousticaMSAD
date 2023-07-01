namespace LaAcoustica_Final
{
    partial class SalesHistory
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
            this.dailySale = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.invoice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saleS = new System.Windows.Forms.Label();
            this.dateS = new System.Windows.Forms.Label();
            this.invoiceNum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ref2 = new LaAcoustica_Final.CButton();
            this.filterInv = new LaAcoustica_Final.CButton();
            this.refresh = new LaAcoustica_Final.CButton();
            this.filter = new LaAcoustica_Final.CButton();
            ((System.ComponentModel.ISupportInitialize)(this.dailySale)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dailySale
            // 
            this.dailySale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailySale.Location = new System.Drawing.Point(26, 94);
            this.dailySale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dailySale.Name = "dailySale";
            this.dailySale.ReadOnly = true;
            this.dailySale.RowHeadersWidth = 51;
            this.dailySale.RowTemplate.Height = 24;
            this.dailySale.Size = new System.Drawing.Size(353, 522);
            this.dailySale.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "Sales History";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(74, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Monthly Sales History";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(546, 279);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 24);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // invoice
            // 
            this.invoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.invoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.invoice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoice.Location = new System.Drawing.Point(443, 94);
            this.invoice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.invoice.Multiline = true;
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(464, 31);
            this.invoice.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(440, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Search Invoice:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(543, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Filter Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(560, 375);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "to";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(546, 325);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(255, 24);
            this.dateTimePicker2.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(2, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 37;
            this.label6.Text = "Invoice:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saleS);
            this.panel1.Controls.Add(this.dateS);
            this.panel1.Controls.Add(this.invoiceNum);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(384, 458);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 80);
            this.panel1.TabIndex = 38;
            this.panel1.Visible = false;
            // 
            // saleS
            // 
            this.saleS.AutoSize = true;
            this.saleS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saleS.Location = new System.Drawing.Point(92, 58);
            this.saleS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.saleS.Name = "saleS";
            this.saleS.Size = new System.Drawing.Size(13, 19);
            this.saleS.TabIndex = 42;
            this.saleS.Text = " ";
            // 
            // dateS
            // 
            this.dateS.AutoSize = true;
            this.dateS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateS.Location = new System.Drawing.Point(92, 30);
            this.dateS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateS.Name = "dateS";
            this.dateS.Size = new System.Drawing.Size(13, 19);
            this.dateS.TabIndex = 41;
            this.dateS.Text = " ";
            // 
            // invoiceNum
            // 
            this.invoiceNum.AutoSize = true;
            this.invoiceNum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.invoiceNum.Location = new System.Drawing.Point(92, 0);
            this.invoiceNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.invoiceNum.Name = "invoiceNum";
            this.invoiceNum.Size = new System.Drawing.Size(13, 19);
            this.invoiceNum.TabIndex = 40;
            this.invoiceNum.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(2, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 19);
            this.label8.TabIndex = 39;
            this.label8.Text = "Sale:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(2, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "Date:";
            // 
            // ref2
            // 
            this.ref2.BackColor = System.Drawing.Color.White;
            this.ref2.BackgroundColor = System.Drawing.Color.White;
            this.ref2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ref2.BorderRadius = 20;
            this.ref2.BorderSize = 0;
            this.ref2.FlatAppearance.BorderSize = 0;
            this.ref2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ref2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ref2.ForeColor = System.Drawing.Color.DarkRed;
            this.ref2.Location = new System.Drawing.Point(712, 139);
            this.ref2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ref2.Name = "ref2";
            this.ref2.Size = new System.Drawing.Size(118, 59);
            this.ref2.TabIndex = 36;
            this.ref2.Text = "Refresh";
            this.ref2.TextColor = System.Drawing.Color.DarkRed;
            this.ref2.UseVisualStyleBackColor = false;
            this.ref2.Click += new System.EventHandler(this.ref2_Click);
            // 
            // filterInv
            // 
            this.filterInv.BackColor = System.Drawing.Color.White;
            this.filterInv.BackgroundColor = System.Drawing.Color.White;
            this.filterInv.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.filterInv.BorderRadius = 20;
            this.filterInv.BorderSize = 0;
            this.filterInv.FlatAppearance.BorderSize = 0;
            this.filterInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterInv.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterInv.ForeColor = System.Drawing.Color.DarkRed;
            this.filterInv.Location = new System.Drawing.Point(546, 139);
            this.filterInv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterInv.Name = "filterInv";
            this.filterInv.Size = new System.Drawing.Size(118, 59);
            this.filterInv.TabIndex = 35;
            this.filterInv.Text = "Filter";
            this.filterInv.TextColor = System.Drawing.Color.DarkRed;
            this.filterInv.UseVisualStyleBackColor = false;
            this.filterInv.Click += new System.EventHandler(this.filterInv_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.White;
            this.refresh.BackgroundColor = System.Drawing.Color.White;
            this.refresh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.refresh.BorderRadius = 20;
            this.refresh.BorderSize = 0;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.DarkRed;
            this.refresh.Location = new System.Drawing.Point(682, 363);
            this.refresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(118, 59);
            this.refresh.TabIndex = 34;
            this.refresh.Text = "Refresh";
            this.refresh.TextColor = System.Drawing.Color.DarkRed;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // filter
            // 
            this.filter.BackColor = System.Drawing.Color.White;
            this.filter.BackgroundColor = System.Drawing.Color.White;
            this.filter.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.filter.BorderRadius = 20;
            this.filter.BorderSize = 0;
            this.filter.FlatAppearance.BorderSize = 0;
            this.filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.ForeColor = System.Drawing.Color.DarkRed;
            this.filter.Location = new System.Drawing.Point(546, 363);
            this.filter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(118, 59);
            this.filter.TabIndex = 33;
            this.filter.Text = "Filter";
            this.filter.TextColor = System.Drawing.Color.DarkRed;
            this.filter.UseVisualStyleBackColor = false;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // SalesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(948, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ref2);
            this.Controls.Add(this.filterInv);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.invoice);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dailySale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(948, 638);
            this.Name = "SalesHistory";
            this.Text = "SalesHistory";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaleHistory_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SaleHistory_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SaleHistory_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dailySale)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dailySale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox invoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private CButton filter;
        private CButton refresh;
        private CButton filterInv;
        private CButton ref2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label saleS;
        private System.Windows.Forms.Label dateS;
        private System.Windows.Forms.Label invoiceNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}