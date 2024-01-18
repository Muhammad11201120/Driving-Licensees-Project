using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmAddEditPerson : Form
    {
        public delegate void ctrShowPersonDetailsEventHandler( object sender, int personID );
        public event ctrShowPersonDetailsEventHandler dataBack;
        public enum _enMode
        {
            AddMode = 0,
            UpdateMode = 1
        }
        private int _personID = -1;
        public frmAddEditPerson( int personID )
        {

            InitializeComponent();
            this._personID = personID;
            ctrShowPersonDetails1.PersonID = this._personID;
            if ( this._personID == -1 )
            {
                ctrShowPersonDetails1._Mode = ctrShowPersonDetails._enMode.AddMode;
            }
            else
            {
                ctrShowPersonDetails1._Mode = ctrShowPersonDetails._enMode.UpdateMode;
            }
        }
        private void frmAddEditPerson_Load( object sender, EventArgs e )
        {
            ctrShowPersonDetails1._LoadForm();
        }
        private void button1_Click( object sender, System.EventArgs e )
        {
            this.Close();
        }

        private void btnSave_Click( object sender, EventArgs e )
        {
            ctrShowPersonDetails1.Save();
        }
    }
}
