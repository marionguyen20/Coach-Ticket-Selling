using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.DAO;
using TicketSelling.DTO;

namespace TicketSelling
{
    public partial class fPayment : Form
    {
        private string idTrip;
        private string idUser;
        private List<int> seat = new List<int>();
        private List<TextBox> tbList = new List<TextBox>();
        private List<Label> lbList = new List<Label>();
        private float totalprice;
        private List<Ticket> tickets = new List<Ticket>();
        public fPayment(string idTrip, string idUser, List<int> seat, float totalprice)
        {
            InitializeComponent();

            this.idTrip = idTrip;
            this.idUser = idUser;
            this.seat = seat;
            this.totalprice = totalprice;

            init();
            LoadPrice(this.totalprice);
        }

        private void lbPay_Click(object sender, EventArgs e)
        {
            
        }
        private void tbCardNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Char is not CTRL or not number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string bank = tbBank.Text;
            string cardNumber = (tbCardNum.Text);
            string cardType = cbType.Text.ToString();

            foreach (int seatNum in seat)
            {
                bool blank = false;
                int index = 0;
                foreach (TextBox tb in tbList)
                {
                    if (IsBlank(tb, index++))
                    {
                        blank = true;
                    }
                    
                }

                if (cbType.SelectedItem == null)
                {
                    lbType.ForeColor = Color.Red;
                    MessageBox.Show("Please fills missing information");
                    blank = true;
                }
                if (blank) return;

                if (cardNumber.Count() > 20)
                {
                    MessageBox.Show("Invalid Card Number !!");
                    return;
                }

                //Transfer data to Ticket database
                InsertTicket(seatNum, TotalPrice(idTrip), idUser, idTrip);

                //Add to list ticket
                tickets.Add(LoadTicket(GetIDTicket()));

                //Transfer data to Payment database
                InsertPayment(name, bank, cardNumber, cardType, GetIDTicket());

                //Update available seat in trip database
                UpdateSeat(idTrip);
            }

            MessageBox.Show("Payment Successfull!!");
            fTicketUser fTicketUser = new fTicketUser(seat.Count,idTrip,idUser,tickets);
            this.Hide();
            fTicketUser.ShowDialog();
            this.Show();

        }
        //Load Textbox and label list
        private void init()
        {
            tbList = new List<TextBox>()
            {
                tbName, tbCardNum, tbBank
            };

            lbList = new List<Label>()
            {
                lbName, lbCardNum, lbBank
            };

        }
        //Check blank
        private Boolean IsBlank(TextBox t, int idx)
        {
            if (string.IsNullOrWhiteSpace(t.Text))
            {
                lbList[idx].ForeColor = Color.Red;
                MessageBox.Show(" Please fill the missing information");
                return true;
            }
            else
            {
                lbList[idx].ForeColor = Color.Black;
            }
            return false;
        }

        //Load Price
        void LoadPrice (float totalprice)
        {
            CultureInfo culture = new CultureInfo("en-GB");
            tbPrice.Text = totalprice.ToString("c",culture);
        }

        //Insert Ticket
        void InsertTicket (int seatNumber, float totalPrice, string idUser, string idTrip)
        {
            TicketDAO.Instance.InsertTicket(seatNumber, totalPrice, idUser, idTrip);
        }

        //Get TotalPrice of trip
        float TotalPrice (string idTrip)
        {
            return TicketDAO.Instance.TotalPrice(idTrip);
        }

        //Insert Payment
        void InsertPayment(string name, string bank, string cardNumber, string cardType, string idTicket)
        {
            PaymentDAO.Instance.InsertPayment(name, bank, cardNumber, cardType, idTicket);
        }

        //Get ID Ticket
        string GetIDTicket()
        {
            DataTable result = PaymentDAO.Instance.GetIDTicket();
            return result.Rows[0].ItemArray[0].ToString();
        }

        //UpdateSeat
        void UpdateSeat (string idTrip)
        {
            PaymentDAO.Instance.UpdateSeat(idTrip);
        }
        
        //Load Ticket
        Ticket LoadTicket (string idTicket)
        {
            return new Ticket (PaymentDAO.Instance.LoadTicket(idTicket).Rows[0]);
        }

        private void cbType_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
