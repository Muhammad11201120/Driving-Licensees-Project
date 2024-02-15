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
    public partial class ctrTests : UserControl
    {
        enum enMode
        {
            ADDNEW = 0,
            UPDATE = 1
        }
        public enum enTestType
        {
            VisionTest = 1,
            WrittenTest = 2,
            DrivingTest = 3
        }
        public int TestAppointmentId = -1;
        public string ClassName = string.Empty;
        public clsPeople _person = null;
        public clsLocalDrivingLicenseApplications _localDrivingLicenseApplication = null;
        public clsApplications _application = null;
        public clsTestAppointments _Appointment = null;
        public clsTests Test = null;
        public clsTestTypes.enTestTypes _TestTypeID = clsTestTypes.enTestTypes.VisionTest;
        enMode Mode = enMode.UPDATE;
        public clsTestTypes.enTestTypes TestTypeID
        {
            get
            {
                return _TestTypeID;
            }
            set
            {
                _TestTypeID = value;
                switch ( _TestTypeID )
                {
                    case clsTestTypes.enTestTypes.VisionTest:
                        lblTestType.Text = "Vision Test";
                        pictureBox1.Image = Properties.Resources.Vision_512;
                        break;
                    case clsTestTypes.enTestTypes.WrittenTest:
                        lblTestType.Text = "Written Test";
                        pictureBox1.Image = Properties.Resources.Written_Test_512;
                        break;
                    case clsTestTypes.enTestTypes.DrivingTest:
                        lblTestType.Text = "Driving Test";
                        pictureBox1.Image = Properties.Resources.driving_test_512;
                        break;
                }
            }
        }
        public ctrTests()
        {
            InitializeComponent();
        }
        public void LoadForm()
        {
            if ( Mode == enMode.ADDNEW )
            {
                _Appointment = new clsTestAppointments();
                return;
            }
            this._Appointment = clsTestAppointments.FindTestAppointmentByTestAppointmentID( this.TestAppointmentId );
            lblLocalApplicationID.Text = _localDrivingLicenseApplication.localDrivingLicenseApplicationID.ToString();
            lblDrivingLicenseClass.Text = ClassName;
            lblName.Text = _person.firstName + " " + _person.lastName;
            lblFees.Text = clsTestTypes.FindTestTypeByTestTypeID( ( int ) TestTypeID ).testFees.ToString();

            if ( _Appointment != null )
            {
                lblDateValue.Text = _Appointment.testAppointmentDate.ToString();
                lblTrials.Text = _Appointment.TestAppointmentByIdCount( _Appointment.testAppointmentID ).ToString();
            }
        }
    }
}
