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
    public partial class EditInventory : Form
    {
        OleDbConnection myConn = new OleDbConnection(StaticClass.connString);
        bool mouseDown;
        Point lastLocation;
        Inventory storage = (Inventory)Application.OpenForms["Inventory"];
        public static string quant;
        public EditInventory()
        {
            InitializeComponent();
            prod.Text = Inventory.product;
            brand.Text = Inventory.brnd;
            categoryT.Text = Inventory.cat;
            Scategory.Text = Inventory.subcat;
            price.Text = Inventory.cost;
            quantity.Text = Inventory.quanti;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                string numericString = price.Text.Replace("₱", "").Replace(",", "");
                myConn.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE Storage SET ProductName = @prod, BrandName = @brand, Category = @category, SubCategory = @subcategory, Price = @price, Quantity = @quantity  WHERE ProductName = @prod", myConn);
                cmd.Parameters.AddWithValue("@prod", prod.Text);
                cmd.Parameters.AddWithValue("@brand", brand.Text);
                cmd.Parameters.AddWithValue("@category", categoryT.Text);
                cmd.Parameters.AddWithValue("@subcategory", Scategory.Text);
                cmd.Parameters.AddWithValue("@price", numericString);
                cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(quantity.Text));
                cmd.ExecuteNonQuery();
                myConn.Close();
                storage.clear_Click(sender, e);
                storage.load();
                MessageBox.Show("Update is successful!");
                Close();
                storage.editted();
            }
            catch(Exception ex) { MessageBox.Show("An Error Occurred! "+ex); }
        }

        private void cButton1_Click(object sender, EventArgs e)
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

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
