using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Collections;

namespace DoggyMotelSys
{
    public partial class frmReservationsRegisterCustomer : Form
    {
        public frmMainMenu parent;
        Random r = new Random();
        Customer customer = new Customer();
        DataSet ds = new DataSet();
        int telephone, custid;
        String fullname, email;
        ArrayList customers = new ArrayList();
       



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

        private void frmReservationsRegisterCustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(Name, "^[A-Z][a-zA-z]*$").Success)
            {
                Console.WriteLine("Invalid Name");
            }
            else
            {
                Console.WriteLine("Name");
               fullname = Console.ReadLine();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            int CustomerID = r.Next(1000,9999);
            textBox4.Text = CustomerID.ToString();

            String strSQL = "INSERT INTO CUSTOMER VALUES(" + this.textBox1 + this.textBox2 + this.textBox3 + this.textBox4 + "')";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Email: ");
            email = Console.ReadLine();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("phone number: ");
            int telephone = Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
