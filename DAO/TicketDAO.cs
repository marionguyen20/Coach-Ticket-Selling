using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSelling.DTO;

namespace TicketSelling.DAO
{
    public class TicketDAO
    {
        private static TicketDAO instance;

        public static TicketDAO Instance
        {
            get { if (instance == null) instance = new TicketDAO(); return instance; }
            private set { instance = value; }
        }

        private TicketDAO() { }

        //Load Full Name
        public DataTable LoadName (string idUser)
        {
            string query = "USP_getName @idUser ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idUser });

            return data;
        }

        //Load Trip Infor
        public Trip loadTrip (string idTrip)
        {
            string query = "USP_loadTripUser @idTrip ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idTrip });

            return new Trip(data.Rows[0]);
        }

        //Insert Ticket
        public void InsertTicket (int seatNumber, float totalPrice, string idUser, string idTrip)
        {
            string query = "USP_InsertTicket @seatNumber , @totalPrice , @idUser , @idTrip ";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] {seatNumber, totalPrice, idUser, idTrip });
        }

        //Get total Price
        public float TotalPrice (string idTrip)
        {
            Trip trip = loadTrip(idTrip);
            return (trip.Price - trip.Price * (trip.Discount/100));
        }

    }
}
