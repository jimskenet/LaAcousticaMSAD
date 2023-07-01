using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaAcoustica_Final
{
    public partial class Home : Form
    {
        bool mouseDown;
        Point lastLocation;

        //Moving the Form around
        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void Home_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void Home_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        public Home()
        {
            InitializeComponent();
            ShowTime();
        }
        private void ShowTime()
        {
            date.Text = DateTime.Now.ToLongDateString();
            Time.Text = DateTime.Now.ToShortTimeString();
        }

        private void sell_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Hide the Menu form
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form form in forms)
            {
                if (form.Name == "Menu")
                {
                    form.Hide();
                    break;
                }
            }
            // Show the Employee form
            Employee emp = new Employee();
            emp.Show();
        }
    }
}
