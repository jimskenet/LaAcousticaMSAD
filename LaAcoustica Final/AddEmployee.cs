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
    public partial class AddEmployee : Form
    {
        bool mouseDown;
        Point lastLocation;
        EmployeeEdit employee = (EmployeeEdit)Application.OpenForms["EmployeeEdit"];
        public AddEmployee()
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
                if (accnum.Text == "" || ls.Text == "" || fs.Text == "" || mi.Text == "" || user.Text == "" || pass.Text == "" || at.Text == "" || em.Text == "")
                {
                    MessageBox.Show("Invalid Input!");
                    employee.clear_Click(sender, e);
                }
                else
                {
                    OleDbConnection myConn = new OleDbConnection(StaticClass.connString);
                    string query = "INSERT INTO Accounts (ID, [Username], [Password], AccType) VALUES (@id,@u,@p,@accT)";
                    OleDbCommand cmd = new OleDbCommand(query, myConn);
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

                    employee.filter_table();
                    MessageBox.Show("Employee Added!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error due to Duplicate "+ex);
            }
        }
        private void EmployeeEdit_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void EmployeeEdit_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                     (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void EmployeeEdit_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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
    }
}
