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
    }
}
