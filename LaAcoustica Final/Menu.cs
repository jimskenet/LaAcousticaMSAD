using FontAwesome.Sharp;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaAcoustica_Final
{
    public partial class Menu : Form
    {
        string imagePath = "jpg(3).jpg";
        bool mouseDown;
        Point lastLocation;

        //Moving the Form around
        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void Menu_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        public Menu()
        {
            
            InitializeComponent();
            name.Text = Login.lname + " " + Login.fname;
            OpenChildForm(new Home());
            ShowProfile();

        }
        private bool isCollapsed;

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }
        //OPENS FORMS
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }             
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildform.Controls.Add(childForm);
            panelChildform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //FORMS
        private void inventory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Inventory());
        }

        private void employee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeEdit());
        }

        private void sale_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void home_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                PnlSales.Height += 200;
                if(PnlSales.Size == PnlSales.MaximumSize) 
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                PnlSales.Height -= 200;
                if (PnlSales.Size == PnlSales.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void SalesRep_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sale());
        }

        private void SalesHis_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SalesHistory());
        }
        private void Profile()
        {
            OleDbConnection myConn = StaticClass.myConn;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog1.FileName;
            }
            myConn.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE Accounts SET ProfPic = @pp  WHERE AccountNumber = @an", myConn);
            cmd.Parameters.AddWithValue("@pp", imagePath);
            cmd.Parameters.AddWithValue("@an", Login.idNum);
            cmd.ExecuteNonQuery();
            myConn.Close();
        }
        private void ShowProfile()
        {
            OleDbConnection myConn = StaticClass.myConn;
            myConn.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = myConn;
            command.CommandText = "Select ProfPic FROM Accounts WHERE AccountNumber = @an";
            command.Parameters.AddWithValue("@an", Login.idNum);
            OleDbDataReader read = command.ExecuteReader();
            if (read.HasRows)
            {
                read.Read();
                string path = read["ProfPic"].ToString();
                if (!string.IsNullOrEmpty(path) && System.IO.File.Exists(path))
                {
                    roundPicture1.Image = Image.FromFile(path);
                }
                else
                {
                    // If the path is null, empty, or invalid, set the profile picture to a default image
                    roundPicture1.Image = Image.FromFile(imagePath);
                }
            }
            else
            {
                // If the record for the account number does not exist, set the profile picture to a default image
                roundPicture1.Image = Image.FromFile(imagePath);
            }
            myConn.Close();
        }

        private void enter(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void leave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void profile_Click(object sender, EventArgs e)
        {
            Profile();
            ShowProfile();
        }
    }
}
