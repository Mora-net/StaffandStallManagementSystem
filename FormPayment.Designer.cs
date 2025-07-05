namespace StaffandStallManagementSystem
{
    partial class FormPayment
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            btninsert = new Button();
            groupBox1 = new GroupBox();
            txtnoo = new TextBox();
            txtrno = new Label();
            tbnupdate = new Button();
            cbid = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtprice = new TextBox();
            dpline = new DateTimePicker();
            txtnamet = new TextBox();
            label12 = new Label();
            cbidt = new ComboBox();
            txtstpo = new TextBox();
            txtskh = new TextBox();
            txtstn = new TextBox();
            txtstid = new TextBox();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtmessage = new Label();
            dataGridView1 = new DataGridView();
            btnclose = new Button();
            updatebtn = new Button();
            btnnew = new Button();
            label4 = new Label();
            btnlogout = new Button();
            label10 = new Label();
            txtno = new TextBox();
            label2 = new Label();
            textsearch = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnsave = new Button();
            label13 = new Label();
            dppay = new DateTimePicker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btninsert
            // 
            btninsert.BackColor = Color.FromArgb(128, 255, 128);
            btninsert.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btninsert.Location = new Point(400, 120);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(128, 47);
            btninsert.TabIndex = 100;
            btninsert.Text = "Insert";
            btninsert.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtnoo);
            groupBox1.Controls.Add(txtrno);
            groupBox1.Controls.Add(tbnupdate);
            groupBox1.Controls.Add(cbid);
            groupBox1.Controls.Add(btninsert);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtprice);
            groupBox1.Controls.Add(dpline);
            groupBox1.Location = new Point(44, 339);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(771, 213);
            groupBox1.TabIndex = 124;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payment Detail";
            // 
            // txtnoo
            // 
            txtnoo.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnoo.Location = new Point(163, 163);
            txtnoo.Name = "txtnoo";
            txtnoo.ReadOnly = true;
            txtnoo.Size = new Size(210, 34);
            txtnoo.TabIndex = 126;
            // 
            // txtrno
            // 
            txtrno.AutoSize = true;
            txtrno.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtrno.ForeColor = SystemColors.ActiveCaptionText;
            txtrno.Location = new Point(22, 163);
            txtrno.Name = "txtrno";
            txtrno.Size = new Size(105, 26);
            txtrno.TabIndex = 125;
            txtrno.Text = "Rental No";
            // 
            // tbnupdate
            // 
            tbnupdate.BackColor = Color.FromArgb(255, 255, 128);
            tbnupdate.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbnupdate.Location = new Point(599, 120);
            tbnupdate.Name = "tbnupdate";
            tbnupdate.Size = new Size(128, 47);
            tbnupdate.TabIndex = 101;
            tbnupdate.Text = "Update";
            tbnupdate.UseVisualStyleBackColor = false;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(127, 26);
            label3.TabIndex = 75;
            label3.Text = "Total Amout";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(399, 45);
            label5.Name = "label5";
            label5.Size = new Size(136, 26);
            label5.TabIndex = 79;
            label5.Text = "Invoice  Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(12, 50);
            label6.Name = "label6";
            label6.Size = new Size(116, 26);
            label6.TabIndex = 84;
            label6.Text = "Invoice No";
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
            // dpline
            // 
            dpline.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dpline.Format = DateTimePickerFormat.Short;
            dpline.Location = new Point(552, 42);
            dpline.Name = "dpline";
            dpline.Size = new Size(210, 34);
            dpline.TabIndex = 94;
            dpline.Value = new DateTime(2025, 6, 6, 14, 8, 2, 0);
            // 
            // txtnamet
            // 
            txtnamet.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnamet.Location = new Point(596, 293);
            txtnamet.Name = "txtnamet";
            txtnamet.ReadOnly = true;
            txtnamet.Size = new Size(210, 34);
            txtnamet.TabIndex = 123;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(433, 293);
            label12.Name = "label12";
            label12.Size = new Size(134, 26);
            label12.TabIndex = 122;
            label12.Text = "Tenant Name";
            // 
            // cbidt
            // 
            cbidt.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbidt.FormattingEnabled = true;
            cbidt.Location = new Point(596, 222);
            cbidt.Name = "cbidt";
            cbidt.Size = new Size(210, 34);
            cbidt.TabIndex = 121;
            // 
            // txtstpo
            // 
            txtstpo.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtstpo.Location = new Point(596, 163);
            txtstpo.Name = "txtstpo";
            txtstpo.ReadOnly = true;
            txtstpo.Size = new Size(210, 34);
            txtstpo.TabIndex = 120;
            // 
            // txtskh
            // 
            txtskh.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtskh.Location = new Point(202, 286);
            txtskh.Name = "txtskh";
            txtskh.ReadOnly = true;
            txtskh.Size = new Size(210, 34);
            txtskh.TabIndex = 119;
            // 
            // txtstn
            // 
            txtstn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtstn.Location = new Point(202, 229);
            txtstn.Name = "txtstn";
            txtstn.ReadOnly = true;
            txtstn.Size = new Size(210, 34);
            txtstn.TabIndex = 118;
            // 
            // txtstid
            // 
            txtstid.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtstid.Location = new Point(198, 166);
            txtstid.Name = "txtstid";
            txtstid.ReadOnly = true;
            txtstid.Size = new Size(210, 34);
            txtstid.TabIndex = 117;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(433, 163);
            label11.Name = "label11";
            label11.Size = new Size(139, 26);
            label11.TabIndex = 116;
            label11.Text = "Staff Position";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(44, 166);
            label9.Name = "label9";
            label9.Size = new Size(87, 26);
            label9.TabIndex = 115;
            label9.Text = "Staff ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(42, 294);
            label8.Name = "label8";
            label8.Size = new Size(154, 26);
            label8.TabIndex = 114;
            label8.Text = "Staff Name KH";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(44, 237);
            label7.Name = "label7";
            label7.Size = new Size(152, 26);
            label7.TabIndex = 113;
            label7.Text = "Staff Name EN";
            // 
            // txtmessage
            // 
            txtmessage.AutoSize = true;
            txtmessage.BackColor = SystemColors.ButtonHighlight;
            txtmessage.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmessage.ForeColor = SystemColors.ActiveCaptionText;
            txtmessage.Location = new Point(408, 513);
            txtmessage.Name = "txtmessage";
            txtmessage.Size = new Size(0, 39);
            txtmessage.TabIndex = 111;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 613);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(783, 95);
            dataGridView1.TabIndex = 110;
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.Red;
            btnclose.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnclose.Location = new Point(678, 714);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(128, 47);
            btnclose.TabIndex = 109;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = false;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.FromArgb(255, 255, 128);
            updatebtn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updatebtn.Location = new Point(174, 714);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(128, 47);
            updatebtn.TabIndex = 108;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            // 
            // btnnew
            // 
            btnnew.BackColor = Color.FromArgb(192, 255, 255);
            btnnew.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnew.Location = new Point(357, 714);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(128, 47);
            btnnew.TabIndex = 107;
            btnnew.Text = "New";
            btnnew.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(433, 227);
            label4.Name = "label4";
            label4.Size = new Size(98, 26);
            label4.TabIndex = 112;
            label4.Text = "TenantID";
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.LightCoral;
            btnlogout.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogout.Location = new Point(516, 714);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(128, 47);
            btnlogout.TabIndex = 106;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(408, 23);
            label10.Name = "label10";
            label10.Size = new Size(282, 34);
            label10.TabIndex = 104;
            label10.Text = "Payment's Information";
            // 
            // txtno
            // 
            txtno.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtno.Location = new Point(198, 102);
            txtno.Name = "txtno";
            txtno.ReadOnly = true;
            txtno.Size = new Size(210, 34);
            txtno.TabIndex = 103;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(44, 102);
            label2.Name = "label2";
            label2.Size = new Size(127, 26);
            label2.TabIndex = 102;
            label2.Text = "Payment No";
            // 
            // textsearch
            // 
            textsearch.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textsearch.Location = new Point(113, 559);
            textsearch.Name = "textsearch";
            textsearch.Size = new Size(272, 34);
            textsearch.TabIndex = 101;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(32, 559);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 100;
            label1.Text = "Search";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.FromArgb(128, 255, 128);
            btnsave.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(21, 714);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(128, 47);
            btnsave.TabIndex = 105;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(436, 100);
            label13.Name = "label13";
            label13.Size = new Size(141, 26);
            label13.TabIndex = 127;
            label13.Text = "Payment Date";
            // 
            // dppay
            // 
            dppay.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dppay.Format = DateTimePickerFormat.Short;
            dppay.Location = new Point(596, 94);
            dppay.Name = "dppay";
            dppay.Size = new Size(210, 34);
            dppay.TabIndex = 127;
            dppay.Value = new DateTime(2025, 6, 6, 14, 8, 2, 0);
            // 
            // FormPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(dppay);
            Controls.Add(label13);
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
            Controls.Add(txtmessage);
            Controls.Add(dataGridView1);
            Controls.Add(btnclose);
            Controls.Add(updatebtn);
            Controls.Add(btnnew);
            Controls.Add(label4);
            Controls.Add(btnlogout);
            Controls.Add(label10);
            Controls.Add(txtno);
            Controls.Add(label2);
            Controls.Add(textsearch);
            Controls.Add(label1);
            Controls.Add(btnsave);
            Name = "FormPayment";
            Size = new Size(1016, 804);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btninsert;
        private GroupBox groupBox1;
        private Button tbnupdate;
        private ComboBox cbid;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtprice;
        private DateTimePicker dpline;
        private TextBox txtnamet;
        private Label label12;
        private ComboBox cbidt;
        private TextBox txtstpo;
        private TextBox txtskh;
        private TextBox txtstn;
        private TextBox txtstid;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label txtmessage;
        private DataGridView dataGridView1;
        private Button btnclose;
        private Button updatebtn;
        private Button btnnew;
        private Label label4;
        private Button btnlogout;
        private Label label10;
        private TextBox txtno;
        private Label label2;
        private TextBox textsearch;
        private Label label1;
        private ErrorProvider errorProvider1;
        private Button btnsave;
        private TextBox txtnoo;
        private Label txtrno;
        private DateTimePicker dppay;
        private Label label13;
    }
}
