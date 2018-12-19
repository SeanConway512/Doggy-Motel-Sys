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
    public partial class frmKennelAdd : Form
    {
        frmMainMenu parent;
        public frmKennelAdd()
        {
            InitializeComponent();
        }
        
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnKennelID_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KennelID","KennelID",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnKennelType_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kennel Type", "Kennel Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmKennelAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
