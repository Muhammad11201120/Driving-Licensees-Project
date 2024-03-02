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
using static DVLD.ctrTests;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD
{
    public partial class frmIssueTest : Form
    {
        enum enMode
        {
            ADDNEW = 0,
            UPDATE = 1,
        }
        private clsTests _Test = null;
        private clsTestAppointments _TestAppointment = null;
        private clsTestTypes _TestTypes = null;
        private clsApplications _Application = null;
        enMode Mode = enMode.UPDATE;
        public frmIssueTest( int testAppontmentID, clsPeople person, clsLocalDrivingLicenseApplications localApplication, clsTestTypes testType, clsApplications application, string className )
        {
            InitializeComponent();
            ctrTests1.TestAppointmentId = testAppontmentID;
            if ( ctrTests1.TestAppointmentId == -1 )
            {
                Mode = enMode.ADDNEW;
            }
            ctrTests1._person = person;
            ctrTests1.TestAppointmentId = testAppontmentID;
            this._TestAppointment = clsTestAppointments.FindTestAppointmentByTestAppointmentID( testAppontmentID );
            _Test = clsTests.FindTestByTestAppointmentID( _TestAppointment.testAppointmentID );
            ctrTests1._localDrivingLicenseApplication = localApplication;
            ctrTests1._application = application;
            ctrTests1.ClassName = className;
            ctrTests1._TestTypeID = ( clsTestTypes.enTestTypes ) testType.testTypeID;
            this._TestTypes = testType;
            this._Application = application;
        }

        private void frmIssueTest_Load( object sender, EventArgs e )
        {
            ctrTests1.LoadForm();
        }

        private void btnSave_Click( object sender, EventArgs e )
        {

            if ( _Test != null && _Test.testResult == true && _TestAppointment.isLocked == false )
            {
                MessageBox.Show( "You Already Passed The Test.." );
                return;
            }
            _Test = new clsTests();
            _Test.testAppointmentID = ctrTests1.TestAppointmentId;
            if ( rdbtnPass.Checked )
            {
                _Test.testResult = true;
            }
            else
            {
                _Test.testResult = false;
            }
            _Test.notes = richTextBox1.Text;
            _Test.createdByUserID = clsGeneralSettings.userID;
            this._TestAppointment.isLocked = true;
            if ( _Test.Save() && this._TestAppointment.Save() && _Application.Save() )
            {
                MessageBox.Show( "Test Saved Successfully.." );
                this.Close();
            }
            else
            {
                MessageBox.Show( "Error Saving Test.." );
            }
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
