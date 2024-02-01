using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmShowApplicationDetails : Form
    {
        private string _nationalNo = string.Empty;
        private clsApplicationTypes _ApplicationType = null;
        private clsPeople _Person = null;
        private clsApplications _Application = null;
        private clsLocalDrivingLicenseApplications _LicenseDrivingApplication = null;
        private clsLicensesClasses _LicenseClass = null;
        public frmShowApplicationDetails( string nationalNO )
        {
            InitializeComponent();
            this._nationalNo = nationalNO;
            if ( this._nationalNo != string.Empty )
            {
                _Person = clsPeople.FindPersonByNationalID( _nationalNo );
                _Application = clsApplications.FindApplicationByPersonID( _Person.ID );
                _ApplicationType = clsApplicationTypes.FindApplicationTypeByID( _Application.applicationTypeID );
                _LicenseDrivingApplication = clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationByApplicationID( _Application.applicationID );
                _LicenseClass = clsLicensesClasses.FindClassByID( _LicenseDrivingApplication.licenseClassID );
            }
        }
        private void _LoadForm()
        {
            //Person Labels
            lblNationalNumberValue.Text = _Person.nationalID.ToString();
            lblName.Text = _Person.firstName + " " + _Person.secondName + " " + _Person.lastName;
            lblDateOfBirth.Text = _Person.dateOfBirth.ToString();
            lblPhone.Text = _Person.phone.ToString();
            lblEmail.Text = _Person.email;
            if ( _Person.gendor == 1 )
            {
                lblGendor.Text = "Female";
            }
            else
            {
                lblGendor.Text = "Male";
            }
            if ( _Person.imagePath != null )
            {
                pboxPersonImage.ImageLocation = _Person.imagePath;
            }
            //Application Labels
            lblApplicationClassName.Text = _LicenseClass.ClassName;
            lblApplicationIDValue.Text = _Application.applicationID.ToString();
            lblApplicationTypeValue.Text = _ApplicationType.ApplicationTypeTitle;
            lblApplicationDate.Text = _Application.applicationDate.ToString();
            lblLicenseClasFees.Text = _LicenseClass.ClassFees.ToString() + " $";
            lblApplicationPaidFees.Text = _Application.paidFees.ToString() + " $";

        }

        private void frmShowApplicationDetails_Load( object sender, EventArgs e )
        {
            _LoadForm();
        }
    }
}
