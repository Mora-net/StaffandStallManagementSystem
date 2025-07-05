using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StaffandStallManagementSystem
{
    public partial class FormPayment : UserControl
    {
        public FormPayment()
        {
            InitializeComponent();
            LoadInvoiceFromView();
            LoadTenantFromView();
            isdeathline();
            dppay.Value = DateTime.Now;
            txtstn.Text = Program.nameStaff;
            txtskh.Text = Program.nameStaffKh;
            txtstpo.Text = Program.positonStaff;
            txtstid.Text = Program.idstaff.ToString();
            cbid.SelectedIndexChanged += Cbid_SelectedIndexChanged;
            btnnew.Click += Btnnew_Click;
            cbid.SelectedIndexChanged += Cbidt_SelectedIndexChanged;
            btnsave.Click += Btnsave_Click;
            btninsert.Click += Btninsert_Click;
            textsearch.TextChanged += Textsearch_TextChanged;
            dataGridView1.Click += DataGridView1_Click;
            tbnupdate.Click += Updatebtn_Click;
            updatebtn.Click += Tbnupdate_Click;


        }

        private void Updatebtn_Click(object? sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdatePaymentDetailByPaymentNoAndInvoiceNo", Program.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Replace control names with yours
                    cmd.Parameters.AddWithValue("@PaymentNo", Convert.ToInt32(txtno.Text));
                    cmd.Parameters.AddWithValue("@InvoiceNo", Convert.ToInt32(cbid.Text));
                    cmd.Parameters.AddWithValue("@InvoiceDate", dppay.Value);
                    cmd.Parameters.AddWithValue("@TotalAmount", Convert.ToDecimal(txtprice.Text));

                    Program.Connection.Open();
                    cmd.ExecuteNonQuery();
                    Program.Connection.Close();

                    MessageBox.Show("Payment detail updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Program.Connection.State == ConnectionState.Open)
                    Program.Connection.Close();
            }
        }

        private void Tbnupdate_Click(object? sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdatePaymentByPaymentNo", Program.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure; 
                    cmd.Parameters.AddWithValue("@PaymentNo", Convert.ToInt32(txtno.Text));
                    cmd.Parameters.AddWithValue("@PaymentDate", dppay.Value);
                    cmd.Parameters.AddWithValue("@PaidAmount", Convert.ToDecimal(txtprice.Text));
                    cmd.Parameters.AddWithValue("@TenantID", Convert.ToInt32(cbidt.Text));
                    cmd.Parameters.AddWithValue("@RentalNo", Convert.ToInt32(txtnoo.Text));
                    cmd.Parameters.AddWithValue("@InvoiceNo", Convert.ToInt32(cbid.Text));  // Assuming cbid is for InvoiceNo
                    cmd.Parameters.AddWithValue("@StaffID", Convert.ToInt16(txtstid.Text));
                    cmd.Parameters.AddWithValue("@StaffNameEN", txtstn.Text);
                    cmd.Parameters.AddWithValue("@StaffNameKH", txtskh.Text);
                    cmd.Parameters.AddWithValue("@StaffPosition", txtstpo.Text);
                    Program.Connection.Open();
                    cmd.ExecuteNonQuery();
                    Program.Connection.Close();

                    MessageBox.Show("Payment updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Program.Connection.State == ConnectionState.Open)
                    Program.Connection.Close();
            }
        }

        private void DataGridView1_Click(object? sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int paymentNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PaymentNo"].Value);
                    int invoiceNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["InvoiceNo"].Value);
                    cbid.Text = Convert.ToString(paymentNo);
                    using (SqlCommand cmd = new SqlCommand("sp_GetPaymentByPaymentNoAndInvoiceNo", Program.Connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PaymentNo", paymentNo);
                        cmd.Parameters.AddWithValue("@InvoiceNo", invoiceNo);

                        Program.Connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Fill controls with payment info
                                txtno.Text = reader["PaymentNo"].ToString();
                                dppay.Value = Convert.ToDateTime(reader["PaymentDate"]);
                                txtprice.Text = reader["PaidAmount"].ToString();
                                cbidt.Text = reader["TenantID"].ToString();
                                //int tenantId = Convert.ToInt32(reader["TenantID"]);
                                //cbid.SelectedValue = tenantId;
                                txtnoo.Text = reader["RentalNo"].ToString();
                                txtstid.Text = reader["StaffID"].ToString();
                                txtstn.Text = reader["StaffNameEN"].ToString();
                                txtskh.Text = reader["StaffNameKH"].ToString();
                                txtstpo.Text = reader["StaffPosition"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No payment record found for this row.");
                            }
                        }

                        Program.Connection.Close();
                    }
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
            if (textsearch.Text != "")
            {
                try
                {
                    int paymentNo = Convert.ToInt32(textsearch.Text);

                    using (SqlCommand cmd = new SqlCommand("spGetPaymentByPaymentNoAndInvoiceNo", Program.Connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // For demo: same value used as PaymentNo and InvoiceNo
                        // You can separate these from different inputs if needed
                        cmd.Parameters.AddWithValue("@PaymentNo", paymentNo);
                        //cmd.Parameters.AddWithValue("@InvoiceNo", );

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Show specific columns
                        DataTable filteredTable = dt.DefaultView.ToTable(false,
                            "PaymentNo", "InvoiceNo", "TenantID", "PaidAmount", "PaymentDate");

                        dataGridView1.DataSource = filteredTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void Btninsert_Click(object? sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sppInsertPaymentDetail", Program.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters from controls
                    cmd.Parameters.AddWithValue("@PaymentNo", Convert.ToInt32(txtno.Text));
                    cmd.Parameters.AddWithValue("@InvoiceNo", Convert.ToInt32(cbid.Text));
                    cmd.Parameters.AddWithValue("@InvoiceDate", dppay.Value);
                    cmd.Parameters.AddWithValue("@TotalAmount", Convert.ToDecimal(txtprice.Text));

                    Program.Connection.Open();
                    cmd.ExecuteNonQuery();
                    Program.Connection.Close();

                    MessageBox.Show("Payment detail inserted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting payment detail: " + ex.Message);
                if (Program.Connection.State == ConnectionState.Open)
                    Program.Connection.Close();
            }
        }

        private void Btnsave_Click(object? sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spInsertPayment", Program.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters from form inputs
                    cmd.Parameters.AddWithValue("@PaymentNo", Convert.ToInt32(txtno.Text));
                    cmd.Parameters.AddWithValue("@PaymentDate", dppay.Value);
                    cmd.Parameters.AddWithValue("@PaidAmount", Convert.ToDecimal(txtprice.Text));
                    cmd.Parameters.AddWithValue("@TenantID", Convert.ToInt32(cbidt.Text));
                    cmd.Parameters.AddWithValue("@InvoiceNo", Convert.ToInt32(cbid.Text));
                    cmd.Parameters.AddWithValue("@RentalNo", Convert.ToInt32(txtnoo.Text));
                    cmd.Parameters.AddWithValue("@StaffID", Convert.ToInt16(txtstid.Text));
                    cmd.Parameters.AddWithValue("@StaffNameEN", txtstn.Text);
                    cmd.Parameters.AddWithValue("@StaffNameKH", txtskh.Text);
                    cmd.Parameters.AddWithValue("@StaffPosition", txtstpo.Text);

                    Program.Connection.Open();
                    cmd.ExecuteNonQuery();
                    Program.Connection.Close();

                    MessageBox.Show("Payment inserted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting payment: " + ex.Message);
                if (Program.Connection.State == ConnectionState.Open)
                    Program.Connection.Close();
            }

        }

        private bool isdeathline()
        {
            DateTime deadline = dpline.Value;
            DateTime today = DateTime.Today;
            DateTime oneWeekFromNow = today.AddDays(7);

            if (deadline >= today && deadline <= oneWeekFromNow)
            {
                MessageBox.Show("Deadline is within 1 week.");
            }

            return false;
        }
        private void Btnnew_Click(object? sender, EventArgs e)
        {
            int totalPayments = 0;
            SqlCommand cmd = new SqlCommand("sp_CountPayments", Program.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            Program.Connection.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    totalPayments = Convert.ToInt32(reader["TotalPayments"]) +1;
                }
            }
            Program.Connection.Close();

            // Display in a textbox
            txtno.Text = totalPayments.ToString();

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
            
            if (cbid.SelectedValue != null && cbid.SelectedValue.ToString() != "")
            try
                {
                    Program.Connection.Open();
                    int invoiceNo = Convert.ToInt32(cbid.Text);
                    int rentalNo = Convert.ToInt32(cbid.SelectedValue);

                    // Prepare command
                    SqlCommand cmd = new SqlCommand("sp_GetInvoiceByInvoiceAndRental", Program.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RentalNo", rentalNo);
                    cmd.Parameters.AddWithValue("@InvoiceNo", invoiceNo);

                    // Execute reader
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dpline.Value = reader.GetDateTime(reader.GetOrdinal("InvoiceDate"));
                            txtnoo.Text = reader["RentalNo"].ToString();
                            cbidt.Text  = reader["TenantID"].ToString();
                            txtnamet.Text= reader["TenantID"].ToString();
                            txtprice.Text = reader["PaidAmount"].ToString();
                        }
                        
                    }
                    DateTime threshold = dppay.Value;
                    DateTime deadline = dpline.Value.Date.AddMonths(1).AddDays(7);

                    if (deadline <= threshold)
                    {
                        MessageBox.Show("This Invoice is Late , Please Pay vai LatePaymentForm ", "Late Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Program.Connection.Close();
                    }
                    Program.Connection.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (Program.Connection.State == ConnectionState.Open)
                        Program.Connection.Close();
                }

            //}
            //cbid.SelectedIndexChanged += Cbidt_SelectedIndexChanged;
           
            //DateTime deadline = dpline.Value.Date.AddMonths(-1).AddDays(-7);
            
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

        private void LoadInvoiceFromView()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM viwInvoiceSummary", Program.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cbid.DataSource = dt;
                cbid.DisplayMember = "InvoiceNo";  // Or "StaffFullName" if view returns full name
                cbid.ValueMember = "RentalNo";        // Internal ID
                cbid.SelectedIndex = -1; // ✅ No selection on load
                cbid.Text = "";
                //cbidt.DataSource = dt;
                //cbidt.DisplayMember = "TenantID";  // Or "StaffFullName" if view returns full name
                //cbidt.ValueMember = "FullName";        // Internal ID
                //cbidt.SelectedIndex = -1; // ✅ No selection on load
                //cbidt.Text = "";
            }
        }
    }
}
