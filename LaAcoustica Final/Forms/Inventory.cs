using System;
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
        private void load()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity FROM Storage", myConn);
            DataSet ds = new DataSet();
            try
            {
                myConn.Open();
                da.Fill(ds, "Storage");
                storageData.DataSource = ds.Tables["Storage"];
            }
            catch (Exception e)
            {
                MessageBox.Show("An Error Occurred! " + e.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
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
        private void clear_Click(object sender, EventArgs e)
        {
            prod.Text = "";
            brand.Text = "";
            categoryT.Text = "";
            Scategory.Text = "";
            price.Text = "";
            quantity.Text = "";
            storageData.ClearSelection();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Storage (ProductName, BrandName, Category, SubCategory, Price, Quantity) VALUES (@prod,@brand,@category,@subcategory,@price,@quantity)";
                OleDbCommand cmd = new OleDbCommand(query, myConn);
                if (prod.Text == "" || brand.Text == "" || categoryT.Text == "" || Scategory.Text == "" || price.Text == "" || quantity.Text == "")
                {
                    MessageBox.Show("Invalid Input!");
                    clear_Click(sender, e);
                }
                else
                {
                    myConn.Open();
                    cmd.Parameters.AddWithValue("@prod", prod.Text);
                    cmd.Parameters.AddWithValue("@brand", brand.Text);
                    cmd.Parameters.AddWithValue("@category", categoryT.Text);
                    cmd.Parameters.AddWithValue("@subcategory", Scategory.Text);
                    cmd.Parameters.AddWithValue("@price", price.Text.ToString());
                    cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(quantity.Text));
                    cmd.ExecuteNonQuery();
                    myConn.Close();
                    MessageBox.Show("Data inserted");
                }
            }
            catch
            {
                MessageBox.Show("Product Already Exists!");
            }
            finally { load(); }
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
        private void SelectRow(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            if (e.RowIndex == -1) return;
            index = e.RowIndex;
            DataGridViewRow row = storageData.Rows[index];
            prod.Text = row.Cells[0].Value.ToString();
            brand.Text = row.Cells[1].Value.ToString();
            categoryT.Text = row.Cells[2].Value.ToString();
            Scategory.Text = row.Cells[3].Value.ToString();
            price.Text = row.Cells[4].Value.ToString();
            quantity.Text = row.Cells[5].Value.ToString();
        }
        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE Storage SET ProductName = @prod, BrandName = @brand, Category = @category, SubCategory = @subcategory, Price = @price, Quantity = @quantity  WHERE ProductName = @prod", myConn);
                cmd.Parameters.AddWithValue("@prod", prod.Text);
                cmd.Parameters.AddWithValue("@brand", brand.Text);
                cmd.Parameters.AddWithValue("@category", categoryT.Text);
                cmd.Parameters.AddWithValue("@subcategory", Scategory.Text);
                cmd.Parameters.AddWithValue("@price", price.Text.ToString());
                cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(quantity.Text));
                cmd.ExecuteNonQuery();
                myConn.Close();
                load();
            }
            catch { MessageBox.Show("An Error Occurred!"); }   
        }
        private void Filter()
        {
            if (brandN.SelectedIndex != -1 && category.SelectedIndex == -1 && subcategory.SelectedIndex == -1) { da = new OleDbDataAdapter("SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity FROM Storage WHERE BrandName = '" + brandN.SelectedItem.ToString() + "'", myConn); }
            else if (brandN.SelectedIndex == -1 && category.SelectedIndex != -1 && subcategory.SelectedIndex == -1) { da = new OleDbDataAdapter("SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity FROM Storage WHERE Category = '" + category.SelectedItem.ToString() + "'", myConn); }
            else if (brandN.SelectedIndex == -1 && category.SelectedIndex == -1 && subcategory.SelectedIndex != -1) { da = new OleDbDataAdapter("SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity FROM Storage WHERE SubCategory = '" + subcategory.SelectedItem.ToString() + "'", myConn); }
            else if (brandN.SelectedIndex != -1 && category.SelectedIndex != -1 && subcategory.SelectedIndex == -1)
            {
                da = new OleDbDataAdapter("SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity FROM Storage WHERE BrandName = '" + brandN.SelectedItem.ToString() + "' and Category = '" + category.SelectedItem.ToString() + "'", myConn);
            }
            else if (brandN.SelectedIndex != -1 && category.SelectedIndex == -1 && subcategory.SelectedIndex != -1)
            {
                da = new OleDbDataAdapter("SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity FROM Storage WHERE BrandName = '" + brandN.SelectedItem.ToString() + "' and SubCategory = '" + subcategory.SelectedItem.ToString() + "'", myConn);
            }
            else if (brandN.SelectedIndex == -1 && category.SelectedIndex != -1 && subcategory.SelectedIndex != -1)
            {
                da = new OleDbDataAdapter("SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity FROM Storage WHERE Category = '" + category.SelectedItem.ToString() + "' and SubCategory = '" + subcategory.SelectedItem.ToString() + "'", myConn);
            }
            else
            {
                da = new OleDbDataAdapter("SELECT ProductName, BrandName, Category, SubCategory, Price, Quantity FROM Storage WHERE BrandName = '" + brandN.SelectedItem.ToString() + "' and Category = '" + category.SelectedItem.ToString() + "' and SubCategory = '" + subcategory.SelectedItem.ToString() + "'", myConn);
            }
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Storage");
            storageData.DataSource = ds.Tables["Storage"];
            storageData.Columns["Price"].DefaultCellStyle.Format = "C";
            myConn.Close();

            storageData.ClearSelection(); // Clear selection after data is loaded
        }
        private void FilterData(object sender, EventArgs e) { Filter(); }
        private void refresh_Click(object sender, EventArgs e)
        {
            brandN.SelectedIndex = -1;
            category.SelectedIndex = -1;
            subcategory.SelectedIndex = -1;
            load();
        }
    }
}
