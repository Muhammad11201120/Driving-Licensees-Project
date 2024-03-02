using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD
{
    public partial class frmNewInternationalLicenseApplication : Form
    {
        private clsInternationalLicense internationalLicense = null;
        public frmNewInternationalLicenseApplication()
        {
            InitializeComponent();
        }
        private bool _LoadData()
        {
            //if this person has a driver license loading data and saving it to the database
            if ( ctrFindLicenseWithFilter1.license != null )
            {

                lblAppDate.Text = DateTime.Now.ToString();
                lblIssueDate.Text = ctrFindLicenseWithFilter1.license.IssueDate.ToString();
                lblFees.Text = clsApplicationTypes.FindApplicationTypeByID( clsApplicationTypes.enApplicationTypes.NewInternationalDrivingLicenseService ).ApplicationFees.ToString();
                lblLocalLisenseID.Text = ctrFindLicenseWithFilter1.license.LicenseID.ToString();
                lblExcpiretyDate.Text = ctrFindLicenseWithFilter1.license.ExpiryDate.ToString();
                lblCreatedBy.Text = clsGeneralSettings.username;
                if ( ctrFindLicenseWithFilter1.license.IsActive == false )
                {
                    MessageBox.Show( "You Have An Inactive License.." );
                    btnIssue.Enabled = false;
                    return false;
                }
                else if ( ctrFindLicenseWithFilter1.license.ExpiryDate < DateTime.Now )
                {
                    MessageBox.Show( "You Have A expire License.." );
                    btnIssue.Enabled = false;
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

        private void btnIssue_Click( object sender, EventArgs e )
        {
            if ( _LoadData() )
            {
                internationalLicense = clsInternationalLicense.FindInternationalLicenseByLocalLicenseID( ctrFindLicenseWithFilter1.license.LicenseID );
                if ( internationalLicense != null )
                {
                    if ( clsInternationalLicense.FindInternationalLicenseByDriverID( internationalLicense.DriverID ) != null )
                    {
                        MessageBox.Show( "This Driver Is Already Has An International License.." );
                        return;
                    }
                    MessageBox.Show( "There is Already International License For This Driver" );
                    return;
                }

                internationalLicense = new clsInternationalLicense
                {
                    ApplicationID = ctrFindLicenseWithFilter1.applications.applicationID,
                    DriverID = ctrFindLicenseWithFilter1.license.DriverID,
                    IssuedUsingLocalLicenseID = ctrFindLicenseWithFilter1.license.LicenseID,
                    IssueDate = DateTime.Now,
                    ExpiryDate = ctrFindLicenseWithFilter1.license.ExpiryDate,
                    IsActive = true,
                    CreatedByUserID = clsGeneralSettings.userID
                };
                if ( internationalLicense.Save() )
                {
                    MessageBox.Show( "International License Issued Successfully" );
                    lblInternationalLicense.Text = internationalLicense.InternationalLicenseID.ToString();
                    lblInternationalLicenseAppID.Text = internationalLicense.ApplicationID.ToString();
                }
                else
                {
                    MessageBox.Show( "Error in Issuing International License.." );
                    lblInternationalLicense.Text = internationalLicense.InternationalLicenseID.ToString();
                }
            }
        }

        private void frmNewInternationalLicenseApplication_Load( object sender, EventArgs e )
        {
            ctrFindLicenseWithFilter1.dataBack += ctrFindLicenseWithFilter1_Data;
            _LoadData();
        }
        public void ctrFindLicenseWithFilter1_Data( object sender )
        {
            _LoadData();
        }
    }
}
