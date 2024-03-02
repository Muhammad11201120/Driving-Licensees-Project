using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;
namespace DVLD
{
    public partial class frmManageInternationalLicenses : Form
    {
        clsPeople _person = null;
        clsLicenses _license = null;
        public frmManageInternationalLicenses()
        {
            InitializeComponent();
        }
        private void _LoadForm()
        {
            DataTable dt = new DataTable();

            dt = clsInternationalLicense.GetAllInterNationalLicenses();
            DataView dv = new DataView( dt );

            dataGridView1.DataSource = dv;
        }


        private void frmManageInternationalLicenses_Load_1( object sender, EventArgs e )
        {
            _LoadForm();
        }

        private void showPersonToolStripMenuItem_Click( object sender, EventArgs e )
        {
            int driverId = int.Parse( dataGridView1.CurrentRow.Cells[ 2 ].Value.ToString() );

            frmShowPersonDetails frm = new frmShowPersonDetails( clsDrivers.FindDriverByDriverID( driverId ).PersonID );
            frm.ShowDialog();
        }

        private void showLicenseInfoToolStripMenuItem_Click( object sender, EventArgs e )
        {
            int driverId = int.Parse( dataGridView1.CurrentRow.Cells[ 2 ].Value.ToString() );
            _license = clsLicenses.FindLicenseByDriverID( driverId );

            frmLicenseInfo frm = new frmLicenseInfo( _license );
            frm.ShowDialog();
        }

        private void showLicenseHistoryToolStripMenuItem_Click( object sender, EventArgs e )
        {
            int driverId = int.Parse( dataGridView1.CurrentRow.Cells[ 2 ].Value.ToString() );
            _person = clsPeople.FindPersonByID( clsDrivers.FindDriverByDriverID( driverId ).PersonID );
            frmShowLicenseHistory frm = new frmShowLicenseHistory( _person.ID );
            frm.ShowDialog();
        }
    }
}
