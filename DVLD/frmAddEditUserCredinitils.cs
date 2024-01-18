using DVLD_BusinessLayer;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmAddEditUserCredinitils : Form
    {

        private int _PersonID = -1;
        private enum enMode
        {
            AddNew = 0,
            Update = 1
        }
        private enMode _Mode = enMode.AddNew;
        private clsUsers user = null;
        private ctrAddEditPersonWithFilters _BackForm;
        public frmAddEditUserCredinitils( ctrAddEditPersonWithFilters backForm, int personID )
        {
            InitializeComponent();
            this._PersonID = personID;
            this._BackForm = backForm;
            clsUsers.FindUserByPersonID( _PersonID );
            if ( this.user != null )
            {
                this._Mode = enMode.Update;
            }
        }
        private void _LoadForm()
        {
            //if ( this._Mode == enMode.AddNew )
            //{
            //    this.user = new clsUsers( this._PersonID );
            //    lblTitle.Text = "ADD NEW USER";
            //    return;
            //}
            this.user = clsUsers.FindUserByPersonID( this._PersonID );
            lblTitle.Text = "UPDATE" + " " + this.user._Name;
            txtUserName.Text = this.user._Name;
            txtPassword.Text = this.user._Password;
            if ( this.user._IsActive )
            {
                rbtnYes.Checked = true;
                rbtnNo.Checked = false;
            }
            else
            {
                rbtnNo.Checked = true;
                rbtnYes.Checked = false;
            }
        }
        private void btnClose_Click( object sender, System.EventArgs e )
        {
            this.Close();
        }

        private void frmAddEditUserCredinitils_Load( object sender, System.EventArgs e )
        {
            this._BackForm._LoadForm();
        }

        private void btnSave_Click( object sender, System.EventArgs e )
        {
            //MessageBox.Show( clsErrorsBuessnisLayer.Msg );
            this.user = new clsUsers( this._PersonID );
            this.user._PersonID = this._PersonID;
            this.user._Name = txtUserName.Text;
            this.user._Password = txtPassword.Text;
            if ( rbtnNo.Checked )
            {
                this.user._IsActive = false;
            }
            else
            {
                this.user._IsActive = true;
            }
            if ( user.Save() )
            {
                this.Close();
            }
            else
            {
                MessageBox.Show( "THER IS SOMETHING WENT WRONG" );
            }
        }
    }
}
