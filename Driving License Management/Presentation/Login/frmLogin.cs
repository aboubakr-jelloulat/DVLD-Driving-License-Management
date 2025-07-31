using Presentation.Home_Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Users;

namespace Presentation.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pbDrivingLiecenceImage_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _ShowDashboardForm()
        {
            Form form = new frmHome();

            form.Show();

            //this.Hide();

        }


        private void btnSubmet_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.FindUserByUserNameAndPassword(txtboxLoginUsername.Text.Trim(), txtboxLoginPassword.Text.Trim());

            if (user == null)
            {
                txtboxLoginUsername.Focus();
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (!user.IsActive)
                {
                    txtboxLoginUsername.Focus();
                    MessageBox.Show("User is not active", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _ShowDashboardForm();
            }

        }
    }
}
