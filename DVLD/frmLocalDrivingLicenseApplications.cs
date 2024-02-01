using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLocalDrivingLicenseApplications : Form
    {
        public frmLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            DataTable dt = clsLocalDrivingLicenseApplications_View.GetAllLocalDrivingLicenseApplication();

            dataGridView1.DataSource = dt;

        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void frmLocalDrivingLicenseApplications_Load( object sender, EventArgs e )
        {
            _LoadData();
        }

        private void btnAddNewApplication_Click( object sender, EventArgs e )
        {
            frmNewLicenseApplication frm = new frmNewLicenseApplication( -1 );
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmShowApplicationDetails frm = new frmShowApplicationDetails( dataGridView1.CurrentRow.Cells[ 2 ].Value.ToString() );
            frm.ShowDialog();
        }

        private void shcduleToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmVisionTestAppointment frm = new frmVisionTestAppointment( dataGridView1.CurrentRow.Cells[ 2 ].Value.ToString() );
            frm.ShowDialog();
        }

        private void scheduleStreetTestToolStripMenuItem_Click( object sender, EventArgs e )
        {

        }
    }
}
