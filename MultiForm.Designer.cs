namespace StaffandStallManagementSystem
{
    partial class MultiForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Navbarpanel = new Panel();
            bntpanel = new Panel();
            bnthome = new Button();
            btnStaff = new Button();
            btnpayroll = new Button();
            btnstall = new Button();
            btnlatepayment = new Button();
            btnRental = new Button();
            btntanent = new Button();
            btnpayment = new Button();
            btnuser = new Button();
            btnStallType = new Button();
            btninvoice = new Button();
            btnnavbar = new Button();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            Contentpanel = new Panel();
            Navbarpanel.SuspendLayout();
            bntpanel.SuspendLayout();
            Contentpanel.SuspendLayout();
            SuspendLayout();
            // 
            // Navbarpanel
            // 
            Navbarpanel.BackColor = SystemColors.InactiveCaption;
            Navbarpanel.Controls.Add(bntpanel);
            Navbarpanel.Controls.Add(btnnavbar);
            Navbarpanel.Controls.Add(panel1);
            Navbarpanel.ForeColor = Color.White;
            Navbarpanel.Location = new Point(2, 2);
            Navbarpanel.Name = "Navbarpanel";
            Navbarpanel.Size = new Size(207, 914);
            Navbarpanel.TabIndex = 0;
            // 
            // bntpanel
            // 
            bntpanel.Controls.Add(bnthome);
            bntpanel.Controls.Add(btnStaff);
            bntpanel.Controls.Add(btnpayroll);
            bntpanel.Controls.Add(btnstall);
            bntpanel.Controls.Add(btnlatepayment);
            bntpanel.Controls.Add(btnRental);
            bntpanel.Controls.Add(btntanent);
            bntpanel.Controls.Add(btnpayment);
            bntpanel.Controls.Add(btnuser);
            bntpanel.Controls.Add(btnStallType);
            bntpanel.Controls.Add(btninvoice);
            bntpanel.Location = new Point(10, 85);
            bntpanel.Name = "bntpanel";
            bntpanel.Size = new Size(179, 810);
            bntpanel.TabIndex = 3;
            // 
            // bnthome
            // 
            bnthome.BackColor = SystemColors.Info;
            bnthome.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bnthome.ForeColor = Color.Black;
            bnthome.Location = new Point(15, 18);
            bnthome.Name = "bnthome";
            bnthome.Size = new Size(158, 50);
            bnthome.TabIndex = 13;
            bnthome.Text = "Home";
            bnthome.UseVisualStyleBackColor = false;
            // 
            // btnStaff
            // 
            btnStaff.BackColor = SystemColors.Info;
            btnStaff.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStaff.ForeColor = Color.Black;
            btnStaff.Location = new Point(15, 84);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(158, 50);
            btnStaff.TabIndex = 3;
            btnStaff.Text = "FrmStaff";
            btnStaff.UseVisualStyleBackColor = false;
            // 
            // btnpayroll
            // 
            btnpayroll.BackColor = SystemColors.Info;
            btnpayroll.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpayroll.ForeColor = Color.Black;
            btnpayroll.Location = new Point(15, 748);
            btnpayroll.Name = "btnpayroll";
            btnpayroll.Size = new Size(158, 50);
            btnpayroll.TabIndex = 12;
            btnpayroll.Text = "FrmPayroll";
            btnpayroll.UseVisualStyleBackColor = false;
            // 
            // btnstall
            // 
            btnstall.BackColor = SystemColors.Info;
            btnstall.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnstall.ForeColor = Color.Black;
            btnstall.Location = new Point(15, 307);
            btnstall.Name = "btnstall";
            btnstall.Size = new Size(158, 50);
            btnstall.TabIndex = 6;
            btnstall.Text = "FrmStall";
            btnstall.UseVisualStyleBackColor = false;
            // 
            // btnlatepayment
            // 
            btnlatepayment.BackColor = SystemColors.Info;
            btnlatepayment.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlatepayment.ForeColor = Color.Black;
            btnlatepayment.Location = new Point(15, 689);
            btnlatepayment.Name = "btnlatepayment";
            btnlatepayment.Size = new Size(158, 41);
            btnlatepayment.TabIndex = 11;
            btnlatepayment.Text = "FrmLatePayment";
            btnlatepayment.UseVisualStyleBackColor = false;
            // 
            // btnRental
            // 
            btnRental.BackColor = SystemColors.Info;
            btnRental.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRental.ForeColor = Color.Black;
            btnRental.Location = new Point(15, 382);
            btnRental.Name = "btnRental";
            btnRental.Size = new Size(158, 50);
            btnRental.TabIndex = 7;
            btnRental.Text = "FrmRental";
            btnRental.UseVisualStyleBackColor = false;
            // 
            // btntanent
            // 
            btntanent.BackColor = SystemColors.Info;
            btntanent.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btntanent.ForeColor = Color.Black;
            btntanent.Location = new Point(15, 229);
            btntanent.Name = "btntanent";
            btntanent.Size = new Size(158, 50);
            btntanent.TabIndex = 5;
            btntanent.Text = "FrmTenant";
            btntanent.UseVisualStyleBackColor = false;
            // 
            // btnpayment
            // 
            btnpayment.BackColor = SystemColors.Info;
            btnpayment.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpayment.ForeColor = Color.Black;
            btnpayment.Location = new Point(15, 610);
            btnpayment.Name = "btnpayment";
            btnpayment.Size = new Size(158, 50);
            btnpayment.TabIndex = 10;
            btnpayment.Text = "FrmPayment";
            btnpayment.UseVisualStyleBackColor = false;
            // 
            // btnuser
            // 
            btnuser.BackColor = SystemColors.Info;
            btnuser.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnuser.ForeColor = Color.Black;
            btnuser.Location = new Point(15, 459);
            btnuser.Name = "btnuser";
            btnuser.Size = new Size(158, 50);
            btnuser.TabIndex = 8;
            btnuser.Text = "FrmUser";
            btnuser.UseVisualStyleBackColor = false;
            // 
            // btnStallType
            // 
            btnStallType.BackColor = SystemColors.Info;
            btnStallType.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStallType.ForeColor = Color.Black;
            btnStallType.Location = new Point(15, 152);
            btnStallType.Name = "btnStallType";
            btnStallType.Size = new Size(158, 50);
            btnStallType.TabIndex = 4;
            btnStallType.Text = "FrmStallType";
            btnStallType.UseVisualStyleBackColor = false;
            btnStallType.Click += button_Click;
            // 
            // btninvoice
            // 
            btninvoice.BackColor = SystemColors.Info;
            btninvoice.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btninvoice.ForeColor = Color.Black;
            btninvoice.Location = new Point(18, 534);
            btninvoice.Name = "btninvoice";
            btninvoice.Size = new Size(158, 50);
            btninvoice.TabIndex = 9;
            btninvoice.Text = "FrmInvoice";
            btninvoice.UseVisualStyleBackColor = false;
            // 
            // btnnavbar
            // 
            btnnavbar.BackColor = SystemColors.Info;
            btnnavbar.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnavbar.ForeColor = Color.Black;
            btnnavbar.Location = new Point(73, 20);
            btnnavbar.Name = "btnnavbar";
            btnnavbar.Size = new Size(62, 50);
            btnnavbar.TabIndex = 2;
            btnnavbar.Text = "☰";
            btnnavbar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(256, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Khmer OS Moul Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(252, 431);
            label6.Name = "label6";
            label6.Size = new Size(0, 41);
            label6.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Khmer OS Moul Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(284, 435);
            label7.Name = "label7";
            label7.Size = new Size(0, 41);
            label7.TabIndex = 6;
            // 
            // Contentpanel
            // 
            Contentpanel.BackColor = SystemColors.ActiveCaption;
            Contentpanel.Controls.Add(label7);
            Contentpanel.Controls.Add(label6);
            Contentpanel.Location = new Point(215, 2);
            Contentpanel.Name = "Contentpanel";
            Contentpanel.Size = new Size(926, 911);
            Contentpanel.TabIndex = 1;
            // 
            // MultiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 909);
            Controls.Add(Contentpanel);
            Controls.Add(Navbarpanel);
            Name = "MultiForm";
            Text = "Form1";
            Load += MultiForm_Load;
            Navbarpanel.ResumeLayout(false);
            bntpanel.ResumeLayout(false);
            Contentpanel.ResumeLayout(false);
            Contentpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnpayroll;
        private Button btnlatepayment;
        private Button btnpayment;
        private Button btninvoice;
        private Button btnuser;
        private Button btnRental;
        private Button btnstall;
        private Button btntanent;
        private Button btnStallType;
        private Button btnStaff;
        private Button btnnavbar;
        private Label label6;
        private Label label7;
        private Panel Contentpanel;
        private Panel bntpanel;
        public Panel Navbarpanel;
        private Button bnthome;
    }
}
