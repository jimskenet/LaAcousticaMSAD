using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaAcoustica_Final
{
    public partial class SalesHistory : Form
    {
        Menu menu = (Menu)Application.OpenForms["Menu"];
        bool mouseDown;
        Point lastLocation;
        private void SaleHistory_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void SaleHistory_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                menu.Location = new Point(
                    (menu.Location.X - lastLocation.X) + e.X, (menu.Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void SaleHistory_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        public SalesHistory()
        {
            InitializeComponent();
            loadDaily();
            reset();
        }
        OleDbConnection myConn = new OleDbConnection(StaticClass.connString);
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        private void loadDaily()
        {
            da = new OleDbDataAdapter("SELECT * FROM Daily ORDER BY [Date] DESC ", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Daily");
            dailySale.DataSource = ds.Tables["Daily"];
            dailySale.Columns["Sales"].DefaultCellStyle.Format = "C";
            myConn.Close();

            dailySale.Columns["month_id"].Visible = false;
            dailySale.Columns["year_id"].Visible = false;
        }
        private void FilterDate()
        {
            string startDate = dateTimePicker1.Value.ToShortDateString();
            string endDate = dateTimePicker2.Value.ToShortDateString();
            string query = "SELECT * FROM Daily WHERE Date BETWEEN #" + startDate + "# AND #" + endDate + "#";
            // Execute the query and populate the DataGridView
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, myConn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dailySale.DataSource = dataTable;
            dailySale.ClearSelection();
        }

        private void filter_Click(object sender, EventArgs e)
        {
            FilterDate();
        }
        private void reset()
        {
            string sql = "SELECT MIN([DATE]) AS Oldest, MAX([DATE]) AS Latest FROM Daily";
            myConn.Open();
            cmd = new OleDbCommand(sql, myConn);
            OleDbDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                DateTime oldestDate = Convert.ToDateTime(read["Oldest"]);
                DateTime latestDate = Convert.ToDateTime(read["Latest"]);

                // Assuming you have a DateTimePicker control named 'dateTimePicker'
                dateTimePicker1.Value = oldestDate;
                dateTimePicker2.Value = latestDate;
            }
            read.Close();
            myConn.Close();
            dailySale.ClearSelection();
            saleS.Text = "";
            dateS.Text = "";
            invoiceNum.Text = "";
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            loadDaily();
            reset();
        }

        private void dailySale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (e.RowIndex == -1 || e.RowIndex > dailySale.RowCount) return;

            DataGridViewRow row = dailySale.Rows[indexRow];
            invoiceNum.Text = row.Cells["InvoiceNumber"].Value.ToString();
            dateS.Text = Convert.ToDateTime(row.Cells["Date"].Value).ToShortDateString();
            string sale = string.Format("₱{0:N}", row.Cells["Sales"].Value);
            saleS.Text = sale;
        }

        private void SalesHistory_Load(object sender, EventArgs e)
        {
            dailySale.ClearSelection();
        }

        private void invoice_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Daily WHERE InvoiceNumber LIKE '%' + @in + '%'";
            myConn.Open();
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@in", invoice.Text);
            da = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "Daily");
            dailySale.DataSource = ds.Tables["Daily"];
            dailySale.Columns["Sales"].DefaultCellStyle.Format = "C";

            dailySale.Columns["month_id"].Visible = false;
            dailySale.Columns["year_id"].Visible = false;
            myConn.Close();
            dailySale.ClearSelection();
        }
    }
}
