namespace StaffandStallManagementSystem
{
    partial class FormRental
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRental));
            label5 = new Label();
            txtmessage = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            btnclose = new Button();
            updatebtn = new Button();
            btnnew = new Button();
            btnlogout = new Button();
            btnsave = new Button();
            label10 = new Label();
            txtno = new TextBox();
            label2 = new Label();
            textsearch = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            label4 = new Label();
            label6 = new Label();
            txtprice = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            txtstid = new TextBox();
            txtstn = new TextBox();
            txtskh = new TextBox();
            txtstpo = new TextBox();
            dprental = new DateTimePicker();
            cbid = new ComboBox();
            cbidt = new ComboBox();
            label12 = new Label();
            txtnamet = new TextBox();
            groupBox1 = new GroupBox();
            tbnupdate = new Button();
            btninsert = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(399, 45);
            label5.Name = "label5";
            label5.Size = new Size(107, 26);
            label5.TabIndex = 79;
            label5.Text = "Retal Date";
            // 
            // txtmessage
            // 
            txtmessage.AutoSize = true;
            txtmessage.BackColor = SystemColors.ButtonHighlight;
            txtmessage.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmessage.ForeColor = SystemColors.ActiveCaptionText;
            txtmessage.Location = new Point(403, 548);
            txtmessage.Name = "txtmessage";
            txtmessage.Size = new Size(0, 39);
            txtmessage.TabIndex = 78;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 622);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(783, 95);
            dataGridView1.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(26, 105);
            label3.Name = "label3";
            label3.Size = new Size(122, 26);
            label3.TabIndex = 75;
            label3.Text = "Paid Amout";
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.Red;
            btnclose.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnclose.Location = new Point(673, 749);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(128, 47);
            btnclose.TabIndex = 74;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = false;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.FromArgb(255, 255, 128);
            updatebtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updatebtn.Location = new Point(169, 749);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(128, 47);
            updatebtn.TabIndex = 73;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            // 
            // btnnew
            // 
            btnnew.BackColor = Color.FromArgb(192, 255, 255);
            btnnew.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnew.Location = new Point(352, 749);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(128, 47);
            btnnew.TabIndex = 72;
            btnnew.Text = "New";
            btnnew.UseVisualStyleBackColor = false;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.LightCoral;
            btnlogout.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogout.Location = new Point(511, 749);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(128, 47);
            btnlogout.TabIndex = 71;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.FromArgb(128, 255, 128);
            btnsave.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(16, 749);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(128, 47);
            btnsave.TabIndex = 70;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(403, 58);
            label10.Name = "label10";
            label10.Size = new Size(255, 34);
            label10.TabIndex = 69;
            label10.Text = "Rental's Information";
            // 
            // txtno
            // 
            txtno.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtno.Location = new Point(193, 137);
            txtno.Name = "txtno";
            txtno.ReadOnly = true;
            txtno.Size = new Size(210, 34);
            txtno.TabIndex = 68;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(39, 137);
            label2.Name = "label2";
            label2.Size = new Size(105, 26);
            label2.TabIndex = 67;
            label2.Text = "Rental No";
            // 
            // textsearch
            // 
            textsearch.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textsearch.Location = new Point(108, 568);
            textsearch.Name = "textsearch";
            textsearch.Size = new Size(272, 34);
            textsearch.TabIndex = 66;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(27, 568);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 65;
            label1.Text = "Search";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(428, 201);
            label4.Name = "label4";
            label4.Size = new Size(98, 26);
            label4.TabIndex = 82;
            label4.Text = "TenantID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(12, 50);
            label6.Name = "label6";
            label6.Size = new Size(87, 26);
            label6.TabIndex = 84;
            label6.Text = "Stall No";
            // 
            // txtprice
            // 
            txtprice.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtprice.Location = new Point(163, 105);
            txtprice.Name = "txtprice";
            txtprice.ReadOnly = true;
            txtprice.Size = new Size(210, 34);
            txtprice.TabIndex = 85;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(39, 272);
            label7.Name = "label7";
            label7.Size = new Size(152, 26);
            label7.TabIndex = 86;
            label7.Text = "Staff Name EN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(37, 329);
            label8.Name = "label8";
            label8.Size = new Size(154, 26);
            label8.TabIndex = 87;
            label8.Text = "Staff Name KH";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(39, 201);
            label9.Name = "label9";
            label9.Size = new Size(87, 26);
            label9.TabIndex = 88;
            label9.Text = "Staff ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(428, 137);
            label11.Name = "label11";
            label11.Size = new Size(139, 26);
            label11.TabIndex = 89;
            label11.Text = "Staff Position";
            // 
            // txtstid
            // 
            txtstid.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtstid.Location = new Point(193, 201);
            txtstid.Name = "txtstid";
            txtstid.ReadOnly = true;
            txtstid.Size = new Size(210, 34);
            txtstid.TabIndex = 90;
            // 
            // txtstn
            // 
            txtstn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtstn.Location = new Point(197, 264);
            txtstn.Name = "txtstn";
            txtstn.ReadOnly = true;
            txtstn.Size = new Size(210, 34);
            txtstn.TabIndex = 91;
            // 
            // txtskh
            // 
            txtskh.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtskh.Location = new Point(197, 321);
            txtskh.Name = "txtskh";
            txtskh.ReadOnly = true;
            txtskh.Size = new Size(210, 34);
            txtskh.TabIndex = 92;
            // 
            // txtstpo
            // 
            txtstpo.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtstpo.Location = new Point(591, 137);
            txtstpo.Name = "txtstpo";
            txtstpo.ReadOnly = true;
            txtstpo.Size = new Size(210, 34);
            txtstpo.TabIndex = 93;
            // 
            // dprental
            // 
            dprental.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dprental.Format = DateTimePickerFormat.Short;
            dprental.Location = new Point(552, 42);
            dprental.Name = "dprental";
            dprental.Size = new Size(210, 34);
            dprental.TabIndex = 94;
            dprental.Value = new DateTime(2025, 6, 6, 14, 8, 2, 0);
            // 
            // cbid
            // 
            cbid.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbid.FormattingEnabled = true;
            cbid.Location = new Point(163, 42);
            cbid.Name = "cbid";
            cbid.Size = new Size(210, 34);
            cbid.TabIndex = 95;
            // 
            // cbidt
            // 
            cbidt.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbidt.FormattingEnabled = true;
            cbidt.Location = new Point(591, 196);
            cbidt.Name = "cbidt";
            cbidt.Size = new Size(210, 34);
            cbidt.TabIndex = 96;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(428, 267);
            label12.Name = "label12";
            label12.Size = new Size(134, 26);
            label12.TabIndex = 97;
            label12.Text = "Tenant Name";
            // 
            // txtnamet
            // 
            txtnamet.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnamet.Location = new Point(591, 267);
            txtnamet.Name = "txtnamet";
            txtnamet.ReadOnly = true;
            txtnamet.Size = new Size(210, 34);
            txtnamet.TabIndex = 98;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbnupdate);
            groupBox1.Controls.Add(cbid);
            groupBox1.Controls.Add(btninsert);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtprice);
            groupBox1.Controls.Add(dprental);
            groupBox1.Location = new Point(39, 374);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(771, 171);
            groupBox1.TabIndex = 99;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rental Detail";
            // 
            // tbnupdate
            // 
            tbnupdate.BackColor = Color.FromArgb(255, 255, 128);
            tbnupdate.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbnupdate.Location = new Point(586, 98);
            tbnupdate.Name = "tbnupdate";
            tbnupdate.Size = new Size(128, 47);
            tbnupdate.TabIndex = 101;
            tbnupdate.Text = "Update";
            tbnupdate.UseVisualStyleBackColor = false;
            // 
            // btninsert
            // 
            btninsert.BackColor = Color.FromArgb(128, 255, 128);
            btninsert.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btninsert.Location = new Point(400, 95);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(128, 47);
            btninsert.TabIndex = 100;
            btninsert.Text = "Insert";
            btninsert.UseVisualStyleBackColor = false;
            // 
            // FormRental
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(groupBox1);
            Controls.Add(txtnamet);
            Controls.Add(label12);
            Controls.Add(cbidt);
            Controls.Add(txtstpo);
            Controls.Add(txtskh);
            Controls.Add(txtstn);
            Controls.Add(txtstid);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(txtmessage);
            Controls.Add(dataGridView1);
            Controls.Add(btnclose);
            Controls.Add(updatebtn);
            Controls.Add(btnnew);
            Controls.Add(btnlogout);
            Controls.Add(btnsave);
            Controls.Add(label10);
            Controls.Add(txtno);
            Controls.Add(label2);
            Controls.Add(textsearch);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormRental";
            Size = new Size(1688, 1182);
            Load += FormRental_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label txtmessage;
        private DataGridView dataGridView1;
        private Label label3;
        private Button btnclose;
        private Button updatebtn;
        private Button btnnew;
        private Button btnlogout;
        private Button btnsave;
        private Label label10;
        private TextBox txtno;
        private Label label2;
        private TextBox textsearch;
        private Label label1;
        private ErrorProvider errorProvider1;
        private Label label4;
        private Label label6;
        private TextBox txtstpo;
        private TextBox txtskh;
        private TextBox txtstn;
        private TextBox txtstid;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtprice;
        private DateTimePicker dprental;
        private ComboBox cbid;
        private TextBox txtnamet;
        private Label label12;
        private ComboBox cbidt;
        private GroupBox groupBox1;
        private Button tbnupdate;
        private Button button2;
        private Button btninsert;
    }
}
