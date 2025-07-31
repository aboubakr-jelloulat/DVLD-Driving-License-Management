using Business.People.Business;
using Presentation.People.Managments.AddPeople;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.People.Managments.People.List
{
    public partial class FrmPeopleList : Form
    {
        public FrmPeopleList()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshPeopleList()
        {

            dgvPeople.Font = new Font("Segoe UI", 10, FontStyle.Italic);

            dgvPeople.DataSource =  clsPeople.GetAllPeople();
            lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();

        }

        private void FrmPeopleList_Load(object sender, EventArgs e)
        {
            _RefreshPeopleList();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form frm1 = new FrmAddUpdatePeople();

            frm1.ShowDialog();

            _RefreshPeopleList();
        }
    }
}
