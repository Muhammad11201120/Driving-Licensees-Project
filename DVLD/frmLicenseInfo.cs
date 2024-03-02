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
    public partial class frmLicenseInfo : Form
    {

        public frmLicenseInfo( clsLicenses license )
        {
            InitializeComponent();
            ctrFindLicenseWithFilter1.licenseID = license.LicenseID;
        }


        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void frmLicenseInfo_Load( object sender, EventArgs e )
        {
            ctrFindLicenseWithFilter1.LoadForm();
        }
    }
}
