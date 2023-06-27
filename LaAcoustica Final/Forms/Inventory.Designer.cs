namespace LaAcoustica_Final
{
    partial class Inventory
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
            this.storageData = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refresh = new LaAcoustica_Final.CButton();
            this.label10 = new System.Windows.Forms.Label();
            this.clear = new LaAcoustica_Final.CButton();
            this.Scategory = new System.Windows.Forms.TextBox();
            this.categoryT = new System.Windows.Forms.TextBox();
            this.brand = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prod = new System.Windows.Forms.TextBox();
            this.delete = new LaAcoustica_Final.CButton();
            this.edit = new LaAcoustica_Final.CButton();
            this.add = new LaAcoustica_Final.CButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.brandN = new System.Windows.Forms.ComboBox();
            this.subcategory = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.storageData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // storageData
            // 
            this.storageData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.storageData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storageData.Location = new System.Drawing.Point(406, 130);
            this.storageData.Name = "storageData";
            this.storageData.ReadOnly = true;
            this.storageData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.storageData.RowTemplate.Height = 24;
            this.storageData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.storageData.Size = new System.Drawing.Size(846, 643);
            this.storageData.TabIndex = 2;
            this.storageData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow);
            this.storageData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.row);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.Scategory);
            this.panel1.Controls.Add(this.categoryT);
            this.panel1.Controls.Add(this.brand);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.prod);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.edit);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 785);
            this.panel1.TabIndex = 23;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refresh.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refresh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.refresh.BorderRadius = 20;
            this.refresh.BorderSize = 0;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.Maroon;
            this.refresh.Location = new System.Drawing.Point(246, 670);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(113, 66);
            this.refresh.TabIndex = 40;
            this.refresh.Text = "Refresh";
            this.refresh.TextColor = System.Drawing.Color.Maroon;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 40);
            this.label10.TabIndex = 39;
            this.label10.Text = "INVENTORY";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.clear.BorderRadius = 20;
            this.clear.BorderSize = 0;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.Maroon;
            this.clear.Location = new System.Drawing.Point(120, 670);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(120, 66);
            this.clear.TabIndex = 38;
            this.clear.Text = "Clear";
            this.clear.TextColor = System.Drawing.Color.Maroon;
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Scategory
            // 
            this.Scategory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scategory.Location = new System.Drawing.Point(19, 383);
            this.Scategory.Multiline = true;
            this.Scategory.Name = "Scategory";
            this.Scategory.Size = new System.Drawing.Size(340, 38);
            this.Scategory.TabIndex = 37;
            // 
            // categoryT
            // 
            this.categoryT.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryT.Location = new System.Drawing.Point(19, 308);
            this.categoryT.Multiline = true;
            this.categoryT.Name = "categoryT";
            this.categoryT.Size = new System.Drawing.Size(340, 38);
            this.categoryT.TabIndex = 36;
            // 
            // brand
            // 
            this.brand.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand.Location = new System.Drawing.Point(19, 156);
            this.brand.Multiline = true;
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(340, 38);
            this.brand.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(15, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Sub-Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(15, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Category";
            // 
            // prod
            // 
            this.prod.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod.Location = new System.Drawing.Point(19, 231);
            this.prod.Multiline = true;
            this.prod.Name = "prod";
            this.prod.Size = new System.Drawing.Size(340, 38);
            this.prod.TabIndex = 32;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.delete.BorderRadius = 20;
            this.delete.BorderSize = 0;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.Maroon;
            this.delete.Location = new System.Drawing.Point(246, 598);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(113, 66);
            this.delete.TabIndex = 31;
            this.delete.Text = "Delete";
            this.delete.TextColor = System.Drawing.Color.Maroon;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.edit.BorderRadius = 20;
            this.edit.BorderSize = 0;
            this.edit.FlatAppearance.BorderSize = 0;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.Maroon;
            this.edit.Location = new System.Drawing.Point(120, 598);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(120, 66);
            this.edit.TabIndex = 30;
            this.edit.Text = "Edit";
            this.edit.TextColor = System.Drawing.Color.Maroon;
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.add.BorderRadius = 20;
            this.add.BorderSize = 0;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.Maroon;
            this.add.Location = new System.Drawing.Point(14, 598);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 66);
            this.add.TabIndex = 29;
            this.add.Text = "Add";
            this.add.TextColor = System.Drawing.Color.Maroon;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(15, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(15, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(15, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Product Name";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(19, 538);
            this.price.Multiline = true;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(340, 38);
            this.price.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(15, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Instrument Brand";
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(19, 459);
            this.quantity.Multiline = true;
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(340, 38);
            this.quantity.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(420, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 23);
            this.label7.TabIndex = 39;
            this.label7.Text = "Instrument Brand";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(722, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 23);
            this.label8.TabIndex = 40;
            this.label8.Text = "Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(985, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 23);
            this.label9.TabIndex = 41;
            this.label9.Text = "Sub-Category";
            // 
            // brandN
            // 
            this.brandN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.brandN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandN.ForeColor = System.Drawing.Color.Maroon;
            this.brandN.FormattingEnabled = true;
            this.brandN.Items.AddRange(new object[] {
            "Squire",
            "Valencia ",
            "Mahalo",
            "Jackson",
            "Gretsch",
            "Fender",
            "Fernando",
            "Zoom",
            "Laney",
            "RockJam",
            "Aguilar",
            "Marshall",
            "Pearl",
            "Gibraltar",
            "Remo",
            "Zildjian",
            "Alesis",
            "M-Audio",
            "Novation",
            "Akai"});
            this.brandN.Location = new System.Drawing.Point(424, 77);
            this.brandN.Name = "brandN";
            this.brandN.Size = new System.Drawing.Size(248, 24);
            this.brandN.TabIndex = 42;
            this.brandN.SelectionChangeCommitted += new System.EventHandler(this.FilterData);
            // 
            // subcategory
            // 
            this.subcategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subcategory.ForeColor = System.Drawing.Color.Maroon;
            this.subcategory.FormattingEnabled = true;
            this.subcategory.Items.AddRange(new object[] {
            "Bass Guitar",
            "Electric Guitar",
            "Acoustic Guitar",
            "Ukulele",
            "Guitar Amplifier",
            "Bass Amplifier",
            "Drum Essentials",
            "Accessories",
            "Drum Kits",
            "Percussions",
            "Cymbals",
            "Digital Pianos",
            "MIDI Controllers",
            "Earphones",
            "Speaker"});
            this.subcategory.Location = new System.Drawing.Point(989, 77);
            this.subcategory.Name = "subcategory";
            this.subcategory.Size = new System.Drawing.Size(224, 24);
            this.subcategory.TabIndex = 43;
            this.subcategory.SelectionChangeCommitted += new System.EventHandler(this.FilterData);
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.WhiteSmoke;
            this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category.ForeColor = System.Drawing.Color.Maroon;
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Guitar",
            "Amplifier",
            "Drums",
            "Keyboards",
            "Others"});
            this.category.Location = new System.Drawing.Point(726, 77);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(224, 24);
            this.category.TabIndex = 44;
            this.category.SelectionChangeCommitted += new System.EventHandler(this.FilterData);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1264, 785);
            this.Controls.Add(this.category);
            this.Controls.Add(this.subcategory);
            this.Controls.Add(this.brandN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.storageData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.storageData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView storageData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private CButton clear;
        private System.Windows.Forms.TextBox Scategory;
        private System.Windows.Forms.TextBox categoryT;
        private System.Windows.Forms.TextBox brand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prod;
        private CButton delete;
        private CButton edit;
        private CButton add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox brandN;
        private System.Windows.Forms.ComboBox subcategory;
        private System.Windows.Forms.ComboBox category;
        private CButton refresh;
    }
}