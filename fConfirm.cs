using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.DAO;
using TicketSelling.DTO;

namespace TicketSelling
{
    public partial class fConfirm : Form
    {
        private string idTrip;
        private string idUser;
        private List<int> seat = new List<int>();
        private float totalprice = 0;

        public fConfirm(string idTrip, string idUser, List<int> seat) 
        {
            InitializeComponent();
            this.idTrip = idTrip;
            this.idUser = idUser;
            this.seat = seat;

            LoadTicket(this.idTrip, this.idUser);
        }

        private void btnCf_Click(object sender, EventArgs e)
        {
            fPayment fPayment = new fPayment(this.idTrip, this.idUser, this.seat, this.totalprice);
            this.Hide();
            fPayment.ShowDialog();
            this.Show();
        }

        //GetName
        string getName (string idUser)
        {
            DataTable result = TicketDAO.Instance.LoadName(idUser);
            return (result.Rows[0].ItemArray[0] + " " + result.Rows[0].ItemArray[1]);
        }

        //Load Ticket
        void LoadTicket (string idTrip, string idUser)
        {
            Trip trip = TicketDAO.Instance.loadTrip(idTrip);
            string name = getName(idUser);
            
            for(int i = 0; i < seat.Count; i++)
            {
                int newSize = 14;
                Button btn = new Button { Width = 300, Height = 500 };
                btn.Font = new Font(btn.Font.OriginalFontName, newSize);
                btn.TextAlign = ContentAlignment.MiddleLeft;

                btn.Text = "Full Name: " + name + Environment.NewLine + Environment.NewLine + "Source: " + trip.Source + Environment.NewLine + Environment.NewLine + "Destination: " + trip.Destination + Environment.NewLine + Environment.NewLine + "Date: " + trip.Date + Environment.NewLine + Environment.NewLine + "Time: " + trip.StartTime +
                    "   -   " + trip.ArrivalTime + Environment.NewLine + Environment.NewLine + "Duration: " + trip.Duration + Environment.NewLine + Environment.NewLine + "Discount: " + trip.Discount + "%" + Environment.NewLine + Environment.NewLine + 
                    "Total Price: " + (trip.Price - trip.Price*trip.Discount/100) + "£" + Environment.NewLine + Environment.NewLine + "Seat Number: " + seat[i].ToString();

                flowLayoutTicket.Controls.Add(btn);
                this.totalprice += (trip.Price - trip.Price * trip.Discount / 100);
            }

            CultureInfo culture = new CultureInfo("en-GB");
            Thread.CurrentThread.CurrentCulture = culture;
            tbPrice.Text = this.totalprice.ToString("c");

        }
    }
}
