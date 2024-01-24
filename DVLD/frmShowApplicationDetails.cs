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
    public partial class frmShowApplicationDetails : Form
    {
        private int _ApplicationID = -1;
        private clsApplicationTypes _ApplicationType = null;
        private clsPeople _Person = null;
        private clsApplications _Application = null;
        private clsLocalDrivingLicenseApplications _LicenseDrivingApplication = null;
        public frmShowApplicationDetails( int applicationID )
        {
            InitializeComponent();
            this._ApplicationID = applicationID;
            if ( this._ApplicationID != -1 )
            {
                _Application = clsApplications.FindApplicationByID( applicationID );
                _ApplicationType = clsApplicationTypes.FindApplicationTypeByID( _Application.applicationTypeID );
                _Person = clsPeople.FindPersonByID( _Application.applicationPersonID );
                _LicenseDrivingApplication = clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationByApplicationID( _ApplicationID );
            }
        }
    }
}
