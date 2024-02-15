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
    public partial class frmLocalDrivingLicenseApplications : Form
    {
        enum enFilters
        {
            Name = 0,
            NationalNo = 1,
            ApplicationStatus = 2,
            None = 3,
        }
        private int _TestType = 1;
        public frmLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }
        private void _LoadData( enFilters switch_on )
        {

            DataTable dt = clsLocalDrivingLicenseApplications_View.GetAllLocalDrivingLicenseApplication();
            DataView dv = new DataView( dt );
            switch ( switch_on )
            {
                case enFilters.Name:
                    dv.RowFilter = "FullName like '%" + txtFilerValue.Text + "%'";
                    dataGridView1.DataSource = dv;
                    break;
                case enFilters.NationalNo:
                    dv.RowFilter = "NationalNo like '%" + txtFilerValue.Text + "%'";
                    dataGridView1.DataSource = dv;
                    break;
                case enFilters.ApplicationStatus:
                    dv.RowFilter = "Status like '%" + txtFilerValue.Text + "%'";
                    dataGridView1.DataSource = dv;
                    break;
                case enFilters.None:
                    comboBox1.SelectedIndex = 3;
                    txtFilerValue.Text = "None";
                    dataGridView1.DataSource = dv;
                    break;
            }

        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void frmLocalDrivingLicenseApplications_Load( object sender, EventArgs e )
        {
            _LoadData( enFilters.None );
        }

        private void btnAddNewApplication_Click( object sender, EventArgs e )
        {
            frmNewLicenseApplication frm = new frmNewLicenseApplication( -1 );
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmShowApplicationDetails frm = new frmShowApplicationDetails( dataGridView1.CurrentRow.Cells[ 2 ].Value.ToString() );
            frm.ShowDialog();
        }

        private void shcduleToolStripMenuItem_Click( object sender, EventArgs e )
        {
            string className = dataGridView1.CurrentRow.Cells[ 1 ].Value.ToString();
            string nationalNO = dataGridView1.CurrentRow.Cells[ 2 ].Value.ToString();
            this._TestType = 1;
            frmVisionTestAppointment frm = new frmVisionTestAppointment( nationalNO, className, _TestType );
            frm.ShowDialog();
        }


        private void scheduleWritingTestToolStripMenuItem_Click( object sender, EventArgs e )
        {
            string className = dataGridView1.CurrentRow.Cells[ 1 ].Value.ToString();
            string nationalNO = dataGridView1.CurrentRow.Cells[ 2 ].Value.ToString();
            this._TestType = 2;
            frmVisionTestAppointment frm = new frmVisionTestAppointment( nationalNO, className, _TestType );
            frm.ShowDialog();
        }

        private void scheduleStreetTestToolStripMenuItem_Click( object sender, EventArgs e )
        {
            string className = dataGridView1.CurrentRow.Cells[ 1 ].Value.ToString();
            string nationalNO = dataGridView1.CurrentRow.Cells[ 2 ].Value.ToString();
            this._TestType = 3;
            frmVisionTestAppointment frm = new frmVisionTestAppointment( nationalNO, className, _TestType );
            frm.ShowDialog();
        }
        private void txtFilerValue_TextChanged( object sender, EventArgs e )
        {
            _LoadData( ( enFilters ) comboBox1.SelectedIndex );
        }

        private void contextMenuStrip1_Opening( object sender, CancelEventArgs e )
        {

        }

        private void shecduleTestToolStripMenuItem_MouseEnter( object sender, EventArgs e )
        {
            int PassedTest = int.Parse( dataGridView1.CurrentRow.Cells[ 5 ].Value.ToString() );
            if ( PassedTest == 0 )
            {
                ( contextMenuStrip1.Items[ 2 ] as ToolStripMenuItem ).DropDownItems[ 0 ].Enabled = true;
            }
            if ( PassedTest == 1 )
            {
                ( contextMenuStrip1.Items[ 2 ] as ToolStripMenuItem ).DropDownItems[ 2 ].Enabled = true;
            }
            if ( PassedTest == 2 )
            {
                ( contextMenuStrip1.Items[ 2 ] as ToolStripMenuItem ).DropDownItems[ 4 ].Enabled = true;
            }
        }

        private void shecduleTestToolStripMenuItem_DropDownClosed( object sender, EventArgs e )
        {
            ( contextMenuStrip1.Items[ 2 ] as ToolStripMenuItem ).DropDownItems[ 0 ].Enabled = false;
            ( contextMenuStrip1.Items[ 2 ] as ToolStripMenuItem ).DropDownItems[ 2 ].Enabled = false;
            ( contextMenuStrip1.Items[ 2 ] as ToolStripMenuItem ).DropDownItems[ 4 ].Enabled = false;
        }
    }
}
