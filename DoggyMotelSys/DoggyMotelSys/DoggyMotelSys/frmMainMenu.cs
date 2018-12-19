using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoggyMotelSys
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuSetType_Click(object sender, EventArgs e)
        {
            frmKennelType nextForm = new frmKennelType(this);

            this.Hide();
            nextForm.Show();
        }

        private void pocMainMenu_Click(object sender, EventArgs e)
        {

        }

        private void updateKennelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
