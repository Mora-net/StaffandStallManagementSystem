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
    public partial class FormTanent : UserControl
    {
        public FormTanent()
        {
            InitializeComponent();
            btnsave.Click += Btnsave_Click;
            btnnew.Click += Btnnew_Click;
            txtsearch.TextChanged += Txtsearch_TextChanged;
            lbtenant.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            btnupdate.Click += Btnupdate_Click;
            txtlogout.Click += Txtlogout_Click;
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

        private void Btnupdate_Click(object? sender, EventArgs e)
        {
            if (Protectnulldata()) return;
            else
                try
                {
                    Program.Connection.Open();
                    Program.UpdateTenantCommand.Parameters["@TenantID"].Value = txtid.Text;
                    Program.UpdateTenantCommand.Parameters["@FirstName"].Value = txtenname.Text;
                    Program.UpdateTenantCommand.Parameters["@LastName"].Value = txtkhname.Text;
                    Program.UpdateTenantCommand.Parameters["@Sex"].Value = rdmale.Checked ? "Male" : "Female";
                    Program.UpdateTenantCommand.Parameters["@PhoneNumber"].Value = txtphone.Text;
                    Program.UpdateTenantCommand.Parameters["@HouseNo"].Value = txthouse.Text;
                    Program.UpdateTenantCommand.Parameters["@StreetNo"].Value = txtstreet.Text;
                    Program.UpdateTenantCommand.Parameters["@City"].Value = txtprovince.Text;
                    Program.UpdateTenantCommand.Parameters["@Sangkat"].Value = txtsangkat.Text;
                    Program.UpdateTenantCommand.Parameters["@Khann"].Value = txtkhan.Text;
                    int n = Program.UpdateTenantCommand.ExecuteNonQuery();
                    MessageBox.Show($"{n} Row Has Been Updated", "Updating",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error > {ex.Message}", "Updating",
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

        private void ListBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lbtenant.SelectedValue != null && int.TryParse(lbtenant.SelectedValue.ToString(), out int staffId))
            {
                try
                {

                    Program.Connection.Open();
                    SqlCommand ReadAllStaffCommand = Program.Connection.CreateCommand();
                    ReadAllStaffCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    ReadAllStaffCommand.CommandText = "GetTenantByID";
                    ReadAllStaffCommand.Parameters.AddWithValue("@TenantID", staffId);
                    using (SqlDataReader reader = ReadAllStaffCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            txtid.Text = reader["TenantID"].ToString();
                            txtenname.Text = reader["FirstName"].ToString();
                            txtkhname.Text = reader["LastName"].ToString();
                            string sex = reader["Sex"].ToString();
                            rdmale.Checked = (sex == "Male");
                            rdfemale.Checked = (sex == "Female");
                            txtphone.Text = reader["PhoneNumber"].ToString();
                            txthouse.Text = reader["HouseNo"].ToString();
                            txtprovince.Text = reader["City"].ToString();
                            txtsangkat.Text = reader["Sangkat"].ToString();
                            txtstreet.Text = reader["StreetNo"].ToString();
                            txtkhan.Text = reader["Khann"].ToString();
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

            lbtenant.SelectedIndexChanged -= ListBox1_SelectedIndexChanged;
            if (string.IsNullOrWhiteSpace(txtsearch.Text))
            {
                lbtenant.DataSource = null;
                lbtenant.Items.Clear();
                return;
            }
            try
            {
                lbtenant.ClearSelected();
                //using (SqlConnection conn = Program.Connection)
                DataTable dt = new DataTable();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.fn_SearchTenantByName(@Name)", Program.Connection))
                {
                    cmd.Parameters.AddWithValue("@name", txtsearch.Text);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        lbtenant.ClearSelected();
                    }
                }
                // Reset ListBox before rebinding
                lbtenant.DataSource = null;
                lbtenant.Items.Clear();

                // Rebind
                lbtenant.DataSource = dt;
                lbtenant.DisplayMember = "FullName";  // Show FullName
                lbtenant.ValueMember = "TenantID";    // Store TenantID
                lbtenant.ClearSelected();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lbtenant.ClearSelected();
            lbtenant.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }

        private void Btnnew_Click(object? sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("usp_CountTenants", Program.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            Program.Connection.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
            Program.Connection.Close();
            txtid.Text = count.ToString();
            Noerror();
            txtenname.Text = "";
            txtkhname.Text = "";
            txtphone.Text = "";
            txtphone.Mask = "(855)-00-000-0000";
            txthouse.Text = "";
            txtkhan.Text = "";
            txtprovince.Text = "";
            txtstreet.Text = "";
            txtsangkat.Text = "";
        }
        private void Noerror()
        {
            errorProvider1.SetError(txtenname, "");
            errorProvider1.SetError(txtkhname, "");
            errorProvider1.SetError(txthouse, "");
            errorProvider1.SetError(txtcity, "");
            errorProvider1.SetError(txtphone, "");
            errorProvider1.SetError(txtkhan, "");
            errorProvider1.SetError(txtsangkat, "");
            errorProvider1.SetError(txtprovince, "");
            errorProvider1.SetError(txtstreet, "");
            errorProvider1.SetError(txtphone, "");
        }

        private void Btnsave_Click(object? sender, EventArgs e)
        {
            //bool iserror = Protectnulldata();
            if (Protectnulldata()) return;
            else
                try
                {
                    Program.Connection.Open();
                    Program.UpdateTenantCommand.Parameters["@FirstName"].Value = txtenname.Text;
                    Program.UpdateTenantCommand.Parameters["@LastName"].Value = txtkhname.Text;
                    Program.UpdateTenantCommand.Parameters["@Sex"].Value = rdmale.Checked ? "Male" : "Female";
                    Program.UpdateTenantCommand.Parameters["@PhoneNumber"].Value = txtphone.Text;
                    Program.UpdateTenantCommand.Parameters["@HouseNo"].Value = txthouse.Text;
                    Program.UpdateTenantCommand.Parameters["@StreetNo"].Value = txtstreet.Text;
                    Program.UpdateTenantCommand.Parameters["@City"].Value = txtprovince.Text;
                    Program.UpdateTenantCommand.Parameters["@Sangkat"].Value = txtsangkat.Text;
                    Program.UpdateTenantCommand.Parameters["@Khann"].Value = txtkhan.Text;
                    int n = Program.UpdateTenantCommand.ExecuteNonQuery();
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
        private bool Protectnulldata()
        {
            bool hasError = false;
            if (string.IsNullOrWhiteSpace(txtenname.Text))
            {
                errorProvider1.SetError(txtenname, "English name is required.");
                hasError = true;
            }
            else errorProvider1.SetError(txtenname, "");

            if (string.IsNullOrWhiteSpace(txtkhname.Text))
            {
                errorProvider1.SetError(txtkhname, "Khmer name is required.");
                hasError = true;
            }

            else errorProvider1.SetError(txthouse, "");

            if (string.IsNullOrWhiteSpace(txtcity.Text))
            {
                errorProvider1.SetError(txtcity, "City is required.");
                hasError = true;
            }
            else errorProvider1.SetError(txtcity, "");
            if (string.IsNullOrWhiteSpace(txtphone.Text))
            {
                errorProvider1.SetError(txtphone, "Phone number is required.");
                hasError = true;
            }
            else
            {
                errorProvider1.SetError(txtphone, "");
            }
            if (string.IsNullOrWhiteSpace(txtkhan.Text))
            {
                errorProvider1.SetError(txtkhan, "Khan is required.");
                hasError = true;
            }
            else errorProvider1.SetError(txtkhan, "");

            if (string.IsNullOrWhiteSpace(txtsangkat.Text))
            {
                errorProvider1.SetError(txtsangkat, "Sangkat is required.");
                hasError = true;
            }
            else errorProvider1.SetError(txtsangkat, "");

            if (string.IsNullOrWhiteSpace(txtprovince.Text))
            {
                errorProvider1.SetError(txtprovince, "Province is required.");
                hasError = true;
            }
            else errorProvider1.SetError(txtprovince, "");

            if (string.IsNullOrWhiteSpace(txtstreet.Text))
            {
                errorProvider1.SetError(txtstreet, "Street is required.");
                hasError = true;
            }
            else errorProvider1.SetError(txtstreet, "");

            // You can also validate dates if needed, e.g., not in future
            //DateTime HiredDate = hireddate.Value;
            //DateTime BirthDate = dptbirtday.Value;
            if (!(txtphone is MaskedTextBox) || !((MaskedTextBox)txtphone).MaskFull)
            {
                errorProvider1.SetError(txtphone, "Phone number is required.");
                hasError = true;
            }
            else
            {
                errorProvider1.SetError(txtphone, "");
            }

            // ✅ Birthdate validation (DateTimePicker with CustomFormat)


            // Stop execution if any control has error
            if (hasError)
            {
                MessageBox.Show("Please correct the highlighted fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            return hasError;
        }

        private void txtlogout_Click_1(object sender, EventArgs e)
        {

        }
    }
}