using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;
namespace DVLD
{
    public partial class frmShowLicenseHistory : Form
    {
        private int _personID = -1;
        private clsDrivers _Driver = null;
        public frmShowLicenseHistory( int personID )
        {
            InitializeComponent();
            this._personID = personID;
            this._Driver = clsDrivers.FindDriverByPersonID( personID );
            ctrShowPersonDetails1.PersonID = this._personID;
        }

        private void frmShowLicenseHistory_Load( object sender, EventArgs e )
        {
            DataTable dt = clsLicenses.FindLicensesByDriverID( _Driver.DriverID );
            DataTable dt2 = clsInternationalLicense.FindLicensesByDriverID( _Driver.DriverID );



            if ( dt.Rows != null )
            {
                DataView dv = new DataView( dt );
                dataGridView1.DataSource = dv;
            }
            if ( dt2.Rows != null )
            {
                DataView dv2 = new DataView( dt2 );
                dataGridView2.DataSource = dv2;
            }
            ctrShowPersonDetails1._LoadForm();
        }
    }
}
