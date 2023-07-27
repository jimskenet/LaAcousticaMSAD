using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
            OleDbDataAdapter da;
            DataSet ds;
            OleDbCommand cmd;
            string at = "Customer";
            bool acc = true;

            string query;
            using (OleDbConnection myConn = new OleDbConnection(StaticClass.connString))
            {
                myConn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = myConn;
                command.CommandText = "Select * FROM Accounts where Username = @user";
                command.Parameters.AddWithValue("@user", un.Text);
                OleDbDataReader read = command.ExecuteReader();
                if (read.HasRows)
                    acc = false;
            }

            if (fn.Text == "" || ln.Text == "" || un.Text == "" || pw.Text == "")
            {
                MessageBox.Show("Fill each Requirement", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (pw.Text != conpw.Text)
            {
                MessageBox.Show("Passwords do not match! Try again.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pw.Text = ""; conpw.Text = "";
            }
            else if (acc == false)
            {
                MessageBox.Show("Username has already been taken! Try again.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                un.Text = "";
                acc = true;
            }
            else
            {
                var idGenerator = new ShortIdGenerator(StaticClass.connString);
                //Automation of Customer ID based of how many existing IDs are there
                query = "Select ID FROM Accounts where AccType = 'Customer'";

                da = new OleDbDataAdapter(query, myConn);
                myConn.Open();
                ds = new DataSet();
                da.Fill(ds,"Accounts");
                string id = idGenerator.GenerateShortId().ToString();
                myConn.Close();

                using (myConn = new OleDbConnection(StaticClass.connString))
                {
                    query = "INSERT INTO Accounts (ID, [Username], [Password], AccType) VALUES (@id,@u,@p,@accT)";
                    cmd = new OleDbCommand(query, myConn);
                    myConn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@u", un.Text);
                    cmd.Parameters.AddWithValue("@p", pw.Text);
                    cmd.Parameters.AddWithValue("@accT", at);
                    cmd.ExecuteNonQuery();
                }

                using (myConn = new OleDbConnection(StaticClass.connString))
                {
                    query = "INSERT INTO Customer (ID, [LastName], [FirstName], MI, [Email]) VALUES (@id,@last,@first,@middle,@em)";
                    cmd = new OleDbCommand(query, myConn);
                    myConn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@last", ln.Text);
                    cmd.Parameters.AddWithValue("@first", fn.Text);
                    cmd.Parameters.AddWithValue("@middle", mi.Text);
                    cmd.Parameters.AddWithValue("@em", email.Text);
                    cmd.ExecuteNonQuery();
                }

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
        private void Register_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               submit_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void Register_Press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                submit.PerformClick();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pw.PasswordChar = '\0'; // show the password
            }
            else
            {
                pw.PasswordChar = '*'; // hide the password
            }
        }
    }
    //THIS SECTION IS FOR THE ID GENERATOR
    public class ShortIdGenerator
    {
        private const string Characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private const int IdLength = 5;

        private readonly Random random;
        private readonly OleDbConnection connection;

        public ShortIdGenerator(string connectionString)
        {
            random = new Random();
            connection = new OleDbConnection(connectionString);
        }

        public string GenerateShortId()
        {
            string id;

            do
            {
                id = GenerateRandomId();
            }
            while (IsIdExistsInDatabase(id));

            return id;
        }

        private string GenerateRandomId()
        {
            var id = new char[IdLength];

            for (int i = 0; i < IdLength; i++)
            {
                id[i] = Characters[random.Next(Characters.Length)];
            }

            return "C" + new string(id).Substring(1);
        }

        private bool IsIdExistsInDatabase(string id)
        {
            using (var command = new OleDbCommand("SELECT COUNT(*) FROM Customer WHERE ID = @Id", connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();

                return count > 0;
            }
        }
    }

}
