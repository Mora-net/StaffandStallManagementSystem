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
    
    public partial class FromStallType : UserControl
    {
        //DataTable dt = new DataTable();
        public FromStallType()
        {
            InitializeComponent();
            btnnew.Click += Btnnew_Click;
            btnsave.Click += Btnsave_Click;
            txtname.TextChanged += TextBox_TextChanged;
            txtprice.TextChanged += TextBox_TextChanged;
            textsearch.TextChanged += Textsearch_TextChanged;
            dataGridView1.Click += DataGridView1_Click;
            updatebtn.Click += Updatebtn_Click;
            btnlogout.Click += Btnlogout_Click;
            btnclose.Click += Btnclose_Click;
        }
        private void Btnclose_Click(object? sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Btnlogout_Click(object? sender, EventArgs e)
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
        private void Updatebtn_Click(object? sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_CountStallTypes", Program.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            Program.Connection.Open();
            int count = (int)cmd.ExecuteScalar();
            Program.Connection.Close();
            if (count <= int.Parse(txtid.Text))
                MessageBox.Show("You Can Save Only", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (Protectnulldata()) return;
                else
                    try
                    {
                        Program.Connection.Open();
                        Program.UpdateStallTypeCommand.Parameters["@StallTypeID"].Value = int.Parse(txtid.Text);
                        Program.UpdateStallTypeCommand.Parameters["@StallTypeName"].Value = txtname.Text;
                        Program.UpdateStallTypeCommand.Parameters["@UnitPrice"].Value = txtprice.Text;
                        int n = Program.UpdateStallTypeCommand.ExecuteNonQuery();
                        MessageBox.Show($"{n} Row Has Been Update", "Updating",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.Connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error > {ex.Message}", "Updating",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Program.Connection.Close();
                    }
                    finally
                    {
                        if (Program.Connection.State == ConnectionState.Open)
                            Program.Connection.Close();
                    }

            }
            

        }
        private void DataGridView1_Click(object? sender, EventArgs e)
        {
            try
            {
                int id =Convert.ToByte(dataGridView1.CurrentRow.Cells["StallTypeID"].Value);
                Program.Connection.Open();
                SqlCommand ReadAllStaffCommand = Program.Connection.CreateCommand();
                ReadAllStaffCommand.CommandType = System.Data.CommandType.StoredProcedure;
                ReadAllStaffCommand.CommandText = "GetStallTypeById";
                ReadAllStaffCommand.Parameters.AddWithValue("@Id",id);
                using (SqlDataReader reader = ReadAllStaffCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtid.Text = reader["StallTypeID"].ToString();
                        txtname.Text = reader["StallTypeName"].ToString();
                        txtprice.Text = reader["UnitPrice"].ToString();
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
        private void Textsearch_TextChanged(object? sender, EventArgs e)
        {
            string searchName = textsearch.Text.Trim();
            if (searchName != "")
                try
                {
                    txtmessage.Text = "";
                    //using (SqlConnection conn = Program.Connection)
                    DataTable dt = new DataTable();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM fn_SearchStallTypeByName(@SearchName)", Program.Connection))
                    {
                        cmd.Parameters.AddWithValue("@SearchName", searchName);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            Program.Connection.Open();
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                            Program.Connection.Close();
                            
                                //else if (dataGridView1.Rows.Count == 0)
                                //    {
                                
                        }
                        
                        
                    }
                    //dataGridView1.DataSource = null;
                    //string id = Convert.ToString(dataGridView1.CurrentRow.Cells["StallTypeID"].Value);
                    if (dataGridView1.Rows.Count == 1 )

                    {
                        dataGridView1.Columns.Clear();
                        txtmessage.Text = "Not Found";

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
        private void TextBox_TextChanged(object? sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                if (tb == null)
                {

                    return;
                }
                else if (txtid.Text == "" && tb.Text != "")
                {
                    MessageBox.Show("Please Click New First", "Creating",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb.Text = "";
                }
                else
                {
                    errorProvider1.SetError(tb, "");
                }
            }
        }
        private bool Protectnulldata()
        {
            bool hasError = false;
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                errorProvider1.SetError(txtname, "Name  is required.");
                hasError = true;
            }
            else errorProvider1.SetError(txtname, "");
            if (string.IsNullOrWhiteSpace(txtprice.Text))
            {
                errorProvider1.SetError(txtprice, "Unit Price  is required.");
                hasError = true;
            }
            else errorProvider1.SetError(txtprice, "");

            // Stop execution if any control has error
            if (hasError)
            {
                MessageBox.Show("Please correct the highlighted fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            return hasError;
        }
        private void Btnsave_Click(object? sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_CountStallTypes", Program.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            Program.Connection.Open();
            int count = (int)cmd.ExecuteScalar();
            Program.Connection.Close();
            if (txtid.Text == "")
                MessageBox.Show("Please Click New First", "Saving",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (count >= int.Parse(txtid.Text))
                MessageBox.Show("You Can Update Update Only", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (Protectnulldata()) return;
                else
                    try

                    {
                        Program.Connection.Open();
                        Program.InsertStallTypeCommand.Parameters["@StallTypeID"].Value = txtid.Text;
                        Program.InsertStallTypeCommand.Parameters["@StallTypeName"].Value = txtname.Text;
                        Program.InsertStallTypeCommand.Parameters["@UnitPrice"].Value = txtprice.Text;
                        int n = Program.InsertStallTypeCommand.ExecuteNonQuery();
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
        }
        private void Btnnew_Click(object? sender, EventArgs e)
        {
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
               SqlCommand cmd = new SqlCommand("sp_CountStallTypes", Program.Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                Program.Connection.Open();
                int count = (int)cmd.ExecuteScalar()+1;
                txtid.Text = count.ToString();
                Program.Connection.Close();
            txtname.Text = "";
            txtprice.Text = "";
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
