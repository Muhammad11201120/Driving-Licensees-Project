using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmEditApplicationTypes : Form
    {
        private int _ApplicationID = -1;
        clsApplicationTypes app;
        public frmEditApplicationTypes( int applicationID )
        {
            InitializeComponent();
            this._ApplicationID = applicationID;
            if ( _ApplicationID != -1 )
            {
                app = clsApplicationTypes.FindApplicationTypeByID( _ApplicationID );
            }
        }

        private void frmEditApplicationTypes_Load( object sender, EventArgs e )
        {
            txtApplicationID.Text = _ApplicationID.ToString();
            txtApplicationTitle.Text = app.ApplicationTypeTitle;
            txtApplicationFees.Text = app.ApplicationFees.ToString();
        }

        private void btnSave_Click( object sender, EventArgs e )
        {
            app.ApplicationTypeID = _ApplicationID;
            app.ApplicationTypeTitle = txtApplicationTitle.Text;
            app.ApplicationFees = decimal.Parse( txtApplicationFees.Text );
            if ( app.UpdateApplicationType( this._ApplicationID ) )
            {
                MessageBox.Show( "Application Infos Updated Successfully" );
            }
            else
            {
                MessageBox.Show( "No Changes Have Been Made" );
            }
            this.Close();
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
