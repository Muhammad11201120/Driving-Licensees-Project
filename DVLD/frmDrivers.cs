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
    public partial class frmDrivers : Form
    {
        enum enFilters
        {
            DriverID = 0,
            PersonID = 1,
            NationalNumber = 2,
            NumberOfActiveLicenses = 3,
            FullName = 4,
            None = 5
        }
        DataTable dt = null;
        DataView dv = null;
        enFilters filter = enFilters.None;
        public frmDrivers()
        {
            InitializeComponent();
        }
        private void loadData( enFilters filter )
        {
            dt = clsDrivers.getDrivers();
            dv = new DataView( dt );
            switch ( filter )
            {
                case enFilters.DriverID:
                    dv.RowFilter = "DriverID = " + txtFilter.Text;
                    break;
                case enFilters.PersonID:
                    dv.RowFilter = "PersonID = " + txtFilter.Text;
                    break;
                case enFilters.NationalNumber:
                    dv.RowFilter = "NationalNo = " + txtFilter.Text;
                    break;
                case enFilters.FullName:
                    dv.RowFilter = "FullName LIKE '%" + txtFilter.Text + "%'";
                    break;
                case enFilters.NumberOfActiveLicenses:
                    dv.RowFilter = "NumberOfActiveLicenses = " + txtFilter.Text;
                    break;
                default:
                    dv.RowFilter = "";
                    break;
            }
            dataGridView1.DataSource = dv;
        }

        private void frmDrivers_Load( object sender, EventArgs e )
        {
            loadData( filter );
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void txtFilter_TextChanged( object sender, EventArgs e )
        {
            if ( txtFilter.Text != string.Empty || dv.Equals( "" ) )
            {
                loadData( filter );
            }
        }

        private void txtFilter_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( comboBox1.SelectedIndex == ( int ) enFilters.DriverID || comboBox1.SelectedIndex == ( int ) enFilters.PersonID || comboBox1.SelectedIndex == ( int ) enFilters.NumberOfActiveLicenses )
            {
                if ( !char.IsNumber( e.KeyChar ) )
                {
                    e.Handled = e.KeyChar != ( Char ) Keys.Back;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged( object sender, EventArgs e )
        {
            filter = ( enFilters ) comboBox1.SelectedIndex;
        }
    }
}
