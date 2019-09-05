using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DoggyMotelSys
{
    class Dog
    {
        int DOG_ID, CUST_ID;
        string DOG_NAME, DOG_BREED, DOG_MEDCOND, DOG_GENDER;

        public Dog()
        {
            DOG_ID = 0;
            CUST_ID = 0;
            DOG_NAME = "";
            DOG_BREED = "";
            DOG_MEDCOND = "";
            DOG_GENDER = "";
        }
        public void setDogID(int DOG_ID)
        {
            this.DOG_ID = DOG_ID;
        }
        public void setCustID(int CUST_ID)
        {
            this.CUST_ID = CUST_ID;
        }
        public void setName(string DOG_NAME)
        {
            this.DOG_NAME = DOG_NAME;
        }
        public void setBreed(string DOG_BREED)
        {
            this.DOG_BREED = DOG_BREED;
        }
        public void setMedCond(string DOG_MEDCOND)
        {
            this.DOG_MEDCOND = DOG_MEDCOND;
        }
        public void setGender(string DOG_GENDER)
        {
            this.DOG_GENDER = DOG_GENDER;
        }


        public int getDogID(int DOG_ID)
        {
            return DOG_ID;
        }
        public int getCustID(int CUST_ID)
        {
            return CUST_ID;
        }
        public string getName(string DOG_NAME)
        {
            return DOG_NAME;
        }
        public string getBreed(string DOG_BREED)
        {
            return DOG_BREED;
        }
        public string getMedCond(string DOG_MEDCOND)
        {
            return DOG_MEDCOND;
        }
        public string getGender(string DOG_GENDER)
        {
            return DOG_GENDER;
        }

        public static DataSet getAllDogID(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String strSQL = "SELECT * FROM DOGS";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(DS, "dog");
            conn.Close();
            return DS;

        }
    }
}
