using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.DAO;
using TicketSelling.DTO;

namespace TicketSelling
{
    public partial class fTicketUser : Form
    {
        private int numTicket;
        private string idTrip;
        private string idUser;
        private List<Ticket> tickets;

        public fTicketUser(int numTicket, string idTrip, string idUser, List<Ticket> tickets)
        {
            InitializeComponent();
            this.numTicket = numTicket;
            this.idTrip = idTrip;
            this.idUser = idUser;
            this.tickets = tickets;

            //Load Ticket
            LoadTicket(this.idTrip, this.tickets);
        }

        //Load User Ticket
        void LoadTicket (string idTrip, List<Ticket> tickets)
        {
            Trip trip = TicketDAO.Instance.loadTrip(idTrip);
            List<Ticket> listTicket = tickets;

            for (int i = 0; i < this.numTicket; i++)
            {
                int newSize = 14;
                Button btn = new Button { Width = 300, Height = 500 };
                btn.Font = new Font(btn.Font.OriginalFontName, newSize);
                btn.TextAlign = ContentAlignment.MiddleLeft;

                btn.Text = "ID Ticket: " + listTicket[i].IdTicket + Environment.NewLine + Environment.NewLine + getName(this.idUser)+ Environment.NewLine + Environment.NewLine + "Source: " + trip.Source + Environment.NewLine + Environment.NewLine + "Destination: " + trip.Destination + Environment.NewLine + Environment.NewLine + "Start Day: " + trip.Date
                    + Environment.NewLine + Environment.NewLine + "Start time: " + trip.StartTime + "   -   " + trip.ArrivalTime + Environment.NewLine + Environment.NewLine + "Duration: " + trip.Duration + Environment.NewLine + Environment.NewLine 
                    + "Discount: " + trip.Discount + "%" + Environment.NewLine  + Environment.NewLine + "Total Price: " + (trip.Price - trip.Price * trip.Discount/100) + "£" + Environment.NewLine + Environment.NewLine + "Seat Number: " + listTicket[i].SeatNumber;

                fllayoutTicket.Controls.Add(btn);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            fUserFrame fUserFrame = new fUserFrame(idUser);
            fUserFrame.ShowDialog();
            Environment.Exit(0);
            //this.Close();
            
        }

        //Get name
        string getName(string idUser)
        {
            DataTable result = TicketDAO.Instance.LoadName(idUser);
            return (result.Rows[0].ItemArray[0] + " " + result.Rows[0].ItemArray[1]);
        }
    }
}
