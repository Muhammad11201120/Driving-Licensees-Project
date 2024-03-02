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
    public partial class frmManageDetainedLicenses : Form
    {
        public frmManageDetainedLicenses()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            DataTable dt = clsDetsinedLicense.GetAllDetainLicenses();
            DataView dv = new DataView( dt );
            dataGridView1.DataSource = dv;
        }

        private void frmManageDetainedLicenses_Load( object sender, EventArgs e )
        {
            _LoadData();
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnDetain_Click( object sender, EventArgs e )
        {
            frmDetainLicense frm = new frmDetainLicense( -1 );
            frm.ShowDialog();
        }

        private void btnRelease_Click( object sender, EventArgs e )
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense( -1 );
            frm.ShowDialog();
        }
    }
}
