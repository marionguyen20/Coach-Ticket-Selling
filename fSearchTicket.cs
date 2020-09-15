using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.DAO;
using TicketSelling.DTO;

namespace TicketSelling
{
    public partial class fSearchTicket : Form
    {
       
        
        public fSearchTicket()
        {
            InitializeComponent();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            flLayoutTicket.Controls.Clear();
            string idTicket = tbIDTicket.Text;

            
            if (CheckIDTicket(idTicket))
            {
                LoadTicket(idTicket);
            } else
            {
                MessageBox.Show("Wrong ID Ticket!!");
            }
            
        }

        //Load Ticket
        void LoadTicket (string idTicket)
        {
            Ticket ticket = new Ticket (PaymentDAO.Instance.LoadTicket(idTicket).Rows[0]);
            Trip trip = TicketDAO.Instance.loadTrip(ticket.IdTrip);
            string name = TicketDAO.Instance.LoadName(ticket.IdUser).Rows[0].ItemArray[0] + " " + TicketDAO.Instance.LoadName(ticket.IdUser).Rows[0].ItemArray[1];
 
            int newSize = 14;
            Button btn = new Button { Width = 300, Height = 500 };
            btn.Font = new Font(btn.Font.OriginalFontName, newSize);
            btn.TextAlign = ContentAlignment.MiddleLeft;

            btn.Text = "ID Ticket: " + ticket.IdTicket + Environment.NewLine + Environment.NewLine +"Name: " + name +Environment.NewLine + Environment.NewLine + "Source: " + trip.Source + Environment.NewLine + Environment.NewLine + "Destination: " + trip.Destination + Environment.NewLine + Environment.NewLine + "Start Day: " + trip.Date
                + Environment.NewLine + Environment.NewLine + "Start time: " + trip.StartTime + "   -   " + trip.ArrivalTime + Environment.NewLine + Environment.NewLine + "Duration: " + trip.Duration + Environment.NewLine + Environment.NewLine
                + "Discount: " + trip.Discount + "%" + Environment.NewLine + Environment.NewLine + "Total Price: " + /*(trip.Price - trip.Price * trip.Discount/100)*/ ticket.TotalPrice + "£" + Environment.NewLine + Environment.NewLine + "Seat Number: " + ticket.SeatNumber;

            flLayoutTicket.Controls.Add(btn);
        }

        //Check ID
        bool CheckIDTicket (string idTicket)
        {
            DataTable data = PaymentDAO.Instance.LoadTicket(idTicket);
            int result = data.Rows.Count;
            return result > 0 ;
        }
    }
}
