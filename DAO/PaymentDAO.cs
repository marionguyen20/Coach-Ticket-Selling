using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSelling.DAO
{
    public class PaymentDAO
    {
        private static PaymentDAO instance;

        public static PaymentDAO Instance 
        { 
            get { if (instance == null) instance = new PaymentDAO(); return instance; }
            private set { instance = value; } 
        }

        private PaymentDAO () { }

        //Insert Payment
        public void InsertPayment (string name, string bank, string cardNumber, string cardType, string idTicket)
        {
            string query = "USP_InsertPayment @Name , @Bank , @CardNum , @CardType , @idTicket ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, bank, cardNumber, cardType, idTicket });
        }

        //GetIDTicet
        public DataTable GetIDTicket ()
        {
            string query = "USP_maxIdTicket";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        //Update Seat
        public void UpdateSeat (string idTrip)
        {
            string query = "USP_updateSeat @idTrip ";
            DataProvider.Instance.ExecuteNonQuery (query, new object[]{ idTrip});
        }

        //Load Ticket
        public DataTable LoadTicket (string idTicket)
        {
            string query = "USP_LoadTicket @idTicket ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idTicket});
            
        }
    }
}
