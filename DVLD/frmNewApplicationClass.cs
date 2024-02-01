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
        clsApplications application = null;
        public frmNewApplicationClass( int personID, int applicationTypeID )
        {
            InitializeComponent();
            this.personID = personID;
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
            this.application = new clsApplications();
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
            this.application.applicationPersonID = this.personID;
            this.application.applicationTypeID = this.appLicationTypeID;
            this.application.applicationDate = DateTime.Parse( lblApplicationDate.Text );
            this.application.applicationStatus = 1;
            this.application.paidFees = this.applicationType.ApplicationFees;
            this.application.lastStatusDate = DateTime.Now;
            this.application.createdByUserID = clsGeneralSettings.userID;



            if ( this.application.Save() )
            {
                MessageBox.Show( "Application Saved Successfully" );
                localDrivingLicenseApplications = new clsLocalDrivingLicenseApplications();
                localDrivingLicenseApplications.applicationID = this.application.applicationID;
                localDrivingLicenseApplications.licenseClassID = clsLicensesClasses.FindClassByID( ( comboBox1.SelectedIndex + 1 ) ).LicenseClassID;
                if ( localDrivingLicenseApplications.Save() )
                {
                    MessageBox.Show( "Application Saved Successfully" );
                    lblDriverLicenseApplicationID.Text = this.application.applicationID.ToString();
                }
                else
                {
                    MessageBox.Show( "licencse class went wrong" );
                }

            }
            else
            {
                MessageBox.Show( "There is Something went wrong.." );
            }
        }
    }
}
