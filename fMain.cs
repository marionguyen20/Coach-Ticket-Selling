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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Show LoginForm
            fLogin fLogin = new fLogin();
            this.Hide();
            fLogin.ShowDialog();
            this.Show();

        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tWELCOME TO E-TICKET SELLING COMPANY\n\nAddress:Sir Matt Busby Way, Trafford Park, Stretford, Manchester\nPhone: +44 123 456 789\nEmail: eticketselling@mail.co.uk");
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            fSignUp fSignUp = new fSignUp();
            this.Hide();
            fSignUp.ShowDialog();
            this.Show();
        }
    }
}
