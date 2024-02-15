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
    public partial class ctrApplicationInfo : UserControl
    {
        public static string NationalNo = string.Empty;
        private clsPeople _Person = null;
        private clsApplications _Application = null;
        private clsLocalDrivingLicenseApplications _LicenseDrivingApplication = null;
        private clsLicensesClasses _LicenseClass = null;
        private clsApplicationTypes _ApplicationType = null;
        private clsUsers user = null;
        public ctrApplicationInfo()
        {
            InitializeComponent();
        }

        public void _LoadForm()
        {
            _Person = clsPeople.FindPersonByNationalID( NationalNo );
            _Application = clsApplications.FindApplicationByPersonID( _Person.ID );
            _LicenseDrivingApplication = clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationByApplicationID( _Application.applicationID );
            _LicenseClass = clsLicensesClasses.FindClassByID( _LicenseDrivingApplication.licenseClassID );
            _ApplicationType = clsApplicationTypes.FindApplicationTypeByID( _Application.applicationTypeID );
            user = clsUsers.FindUserByUserID( _Application.createdByUserID );
            lblDrivingLicenseApplicationID.Text = _LicenseDrivingApplication.localDrivingLicenseApplicationID.ToString();
            lblIdValue.Text = _Application.applicationID.ToString();
            lblAppliedFor.Text = _LicenseClass.ClassName;
            lblApplicant.Text = _Person.firstName + " " + _Person.lastName;
            lblDate.Text = _Application.applicationDate.ToString();
            lblStatusDate.Text = _Application.lastStatusDate.ToString();
            if ( _Application.applicationStatus == 1 )
            {
                lblStatus.Text = "NEW";
            }
            else if ( _Application.applicationStatus == 2 )
            {
                lblStatus.Text = "CANCELED";
            }
            else if ( _Application.applicationStatus == 3 )
            {
                lblStatus.Text = "COMPLETED";
            }
            else
            {
                lblStatus.Text = "UNKNOWN";
            }
            lblFees.Text = _LicenseClass.ClassFees.ToString();
            lblType.Text = _ApplicationType.ApplicationTypeTitle;
            if ( _ApplicationType.ApplicationTypeID == 1 )
            {
                lblPassedTests.Text = "0/3";
                lblPassedTests.ForeColor = Color.Red;
            }
            else if ( _ApplicationType.ApplicationTypeID == 2 )
            {
                lblPassedTests.Text = "1/3";
                lblPassedTests.ForeColor = Color.Red;
            }
            else if ( _ApplicationType.ApplicationTypeID == 3 )
            {
                lblPassedTests.Text = "2/3";
                lblPassedTests.ForeColor = Color.Red;
            }
            else
            {
                lblPassedTests.Text = "3/3";
                lblPassedTests.ForeColor = Color.Green;
            }
            lblCreatedBy.Text = user._Name;

        }

        //private void ctrApplicationInfo_Load( object sender, EventArgs e )
        //{
        //    _LoadForm();
        //}
    }
}
