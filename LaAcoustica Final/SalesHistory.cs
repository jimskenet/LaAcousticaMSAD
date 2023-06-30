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
        public SalesHistory()
        {
            InitializeComponent();
            loadDaily();            
        }
        OleDbConnection myConn = new OleDbConnection(StaticClass.connString);
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        private void loadDaily()
        {
            da = new OleDbDataAdapter("SELECT * FROM Daily", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Daily");
            dailySale.DataSource = ds.Tables["Daily"];
            dailySale.Columns["Sales"].DefaultCellStyle.Format = "C";
            myConn.Close();
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
        }

        private void filter_Click(object sender, EventArgs e)
        {
            FilterDate();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            loadDaily();
        }
        private void FilterInvoice()
        {
            string query = "SELECT * FROM Daily WHERE InvoiceNumber = @in";
            string inVoice = invoice.Text.ToString();
            myConn.Open();
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@in", inVoice);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                panel1.Visible = true;
                invoiceNum.Text = reader["InvoiceNumber"].ToString();
                dateS.Text = reader["Date"].ToString();
                saleS.Text = Convert.ToDecimal(reader["Sales"]).ToString("C");
                MessageBox.Show("Invoice Number Found");
            }
            else { MessageBox.Show("Invoice Number not Found"); }
            myConn.Close();
        }


        private void filterInv_Click(object sender, EventArgs e)
        {
            FilterInvoice();
        }

        private void ref2_Click(object sender, EventArgs e)
        {
            loadDaily();
        }
    }
}
