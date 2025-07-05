using Microsoft.Data.SqlClient;

namespace StaffandStallManagementSystem
{
    public partial class MultiForm : Form
    {
        public bool IsnavbarShow = false;
        public MultiForm()
        {
            InitializeComponent();
            NavbarHide();
            LoadForm(new UserControlmainForm());
            btnnavbar.Click += Btnnavbar_Click;
            bnthome.Click += Bnthome_Click;
            btnStaff.Click += BtnStaff_Click;
            Navbarpanel.Cursor = Cursors.Hand;
            btnStallType.Click += BtnStaff_Click1;
            btnuser.Click += Btnuser_Click;
            btntanent.Click += Btntanent_Click;
            btnstall.Click += Btnstall_Click;
            btnRental.Click += BtnRental_Click;
            btnpayroll.Click += Btnpayroll_Click;
            btnpayment.Click += Btnpayment_Click;
            btninvoice.Click += Btninvoice_Click;
            btnlatepayment.Click += Btnlatepayment_Click;

            this.ControlBox = false;

        }

        private void Btnlatepayment_Click(object? sender, EventArgs e)
        {
            LoadForm(new FormLatepayment());
        }

        private void Btninvoice_Click(object? sender, EventArgs e)
        {
            LoadForm(new FormInvoice());
        }

        private void Btnpayment_Click(object? sender, EventArgs e)
        {
            LoadForm(new FormPayment());
        }
        private void Btnpayroll_Click(object? sender, EventArgs e)
        {
            LoadForm(new FormPayroll());
        }
        private void BtnRental_Click(object? sender, EventArgs e)
        {
            LoadForm(new FormRental());
        }
        private void Btnstall_Click(object? sender, EventArgs e)
        {
            LoadForm(new FormStall());
        }
        private void Btntanent_Click(object? sender, EventArgs e)
        {
            LoadForm(new FormTanent());
        }
        private void Btnuser_Click(object? sender, EventArgs e)
        {
            if (Program.positonStaff != "Manager")
            {
                MessageBox.Show("Only Manager Can Controll This Form", "User Form",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else LoadForm(new FormUser());
        }
        private void BtnStaff_Click1(object? sender, EventArgs e)
        {
            LoadForm(new FromStallType());
        }
        private void BtnStaff_Click(object? sender, EventArgs e)
        {
            LoadForm(new FormStaff());

        }
        public void NavbarShow()
        {
            bntpanel.Visible = true;
            Navbarpanel.Size = new Size(207, 914);
            Navbarpanel.Location = new Point(2,2);
            Contentpanel.Size = new Size(1200, 914);
            Contentpanel.Location = new Point(215, 2);
            btnnavbar.Size = new Size(62, 50);
            btnnavbar.Location = new Point(73, 20);
            this.Size = new Size(1200, 950);
            IsnavbarShow = true;
        }
        public void NavbarHide()
        {
            Navbarpanel.Size = new Size(81, 914);
            Navbarpanel.Location = new Point(2, 2);
            btnnavbar.Size = new Size(62, 50);
            btnnavbar.Location = new Point(10, 10);
            bntpanel.Visible = false;
            Contentpanel.Size = new Size(1070, 914);
            Contentpanel.Location = new Point(89, 2);
            this.Size = new Size(1070, 950);
            IsnavbarShow = false;

        }
        private void Bnthome_Click(object? sender, EventArgs e)
        {
            LoadForm(new UserControlmainForm());
        }
        private void LoadForm(UserControl uc)
        {
            Contentpanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            Contentpanel.Controls.Add(uc);
        }
        private void Btnnavbar_Click(object? sender, EventArgs e)
        {
            if (IsnavbarShow == false) NavbarShow();
            else NavbarHide();


        }
        private void button_Click(object sender, EventArgs e)
        {

        }
        private void MultiForm_Load(object sender, EventArgs e)
        {

        }
        public static SqlConnection Connection = new(
         @"server=DESKTOP-KPD5D9S\\MSSQLSEVER2022;database=MORADDB;
          user id=immora; password=mora123; encrypt=false");
        public static SqlCommand InsertStaffCommand = default!;
    }
}
