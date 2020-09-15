using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace TicketSelling.DAO
{
    public class SeatDAO
    {
        private static SeatDAO instance;

        public static SeatDAO Instance
        {
            get { if (instance == null) instance = new SeatDAO(); return instance; }
            private set { instance = value; }
        }

        private SeatDAO() { }

        //Get Seat
        public DataTable getSeat (string idTrip)
        {
            string query = "USP_getSeat @idTrip ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idTrip });
            return data;
        }

        //Load Booked Seat
        public List<int> LoadBookedSeat (string idTrip)
        {
            List<int> listBookedSeat = new List<int>();

            //Load data
            string query = " USP_getListSeat @idTrip ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idTrip });
            for (int idx = 0; idx < data.Rows.Count; idx ++)
            {
                int seat = (int) data.Rows[idx].ItemArray[0];
                listBookedSeat.Add(seat);
            }

            return listBookedSeat;
            
        }

    }
}
