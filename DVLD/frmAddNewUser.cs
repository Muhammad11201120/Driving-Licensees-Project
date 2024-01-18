using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmAddNewUser : Form
    {
        enum enFilter
        {
            Email = 0,
            Phone = 1,
            PersonID = 2,
            nationalNO = 3,
            userID = 4,
            userName = 5
        }
        struct stDefaultImage
        {
            public string male;
            public string female;
        }
        private enum _enMode
        {
            AddMode = 0,
            UpdateMode = 1
        }
        private enum _enGendor
        {
            Male = 0,
            Female = 1
        }
        private int _PersonID = -1;
        private int _UserID = -1;
        private clsPeople _Person;
        private clsUsers _user;
        private _enMode _Mode;
        stDefaultImage _image;
        public frmAddNewUser( int personID )
        {
            InitializeComponent();
            this._PersonID = personID;
            ctrAddEditPersonWithFilters1.PersonID = personID;
            if ( this._PersonID == -1 )
            {
                ctrAddEditPersonWithFilters1._Mode = ctrAddEditPersonWithFilters._enMode.AddMode;
            }
            else
            {
                ctrAddEditPersonWithFilters1._Mode = ctrAddEditPersonWithFilters._enMode.UpdateMode;
            }
        }
        private void btnSave_Click( object sender, EventArgs e )
        {
            ctrAddEditPersonWithFilters1.Save();
        }
        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }
        private void AddNewUser_Load( object sender, EventArgs e )
        {
            ctrAddEditPersonWithFilters1._LoadForm();
        }
        private void btnNext_Click( object sender, EventArgs e )
        {

            frmAddEditUserCredinitils frmUserCredintials = new frmAddEditUserCredinitils( ctrAddEditPersonWithFilters1, ctrAddEditPersonWithFilters1.PersonID );
            frmUserCredintials.ShowDialog();
        }
        public void frmAddEditCredinitilas_Data( object sender, int personID )
        {
            this._PersonID = personID;
            ctrAddEditPersonWithFilters1._LoadForm();
        }
        private void btnAddNewPerson_Click( object sender, EventArgs e )
        {
            frmAddEditPerson frmAdd = new frmAddEditPerson( this._PersonID );
            frmAdd.dataBack += frmAddEditCredinitilas_Data;
            frmAdd.ShowDialog();
        }

    }
}
