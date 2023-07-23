namespace LaAcoustica_Final
{
    partial class Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ysales = new System.Windows.Forms.TextBox();
            this.dsales = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.revenue = new System.Windows.Forms.TextBox();
            this.msales = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.monthlySale = new System.Windows.Forms.DataGridView();
            this.YearlySale = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.SalesReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.filter_report = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlySale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearlySale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(41, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Current Day Sales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(41, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Current Monthly Sales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(41, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Current Year Sales";
            // 
            // ysales
            // 
            this.ysales.BackColor = System.Drawing.Color.White;
            this.ysales.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ysales.ForeColor = System.Drawing.Color.Red;
            this.ysales.Location = new System.Drawing.Point(45, 301);
            this.ysales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ysales.Multiline = true;
            this.ysales.Name = "ysales";
            this.ysales.ReadOnly = true;
            this.ysales.Size = new System.Drawing.Size(545, 66);
            this.ysales.TabIndex = 1;
            this.ysales.Text = "0";
            this.ysales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dsales
            // 
            this.dsales.BackColor = System.Drawing.Color.White;
            this.dsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsales.ForeColor = System.Drawing.Color.Red;
            this.dsales.Location = new System.Drawing.Point(45, 89);
            this.dsales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dsales.Multiline = true;
            this.dsales.Name = "dsales";
            this.dsales.ReadOnly = true;
            this.dsales.Size = new System.Drawing.Size(545, 66);
            this.dsales.TabIndex = 0;
            this.dsales.Text = "0";
            this.dsales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(653, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 34);
            this.label5.TabIndex = 23;
            this.label5.Text = "Overall Revenue:";
            // 
            // revenue
            // 
            this.revenue.BackColor = System.Drawing.Color.White;
            this.revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenue.ForeColor = System.Drawing.Color.DarkRed;
            this.revenue.Location = new System.Drawing.Point(659, 103);
            this.revenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.revenue.Multiline = true;
            this.revenue.Name = "revenue";
            this.revenue.ReadOnly = true;
            this.revenue.Size = new System.Drawing.Size(575, 75);
            this.revenue.TabIndex = 2;
            this.revenue.Text = "\r\n";
            this.revenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msales
            // 
            this.msales.BackColor = System.Drawing.Color.White;
            this.msales.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msales.ForeColor = System.Drawing.Color.Red;
            this.msales.Location = new System.Drawing.Point(45, 192);
            this.msales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msales.Multiline = true;
            this.msales.Name = "msales";
            this.msales.ReadOnly = true;
            this.msales.Size = new System.Drawing.Size(545, 66);
            this.msales.TabIndex = 2;
            this.msales.Text = "0";
            this.msales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(932, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Monthly Revenue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 415);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sale_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Sale_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sale_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(183, 661);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 39);
            this.label7.TabIndex = 26;
            this.label7.Text = "Sales Report";
            // 
            // monthlySale
            // 
            this.monthlySale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthlySale.Location = new System.Drawing.Point(936, 213);
            this.monthlySale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthlySale.Name = "monthlySale";
            this.monthlySale.ReadOnly = true;
            this.monthlySale.RowHeadersWidth = 51;
            this.monthlySale.RowTemplate.Height = 24;
            this.monthlySale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.monthlySale.Size = new System.Drawing.Size(299, 217);
            this.monthlySale.TabIndex = 28;
            // 
            // YearlySale
            // 
            this.YearlySale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YearlySale.Location = new System.Drawing.Point(613, 213);
            this.YearlySale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YearlySale.Name = "YearlySale";
            this.YearlySale.ReadOnly = true;
            this.YearlySale.RowHeadersWidth = 51;
            this.YearlySale.RowTemplate.Height = 24;
            this.YearlySale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.YearlySale.Size = new System.Drawing.Size(316, 217);
            this.YearlySale.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(611, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Yearly Revenue";
            // 
            // SalesReport
            // 
            chartArea1.Name = "ChartArea1";
            this.SalesReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SalesReport.Legends.Add(legend1);
            this.SalesReport.Location = new System.Drawing.Point(592, 474);
            this.SalesReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SalesReport.Name = "SalesReport";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Sales";
            this.SalesReport.Series.Add(series1);
            this.SalesReport.Size = new System.Drawing.Size(483, 293);
            this.SalesReport.TabIndex = 30;
            this.SalesReport.Text = "SalesChart";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(589, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 23);
            this.label8.TabIndex = 31;
            this.label8.Text = "Sales Chart";
            // 
            // filter_report
            // 
            this.filter_report.FormattingEnabled = true;
            this.filter_report.Items.AddRange(new object[] {
            "Monthly",
            "Yearly"});
            this.filter_report.Location = new System.Drawing.Point(1103, 503);
            this.filter_report.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filter_report.Name = "filter_report";
            this.filter_report.Size = new System.Drawing.Size(131, 24);
            this.filter_report.TabIndex = 32;
            this.filter_report.SelectedIndexChanged += new System.EventHandler(this.Sale_Load);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(1081, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 23);
            this.label9.TabIndex = 33;
            this.label9.Text = "Select Report";
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1264, 785);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.filter_report);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SalesReport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthlySale);
            this.Controls.Add(this.YearlySale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dsales);
            this.Controls.Add(this.ysales);
            this.Controls.Add(this.msales);
            this.Controls.Add(this.revenue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sale";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sale_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Sale_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sale_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlySale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearlySale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dsales;
        private System.Windows.Forms.TextBox ysales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox revenue;
        private System.Windows.Forms.TextBox msales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView monthlySale;
        private System.Windows.Forms.DataGridView YearlySale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart SalesReport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox filter_report;
        private System.Windows.Forms.Label label9;
    }
}