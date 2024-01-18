using DVLD_BusinessLayer;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmChangePassword : Form
    {
        private int _UserID = -1;
        private clsUsers user = null;
        public frmChangePassword( int userID )
        {
            InitializeComponent();
            this._UserID = userID;
            user = clsUsers.FindUserByUserID( userID );
        }

        private void frmChangePassword_Load( object sender, System.EventArgs e )
        {
            txtCurrentPass.Text = user._Password;
        }



        private void btnCancel_Click( object sender, System.EventArgs e )
        {
            this.Close();
        }

        private void txtNewPass_Leave( object sender, System.EventArgs e )
        {
            if ( txtNewPass.Text != txtConfirmNewPass.Text )
            {
                errorProvider1.SetError( txtConfirmNewPass, "The New Passwords Doesn`t Macthes.." );
                btnSave.Enabled = false;
            }
            else if ( txtNewPass.Text == string.Empty )
            {
                errorProvider1.SetError( txtNewPass, "You Have To Enter New Password" );
                btnSave.Enabled = false;
            }
            else
            {
                errorProvider1.SetError( txtNewPass, string.Empty );
                btnSave.Enabled = true;
            }
        }
        private void txtConfirmNewPass_Leave( object sender, System.EventArgs e )
        {
            if ( txtNewPass.Text == txtCurrentPass.Text )
            {
                errorProvider1.SetError( txtNewPass, "You Can`t Use Old Password.." );
                btnSave.Enabled = false;
            }
            else
            {
                errorProvider1.SetError( txtConfirmNewPass, string.Empty );
                btnSave.Enabled = true;
            }
        }
        private void btnSave_Click( object sender, System.EventArgs e )
        {
            if ( this.user.ChangePAssword( txtNewPass.Text ) )
            {
                MessageBox.Show( "Password Updated Successfully :)" );
                this.Close();
            }
            else
            {
                MessageBox.Show( "It Lokks Something Went Wrong :( Try Again.." );
            }

        }


    }
}

