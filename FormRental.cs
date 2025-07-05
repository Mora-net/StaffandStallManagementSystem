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
     
    public partial class FormRental : UserControl
    {
        //public static double priceStall = 0.0;
        public FormRental()
        {
            InitializeComponent();
            LoadStallFromView();
            LoadTenantFromView();
            txtstn.Text = Program.nameStaff;
            txtskh.Text = Program.nameStaffKh;
            txtstpo.Text = Program.positonStaff;
            txtstid.Text = Program.idstaff.ToString();
            cbid.SelectedIndexChanged += Cbid_SelectedIndexChanged; // ✅ Event handler for selection change
            cbidt.SelectedIndexChanged += Cbidt_SelectedIndexChanged; // ✅ Event handler for selection change
            btnnew.Click += Btnnew_Click;
            btninsert.Click += Btninsert_Click;
            btnsave.Click += Btnsave_Click;
            updatebtn.Click += Updatebtn_Click;
            tbnupdate.Click += Tbnupdate_Click;
            textsearch.TextChanged += Textsearch_TextChanged; // ✅ Event handler for text change
            dataGridView1.Click += DataGridView1_Click; // ✅ Event handler for DataGridView click
            btnlogout.Click += Txtlogout_Click;
            btnclose.Click += Btnclose_Click;
        }
        

        private void DataGridView1_Click(object? sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    Program.Connection.Open();

                    // Get RentalNo and StallNo from selected row
                    int rentalNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["RentalNo"].Value);
                    short stallNo = Convert.ToInt16(dataGridView1.CurrentRow.Cells["StallNo"].Value);

                    SqlCommand cmd = new SqlCommand("sp_GetRentalByRentalAndStall", Program.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RentalNo", rentalNo);
                    cmd.Parameters.AddWithValue("@StallNo", stallNo);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Fill your controls with data
                            txtno.Text = reader["RentalNo"].ToString();
                            cbid.Text = reader["StallNo"].ToString();
                            dprental.Value = Convert.ToDateTime(reader["RentalDate"]);
                            txtprice.Text = reader["PaidAmount"].ToString();
                            cbidt.Text = reader["TenantID"].ToString();
                            //txtskh.Text = reader["StaffNameKH"].ToString();
                            //txtstn.Text = reader["StaffNameEN"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No rental detail found for this row.");
                        }
                    }

                    Program.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Program.Connection.State == ConnectionState.Open)
                    Program.Connection.Close();
            }
        }

        private void Textsearch_TextChanged(object? sender, EventArgs e)
        {
            if(textsearch.Text!="")
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_SearchRentalById", Program.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RentalNo",Convert.ToInt32( textsearch.Text));

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        
                        DataTable dt = new DataTable();
                    adapter.Fill(dt);
                        DataTable filteredTable = dt.DefaultView.ToTable(false, "RentalNo","StallNo" ,"RentalDate", "PaidAmount", "StaffNameEN");

                        dataGridView1.DataSource = filteredTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Tbnupdate_Click(object? sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateRentalDetail", Program.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters from form controls
                    cmd.Parameters.AddWithValue("@RentalNo", Convert.ToInt32(txtno.Text));
                    cmd.Parameters.AddWithValue("@StallNo", Convert.ToInt16(cbid.Text)); // assuming StallNo comes from combo box
                    cmd.Parameters.AddWithValue("@RentalDate", dprental.Value);
                    cmd.Parameters.AddWithValue("@PaidAmount", Convert.ToDecimal(txtprice.Text));

                    Program.Connection.Open();
                    cmd.ExecuteNonQuery();
                    Program.Connection.Close();

                    MessageBox.Show("Rental detail updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Program.Connection.Close();
            }
        }

        private void Updatebtn_Click(object? sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateRental", Program.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters from form controls
                    cmd.Parameters.AddWithValue("@RentalNo", Convert.ToInt32(txtno.Text));
                    cmd.Parameters.AddWithValue("@RentalDate", dprental.Value);
                    cmd.Parameters.AddWithValue("@PaidAmount", Convert.ToDecimal(txtprice.Text));
                    cmd.Parameters.AddWithValue("@TenantID", Convert.ToInt32(cbidt.Text));
                    cmd.Parameters.AddWithValue("@StallNo", Convert.ToInt16(cbid.Text));
                    cmd.Parameters.AddWithValue("@StaffID", Convert.ToInt16(txtstid.Text));
                    cmd.Parameters.AddWithValue("@StaffNameEN", txtstn.Text);
                    cmd.Parameters.AddWithValue("@StaffNameKH", txtskh.Text);
                    cmd.Parameters.AddWithValue("@StaffPosition", txtstpo.Text);

                    Program.Connection.Open();
                    cmd.ExecuteNonQuery();
                    Program.Connection.Close();

                    MessageBox.Show("Rental updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Program.Connection.Close();
            }
        }

        private void Btnsave_Click(object? sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertRental", Program.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters from your form controls
                    cmd.Parameters.AddWithValue("@RentalNo", Convert.ToInt32(txtno.Text));
                    cmd.Parameters.AddWithValue("@RentalDate", dprental.Value);
                    cmd.Parameters.AddWithValue("@PaidAmount", Convert.ToDecimal(txtprice.Text));
                    cmd.Parameters.AddWithValue("@TenantID", Convert.ToInt32(cbidt.Text));
                    cmd.Parameters.AddWithValue("@StallNo", Convert.ToInt16(cbid.Text));
                    cmd.Parameters.AddWithValue("@StaffID", Convert.ToInt16(txtstid.Text));
                    cmd.Parameters.AddWithValue("@StaffNameEN", txtstn.Text);
                    cmd.Parameters.AddWithValue("@StaffNameKH", txtskh.Text);
                    cmd.Parameters.AddWithValue("@StaffPosition",txtstpo.Text);

                    Program.Connection.Open();
                    cmd.ExecuteNonQuery();
                    Program.Connection.Close();

                    MessageBox.Show("Rental inserted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Program.Connection.Close();
            }
        }

        private void Btninsert_Click(object? sender, EventArgs e)
        {
            try
            {
                
                using (SqlCommand cmd = new SqlCommand("sp_InsertRentalDetail", Program.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    cmd.Parameters.AddWithValue("@RentalNo",Convert.ToInt32(txtno.Text));
                    cmd.Parameters.AddWithValue("@StallNo", Convert.ToInt16(cbid.Text));
                    cmd.Parameters.AddWithValue("@RentalDate",dprental.Value);
                    cmd.Parameters.AddWithValue("@PaidAmount",Convert.ToDecimal( txtprice.Text));
                    Program.Connection.Open();
                    cmd.ExecuteNonQuery();
                    Program.Connection.Close();
                    MessageBox.Show("Rental detail inserted successfully.");
                }
            }
           
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Program.Connection.Close();
            }
        }

        private void Btnnew_Click(object? sender, EventArgs e)
        {

            int totalStalls = 0;
            SqlCommand cmd = new SqlCommand("sp_CountRental", Program.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            Program.Connection.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    totalStalls = Convert.ToInt32(reader["TotalRentals"]) + 1;
                }
            }
            Program.Connection.Close();
            txtno.Text = totalStalls.ToString();
            cbid.SelectedIndex = -1;
            cbidt.SelectedIndex = -1;
            txtprice.Text = "";
            txtnamet.Text = "";
            
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
        private void Cbidt_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cbidt.SelectedValue != null &&  cbidt.SelectedValue.ToString() !="")
            {
                txtnamet.Text = cbidt.SelectedValue.ToString();

            }

        }

        private void Cbid_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cbid.SelectedValue != null && double.TryParse(cbid.SelectedValue.ToString(), out double staffId))
            {
                txtprice.Text = staffId.ToString();
                
            }
        }

        private void LoadStallFromView()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM vw_StallWithPrice", Program.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbid.DataSource = dt;
                cbid.DisplayMember = "StallNo";  // Or "StaffFullName" if view returns full name
                cbid.ValueMember = "UnitPrice";        // Internal ID
                cbid.SelectedIndex = -1; // ✅ No selection on load
                cbid.Text = "";
            }
        }
        private void LoadTenantFromView()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM vw_TenantBasicInfo", Program.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbidt.DataSource = dt;
                cbidt.DisplayMember = "TenantID";  // Or "StaffFullName" if view returns full name
                cbidt.ValueMember = "FullName";        // Internal ID
                cbidt.SelectedIndex = -1; // ✅ No selection on load
                cbidt.Text = "";
            }
        }

        private void FormRental_Load(object sender, EventArgs e)
        {

        }
    }
}
