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
        internal static int indexPass, acctype;
        internal static string accnumber,lname,fname,mname,username, password, email;
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
            Worker_load();
        }

        protected internal void filter_table()
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
            employeeData.Columns[1].HeaderText = "Username";
            employeeData.Columns[7].HeaderText = "Position";
            employeeData.Columns[2].Visible = false;
            employeeData.Sort(employeeData.Columns[0], ListSortDirection.Ascending);
            myConn.Close();

            BeginInvoke((Action)(() => //Makes the dgv load first then begins to execute ClearSelection()
            {
                employeeData.ClearSelection(); // Clear selection after data is loaded
            }));
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
            AddEmployee add = new AddEmployee();
            add.Show();
        }

        protected internal void clear_Click(object sender, EventArgs e)
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
            if (deleteFlag != true && accnum.Text!="")
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

                if (at.Text == "Employee")
                    MessageBox.Show("Employee Removed!");
                else
                    MessageBox.Show("Customer Removed!");
            }
            else if (accnum.Text == "" && at.Text != "Main")
                MessageBox.Show("No account is selected", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if(at.SelectedIndex == 2) 
                    MessageBox.Show("Main Admin Account is Restricted!", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Logged In Account can't be Deleted", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                if(at.Text == "Main")
                    MessageBox.Show("Main Admin Account is Restricted!", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (accnum.Text == "")
                    MessageBox.Show("No account is selected", "Account Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    EditEmployee edit = new EditEmployee();
                    edit.Show();
                }
                clear_Click(sender, e);
            }
            catch { MessageBox.Show("An Error Occured! "); }
        }

        private void SelectRow(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            try
            {
                DataGridViewRow row = employeeData.Rows[index];
                if (e.RowIndex == -1) return;

                accnumber= accnum.Text = row.Cells[0].Value.ToString();
                lname= ls.Text = row.Cells["LastName"].Value.ToString();
                fname= fs.Text = row.Cells["FirstName"].Value.ToString();
                mname= mi.Text = row.Cells["MI"].Value.ToString();
                username= user.Text = row.Cells["Accounts.Username"].Value.ToString();
                password= pass.Text = row.Cells["Accounts.Password"].Value.ToString();
                email = em.Text = row.Cells["Email"].Value.ToString();
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
                if (filter_combo.SelectedIndex == 0)
                {
                    acctype = at.SelectedIndex = at.Items.IndexOf(row.Cells["Worker.Position"].Value.ToString());
                }
                else { at.SelectedIndex = 1; at.Enabled = false; }
                indexPass = filter_combo.SelectedIndex;
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