using DVLD_BusinessLayer;
using DVLD_DataAccessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmAddEditPerson : Form
    {
        public enum _enMode
        {
            AddMode = 0,
            UpdateMode = 1
        }
        private int _PersonID;
        private clsPeople _Person;
        private _enMode _Mode;
        public frmAddEditPerson( int personID )
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

            if ( this._Mode == _enMode.AddMode )
            {
                lblMode.Text = "ADD NEW PERSON";
                txtId.Enabled = false;
                this._Person = new clsPeople();
                return;
            }

            this._Person = clsPeople.FindPeopleByID( this._PersonID );
            if ( this._Person == null )
            {
                MessageBox.Show( "There Is No Person With This ID.." );
            }

            lblMode.Text = "UPDATE " + this._Person.firstName + "  " + this._Person.lastName;
            txtId.Enabled = false;
            txtNationalID.Text = this._Person.nationalID.ToString();
            txtNationalID.Enabled = false;
            txtFirstName.Text = this._Person.firstName;
            txtSecondName.Text = this._Person.secondName;
            txtLastName.Text = this._Person.lastName;
            dtmDateOfBirth.Value = this._Person.dateOfBirth;
            txtGendor.Text = this._Person.gendor.ToString();
            txtAddress.Text = this._Person.address;
            txtPhone.Text = this._Person.phone;

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

        private void frmAddEditPerson_Load( object sender, EventArgs e )
        {
            errorProvider1.ContainerControl = this;
            _LoadForm();
        }

        private void btnSave_Click( object sender, EventArgs e )
        {
            int countryID = clsCountries.FindContry( cmxCountry.Text ).CountryID;
            this._Person.nationalID = txtNationalID.Text;
            this._Person.firstName = txtFirstName.Text;
            this._Person.secondName = txtSecondName.Text;
            this._Person.lastName = txtLastName.Text;
            this._Person.gendor = Convert.ToByte( txtGendor.Text );
            this._Person.phone = txtPhone.Text;
            this._Person.address = txtAddress.Text;
            this._Person.dateOfBirth = dtmDateOfBirth.Value;
            this._Person.nationalityCountryID = countryID;
            if ( pbxPerson.ImageLocation != null )
            {
                this._Person.imagePath = pbxPerson.ImageLocation;
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
                this._Person.email = "";
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
                    btnSave.Enabled = false;
                }
                else
                {
                    errorProvider1.SetError( txtNationalID, string.Empty );
                    btnSave.Enabled = true;
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
        private void button1_Click( object sender, System.EventArgs e )
        {
            this.Close();
        }

    }
}
