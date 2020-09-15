using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.DAO;
using TicketSelling.DTO;

namespace TicketSelling
{
    public partial class fTrip : Form
    {
        private string idUser;

        public fTrip(string idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
            
            //Load Source
            loadSource();

            //Load Destination
            loadDestination();

            //Load suggest trip
            LoadTotalTrip();
        }
        private bool control = false;
        private string idTrip;
        private int numTicket;
        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get source, destination, date
            string source = cbSource.Text;
            string destinaiton = cbDes.Text;
            DateTime date = datePick.Value;

            //Refesh the trip list
            flTripList.Controls.Clear();

            //Check day valid
            if (date < DateTime.Today)
            {
                MessageBox.Show("The trip had been out of day!! Choose another trip! ");
            } else
            {
                loadTrip(source, destinaiton, date);
                if (flTripList.Controls.Count == 0) MessageBox.Show("There is no trip at this day!!");
                
            }

            this.control = false;

        }
        private void btnChoose_Click(object sender, EventArgs e)
        {  
            //Next form
            if (control)
            {
                
                this.numTicket = (int) numericTicket.Value;
                Trip trip = TicketDAO.Instance.loadTrip(this.idTrip);
                
                if (this.numTicket >  trip.AvailableSeat)
                {
                    MessageBox.Show("SORRY!! There is no enough ticket in this trip!.");
                    return;
                }
                    fInputInfor fInputInfor = new fInputInfor(this.idTrip, this.idUser, this.numTicket);
                this.Hide();
                fInputInfor.ShowDialog();
                this.control = false;
                this.Show();
            }

        }
        private void fTrip_Load(object sender, EventArgs e)
        {

        }
        private void btn_Click (object sender, EventArgs e)
        {
            this.idTrip = ((sender as Button).Tag as Trip).IdTrip.ToString();
            this.control = true;
        }

        //Load Source List
        void loadSource ()
        {
  
            //Get DataSource is all data
            cbSource.DataSource = TripDAO.Instance.LoadSource();

            //Display column Source
            cbSource.DisplayMember = "Source";
                       
        }

        //Load Destination List
        void loadDestination ()
        {
 
            //Get DataSource is all data
            cbDes.DataSource = TripDAO.Instance.LoadDestination();

            //Display column Destination
            cbDes.DisplayMember = "Destination";
        }

        //Load trip
        void loadTrip (string source, string destination, DateTime date)
        {
            List<Trip> tripList = TripDAO.Instance.LoadTripList(source, destination, date);
            
            //Add trip into button
            foreach (Trip item in tripList)
            {
                int newSize = 14;
                Button btn = new Button() { Width = TripDAO.TripWidth, Height = TripDAO.TripHeight };
                btn.Font = new Font(btn.Font.OriginalFontName, newSize);
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Text = "Source: " + item.Source + Environment.NewLine +"Destination: "+ item.Destination + Environment.NewLine + "Date: " + item.Date + Environment.NewLine + "Time: " + item.StartTime + 
                    "   -   " + item.ArrivalTime + Environment.NewLine + "Duration: " + item.Duration + Environment.NewLine + "Total Seat: " + item.TotalSeat + "     Available Seat: " + item.AvailableSeat + Environment.NewLine 
                    + "Price: " + item.Price + "£" + Environment.NewLine + "Discount: " + item.Discount + "%";

                btn.Click += btn_Click;
                btn.Tag = item;
                
                flTripList.Controls.Add(btn);
            }
        }

        //Load total trip
        void LoadTotalTrip()
        {
            List<Trip> tripList = TripDAO.Instance.LoadTotalTrip();

            //Add trip into button
            foreach (Trip item in tripList)
            {
                int newSize = 14;
                Button btn = new Button() { Width = TripDAO.TripWidth, Height = TripDAO.TripHeight };
                btn.Font = new Font(btn.Font.OriginalFontName, newSize);
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Text = "Source: " + item.Source + Environment.NewLine + "Destination: " + item.Destination + Environment.NewLine + "Date: " + item.Date + Environment.NewLine + "Time: " + item.StartTime +
                    "   -   " + item.ArrivalTime + Environment.NewLine + "Duration: " + item.Duration + Environment.NewLine + "Total Seat: " + item.TotalSeat + "     Available Seat: " + item.AvailableSeat + Environment.NewLine
                    + "Price: " + item.Price + "£" + Environment.NewLine + "Discount: " + item.Discount + "%";

                btn.Click += btn_Click;
                btn.Tag = item;

                flTripList.Controls.Add(btn);
            }
        }

        private void cbSource_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbDes_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
