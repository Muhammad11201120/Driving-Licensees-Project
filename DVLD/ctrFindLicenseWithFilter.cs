using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrFindLicenseWithFilter : UserControl
    {
        public delegate void DataBackEventHandler( object sender );
        public event DataBackEventHandler dataBack;

        public clsLicenses license = null;
        public clsApplications applications = null;
        public clsPeople person = null;
        public clsDrivers driver = null;
        public bool withFilter = true;
        public int licenseID = -1;
        public ctrFindLicenseWithFilter()
        {
            InitializeComponent();
        }
        public void checkFilter()
        {
            if ( !withFilter )
            {
                txtLicenseID.Text = licenseID.ToString();
                groupBox1.Enabled = false;
            }
        }
        public bool LoadForm()
        {
            license = clsLicenses.FindLicenseByLicenseID( licenseID );
            if ( license == null )
            {
                return false;
            }
            applications = clsApplications.FindApplicationByID( license.ApplicationID );
            person = clsPeople.FindPersonByID( applications.applicationPersonID );
            driver = clsDrivers.FindDriverByPersonID( person.ID );
            lblClass.Text = clsLicensesClasses.FindClassByID( license.LicenseClassID ).ClassName;
            lblDriverID.Text = license.DriverID.ToString();
            lblIsseDate.Text = license.IssueDate.ToShortDateString();
            lblLicenseID.Text = license.LicenseID.ToString();
            lblName.Text = person.firstName + " " + person.lastName;
            lblExcpirtyDate.Text = license.ExpiryDate.ToShortDateString();
            lblNationalID.Text = person.nationalID;
            if ( license.IsActive )
            {
                lblIsActive.Text = "YES";
                lblIsActive.ForeColor = Color.Green;
            }
            else
            {
                lblIsActive.Text = "NO";
                lblIsActive.ForeColor = Color.Red;
            }
            lblDriverID.Text = driver.DriverID.ToString();
            if ( person.gendor == 0 )
            {
                lblGendor.Text = "MALE";
            }
            else
            {
                lblGendor.Text = "FEMALE";
            }
            lblDateOfBirth.Text = person.dateOfBirth.ToShortDateString();
            if ( license.issueReason == ( byte ) clsLicenses.enIssueReason.firstTime )
            {
                lblIssueReason.Text = "FIRST TIME";
            }
            else if ( license.issueReason == ( byte ) clsLicenses.enIssueReason.secondTime )
            {
                lblIssueReason.Text = "SECOND TIME";
            }
            else if ( license.issueReason == ( byte ) clsLicenses.enIssueReason.thirdTime )
            {
                lblIssueReason.Text = "THIRD TIME";
            }
            else if ( license.issueReason == ( byte ) clsLicenses.enIssueReason.fourthTime )
            {
                lblIssueReason.Text = "FOURTH TIME";
            }
            else if ( license.issueReason == ( byte ) clsLicenses.enIssueReason.moreThanFourTimes )
            {
                lblIssueReason.Text = "MORE THAN FOUR TIMES";
            }
            else if ( license.issueReason == ( byte ) clsLicenses.enIssueReason.Renew )
            {
                lblIssueReason.Text = "RENEW";
            }
            else if ( license.issueReason == ( byte ) clsLicenses.enIssueReason.Replace )
            {
                lblIssueReason.Text = "REPLACE";
            }
            else
            {
                lblIssueReason.Text = "UN KNOWN";
            }
            lblIsDetained.Text = clsDetsinedLicense.FindDetainLicenseByLicenseID( license.LicenseID ).isRelaesed  ? "NO" : "YES";
            lblNotes.Text = license.Notes == string.Empty ? "NO ADDITIONS" : license.Notes;
            pboxImage.ImageLocation = person.imagePath;
            return true;
        }

        private void txtLicenseID_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( !char.IsNumber( e.KeyChar ) )
            {
                e.Handled = e.KeyChar != ( Char ) Keys.Back;
            }
        }

        private void button1_Click( object sender, EventArgs e )
        {
            licenseID = int.Parse( txtLicenseID.Text );
            license = clsLicenses.FindLicenseByLicenseID( licenseID );
            if ( LoadForm() )
            {
                LoadForm();
                dataBack?.Invoke( this );
            }
        }
    }
}
