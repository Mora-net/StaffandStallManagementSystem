using Microsoft.Data.SqlClient;
using System;
using System.Collections;
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
    public partial class FormInvoice : UserControl
    {
        public FormInvoice()
        {
            InitializeComponent();
            txtstn.Text = Program.nameStaff;
            txtskh.Text = Program.nameStaffKh;
            txtstpo.Text = Program.positonStaff;
            txtstid.Text = Program.idstaff.ToString();
            btnnew.Click += Btnnew_Click;
            dpin.ValueChanged += Dpin_ValueChanged;

            LoadSRentalFromView();
            cbidt.SelectedIndexChanged += Cbidt_SelectedIndexChanged;
            cbid.SelectedIndexChanged += Cbid_SelectedIndexChanged;
            btnsave.Click += Btnsave_Click;
            updatebtn.Click += Updatebtn_Click;
            textsearch.TextChanged += Textsearch_TextChanged;
            dataGridView1.Click += DataGridView1_Click;

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

        private void DataGridView1_Click(object? sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    Program.Connection.Open();

                    // Get RentalNo and StallNo from selected row
                    int rentalNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["RentalNo"].Value);
                    short stallNo = Convert.ToInt16(dataGridView1.CurrentRow.Cells["InvoiceNo"].Value);

                    SqlCommand cmd = new SqlCommand("sp_GetInvoiceByInvoiceAndRental", Program.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RentalNo", rentalNo);
                    cmd.Parameters.AddWithValue("@InvoiceNo", stallNo);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Fill your controls with data
                            txtno.Text = reader["InvoiceNo"].ToString();
                            dpin.Value = reader.GetDateTime(reader.GetOrdinal("InvoiceDate"));
                            txtprice.Text = reader["PaidAmount"].ToString();
                            dpline.Value = reader.GetDateTime(reader.GetOrdinal("DataLine"));
                            cbidt.Text = reader["TenantID"].ToString();
                            cbid.Text = reader["RentalNo"].ToString();
                            txtstid.Text = reader["StaffID"].ToString();
                            txtstn.Text = reader["StaffNameEN"].ToString();
                            txtskh.Text = reader["StaffNameKH"].ToString();
                            txtstpo.Text = reader["StaffPosition"].ToString();
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
            if (!string.IsNullOrWhiteSpace(textsearch.Text))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_SearchInvoiceById", Program.Connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@InvoiceNo", Convert.ToInt32(textsearch.Text));

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Only select valid columns returned from the stored procedure
                        DataTable filteredTable = dt.DefaultView.ToTable(false,
                            "InvoiceNo",
                            "RentalNo",
                            "PaidAmount",
                            "InvoiceDate",
                            "DataLine"
                            );

                        dataGridView1.DataSource = filteredTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Updatebtn_Click(object? sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateInvoice", Program.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Pass parameters from form controls
                    cmd.Parameters.AddWithValue("@InvoiceNo", Convert.ToInt32(txtno.Text));
                    cmd.Parameters.AddWithValue("@InvoiceDate", dpin.Value);
                    cmd.Parameters.AddWithValue("@PaidAmount", Convert.ToDecimal(txtprice.Text));
                    cmd.Parameters.AddWithValue("@DataLine", dpline.Value);
                    cmd.Parameters.AddWithValue("@TenantID", Convert.ToInt32(cbidt.Text));
                    cmd.Parameters.AddWithValue("@RentalNo", Convert.ToInt32(cbid.Text));
                    cmd.Parameters.AddWithValue("@StaffID", Convert.ToInt16(txtstid.Text));
                    cmd.Parameters.AddWithValue("@StaffNameEN", txtstn.Text);
                    cmd.Parameters.AddWithValue("@StaffNameKH", txtskh.Text);
                    cmd.Parameters.AddWithValue("@StaffPosition", txtstpo.Text);

                    Program.Connection.Open();
                    cmd.ExecuteNonQuery();
                    Program.Connection.Close();
                    MessageBox.Show("Invoice updated successfully 💖");
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Program.Connection.State == ConnectionState.Open)
                    Program.Connection.Close();
            }
        }

        private void Dpin_ValueChanged(object? sender, EventArgs e)
        {
            DateTime selectedDate = dpin.Value;

            // Add one month
            DateTime nextMonthDate = selectedDate.AddMonths(1);

            // Optional: Keep the day if possible, otherwise will adjust automatically
            dpline.Value = nextMonthDate;
        }

        private void Btnsave_Click(object? sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertInvoice", Program.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters from form inputs
                    cmd.Parameters.AddWithValue("@InvoiceNo", Convert.ToInt32(txtno.Text));
                    cmd.Parameters.AddWithValue("@InvoiceDate", dpin.Value);
                    cmd.Parameters.AddWithValue("@PaidAmount", Convert.ToDecimal(txtprice.Text));
                    cmd.Parameters.AddWithValue("@DataLine", dpline.Value);
                    cmd.Parameters.AddWithValue("@TenantID", Convert.ToInt32(cbidt.Text));
                    cmd.Parameters.AddWithValue("@RentalNo", Convert.ToInt32(cbid.Text));
                    cmd.Parameters.AddWithValue("@StaffID", Convert.ToInt16(txtstid.Text));
                    cmd.Parameters.AddWithValue("@StaffNameEN", txtstn.Text);
                    cmd.Parameters.AddWithValue("@StaffNameKH", txtskh.Text);
                    cmd.Parameters.AddWithValue("@StaffPosition", txtstpo.Text);
                    Program.Connection.Open();
                    cmd.ExecuteNonQuery();
                    Program.Connection.Close();

                    MessageBox.Show("Invoice inserted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Program.Connection.State == ConnectionState.Open)
                    Program.Connection.Close();
            }
        }

        private void Cbidt_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cbidt.SelectedValue != null && cbidt.SelectedValue.ToString() != "")
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
        private void LoadSRentalFromView()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM vw_RentalPaidAmountAndTenant", Program.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbid.DataSource = dt;
                cbid.DisplayMember = "RentalNo";  // Or "StaffFullName" if view returns full name
                cbid.ValueMember = "PaidAmount";        // Internal ID
                cbid.SelectedIndex = -1; // ✅ No selection on load
                cbid.Text = "";
                cbidt.DataSource = dt;
                cbidt.DisplayMember = "TenantID";  // Or "StaffFullName" if view returns full name
                cbidt.ValueMember = "FullName";        // Internal ID
                cbidt.SelectedIndex = -1; // ✅ No selection on load
                cbidt.Text = "";
            }
        }
     

        private void Btnnew_Click(object? sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("sp_CountInvoice", Program.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                Program.Connection.Open();
                int count = (int)cmd.ExecuteScalar()+1;
                Program.Connection.Close();
                txtno.Text = count.ToString(); 
            }
        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {

        }
    }
}
