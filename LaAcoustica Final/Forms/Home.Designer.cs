namespace LaAcoustica_Final
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.date = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.sell = new LaAcoustica_Final.CButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, -99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1088, 792);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Black;
            this.date.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.SystemColors.Control;
            this.date.Location = new System.Drawing.Point(371, 516);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(26, 39);
            this.date.TabIndex = 1;
            this.date.Text = ".";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Black;
            this.Time.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.SystemColors.Control;
            this.Time.Location = new System.Drawing.Point(489, 582);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(26, 39);
            this.Time.TabIndex = 2;
            this.Time.Text = ".";
            this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sell
            // 
            this.sell.BackColor = System.Drawing.Color.DarkRed;
            this.sell.BackgroundColor = System.Drawing.Color.DarkRed;
            this.sell.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sell.BorderRadius = 20;
            this.sell.BorderSize = 0;
            this.sell.FlatAppearance.BorderSize = 0;
            this.sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sell.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell.ForeColor = System.Drawing.Color.White;
            this.sell.Location = new System.Drawing.Point(12, 715);
            this.sell.Name = "sell";
            this.sell.Size = new System.Drawing.Size(312, 58);
            this.sell.TabIndex = 3;
            this.sell.Text = "Sell Products";
            this.sell.TextColor = System.Drawing.Color.White;
            this.sell.UseVisualStyleBackColor = false;
            this.sell.Click += new System.EventHandler(this.sell_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 785);
            this.Controls.Add(this.sell);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label Time;
        private CButton sell;
    }
}