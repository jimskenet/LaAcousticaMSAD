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
