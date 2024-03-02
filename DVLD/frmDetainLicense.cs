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
    public partial class frmDetainLicense : Form
    {
        enum _enMode
        {
            ADDNEW = 0,
            UPDATE = 1
        }
        private int LicenseID = -1;
        clsDetsinedLicense detainLicense = null;
        _enMode mode = _enMode.UPDATE;
        public frmDetainLicense( int LicenseID )
        {
            InitializeComponent();
            this.LicenseID = LicenseID;
            if ( this.LicenseID != -1 )
            {
                ctrFindLicenseWithFilter1.withFilter = false;
            }
        }
        private bool _LoadData()
        {
            if ( ctrFindLicenseWithFilter1.license != null )
            {
                detainLicense = clsDetsinedLicense.FindDetainLicenseByLicenseID( ctrFindLicenseWithFilter1.license.LicenseID );
                if ( detainLicense == null )
                {
                    mode = _enMode.ADDNEW;
                }
                lblDetainDate.Text = DateTime.Now.ToString();
                lblCreatedBy.Text = clsGeneralSettings.username;
                lblLicenseID.Text = ctrFindLicenseWithFilter1.license.LicenseID.ToString();
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
        private void frmDetainLicense_Load( object sender, EventArgs e )
        {
            ctrFindLicenseWithFilter1.checkFilter();
            ctrFindLicenseWithFilter1.dataBack += ctrFindLicenseWithFilter1_Data;

        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnDetain_Click( object sender, EventArgs e )
        {
            if ( _LoadData() )
            {
                if ( mode == _enMode.ADDNEW )
                {
                    detainLicense = new clsDetsinedLicense();
                }
                detainLicense.licenseID = ctrFindLicenseWithFilter1.license.LicenseID;
                detainLicense.detainDate = DateTime.Now;
                detainLicense.fineFees = Convert.ToDecimal( txtFineFees.Text );
                detainLicense.isRelaesed = false;
                detainLicense.createdByUserID = clsGeneralSettings.userID;
                if ( detainLicense.Save() )
                {
                    MessageBox.Show( "License Detained Successfully.." );
                }
                else
                {
                    MessageBox.Show( "License Detained Failed.." );
                }
            }
        }
    }
}
