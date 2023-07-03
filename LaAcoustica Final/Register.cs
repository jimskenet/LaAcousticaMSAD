using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    public partial class Register : Form
    {
        OleDbConnection myConn = new OleDbConnection(StaticClass.connString);
        bool mouseDown;
        Point lastLocation;

        //Moving the Form around
        internal void Register_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        internal void Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        internal void Register_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        public Register()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string at = "Customer";
            if(fn.Text == "" || ln.Text == "" || mi.Text == "" || an.Text == "" || un.Text == "" || pw.Text == "")
            {
                MessageBox.Show("Fill each Requirement");
            }
            else
            {
                string query = "INSERT INTO Accounts (AccountNumber, [LastName], [FirstName], MI, [Username], [Password], AccType, [Email]) VALUES (@ac,@last,@first,@middle,@u,@p,@accT,@em)";
                OleDbCommand cmd = new OleDbCommand(query, myConn);
                myConn.Open();
                cmd.Parameters.AddWithValue("@ac", an.Text);
                cmd.Parameters.AddWithValue("@last", ln.Text);
                cmd.Parameters.AddWithValue("@first", fn.Text);
                cmd.Parameters.AddWithValue("@middle", mi.Text);
                cmd.Parameters.AddWithValue("@u", un.Text);
                cmd.Parameters.AddWithValue("@p", pw.Text);
                cmd.Parameters.AddWithValue("@accT", at);
                cmd.Parameters.AddWithValue("@em", email.Text);
                cmd.ExecuteNonQuery();
                myConn.Close();
                MessageBox.Show("Account Added!");
                this.Hide();
                Login lg = new Login();
                lg.Show();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

    }
}
