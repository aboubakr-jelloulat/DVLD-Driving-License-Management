using Presentation.People.Managments.People.List;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Home_Pages
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            


        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            Form frmPeopleList = new FrmPeopleList();

            frmPeopleList.ShowDialog();
        }
    }
}
