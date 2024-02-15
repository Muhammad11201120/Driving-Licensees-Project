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
    public partial class frmVisionTest : Form
    {
        enum enMode
        {
            ADDNEW = 0,
            UPDATE = 1
        }
        enum enTestType
        {
            VisionTest = 1,
            WrittenTest = 2,
            DrivingTest = 3
        }
        public int TestAppointmentId { get; set; }
        public string ClassName { get; set; }
        private clsPeople _person = null;
        private clsLocalDrivingLicenseApplications _localDrivingLicenseApplication = null;
        private clsApplications _application = null;
        private clsTestAppointments _Appointment = null;
        private clsTestTypes _TestType = null;
        private clsTests _test = null;
        enMode Mode = enMode.UPDATE;
        enTestType TestType = enTestType.VisionTest;
        public frmVisionTest( int testAppontmentID, clsPeople person, clsLocalDrivingLicenseApplications localApplication, clsApplications application, string className )
        {
            InitializeComponent();
            this.TestAppointmentId = testAppontmentID;
            if ( this.TestAppointmentId == -1 )
            {
                Mode = enMode.ADDNEW;
            }
            this._person = person;
            this._localDrivingLicenseApplication = localApplication;
            this._application = application;
            this.ClassName = className;
            this._TestType = clsTestTypes.FindTestTypeByTestTypeID( ( int ) TestType );
        }
        private void _LoadForm()
        {
            if ( Mode == enMode.ADDNEW )
            {
                _Appointment = new clsTestAppointments();
                return;
            }
            this._Appointment = clsTestAppointments.FindTestAppointmentByTestAppointmentID( this.TestAppointmentId );
            this._test = clsTests.FindTestByTestAppointmentID( _Appointment.testAppointmentID );
            if ( _Appointment != null && _test != null )
            {
                if ( _Appointment.isLocked && _test.testResult == false )
                {
                    lblSubject.Visible = true;
                    groupBox1.Enabled = true;
                    dtpAppointmentDate.Enabled = false;
                    lblRetakeTestFees.Text = _TestType.testFees.ToString();
                    lblTotallFees.Text = ( _TestType.testFees * 2 ).ToString();
                    lblRetakeTestID.Text = _application.applicationID.ToString();
                }
            }

            lblLicenseID.Text = _localDrivingLicenseApplication.localDrivingLicenseApplicationID.ToString();
            lblLicenseClass.Text = ClassName;
            lblName.Text = _person.firstName + " " + _person.lastName;
            lblFeesValue.Text = _TestType.testFees.ToString();

            if ( _Appointment != null )
            {
                dtpAppointmentDate.Value = _Appointment.testAppointmentDate;
                lblTrial.Text = _Appointment.TestAppointmentByIdCount( _Appointment.testAppointmentID ).ToString();
            }
        }

        private void frmVisionTest_Load( object sender, EventArgs e )
        {
            _LoadForm();
        }

        private void btnSave_Click( object sender, EventArgs e )
        {
            if ( this._test != null )
            {
                if ( _Appointment.isLocked && _test.testResult == false )
                {
                    _Appointment.RetakeTestApplicationID = int.Parse( lblRetakeTestID.Text );
                    MessageBox.Show( "You Applied Successfully For Retake Test.." );
                    return;
                }
            }
            _Appointment.testAppointmentDate = ( DateTime ) dtpAppointmentDate.Value;
            _Appointment.testTypeID = _TestType.testTypeID;
            _Appointment.LocalDrivingLicenseApplicationID = _localDrivingLicenseApplication.localDrivingLicenseApplicationID;
            _Appointment.paidFees = _TestType.testFees;
            _Appointment.createdByUserID = clsGeneralSettings.userID;
            _Appointment.isLocked = false;
            if ( groupBox1.Enabled )
            {
                _Appointment.RetakeTestApplicationID = int.Parse( lblRetakeTestID.Text );
            }
            if ( _Appointment.Save() )
            {
                MessageBox.Show( "Appointment Saved Successfully" );
            }
            else
            {
                MessageBox.Show( "There is something went wrong" );
            }
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
