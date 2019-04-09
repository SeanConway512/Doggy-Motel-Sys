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
    public partial class frmReservationsRegisterCustomer : Form
    {
        frmMainMenu parent;
        public frmReservationsRegisterCustomer()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuSetType_Click(object sender, EventArgs e)
        {
            frmKennelType nextForm = new frmKennelType();

            this.Hide();
            nextForm.Show();
        }

        private void mnuKennelAdd_Click(object sender, EventArgs e)
        {
            frmKennelAdd nextForm = new frmKennelAdd();

            this.Hide();
            nextForm.Show();
        }

        private void updateKennelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKennelUpdate nextForm = new frmKennelUpdate();
            this.Hide();
            nextForm.Show();
        }

        private void removeKennelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKennelRemove nextForm = new frmKennelRemove();
            this.Hide();
            nextForm.Show();
        }

        private void registerCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservationsRegisterCustomer nextForm = new frmReservationsRegisterCustomer();
            this.Hide();
            nextForm.Show();
        }

        private void registerDogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservationsRegisterDog nextForm = new frmReservationsRegisterDog();
            this.Hide();
            nextForm.Show();
        }

        private void makeReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservationsMakeReservation nextForm = new frmReservationsMakeReservation();
            this.Hide();
            nextForm.Show();
        }

        private void cancelReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservationsCancelReservation nextForm = new frmReservationsCancelReservation();
            this.Hide();
            nextForm.Show();
        }

        private void registerArrivalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminRegisterArrival nextForm = new frmAdminRegisterArrival();
            this.Hide();
            nextForm.Show();
        }

        private void registerDepartureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminRegisterDeparture nextForm = new frmAdminRegisterDeparture();
            this.Hide();
            nextForm.Show();
        }

        private void revenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminRevenueAnalysis nextForm = new frmAdminRevenueAnalysis();
            this.Hide();
            nextForm.Show();
        }

        private void kennelAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminKennelAnalysis nextForm = new frmAdminKennelAnalysis();
            this.Hide();
            nextForm.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
