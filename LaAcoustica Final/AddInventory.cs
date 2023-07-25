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

namespace LaAcoustica_Final
{
    public partial class AddInventory : Form
    {
        OleDbConnection myConn = new OleDbConnection(StaticClass.connString);
        bool mouseDown;
        Point lastLocation;
        Inventory storage = (Inventory)Application.OpenForms["Inventory"];
        public AddInventory()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
                    storage.clear_Click(sender, e);
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
            finally { storage.load(); Close(); }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            prod.Text = "";
            brand.Text = "";
            categoryT.Text = "";
            Scategory.Text = "";
            price.Text = "";
            quantity.Text = "";
        }
        private void Inventory_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Inventory_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void Inventory_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
