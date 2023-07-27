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
            this.label12 = new System.Windows.Forms.Label();
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
            this.brand_txt = new System.Windows.Forms.TextBox();
            this.cat_txt = new System.Windows.Forms.TextBox();
            this.subcat_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.storageData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // storageData
            // 
            this.storageData.AllowUserToAddRows = false;
            this.storageData.AllowUserToDeleteRows = false;
            this.storageData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storageData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storageData.Location = new System.Drawing.Point(304, 106);
            this.storageData.Margin = new System.Windows.Forms.Padding(2);
            this.storageData.Name = "storageData";
            this.storageData.ReadOnly = true;
            this.storageData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.storageData.RowTemplate.Height = 24;
            this.storageData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.storageData.Size = new System.Drawing.Size(634, 522);
            this.storageData.TabIndex = 2;
            this.storageData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow);
            this.storageData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.row);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label12);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 638);
            this.panel1.TabIndex = 23;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Inventory_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Inventory_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Inventory_MouseUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(11, 72);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 21);
            this.label12.TabIndex = 50;
            this.label12.Text = "INFORMATION DISPLAY";
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
            this.refresh.Location = new System.Drawing.Point(184, 544);
            this.refresh.Margin = new System.Windows.Forms.Padding(2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(85, 54);
            this.refresh.TabIndex = 40;
            this.refresh.Text = "Refresh";
            this.refresh.TextColor = System.Drawing.Color.Maroon;
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(9, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 33);
            this.label10.TabIndex = 39;
            this.label10.Text = "INVENTORY";
            this.label10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Inventory_MouseDown);
            this.label10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Inventory_MouseMove);
            this.label10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Inventory_MouseUp);
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
            this.clear.Location = new System.Drawing.Point(90, 544);
            this.clear.Margin = new System.Windows.Forms.Padding(2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(90, 54);
            this.clear.TabIndex = 38;
            this.clear.Text = "Clear";
            this.clear.TextColor = System.Drawing.Color.Maroon;
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Scategory
            // 
            this.Scategory.Enabled = false;
            this.Scategory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scategory.Location = new System.Drawing.Point(14, 311);
            this.Scategory.Margin = new System.Windows.Forms.Padding(2);
            this.Scategory.Multiline = true;
            this.Scategory.Name = "Scategory";
            this.Scategory.Size = new System.Drawing.Size(256, 32);
            this.Scategory.TabIndex = 37;
            // 
            // categoryT
            // 
            this.categoryT.Enabled = false;
            this.categoryT.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryT.Location = new System.Drawing.Point(14, 250);
            this.categoryT.Margin = new System.Windows.Forms.Padding(2);
            this.categoryT.Multiline = true;
            this.categoryT.Name = "categoryT";
            this.categoryT.Size = new System.Drawing.Size(256, 32);
            this.categoryT.TabIndex = 36;
            // 
            // brand
            // 
            this.brand.Enabled = false;
            this.brand.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand.Location = new System.Drawing.Point(14, 127);
            this.brand.Margin = new System.Windows.Forms.Padding(2);
            this.brand.Multiline = true;
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(256, 32);
            this.brand.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(11, 290);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "Sub-Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(11, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Category";
            // 
            // prod
            // 
            this.prod.Enabled = false;
            this.prod.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod.Location = new System.Drawing.Point(14, 188);
            this.prod.Margin = new System.Windows.Forms.Padding(2);
            this.prod.Multiline = true;
            this.prod.Name = "prod";
            this.prod.Size = new System.Drawing.Size(256, 39);
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
            this.delete.Location = new System.Drawing.Point(184, 486);
            this.delete.Margin = new System.Windows.Forms.Padding(2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(85, 54);
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
            this.edit.Location = new System.Drawing.Point(90, 486);
            this.edit.Margin = new System.Windows.Forms.Padding(2);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(90, 54);
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
            this.add.Location = new System.Drawing.Point(10, 486);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 54);
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
            this.label4.Location = new System.Drawing.Point(11, 416);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(11, 352);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(11, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Product Name";
            // 
            // price
            // 
            this.price.Enabled = false;
            this.price.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(14, 437);
            this.price.Margin = new System.Windows.Forms.Padding(2);
            this.price.Multiline = true;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(256, 32);
            this.price.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(11, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Instrument Brand";
            // 
            // quantity
            // 
            this.quantity.Enabled = false;
            this.quantity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(14, 373);
            this.quantity.Margin = new System.Windows.Forms.Padding(2);
            this.quantity.Multiline = true;
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(256, 32);
            this.quantity.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(382, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 21);
            this.label7.TabIndex = 39;
            this.label7.Text = "Instrument Brand";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(574, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(764, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 21);
            this.label9.TabIndex = 41;
            this.label9.Text = "Sub-Category";
            // 
            // brand_txt
            // 
            this.brand_txt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand_txt.Location = new System.Drawing.Point(386, 72);
            this.brand_txt.Margin = new System.Windows.Forms.Padding(2);
            this.brand_txt.Multiline = true;
            this.brand_txt.Name = "brand_txt";
            this.brand_txt.Size = new System.Drawing.Size(169, 21);
            this.brand_txt.TabIndex = 45;
            this.brand_txt.TextChanged += new System.EventHandler(this.brand_txt_TextChanged);
            // 
            // cat_txt
            // 
            this.cat_txt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat_txt.Location = new System.Drawing.Point(578, 72);
            this.cat_txt.Margin = new System.Windows.Forms.Padding(2);
            this.cat_txt.Multiline = true;
            this.cat_txt.Name = "cat_txt";
            this.cat_txt.Size = new System.Drawing.Size(169, 21);
            this.cat_txt.TabIndex = 46;
            this.cat_txt.TextChanged += new System.EventHandler(this.cat_txt_TextChanged);
            // 
            // subcat_txt
            // 
            this.subcat_txt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subcat_txt.Location = new System.Drawing.Point(768, 72);
            this.subcat_txt.Margin = new System.Windows.Forms.Padding(2);
            this.subcat_txt.Multiline = true;
            this.subcat_txt.Name = "subcat_txt";
            this.subcat_txt.Size = new System.Drawing.Size(169, 21);
            this.subcat_txt.TabIndex = 47;
            this.subcat_txt.TextChanged += new System.EventHandler(this.subcat_txt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(304, 42);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 21);
            this.label11.TabIndex = 48;
            this.label11.Text = "ID";
            // 
            // id_txt
            // 
            this.id_txt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txt.Location = new System.Drawing.Point(306, 72);
            this.id_txt.Margin = new System.Windows.Forms.Padding(2);
            this.id_txt.Multiline = true;
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(56, 21);
            this.id_txt.TabIndex = 49;
            this.id_txt.TextChanged += new System.EventHandler(this.id_txt_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(304, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 21);
            this.label13.TabIndex = 51;
            this.label13.Text = "Search Inventory";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(948, 638);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.subcat_txt);
            this.Controls.Add(this.cat_txt);
            this.Controls.Add(this.brand_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.storageData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Inventory_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Inventory_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Inventory_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.storageData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private CButton refresh;
        protected internal System.Windows.Forms.DataGridView storageData;
        private System.Windows.Forms.TextBox brand_txt;
        private System.Windows.Forms.TextBox cat_txt;
        private System.Windows.Forms.TextBox subcat_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}