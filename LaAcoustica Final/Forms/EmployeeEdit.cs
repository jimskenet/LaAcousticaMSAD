using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using System.Windows.Forms;

namespace LaAcoustica_Final
{
    public partial class EmployeeEdit : Form
    {
        bool deleteFlag;
        bool mouseDown;
        Point lastLocation;
        Menu menu = (Menu)Application.OpenForms["Menu"];
        //Moving the Form around
        private void EmployeeEdit_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void EmployeeEdit_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                menu.Location = new Point(
                     (menu.Location.X - lastLocation.X) + e.X, (menu.Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void EmployeeEdit_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        public EmployeeEdit()
        {
            InitializeComponent();
        }
        OleDbConnection myConn = new OleDbConnection(StaticClass.connString);
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        private void EmployeeEdit_Load(object sender, EventArgs e)
        {
            filter_combo.SelectedIndex = 0;
            filter_table();
        }

        private void filter_table()
        {
            if (filter_combo.SelectedIndex == 0)
                Worker_load();
            else
                Customer_load();
        }
        //NOT SHOW PASS FOR CUSTOMERS
        private void Worker_load()
        {
            myConn.Open();
            da = new OleDbDataAdapter("SELECT Accounts.ID, [Accounts.Username], [Accounts.Password], Worker.LastName, Worker.FirstName, Worker.MI, Worker.Email, [Worker.Position]\r\nFROM Accounts INNER JOIN Worker ON Accounts.ID = Worker.ID;", myConn);
            ds = new DataSet();
            da.Fill(ds, "Accounts");

            employeeData.DataSource = ds.Tables["Accounts"];
            employeeData.Columns[1].HeaderText = "Username"; //From Accounts.Username -> Username
            employeeData.Columns[7].HeaderText = "Position"; //From Worker.Position -> Position
            employeeData.Columns[2].Visible = false; //Hide password column
            employeeData.Sort(employeeData.Columns[0], ListSortDirection.Ascending);
            myConn.Close();

            employeeData.ClearSelection();
        }

        private void Customer_load()
        {
            myConn.Open();
            da = new OleDbDataAdapter("SELECT Accounts.ID, [Accounts.Username], [Accounts.Password], Customer.LastName, Customer.FirstName, Customer.MI, Customer.Email\r\nFROM Accounts INNER JOIN Customer ON Accounts.ID = Customer.ID;\r\n", myConn);
            ds = new DataSet();
            da.Fill(ds, "Accounts");

            employeeData.DataSource = ds.Tables["Accounts"];
            employeeData.Columns[1].HeaderText = "Username"; //From Accounts.Username -> Username
            employeeData.Columns[2].Visible = false; //Hide password column
            employeeData.Sort(employeeData.Columns[0], ListSortDirection.Ascending);
            myConn.Close();

            employeeData.ClearSelection();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (accnum.Text == "" || ls.Text == "" || fs.Text == "" || mi.Text == "" || user.Text == "" || pass.Text == "" || at.Text == "" || em.Text == "")
                {
                    MessageBox.Show("Invalid Input!");
                    clear_Click(sender, e);
                }
                else if(at.Text == "Customer")
                {
                    MessageBox.Show("Customers should sign up using their assigned registration form!");
                    clear_Click(sender, e);
                }
                else
                {
                    string query = "INSERT INTO Accounts (ID, [Username], [Password], AccType) VALUES (@id,@u,@p,@accT)";
                    cmd = new OleDbCommand(query, myConn);
                    myConn.Open();
                    cmd.Parameters.AddWithValue("@id", accnum.Text);
                    cmd.Parameters.AddWithValue("@u", user.Text);
                    cmd.Parameters.AddWithValue("@p", pass.Text);
                    cmd.Parameters.AddWithValue("@accT", "Worker");
                    cmd.ExecuteNonQuery();
                    myConn.Close();

                    query = "INSERT INTO Worker (ID, [LastName], [FirstName], MI, [Position], [Email]) VALUES (@id,@last,@first,@middle,@pos,@em)";
                    cmd = new OleDbCommand(query, myConn);
                    myConn.Open();
                    cmd.Parameters.AddWithValue("@id", accnum.Text);
                    cmd.Parameters.AddWithValue("@last", ls.Text);
                    cmd.Parameters.AddWithValue("@first", fs.Text);
                    cmd.Parameters.AddWithValue("@middle", mi.Text);
                    cmd.Parameters.AddWithValue("@pos", at.Text);
                    cmd.Parameters.AddWithValue("@em", em.Text);
                    cmd.ExecuteNonQuery();
                    myConn.Close();

                    filter_table();
                    MessageBox.Show("Employee Added!");
                }
            }
            catch
            {
                MessageBox.Show("Error due to Duplicate ");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            accnum.Text = "";
            ls.Text = "";
            fs.Text = "";
            mi.Text = "";
            user.Text = "";
            pass.Text = "";
            at.SelectedIndex = -1;
            em.Text = "";
            employeeData.ClearSelection();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (deleteFlag == true)
            {
                MessageBox.Show("Logged In Account can't be Deleted");
                clear.PerformClick();
            }
            else
            {
                if (at.SelectedIndex != 2)
                {
                    string query = "Delete From Accounts Where ID = @an";
                    cmd = new OleDbCommand(query, myConn);
                    cmd.Parameters.AddWithValue("@an", employeeData.CurrentRow.Cells[0].Value);
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                    myConn.Close();

                    if (filter_combo.SelectedIndex == 1)
                    {
                        query = "Delete From Customer Where ID = @an";
                        cmd = new OleDbCommand(query, myConn);
                        cmd.Parameters.AddWithValue("@an", employeeData.CurrentRow.Cells[0].Value);
                        myConn.Open();
                        cmd.ExecuteNonQuery();
                        myConn.Close();
                    }
                    else
                    {
                        query = "Delete From Worker Where ID = @an";
                        cmd = new OleDbCommand(query, myConn);
                        cmd.Parameters.AddWithValue("@an", employeeData.CurrentRow.Cells[0].Value);
                        myConn.Open();
                        cmd.ExecuteNonQuery();
                        myConn.Close();
                    }

                    filter_table();
                    clear_Click(sender, e);

                    if(at.SelectedItem.ToString()=="Employee")
                        MessageBox.Show("Employee Removed!");
                    else
                        MessageBox.Show("Customer Removed!");
                }
                else { MessageBox.Show("Main Admin Account is Restricted!"); }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE Accounts SET ID = @an, [Username] = @user, [Password] = @pass, AccType = @ac WHERE ID = @an", myConn);
                cmd.Parameters.AddWithValue("@an", accnum.Text);
                cmd.Parameters.AddWithValue("@user", user.Text);
                cmd.Parameters.AddWithValue("@pass", pass.Text);
                cmd.Parameters.AddWithValue("@ac", at.Text);
                cmd.ExecuteNonQuery();
                myConn.Close();

                if (filter_combo.SelectedIndex == 0)
                {
                    myConn.Open();
                    cmd = new OleDbCommand("UPDATE Worker SET ID = @an, [LastName] = @ls, [FirstName] = @fs, MI = @mi, [Position] = @pos, [Email] = @em  WHERE ID = @an", myConn);
                    cmd.Parameters.AddWithValue("@an", accnum.Text);
                    cmd.Parameters.AddWithValue("@ls", ls.Text);
                    cmd.Parameters.AddWithValue("@fs", fs.Text);
                    cmd.Parameters.AddWithValue("@mi", mi.Text);
                    cmd.Parameters.AddWithValue("@pos", at.Text);
                    cmd.Parameters.AddWithValue("@em", em.Text);
                    cmd.ExecuteNonQuery();
                    myConn.Close();
                }
                else
                {
                    myConn.Open();
                    cmd = new OleDbCommand("UPDATE Customer SET ID = @an, [LastName] = @ls, [FirstName] = @fs, MI = @mi, [Email] = @em  WHERE ID = @an", myConn);
                    cmd.Parameters.AddWithValue("@an", accnum.Text);
                    cmd.Parameters.AddWithValue("@ls", ls.Text);
                    cmd.Parameters.AddWithValue("@fs", fs.Text);
                    cmd.Parameters.AddWithValue("@mi", mi.Text);
                    cmd.Parameters.AddWithValue("@em", em.Text);
                    cmd.ExecuteNonQuery();
                    myConn.Close();
                }

                filter_table();
            }
            catch { MessageBox.Show("An Error Occured!"); }
        }

        private void SelectRow(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            try
            {
                DataGridViewRow row = employeeData.Rows[index];
                if (e.RowIndex == -1) return;

                accnum.Text = row.Cells[0].Value.ToString();
                ls.Text = row.Cells["LastName"].Value.ToString();
                fs.Text = row.Cells["FirstName"].Value.ToString();
                mi.Text = row.Cells["MI"].Value.ToString();
                user.Text = row.Cells["Accounts.Username"].Value.ToString();
                pass.Text = row.Cells["Accounts.Password"].Value.ToString();
                em.Text = row.Cells["Email"].Value.ToString();
                if (accnum.Text == "A0")
                {
                    accnum.Text = "";
                    ls.Text = "";
                    fs.Text = "";
                    mi.Text = "";
                    user.Text = "";
                    pass.Text = "";
                    em.Text = "";
                    at.Text = "";
                }

                if (Login.idNum == row.Cells[0].Value.ToString()) { deleteFlag = true; }
                else { deleteFlag = false; }
                if (filter_combo.SelectedIndex==0)
                {
                    at.SelectedIndex = at.Items.IndexOf(row.Cells["Worker.Position"].Value.ToString());
                    if (at.SelectedIndex == 3)
                        at.Enabled = true;
                    else
                        at.Enabled = false;
                }
                else { at.SelectedIndex = 1; at.Enabled = false; }
            }
            catch{}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pass.PasswordChar = '\0'; // show the password
            }
            else
            {
                pass.PasswordChar = '*'; // hide the password
            }
        }

        private void filter_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter_table();
        }
    }
}