using iTextSharp.text.io;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace LaAcoustica_Final
{
    public partial class Inventory : Form
    {
        DataSet ds;
        OleDbDataAdapter da;
        OleDbConnection myConn = new OleDbConnection(StaticClass.connString);
        bool mouseDown;
        Point lastLocation;
        Menu menu = (Menu)Application.OpenForms["Menu"];
        int rowIndex;
        internal static string brnd, product, cat, subcat, quanti, cost;
        //Moving the Form around
        private void Inventory_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Inventory_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                menu.Location = new Point(
                    (menu.Location.X - lastLocation.X) + e.X, (menu.Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void Inventory_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        public Inventory()
        {
            InitializeComponent();
            load();
        }
        internal void load()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity FROM Storage", myConn);
            DataSet ds = new DataSet();
            try
            {
                myConn.Open();
                da.Fill(ds, "Storage");
                storageData.DataSource = ds.Tables["Storage"];
            }
            catch
            {
                MessageBox.Show("An Error Occurred!");
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
            storageData.ClearSelection();
        }
        //ADDS NUMBERS BEFORE THE COLUMNS
        private void row(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string rowNumber = (e.RowIndex + 1).ToString();
            Rectangle rowBounds = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, storageData.RowHeadersWidth - 4, e.RowBounds.Height);
            StringFormat centerFormat = new StringFormat();
            centerFormat.Alignment = StringAlignment.Center;
            centerFormat.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(rowNumber, this.Font, SystemBrushes.ControlText, rowBounds, centerFormat);
        }
        internal void clear_Click(object sender, EventArgs e)
        {
            prod.Text = "";
            brand.Text = "";
            categoryT.Text = "";
            Scategory.Text = "";
            price.Text = "";
            quantity.Text = "";
            brand_txt.Text = "";
            cat_txt.Text = "";
            subcat_txt.Text = "";
            id_txt.Text = "";
            storageData.ClearSelection();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                AddInventory add = new AddInventory();
                add.Show();
            }
            catch
            { }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (brand.Text != "")
                {
                    string query = "Delete From Storage Where ProductName = @pr";
                    OleDbCommand cmd = new OleDbCommand(query, myConn);
                    cmd.Parameters.AddWithValue("@pr", storageData.CurrentRow.Cells[0].Value);
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                    myConn.Close();
                    load();
                }
                else
                {
                    MessageBox.Show("No Product is Selected!", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clear_Click(sender, e);

            }
            catch { MessageBox.Show("An Error Occurred!"); } 
        }

        private void cat_txt_TextChanged(object sender, EventArgs e)
        {
            FilterUnion();
        }

        private void subcat_txt_TextChanged(object sender, EventArgs e)
        {
           FilterUnion();
        }

        private void SelectRow(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            if (e.RowIndex == -1) return;
            rowIndex = index = e.RowIndex;
            DataGridViewRow row = storageData.Rows[index];
            product = prod.Text = row.Cells["ProductName"].Value.ToString();
            brnd = brand.Text = row.Cells["BrandName"].Value.ToString();
            cat = categoryT.Text = row.Cells["Category"].Value.ToString();
            subcat = Scategory.Text = row.Cells["SubCategory"].Value.ToString();
            cost = price.Text = string.Format("₱{0:N}", row.Cells["Price"].Value.ToString());
            quanti = quantity.Text = row.Cells["Quantity"].Value.ToString();
        }

        private void brand_txt_TextChanged(object sender, EventArgs e)
        {
            FilterUnion();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (prod.Text == "")
                    MessageBox.Show("No Product is Selected!", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    EditInventory edit = new EditInventory();
                    edit.Show();
                }
            }
            catch { MessageBox.Show("An Error Occurred!"); }   
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            brand_txt.Text = "";
            cat_txt.Text = "";
            subcat_txt.Text = "";
            id_txt.Text = "";
            load();
        }

        private void id_txt_TextChanged(object sender, EventArgs e)
        {
            brand_txt.Text = "";
            cat_txt.Text = "";
            subcat_txt.Text = "";
            string query = "SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity FROM Storage WHERE ID = @in";
            using (OleDbConnection connection = new OleDbConnection(StaticClass.connString))
            {
                connection.Open();

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@in", id_txt.Text);

                    using (da = new OleDbDataAdapter(cmd))
                    {
                        ds = new DataSet();
                        da.Fill(ds, "Storage");
                        storageData.DataSource = ds.Tables["Storage"]; ;
                    }
                }
            }
            storageData.ClearSelection();
        }

        internal void editted()
        {
            if (rowIndex >= 0 && rowIndex < storageData.Rows.Count)
            {
                // Get the row from the DataGridViewRowCollection
                DataGridViewRow row = storageData.Rows[rowIndex];

                // Select the row
                row.Selected = true;
            }
        }

        private void FilterBrand(string brand)
        {
            string query = "SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity FROM Storage WHERE BrandName LIKE '%' + @in + '%'";
            using (OleDbConnection connection = new OleDbConnection(StaticClass.connString))
            {
                connection.Open();

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@in", brand);

                    using (da = new OleDbDataAdapter(cmd))
                    {
                        ds = new DataSet();
                        da.Fill(ds, "Storage");
                        storageData.DataSource = ds.Tables["Storage"]; ;
                    }
                }
            }
        }
        private void FilterCategory(string category)
        {
            string query = "SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity FROM Storage WHERE Category LIKE '%' + @in + '%'";
            using (OleDbConnection connection = new OleDbConnection(StaticClass.connString))
            {
                connection.Open();

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@in", category);

                    using (da = new OleDbDataAdapter(cmd))
                    {
                        ds = new DataSet();
                        da.Fill(ds, "Storage");
                        storageData.DataSource = ds.Tables["Storage"]; ;
                    }
                }
            }
        }

        private void FilterSubCat(string subcat)
        {
            string query = "SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity FROM Storage WHERE SubCategory LIKE '%' + @in + '%'";
            using (OleDbConnection connection = new OleDbConnection(StaticClass.connString))
            {
                connection.Open();

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@in", subcat_txt.Text);

                    using (da = new OleDbDataAdapter(cmd))
                    {
                        ds = new DataSet();
                        da.Fill(ds, "Storage");
                        storageData.DataSource = ds.Tables["Storage"]; ;
                    }
                }
            }
        }

        private void FilterUnion()
        {
            string query;
            id_txt.Text = "";
            if (brand_txt.Text == "" && cat_txt.Text != "" && subcat_txt.Text != "")
            {
                query = "SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity FROM Storage WHERE SubCategory LIKE '%' + @sub + '%' AND Category LIKE '%' + @cat + '%'";
                using (OleDbConnection connection = new OleDbConnection(StaticClass.connString))
                {
                    connection.Open();

                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@sub", subcat_txt.Text);
                        cmd.Parameters.AddWithValue("@cat", cat_txt.Text);

                        using (da = new OleDbDataAdapter(cmd))
                        {
                            ds = new DataSet();
                            da.Fill(ds, "Storage");
                            storageData.DataSource = ds.Tables["Storage"]; ;
                        }
                    }
                }
            }

            else if (brand_txt.Text != "" && cat_txt.Text != "" && subcat_txt.Text == "")
            {
                query = "SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity FROM Storage WHERE BrandName LIKE '%' + @sub + '%' AND Category LIKE '%' + @cat + '%'";
                using (OleDbConnection connection = new OleDbConnection(StaticClass.connString))
                {
                    connection.Open();

                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@sub", brand_txt.Text);
                        cmd.Parameters.AddWithValue("@cat", cat_txt.Text);

                        using (da = new OleDbDataAdapter(cmd))
                        {
                            ds = new DataSet();
                            da.Fill(ds, "Storage");
                            storageData.DataSource = ds.Tables["Storage"]; ;
                        }
                    }
                }
            }

            else if (brand_txt.Text != "" && cat_txt.Text == "" && subcat_txt.Text != "")
            {
                query = "SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity FROM Storage WHERE BrandName LIKE '%' + @sub + '%' AND SubCategory LIKE '%' + @cat + '%'";
                using (OleDbConnection connection = new OleDbConnection(StaticClass.connString))
                {
                    connection.Open();

                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@sub", brand_txt.Text);
                        cmd.Parameters.AddWithValue("@cat", subcat_txt.Text);

                        using (da = new OleDbDataAdapter(cmd))
                        {
                            ds = new DataSet();
                            da.Fill(ds, "Storage");
                            storageData.DataSource = ds.Tables["Storage"]; ;
                        }
                    }
                }
            }
            else if (brand_txt.Text != "" && cat_txt.Text != "" && subcat_txt.Text != "")
            {
                query = "SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity FROM Storage WHERE BrandName LIKE '%' + @sub + '%' AND SubCategory LIKE '%' + @cat + '%' AND Category LIKE '%' + @categ + '%'";
                using (OleDbConnection connection = new OleDbConnection(StaticClass.connString))
                {
                    connection.Open();

                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@sub", brand_txt.Text);
                        cmd.Parameters.AddWithValue("@cat", subcat_txt.Text);
                        cmd.Parameters.AddWithValue("@categ", cat_txt.Text);

                        using (da = new OleDbDataAdapter(cmd))
                        {
                            ds = new DataSet();
                            da.Fill(ds, "Storage");
                            storageData.DataSource = ds.Tables["Storage"]; ;
                        }
                    }
                }
            }
            else if (brand_txt.Text != "" && cat_txt.Text == "" && subcat_txt.Text == "")
                FilterBrand(brand_txt.Text);
            else if (brand_txt.Text == "" && cat_txt.Text != "" && subcat_txt.Text == "")
                FilterCategory(cat_txt.Text);
            else if (brand_txt.Text == "" && cat_txt.Text == "" && subcat_txt.Text != "")
                FilterSubCat(subcat_txt.Text);
            else if (brand_txt.Text == "" && cat_txt.Text == "" && subcat_txt.Text == "")
                load();
            storageData.ClearSelection();
        }
    }
}
