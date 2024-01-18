using DVLD_BusinessLayer;
using DVLD_DataAccessLayer;
using System.Windows.Forms;
namespace DVLD
{
    public partial class frmShowPersonDetails : Form
    {

        public int _PersonID = -1;
        private clsPeople _person;
        public frmShowPersonDetails( int PersonID )
        {
            this._PersonID = PersonID;
            this._person = clsPeople.FindPersonByID( this._PersonID );
            InitializeComponent();
        }

        private void frmShowPersonDetails_Load( object sender, System.EventArgs e )
        {
            lblPersonIDValue.Text = _PersonID.ToString();
            ctrShowPersonDetails1 = new ctrShowPersonDetails();
            lblFirstNaameValue.Text = this._person.firstName;
            lblSecondNameValue.Text = this._person.secondName;
            lblThirdNameVaalue.Text = this._person.thirdName;
            lblLastNameValue.Text = this._person.lastName;
            lblDateOfBirth.Text = this._person.dateOfBirth.ToString();
            lblEmailValue.Text = this._person.email;
            lblPhoneValue.Text = this._person.phone;
            lblNationalNO.Text = this._person.nationalID;
            if ( this._person.gendor == 0 )
            {
                lblGendorValue.Text = "MALE";
            }
            else
            {
                lblGendorValue.Text = "FEMALE";
            }
            lblCountryValue.Text = clsCountries.FindContry( this._person.nationalityCountryID ).CountryName;
            pbxImagePath.ImageLocation = this._person.imagePath;
            lblAddressValue.Text = this._person.address;
        }

        private void lblEditPerson_Click( object sender, System.EventArgs e )
        {
            frmAddEditPerson form = new frmAddEditPerson( this._PersonID );
            form.ShowDialog();
        }

        private void btnClose_Click( object sender, System.EventArgs e )
        {
            this.Close();
        }
    }
}
