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
    public partial class frmAddEditNewLocalDrivingLicenseApplication : Form
    {
        enum enMode
        {
            ADDNEW = 0,
            UPDATE = 1
        }
        int localDrivingLicenseApplicationID = -1;
        clsLocalDrivingLicenseApplications_View localDrivingLicenseApplication;
        enMode Mode = enMode.UPDATE;
        public frmAddEditNewLocalDrivingLicenseApplication( int applicationID )
        {
            this.localDrivingLicenseApplicationID = applicationID;
            if ( this.localDrivingLicenseApplicationID == -1 )
            {
                Mode = enMode.ADDNEW;
            }
            InitializeComponent();
        }
    }
}
