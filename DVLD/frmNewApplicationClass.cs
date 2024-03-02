using DVLD_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmNewApplicationClass : Form
    {
        int appLicationTypeID = -1;
        int personID = -1;
        clsApplicationTypes applicationType = null;
        clsLocalDrivingLicenseApplications localDrivingLicenseApplications = null;
        clsApplications _application = null;
        clsApplications _Application = null;
        clsLicenses _license = null;
        clsDrivers _driver = null;
        public frmNewApplicationClass( int personID, int applicationTypeID )
        {
            InitializeComponent();
            this.personID = personID;
            if ( this.personID != -1 )
            {
                _application = clsApplications.FindApplicationByPersonID( personID );

            }
            this.appLicationTypeID = applicationTypeID;
            if ( applicationTypeID != -1 )
            {
                this.applicationType = clsApplicationTypes.FindApplicationTypeByID( appLicationTypeID );
            }

        }
        private void _fillLicenseClasses()
        {
            DataTable dt = clsLicensesClasses.GetAllLicenseClasses();
            if ( dt != null )
            {
                foreach ( DataRow row in dt.Rows )
                {
                    comboBox1.Items.Add( row[ "ClassName" ] );
                }
            }
        }
        private void frmNewApplicationClass_Load( object sender, System.EventArgs e )
        {
            _fillLicenseClasses();
            _Application = new clsApplications();
            comboBox1.SelectedIndex = 0;
            lblApplicationDate.Text = DateTime.Now.ToString();
            lblApplicationFees.Text = this.applicationType.ApplicationFees.ToString();
            lblCreatedBy.Text = clsGeneralSettings.username;

        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnSave_Click( object sender, EventArgs e )
        {
            this._Application.applicationPersonID = this.personID;
            this._Application.applicationTypeID = this.appLicationTypeID;
            this._Application.applicationDate = DateTime.Parse( lblApplicationDate.Text );
            this._Application.applicationStatus = 1;
            this._Application.paidFees = this.applicationType.ApplicationFees;
            this._Application.lastStatusDate = DateTime.Now;
            this._Application.createdByUserID = clsGeneralSettings.userID;
            _driver = clsDrivers.FindDriverByPersonID( _Application.applicationPersonID );
            _license = clsLicenses.FindLicenseByDriverID( _driver.DriverID );

            if ( clsLicenses.isLicenseExists( this._driver.DriverID, this._license.ApplicationID, ( comboBox1.SelectedIndex + 1 ) ) )
            {
                MessageBox.Show( "This Driver Already has a License of this Class" );
                return;
            }

            if ( this._Application.Save() )
            {
                MessageBox.Show( "Application Saved Successfully" );
                localDrivingLicenseApplications = new clsLocalDrivingLicenseApplications();
                localDrivingLicenseApplications.applicationID = this._Application.applicationID;
                localDrivingLicenseApplications.licenseClassID = clsLicensesClasses.FindClassByID( ( comboBox1.SelectedIndex + 1 ) ).LicenseClassID;
                if ( localDrivingLicenseApplications.Save() )
                {
                    MessageBox.Show( "Application Saved Successfully" );
                    lblDriverLicenseApplicationID.Text = this._Application.applicationID.ToString();
                }
                else
                {
                    MessageBox.Show( "license class went wrong" );
                }

            }
            else
            {
                MessageBox.Show( "There is Something went wrong.." );
            }
        }
    }
}
