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
                detainedLicense = clsDetsinedLicense.FindDetainLicenseByLicenseID( ctrFindLicenseWithFilter1.license.LicenseID );
                if ( detainedLicense == null )
                {
                    MessageBox.Show( "This License Is Not Detained" );
                    return false;
                }

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
        }
        private void frmReleaseDetainedLicense_Load( object sender, EventArgs e )
        {
            ctrFindLicenseWithFilter1.dataBack += ctrFindLicenseWithFilter1_Data;
        }

        private void btnRelease_Click( object sender, EventArgs e )
        {
            if ( _LoadData() )
            {
                releasedLicense = new clsDetsinedLicense();
            }
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
