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
    public partial class FormPayroll : UserControl
    {
        public FormPayroll()
        {
            InitializeComponent();
            LoadStaffFromView();
            cbname.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            btnnew.Click += Btnnew_Click;
            btnsave.Click+=Btnsave_Click;
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
                using (SqlCommand cmd = new SqlCommand("sp_UpdatePayroll", Program.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters from form controls
                    cmd.Parameters.AddWithValue("@PayrollID", Convert.ToInt32(txtid.Text)); // If using manual ID
                    cmd.Parameters.AddWithValue("@StaffID", Convert.ToInt16(txtids.Text));
                    cmd.Parameters.AddWithValue("@PayrollDate", dppay.Value);
                    cmd.Parameters.AddWithValue("@PaidAmount", Convert.ToDecimal(txtamount.Text));
                    cmd.Parameters.AddWithValue("@StaffNameEN", cbname.Text);
                    cmd.Parameters.AddWithValue("@StaffNameKH", txtnamekh.Text);
                    cmd.Parameters.AddWithValue("@StaffPosition", txtpos.Text);
                    Program.Connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Program.Connection.Close();
                        MessageBox.Show("Payroll updated successfully.");
                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    ReadAllUserCommand.CommandText = "sp_GetPayrollById";
                    ReadAllUserCommand.Parameters.AddWithValue("@PayrollId", userId);
                    using (SqlDataReader reader = ReadAllUserCommand.ExecuteReader())
                    {
                        groupBox1.Enabled = true;
                        cbname.DataSource = null;
                        cbname.Items.Clear();

                        if (reader.Read())
                        {
                            txtid.Text = reader["PayrollID"].ToString();
                            txtids.Text = reader["StaffID"].ToString();
                            dppay.Value = Convert.ToDateTime(reader["PayrollDate"]);
                            txtamount.Text = reader["PaidAmount"].ToString();
                            cbname.Items.Add(reader["StaffNameEN"].ToString());
                            cbname.Text = reader["StaffNameEN"].ToString();
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
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.fn_SearchPayrollByName(@Name)", Program.Connection))
                {
                    cmd.Parameters.AddWithValue("Name", txtsearch.Text);

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
                lbuser.DisplayMember = "StaffNameEN";
                lbuser.ValueMember = "PayrollID";
                lbuser.ClearSelected();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Connection.Close();
            }
            lbuser.ClearSelected();
            lbuser.SelectedIndexChanged += Lbuser_SelectedIndexChanged;
        }

        private void Btnsave_Click(object? sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertPayroll", Program.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters from your form controls
                    cmd.Parameters.AddWithValue("@PayrollID", Convert.ToInt32(txtid.Text)); // If using manual ID
                    cmd.Parameters.AddWithValue("@StaffID", Convert.ToInt16(txtids.Text));
                    cmd.Parameters.AddWithValue("@PayrollDate", dppay.Value);
                    cmd.Parameters.AddWithValue("@PaidAmount", Convert.ToDecimal(txtamount.Text));
                    cmd.Parameters.AddWithValue("@StaffNameEN",cbname.Text);
                    cmd.Parameters.AddWithValue("@StaffNameKH", txtnamekh.Text);
                    cmd.Parameters.AddWithValue("@StaffPosition",txtpos.Text);

                    Program.Connection.Open();
                    cmd.ExecuteNonQuery();
                    Program.Connection.Close();

                    MessageBox.Show("Payroll inserted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Program.Connection.State == ConnectionState.Open)
                    Program.Connection.Close();
            }
        }

        private void Btnnew_Click(object? sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            using (SqlCommand cmd = new SqlCommand("sp_CountPayroll", Program.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                Program.Connection.Open();
                int count = (int)cmd.ExecuteScalar()+1;
                Program.Connection.Close();
                txtid.Text = count.ToString();


            } 
            LoadStaffFromView();
            txtamount.Text = "";
            //txtpass.Text = "";
            cbname.Text = "";
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
        private void FormPayroll_Load(object sender, EventArgs e)
        {

        }
    }
}
