using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DoggyMotelSys
{
    class Reservations
    {
        int RES_ID, KENNEL_ID, DOG_ID, RES_COST;
        string RES_STATUS;
        DateTime ARRIVAL_TIME, DEPARTURE_TIME;

        public Reservations()
        {
            RES_ID = 0;
            KENNEL_ID = 0;
            DOG_ID = 0;
            RES_COST = 0;
            RES_STATUS = "";
            
            
        }
        public void setResID(int RES_ID)
        {
            this.RES_ID = RES_ID;
        }
        public void setKennelID(int KENNEL_ID)
        {
            this.KENNEL_ID = KENNEL_ID;
        }
        public void setDogID(int DOG_ID)
        {
            this.DOG_ID = DOG_ID;
        }
        public void setCost(int RES_COST)
        {
            this.RES_COST = RES_COST;
        }
        public void setStatus(string RES_STATUS)
        {
            this.RES_STATUS = RES_STATUS;
        }
        public void setArrivalTime(DateTime ARRIVAL_TIME)
        {
            this.ARRIVAL_TIME = ARRIVAL_TIME;
        }
        public void setDeparureTime(DateTime DEPARTURE_TIME)
        {
            this.DEPARTURE_TIME = DEPARTURE_TIME;
        }
        public int getResID()
        {
            return RES_ID;
        }
        public int getKennelID()
        {
            return KENNEL_ID;
        }
        public int getDogID()
        {
            return DOG_ID;
        }
        public int getCost()
        {
            return RES_COST;
        }
        public string getStatus()
        {
            return RES_STATUS;
        }
        public DateTime getArrivalTime()
        {
            return ARRIVAL_TIME;
        }
        public DateTime getDepartureTime()
        {
            return DEPARTURE_TIME;
        }
        
        public static DataSet getAllResID(DataSet DS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String strSQL = "SELECT * FROM RESERVATIONS";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(DS, "res");
            conn.Close();
            return DS;
        }
    }
}
