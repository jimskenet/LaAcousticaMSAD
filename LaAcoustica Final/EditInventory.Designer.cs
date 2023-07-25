namespace LaAcoustica_Final
{
    partial class EditInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditInventory));
            this.exit = new System.Windows.Forms.PictureBox();
            this.min = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Scategory = new System.Windows.Forms.TextBox();
            this.categoryT = new System.Windows.Forms.TextBox();
            this.brand = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edit = new LaAcoustica_Final.CButton();
            this.cButton1 = new LaAcoustica_Final.CButton();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(243, 11);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(23, 24);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 73;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // min
            // 
            this.min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min.BackColor = System.Drawing.Color.Transparent;
            this.min.Image = ((System.Drawing.Image)(resources.GetObject("min.Image")));
            this.min.Location = new System.Drawing.Point(216, 11);
            this.min.Margin = new System.Windows.Forms.Padding(2);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(23, 24);
            this.min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.min.TabIndex = 74;
            this.min.TabStop = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(14, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 33);
            this.label7.TabIndex = 72;
            this.label7.Text = "EDIT";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Inventory_MouseDown);
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Inventory_MouseMove);
            this.label7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Inventory_MouseUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(13, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 33);
            this.label10.TabIndex = 71;
            this.label10.Text = "INVENTORY";
            this.label10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Inventory_MouseDown);
            this.label10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Inventory_MouseMove);
            this.label10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Inventory_MouseUp);
            // 
            // Scategory
            // 
            this.Scategory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scategory.Location = new System.Drawing.Point(19, 350);
            this.Scategory.Margin = new System.Windows.Forms.Padding(2);
            this.Scategory.Multiline = true;
            this.Scategory.Name = "Scategory";
            this.Scategory.Size = new System.Drawing.Size(256, 32);
            this.Scategory.TabIndex = 70;
            // 
            // categoryT
            // 
            this.categoryT.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryT.Location = new System.Drawing.Point(19, 289);
            this.categoryT.Margin = new System.Windows.Forms.Padding(2);
            this.categoryT.Multiline = true;
            this.categoryT.Name = "categoryT";
            this.categoryT.Size = new System.Drawing.Size(256, 32);
            this.categoryT.TabIndex = 69;
            // 
            // brand
            // 
            this.brand.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand.Location = new System.Drawing.Point(19, 166);
            this.brand.Margin = new System.Windows.Forms.Padding(2);
            this.brand.Multiline = true;
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(256, 32);
            this.brand.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(16, 329);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 67;
            this.label6.Text = "Sub-Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(16, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 66;
            this.label5.Text = "Category";
            // 
            // prod
            // 
            this.prod.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod.Location = new System.Drawing.Point(19, 227);
            this.prod.Margin = new System.Windows.Forms.Padding(2);
            this.prod.Multiline = true;
            this.prod.Name = "prod";
            this.prod.Size = new System.Drawing.Size(256, 39);
            this.prod.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(16, 455);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 64;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(16, 391);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 63;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(16, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "Product Name";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(19, 476);
            this.price.Margin = new System.Windows.Forms.Padding(2);
            this.price.Multiline = true;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(256, 32);
            this.price.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(16, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 60;
            this.label1.Text = "Instrument Brand";
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(19, 412);
            this.quantity.Margin = new System.Windows.Forms.Padding(2);
            this.quantity.Multiline = true;
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(256, 32);
            this.quantity.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.cButton1);
            this.panel1.Controls.Add(this.edit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 638);
            this.panel1.TabIndex = 77;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Inventory_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Inventory_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Inventory_MouseUp);
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
            this.edit.Location = new System.Drawing.Point(91, 534);
            this.edit.Margin = new System.Windows.Forms.Padding(2);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(90, 54);
            this.edit.TabIndex = 78;
            this.edit.Text = "Edit";
            this.edit.TextColor = System.Drawing.Color.Maroon;
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // cButton1
            // 
            this.cButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cButton1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cButton1.BorderRadius = 20;
            this.cButton1.BorderSize = 0;
            this.cButton1.FlatAppearance.BorderSize = 0;
            this.cButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cButton1.ForeColor = System.Drawing.Color.Maroon;
            this.cButton1.Location = new System.Drawing.Point(185, 534);
            this.cButton1.Margin = new System.Windows.Forms.Padding(2);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(90, 54);
            this.cButton1.TabIndex = 78;
            this.cButton1.Text = "Clear";
            this.cButton1.TextColor = System.Drawing.Color.Maroon;
            this.cButton1.UseVisualStyleBackColor = false;
            this.cButton1.Click += new System.EventHandler(this.cButton1_Click);
            // 
            // EditInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 638);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.min);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Scategory);
            this.Controls.Add(this.categoryT);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditInventory";
            this.Text = "EditInventory";
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox min;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Scategory;
        private System.Windows.Forms.TextBox categoryT;
        private System.Windows.Forms.TextBox brand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Panel panel1;
        private CButton edit;
        private CButton cButton1;
    }
}