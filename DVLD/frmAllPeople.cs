using DVLD_BusinessLayer;
using System.Windows.Forms;
namespace DVLD
{
    public partial class frmAllPeople : Form
    {
        private void RefreshAllPeopleList()
        {
            dgvAllPeopleList.DataSource = clsPeople.AllPeopleList();
        }
        public frmAllPeople()
        {
            InitializeComponent();
        }

        private void frmAllPeople_Load( object sender, System.EventArgs e )
        {
            RefreshAllPeopleList();
        }

        private void btnAddPerson_Click( object sender, System.EventArgs e )
        {
            frmAddEditPerson addEditForm = new frmAddEditPerson( -1 );
            addEditForm.ShowDialog();
            RefreshAllPeopleList();
        }

        private void eDITToolStripMenuItem_Click( object sender, System.EventArgs e )
        {
            frmAddEditPerson frmEdit = new frmAddEditPerson( ( int ) dgvAllPeopleList.CurrentRow.Cells[ 0 ].Value );
            frmEdit.ShowDialog();
            RefreshAllPeopleList();
        }

        private void dELETEToolStripMenuItem_Click( object sender, System.EventArgs e )
        {
            if ( MessageBox.Show( "Are You Sure You Want To Delete ( " + dgvAllPeopleList.CurrentRow.Cells[ 2 ].Value + " " + dgvAllPeopleList.CurrentRow.Cells[ 5 ].Value + " )", "Confirm Delete", MessageBoxButtons.OKCancel ) == DialogResult.OK )
            {


                if ( clsPeople.DeletePerson( ( int ) dgvAllPeopleList.CurrentRow.Cells[ 0 ].Value ) )
                {
                    MessageBox.Show( "Contact Deleted Successfully.." );
                    RefreshAllPeopleList();
                }
                else
                {
                    MessageBox.Show( "Contact Is Not Deleted.." );
                }
            }
        }
    }
}
