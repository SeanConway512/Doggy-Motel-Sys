using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DoggyMotelSys
{
    public partial class frmAdminRegisterDeparture : Form
    {
        frmMainMenu parent;
        DataSet ds = new DataSet();
        Reservations reservations = new Reservations();
        

        public frmAdminRegisterDeparture()
        {
            InitializeComponent();
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

        private void frmAdminRegisterDeparture_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String strSQL = "UPDATE RESERVATIONS,SET RES_STATUS ='Departed',WHERE RES_ID = " + this.textBox1;
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
