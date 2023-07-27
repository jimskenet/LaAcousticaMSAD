using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Windows.Forms;


namespace LaAcoustica_Final
{
    public partial class Employee : Form
    {
        OleDbConnection myConn = new OleDbConnection(StaticClass.connString);
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        DataGridViewRow row;
        PrivateFontCollection pfc;
        int quanI;
        decimal totalPrice;
        int qty;
        bool mouseDown;
        Point lastLocation;
        //For Receipt
        string invoiceNumber;
        int count, count2,quantity;

        //Moving the Form around
        private void Employee_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Employee_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void Employee_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        public Employee()
        {
            InitializeComponent();
            cashier.Text = Login.lname + ", " + Login.fname;
            if (Login.acc == "Admin" || Login.acc == "Main")
            {
                Acc.Text = "Admin User";
            }
            else if (Login.acc == "Customer")
            {
                Acc.Text = "Customer";
                label4.Text = "My Cart";
                label10.Text = "Customer: ";
                cashier.Location = new Point(100, 2);
                add.Text = "Add to Cart"; delete.Text = "Remove from Cart"; printR.Text = "Purchase Item/s";
                resetBill.Text = "Clear Cart";
                edit.Text = "Update Order"; edit.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            }
            else { Acc.Text = "Employee User"; }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            Reset();
        }
        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //logout
        private void logout_Click(object sender, EventArgs e)
        {
            if (myConn.State != ConnectionState.Closed)
                myConn.Close();
            Close();
            Login lg = new Login();
            lg.Show();
            Reset();
        }
        //Product storage
        private void Employee_Load(object sender, EventArgs e)
        {
            loadInventory();
            loadBill();
            Total();
            ItemPic.Image = null;
        }
        //LOADS INVENTORY
        private void loadInventory()
        {
            da = new OleDbDataAdapter("SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity, ImageUrl FROM Storage", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Storage");
            storageData.DataSource = ds.Tables["Storage"];
            storageData.Columns["Price"].DefaultCellStyle.Format = "C";
            myConn.Close();

            storageData.Columns["ImageUrl"].Visible = false;
            storageData.Columns["Quantity"].Visible = false;
            storageData.ClearSelection();
            Q.Visible = false;
        }
        //LOADS BILL
        private void loadBill()
        {
            da = new OleDbDataAdapter("SELECT Product, Price, Quantity FROM Bill", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Bill");
            cart.DataSource = ds.Tables["Bill"];
            cart.Columns["Price"].DefaultCellStyle.Format = "C";
            myConn.Close();
        }
        //SELECTS ROW IN INVENTORY
        private void SelectRow(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;

                int index = e.RowIndex;
                row = storageData.Rows[index];
                prodN.Text = row.Cells[0].Value.ToString();
                double price = Convert.ToDouble(row.Cells[4].Value);
                quanI = Convert.ToInt32(row.Cells[5].Value);
                priceN.Text = price.ToString("C");
                stockQ.Text = row.Cells["Quantity"].Value.ToString() + "  items left";
                quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                Q.Visible = true;
            }
            catch
            {
                MessageBox.Show("An Error Occurred");
            }
        }
        //SELECT ROW IN BILL
        private void SelectRow2(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;

                int index = e.RowIndex;
                row = cart.Rows[index];
                prodN.Text = row.Cells[0].Value.ToString();
                int quanB = Convert.ToInt32(row.Cells[2].Value);
                double priceB = Convert.ToDouble(row.Cells[1].Value);
                priceN.Text = priceB.ToString("C");
                Q.Value = quanB;
            }
            catch
            {
                MessageBox.Show("No Products Selected!");
            }
        }
        //ADDS PRODUCT QUANTITY INTO BILL
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (Q.Value == 0)
                {
                    MessageBox.Show("Quantity of order must be more than 0", "Purchasing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (quantity <= 0)
                {
                    if (prodN.Text == "")
                        MessageBox.Show("No product selected", "Purchasing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("No Stock Available", "Purchasing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(Q.Value > quantity)
                {
                    MessageBox.Show("Insufficient Stock for Quantity Order\nStock Available = "+quantity.ToString() +" units", "Purchasing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (quanI >= Q.Value)
                    {
                        string query = "INSERT INTO Bill ([Product], [Price], [Quantity]) VALUES (@prod,@price,@quan)";
                        cmd = new OleDbCommand(query, myConn);
                        cmd.Parameters.AddWithValue("@prod", prodN.Text);
                        cmd.Parameters.AddWithValue("@price", priceN.Text.ToString());
                        cmd.Parameters.AddWithValue("@quan", Q);
                        myConn.Open();
                        cmd.ExecuteNonQuery();
                        myConn.Close();
                        int totQuan = -1 * Convert.ToInt32(Q.Value);
                        UpInventory(totQuan, prodN.Text);
                        loadBill();
                        Total();
                        Q.Value = 1;
                    }
                    else { MessageBox.Show("Insufficient Stock"); }
                    refresh.PerformClick();
                }
            }
            catch
            {
                MessageBox.Show("Product Already Added!"); myConn.Close(); ;
            }
        }
        //TOTAL PRICE OF ALL PRODUCTS IN BILL
        private void Total()
        {
            totalPrice = 0;
            qty = 0;
            foreach (DataGridViewRow row in cart.Rows)
            {
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                totalPrice = totalPrice + (price * quantity);
                qty += quantity;
            }
            totPrice.Text = string.Format("₱{0:N}", totalPrice);
            items.Text = qty.ToString();
        }
        //DELETES FROM BILL DATABASE AND RETURNS DELETED PRODUCTS BACK TO INVENTORY
        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cart.CurrentRow != null && cart.CurrentRow.Cells[0].Value != null && prodN != null)
                {
                    cmd = new OleDbCommand("Delete From Bill Where Product = @pr", myConn);
                    cmd.Parameters.AddWithValue("@pr", cart.CurrentRow.Cells[0].Value);
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                    myConn.Close();
                    int quantity = Convert.ToInt32(cart.CurrentRow.Cells[2].Value);
                    UpInventory(quantity, prodN.Text);
                    loadBill();
                    Total();
                }
                else
                {
                    MessageBox.Show("No Products to be Deleted!", "Cart Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("An error occurred");
                myConn.Close();
            }
        }
        //RESET METHOD
        private void Reset()
        {
            using (OleDbConnection myConn = new OleDbConnection(StaticClass.connString))
            {
                string query = "DELETE * FROM Bill";
                OleDbCommand command = new OleDbCommand(query, myConn);
                myConn.Open();
                command.ExecuteNonQuery();
                loadBill();
                decimal totalPrice = 0;
                totPrice.Text = string.Format("₱{0:N}", totalPrice);
                items.Text = "0";
                prodN.Text = "";
                priceN.Text = "";
            }
        }
        private void compare()
        {
            foreach (DataGridViewRow row in cart.Rows)
            {
                foreach (DataGridViewRow row2 in storageData.Rows)
                {
                    var cellProduct = row.Cells["Product"].Value;
                    var cellProductName = row2.Cells["ProductName"].Value;
                    if (cellProduct != null && cellProductName != null && cellProduct.ToString() == cellProductName.ToString())
                    {
                        int quantity = Convert.ToInt32(row.Cells[2].Value);
                        UpInventory(quantity, row.Cells[0].Value.ToString());
                        break;
                    }
                }
            }
        }
        //RESET AND DELETES BILL DATABASE
        private void resetBill_Click(object sender, EventArgs e)
        {
            try
            {
                compare();
                Reset();
                cart.DataSource = null;
                cart.Rows.Clear();
                loadBill();
                Total();
                storageData.ClearSelection();
                Q.Value = 1;

            }
            catch
            {
                MessageBox.Show("An Error Occurred"); myConn.Close();
            }
        }
        //UPDATES QUANTITY IN INVENTORY
        private void UpInventory(int tot, string prod)
        {
            cmd = new OleDbCommand("UPDATE Storage SET [Quantity] = [Quantity] + @qt  WHERE ProductName = @pr", myConn);
            myConn.Open();
            cmd.Parameters.AddWithValue("@qt", tot);
            cmd.Parameters.AddWithValue("@pr", prod);
            cmd.ExecuteNonQuery();
            myConn.Close();
            loadInventory();
        }
        //EDIT QUANTITY OF PRODUCTS
        private void edit_Click(object sender, EventArgs e)
        {
            if (Q.Value == 0) { delete.PerformClick(); }
            else
            {
                try
                {
                    int q = Convert.ToInt32(Q.Value);
                    int quantity = Convert.ToInt32(cart.CurrentRow.Cells[2].Value);
                    UpInventory(quantity - q, prodN.Text);
                    myConn.Open();
                    cmd = new OleDbCommand("UPDATE Bill SET Product = @pr, Price = @pc, [Quantity] = @qt  WHERE Product = @pr", myConn);
                    cmd.Parameters.AddWithValue("@pr", prodN.Text);
                    cmd.Parameters.AddWithValue("@pc", priceN.Text);
                    cmd.Parameters.AddWithValue("@qt", Q);
                    cmd.ExecuteNonQuery();
                    myConn.Close();
                }
                catch { MessageBox.Show("Insufficient Stock!"); myConn.Close(); }
                loadBill();
            }
                
        }
        //FILTER METHODS
        private void Filter()
        {
            BeginInvoke((Action)(() => //Makes the dgv load first then begins to execute ClearSelection()
            {
                if (brandN.SelectedIndex != -1 && category.SelectedIndex == -1 && subcategory.SelectedIndex == -1) { da = new OleDbDataAdapter("SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity,ImageUrl FROM Storage WHERE BrandName = '" + brandN.SelectedItem.ToString() + "'", myConn); }
            else if (brandN.SelectedIndex == -1 && category.SelectedIndex != -1 && subcategory.SelectedIndex == -1) { da = new OleDbDataAdapter("SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity,ImageUrl FROM Storage WHERE Category = '" + category.SelectedItem.ToString() + "'", myConn); }
            else if (brandN.SelectedIndex == -1 && category.SelectedIndex == -1 && subcategory.SelectedIndex != -1) { da = new OleDbDataAdapter("SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity,ImageUrl FROM Storage WHERE SubCategory = '" + subcategory.SelectedItem.ToString() + "'", myConn); }
            else if (brandN.SelectedIndex != -1 && category.SelectedIndex != -1 && subcategory.SelectedIndex == -1)
            {
                da = new OleDbDataAdapter("SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity,ImageUrl FROM Storage WHERE BrandName = '" + brandN.SelectedItem.ToString() + "' and Category = '" + category.SelectedItem.ToString() + "'", myConn);
            }
            else if (brandN.SelectedIndex != -1 && category.SelectedIndex == -1 && subcategory.SelectedIndex != -1)
            {
                da = new OleDbDataAdapter("SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity,ImageUrl FROM Storage WHERE BrandName = '" + brandN.SelectedItem.ToString() + "' and SubCategory = '" + subcategory.SelectedItem.ToString() + "'", myConn);
            }
            else if (brandN.SelectedIndex == -1 && category.SelectedIndex != -1 && subcategory.SelectedIndex != -1)
            {
                da = new OleDbDataAdapter("SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity,ImageUrl FROM Storage WHERE Category = '" + category.SelectedItem.ToString() + "' and SubCategory = '" + subcategory.SelectedItem.ToString() + "'", myConn);
            }
            else
            {
                da = new OleDbDataAdapter("SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity,ImageUrl FROM Storage WHERE BrandName = '" + brandN.SelectedItem.ToString() + "' and Category = '" + category.SelectedItem.ToString() + "' and SubCategory = '" + subcategory.SelectedItem.ToString() + "'", myConn);
            }

            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Storage");
            storageData.DataSource = ds.Tables["Storage"];
            storageData.Columns["Price"].DefaultCellStyle.Format = "C";
            myConn.Close();
            }));
        }
        
        private void FilterData(object sender, EventArgs e) 
        { 
            Filter(); 
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            brandN.Text = "";
            category.Text = "";
            subcategory.Text = "";
            Q.Value = 1;

            loadInventory();
            BeginInvoke((Action)(() => //Makes the dgv load first then begins to execute ClearSelection()
            {
            if (myConn.State == ConnectionState.Closed)
                myConn.Open();
            cmd = new OleDbCommand();
            cmd.Connection = myConn;
            string query = "SELECT DISTINCT BrandName, Category,SubCategory FROM Storage";
            cmd.CommandText = query;

            OleDbDataReader reader = cmd.ExecuteReader();
            brandN.Items.Clear();
            category.Items.Clear();
            subcategory.Items.Clear();
            while (reader.Read())
            {
                if (!category.Items.Contains(reader["Category"].ToString()))
                    category.Items.Add(reader["Category"].ToString()); //Lists all of the related category
                if (!subcategory.Items.Contains(reader["SubCategory"].ToString()))
                    subcategory.Items.Add(reader["SubCategory"].ToString());
                if (!brandN.Items.Contains(reader["BrandName"].ToString()))
                    brandN.Items.Add(reader["BrandName"].ToString());
            }
            reader.Close();
            myConn.Close();
            }));
        }

        private void printR_Click(object sender, EventArgs e)
        {
            try
            {
                string numericString = totPrice.Text.Replace("₱", "").Replace(",", "");
                if (numericString != "0.00")
                {
                    string total = totalPrice.ToString("C");
                    invoiceNumber = Guid.NewGuid().ToString();
                    string dateTime = DateTime.Now.ToShortDateString();
                    string query = "INSERT INTO Daily (InvoiceNumber, Sales, [Date],month_id,year_id) VALUES (@in,@sale,@dt,@mnth,@yr)";
                    cmd = new OleDbCommand(query, myConn);
                    cmd.Parameters.AddWithValue("@in", invoiceNumber);
                    cmd.Parameters.AddWithValue("@sale", total);
                    cmd.Parameters.AddWithValue("@dt", dateTime);
                    cmd.Parameters.AddWithValue("@mnth", DateTime.Now.Month);
                    cmd.Parameters.AddWithValue("@yr", DateTime.Now.Year);
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                    myConn.Close();
                    //For Bill Sums
                    string sql = "SELECT SUM(Price) FROM Bill";
                    myConn.Open();
                    OleDbCommand cmd2 = new OleDbCommand(sql, myConn);
                    object result = cmd2.ExecuteScalar();
                    decimal tomonthly = Convert.ToDecimal(result);
                    myConn.Close();
                    UpdateSales(tomonthly);
                    //For Reciept
                    PrintProperties();
                    MessageBox.Show("Sale Purchased!");
                    resetBill_Click(sender, e);
                }
                else { MessageBox.Show("Cart is empty!", "Purchasing Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch { MessageBox.Show("An error has occured. You may contact your developer or try again. ", "Purchasing Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { myConn.Close(); }
        }
        
        private void UpdateSales(decimal monthly)
        {
            using (OleDbConnection myConn = new OleDbConnection(StaticClass.connString))
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = myConn;
                command.CommandText = "Select * FROM Monthly where month_id =@mnth and year_id = @yr";
                command.Parameters.AddWithValue("@mnth", DateTime.Now.Month);
                command.Parameters.AddWithValue("@yr", DateTime.Now.Year);
                myConn.Open();
                OleDbDataReader read = command.ExecuteReader();
                if (!read.HasRows)
                {
                    string query = "INSERT INTO Monthly (TotalSales, month_id,year_id) VALUES (@sale,@mnth,@yr)";
                    cmd = new OleDbCommand(query, myConn);
                    cmd.Parameters.AddWithValue("@sale", monthly);
                    cmd.Parameters.AddWithValue("@mnth", DateTime.Now.Month);
                    cmd.Parameters.AddWithValue("@yr", DateTime.Now.Year);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string query = "UPDATE Monthly SET [TotalSales] = [TotalSales] + @ds  WHERE month_id = @mnth AND year_id = @yr";
                    cmd = new OleDbCommand(query, myConn);
                    cmd.Parameters.AddWithValue("@ds", monthly);
                    cmd.Parameters.AddWithValue("@mnth", DateTime.Now.Month);
                    cmd.Parameters.AddWithValue("@yr", DateTime.Now.Year);
                    cmd.ExecuteNonQuery();
                }
                myConn.Close();
            }

            using (OleDbConnection myConn = new OleDbConnection(StaticClass.connString))
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = myConn;
                command.CommandText = "Select * FROM Yearly where year_id = @yr";
                command.Parameters.AddWithValue("@yr", DateTime.Now.Year);
                myConn.Open();
                OleDbDataReader read = command.ExecuteReader();
                if (!read.HasRows)
                {
                    string query = "INSERT INTO Yearly (TotalSales,year_id) VALUES (@sale,@yr)";
                    cmd = new OleDbCommand(query, myConn);
                    cmd.Parameters.AddWithValue("@sale", monthly);
                    cmd.Parameters.AddWithValue("@yr", DateTime.Now.Year);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string query = "UPDATE Yearly SET [TotalSales] = [TotalSales] + @ds  WHERE year_id = @yr";
                    cmd = new OleDbCommand(query, myConn);
                    cmd.Parameters.AddWithValue("@ds", monthly);
                    cmd.Parameters.AddWithValue("@yr", DateTime.Now.Year);
                    cmd.ExecuteNonQuery();
                }
                myConn.Close();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"Merchant Copy.ttf");
            System.Drawing.Font font = new System.Drawing.Font("Merchant Copy", 10, FontStyle.Regular);
            SolidBrush brush = new SolidBrush(System.Drawing.Color.Black);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            e.Graphics.DrawString("La Acoustica", new System.Drawing.Font("Merchant Copy", 18, FontStyle.Bold), brush, e.PageBounds.Width / 2, 10, format);
            e.Graphics.DrawString("Music And Audio Store", font, brush, e.PageBounds.Width / 2, 30, format);
            e.Graphics.DrawString("Date: " + DateTime.Now.ToString(), font, brush, 0, 50);
            e.Graphics.DrawString("Invoice: " + invoiceNumber, font, brush, 0, 60);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------", font, brush, e.PageBounds.Width / 2, 70, format);
            e.Graphics.DrawString("Qty", font, brush, 0, 80);
            e.Graphics.DrawString("Product", font, brush, 50, 80);
            e.Graphics.DrawString("Price", font, brush, 180, 80);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------", font, brush, e.PageBounds.Width / 2, 90, format);
            //for datagridview
            int y = 105;
            count = 0;
            count2 = 0;
            foreach (DataGridViewRow row in cart.Rows)
            {
                // Check if the row is not a header row
                if (!row.IsNewRow)
                {
                    // Print the values of the cells in the row
                    string quantity = row.Cells["Quantity"].Value != null ? row.Cells["Quantity"].Value.ToString() : "";
                    string product = row.Cells["Product"].Value != null ? row.Cells["Product"].Value.ToString() : "";
                    string priceString = row.Cells["Price"].Value != null ? row.Cells["Price"].Value.ToString() : "";
                    // Parse the price string to a double
                    double price = 0;
                    double.TryParse(priceString, out price);
                    // Convert the price to currency format
                    string formattedPrice = price.ToString("C");
                    // Split the product text into multiple lines if it exceeds the maximum width
                    List<string> lines = new List<string>();
                    SizeF size = e.Graphics.MeasureString(product, font);
                    float maxWidth = 120; // set a maximum width for the product column
                    if (size.Width > maxWidth)
                    {
                        string[] words = product.Split(' ');
                        string line = "";
                        foreach (string word in words)
                        {
                            if (e.Graphics.MeasureString(line + word, font).Width > maxWidth)
                            {
                                lines.Add(line);
                                line = word + " ";
                            }
                            else
                            {
                                line += word + " ";
                            }
                        }
                        if (line.Length > 0)
                        {
                            lines.Add(line);
                        }
                    }
                    else
                    {
                        lines.Add(product);
                    }
                    e.Graphics.DrawString(quantity, font, brush, 0, y);
                    e.Graphics.DrawString(formattedPrice, font, brush, 180, y);
                    // Print each line of the product text
                    float x = 50;
                    foreach (string line in lines)
                    {
                        e.Graphics.DrawString(line, font, brush, x, y);
                        y += 10;
                        count2++;
                    }
                    y += 5;
                    count++;
                }
            }
            e.Graphics.DrawString("----------------------------------------------------------------------------------------", font, brush, e.PageBounds.Width / 2, y, format);
            e.Graphics.DrawString(qty.ToString(), font, brush, 0, y + 15);
            e.Graphics.DrawString("Total: ", font, brush, 145, y + 15);
            e.Graphics.DrawString(totalPrice.ToString("C"), font, brush, 180, y + 15);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------", font, brush, e.PageBounds.Width / 2, y + 30, format);
            e.Graphics.DrawString("THANK YOU FOR YOUR PURCHASE!", new System.Drawing.Font("Merchant Copy", 11, FontStyle.Bold), brush, e.PageBounds.Width / 2, y + 60, format);
        }

        private void brandN_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterCombo();
        }

        private void category_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterCombo();
        }

        private void subcategory_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterCombo();
        }

