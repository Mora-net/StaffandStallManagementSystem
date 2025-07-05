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
using System.Xml.Linq;

namespace StaffandStallManagementSystem
{
    public partial class FormUser : UserControl
    {
        public FormUser()
        {
            InitializeComponent();
            LoadStaffFromView();
            cbname.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            btnnew.Click += Btnnew_Click;
            btnsave.Click += Btnsave_Click;
            txtsearch.TextChanged += Txtsearch_TextChanged;
            lbuser.SelectedIndexChanged += Lbuser_SelectedIndexChanged;
            btnupdate.Click += Btnupdate_Click;
            btnclose.Click += Btnclose_Click;
            txtlogout.Click += Txtlogout_Click;
        }
        private void Btnclose_Click(object? sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Txtlogout_Click(object? sender, EventArgs e)
        {
            Form MultiForm = this.FindForm();
            if (MultiForm != null)
            {
                // Hide MainForm
                MultiForm.Hide();

                // Open LoginForm
                LogIn loginForm = new LogIn();
                loginForm.FormClosed += (s, args) => MultiForm.Show(); // Re-show MainForm if needed
                loginForm.Show();
            }
        }

        private void Btnupdate_Click(object? sender, EventArgs e)
        {
            try
            {

                Program.Connection.Open();

                Program.UpdateUserCommand.Parameters["@UserID"].Value = txtid.Text;
                Program.UpdateUserCommand.Parameters["@UserName"].Value = txtusername.Text;
                Program.UpdateUserCommand.Parameters["@Password"].Value = txtpass.Text;
                Program.UpdateUserCommand.Parameters["@StaffID"].Value = txtids.Text;
                Program.UpdateUserCommand.Parameters["@StaffNameEN"].Value = cbname.Text;
                Program.UpdateUserCommand.Parameters["@StaffNameKH"].Value = txtnamekh.Text;
                Program.UpdateUserCommand.Parameters["@StaffPosition"].Value = txtpos.Text;


                int n = Program.UpdateUserCommand.ExecuteNonQuery();
                MessageBox.Show($"{n} row(s) updated.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error > {ex.Message}", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Program.Connection.State == ConnectionState.Open)
                    Program.Connection.Close();
            }
        }

        private void Lbuser_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lbuser.SelectedValue != null && int.TryParse(lbuser.SelectedValue.ToString(), out int userId))
            {
                
                try
                {
                    Program.Connection.Open();
                    SqlCommand ReadAllUserCommand = Program.Connection.CreateCommand();
                    ReadAllUserCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    ReadAllUserCommand.CommandText = "sp_GetUserById";
                    ReadAllUserCommand.Parameters.AddWithValue("@UserId", userId);
                    using (SqlDataReader reader = ReadAllUserCommand.ExecuteReader())
                    {
                        groupBox1.Enabled = true;
                        cbname.DataSource = null;
                        cbname.Items.Clear();

                        if (reader.Read())
                        {
                            txtid.Text = reader["UserID"].ToString();
                            txtusername.Text = reader["UserName"].ToString();
                            txtpass.Text = reader["Password"].ToString();
                            cbname.Items.Add(reader["StaffNameEN"].ToString());
                            cbname.Text= reader["StaffNameEN"].ToString();
                            txtids.Text = reader["StaffID"].ToString();
                            txtnamekh.Text = reader["StaffNameKH"].ToString();
                            txtpos.Text = reader["StaffPosition"].ToString();
                        }
                    }

                    Program.Connection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Connection.Close();

                }

            }
        }

        private void Txtsearch_TextChanged(object? sender, EventArgs e)
        {
            lbuser.SelectedIndexChanged -= Lbuser_SelectedIndexChanged;
            if (string.IsNullOrWhiteSpace(txtsearch.Text))
            {
               lbuser.DataSource = null;
               lbuser.Items.Clear();
                return;
            }
            try
            {
                lbuser.ClearSelected();
                //using (SqlConnection conn = Program.Connection)
                DataTable dt = new DataTable();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.fn_SearchUserByName(@SearchName)", Program.Connection))
                {
                    cmd.Parameters.AddWithValue("@SearchName", txtsearch.Text);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        lbuser.ClearSelected();
                    }
                }
                // Reset ListBox before rebinding
                lbuser.DataSource = null;
                lbuser.Items.Clear();

                // Rebind
                lbuser.DataSource = dt;
                lbuser.DisplayMember = "UserName";
                lbuser.ValueMember = "UserID";
                lbuser.ClearSelected();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Program.Connection.Close();
            }
            lbuser.ClearSelected();
            lbuser.SelectedIndexChanged += Lbuser_SelectedIndexChanged;
        }

        private void Btnsave_Click(object? sender, EventArgs e)
        {
            try

            {
                //if (Program.Connection.State != ConnectionState.Open)
                Program.Connection.Open();
                Program.InserUserCommand.Parameters["@UserID"].Value = txtid.Text;
                Program.InserUserCommand.Parameters["@UserName"].Value = txtusername.Text;
                Program.InserUserCommand.Parameters["@Password"].Value = txtpass.Text;
                Program.InserUserCommand.Parameters["@StaffID"].Value = txtids.Text;
                Program.InserUserCommand.Parameters["@StaffNameEN"].Value = cbname.Text;
                Program.InserUserCommand.Parameters["@StaffNameKH"].Value = txtnamekh.Text;
                Program.InserUserCommand.Parameters["@StaffPosition"].Value = txtpos.Text;
                int n = Program.InserUserCommand.ExecuteNonQuery();
                MessageBox.Show($"{n} Row Has Been Saved", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error > {ex.Message}", "Creating",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(sa);
                Program.Connection.Close();
            }
            finally
            {
                if (Program.Connection.State == ConnectionState.Open)
                    Program.Connection.Close();
            }
        }
        private void Btnnew_Click(object? sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            SqlCommand cmd = new SqlCommand("SELECT dbo.fn_CountUsers()", Program.Connection);
            Program.Connection.Open();
            int userCount = (int)cmd.ExecuteScalar() + 1; // Get the single int value
            Program.Connection.Close();
            txtid.Text = userCount.ToString();
            LoadStaffFromView();
            txtusername.Text = "";
            txtpass.Text = "";
            cbname.Text ="";
            txtids.Text = "";
            txtnamekh.Text = "";
            txtpos.Text = "";
            


        }
        private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cbname.SelectedValue != null && int.TryParse(cbname.SelectedValue.ToString(), out int staffId))
            {
                try
                {

                    Program.Connection.Open();
                    SqlCommand ReadAllStaffCommand = Program.Connection.CreateCommand();
                    ReadAllStaffCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    ReadAllStaffCommand.CommandText = "spSearchStaffByID";
                    ReadAllStaffCommand.Parameters.AddWithValue("@id", staffId);
                    using (SqlDataReader reader = ReadAllStaffCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtids.Text = reader["StaffID"].ToString();
                            txtnamekh.Text = reader["StaffNameKH"].ToString();
                            txtpos.Text = reader["StaffPosition"].ToString();
                        }
                    }
                    Program.Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Connection.Close();

                }
            }
        }
        private void LoadStaffFromView()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM vw_StaffList", Program.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbname.DataSource = dt;
                cbname.DisplayMember = "StaffNameEN";  // Or "StaffFullName" if view returns full name
                cbname.ValueMember = "StaffID";        // Internal ID
                cbname.SelectedIndex = -1; // ✅ No selection on load
                cbname.Text = "";
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }
    }
}
