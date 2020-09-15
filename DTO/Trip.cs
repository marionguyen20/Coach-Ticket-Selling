using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSelling.DTO
{
    public class Trip
    {
        private string source;
        private string destination;
        private string date;
        private string startTime;
        private string arrivalTime;
        private string duration;
        private int totalSeat;
        private int availableSeat;
        private int price;
        private float discount;
        private string idTrip;
        private string idDriver;
        private string idMana;

        public string Source { get => source; set => source = value; }
        public string Destination { get => destination; set => destination = value; }
        public string Date { get => date; set => date = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public string ArrivalTime { get => arrivalTime; set => arrivalTime = value; }
        public int TotalSeat { get => totalSeat; set => totalSeat = value; }
        public int AvailableSeat { get => availableSeat; set => availableSeat = value; }
        public int Price { get => price; set => price = value; }
        public float Discount { get => discount; set => discount = value; }
        public string Duration { get => duration; set => duration = value; }
        public string IdTrip { get => idTrip; set => idTrip = value; }
        public string IdUser { get => idDriver; set => idDriver = value; }
        public string IdMana { get => idMana; set => idMana = value; }

        //Constructor
        public Trip(string source, string destination, string date, string startTime, string arrivalTime, string duration, int totalSeat, int availableSeat, int price, float discount, string idTrip, string idDriver, string idMana)
        {
            this.source = source;
            this.destination = destination;
            this.date = date;
            this.startTime = startTime;
            this.arrivalTime = arrivalTime;
            this.duration = duration;
            this.totalSeat = totalSeat;
            this.availableSeat = availableSeat;
            this.price = price;
            this.discount = discount;
            this.idTrip = idTrip;
            this.idDriver = idDriver;
            this.idMana = idMana;
        }

        //Get data from column
        public Trip (DataRow row)
        {
            this.source = row["Source"].ToString();
            this.destination = row["Destination"].ToString();
            this.date =  ((DateTime) row["Date_Trip"]).ToString("dd-MM-yyyy");
            this.startTime =  row["Start_Time"].ToString();
            this.arrivalTime = row["Arrival_Time"].ToString();
            this.duration = row["Duration"].ToString();
            this.totalSeat = (int) row["Total_Seat"];
            this.availableSeat = (int) row["Available_Seat"];
            this.price = (int) row["Price"];
            this.discount = (float) Convert.ToDouble( row["Discount"]);
            this.idTrip = row["ID_Trip"].ToString();
            this.idDriver = row["ID_Driver"].ToString();
            this.idMana = row["ID_Manager"].ToString();

        }
    }
}
