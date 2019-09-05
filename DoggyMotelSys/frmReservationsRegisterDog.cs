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
    public partial class frmReservationsRegisterDog : Form
    {
        frmMainMenu parent;
        Random r = new Random();
        Customer customer = new Customer();
        Dog dog = new Dog();
        DataSet ds = new DataSet();
        String DogName, Breed, MedicalCond;
        int Dogid;




        public frmReservationsRegisterDog()
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

        private void button1_Click(object sender, EventArgs e)
        {

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            int DogID = r.Next(1000, 9999);
            textBox5.Text = DogID.ToString();

            String strSQL = "INSERT INTO DOGS VALUES(" + this.textBox1 + this.textBox2 + this.textBox3 + this.textBox4 + this.textBox5 + ")";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

        private void frmReservationsRegisterDog_Load(object sender, EventArgs e)
        {

        }
    }
}
