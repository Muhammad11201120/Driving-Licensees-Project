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
    public partial class frmReleaseDetainedLicense : Form
    {
        clsDetsinedLicense detainedLicense = null;
        clsDetsinedLicense releasedLicense = null;
        clsPeople person = null;
        public frmReleaseDetainedLicense( int licenseID )
        {
            InitializeComponent();
            ctrFindLicenseWithFilter1.licenseID = licenseID;

        }
        private bool _LoadData()
        {
            //if this person has a driver license loading data and saving it to the database
            if ( ctrFindLicenseWithFilter1.license != null )
            {
                //if ( ctrFindLicenseWithFilter1.license.ExpiryDate < DateTime.Now || ctrFindLicenseWithFilter1.license.IsActive == false )
                //{
                //    MessageBox.Show( "This is An Expired License OR Inactive License And Can`nt Be Detained OR Released.." );
                //    return false;
                //}
                detainedLicense = clsDetsinedLicense.FindDetainLicenseByLicenseID( ctrFindLicenseWithFilter1.license.LicenseID );
                if ( detainedLicense == null )
                {
                    MessageBox.Show( "This License Is Not Detained" );
                    return false;
                }
                lblDetainID.Text = detainedLicense.detainID.ToString();
                lblApplicationFees.Text = clsApplicationTypes.FindApplicationTypeByID( 5 ).ApplicationFees.ToString();
                lblDetainDate.Text = detainedLicense.detainDate.ToString();
                lblCreatedBy.Text = clsUsers.FindUserByUserID( detainedLicense.createdByUserID )._Name;
                lblLicenseID.Text = ctrFindLicenseWithFilter1.license.LicenseID.ToString();
                lblFinFees.Text = detainedLicense.fineFees.ToString();
                lblTottalFees.Text = ( detainedLicense.fineFees + clsApplicationTypes.FindApplicationTypeByID( 5 ).ApplicationFees ).ToString();
                return true;
            }
            else
            {
                return false;
            }

        }
        public void ctrFindLicenseWithFilter1_Data( object sender )
        {
            _LoadData();
            if ( ctrFindLicenseWithFilter1.license == null )
            {
                label5.Enabled = false;
            }
            else
            {
                label5.Enabled = true;
            }
        }
        private void frmReleaseDetainedLicense_Load( object sender, EventArgs e )
        {
            if ( ctrFindLicenseWithFilter1.license == null )
            {
                label5.Enabled = false;
            }
            ctrFindLicenseWithFilter1.dataBack += ctrFindLicenseWithFilter1_Data;

        }

        private void btnRelease_Click( object sender, EventArgs e )
        {
            if ( _LoadData() )
            {
                ctrFindLicenseWithFilter1.licenseID = detainedLicense.licenseID;
                ctrFindLicenseWithFilter1.checkFilter();
                detainedLicense.isRelaesed = true;
                detainedLicense.releasedByUserID = clsGeneralSettings.userID;
                detainedLicense.releaseDate = DateTime.Now;
                detainedLicense.releaseApplicationID = ctrFindLicenseWithFilter1.applications.applicationID;
                if ( detainedLicense.Save() )
                {  
                    MessageBox.Show( "License Is Released Successfully.." );
                    ctrFindLicenseWithFilter1.LoadForm();
                }
            }
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void label5_Click( object sender, EventArgs e )
        {
            clsLicenses license = clsLicenses.FindLicenseByLicenseID( ctrFindLicenseWithFilter1.license.LicenseID );
            frmLicenseInfo frm = new frmLicenseInfo( license );
            frm.ShowDialog();
        }

    }
}
