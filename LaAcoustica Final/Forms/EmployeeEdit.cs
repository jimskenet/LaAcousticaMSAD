using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace LaAcoustica_Final
{
    public partial class EmployeeEdit : Form
    {
        bool deleteFlag;
        
        public EmployeeEdit()
        {
            InitializeComponent();
        }
        OleDbConnection myConn = new OleDbConnection(StaticClass.connString);
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;

        private void EmployeeEdit_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            myConn.Open();
            da = new OleDbDataAdapter("SELECT AccountNumber, [LastName], [FirstName], MI, [Username], [Password], AccType from Accounts", myConn);
            ds = new DataSet();
            da.Fill(ds, "Accounts");
            employeeData.DataSource = ds.Tables["Accounts"];
            myConn.Close();
        }
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Accounts (AccountNumber, [LastName], [FirstName], MI, [Username], [Password], AccType) VALUES (@ac,@last,@first,@middle,@u,@p,@accT)";
                cmd = new OleDbCommand(query, myConn);
                if (accnum.Text == "" || ls.Text == "" || fs.Text == "" || mi.Text == "" || user.Text == "" || pass.Text == "" || at.Text == "")
                {
                    MessageBox.Show("Invalid Input!");
                    clear_Click(sender, e);
                }
                else
                {
                    myConn.Open();
                    cmd.Parameters.AddWithValue("@ac", accnum.Text);
                    cmd.Parameters.AddWithValue("@last", ls.Text);
                    cmd.Parameters.AddWithValue("@first", fs.Text);
                    cmd.Parameters.AddWithValue("@middle", mi.Text);
                    cmd.Parameters.AddWithValue("@u", user.Text);
                    cmd.Parameters.AddWithValue("@p", pass.Text);
                    cmd.Parameters.AddWithValue("@accT", at.Text);
                    cmd.ExecuteNonQuery();
                    myConn.Close();
                    MessageBox.Show("Employee Added!");
                }
            }
            catch
            {
                MessageBox.Show("Error due to Duplicate");
            }
            finally { load(); }
                   
        }

        private void clear_Click(object sender, EventArgs e)
        {
            accnum.Text = "";
            ls.Text = "";
            fs.Text = "";
            mi.Text = "";
            user.Text = "";
            pass.Text = "";
            at.SelectedIndex = -1;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (deleteFlag == true)
            {
                MessageBox.Show("Logged In Account can't be Deleted");
                clear.PerformClick();
            }
            else
            {
                if (at.SelectedIndex != -1)
                {
                    string query = "Delete From Accounts Where AccountNumber = @an";
                    cmd = new OleDbCommand(query, myConn);
                    cmd.Parameters.AddWithValue("@pr", employeeData.CurrentRow.Cells[0].Value);
                    myConn.Open();
                    cmd.ExecuteNonQuery();
                    myConn.Close();
                    load();
                    MessageBox.Show("Employee Removed!");
                }
                else { MessageBox.Show("Main Admin Account is Restricted!"); }
            }
            
            
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE Accounts SET AccountNumber = @an, [LastName] = @ls, [FirstName] = @fs, MI = @mi, [Username] = @user, [Password] = @pass, AccType = @ac  WHERE [LastName] = @ls", myConn);
                cmd.Parameters.AddWithValue("@an", accnum.Text);
                cmd.Parameters.AddWithValue("@ls", ls.Text);
                cmd.Parameters.AddWithValue("@fs", fs.Text);
                cmd.Parameters.AddWithValue("@mi", mi.Text);
                cmd.Parameters.AddWithValue("@user", user.Text);
                cmd.Parameters.AddWithValue("@pass", pass.Text);
                cmd.Parameters.AddWithValue("@ac", at.Text);
                cmd.ExecuteNonQuery();
                myConn.Close();
                load();
            }
            catch { MessageBox.Show("An Error Occured!"); } 
        }

        private void SelectRow(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow row = employeeData.Rows[index];
            accnum.Text = row.Cells[0].Value.ToString();
            ls.Text = row.Cells[1].Value.ToString();
            fs.Text = row.Cells[2].Value.ToString();
            mi.Text = row.Cells[3].Value.ToString();
            user.Text = row.Cells[4].Value.ToString();
            pass.Text = row.Cells[5].Value.ToString();
            if(Login.idNum == row.Cells[0].Value.ToString()) { deleteFlag = true; }
            else { deleteFlag = false; }
            if(at.Items.IndexOf(row.Cells[6].Value.ToString()) == -1)
            {
                at.Enabled = false;
                at.SelectedIndex = -1;
            }
            else { at.Text = row.Cells[6].Value.ToString(); at.Enabled = true; }
        }
    }
}
