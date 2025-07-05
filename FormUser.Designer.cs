namespace StaffandStallManagementSystem
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            errorProvider1 = new ErrorProvider(components);
            btnclose = new Button();
            btnupdate = new Button();
            btnnew = new Button();
            txtlogout = new Button();
            btnsave = new Button();
            label10 = new Label();
            txtpass = new TextBox();
            label4 = new Label();
            txtusername = new TextBox();
            label3 = new Label();
            txtid = new TextBox();
            lbuser = new ListBox();
            txtsearch = new TextBox();
            label1 = new Label();
            k = new Label();
            groupBox1 = new GroupBox();
            cbname = new ComboBox();
            txtpos = new TextBox();
            label12 = new Label();
            txtnamekh = new TextBox();
            t = new Label();
            txtids = new TextBox();
            label8 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.Red;
            btnclose.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnclose.Location = new Point(817, 687);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(128, 47);
            btnclose.TabIndex = 84;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.FromArgb(255, 255, 128);
            btnupdate.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(305, 687);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(128, 47);
            btnupdate.TabIndex = 83;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = false;
            // 
            // btnnew
            // 
            btnnew.BackColor = Color.FromArgb(192, 255, 255);
            btnnew.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnew.Location = new Point(483, 687);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(128, 47);
            btnnew.TabIndex = 82;
            btnnew.Text = "New";
            btnnew.UseVisualStyleBackColor = false;
            // 
            // txtlogout
            // 
            txtlogout.BackColor = Color.LightCoral;
            txtlogout.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtlogout.Location = new Point(657, 687);
            txtlogout.Name = "txtlogout";
            txtlogout.Size = new Size(128, 47);
            txtlogout.TabIndex = 81;
            txtlogout.Text = "Log Out";
            txtlogout.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.FromArgb(128, 255, 128);
            btnsave.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(109, 687);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(128, 47);
            btnsave.TabIndex = 80;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(332, 49);
            label10.Name = "label10";
            label10.Size = new Size(235, 34);
            label10.TabIndex = 75;
            label10.Text = "User's Information";
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.Location = new Point(562, 355);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(261, 34);
            txtpass.TabIndex = 72;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(382, 363);
            label4.Name = "label4";
            label4.Size = new Size(102, 26);
            label4.TabIndex = 71;
            label4.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(562, 308);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(261, 34);
            txtusername.TabIndex = 70;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(382, 316);
            label3.Name = "label3";
            label3.Size = new Size(114, 26);
            label3.TabIndex = 69;
            label3.Text = "User Name";
            // 
            // txtid
            // 
            txtid.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtid.Location = new Point(563, 246);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(261, 34);
            txtid.TabIndex = 68;
            // 
            // lbuser
            // 
            lbuser.FormattingEnabled = true;
            lbuser.Location = new Point(105, 240);
            lbuser.Name = "lbuser";
            lbuser.Size = new Size(261, 404);
            lbuser.TabIndex = 66;
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsearch.Location = new Point(105, 178);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(261, 34);
            txtsearch.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(105, 136);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 64;
            label1.Text = "Search";
            // 
            // k
            // 
            k.AutoSize = true;
            k.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            k.ForeColor = SystemColors.ActiveCaptionText;
            k.Location = new Point(387, 246);
            k.Name = "k";
            k.Size = new Size(84, 26);
            k.TabIndex = 67;
            k.Text = "User ID";
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
            groupBox1.Location = new Point(382, 395);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 249);
            groupBox1.TabIndex = 91;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff";
            groupBox1.Enter += groupBox1_Enter;
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
            // txtpos
            // 
            txtpos.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpos.Location = new Point(180, 196);
            txtpos.Name = "txtpos";
            txtpos.ReadOnly = true;
            txtpos.Size = new Size(269, 34);
            txtpos.TabIndex = 98;
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
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(groupBox1);
            Controls.Add(btnclose);
            Controls.Add(btnupdate);
            Controls.Add(btnnew);
            Controls.Add(txtlogout);
            Controls.Add(btnsave);
            Controls.Add(label10);
            Controls.Add(txtpass);
            Controls.Add(label4);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(txtid);
            Controls.Add(lbuser);
            Controls.Add(txtsearch);
            Controls.Add(label1);
            Controls.Add(k);
            Name = "FormUser";
            Size = new Size(1080, 911);
            Load += FormUser_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Button btnclose;
        private Button btnupdate;
        private Button btnnew;
        private Button txtlogout;
        private Button btnsave;
        private RadioButton rdfemale;
        private RadioButton rdmale;
        private Label label10;
        private TextBox txtpass;
        private Label label4;
        private TextBox txtusername;
        private Label label3;
        private TextBox txtid;
        private ListBox lbuser;
        private TextBox txtsearch;
        private Label label1;
        private Label k;
        private GroupBox groupBox1;
        private TextBox txtpos;
        private Label label12;
        private TextBox txtnamekh;
        private Label t;
        private TextBox txtids;
        private Label label8;
        private Label label11;
        private ComboBox cbname;
    }
}
