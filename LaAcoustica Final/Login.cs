using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaAcoustica_Final
{
    public partial class Login : Form
    {
        public static string idNum;
        public static string lname;
        public static string fname;
        public static string acc;
        string accType;
        bool mouseDown;
        Point lastLocation;

        //Moving the Form around
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        public Login()
        {

            InitializeComponent();

        }
        //Windows Maximize and minimize
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //LOGIN USER AND ADMIN
        private void log_Click(object sender, EventArgs e)
        {
            using (OleDbConnection myConn = new OleDbConnection(StaticClass.connString))
            {
                myConn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = myConn;
                command.CommandText = "Select * FROM Accounts where Username = @user and Password = @pass";
                command.Parameters.AddWithValue("@user", user.Text);
                command.Parameters.AddWithValue("@pass", pass.Text);
                OleDbDataReader read = command.ExecuteReader();
                if (read.HasRows)
                {
                    read.Read();
                    idNum = read["ID"].ToString();
                    accType= read["AccType"].ToString();
                    read.Close();
                    command.Parameters.Clear();
                    myConn.Close();

                    myConn.Open();
                    if (accType == "Customer")
                        command.CommandText = "Select LastName,FirstName FROM Customer where ID = @id";
                    else 
                        command.CommandText = "Select LastName,FirstName,[Position] FROM Worker where ID = @id";
                    command.Parameters.AddWithValue("@id", idNum);
                    read = command.ExecuteReader();
                    if (read.HasRows)
                    {
                        read.Read();
                        lname = read["LastName"].ToString();
                        fname = read["FirstName"].ToString();
                        if (accType == "Worker")
                            acc = read["Position"].ToString();
                        else
                            acc = accType;
                    }
                    myConn.Close();
                    if (acc == "Admin" || acc == "Main")
                    {
                        Menu mn = new Menu();
                        this.Hide();
                        mn.Show();
                    }
                    else
                    {
                        this.Hide(); myConn.Close();
                        Employee emp = new Employee();
                        emp.Show();
                    }
                }

                else
                {
                    MessageBox.Show("Invalid Account!");
                    user.Text = "";
                    pass.Text = "";
                }
            }
        }
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                log_Click(sender, e);
            }
        }

        private void Login_Press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                log.PerformClick();
            }
        }

        private void clear_Click_1(object sender, EventArgs e)
        {
            user.Text = "";
            pass.Text = "";
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

        private void register_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.Show();
        }

        private void hov(object sender, EventArgs e)
        {
            register_btn.ForeColor = System.Drawing.Color.RoyalBlue;
        }

        private void lev(object sender, EventArgs e)
        {
            register_btn.ForeColor = System.Drawing.Color.Navy;
        }
    }
}
