using DVLD_BusinessLayer;
using DVLD_DataAccessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmNewLicenseApplication : Form
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
        enum enApplicationTypes
        {
            NewLocalDrivingLicenseService = 1,
            RenewDrivingLicenseService = 2,
            ReplacementForAlostDrivingLicense = 3,
            ReplacementForAdamagedDrivingLicense = 4,
            ReleaseDetainedDrivingLicsense = 5,
            NewInternationalLicense = 6

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
        public frmNewLicenseApplication( int personID )
        {

            InitializeComponent();
            this._PersonID = personID;
            if ( this._PersonID == -1 )
            {
                this._Mode = _enMode.AddMode;
            }
            else
            {
                this._Mode = _enMode.UpdateMode;
            }
            _image.male = "D:\\Programing\\c#\\DVLD_PROJECT\\Assets\\male.png";
            _image.female = "D:\\Programing\\c#\\DVLD_PROJECT\\Assets\\female.png";

        }
        private bool findPerson()
        {
            if ( this._PersonID != -1 )
            {
                cbxFilters.SelectedIndex = ( int ) enFilter.PersonID;
                txtFilter.Text = _PersonID.ToString();
            }
            if ( cbxFilters.SelectedIndex == ( int ) enFilter.Email )
            {
                this._Person = clsPeople.FindPersonByEmail( txtFilter.Text );
                if ( this._Person != null )
                {
                    return true;
                }
            }
            if ( cbxFilters.SelectedIndex == ( int ) enFilter.Phone )
            {
                this._Person = clsPeople.FindPersonByPhone( txtFilter.Text );
                if ( this._Person != null )
                {
                    return true;
                }
            }
            if ( cbxFilters.SelectedIndex == ( int ) enFilter.PersonID )
            {
                this._Person = clsPeople.FindPersonByID( int.Parse( txtFilter.Text ) );
                if ( this._Person != null )
                {
                    return true;
                }
            }
            if ( cbxFilters.SelectedIndex == ( int ) enFilter.nationalNO )
            {
                this._Person = clsPeople.FindPersonByNationalID( txtFilter.Text );
                if ( this._Person != null )
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsValidEmail( string email )
        {
            var trimmedEmail = email.Trim();

            if ( trimmedEmail.EndsWith( "." ) )
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress( email );
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        private bool checkIfNationalNumberExisits( string nationalNO )
        {
            return clsPeople.IsNationalIDExist( nationalNO );
        }
        private void _FillCountries()
        {
            DataTable dt = clsCountries.GetAllCountries();
            if ( dt != null )
            {
                foreach ( DataRow row in dt.Rows )
                {
                    cmxCountry.Items.Add( row[ "CountryName" ] );
                }
            }
            else
            {
                cmxCountry.Visible = false;
            }
        }
        private void _LoadForm()
        {

            _FillCountries();
            cmxCountry.SelectedIndex = 0;

            if ( !findPerson() )
            {
                lblTitle.Text = "ADD NEW USER";
                txtId.Enabled = false;
                txtNationalID.Text = string.Empty;
                txtNationalID.Enabled = true;
                txtFirstName.Text = string.Empty;
                txtSecondName.Text = string.Empty;
                txtThirdName.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtLastName.Text = string.Empty;
                dtmDateOfBirth.Value = DateTime.Now;
                txtAddress.Text = string.Empty;
                txtPhone.Text = string.Empty;
                rbtnFemale.Checked = true;
                pbxPerson.ImageLocation = string.Empty;
                lblRemoveImage.Visible = false;
                this._Person = new clsPeople();
                return;
            }

            lblTitle.Text = "Edit" + " " + this._Person.firstName + " " + this._Person.lastName;
            txtId.Text = this._Person.ID.ToString();
            txtId.Enabled = false;
            txtNationalID.Text = this._Person.nationalID.ToString();
            txtNationalID.Enabled = false;
            txtFirstName.Text = this._Person.firstName;
            txtSecondName.Text = this._Person.secondName;
            txtLastName.Text = this._Person.lastName;
            dtmDateOfBirth.Value = this._Person.dateOfBirth;
            txtAddress.Text = this._Person.address;
            txtPhone.Text = this._Person.phone;

            if ( this._Person.gendor == ( byte ) _enGendor.Female )
            {
                rbtnFemale.Checked = true;
                pbxPerson.ImageLocation = _image.female;
            }
            else
            {
                rbtnMale.Checked = true;
                pbxPerson.ImageLocation = _image.male;
            }
            if ( this._Person.thirdName != "" )
            {
                txtThirdName.Text = this._Person.thirdName;
            }
            if ( this._Person.email != "" )
            {
                txtEmail.Text = this._Person.email;
            }

            if ( this._Person.imagePath != "" )
            {
                try
                {
                    pbxPerson.Load( this._Person.imagePath );
                }
                catch ( Exception ex )
                {

                    MessageBox.Show( ex.Message );
                }

            }
            lblRemoveImage.Visible = ( this._Person.imagePath != "" );
            cmxCountry.SelectedIndex = cmxCountry.FindString( clsCountries.FindContry( this._Person.nationalityCountryID ).CountryName );
        }

        private void btnSave_Click( object sender, EventArgs e )
        {
            string sourctImagePath = "";
            string destnationImagePath = "";
            string PreviousImagePath = "";
            int countryID = clsCountries.FindContry( cmxCountry.Text ).CountryID;
            this._Person.nationalID = txtNationalID.Text;
            this._Person.firstName = txtFirstName.Text;
            this._Person.secondName = txtSecondName.Text;
            this._Person.lastName = txtLastName.Text;
            this._Person.phone = txtPhone.Text;
            this._Person.address = txtAddress.Text;
            this._Person.dateOfBirth = dtmDateOfBirth.Value;
            this._Person.nationalityCountryID = countryID;
            if ( rbtnFemale.Checked == true )
            {
                this._Person.gendor = 1;
            }
            else
            {
                this._Person.gendor = 0;
            }
            if ( pbxPerson.ImageLocation != _image.male && pbxPerson.ImageLocation != _image.female && pbxPerson.ImageLocation != null )
            {
                PreviousImagePath = this._Person.imagePath;
                sourctImagePath = pbxPerson.ImageLocation;
                destnationImagePath = "D:\\DVLD-People-Images\\" + Guid.NewGuid() + ".png";
                System.IO.File.Copy( sourctImagePath, destnationImagePath );
                if ( PreviousImagePath != "" )
                {
                    System.IO.File.Delete( PreviousImagePath );
                }
                this._Person.imagePath = destnationImagePath;
            }
            else
            {
                this._Person.imagePath = "";
            }
            if ( txtThirdName.Text != string.Empty )
            {
                this._Person.thirdName = txtThirdName.Text;
            }
            else
            {
                this._Person.thirdName = "";
            }
            if ( txtEmail.Text != string.Empty )
            {
                this._Person.email = txtEmail.Text;
            }
            else
            {
                this._Person.email = string.Empty;
            }
            if ( this._Person.Save() )
            {
                MessageBox.Show( "Contact Saved Successfully.." );

            }
            else
            {
                MessageBox.Show( "ERROR: Data Is Not Saved" );
            }
            _Mode = _enMode.UpdateMode;
            txtId.Text = this._Person.ID.ToString();
            txtId.ReadOnly = true;
        }
        private void txtNationalID_Leave( object sender, EventArgs e )
        {
            if ( this._Mode == _enMode.AddMode )
            {
                if ( checkIfNationalNumberExisits( txtNationalID.Text ) )
                {
                    errorProvider1.SetError( txtNationalID, "This National Number Is Alreaady Rigestered.." );
                    btnNext.Enabled = false;
                }
                else
                {
                    errorProvider1.SetError( txtNationalID, string.Empty );
                    btnNext.Enabled = true;
                }
            }
        }


        private void rbtnMale_CheckedChanged( object sender, EventArgs e )
        {
            pbxPerson.ImageLocation = "D:\\Programing\\c#\\DVLD_PROJECT\\Assets\\male.png";
        }

        private void rbtnFemale_CheckedChanged( object sender, EventArgs e )
        {
            pbxPerson.ImageLocation = "D:\\Programing\\c#\\DVLD_PROJECT\\Assets\\female.png";
        }

        private void txtEmail_Leave( object sender, EventArgs e )
        {
            if ( this._Mode == _enMode.AddMode )
            {
                if ( txtEmail.Text != string.Empty )
                {
                    if ( !IsValidEmail( txtEmail.Text ) )
                    {
                        errorProvider1.SetError( txtEmail, "This is Invalid Email Address.." );
                        btnNext.Enabled = false;
                    }
                    else
                    {
                        errorProvider1.SetError( txtEmail, string.Empty );
                        btnNext.Enabled = true;
                    }

                }

            }
        }
        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }
        private void txtFilter_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( cbxFilters.SelectedIndex == ( int ) enFilter.PersonID || cbxFilters.SelectedIndex == ( int ) enFilter.Phone )
            {
                if ( !char.IsNumber( e.KeyChar ) )
                {
                    e.Handled = e.KeyChar != ( Char ) Keys.Back;
                }
            }

        }
        private void frmNewLicenseApplication_Load( object sender, EventArgs e )
        {
            _LoadForm();
        }



        private void btnSearch_Click( object sender, EventArgs e )
        {
            _LoadForm();
        }

        private void btnNext_Click( object sender, EventArgs e )
        {

            frmNewApplicationClass form = new frmNewApplicationClass( this._Person.ID, ( int ) enApplicationTypes.NewLocalDrivingLicenseService );
            form.ShowDialog();

        }
        public void frmAddEditCredinitilas_Data( object sender, int personID )
        {
            this._PersonID = personID;
            _LoadForm();
        }
        private void lblImage_Click( object sender, EventArgs e )
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if ( openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbxPerson.Load( selectedFilePath );
                lblRemoveImage.Visible = true;
            }
        }

        private void lblRemoveImage_Click( object sender, EventArgs e )
        {
            pbxPerson.ImageLocation = null;
            lblRemoveImage.Visible = false;
        }

        private void btnAddNewPerson_Click( object sender, EventArgs e )
        {
            //frmAddEditPerson frmAdd = new frmAddEditPerson( this._PersonID );
            //frmAdd.dataBack += frmAddEditCredinitilas_Data;
            //frmAdd.ShowDialog();
        }

        private void txtFilter_TextChanged( object sender, EventArgs e )
        {
            _LoadForm();
        }
    }
}
