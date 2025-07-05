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
    public partial class UserControlmainForm : UserControl
    {
        public UserControlmainForm()
        {
            InitializeComponent();
            btnlogout.Click += Btnlogout_Click;
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
