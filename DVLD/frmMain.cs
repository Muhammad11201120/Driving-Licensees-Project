using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmMain : Form
    {
        frmLogin frmLoginBack = null;
        public frmMain( frmLogin frm )
        {
            this.frmLoginBack = frm;
            InitializeComponent();
        }

        private void pEOPLEToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmAllPeople frmShowAllPeople = new frmAllPeople();
            frmShowAllPeople.ShowDialog();
        }



        private void toolStripMenuItem1_Click( object sender, EventArgs e )
        {
            frmUsers frmUsers = new frmUsers();
            frmUsers.ShowDialog();
        }

        private void mstrpAccountInfos_Click( object sender, EventArgs e )
        {
            frmAddNewUser form = new frmAddNewUser( clsUsers.FindUserByUserID( clsGeneralSettings.userID )._PersonID );
            form.ShowDialog();
        }

        private void mstrpChangePassword_Click( object sender, EventArgs e )
        {
            frmChangePassword form = new frmChangePassword( clsGeneralSettings.userID );
            form.ShowDialog();
        }
        private void btnClose_Click( object sender, EventArgs e )
        {
            frmLoginBack.Visible = true;
            this.Close();
        }

        private void lOGOUTToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmLoginBack.Visible = true;
            this.Close();
        }

        private void mANAGEAPPLICATIONTYPESToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmManageApplicationTypes form = new frmManageApplicationTypes();
            form.ShowDialog();
        }
        private void localLicenseToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmNewLicenseApplication formNewApp = new frmNewLicenseApplication( -1 );
            formNewApp.ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem1_Click( object sender, EventArgs e )
        {
            frmLocalDrivingLicenseApplications frm = new frmLocalDrivingLicenseApplications();
            frm.ShowDialog();
        }

        private void frmMain_Load( object sender, EventArgs e )
        {
            lblUserName.Text = clsGeneralSettings.username;
            lbNationalNumber.Text = clsGeneralSettings.nationalNumber;
            pictureBox1.ImageLocation = clsGeneralSettings.userImg;
        }

        private void dRIVERSToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmDrivers frm = new frmDrivers();
            frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmNewInternationalLicenseApplication frm = new frmNewInternationalLicenseApplication();
            frm.ShowDialog();
        }

        private void internationalDrivingLicenseApplicationsToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmManageInternationalLicenses frm = new frmManageInternationalLicenses();
            frm.ShowDialog();
        }

        private void rENEWDRIVINGLICENSEToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmRenewLicenseApplicationcs frm = new frmRenewLicenseApplicationcs();
            frm.ShowDialog();
        }

        private void toolStripMenuItem4_Click( object sender, EventArgs e )
        {
            frmReplacementForDamagedOrLostLicense frm = new frmReplacementForDamagedOrLostLicense();
            frm.ShowDialog();
        }

        private void rETAKETESTToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmLocalDrivingLicenseApplications frm = new frmLocalDrivingLicenseApplications();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmDetainLicense frm = new frmDetainLicense( -1 );
            frm.ShowDialog();
        }

        private void manageDetainLToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmManageDetainedLicenses frm = new frmManageDetainedLicenses();
            frm.ShowDialog();
        }

        private void relaeaseDetainLicenseToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense( -1 );
            frm.ShowDialog();
        }
    }
}
