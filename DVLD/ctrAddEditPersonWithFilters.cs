using DVLD_BusinessLayer;
using DVLD_DataAccessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrAddEditPersonWithFilters : UserControl
    {
        public delegate void ctrShowPersonDetailsWithFiltersEventHandler( object sender, int personID );
        public event ctrShowPersonDetailsWithFiltersEventHandler dataBack;
        struct stDefaultImage
        {
            public string male;
            public string female;
        }
        public enum _enMode
        {
            AddMode = 0,
            UpdateMode = 1
        }
        private enum _enGendor
        {
            Male = 0,
            Female = 1
        }
        enum enFilter
        {
            Email = 0,
            Phone = 1,
            PersonID = 2,
            nationalNO = 3,
            userID = 4,
            userName = 5
        }
        public int PersonID { get; set; }
        private clsPeople _Person;
        public _enMode _Mode = _enMode.AddMode;
        stDefaultImage _image;
        //Constructor
        public ctrAddEditPersonWithFilters()
        {
            InitializeComponent();
            _image.male = "D:\\Programing\\c#\\DVLD_PROJECT\\Assets\\Male512.png";
            _image.female = "D:\\Programing\\c#\\DVLD_PROJECT\\Assets\\Female512.png";
        }
        private bool _CheckIfTextBoxIsEmpty( TextBox txtbx )
        {
            if ( txtbx.Text == string.Empty )
            {
                errorProvider1.SetError( txtbx, "This Field Is Required.." );
                return false;
            }
            else
            {
                errorProvider1.SetError( txtbx, string.Empty );
                return true;
            }
        }
        private bool findPerson()
        {
            if ( this.PersonID != -1 )
            {
                cbxFilters.SelectedIndex = ( int ) enFilter.PersonID;
                txtFilter.Text = PersonID.ToString();
            }
            if ( cbxFilters.SelectedIndex == ( int ) enFilter.Email )
            {
                this._Person = clsPeople.FindPersonByEmail( txtFilter.Text );
                if ( this._Person != null )
                {
                    this.PersonID = this._Person.ID;
                    return true;
                }
            }
            if ( cbxFilters.SelectedIndex == ( int ) enFilter.Phone )
            {
                this._Person = clsPeople.FindPersonByPhone( txtFilter.Text );
                if ( this._Person != null )
                {
                    this.PersonID = this._Person.ID;
                    return true;
                }
            }
            if ( cbxFilters.SelectedIndex == ( int ) enFilter.PersonID )
            {
                this._Person = clsPeople.FindPersonByID( int.Parse( txtFilter.Text ) );
                if ( this._Person != null )
                {
                    this.PersonID = this._Person.ID;
                    return true;
                }
            }
            if ( cbxFilters.SelectedIndex == ( int ) enFilter.nationalNO )
            {
                this._Person = clsPeople.FindPersonByNationalID( txtFilter.Text );
                if ( this._Person != null )
                {
                    this.PersonID = this._Person.ID;
                    return true;
                }
            }
            return false;
        }

        private bool checkIfNationalNumberExisits( string nationalNO )
        {
            return clsPeople.IsNationalIDExist( nationalNO );
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
        public void _LoadForm()
        {

            _FillCountries();
            cmxCountry.SelectedIndex = 0;

            if ( !findPerson() )
            {
                lblMode.Text = "ADD NEW PERSON";
                txtId.Enabled = false;
                txtId.Enabled = false;
                this._Person = new clsPeople();
                return;
            }

            this._Person = clsPeople.FindPersonByID( this.PersonID );
            if ( this._Person == null )
            {
                return;
            }

            cbxFilters.Enabled = false;
            txtFilter.Text = this._Person.ID.ToString();
            txtFilter.Enabled = false;
            lblMode.Text = "UPDATE " + this._Person.firstName + "  " + this._Person.lastName;
            txtId.Enabled = false;
            txtId.Text = this._Person.ID.ToString();
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
        public void Save()
        {
            string sourceImagePath = "";
            string destinationImagePath = "";
            string PreviousImagePath = "";
            if ( !_CheckIfTextBoxIsEmpty( txtNationalID ) || !_CheckIfTextBoxIsEmpty( txtFirstName ) || !_CheckIfTextBoxIsEmpty( txtLastName ) || !_CheckIfTextBoxIsEmpty( txtPhone ) || !_CheckIfTextBoxIsEmpty( txtAddress ) )
            {
                return;
            }
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
            if ( pbxPerson.ImageLocation != _image.male && pbxPerson.ImageLocation != _image.female && pbxPerson.ImageLocation != string.Empty )
            {

                sourceImagePath = pbxPerson.ImageLocation;
                destinationImagePath = "D:\\DVLD-People-Images\\" + Guid.NewGuid() + ".png";
                PreviousImagePath = this._Person.imagePath;

                if ( PreviousImagePath != string.Empty && System.IO.File.Exists( PreviousImagePath ) && PreviousImagePath != destinationImagePath )
                {

                    System.IO.File.Delete( this._Person.imagePath );
                }
                System.IO.File.Copy( sourceImagePath, destinationImagePath );
                this._Person.imagePath = destinationImagePath;
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
                dataBack?.Invoke( this, this._Person.ID );
                MessageBox.Show( "Contact Saved Successfully.." );

            }
            else
            {
                MessageBox.Show( "ERROR: Data Is Not Saved" );
            }
            _Mode = _enMode.UpdateMode;
            lblMode.Text = "UPDATE " + this._Person.firstName + "  " + this._Person.lastName;
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
                }
                else
                {
                    errorProvider1.SetError( txtNationalID, string.Empty );
                }
            }

        }
        private void btnSearch_Click( object sender, EventArgs e )
        {
            _LoadForm();
        }
        private void txtFilter_TextChanged( object sender, EventArgs e )
        {

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
        private void lblRemoveImage_Click( object sender, EventArgs e )
        {
            pbxPerson.ImageLocation = null;
            lblRemoveImage.Visible = false;
        }
        private void rbtnMale_CheckedChanged( object sender, EventArgs e )
        {
            this._Person.gendor = 0;
            pbxPerson.ImageLocation = "D:\\Programing\\c#\\DVLD_PROJECT\\Assets\\male.png";
        }

        private void rbtnFemale_CheckedChanged( object sender, EventArgs e )
        {
            this._Person.gendor = 1;
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

                    }
                    else
                    {
                        errorProvider1.SetError( txtEmail, string.Empty );

                    }

                }

            }
        }

    }
}
