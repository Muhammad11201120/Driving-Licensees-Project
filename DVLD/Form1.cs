using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pEOPLEToolStripMenuItem_Click( object sender, EventArgs e )
        {
            frmAllPeople frmShowAllPeople = new frmAllPeople();
            frmShowAllPeople.ShowDialog();
        }
    }
}
