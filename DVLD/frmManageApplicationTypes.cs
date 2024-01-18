using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManageApplicationTypes : Form
    {

        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }
        private void refreshList()
        {
            dataGridView1.DataSource = clsApplicationTypes.GetAllApplicationTypes();
        }
        private void frmManageApplicationTypes_Load( object sender, EventArgs e )
        {
            refreshList();
        }

        private void eDITToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmEditApplicationTypes form = new frmEditApplicationTypes( ( int ) dataGridView1.CurrentRow.Cells[ 0 ].Value );
            form.ShowDialog();
            refreshList();
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
