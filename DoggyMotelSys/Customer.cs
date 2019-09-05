using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace DoggyMotelSys
{
    class Customer
    {
        int CUST_ID, CUST_PHONE;
        string CUST_NAME, CUST_EMAIL;

        public Customer()
        {
            CUST_ID = 00000;
            CUST_PHONE = 0000;
            CUST_NAME = "";
            CUST_EMAIL = "";
        }
        public void setCustID(int CUST_ID)
        {
            this.CUST_ID = CUST_ID;
        }
        public void setPhone(int CUST_PHONE)
        {
            this.CUST_PHONE = CUST_PHONE;
        }
        public void setName(string CUST_NAME)
        {
            this.CUST_NAME = CUST_NAME;
        }
        public void setEmail(string CUST_EMAIL)
        {
            this.CUST_EMAIL = CUST_EMAIL;
        }

        public int getCustID()
        {
            return CUST_ID;
        }
        public int getPhone()
        {
            return CUST_PHONE;
        }
        public string getName()
        {
            return CUST_NAME;
        }
        public string getEmail()
        {
            return CUST_EMAIL;
        }
        

        public static DataSet getAllCustID(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String strSQL = "SELECT * FROM CUSTOMERS";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(DS, "cust");
            conn.Close();
            return DS;
        }
    }
}
