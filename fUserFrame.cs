using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSelling
{
    public partial class fUserFrame : Form
    {
        private string idUser;
        public fUserFrame(string idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }

        public string IdUser { get => idUser; set => idUser = value; }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fSearchTicket fSearchTicket = new fSearchTicket();
            this.Hide();
            fSearchTicket.ShowDialog();
            this.Show();
        }

        private void btnBuying_Click(object sender, EventArgs e)
        {
            fTrip fTrip = new fTrip(this.idUser);
            this.Hide();
            fTrip.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit the application?", "Annoucement", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Environment.Exit(1);
                //Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fChangePassword fChangePassword = new fChangePassword(this.idUser);
            this.Hide();
            fChangePassword.ShowDialog();
            this.Show();
        }
    }
}
