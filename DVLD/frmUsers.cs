using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmUsers : Form
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


        private void RefreshAllPeopleList( enFilters refreshFlag )
        {
            switch ( refreshFlag )
            {
                case enFilters.firstName:
                    dgvUsers.DataSource = clsPeople.FindPeopleByFirstName( txtFilter.Text );
                    break;
                case enFilters.secondName:
                    dgvUsers.DataSource = clsPeople.FindPeopleBySecondName( txtFilter.Text );
                    break;
                case enFilters.thirdName:
                    dgvUsers.DataSource = clsPeople.FindPeopleByThirdName( txtFilter.Text );
                    break;
                case enFilters.lastName:
                    dgvUsers.DataSource = clsPeople.FindPeopleByLastName( txtFilter.Text );
                    break;
                case enFilters.email:
                    dgvUsers.DataSource = clsPeople.FindPeopleByEmail( txtFilter.Text );
                    break;
                case enFilters.phone:
                    dgvUsers.DataSource = clsPeople.FindPeopleByPhone( txtFilter.Text );
                    break;
                case enFilters.nationalNO:
                    dgvUsers.DataSource = clsPeople.FindPeopleByNationalNO( txtFilter.Text );
                    break;
                case enFilters.gendor:
                    dgvUsers.DataSource = clsPeople.FindPeopleByGendor( txtFilter.Text );
                    break;
                case enFilters.ID:
                    dgvUsers.DataSource = clsPeople.FindPeopleByID( txtFilter.Text );
                    break;
                default:
                    dgvUsers.DataSource = clsPeople.AllPeopleList();
                    break;
            }

        }
        public void RefreshAllUsersList()
        {
            dgvUsers.DataSource = clsUsers.AllUsersList();
        }
        public frmUsers()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click( object sender, EventArgs e )
        {
            frmAddNewUser frmAddNewUser = new frmAddNewUser( -1 );
            frmAddNewUser.ShowDialog();
        }

        private void frmUsers_Load( object sender, EventArgs e )
        {
            RefreshAllUsersList();
            lblRecords.Text = clsUsers.TotalUsers().ToString();
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void eDITToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmAddNewUser addEditForm = new frmAddNewUser( ( int ) dgvUsers.CurrentRow.Cells[ 1 ].Value );
            addEditForm.ShowDialog();
            RefreshAllUsersList();
        }

        private void dELETEToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if ( MessageBox.Show( "Are You Sure You Want To Delete ( " + dgvUsers.CurrentRow.Cells[ 2 ].Value + " )", "Confirm Delete", MessageBoxButtons.OKCancel ) == DialogResult.OK )
            {


                if ( clsUsers.DeleteUser( ( int ) dgvUsers.CurrentRow.Cells[ 0 ].Value ) )
                {
                    MessageBox.Show( "User Deleted Successfully.." );
                    RefreshAllUsersList();
                }
                else
                {
                    MessageBox.Show( "User Is Not Deleted.." );
                }
            }
        }
    }
}
