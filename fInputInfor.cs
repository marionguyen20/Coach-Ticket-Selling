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

namespace TicketSelling
{
    public partial class fInputInfor : Form
    {
        private string idTrip;
        private string idUser;
        private int numTicket;
        private int numSeat;
        private List<int> seat = new List<int>();
        private bool control = false;
        private int count = 0;
        private List<Button> listButton = new List<Button>();
        private int same = 0;
 

        public fInputInfor(string idTrip, string idUser, int numTicket)
        {
            InitializeComponent();
            this.idTrip = idTrip;
            this.idUser = idUser;
            this.numTicket = numTicket;

            LoadSeat(this.idTrip);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e) 
        {

            this.control = true;
            this.numSeat = (int) (sender as Button).Tag;
            listButton.Add(sender as Button);

            listButton[listButton.Count - 1].BackColor = Color.Red;
            if (listButton.Count > 1)
            {

                if (listButton[listButton.Count - 2].Equals(listButton[listButton.Count - 1]))
                {
                    same++;
                    if (same % 2 != 0) listButton[listButton.Count - 2].BackColor = Color.Gainsboro;


                }
                else
                {
                    listButton[listButton.Count - 2].BackColor = Color.Gainsboro;
                    same = 0;
                }
      

            }
 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Get list of booked seats
            List<int> list = SeatDAO.Instance.LoadBookedSeat(idTrip); 
            
            //Choose ticket and check condition
            if (control && (this.count < numTicket))
            {
                if (!list.Contains(numSeat) && !seat.Contains(numSeat))
                {
                    this.count++;
                    MessageBox.Show("Choose Successfully!\nTicket " + count.ToString() + " Number is: " + numSeat.ToString());
                    seat.Add(this.numSeat);
                    control = false;
                    listButton = new List<Button>();
                    same = 0;

                } else
                {

                    MessageBox.Show("Ticket number: " + numSeat.ToString() + " is canceled ");
                    seat.Remove(this.numSeat);
                    this.count--;
                    control = false;
                    listButton = new List<Button>();
                    same = 0;
                }
            }

            //Mark ticket is booked
            foreach (Control c in flowLayoutSeat.Controls.OfType<Button>())
            {
                string temp = c.ToString().Substring(35, 2);
                int a = Int32.Parse(temp);
                if (seat.Contains(a)) c.BackColor = Color.Red; else if (!list.Contains(a)) c.BackColor =Color.Gainsboro;
            }

            //Move next form
            if (this.count == numTicket)
            {
                fConfirm fConfirm = new fConfirm(this.idTrip, this.idUser, this.seat);
                this.Hide();
                fConfirm.ShowDialog();
                //this.Show();
                control = false;
            }
                      
        }

        //Get Seat
        int getSeat (string idTrip)
        {
            DataTable result = SeatDAO.Instance.getSeat(idTrip);
            return (int)(result.Rows[0].ItemArray[0]);
        }

        //Load Seat
        void LoadSeat(string idTrip)
        {
            List<int> list = SeatDAO.Instance.LoadBookedSeat(idTrip);

            for (int i = 1; i <= getSeat(idTrip); i++)
            {
                int newSize = 11; string status = "Available";
                Button btn = new Button { Width = 80, Height = 80 };
                if (list.Contains(i))
                {
                    btn.BackColor = Color.Aqua;
                    status = "Booked";
                    btn.Font = new Font(btn.Font.OriginalFontName, newSize);
                    btn.Text = i.ToString() + Environment.NewLine + status;
                } else
                {
                    btn.Font = new Font(btn.Font.OriginalFontName, newSize);
                    btn.Text = i.ToString() + Environment.NewLine + status;

                    btn.Click += btn_Click;     //Create event Click of button
                    btn.Tag = i;                //Assign value to button
                }


                flowLayoutSeat.Controls.Add(btn);
            }
        }


    }
}
