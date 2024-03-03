using DVLD_BusinessLayer;
using DVLD_DataAccessLayer;
using System;
using System.Data;
using System.Windows.Forms;
namespace DVLD
{
    public partial class ctrShowPersonDetails : UserControl
    {
        public delegate void ctrShowPersonDetailsEventHandler( object sender, int personID );
        public event ctrShowPersonDetailsEventHandler dataBack;
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
        public int PersonID { get; set; }
        private clsPeople _Person;
        public _enMode _Mode = _enMode.UpdateMode;
        stDefaultImage _image;
        public ctrShowPersonDetails()
        {

            InitializeComponent();
            _image.male = "D:\\Programing\\c#\\DVLD_PROJECT\\Assets\\male.png";
            _image.female = "D:\\Programing\\c#\\DVLD_PROJECT\\Assets\\female.png";

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
        public void _LoadForm()
        {

            _FillCountries();
            cmxCountry.SelectedIndex = 0;


            this._Person = clsPeople.FindPersonByID( this.PersonID );
            if ( this._Person == null )
            {
                MessageBox.Show( "There Is No Person With This ID.." );
                return;
            }

            lblMode.Text = "UPDATE " + this._Person.firstName + "  " + this._Person.lastName;
            lblPersonID.Enabled = false;
            lblPersonID.Text = this._Person.ID.ToString();
            lblNationalIdValue.Text = this._Person.nationalID.ToString();
            lblNationalIdValue.Enabled = false;
            lblFirstName.Text = this._Person.firstName;
            lblSecondNameValue.Text = this._Person.secondName;
            lblLastNameValue.Text = this._Person.lastName;
            dtmDateOfBirth.Value = this._Person.dateOfBirth;
            lblAddressValue.Text = this._Person.address;
            lblPhoneValue.Text = this._Person.phone;
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
                lblThirdNameValue.Text = this._Person.thirdName;
            }
            if ( this._Person.email != "" )
            {
                lblEmailValue.Text = this._Person.email;
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
            string sourctImagePath = "";
            string destnationImagePath = "";
            string PreviousImagePath = "";
            int countryID = clsCountries.FindContry( cmxCountry.Text ).CountryID;
            this._Person.nationalID = lblNationalIdValue.Text;
            this._Person.firstName = lblFirstName.Text;
            this._Person.secondName = lblSecondNameValue.Text;
            this._Person.lastName = lblLastNameValue.Text;
            this._Person.phone = lblPhoneValue.Text;
            this._Person.address = lblAddressValue.Text;
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

                sourctImagePath = pbxPerson.ImageLocation;
                destnationImagePath = "D:\\DVLD-People-Images\\" + Guid.NewGuid() + ".png";
                PreviousImagePath = this._Person.imagePath;
                System.IO.File.Copy( sourctImagePath, destnationImagePath );
                this._Person.imagePath = destnationImagePath;
                if ( PreviousImagePath != string.Empty && System.IO.File.Exists( PreviousImagePath ) && PreviousImagePath != destnationImagePath )
                {
                    System.IO.File.Delete( this._Person.imagePath );
                }
            }
            else
            {
                this._Person.imagePath = "";
            }
            if ( lblThirdNameValue.Text != string.Empty )
            {
                this._Person.thirdName = lblThirdNameValue.Text;
            }
            else
            {
                this._Person.thirdName = "";
            }
            if ( lblEmailValue.Text != string.Empty )
            {
                this._Person.email = lblEmailValue.Text;
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
            lblPersonID.Text = this._Person.ID.ToString();
            lblPersonID.Enabled = false;
        }
        private void txtNationalID_Leave( object sender, EventArgs e )
        {
            if ( this._Mode == _enMode.AddMode )
            {
                if ( checkIfNationalNumberExisits( lblPersonID.Text ) )
                {
                    errorProvider1.SetError( lblNationalIdValue, "This National Number Is Alreaady Rigestered.." );
                }
                else
                {
                    errorProvider1.SetError( lblNationalIdValue, string.Empty );
                }
            }

        }
        private void lblRemoveImage_Click( object sender, EventArgs e )
        {
            pbxPerson.ImageLocation = null;
            lblRemoveImage.Visible = false;
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
                if ( lblEmailValue.Text != string.Empty )
                {
                    if ( !IsValidEmail( lblEmailValue.Text ) )
                    {
                        errorProvider1.SetError( lblEmailValue, "This is Invalid Email Address.." );

                    }
                    else
                    {
                        errorProvider1.SetError( lblEmailValue, string.Empty );

                    }

                }

            }
        }
        private void ctrShowPersonDetails_Load( object sender, System.EventArgs e )
        {
            errorProvider1.ContainerControl = this;
        }

        private void btnSave( object sender, EventArgs e )
        {

        }
    }
}