        private void FilterCombo()
        {
            BeginInvoke((Action)(() =>
            {
                if (myConn.State == ConnectionState.Closed)
                    myConn.Open();
                if (brandN.SelectedIndex != -1 && category.SelectedIndex == -1 && subcategory.SelectedIndex == -1) 
                {
                    cmd = new OleDbCommand();
                    cmd.Connection = myConn;
                    string query = "SELECT DISTINCT Category,SubCategory FROM Storage WHERE BrandName = @brand";
                    cmd.Parameters.AddWithValue("@brand", brandN.Text);
                    cmd.CommandText = query;

                    OleDbDataReader reader = cmd.ExecuteReader();
                    category.Items.Clear();
                    subcategory.Items.Clear();
                    while (reader.Read())
                    {
                        if (!category.Items.Contains(reader["Category"].ToString()))
                            category.Items.Add(reader["Category"].ToString()); //Lists all of the related category
                        if (!subcategory.Items.Contains(reader["SubCategory"].ToString()))
                            subcategory.Items.Add(reader["SubCategory"].ToString());
                    }
                    reader.Close();
                }
                else if (brandN.SelectedIndex == -1 && category.SelectedIndex != -1 && subcategory.SelectedIndex == -1) 
                {
                    cmd = new OleDbCommand();
                    cmd.Connection = myConn;
                    string query = "SELECT DISTINCT BrandName,SubCategory FROM Storage WHERE Category = @cat";
                    cmd.Parameters.AddWithValue("@cat", category.Text);
                    cmd.CommandText = query;

                    OleDbDataReader reader = cmd.ExecuteReader();
                    brandN.Items.Clear();
                    subcategory.Items.Clear();
                    while (reader.Read())
                    {
                        if (!brandN.Items.Contains(reader["BrandName"].ToString()))
                            brandN.Items.Add(reader["BrandName"].ToString()); //Lists all of the related category
                        if (!subcategory.Items.Contains(reader["SubCategory"].ToString()))
                            subcategory.Items.Add(reader["SubCategory"].ToString());
                    }
                    reader.Close();
                }
                else if (brandN.SelectedIndex == -1 && category.SelectedIndex == -1 && subcategory.SelectedIndex != -1) 
                {
                    cmd = new OleDbCommand();
                    cmd.Connection = myConn;
                    string query = "SELECT DISTINCT BrandName,Category FROM Storage WHERE SubCategory = @subcat";
                    cmd.Parameters.AddWithValue("@subcat", subcategory.Text);
                    cmd.CommandText = query;

                    OleDbDataReader reader = cmd.ExecuteReader();
                    brandN.Items.Clear();
                    category.Items.Clear();
                    while (reader.Read())
                    {
                        if (!brandN.Items.Contains(reader["BrandName"].ToString()))
                            brandN.Items.Add(reader["BrandName"].ToString()); //Lists all of the related category
                        if (!category.Items.Contains(reader["Category"].ToString()))
                            category.Items.Add(reader["Category"].ToString());
                    }
                    reader.Close();
                }
                else if (brandN.SelectedIndex != -1 && category.SelectedIndex != -1 && subcategory.SelectedIndex == -1)
                {
                    cmd = new OleDbCommand();
                    cmd.Connection = myConn;
                    string query = "SELECT DISTINCT SubCategory FROM Storage WHERE Category = @cat and BrandName = @brand";
                    cmd.Parameters.AddWithValue("@cat", category.Text);
                    cmd.Parameters.AddWithValue("@brand", brandN.Text);
                    cmd.CommandText = query;

                    OleDbDataReader reader = cmd.ExecuteReader();
                    subcategory.Items.Clear();
                    while (reader.Read())
                    {
                        if (!subcategory.Items.Contains(reader["SubCategory"].ToString()))
                            subcategory.Items.Add(reader["SubCategory"].ToString());
                    }
                    reader.Close();
                }
                else if (brandN.SelectedIndex != -1 && category.SelectedIndex == -1 && subcategory.SelectedIndex != -1)
                {
                    cmd = new OleDbCommand();
                    cmd.Connection = myConn;
                    string query = "SELECT DISTINCT Category FROM Storage WHERE SubCategory = @subcat and BrandName = @brand";
                    cmd.Parameters.AddWithValue("@subcat", subcategory.Text);
                    cmd.Parameters.AddWithValue("@brand", brandN.Text);
                    cmd.CommandText = query;

                    OleDbDataReader reader = cmd.ExecuteReader();
                    category.Items.Clear();
                    while (reader.Read())
                    {
                        if (!category.Items.Contains(reader["Category"].ToString()))
                            category.Items.Add(reader["Category"].ToString());
                    }
                    reader.Close();
                }
                else if (brandN.SelectedIndex == -1 && category.SelectedIndex != -1 && subcategory.SelectedIndex != -1)
                {
                    cmd = new OleDbCommand();
                    cmd.Connection = myConn;
                    string query = "SELECT DISTINCT BrandName FROM Storage WHERE SubCategory = @subcat and Category = @cat";
                    cmd.Parameters.AddWithValue("@subcat", subcategory.Text);
                    cmd.Parameters.AddWithValue("@cat", category.Text);
                    cmd.CommandText = query;

                    OleDbDataReader reader = cmd.ExecuteReader();
                    brandN.Items.Clear();
                    while (reader.Read())
                    {
                        if (!brandN.Items.Contains(reader["BrandName"].ToString()))
                            brandN.Items.Add(reader["BrandName"].ToString());
                    }
                    reader.Close();
                }
                myConn.Close(); 
            }));
        }
        private void storageData_SelectionChanged(object sender, EventArgs e)
        {
            if (storageData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = storageData.SelectedRows[0];
                if (selectedRow.Cells["ImageUrl"].Value != null)
                {
                    string imageurl = selectedRow.Cells["ImageUrl"].Value.ToString();
                    try
                    {
                        ItemPic.Load(imageurl);
                    }
                    catch
                    {
                        MessageBox.Show("Error loading Image");
                    }
                }
            }
        }

        private void PrintProperties()
        {
            int y = 500 + (count * 15) + (count2 * 10);
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", 250, y);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
