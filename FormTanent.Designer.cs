namespace StaffandStallManagementSystem
{
    partial class FormTanent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTanent));
            txtphone = new MaskedTextBox();
            groupBox1 = new GroupBox();
            txtprovince = new TextBox();
            txtcity = new Label();
            txtsangkat = new TextBox();
            label14 = new Label();
            txtkhan = new TextBox();
            txtkhann = new Label();
            txtstreet = new TextBox();
            label13 = new Label();
            txthouse = new TextBox();
            label11 = new Label();
            rdfemale = new RadioButton();
            rdmale = new RadioButton();
            label10 = new Label();
            label9 = new Label();
            label5 = new Label();
            txtkhname = new TextBox();
            label4 = new Label();
            txtenname = new TextBox();
            label3 = new Label();
            txtid = new TextBox();
            k = new Label();
            lbtenant = new ListBox();
            txtsearch = new TextBox();
            label1 = new Label();
            btnclose = new Button();
            btnupdate = new Button();
            btnnew = new Button();
            txtlogout = new Button();
            btnsave = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtphone
            // 
            txtphone.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtphone.Location = new Point(435, 456);
            txtphone.Mask = "(855)-00-000-0000";
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(261, 34);
            txtphone.TabIndex = 58;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtprovince);
            groupBox1.Controls.Add(txtcity);
            groupBox1.Controls.Add(txtsangkat);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtkhan);
            groupBox1.Controls.Add(txtkhann);
            groupBox1.Controls.Add(txtstreet);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txthouse);
            groupBox1.Controls.Add(label11);
            groupBox1.Location = new Point(293, 511);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(604, 223);
            groupBox1.TabIndex = 57;
            groupBox1.TabStop = false;
            groupBox1.Text = "Address";
            // 
            // txtprovince
            // 
            txtprovince.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtprovince.Location = new Point(142, 74);
            txtprovince.Name = "txtprovince";
            txtprovince.Size = new Size(419, 34);
            txtprovince.TabIndex = 42;
            // 
            // txtcity
            // 
            txtcity.AutoSize = true;
            txtcity.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcity.ForeColor = SystemColors.ActiveCaptionText;
            txtcity.Location = new Point(6, 77);
            txtcity.Name = "txtcity";
            txtcity.Size = new Size(140, 26);
            txtcity.TabIndex = 41;
            txtcity.Text = "Province/City";
            // 
            // txtsangkat
            // 
            txtsangkat.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsangkat.Location = new Point(142, 174);
            txtsangkat.Name = "txtsangkat";
            txtsangkat.Size = new Size(419, 34);
            txtsangkat.TabIndex = 48;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(14, 174);
            label14.Name = "label14";
            label14.Size = new Size(90, 26);
            label14.TabIndex = 47;
            label14.Text = "SangKat";
            // 
            // txtkhan
            // 
            txtkhan.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtkhan.Location = new Point(142, 126);
            txtkhan.Name = "txtkhan";
            txtkhan.Size = new Size(419, 34);
            txtkhan.TabIndex = 46;
            // 
            // txtkhann
            // 
            txtkhann.AutoSize = true;
            txtkhann.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtkhann.ForeColor = SystemColors.ActiveCaptionText;
            txtkhann.Location = new Point(18, 129);
            txtkhann.Name = "txtkhann";
            txtkhann.Size = new Size(74, 26);
            txtkhann.TabIndex = 45;
            txtkhann.Text = "Khann";
            // 
            // txtstreet
            // 
            txtstreet.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtstreet.Location = new Point(438, 26);
            txtstreet.Name = "txtstreet";
            txtstreet.Size = new Size(123, 34);
            txtstreet.TabIndex = 44;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(328, 34);
            label13.Name = "label13";
            label13.Size = new Size(99, 26);
            label13.TabIndex = 43;
            label13.Text = "Street No";
            // 
            // txthouse
            // 
            txthouse.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txthouse.Location = new Point(124, 23);
            txthouse.Name = "txthouse";
            txthouse.Size = new Size(130, 34);
            txthouse.TabIndex = 42;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(7, 23);
            label11.Name = "label11";
            label11.Size = new Size(104, 26);
            label11.TabIndex = 41;
            label11.Text = "House No";
            // 
            // rdfemale
            // 
            rdfemale.AutoSize = true;
            rdfemale.Location = new Point(535, 396);
            rdfemale.Name = "rdfemale";
            rdfemale.Size = new Size(78, 24);
            rdfemale.TabIndex = 55;
            rdfemale.Text = "Female";
            rdfemale.UseVisualStyleBackColor = true;
            // 
            // rdmale
            // 
            rdmale.AutoSize = true;
            rdmale.Checked = true;
            rdmale.Location = new Point(438, 396);
            rdmale.Name = "rdmale";
            rdmale.Size = new Size(63, 24);
            rdmale.TabIndex = 54;
            rdmale.TabStop = true;
            rdmale.Text = "Male";
            rdmale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(436, 62);
            label10.Name = "label10";
            label10.Size = new Size(260, 34);
            label10.TabIndex = 53;
            label10.Text = "Tenant's Information";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(312, 456);
            label9.Name = "label9";
            label9.Size = new Size(71, 26);
            label9.TabIndex = 52;
            label9.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(313, 399);
            label5.Name = "label5";
            label5.Size = new Size(46, 26);
            label5.TabIndex = 50;
            label5.Text = "Sex";
            // 
            // txtkhname
            // 
            txtkhname.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtkhname.Location = new Point(435, 343);
            txtkhname.Name = "txtkhname";
            txtkhname.Size = new Size(261, 34);
            txtkhname.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(303, 351);
            label4.Name = "label4";
            label4.Size = new Size(110, 26);
            label4.TabIndex = 48;
            label4.Text = "Last Name";
            // 
            // txtenname
            // 
            txtenname.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtenname.Location = new Point(432, 296);
            txtenname.Name = "txtenname";
            txtenname.Size = new Size(261, 34);
            txtenname.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(303, 304);
            label3.Name = "label3";
            label3.Size = new Size(114, 26);
            label3.TabIndex = 46;
            label3.Text = "First Name";
            // 
            // txtid
            // 
            txtid.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtid.Location = new Point(432, 234);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(261, 34);
            txtid.TabIndex = 45;
            // 
            // k
            // 
            k.AutoSize = true;
            k.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            k.ForeColor = SystemColors.ActiveCaptionText;
            k.Location = new Point(308, 234);
            k.Name = "k";
            k.Size = new Size(104, 26);
            k.TabIndex = 44;
            k.Text = "Tenant ID";
            // 
            // lbtenant
            // 
            lbtenant.FormattingEnabled = true;
            lbtenant.Location = new Point(26, 228);
            lbtenant.Name = "lbtenant";
            lbtenant.Size = new Size(261, 504);
            lbtenant.TabIndex = 43;
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsearch.Location = new Point(26, 166);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(261, 34);
            txtsearch.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(26, 124);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 41;
            label1.Text = "Search";
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.Red;
            btnclose.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnclose.Location = new Point(743, 778);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(128, 47);
            btnclose.TabIndex = 63;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.FromArgb(255, 255, 128);
            btnupdate.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(231, 778);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(128, 47);
            btnupdate.TabIndex = 62;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = false;
            // 
            // btnnew
            // 
            btnnew.BackColor = Color.FromArgb(192, 255, 255);
            btnnew.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnew.Location = new Point(409, 778);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(128, 47);
            btnnew.TabIndex = 61;
            btnnew.Text = "New";
            btnnew.UseVisualStyleBackColor = false;
            // 
            // txtlogout
            // 
            txtlogout.BackColor = Color.LightCoral;
            txtlogout.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtlogout.Location = new Point(583, 778);
            txtlogout.Name = "txtlogout";
            txtlogout.Size = new Size(128, 47);
            txtlogout.TabIndex = 60;
            txtlogout.Text = "Log Out";
            txtlogout.UseVisualStyleBackColor = false;
            txtlogout.Click += txtlogout_Click_1;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.FromArgb(128, 255, 128);
            btnsave.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(35, 778);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(128, 47);
            btnsave.TabIndex = 59;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // FormTanent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(btnclose);
            Controls.Add(btnupdate);
            Controls.Add(btnnew);
            Controls.Add(txtlogout);
            Controls.Add(btnsave);
            Controls.Add(txtphone);
            Controls.Add(groupBox1);
            Controls.Add(rdfemale);
            Controls.Add(rdmale);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(txtkhname);
            Controls.Add(label4);
            Controls.Add(txtenname);
            Controls.Add(label3);
            Controls.Add(txtid);
            Controls.Add(k);
            Controls.Add(lbtenant);
            Controls.Add(txtsearch);
            Controls.Add(label1);
            Name = "FormTanent";
            Size = new Size(1080, 911);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtphone;
        private GroupBox groupBox1;
        private TextBox txtprovince;
        private Label txtcity;
        private TextBox txtsangkat;
        private Label label14;
        private TextBox txtkhan;
        private Label txtkhann;
        private TextBox txtstreet;
        private Label label13;
        private TextBox txthouse;
        private Label label11;
        private RadioButton rdfemale;
        private RadioButton rdmale;
        private Label label10;
        private Label label9;
        private Label label5;
        private TextBox txtkhname;
        private Label label4;
        private TextBox txtenname;
        private Label label3;
        private TextBox txtid;
        private Label k;
        private ListBox lbtenant;
        private TextBox txtsearch;
        private Label label1;
        private Button btnclose;
        private Button btnupdate;
        private Button btnnew;
        private Button txtlogout;
        private Button btnsave;
        private ErrorProvider errorProvider1;
    }
}
