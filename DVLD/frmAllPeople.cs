using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;
namespace DVLD
{
    public partial class frmAllPeople : Form
    {
        enum enFilters
        {
            firstName = 0,
            secondName = 1,
            thirdName = 2,
            lastName = 3,
            email = 4,
            phone = 5,
            nationalNO = 6,
            gendor = 7,
            ID = 8,
            all = 9,

        }

        private frmAddEditPerson addEditForm = null;
        private void RefreshAllPeopleList( enFilters refreshFlag )
        {
            switch ( refreshFlag )
            {
                case enFilters.firstName:
                    dgvAllPeopleList.DataSource = clsPeople.FindPeopleByFirstName( txtFilter.Text );
                    break;
                case enFilters.secondName:
                    dgvAllPeopleList.DataSource = clsPeople.FindPeopleBySecondName( txtFilter.Text );
                    break;
                case enFilters.thirdName:
                    dgvAllPeopleList.DataSource = clsPeople.FindPeopleByThirdName( txtFilter.Text );
                    break;
                case enFilters.lastName:
                    dgvAllPeopleList.DataSource = clsPeople.FindPeopleByLastName( txtFilter.Text );
                    break;
                case enFilters.email:
                    dgvAllPeopleList.DataSource = clsPeople.FindPeopleByEmail( txtFilter.Text );
                    break;
                case enFilters.phone:
                    dgvAllPeopleList.DataSource = clsPeople.FindPeopleByPhone( txtFilter.Text );
                    break;
                case enFilters.nationalNO:
                    dgvAllPeopleList.DataSource = clsPeople.FindPeopleByNationalNO( txtFilter.Text );
                    break;
                case enFilters.gendor:
                    dgvAllPeopleList.DataSource = clsPeople.FindPeopleByGendor( txtFilter.Text );
                    break;
                case enFilters.ID:
                    dgvAllPeopleList.DataSource = clsPeople.FindPeopleByID( txtFilter.Text );
                    break;
                case enFilters.all:
                    dgvAllPeopleList.DataSource = clsPeople.AllPeopleList();
                    break;
            }

        }
        public frmAllPeople()
        {
            InitializeComponent();
        }

        private void frmAllPeople_Load( object sender, System.EventArgs e )
        {
            RefreshAllPeopleList( enFilters.all );
            lblRecords.Text = clsPeople.TotalPeople().ToString();
        }

        private void btnAddPerson_Click( object sender, System.EventArgs e )
        {
            addEditForm = new frmAddEditPerson( -1 );
            addEditForm.ShowDialog();
            RefreshAllPeopleList( enFilters.all );
        }

        private void eDITToolStripMenuItem_Click( object sender, System.EventArgs e )
        {
            addEditForm = new frmAddEditPerson( ( int ) dgvAllPeopleList.CurrentRow.Cells[ 0 ].Value );
            addEditForm.ShowDialog();
            RefreshAllPeopleList( enFilters.all );
        }

        private void dELETEToolStripMenuItem_Click( object sender, System.EventArgs e )
        {
            if ( MessageBox.Show( "Are You Sure You Want To Delete ( " + dgvAllPeopleList.CurrentRow.Cells[ 2 ].Value + " " + dgvAllPeopleList.CurrentRow.Cells[ 5 ].Value + " )", "Confirm Delete", MessageBoxButtons.OKCancel ) == DialogResult.OK )
            {


                if ( clsPeople.DeletePerson( ( int ) dgvAllPeopleList.CurrentRow.Cells[ 0 ].Value ) )
                {
                    MessageBox.Show( "Contact Deleted Successfully.." );
                    RefreshAllPeopleList( enFilters.all );
                }
                else
                {
                    MessageBox.Show( "Contact Is Not Deleted Because It Is Related With other Applications..", "", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
        }

        private void btnClose_Click( object sender, System.EventArgs e )
        {
            this.Close();
        }

        private void aDDNEWPERSONToolStripMenuItem_Click( object sender, System.EventArgs e )
        {
            addEditForm = new frmAddEditPerson( -1 );
            addEditForm.ShowDialog();
            RefreshAllPeopleList( enFilters.all );
        }

        private void sENDEMAILToolStripMenuItem_Click( object sender, System.EventArgs e )
        {
            MessageBox.Show( "PLACE HOLDER FOR SENDING EMAIL CODE.." );
        }

        private void pHONECALLToolStripMenuItem_Click( object sender, System.EventArgs e )
        {
            MessageBox.Show( "PLACE HOLDER UNTIL CALLING PHONES CODE.." );
        }

        private void sHOWDETAILSToolStripMenuItem_Click( object sender, System.EventArgs e )
        {
            frmShowPersonDetails personDetailsForm = new frmShowPersonDetails( ( int ) dgvAllPeopleList.CurrentRow.Cells[ 0 ].Value );
            personDetailsForm.ShowDialog();
        }

        private void txtFilter_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( cbxFilters.SelectedIndex == ( int ) enFilters.phone || cbxFilters.SelectedIndex == ( int ) enFilters.ID || cbxFilters.SelectedIndex == ( int ) enFilters.gendor )
            {
                if ( !char.IsNumber( e.KeyChar ) )
                {
                    e.Handled = e.KeyChar != ( Char ) Keys.Back;
                }
            }
            RefreshAllPeopleList( ( enFilters ) cbxFilters.SelectedIndex );
        }

        private void txtFilter_TextChanged( object sender, EventArgs e )
        {
            RefreshAllPeopleList( ( enFilters ) cbxFilters.SelectedIndex );
        }
    }
}
