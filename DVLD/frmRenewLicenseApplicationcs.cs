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
    public partial class frmRenewLicenseApplicationcs : Form
    {
        private clsLicenses _NewLicense = null;
        private clsApplicationTypes appType = null;
        public frmRenewLicenseApplicationcs()
        {
            InitializeComponent();
        }
        private bool _LoadData()
        {
            //if this person has a driver license loading data and saving it to the database
            if ( ctrFindLicenseWithFilter1.license != null )
            {
                int isLicenseDateIsExpired = clsLicenses.CheckIfLicenseDateIsExpired( ctrFindLicenseWithFilter1.license.DriverID );
                int isLicenseActive = clsLicenses.CheckIfLicenseIsActive( ctrFindLicenseWithFilter1.license.DriverID );
                appType = clsApplicationTypes.FindApplicationTypeByID( clsApplicationTypes.enApplicationTypes.RenewDrivingLicenseService );
                lblAppDate.Text = DateTime.Now.ToString();
                lblIssueDate.Text = ctrFindLicenseWithFilter1.license.IssueDate.ToString();
                lblFees.Text = clsApplicationTypes.FindApplicationTypeByID( clsApplicationTypes.enApplicationTypes.NewInternationalDrivingLicenseService ).ApplicationFees.ToString();
                lblLocalLisenseID.Text = ctrFindLicenseWithFilter1.license.LicenseID.ToString();
                lblExcpiretyDate.Text = ctrFindLicenseWithFilter1.license.ExpiryDate.ToString();
                lblCreatedBy.Text = clsGeneralSettings.username;
                lblRenewFees.Text = appType.ApplicationFees.ToString();
                lblTotallFees.Text = ( decimal.Parse( lblFees.Text ) + decimal.Parse( lblRenewFees.Text ) ).ToString();
                if ( isLicenseDateIsExpired != -1 )
                {
                    MessageBox.Show( "You Have An active License..with ID : " + isLicenseDateIsExpired );
                    btnRenew.Enabled = false;
                    return false;
                }
                if ( isLicenseActive != -1 )
                {
                    MessageBox.Show( "You Have An active License..with ID : " );
                    btnRenew.Enabled = false;
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnRenew_Click( object sender, EventArgs e )
        {
            if ( _LoadData() )
            {
                _NewLicense = new clsLicenses
                {
                    ApplicationID = ctrFindLicenseWithFilter1.license.ApplicationID,
                    DriverID = ctrFindLicenseWithFilter1.license.DriverID,
                    IssueDate = DateTime.Now,
                    ExpiryDate = DateTime.Now.AddYears( 1 ),
                    IsActive = true,
                    issueReason = ( byte ) clsLicenses.enIssueReason.Renew,
                    Notes = "RENEWED",
                    LicenseClassID = ctrFindLicenseWithFilter1.license.LicenseClassID,
                    CreatedByUser = clsGeneralSettings.userID
                };


                if ( _NewLicense.Save() )
                {
                    //if the license is renewed successfully
                    MessageBox.Show( " License Renewed  Successfully" );
                    lblInternationalLicense.Text = _NewLicense.LicenseID.ToString();
                    lblInternationalLicenseAppID.Text = _NewLicense.ApplicationID.ToString();
                }
                else
                {
                    MessageBox.Show( "Error Renewing License.." );
                }
            }
        }
        public void ctrFindLicenseWithFilter1_Data( object sender )
        {
            _LoadData();
        }

        private void frmRenewLicenseApplicationcs_Load( object sender, EventArgs e )
        {
            ctrFindLicenseWithFilter1.dataBack += ctrFindLicenseWithFilter1_Data;
        }

    }
}

