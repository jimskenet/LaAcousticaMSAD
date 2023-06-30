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
        OleDbDataReader reader;
        String weekNow;
        public Sale()
        {
            InitializeComponent();
            loadWeekly();
            loadMonthly();
            ShowTotalSales();
            ShowMonthlySales();
            ShowWeeklyySales();
            ShowDailySales();
        }
        private void loadWeekly()
        {
            da = new OleDbDataAdapter("SELECT * FROM Weekly", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Weekly");
            weeklySale.DataSource = ds.Tables["Weekly"];
            weeklySale.Columns["TotalSales"].DefaultCellStyle.Format = "C";
            myConn.Close();
        }
        private void loadMonthly()
        {
            da = new OleDbDataAdapter("SELECT * FROM Monthly", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Monthly");
            monthlySale.DataSource = ds.Tables["Monthly"];
            monthlySale.Columns["TotalSales"].DefaultCellStyle.Format = "C";
            myConn.Close();
        }
        private void ShowTotalSales()
        {
            string sql = "SELECT SUM(TotalSales) FROM Monthly";
            myConn.Open();
            cmd = new OleDbCommand(sql, myConn);
            object result = cmd.ExecuteScalar();
            string totalSales = string.Format("{0:C}", result);
            revenue.Text = totalSales;
            myConn.Close();
        }
        private void ShowMonthlySales()
        {
            string sql = "SELECT SUM(TotalSales) FROM Weekly";
            myConn.Open();
            cmd = new OleDbCommand(sql, myConn);
            object result = cmd.ExecuteScalar();
            string totalSales = string.Format("{0:C}", result);
            msales.Text = totalSales;
            decimal tomonthly = Convert.ToDecimal(result);
            UpdateMonthly(tomonthly);
            myConn.Close();
        }
        private void ShowWeeklyySales()
        {
            DateTime currentDate = DateTime.Now;
            CultureInfo culture = CultureInfo.CurrentCulture;
            Calendar calendar = culture.Calendar;
            int weekNumber = calendar.GetWeekOfYear(currentDate, culture.DateTimeFormat.CalendarWeekRule, culture.DateTimeFormat.FirstDayOfWeek);
            int dayOfMonth = currentDate.Day;
            int weekOfMonth = (int)Math.Ceiling((double)dayOfMonth / 7);
            weekNow = "Week" + weekOfMonth;
            string sql = "SELECT SUM(TotalSales) FROM Weekly WHERE Week = @week";
            myConn.Open();
            cmd = new OleDbCommand(sql, myConn);
            cmd.Parameters.AddWithValue("@week", weekNow);
            object result = cmd.ExecuteScalar();
            string totalSales = string.Format("{0:C}", result);
            wsales.Text = totalSales;
            myConn.Close();
        }
        private void ShowDailySales()
        {
            string dateNow = DateTime.Now.ToShortDateString();
            string sql = "SELECT SUM(Sales) FROM Daily WHERE Date = Date() ";
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
                totalSales = string.Format("{0:C}", result);
            }
            dsales.Text = totalSales;
        }
        private void UpdateWeekly(decimal daily)
        {
            DateTime currentDate = DateTime.Now;
            CultureInfo culture = CultureInfo.CurrentCulture;
            Calendar calendar = culture.Calendar;
            int weekNumber = calendar.GetWeekOfYear(currentDate, culture.DateTimeFormat.CalendarWeekRule, culture.DateTimeFormat.FirstDayOfWeek);
            int dayOfMonth = currentDate.Day;
            int weekOfMonth = (int)Math.Ceiling((double)dayOfMonth / 7);
            string weekNow = "Week" + weekOfMonth;
            if (myConn.State != ConnectionState.Open)
            {
                myConn.Open();
            }
            cmd = new OleDbCommand("UPDATE Weekly SET [TotalSales] = [TotalSales] + @ds  WHERE Week = @week", myConn);
            cmd.Parameters.AddWithValue("@ds", daily);
            cmd.Parameters.AddWithValue("@week", weekNow);
            cmd.ExecuteNonQuery();
            myConn.Close();
        }

        private void UpdateMonthly(decimal weekly)
        {
            string currentMonth = DateTime.Now.ToString("MMMM");
            if (myConn.State != ConnectionState.Open)
            {
                myConn.Open();
            }
            cmd = new OleDbCommand("UPDATE Monthly SET [TotalSales] = @ws  WHERE Month = @month", myConn);
            cmd.Parameters.AddWithValue("@ds", weekly);
            cmd.Parameters.AddWithValue("@month", currentMonth);
            cmd.ExecuteNonQuery();
            myConn.Close();

        }
    }
}
