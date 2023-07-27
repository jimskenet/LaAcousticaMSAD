using FontAwesome.Sharp;
using Org.BouncyCastle.Asn1.X500;
using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaAcoustica_Final
{
    public partial class Sale : Form
    {
        OleDbConnection myConn = new OleDbConnection(StaticClass.connString);
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        Menu menu = (Menu)Application.OpenForms["Menu"];
        bool mouseDown;
        Point lastLocation;
        private void Sale_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Sale_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                menu.Location = new Point(
                    (menu.Location.X - lastLocation.X) + e.X, (menu.Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void Sale_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        public Sale()
        {
            InitializeComponent();
            loadYearly();
            loadMonthly();
            ShowDailySales();
            TotalRevenue();
            filter_report.SelectedIndex = 0;
        }
        private void loadYearly()
        {
            da = new OleDbDataAdapter("SELECT * FROM Yearly", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Yearly");
            YearlySale.DataSource = ds.Tables["Yearly"];
            YearlySale.Columns["TotalSales"].DefaultCellStyle.Format = "C";
            OleDbCommand command = new OleDbCommand();
            command.Connection = myConn;
            command.CommandText = "Select * FROM Yearly where year_id=@yr";
            command.Parameters.AddWithValue("@yr", DateTime.Now.Year);
            OleDbDataReader read = command.ExecuteReader();
            if (read.HasRows)
            {
                read.Read();
                ysales.Text = string.Format("₱{0:N}", read["TotalSales"]);
            }
            else
                ysales.Text = "₱0.00";
            myConn.Close();
        }
        private void loadMonthly()
        {
            da = new OleDbDataAdapter("SELECT Monthly.year_id, months.Month, Monthly.TotalSales\r\nFROM months INNER JOIN Monthly ON months.month_id = Monthly.month_id\r\nORDER BY Monthly.year_id DESC , Monthly.month_id;\r\n", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Monthly");
            monthlySale.DataSource = ds.Tables["Monthly"];
            monthlySale.Columns["TotalSales"].DefaultCellStyle.Format = "C";
            myConn.Close();

            myConn.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = myConn;
            command.CommandText = "Select * FROM Monthly where month_id=@mnth and year_id=@yr";
            command.Parameters.AddWithValue("@mnth", DateTime.Now.Month);
            command.Parameters.AddWithValue("@yr", DateTime.Now.Year);
            OleDbDataReader read = command.ExecuteReader();
            if (read.HasRows)
            {
                read.Read();
                msales.Text = string.Format("₱{0:N}", read["TotalSales"]);
            }
            else
                msales.Text = "₱0.00";
            myConn.Close();
        }
        private void TotalRevenue()
        {
            string sql = "SELECT SUM(TotalSales) FROM Yearly";
            myConn.Open();
            cmd = new OleDbCommand(sql, myConn);
            object result = cmd.ExecuteScalar();
            myConn.Close();
            string totalSales;
            if (result == null || result == DBNull.Value)
            {
                totalSales = "₱0.00";
            }
            else
            {
                totalSales = string.Format("₱{0:N}", result);
            }
            revenue.Text = totalSales;
        }
        private void ShowDailySales()
        {
            string sql = "SELECT SUM(Sales) FROM Daily WHERE Date = @dt ";
            myConn.Open();
            cmd = new OleDbCommand(sql, myConn);
            cmd.Parameters.AddWithValue("@dt", DateTime.Now.ToShortDateString());
            object result = cmd.ExecuteScalar();
            myConn.Close();
            string totalSales;
            if (result == null || result == DBNull.Value)
            {
                totalSales = "₱0.00";
            }
            else
            {
                totalSales = string.Format("₱{0:N}", result);
            }
            dsales.Text = totalSales;
        }
        private void Sale_Load(object sender, EventArgs e)
        {
            using (myConn = new OleDbConnection(StaticClass.connString))
            {
                string query, filter = filter_report.Text;
                if (filter == "Yearly")
                    query = "Select * FROM Yearly";
                else
                    query = "SELECT Monthly.year_id, months.Month, Monthly.TotalSales\r\nFROM months INNER JOIN Monthly ON months.month_id = Monthly.month_id\r\nORDER BY Monthly.year_id DESC , Monthly.month_id;";
                da = new OleDbDataAdapter(query, myConn);
                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "Sales");
                SalesReport.DataSource = ds.Tables["Sales"]; //Puts the content in the dataGrid

                if (filter == "Yearly")
                    SalesReport.Series[0].XValueMember = "year_id"; //Puts the content in the chart
                else
                    SalesReport.Series[0].XValueMember = "Month";
                SalesReport.Series[0].YValueMembers = "TotalSales";
                SalesReport.DataSource = ds;
                SalesReport.DataBind();
            }
            monthlySale.ClearSelection();
            YearlySale.ClearSelection();
        }
    }
}
