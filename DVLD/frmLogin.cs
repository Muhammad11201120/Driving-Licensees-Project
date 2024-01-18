using DVLD_BusinessLayer;
using System;
using System.IO;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLogin : Form
    {
        private string _UserCredentialsFile = "D:\\DVLD-User-Credintials\\user-credinitials.txt";
        private struct StCredentials
        {
            public int userID;
            public string userName;
            public string password;
            public bool isActive;
        }
        private StCredentials _Credentials;
        clsUsers user;
        public frmLogin()
        {
            InitializeComponent();
        }
        private bool _LoginSucceed()
        {
            bool success = false;
            _Credentials.userName = txtUserName.Text;
            _Credentials.password = txtPassword.Text;

            clsGeneralSettings.username = _Credentials.userName;
            clsGeneralSettings.password = _Credentials.password;

            user = clsUsers.FindUserByUserName( _Credentials.userName );
            if ( user != null && user._Name == _Credentials.userName && user._Password == _Credentials.password )
            {
                _Credentials.userID = this.user._UserID;
                clsGeneralSettings.userID = this.user._UserID;
                success = true;
            }

            return success;
        }
        private void _LoadCredentials()
        {
            if ( System.IO.File.Exists( _UserCredentialsFile ) )
            {
                string[] content = File.ReadAllLines( _UserCredentialsFile );
                if ( content.Length != 0 )
                {
                    txtUserName.Text = content[ 0 ];
                    txtPassword.Text = content[ 1 ];
                    if ( content[ 2 ] == "true" )
                    {
                        rdbtnNo.Visible = false;
                        rdbtnYes.Checked = true;
                        _Credentials.isActive = true;
                    }
                    else
                    {
                        rdbtnYes.Visible = false;
                        rdbtnNo.Checked = true;
                        _Credentials.isActive = false;
                    }
                }
            }
            else
            {
                _Credentials.userName = string.Empty;
                _Credentials.password = string.Empty;
                txtUserName.Text = "ENTER USER NAME";
                txtPassword.Text = "ENTER PASSOWARD";
                txtUserName.Focus();
            }

        }

        private void frmLogin_Load( object sender, EventArgs e )
        {
            _LoadCredentials();
        }
        private void lblNewRigester_Click( object sender, EventArgs e )
        {
            frmAddNewUser frmAddNewUser = new frmAddNewUser( -1 );
            frmAddNewUser.ShowDialog();
        }

        private void btnLogin_Click( object sender, EventArgs e )
        {
            if ( _LoginSucceed() )
            {
                frmMain frmMain = new frmMain( this );
                this.Visible = false;
                frmMain.ShowDialog();
            }
            else
            {
                MessageBox.Show( "CONTACT ADMINISTRATOR.." );
                _LoadCredentials();
            }
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void lblClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
