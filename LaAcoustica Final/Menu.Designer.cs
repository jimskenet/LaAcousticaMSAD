namespace LaAcoustica_Final
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.min = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.logout = new FontAwesome.Sharp.IconButton();
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.employee = new FontAwesome.Sharp.IconButton();
            this.inventory = new FontAwesome.Sharp.IconButton();
            this.PnlSales = new System.Windows.Forms.Panel();
            this.SalesHis = new FontAwesome.Sharp.IconButton();
            this.SalesRep = new FontAwesome.Sharp.IconButton();
            this.sale = new FontAwesome.Sharp.IconButton();
            this.home = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roundPicture1 = new LaAcoustica_Final.Forms.RoundPicture();
            this.panelChildform = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.PnlSales.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1164, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(1207, 2);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(48, 34);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 3;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.Transparent;
            this.min.Image = ((System.Drawing.Image)(resources.GetObject("min.Image")));
            this.min.Location = new System.Drawing.Point(1109, 2);
            this.min.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(49, 34);
            this.min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.min.TabIndex = 5;
            this.min.TabStop = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Controls.Add(this.min);
            this.panel3.Controls.Add(this.exit);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(285, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1264, 49);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseUp);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logout.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.logout.IconColor = System.Drawing.Color.LightGray;
            this.logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logout.IconSize = 40;
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(0, 764);
            this.logout.Margin = new System.Windows.Forms.Padding(0);
            this.logout.Name = "logout";
            this.logout.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.logout.Size = new System.Drawing.Size(285, 70);
            this.logout.TabIndex = 8;
            this.logout.Text = "Logout";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Gold;
            this.name.Location = new System.Drawing.Point(0, 249);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(285, 36);
            this.name.TabIndex = 6;
            this.name.Text = ".";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.employee);
            this.panel5.Controls.Add(this.inventory);
            this.panel5.Controls.Add(this.PnlSales);
            this.panel5.Location = new System.Drawing.Point(0, 405);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(289, 356);
            this.panel5.TabIndex = 12;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.panel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseUp);
            // 
            // employee
            // 
            this.employee.BackColor = System.Drawing.Color.Transparent;
            this.employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.employee.FlatAppearance.BorderSize = 0;
            this.employee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employee.IconChar = FontAwesome.Sharp.IconChar.User;
            this.employee.IconColor = System.Drawing.Color.LightGray;
            this.employee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.employee.IconSize = 40;
            this.employee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employee.Location = new System.Drawing.Point(0, 85);
            this.employee.Margin = new System.Windows.Forms.Padding(0);
            this.employee.Name = "employee";
            this.employee.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.employee.Size = new System.Drawing.Size(289, 85);
            this.employee.TabIndex = 7;
            this.employee.Text = "Accounts";
            this.employee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.employee.UseVisualStyleBackColor = false;
            this.employee.Click += new System.EventHandler(this.employee_Click);
            this.employee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.employee.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.employee.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseUp);
            // 
            // inventory
            // 
            this.inventory.BackColor = System.Drawing.Color.Transparent;
            this.inventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventory.FlatAppearance.BorderSize = 0;
            this.inventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inventory.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.inventory.IconColor = System.Drawing.Color.LightGray;
            this.inventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.inventory.IconSize = 40;
            this.inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventory.Location = new System.Drawing.Point(0, 0);
            this.inventory.Margin = new System.Windows.Forms.Padding(0);
            this.inventory.Name = "inventory";
            this.inventory.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.inventory.Size = new System.Drawing.Size(289, 85);
            this.inventory.TabIndex = 6;
            this.inventory.Text = "Inventory";
            this.inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inventory.UseVisualStyleBackColor = false;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
            this.inventory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.inventory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.inventory.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseUp);
            // 
            // PnlSales
            // 
            this.PnlSales.BackColor = System.Drawing.Color.Firebrick;
            this.PnlSales.Controls.Add(this.SalesHis);
            this.PnlSales.Controls.Add(this.SalesRep);
            this.PnlSales.Controls.Add(this.sale);
            this.PnlSales.Location = new System.Drawing.Point(0, 172);
            this.PnlSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlSales.MaximumSize = new System.Drawing.Size(289, 172);
            this.PnlSales.MinimumSize = new System.Drawing.Size(289, 66);
            this.PnlSales.Name = "PnlSales";
            this.PnlSales.Size = new System.Drawing.Size(289, 66);
            this.PnlSales.TabIndex = 12;
            // 
            // SalesHis
            // 
            this.SalesHis.BackColor = System.Drawing.Color.Transparent;
            this.SalesHis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesHis.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalesHis.FlatAppearance.BorderSize = 0;
            this.SalesHis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.SalesHis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesHis.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesHis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SalesHis.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.SalesHis.IconColor = System.Drawing.Color.LightGray;
            this.SalesHis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SalesHis.IconSize = 35;
            this.SalesHis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesHis.Location = new System.Drawing.Point(0, 115);
            this.SalesHis.Margin = new System.Windows.Forms.Padding(0);
            this.SalesHis.Name = "SalesHis";
            this.SalesHis.Padding = new System.Windows.Forms.Padding(51, 0, 20, 0);
            this.SalesHis.Size = new System.Drawing.Size(289, 49);
            this.SalesHis.TabIndex = 12;
            this.SalesHis.Text = "Sales History";
            this.SalesHis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesHis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SalesHis.UseVisualStyleBackColor = false;
            this.SalesHis.Click += new System.EventHandler(this.SalesHis_Click);
            // 
            // SalesRep
            // 
            this.SalesRep.BackColor = System.Drawing.Color.Transparent;
            this.SalesRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesRep.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalesRep.FlatAppearance.BorderSize = 0;
            this.SalesRep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.SalesRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesRep.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesRep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SalesRep.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.SalesRep.IconColor = System.Drawing.Color.LightGray;
            this.SalesRep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SalesRep.IconSize = 35;
            this.SalesRep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesRep.Location = new System.Drawing.Point(0, 66);
            this.SalesRep.Margin = new System.Windows.Forms.Padding(0);
            this.SalesRep.Name = "SalesRep";
            this.SalesRep.Padding = new System.Windows.Forms.Padding(51, 0, 20, 0);
            this.SalesRep.Size = new System.Drawing.Size(289, 49);
            this.SalesRep.TabIndex = 11;
            this.SalesRep.Text = "Sales Report";
            this.SalesRep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesRep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SalesRep.UseVisualStyleBackColor = false;
            this.SalesRep.Click += new System.EventHandler(this.SalesRep_Click);
            // 
            // sale
            // 
            this.sale.BackColor = System.Drawing.Color.Maroon;
            this.sale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sale.Dock = System.Windows.Forms.DockStyle.Top;
            this.sale.FlatAppearance.BorderSize = 0;
            this.sale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sale.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sale.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.sale.IconColor = System.Drawing.Color.LightGray;
            this.sale.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sale.IconSize = 40;
            this.sale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sale.Location = new System.Drawing.Point(0, 0);
            this.sale.Margin = new System.Windows.Forms.Padding(0);
            this.sale.Name = "sale";
            this.sale.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.sale.Size = new System.Drawing.Size(289, 66);
            this.sale.TabIndex = 9;
            this.sale.Text = "Sales";
            this.sale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sale.UseVisualStyleBackColor = false;
            this.sale.Click += new System.EventHandler(this.sale_Click);
            this.sale.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.sale.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.sale.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseUp);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Transparent;
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.home.IconChar = FontAwesome.Sharp.IconChar.House;
            this.home.IconColor = System.Drawing.Color.LightGray;
            this.home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.home.IconSize = 40;
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(3, 316);
            this.home.Margin = new System.Windows.Forms.Padding(0);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.home.Size = new System.Drawing.Size(285, 89);
            this.home.TabIndex = 3;
            this.home.Text = "Home";
            this.home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            this.home.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.home.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.home.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(93, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "Change Profile";
            this.label3.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.home);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.logout);
            this.panel2.Controls.Add(this.roundPicture1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 834);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseUp);
            // 
            // roundPicture1
            // 
            this.roundPicture1.Location = new System.Drawing.Point(59, 37);
            this.roundPicture1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundPicture1.Name = "roundPicture1";
            this.roundPicture1.Size = new System.Drawing.Size(176, 169);
            this.roundPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPicture1.TabIndex = 0;
            this.roundPicture1.TabStop = false;
            this.roundPicture1.Click += new System.EventHandler(this.profile_Click);
            this.roundPicture1.MouseEnter += new System.EventHandler(this.enter);
            this.roundPicture1.MouseLeave += new System.EventHandler(this.leave);
            // 
            // panelChildform
            // 
            this.panelChildform.AutoSize = true;
            this.panelChildform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildform.Location = new System.Drawing.Point(285, 49);
            this.panelChildform.Margin = new System.Windows.Forms.Padding(0);
            this.panelChildform.MaximumSize = new System.Drawing.Size(1264, 785);
            this.panelChildform.Name = "panelChildform";
            this.panelChildform.Size = new System.Drawing.Size(1264, 785);
            this.panelChildform.TabIndex = 3;
            this.panelChildform.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.panelChildform.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.panelChildform.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseUp);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1549, 834);
            this.Controls.Add(this.panelChildform);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1549, 834);
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.PnlSales.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox min;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private FontAwesome.Sharp.IconButton logout;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton employee;
        private FontAwesome.Sharp.IconButton inventory;
        private System.Windows.Forms.Panel PnlSales;
        private FontAwesome.Sharp.IconButton SalesHis;
        private FontAwesome.Sharp.IconButton SalesRep;
        private FontAwesome.Sharp.IconButton sale;
        private FontAwesome.Sharp.IconButton home;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelChildform;
        private Forms.RoundPicture roundPicture1;
    }
}