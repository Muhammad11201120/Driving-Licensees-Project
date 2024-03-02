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
    public partial class frmIssueLicense : Form
    {
        private string _NationalNO = string.Empty;
        private clsPeople _person = null;
        private clsDrivers _drivers = null;
        private clsApplications _appliction = null;
        private clsLicensesClasses _licenseClass = null;
        private clsLicenses _license = null;
        public frmIssueLicense( string nationalID, int localAppID )
        {
            InitializeComponent();
            this._NationalNO = nationalID;
            ctrApplicationInfo.NationalNo = _NationalNO;
            ctrApplicationInfo1._LocaAppID = localAppID;
            if ( _NationalNO != string.Empty )
            {
                _person = clsPeople.FindPersonByNationalID( _NationalNO );
            }
            _appliction = clsApplications.FindApplicationByPersonID( _person.ID );
            _licenseClass = clsLicensesClasses.FindClassByID( _appliction.applicationTypeID );
        }

        private void frmIssueLicense_Load( object sender, EventArgs e )
        {
            ctrApplicationInfo1._LoadForm();
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnIssue_Click( object sender, EventArgs e )
        {
            if ( _person == null || _appliction == null || _licenseClass == null )
            {
                MessageBox.Show( "There is Something went wrong.. Please Try Again.." );
                return;
            }
            _drivers = clsDrivers.FindDriverByPersonID( _person.ID );
            if ( _drivers != null )
            {
                _license = clsLicenses.FindLicenseByDriverID( _drivers.DriverID );
                if ( clsLicenses.isLicenseExists( _license.DriverID, _appliction.applicationID, _license.LicenseClassID ) )
                {
                    MessageBox.Show( "This Driver Already Have This License.." );
                    return;
                }
            }
            else
            {
                _drivers = new clsDrivers();
            }
            //driver

            _drivers.PersonID = _person.ID;
            _drivers.CreatedByUserID = clsGeneralSettings.userID;
            _drivers.CreatedDate = DateTime.Now;
            _drivers.Save();
            //license
            _license = new clsLicenses();
            _license.ApplicationID = _appliction.applicationID;
            _license.DriverID = _drivers.DriverID;
            _license.LicenseClassID = _licenseClass.LicenseClassID;
            _license.IssueDate = DateTime.Now;
            _license.ExpiryDate = DateTime.Now.AddYears( _licenseClass.DefaultValidationLength );
            _license.IsActive = true;
            _license.issueReason = ( byte ) clsLicenses.enIssueReason.firstTime;
            _license.Notes = richTextBox1.Text;
            _license.CreatedByUser = clsGeneralSettings.userID;
            _license.PaidFees = _licenseClass.ClassFees;
            //application
            _appliction.applicationStatus = 3;
            //if ( clsLicenses.isLicenseExists( _license.DriverID, _appliction.applicationID, _licenseClass.LicenseClassID ) )
            //{
            //    MessageBox.Show( "This Driver Already Have This License.." );
            //    return;
            //}

            if ( _license.Save() && _appliction.Save() )
            {
                MessageBox.Show( "License Created For This Driver Successfully.." );
            }
            else
            {
                MessageBox.Show( "There is Something went wrong.. Please Try Again.." );
            }
        }
    }
}
