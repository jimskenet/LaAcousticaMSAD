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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wsales = new System.Windows.Forms.TextBox();
            this.dsales = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.revenue = new System.Windows.Forms.TextBox();
            this.msales = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.monthlySale = new System.Windows.Forms.DataGridView();
            this.weeklySale = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlySale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklySale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Current Day Sales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(31, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Current Week Sales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(31, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Current Month Sales";
            // 
            // wsales
            // 
            this.wsales.BackColor = System.Drawing.Color.White;
            this.wsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wsales.ForeColor = System.Drawing.Color.Red;
            this.wsales.Location = new System.Drawing.Point(34, 157);
            this.wsales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wsales.Multiline = true;
            this.wsales.Name = "wsales";
            this.wsales.ReadOnly = true;
            this.wsales.Size = new System.Drawing.Size(410, 54);
            this.wsales.TabIndex = 1;
            this.wsales.Text = "0";
            this.wsales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dsales
            // 
            this.dsales.BackColor = System.Drawing.Color.White;
            this.dsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsales.ForeColor = System.Drawing.Color.Red;
            this.dsales.Location = new System.Drawing.Point(34, 72);
            this.dsales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dsales.Multiline = true;
            this.dsales.Name = "dsales";
            this.dsales.ReadOnly = true;
            this.dsales.Size = new System.Drawing.Size(410, 54);
            this.dsales.TabIndex = 0;
            this.dsales.Text = "0";
            this.dsales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(490, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Overall Revenue:";
            // 
            // revenue
            // 
            this.revenue.BackColor = System.Drawing.Color.White;
            this.revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenue.ForeColor = System.Drawing.Color.DarkRed;
            this.revenue.Location = new System.Drawing.Point(494, 84);
            this.revenue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.revenue.Multiline = true;
            this.revenue.Name = "revenue";
            this.revenue.ReadOnly = true;
            this.revenue.Size = new System.Drawing.Size(432, 62);
            this.revenue.TabIndex = 2;
            this.revenue.Text = "\r\n";
            this.revenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msales
            // 
            this.msales.BackColor = System.Drawing.Color.White;
            this.msales.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msales.ForeColor = System.Drawing.Color.Red;
            this.msales.Location = new System.Drawing.Point(34, 254);
            this.msales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msales.Multiline = true;
            this.msales.Name = "msales";
            this.msales.ReadOnly = true;
            this.msales.Size = new System.Drawing.Size(410, 54);
            this.msales.TabIndex = 2;
            this.msales.Text = "0";
            this.msales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(699, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Monthly Revenue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 232);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 372);
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
            this.label7.Location = new System.Drawing.Point(130, 493);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 32);
            this.label7.TabIndex = 26;
            this.label7.Text = "Sales Report";
            // 
            // monthlySale
            // 
            this.monthlySale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthlySale.Location = new System.Drawing.Point(702, 213);
            this.monthlySale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.monthlySale.Name = "monthlySale";
            this.monthlySale.ReadOnly = true;
            this.monthlySale.RowHeadersWidth = 51;
            this.monthlySale.RowTemplate.Height = 24;
            this.monthlySale.Size = new System.Drawing.Size(237, 356);
            this.monthlySale.TabIndex = 28;
            // 
            // weeklySale
            // 
            this.weeklySale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeklySale.Location = new System.Drawing.Point(460, 213);
            this.weeklySale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weeklySale.Name = "weeklySale";
            this.weeklySale.ReadOnly = true;
            this.weeklySale.RowHeadersWidth = 51;
            this.weeklySale.RowTemplate.Height = 24;
            this.weeklySale.Size = new System.Drawing.Size(237, 176);
            this.weeklySale.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(458, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Weekly Revenue";
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(948, 638);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthlySale);
            this.Controls.Add(this.weeklySale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dsales);
            this.Controls.Add(this.wsales);
            this.Controls.Add(this.msales);
            this.Controls.Add(this.revenue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Sale";
            this.Text = "Sale";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sale_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Sale_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Sale_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlySale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklySale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dsales;
        private System.Windows.Forms.TextBox wsales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox revenue;
        private System.Windows.Forms.TextBox msales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView monthlySale;
        private System.Windows.Forms.DataGridView weeklySale;
        private System.Windows.Forms.Label label4;
    }
}