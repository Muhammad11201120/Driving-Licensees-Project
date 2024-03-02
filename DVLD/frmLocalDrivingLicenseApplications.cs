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
        enum enFilters
        {
            Name = 0,
            NationalNo = 1,
            ApplicationStatus = 2,
            None = 3,
        }
        private int _TestType = 1;
        private clsLocalDrivingLicenseApplications _clsLocalDrivingLicenseApplication = null;
        private clsLicensesClasses _licenseClass = null;
        private clsLicenses _license = null;
        private clsPeople _person = null;
        private clsApplications application = null;
        private clsDrivers _driver = null;
        private clsTestAppointments _testAppointment = null;
        private clsTestTypes _testType = null;
        private clsTests _test = null;
        DataTable dt = clsLocalDrivingLicenseApplications_View.GetAllLocalDrivingLicenseApplication();
        int PassedTest = 0;


        public frmLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }
        private void _LoadData( enFilters switch_on )
        {


            DataView dv = new DataView( dt );



            switch ( switch_on )
            {
                case enFilters.Name:
                    dv.RowFilter = "FullName like '%" + txtFilerValue.Text + "%'";
                    dataGridView1.DataSource = dv;
                    break;
                case enFilters.NationalNo:
                    dv.RowFilter = "NationalNo like '%" + txtFilerValue.Text + "%'";
                    dataGridView1.DataSource = dv;
                    break;
                case enFilters.ApplicationStatus:
                    dv.RowFilter = "Status like '%" + txtFilerValue.Text + "%'";
                    dataGridView1.DataSource = dv;
                    break;
                case enFilters.None:
                    comboBox1.SelectedIndex = 3;
                    txtFilerValue.Text = "None";
                    dataGridView1.DataSource = dv;
                    break;
            }

        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void frmLocalDrivingLicenseApplications_Load( object sender, EventArgs e )
        {
            _LoadData( enFilters.None );
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
            int localAppID = int.Parse( dataGridView1.CurrentRow.Cells[ 0 ].Value.ToString() );
            string className = dataGridView1.CurrentRow.Cells[ 1 ].Value.ToString();
            string nationalNO = dataGridView1.CurrentRow.Cells[ 2 ].Value.ToString();
            this._TestType = 1;
            frmVisionTestAppointment frm = new frmVisionTestAppointment( localAppID, nationalNO, className, _TestType );
            frm.ShowDialog();
        }


        private void scheduleWritingTestToolStripMenuItem_Click( object sender, EventArgs e )
        {
            int localAppID = int.Parse( dataGridView1.CurrentRow.Cells[ 0 ].Value.ToString() );
            string className = dataGridView1.CurrentRow.Cells[ 1 ].Value.ToString();
            string nationalNO = dataGridView1.CurrentRow.Cells[ 2 ].Value.ToString();
            this._TestType = 2;
            frmVisionTestAppointment frm = new frmVisionTestAppointment( localAppID, nationalNO, className, _TestType );
            frm.ShowDialog();
        }

        private void scheduleStreetTestToolStripMenuItem_Click( object sender, EventArgs e )
        {
            int localAppID = int.Parse( dataGridView1.CurrentRow.Cells[ 0 ].Value.ToString() );
            string className = dataGridView1.CurrentRow.Cells[ 1 ].Value.ToString();
            string nationalNO = dataGridView1.CurrentRow.Cells[ 2 ].Value.ToString();
            this._TestType = 3;
            frmVisionTestAppointment frm = new frmVisionTestAppointment( localAppID, nationalNO, className, _TestType );
            frm.ShowDialog();
        }
        private void txtFilerValue_TextChanged( object sender, EventArgs e )
        {
            _LoadData( ( enFilters ) comboBox1.SelectedIndex );
        }

        private void contextMenuStrip1_Opening( object sender, CancelEventArgs e )
        {
            int passedTests = int.Parse( dataGridView1.CurrentRow.Cells[ 5 ].Value.ToString() );
            _testAppointment = clsTestAppointments.FindTestAppointmentByLocalDrivingLicenseApplicationID( int.Parse( dataGridView1.CurrentRow.Cells[ 0 ].Value.ToString() ) );
            if ( passedTests == 0 )
            {
                _testType = clsTestTypes.FindTestTypeByTestTypeID( 1 );
                ( contextMenuStrip1.Items[ 2 ] as ToolStripMenuItem ).DropDownItems[ 0 ].Enabled = true;
            }
            else if ( passedTests == 1 )
            {
                _testType = clsTestTypes.FindTestTypeByTestTypeID( 2 );
                ( contextMenuStrip1.Items[ 2 ] as ToolStripMenuItem ).DropDownItems[ 2 ].Enabled = true;
            }
            else if ( passedTests == 2 )
            {
                _testType = clsTestTypes.FindTestTypeByTestTypeID( 3 );
                ( contextMenuStrip1.Items[ 2 ] as ToolStripMenuItem ).DropDownItems[ 4 ].Enabled = true;
            }
            else
            {
                contextMenuStrip1.Items[ 2 ].Enabled = false;
            }

            if ( dataGridView1.CurrentRow.Cells[ "Status" ].Value.ToString() == "Completed" )
            {
                contextMenuStrip1.Items[ 0 ].Enabled = false;
                contextMenuStrip1.Items[ 2 ].Enabled = false;
                contextMenuStrip1.Items[ 4 ].Enabled = false;
                contextMenuStrip1.Items[ 5 ].Enabled = false;
                contextMenuStrip1.Items[ 7 ].Enabled = false;
            }
            else
            {
                contextMenuStrip1.Items[ 0 ].Enabled = true;
                contextMenuStrip1.Items[ 2 ].Enabled = true;
                contextMenuStrip1.Items[ 4 ].Enabled = true;
                contextMenuStrip1.Items[ 5 ].Enabled = true;
                contextMenuStrip1.Items[ 7 ].Enabled = true;
            }

        }

        private void shecduleTestToolStripMenuItem_MouseEnter( object sender, EventArgs e )
        {
            PassedTest = int.Parse( dataGridView1.CurrentRow.Cells[ 5 ].Value.ToString() );
            if ( PassedTest == 0 )
            {
                ( contextMenuStrip1.Items[ 2 ] as ToolStripMenuItem ).DropDownItems[ 0 ].Enabled = true;
            }
            if ( PassedTest == 1 )
            {
                ( contextMenuStrip1.Items[ 2 ] as ToolStripMenuItem ).DropDownItems[ 2 ].Enabled = true;
            }
            if ( PassedTest == 2 )
            {
                ( contextMenuStrip1.Items[ 2 ] as ToolStripMenuItem ).DropDownItems[ 4 ].Enabled = true;
            }
        }

        private void shecduleTestToolStripMenuItem_DropDownClosed( object sender, EventArgs e )
        {
            ( contextMenuStrip1.Items[ 2 ] as ToolStripMenuItem ).DropDownItems[ 0 ].Enabled = false;
            ( contextMenuStrip1.Items[ 2 ] as ToolStripMenuItem ).DropDownItems[ 2 ].Enabled = false;
            ( contextMenuStrip1.Items[ 2 ] as ToolStripMenuItem ).DropDownItems[ 4 ].Enabled = false;
        }

        private void toolStripMenuItem1_Click( object sender, EventArgs e )
        {
            // cancel Application
        }

        private void deleteLicenseToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if ( _license != null )
            {
                // delete
            }
        }

        private void issueLicenseToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if ( dataGridView1.CurrentRow.Cells[ "Status" ].Value.ToString() == "Cancelled" )
            {
                MessageBox.Show( "This Application Has Been Canceled Before..You have To Get Another Application" );
                return;
            }
            if ( dataGridView1.CurrentRow.Cells[ "Status" ].Value.ToString() == "Completed" )
            {
                MessageBox.Show( "You Already An Active License For This Class" );
                return;
            }
            if ( int.Parse( dataGridView1.CurrentRow.Cells[ 5 ].Value.ToString() ) < 3 )
            {
                MessageBox.Show( "There are Some exams That You Have To Pass No License Issued Yet.." );
                return;
            }

            _person = clsPeople.FindPersonByNationalID( dataGridView1.CurrentRow.Cells[ 2 ].Value.ToString() );
            _clsLocalDrivingLicenseApplication = clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationByID( int.Parse( dataGridView1.CurrentRow.Cells[ 0 ].Value.ToString() ) );
            _driver = clsDrivers.FindDriverByPersonID( _person.ID );
            application = clsApplications.FindApplicationByPersonID( _person.ID );
            _licenseClass = clsLicensesClasses.FindClassByName( dataGridView1.CurrentRow.Cells[ 1 ].Value.ToString() );
            if ( _driver != null )
            {
                _license = clsLicenses.FindLicenseByDriverID( _driver.DriverID );
                if ( _license != null && clsLicenses.isLicenseExists( _driver.DriverID, application.applicationID, _licenseClass.LicenseClassID ) )
                {
                    MessageBox.Show( "There is Already License For this Driver" );
                    return;
                }
            }
            frmIssueLicense frm = new frmIssueLicense( _person.nationalID, _clsLocalDrivingLicenseApplication.localDrivingLicenseApplicationID );
            frm.ShowDialog();
        }

        private void showLicenseToolStripMenuItem_Click( object sender, EventArgs e )
        {
            _clsLocalDrivingLicenseApplication = clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationByID( int.Parse( dataGridView1.CurrentRow.Cells[ 0 ].Value.ToString() ) );
            _licenseClass = clsLicensesClasses.FindClassByName( dataGridView1.CurrentRow.Cells[ 1 ].Value.ToString() );
            _person = clsPeople.FindPersonByNationalID( dataGridView1.CurrentRow.Cells[ 2 ].Value.ToString() );
            _driver = clsDrivers.FindDriverByPersonID( _person.ID );
            if ( _driver != null )
            {
                _license = clsLicenses.FindLicenseByDriverID( _driver.DriverID );

            }
            if ( _license == null )
            {
                MessageBox.Show( "There are Some exams That You Have To Pass No License Issued Yet.." );
                return;
            }

            frmLicenseInfo frm = new frmLicenseInfo( _license );
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click( object sender, EventArgs e )
        {
            _person = clsPeople.FindPersonByNationalID( dataGridView1.CurrentRow.Cells[ 2 ].Value.ToString() );
            frmShowLicenseHistory frm = new frmShowLicenseHistory( _person.ID );
            frm.ShowDialog();
        }
    }
}
