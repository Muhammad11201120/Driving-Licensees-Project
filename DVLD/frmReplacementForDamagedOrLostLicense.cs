using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmReplacementForDamagedOrLostLicense : Form
    {
        clsLicenses _NewLicense = null;
        clsApplicationTypes appType = clsApplicationTypes.FindApplicationTypeByID( clsApplicationTypes.enApplicationTypes.ReplacementForDamagedDrivingLicenseService );
        public frmReplacementForDamagedOrLostLicense()
        {
            InitializeComponent();
        }
        private bool _LoadData()
        {
            //if this person has a driver license loading data and saving it to the database
            if ( ctrFindLicenseWithFilter1.license != null )
            {
                if ( rdmtnLost.Checked )
                {
                    appType = clsApplicationTypes.FindApplicationTypeByID( clsApplicationTypes.enApplicationTypes.ReplacementForLostDrivingLicenseService );
                }
                lblAppDate.Text = DateTime.Now.ToString();
                lblIssueDate.Text = ctrFindLicenseWithFilter1.license.IssueDate.ToString();
                lblFees.Text = clsApplicationTypes.FindApplicationTypeByID( clsApplicationTypes.enApplicationTypes.NewInternationalDrivingLicenseService ).ApplicationFees.ToString();
                lblLocalLisenseID.Text = ctrFindLicenseWithFilter1.license.LicenseID.ToString();
                lblExcpiretyDate.Text = ctrFindLicenseWithFilter1.license.ExpiryDate.ToString();
                lblCreatedBy.Text = clsGeneralSettings.username;
                lblRenewFees.Text = appType.ApplicationFees.ToString();
                lblTotallFees.Text = ( decimal.Parse( lblFees.Text ) + decimal.Parse( lblRenewFees.Text ) ).ToString();
                if ( ctrFindLicenseWithFilter1.license.ExpiryDate < DateTime.Now )
                {
                    MessageBox.Show( "Your License Is Already Expired.." );
                    btnReplace.Enabled = false;
                    return false;
                }
                if ( !ctrFindLicenseWithFilter1.license.IsActive )
                {
                    MessageBox.Show( "You Have An Inactive License.." );
                    btnReplace.Enabled = false;
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnReplace_Click( object sender, EventArgs e )
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
                    issueReason = ( byte ) clsLicenses.enIssueReason.Replace,
                    Notes = appType.ApplicationTypeID == ( int ) clsApplicationTypes.enApplicationTypes.ReplacementForDamagedDrivingLicenseService ? "Replace For Damage" : "Replace For Lost",
                    LicenseClassID = ctrFindLicenseWithFilter1.license.LicenseClassID,
                    CreatedByUser = clsGeneralSettings.userID
                };


                if ( _NewLicense.Save() )
                {
                    //if the license is renewed successfully
                    ctrFindLicenseWithFilter1.license.IsActive = false;
                    ctrFindLicenseWithFilter1.license.Save();
                    MessageBox.Show( " License Replaced  Successfully" );
                    lblInternationalLicense.Text = _NewLicense.LicenseID.ToString();
                    lblInternationalLicenseAppID.Text = _NewLicense.ApplicationID.ToString();
                }
                else
                {
                    MessageBox.Show( "Error Replacing License.." );
                }
            }
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }
        public void ctrFindLicenseWithFilter1_Data( object sender )
        {
            _LoadData();
        }
        private void frmReplacementForDamagedOrLostLicense_Load( object sender, EventArgs e )
        {
            ctrFindLicenseWithFilter1.dataBack += ctrFindLicenseWithFilter1_Data;
        }
    }
}
