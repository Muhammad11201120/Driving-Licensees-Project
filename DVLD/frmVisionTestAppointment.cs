using DVLD.Properties;
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
    public partial class frmVisionTestAppointment : Form
    {
        public string NationalID { get; set; }
        public string ClassName { get; set; }
        private int _LocalAppID = -1;
        private clsPeople _Person = null;
        private clsLocalDrivingLicenseApplications _LocalDrivingLicenseApplication = null;
        private clsApplications _Application = null;
        private clsTestAppointments _Appointment = null;
        private clsTestTypes _TestType;
        private clsTests _Test = null;
        DataTable dt;
        private DataView _Dv;
        public frmVisionTestAppointment( int localAppID, string nationalID, string className, int testType )
        {

            this.NationalID = nationalID;
            this.ClassName = className;
            this._LocalAppID = localAppID;
            ctrApplicationInfo.NationalNo = this.NationalID;
            _Person = clsPeople.FindPersonByNationalID( this.NationalID );
            _Application = clsApplications.FindApplicationByPersonID( _Person.ID );
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationByID( _LocalAppID );
            dt = clsTestAppointments.GetAllTestAppointmentsByLocalDrivingLicenseApplicatioID( _LocalDrivingLicenseApplication.localDrivingLicenseApplicationID );
            _Appointment = clsTestAppointments.FindTestAppointmentByLocalDrivingLicenseApplicationID( _LocalDrivingLicenseApplication.localDrivingLicenseApplicationID );
            _TestType = clsTestTypes.FindTestTypeByTestTypeID( testType );
            if ( _Appointment != null )
            {
                _Test = clsTests.FindTestByTestAppointmentID( _Appointment.testAppointmentID );
            }
            InitializeComponent();
        }

        private void frmVisionTestAppointment_Load( object sender, EventArgs e )
        {
            ctrApplicationInfo1._LocaAppID = _LocalAppID;
            ctrApplicationInfo1._LoadForm();
            if ( _TestType.testTypeID == 3 )
            {
                pictureBox1.Image = Resources.driving_test_512;
                label3.Text = "DRIVING TEST APPOINTMENT";
            }
            else if ( _TestType.testTypeID == 2 )
            {
                pictureBox1.Image = Resources.Written_Test_512;
                label3.Text = "WRITTING TEST APPOINTMENT";
            }
            else
            {
                pictureBox1.Image = Resources.Vision_512;
                label3.Text = "VISION TEST APPOINTMENT";
            }
            _Dv = new DataView( dt );
            dgvAppoinments.DataSource = _Dv;
            lblRecords.Text = _Dv.Count.ToString();

        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnAddNewAppointment_Click( object sender, EventArgs e )
        {
            int AppointmentID = -1;
            if ( dt != null )
            {
                foreach ( DataRow row in dt.Rows )
                {
                    if ( !( bool ) row[ "IsLocked" ] )
                    {
                        MessageBox.Show( "You Already Have An Open Appointment..in : " + row[ "AppointmentDate" ] );
                        return;
                    }

                }
            }
            if ( _Test != null )
            {
                if ( _Appointment.testTypeID == 3 && _Test.testResult )
                {
                    AppointmentID = _Appointment.testAppointmentID;
                    MessageBox.Show( "You Already Passed This Test.." );
                    return;
                }
            }


            frmVisionTest frm = new frmVisionTest( AppointmentID, _Person, _LocalDrivingLicenseApplication, _Application, ClassName );
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click( object sender, EventArgs e )
        {

            if ( _Test != null )
            {
                if ( _Appointment != null && _Test.testResult )
                {
                    MessageBox.Show( "You Already Passed This Test.." );
                    return;
                }
            }

            frmVisionTest frm = new frmVisionTest( _Appointment.testAppointmentID, _Person, _LocalDrivingLicenseApplication, _Application, ClassName );
            frm.ShowDialog();
        }

        private void issueLicenseToolStripMenuItem_Click( object sender, EventArgs e )
        {
            _Test = clsTests.FindTestByTestAppointmentID( int.Parse( dgvAppoinments.CurrentRow.Cells[ "TestAppointmentID" ].Value.ToString() ) );
            if ( _Test != null && _Test.testResult == true && _Appointment.isLocked )
            {
                MessageBox.Show( "You Already Passed The Test ", MessageBoxIcon.Error.ToString() );
                return;
            }
            //if ( _Test != null )
            //{
            //    if ( _Appointment.isLocked && _Test.testResult == true )
            //    {
            //        MessageBox.Show( "You Already Passed The Test ", MessageBoxIcon.Error.ToString() );
            //        return;
            //    }
            //}

            int testAppointmentID = int.Parse( dgvAppoinments.CurrentRow.Cells[ "TestAppointmentID" ].Value.ToString() );
            frmIssueTest frm = new frmIssueTest( testAppointmentID, _Person, _LocalDrivingLicenseApplication, _TestType, _Application, ClassName );
            frm.ShowDialog();
            _Dv = new DataView( dt );
            dgvAppoinments.DataSource = _Dv;
            lblRecords.Text = _Dv.Count.ToString();
        }
    }
}
