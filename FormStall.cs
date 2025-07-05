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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StaffandStallManagementSystem
{
    public partial class FormStall : UserControl
    {
        public FormStall()
        {
            InitializeComponent();
            LoadStallTypeFromView();
            cbid.SelectedIndexChanged += Cbname_SelectedIndexChanged;
            btnnew.Click += Btnnew_Click;
            btnsave.Click += Btnsave_Click;
            textsearch.TextChanged += Textsearch_TextChanged;
            updatebtn.Click += Updatebtn_Click;
            dataGridView1.Click += DataGridView1_Click;
            cbid.Click += Cbid_Click;
            btnlogout.Click += Txtlogout_Click;
            btnclose.Click += Btnclose_Click;
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
        private void Cbid_Click(object? sender, EventArgs e)
        {
            LoadStallTypeFromView();
        }

        private void DataGridView1_Click(object? sender, EventArgs e)
        {
            try
            {
                Program.Connection.Open();
                int id = Convert.ToByte(dataGridView1.CurrentRow.Cells["StallNo"].Value);
                
                SqlCommand ReadAllStaffCommand = Program.Connection.CreateCommand();
                ReadAllStaffCommand.CommandType = System.Data.CommandType.StoredProcedure;
                ReadAllStaffCommand.CommandText = "sp_GetStallById";
                ReadAllStaffCommand.Parameters.AddWithValue("@StallNo", id);
                using (SqlDataReader reader = ReadAllStaffCommand.ExecuteReader())
                {
                    cbid.DataSource = null;
                    cbid.Items.Clear();
                    if (reader.Read())
                    {
                        txtno.Text = reader["StallNo"].ToString();
                        txtname.Text = reader["StallTypeName"].ToString();
                        cbid.Text = reader["StallTypeID"].ToString();
                        cbst.Text = reader["Status"].ToString() == "True" ? "Rented" : "Available"; // Assuming "Rented" means true, adjust logic if needed
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

        private void Updatebtn_Click(object? sender, EventArgs e)
        {
            try
            {
                
                using (SqlCommand cmd = new SqlCommand("sp_UpdateStall", Program.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    bool st = true;
                    cmd.Parameters.AddWithValue("@StallNo",Convert.ToInt32( txtno.Text));

                    cmd.Parameters.AddWithValue("@StallTypeID", Convert.ToInt32(cbid.Text));
                    if (cbst.Text == "Rented") st = true;
                    else st = false; // Assuming "Rented" means true, otherwise adjust logic accordingly
                    cmd.Parameters.AddWithValue("@Status", st);
                    cmd.Parameters.AddWithValue("@StallTypeName", txtname.Text);

                    Program.Connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show("Stall updated successfully!");
                    Program.Connection.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
                Program.Connection.Close();
            }
        }

        private void Textsearch_TextChanged(object? sender, EventArgs e)
        {
            string searchName = textsearch.Text.Trim();
            if (searchName != "")
                try
                {
                    txtmessage.Text = "";
                    //using (SqlConnection conn = Program.Connection)
                    DataTable dt = new DataTable();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM fn_SearchStallByName(@Keyword)", Program.Connection))
                    {
                        cmd.Parameters.AddWithValue("@Keyword", searchName);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            Program.Connection.Open();
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                            Program.Connection.Close();
                        }


                    }
        

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Connection.Close();
                }

            //}
            else
            {
                dataGridView1.Columns.Clear();
                //txtmessage.Text = "Not Found ";

            }

        }

        private void Btnsave_Click(object? sender, EventArgs e)
        {

            using (SqlCommand cmd = new SqlCommand("sp_InsertStall", Program.Connection))
            {
                try
                {
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    bool st = true;
                    cmd.Parameters.AddWithValue("@StallNo", txtno.Text);

                    cmd.Parameters.AddWithValue("@StallTypeID", Convert.ToInt32(cbid.Text));
                    if (cbst.Text == "Rented") st = true;
                    else st = false; // Assuming "Rented" means true, otherwise adjust logic accordingly
                    cmd.Parameters.AddWithValue("@Status", st);
                    cmd.Parameters.AddWithValue("@StallTypeName", txtname.Text);
                    Program.Connection.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Have been saved ", "Saving ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.Connection.Close(); // Ensure connection is closed after operation

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.Connection.Close(); // Ensure connection is closed on error
                    return; // Exit if there's an error
                }
                
            }

        }

        private void Btnnew_Click(object? sender, EventArgs e)
        {
            int totalStalls = 0;
            SqlCommand cmd = new SqlCommand("sp_CountStalls", Program.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            Program.Connection.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    totalStalls = Convert.ToInt32(reader["TotalStalls"]) + 1;
                }
            }
            txtno.Text = totalStalls.ToString();
            Program.Connection.Close();


        }

        private void Cbname_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cbid.SelectedValue != null && int.TryParse(cbid.SelectedValue.ToString(), out int staffId))
            {
                try
                {
                    Program.Connection.Open();
                    SqlCommand ReadAllStaffCommand = Program.Connection.CreateCommand();
                    ReadAllStaffCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    ReadAllStaffCommand.CommandText = "GetStallTypeById";
                    ReadAllStaffCommand.Parameters.AddWithValue("@Id", staffId);
                    using (SqlDataReader reader = ReadAllStaffCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtname.Text = reader["StallTypeName"].ToString();

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

        private void LoadStallTypeFromView()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM vw_StallTypeList", Program.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbid.DataSource = dt;
                cbid.DisplayMember = "StallTypeID";  // Or "StaffFullName" if view returns full name
                cbid.ValueMember = "StallTypeID";        // Internal ID
                cbid.SelectedIndex = -1; // ✅ No selection on load
                cbid.Text = "";
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
