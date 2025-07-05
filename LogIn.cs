using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffandStallManagementSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
            btnclose.Click += Btnclose_Click;
        }
        public DataRow CheckUserLogin(string username, string password)
        {
            //string connectionString = "your_connection_string_here"; // replace with your DB connection
            //using (SqlConnection conn = new SqlConnection(Program.Connection))
            using (SqlCommand cmd = new SqlCommand("CheckUserLogin", Program.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable result = new DataTable();
                adapter.Fill(result);

                if (result.Rows.Count > 0)
                {
                    // Login successful: return first row
                    return result.Rows[0];
                }
                else
                {
                    // Login failed: return null
                    return null;
                }
            }
        }

        private void Btnclose_Click(object? sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
           
            string username = txtname.Text;
            string password = txtpas.Text;

            DataRow userRow = CheckUserLogin(username, password);

            if (userRow != null)
            {
                MessageBox.Show("Login successful! Welcome " + userRow["StaffNameEN"]);

                // Optional: store user data
                Program.nameStaff = userRow["StaffNameEN"].ToString();
                Program.nameStaffKh = userRow["StaffNameKH"].ToString();
                Program.positonStaff = userRow["StaffPosition"].ToString();
                Program.idstaff= Convert.ToInt32(userRow["UserID"]);
                //string role = userRow["StaffPosition"].ToString();
                new MultiForm().Show();
                this.Hide();
                // Redirect to next form, etc.
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
