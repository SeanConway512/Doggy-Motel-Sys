using Oracle.ManagedDataAccess.Client;
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
    public partial class frmAdminRevenueAnalysis : Form
    {
        frmMainMenu parent;
        DataSet ds = new DataSet();

        public frmAdminRevenueAnalysis()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            String strSQL = "SELECT SUM(Sale_Value), to_Char(Sale_Date,'MM') FROM Sales GROUP BY to_Char(Sale_Date,'MM') ORDER char(Sale_Date,'MM')";
            DataTable dt = new DataTable();

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(dt); myConn.Close();

            string[] N = new string[dt.Rows.Count];
            decimal[] M = new decimal[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                N[i] = getMonth(Convert.ToInt32(dt.Rows[i][1]));
                M[i] = Convert.ToDecimal(dt.Rows[i][0]);
            }
        }

        private String getMonth(int month)
        {
            switch (month)
            {
                case 1:
                    {
                        return "JAN";

                    }
                case 2:
                    {
                        return "FEB";

                    }
                case 3:
                    {
                        return "MAR";

                    }
                case 4:
                    {
                        return "APR";

                    }
                case 5:
                    {
                        return "MAY";
                    }
                case 6:
                    {
                        return "JUN";
                    }
                case 7:
                    {
                        return "JUL";
                    }
                case 8:
                    {
                        return "AUG";
                    }
                case 9:
                    {
                        return "SEP";
                    }
                case 10:
                    {
                        return "OCT";
                    }
                case 11:
                    {
                        return "NOV";
                    }
                case 12:
                    {
                        return "DEC";
                    }

            }
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

        private void frmAdminRevenueAnalysis_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String strSQL = "SELECT StockNo,Description FROM Stock ORDER BY StockNo";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
