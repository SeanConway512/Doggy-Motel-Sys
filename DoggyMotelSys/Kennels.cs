using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DoggyMotelSys
{
    class Kennels
    {
        int KENNEL_ID;
        string KENNEL_TYPE, KENNEL_STATUS;

        public Kennels()
        {
            KENNEL_ID = 0;
            KENNEL_TYPE = "";
            KENNEL_STATUS = "";
        }
        public void setKennelID(int KENNEL_ID)
        {
            this.KENNEL_ID = KENNEL_ID;
        }
        public void setType(string KENNEL_TYPE)
        {
            this.KENNEL_TYPE = KENNEL_TYPE;
        }
        public void setStatus(string KENNEL_STATUS)
        {
            this.KENNEL_STATUS = KENNEL_STATUS;
        }
        public int getKennelID()
        {
            return KENNEL_ID;
        }
        public string getType()
        {
            return KENNEL_TYPE;
        }
        public string getStatus()
        {
            return KENNEL_STATUS;
        }
        public static DataSet getAllKennels(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String strSQL = "SELECT * FROM KENNELS";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(DS, "ken");
            conn.Close();
            return DS;
        }
    }
}
