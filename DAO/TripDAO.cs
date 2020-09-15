using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSelling.DTO;

namespace TicketSelling.DAO
{
    public class TripDAO
    {
        private static TripDAO instance;

        public static TripDAO Instance 
        {
            get { if (instance == null) instance = new TripDAO(); return instance; }
            private set { instance = value; }
        }

        private TripDAO () { }

        //Load Source
        public DataTable LoadSource ()
        {
            //Create the query
            string query = "SELECT DISTINCT Source FROM dbo.TRIP";

            return DataProvider.Instance.ExecuteQuery(query);

        }

        public static int TripWidth = 400;
        public static int TripHeight = 200;

        //Load Destination
        public DataTable LoadDestination ()
        {
            //Create the query
            string query = "SELECT DISTINCT Destination FROM dbo.TRIP";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        //Load Trip List
        public List<Trip> LoadTripList(string source, string destination, DateTime date)
        {
            List<Trip> tripList = new List<Trip>();

            //Load table trip data
            string query = "USP_loadTrip @source , @destination , @date ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { source, destination, date });

            //Add trip into List Trip
            foreach (DataRow item in data.Rows)
            {
                Trip trip = new Trip(item);
                tripList.Add(trip);
            }

            return tripList;
        }

        //Load total Trip
        public List<Trip> LoadTotalTrip ()
        {
            List<Trip> triplist = new List<Trip>();

            //Load table trip data
            string query = "SELECT* FROM dbo.TRIP WHERE Date_Trip >= GETDATE() ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            //Add trip into List Trip
            foreach (DataRow item in data.Rows)
            {
                Trip trip = new Trip(item);
                triplist.Add(trip);
            }

            return triplist;
        }
    }
}
