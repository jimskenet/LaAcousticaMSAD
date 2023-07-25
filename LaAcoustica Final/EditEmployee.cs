using PdfSharp.Pdf.Content.Objects;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LaAcoustica_Final
{
    public partial class EditEmployee : Form
    {
        bool mouseDown;
        Point lastLocation;
        EmployeeEdit employee = (EmployeeEdit)Application.OpenForms["EmployeeEdit"];

        public EditEmployee()
        {
            InitializeComponent();
            accnum.Text = EmployeeEdit.accnumber;
            ls.Text = EmployeeEdit.lname;
            fs.Text = EmployeeEdit.fname;
            mi.Text = EmployeeEdit.mname;
            user.Text = EmployeeEdit.username;
            pass.Text = EmployeeEdit.password;
            em.Text = EmployeeEdit.email;
            at.SelectedIndex = EmployeeEdit.acctype;
        }

        private void min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
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

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection myConn = new OleDbConnection(StaticClass.connString);
                myConn.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE Accounts SET ID = @an, [Username] = @user, [Password] = @pass, AccType = @ac WHERE ID = @an", myConn);
                cmd.Parameters.AddWithValue("@an", accnum.Text);
                cmd.Parameters.AddWithValue("@user", user.Text);
                cmd.Parameters.AddWithValue("@pass", pass.Text);
                cmd.Parameters.AddWithValue("@ac", at.Text);
                cmd.ExecuteNonQuery();
                myConn.Close();

                if (EmployeeEdit.indexPass == 0)
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

                employee.filter_table();
                MessageBox.Show("Information has been successfully edited!");
                Close();
            }
            catch { MessageBox.Show("An Error Occured!"); }
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
