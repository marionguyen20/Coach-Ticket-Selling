using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSelling.DTO
{
    public class Ticket
    {
        private string idTicket;
        private int seatNumber;
        private float totalPrice;
        private string idUser;
        private string idTrip;

        public string IdTrip { get => idTrip; set => idTrip = value; }
        public string IdUser { get => idUser; set => idUser = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int SeatNumber { get => seatNumber; set => seatNumber = value; }
        public string IdTicket { get => idTicket; set => idTicket = value; }

        //Constructor
        public Ticket (string idTicket, int seatNumber, float totalPrice, string idUser, string idTrip)
        {
            this.idTicket = idTicket;
            this.seatNumber = seatNumber;
            this.totalPrice = totalPrice;
            this.idUser = idUser;
            this.idTrip = idTrip;
        }

        //Get data from column
        public Ticket (DataRow row)
        {
            this.idTicket = row["ID_Ticket"].ToString();
            this.seatNumber = (int)row["Seat_Number"];
            this.totalPrice = (float)Convert.ToDouble(row["Total_Price"].ToString());
            this.idUser = row["ID_User"].ToString();
            this.idTrip = row["ID_Trip"].ToString();

        }
    }
}
