namespace StaffandStallManagementSystem
{
    partial class FormPayroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayroll));
            txtpos = new TextBox();
            groupBox1 = new GroupBox();
            label12 = new Label();
            txtnamekh = new TextBox();
            t = new Label();
            txtids = new TextBox();
            label8 = new Label();
            label11 = new Label();
            btnclose = new Button();
            btnupdate = new Button();
            btnnew = new Button();
            txtlogout = new Button();
            btnsave = new Button();
            label10 = new Label();
            label4 = new Label();
            txtamount = new TextBox();
            label3 = new Label();
            txtid = new TextBox();
            k = new Label();
            errorProvider1 = new ErrorProvider(components);
            dppay = new DateTimePicker();
            label1 = new Label();
            txtsearch = new TextBox();
            lbuser = new ListBox();
            cbname = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtpos
            // 
            txtpos.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpos.Location = new Point(180, 196);
            txtpos.Name = "txtpos";
            txtpos.ReadOnly = true;
            txtpos.Size = new Size(269, 34);
            txtpos.TabIndex = 98;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbname);
            groupBox1.Controls.Add(txtpos);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtnamekh);
            groupBox1.Controls.Add(t);
            groupBox1.Controls.Add(txtids);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label11);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(365, 384);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 249);
            groupBox1.TabIndex = 107;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(8, 196);
            label12.Name = "label12";
            label12.Size = new Size(145, 26);
            label12.TabIndex = 97;
            label12.Text = "Staff Position ";
            // 
            // txtnamekh
            // 
            txtnamekh.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnamekh.Location = new Point(181, 139);
            txtnamekh.Name = "txtnamekh";
            txtnamekh.ReadOnly = true;
            txtnamekh.Size = new Size(268, 34);
            txtnamekh.TabIndex = 95;
            // 
            // t
            // 
            t.AutoSize = true;
            t.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            t.ForeColor = SystemColors.ActiveCaptionText;
            t.Location = new Point(8, 147);
            t.Name = "t";
            t.Size = new Size(154, 26);
            t.TabIndex = 94;
            t.Text = "Staff Name KH";
            // 
            // txtids
            // 
            txtids.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtids.Location = new Point(181, 85);
            txtids.Name = "txtids";
            txtids.ReadOnly = true;
            txtids.Size = new Size(268, 34);
            txtids.TabIndex = 93;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(6, 45);
            label8.Name = "label8";
            label8.Size = new Size(117, 26);
            label8.TabIndex = 92;
            label8.Text = "Staff Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(8, 93);
            label11.Name = "label11";
            label11.Size = new Size(81, 26);
            label11.TabIndex = 91;
            label11.Text = "StaffID";
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.Red;
            btnclose.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnclose.Location = new Point(800, 676);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(128, 47);
            btnclose.TabIndex = 106;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.FromArgb(255, 255, 128);
            btnupdate.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(288, 676);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(128, 47);
            btnupdate.TabIndex = 105;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = false;
            // 
            // btnnew
            // 
            btnnew.BackColor = Color.FromArgb(192, 255, 255);
            btnnew.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnew.Location = new Point(466, 676);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(128, 47);
            btnnew.TabIndex = 104;
            btnnew.Text = "New";
            btnnew.UseVisualStyleBackColor = false;
            // 
            // txtlogout
            // 
            txtlogout.BackColor = Color.LightCoral;
            txtlogout.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtlogout.Location = new Point(640, 676);
            txtlogout.Name = "txtlogout";
            txtlogout.Size = new Size(128, 47);
            txtlogout.TabIndex = 103;
            txtlogout.Text = "Log Out";
            txtlogout.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.FromArgb(128, 255, 128);
            btnsave.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(92, 676);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(128, 47);
            btnsave.TabIndex = 102;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(315, 38);
            label10.Name = "label10";
            label10.Size = new Size(235, 34);
            label10.TabIndex = 101;
            label10.Text = "User's Information";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(365, 352);
            label4.Name = "label4";
            label4.Size = new Size(127, 26);
            label4.TabIndex = 99;
            label4.Text = "Payroll Date";
            // 
            // txtamount
            // 
            txtamount.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtamount.Location = new Point(545, 297);
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(261, 34);
            txtamount.TabIndex = 98;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(365, 305);
            label3.Name = "label3";
            label3.Size = new Size(134, 26);
            label3.TabIndex = 97;
            label3.Text = "Piad Amount";
            // 
            // txtid
            // 
            txtid.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtid.Location = new Point(546, 235);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(261, 34);
            txtid.TabIndex = 96;
            // 
            // k
            // 
            k.AutoSize = true;
            k.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            k.ForeColor = SystemColors.ActiveCaptionText;
            k.Location = new Point(365, 243);
            k.Name = "k";
            k.Size = new Size(115, 26);
            k.TabIndex = 95;
            k.Text = "Payroll ID ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // dppay
            // 
            dppay.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dppay.Format = DateTimePickerFormat.Short;
            dppay.Location = new Point(545, 352);
            dppay.Name = "dppay";
            dppay.Size = new Size(262, 34);
            dppay.TabIndex = 100;
            dppay.Value = new DateTime(2025, 6, 6, 14, 8, 2, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(88, 125);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 92;
            label1.Text = "Search";
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsearch.Location = new Point(88, 167);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(261, 34);
            txtsearch.TabIndex = 93;
            // 
            // lbuser
            // 
            lbuser.FormattingEnabled = true;
            lbuser.Location = new Point(88, 229);
            lbuser.Name = "lbuser";
            lbuser.Size = new Size(261, 404);
            lbuser.TabIndex = 94;
            // 
            // cbname
            // 
            cbname.DropDownStyle = ComboBoxStyle.DropDownList;
            cbname.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbname.FormattingEnabled = true;
            cbname.Location = new Point(180, 37);
            cbname.Name = "cbname";
            cbname.Size = new Size(269, 34);
            cbname.TabIndex = 99;
            // 
            // FormPayroll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(dppay);
            Controls.Add(groupBox1);
            Controls.Add(btnclose);
            Controls.Add(btnupdate);
            Controls.Add(btnnew);
            Controls.Add(txtlogout);
            Controls.Add(btnsave);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(txtamount);
            Controls.Add(label3);
            Controls.Add(txtid);
            Controls.Add(lbuser);
            Controls.Add(txtsearch);
            Controls.Add(label1);
            Controls.Add(k);
            Name = "FormPayroll";
            Size = new Size(1016, 761);
            Load += FormPayroll_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtpos;
        private GroupBox groupBox1;
        private Label label12;
        private TextBox txtnamekh;
        private Label t;
        private TextBox txtids;
        private Label label8;
        private Label label11;
        private Button btnclose;
        private Button btnupdate;
        private Button btnnew;
        private Button txtlogout;
        private Button btnsave;
        private Label label10;
        private Label label4;
        private TextBox txtamount;
        private Label label3;
        private TextBox txtid;
        private Label k;
        private ErrorProvider errorProvider1;
        private DateTimePicker dppay;
        private ComboBox cbname;
        private ListBox lbuser;
        private TextBox txtsearch;
        private Label label1;
    }
}
