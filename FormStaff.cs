using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Devices;
using static Azure.Core.HttpHeader;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace StaffandStallManagementSystem
{

    public partial class FormStaff : UserControl
    {
        public FormStaff()
        {
            InitializeComponent();
            //cbstop.DisplayMember = "1";
            dptbirtday.Format = DateTimePickerFormat.Custom;
            dptbirtday.CustomFormat = " ";
            hireddate.Format = DateTimePickerFormat.Custom;
            hireddate.CustomFormat = " ";
            btnpic.Click += Btnpic_Click;
            btnsave.Click += Btnsave_Click;
            btnnew.Click += Btnnew_Click;
            txtsearch.TextChanged += Txtsearch_TextChanged;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            dptbirtday.ValueChanged += Dptbirtday_ValueChanged;
            hireddate.ValueChanged += Hireddate_ValueChanged;
            tbnupdate.Click += Tbnupdate_Click;
            txtkhname.TextChanged += TextBox_TextChanged;
            txtenname.TextChanged += TextBox_TextChanged;
            txtkhan.TextChanged += TextBox_TextChanged;
            txthouse.TextChanged += TextBox_TextChanged;
            txtkhan.TextChanged += TextBox_TextChanged;
            //cbposition.SelectedValueChanged += TextBox_TextChanged;
            txtprovince.TextChanged += TextBox_TextChanged;
            txtsalary.TextChanged += TextBox_TextChanged;
            txtstreet.TextChanged += TextBox_TextChanged;
            txtsangkat.TextChanged += TextBox_TextChanged;
            txtphone.MaskInputRejected += Txtphone_MaskInputRejected;
            cbposition.SelectedValueChanged += Cbposition_SelectedValueChanged;
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
        private void Txtphone_MaskInputRejected(object? sender, MaskInputRejectedEventArgs e)
        {
            if (txtphone.MaskFull)
            {
                errorProvider1.SetError(txtphone, "");
            }
        }
        private void Cbposition_SelectedValueChanged(object? sender, EventArgs e)
        {
            errorProvider1.SetError(cbposition, "");

        } 
        private void TextBox_TextChanged(object sender, EventArgs e)
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
        private void Tbnupdate_Click(object? sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("spCountStaffRecordsOut", Program.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter outputParam = new SqlParameter("@Total", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(outputParam);
            Program.Connection.Open();
            cmd.ExecuteNonQuery();
            Program.Connection.Close();
            int count = (int)outputParam.Value;
            if (txtid.Text == "")
                MessageBox.Show("Please Search Staff'Name For Update", "Updating",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (count <= int.Parse(txtid.Text))
                MessageBox.Show("You Can Save Update Only", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else{
            bool iserror = Protectnulldata();
            //else
            if (iserror) return;
            else
                    try
                {

                byte[]? photo = null;
                if (pictureBox1.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        photo = ms.ToArray();
                    }
                }
                Program.Connection.Open();

                    Program.UpdateStaffCommand.Parameters["@StaffID"].Value = int.Parse(txtid.Text);
                    Program.UpdateStaffCommand.Parameters["@StaffNameEN"].Value = txtenname.Text;

                Program.UpdateStaffCommand.Parameters["@StaffNameEN"].Value = txtenname.Text;
                Program.UpdateStaffCommand.Parameters["@StaffNameKH"].Value = txtkhname.Text;
                Program.UpdateStaffCommand.Parameters["@Sex"].Value = rdmale.Checked ? "Male" : "Female";
                Program.UpdateStaffCommand.Parameters["@BirthDate"].Value = dptbirtday.Value;
                Program.UpdateStaffCommand.Parameters["@StaffPosition"].Value = cbposition.Text;
                Program.UpdateStaffCommand.Parameters["@PhoneNumber"].Value = txtphone.Text;
                Program.UpdateStaffCommand.Parameters["@HouseNo"].Value = txthouse.Text;
                Program.UpdateStaffCommand.Parameters["@StreetNo"].Value = txtstreet.Text;
                Program.UpdateStaffCommand.Parameters["@Province"].Value = txtprovince.Text;
                Program.UpdateStaffCommand.Parameters["@Sangkat"].Value = txtsangkat.Text;
                Program.UpdateStaffCommand.Parameters["@Khann"].Value = txtkhan.Text;
                Program.UpdateStaffCommand.Parameters["@HiredDate"].Value = hireddate.Value;
                Program.UpdateStaffCommand.Parameters["@Salary"].Value = txtsalary.Text;
                Program.UpdateStaffCommand.Parameters["@Photo"].Value = (object?)photo ?? DBNull.Value;
                Program.UpdateStaffCommand.Parameters["@IsStopwork"].Value = 0;

                int n = Program.UpdateStaffCommand.ExecuteNonQuery();
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
            
        }      
        private void Hireddate_ValueChanged(object? sender, EventArgs e)
        {
            hireddate.Format = DateTimePickerFormat.Short;
            errorProvider1.SetError(hireddate, "");
        }
        private void Dptbirtday_ValueChanged(object? sender, EventArgs e)
        {
            dptbirtday.Format = DateTimePickerFormat.Short;
            errorProvider1.SetError(dptbirtday,"");
        }
        private void ListBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listBox1.SelectedValue != null && int.TryParse(listBox1.SelectedValue.ToString(), out int staffId))
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
                            txtid.Text = reader["StaffID"].ToString();
                            txtenname.Text = reader["StaffNameEN"].ToString();
                            txtkhname.Text = reader["StaffNameKH"].ToString();
                            string sex = reader["Sex"].ToString();
                            rdmale.Checked = (sex == "Male");
                            rdfemale.Checked = (sex == "Female");
                            if (reader["BirthDate"] != DBNull.Value)
                                dptbirtday.Value = Convert.ToDateTime(reader["BirthDate"]);
                            cbposition.Text = reader["StaffPosition"].ToString();

                            txtphone.Text = reader["PhoneNumber"].ToString();
                            txthouse.Text = reader["HouseNo"].ToString();
                            txtprovince.Text = reader["Province"].ToString();
                            txtsangkat.Text=  reader["Sangkat"].ToString();
                            txtstreet.Text= reader["StreetNo"].ToString();
                            txtkhan.Text= reader["Khann"].ToString();
                            if (reader["HiredDate"] != DBNull.Value)
                            hireddate.Value = Convert.ToDateTime(reader["HiredDate"]);
                            txtsalary.Text = reader["Salary"].ToString();

                            if (reader["Photo"] != DBNull.Value)
                            {
                                byte[] photoData = (byte[])reader["Photo"];
                                using (MemoryStream ms = new MemoryStream(photoData))
                                using (Bitmap bmp = new Bitmap(ms))
                                {
                                    // Resize or draw the image smoothly before setting it
                                    Bitmap smoothImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                                    using (Graphics g = Graphics.FromImage(smoothImage))
                                    {
                                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                        g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                                        g.DrawImage(bmp, 0, 0, pictureBox1.Width, pictureBox1.Height);
                                    }

                                    pictureBox1.Image = smoothImage;
                                }
                            }
                            else
                            {

                                pictureBox1.Image = null;
                            }
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
            listBox1.SelectedIndexChanged -= ListBox1_SelectedIndexChanged;
            if (string.IsNullOrWhiteSpace(txtsearch.Text))
            {
                listBox1.DataSource = null;
                listBox1.Items.Clear();
                return;
            }
            try
            {
                listBox1.ClearSelected();
                //using (SqlConnection conn = Program.Connection)
                DataTable dt = new DataTable();
                using (SqlCommand cmd = new SqlCommand("SELECT StaffID, StaffNameEN FROM dbo.fnSearchStaffByName(@name)", Program.Connection))
                {
                    cmd.Parameters.AddWithValue("@name", txtsearch.Text);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        listBox1.ClearSelected();
                    }
                }
                // Reset ListBox before rebinding
                listBox1.DataSource = null;
                listBox1.Items.Clear();
                // Rebind
                listBox1.DataSource = dt;
                listBox1.DisplayMember = "StaffNameEN";
                listBox1.ValueMember = "StaffID";
                listBox1.ClearSelected();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            listBox1.ClearSelected();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;

        }
        private void Btnnew_Click(object? sender, EventArgs e)
        {

            Noerror();
            txtenname.Text = "";
            txtkhname.Text = "";
            txtphone.Text = "";
            txtphone.Mask = "(855)-00-000-0000";
            cbposition.Text = "";
            txtsalary.Text = "";
            ////if(pictureBox1 != null)
            //  pictureBox1.Image.Dispose();
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose(); // ចាប់ផ្ដើមបិទ memory (ប្រសិនបើមាន)
                pictureBox1.Image = null;    // Clear picture
            }
            txthouse.Text = "";
            txtkhan.Text = "";
            txtprovince.Text = "";
            txtstreet.Text = "";
            txtsangkat.Text = "";
            dptbirtday.Format = DateTimePickerFormat.Custom;
            dptbirtday.CustomFormat = " ";
            hireddate.Format = DateTimePickerFormat.Custom;
            hireddate.CustomFormat = " ";
            //dptbirtday.Text = "";
            //hireddate.Text = "";
            //dptbirtday.Value;
            pictureBox1.Image = null;
            SqlCommand cmd = new SqlCommand("spCountStaffRecordsOut", Program.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter outputParam = new SqlParameter("@Total", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(outputParam);
            Program.Connection.Open();
            cmd.ExecuteNonQuery();
            Program.Connection.Close();
            int count = (int)outputParam.Value + 1;
            txtid.Text = count.ToString();
            //MessageBox.Show($"Total staff: {count}");
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
           errorProvider1.SetError(cbposition, "");
           errorProvider1.SetError(txtstreet, "");
           errorProvider1.SetError(txtsalary, "");
           errorProvider1.SetError(txtphone, "");
           errorProvider1.SetError(dptbirtday, "");
           errorProvider1.SetError(hireddate, "");
        }
        private void Btnsave_Click(object? sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("spCountStaffRecordsOut", Program.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter outputParam = new SqlParameter("@Total", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(outputParam);
            Program.Connection.Open();
            cmd.ExecuteNonQuery();
            Program.Connection.Close();
            int count = (int)outputParam.Value;
            if (txtid.Text == "")
                MessageBox.Show("Please Click New First", "Saving",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (count >= int.Parse(txtid.Text))
                MessageBox.Show("You Can Update Update Only", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                
                bool iserror = Protectnulldata();
                if(iserror) return;
                else
                 try

                    {

                    byte[]? photo = null;
                    if (pictureBox1.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            //pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            photo = ms.ToArray();
                        }
                    }
                    //if (Program.Connection.State != ConnectionState.Open)
                    Program.Connection.Open();
                        Program.InsertStaffCommand.Parameters["@StaffNameEN"].Value = txtenname.Text;
                        Program.InsertStaffCommand.Parameters["@StaffNameKH"].Value = txtkhname.Text;
                        Program.InsertStaffCommand.Parameters["@Sex"].Value = rdmale.Checked ? "Male" : "Female";
                        Program.InsertStaffCommand.Parameters["@BirthDate"].Value = dptbirtday.Value;
                        Program.InsertStaffCommand.Parameters["@StaffPosition"].Value = cbposition.Text;
                        Program.InsertStaffCommand.Parameters["@PhoneNumber"].Value = txtphone.Text;
                        Program.InsertStaffCommand.Parameters["@HouseNo"].Value = txthouse.Text;
                        Program.InsertStaffCommand.Parameters["@StreetNo"].Value = txtstreet.Text;
                        Program.InsertStaffCommand.Parameters["@Province"].Value = txtprovince.Text;
                        Program.InsertStaffCommand.Parameters["@Sangkat"].Value = txtsangkat.Text;
                        Program.InsertStaffCommand.Parameters["@Khann"].Value = txtkhan.Text;
                        Program.InsertStaffCommand.Parameters["@HiredDate"].Value = hireddate.Value;
                        Program.InsertStaffCommand.Parameters["@Salary"].Value = txtsalary.Text;
                        Program.InsertStaffCommand.Parameters["@Photo"].Value = (object?)photo ?? DBNull.Value;
                        Program.InsertStaffCommand.Parameters["@IsStopwork"].Value = 0;
                        int n = Program.InsertStaffCommand.ExecuteNonQuery();
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

            

            // Photo
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
            else errorProvider1.SetError(txtkhname, "");

            if (string.IsNullOrWhiteSpace(cbposition.Text))
            {
                errorProvider1.SetError(cbposition, "Position is required.");
                hasError = true;
            }
            else errorProvider1.SetError(cbposition, "");

            if (string.IsNullOrWhiteSpace(txthouse.Text))
            {
                errorProvider1.SetError(txthouse, "House number is required.");
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
            // Validate salary
            if (string.IsNullOrWhiteSpace(txtsalary.Text) || !double.TryParse(txtsalary.Text, out double salary))
            {
                errorProvider1.SetError(txtsalary, "Valid salary is required.");
                hasError = true;
            }
            else errorProvider1.SetError(txtsalary, "");

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
            if (dptbirtday.Format == DateTimePickerFormat.Short)
            {
                errorProvider1.SetError(dptbirtday, "");

            }
            else
            {
                errorProvider1.SetError(dptbirtday, "Birthdate is required.");
                hasError = true;
            }

            // ✅ HiredDate validation (DateTimePicker with CustomFormat)
            if (hireddate.Format == DateTimePickerFormat.Short)
            {
                errorProvider1.SetError(hireddate, "");
            }
            else
            {
                errorProvider1.SetError(hireddate, "Hire date is required.");
                hasError = true;
            }
            byte[]? photo = null;
            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    photo = ms.ToArray();
                }
            }

            // Stop execution if any control has error
            if (hasError)
            {
                MessageBox.Show("Please correct the highlighted fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            return hasError;
        }
        private void Btnpic_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image File";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    //MessageBox.Show("You selected: " + imagePath);
                    if (File.Exists(imagePath))
                    {

                        pictureBox1.Image = Image.FromFile(imagePath);
                        //pictureBox1.SizeMode = pictureBox1.SizeMode;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        //pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                    }
                }
            }
        }
        private void birtdate_ValueChanged(object sender, EventArgs e)
        {

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void FormStaff_Load(object sender, EventArgs e)
        {
           
        }
    }
}
