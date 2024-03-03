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
    public partial class frmManageDetainedLicenses : Form
    {
        clsDetsinedLicense detainLicense = null;
        clsPeople person = null;
        clsLicenses license = null;
        public frmManageDetainedLicenses()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            DataTable dt = clsDetsinedLicense.GetAllDetainLicenses();
            DataView dv = new DataView( dt );
            dataGridView1.DataSource = dv;
        }

        private void frmManageDetainedLicenses_Load( object sender, EventArgs e )
        {
            _LoadData();
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnDetain_Click( object sender, EventArgs e )
        {
            frmDetainLicense frm = new frmDetainLicense( -1 );
            frm.ShowDialog();
        }

        private void btnRelease_Click( object sender, EventArgs e )
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense( -1 );
            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening( object sender, CancelEventArgs e )
        {
            detainLicense = clsDetsinedLicense.FindDetainLicenseByLicenseID( int.Parse( dataGridView1.CurrentRow.Cells[ 1 ].Value.ToString() ) );
            if ( detainLicense.isRelaesed )
            {
                contextMenuStrip1.Items[ 3 ].Enabled = false;
            }
            else
            {
                contextMenuStrip1.Items[ 3 ].Enabled = true;
            }
        }

        private void showPersonDetailsToolStripMenuItem_Click( object sender, EventArgs e )
        {
            person = clsPeople.FindPersonByNationalID( dataGridView1.CurrentRow.Cells[ 6 ].Value.ToString() );
            frmShowPersonDetails frm = new frmShowPersonDetails( person.ID );
            frm.ShowDialog();
        }

        private void showPersonLicensesHistoryToolStripMenuItem_Click( object sender, EventArgs e )
        {
            person = clsPeople.FindPersonByNationalID( dataGridView1.CurrentRow.Cells[ 6 ].Value.ToString() );
            frmShowLicenseHistory frm = new frmShowLicenseHistory( person.ID );
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click( object sender, EventArgs e )
        {
            license = clsLicenses.FindLicenseByLicenseID( int.Parse( dataGridView1.CurrentRow.Cells[ 1 ].Value.ToString() ) );
            frmLicenseInfo frm = new frmLicenseInfo( license );
            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click( object sender, EventArgs e )
        {
            detainLicense = clsDetsinedLicense.FindDetainLicenseByLicenseID( int.Parse( dataGridView1.CurrentRow.Cells[ 1 ].Value.ToString() ) );
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense( detainLicense.detainID );
            frm.ShowDialog();
        }
    }
}
