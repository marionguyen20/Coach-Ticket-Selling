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
    public partial class fChangePassword : Form
    {
        private string idUser;

        public fChangePassword(string idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            UpdatePass();
        }
        //Update Password
        void UpdatePass ()
        {
            string pass = tbPass.Text;
            string newPass = tbNewPass.Text;
            string cfPass = tbCfPass.Text;

            if (!newPass.Equals(cfPass))
            {
                MessageBox.Show("Please input confirm password is the same as new password!");
            } else
            {
                if (AccountDAO.Instance.UpdatePass (this.idUser, pass, newPass))
                {
                    MessageBox.Show("Update successfully");
                } else
                {
                    MessageBox.Show("Update unsuccessfully!! Check your password again !!");
                }
            }
            tbNewPass.Clear();
            tbPass.Clear();
            tbCfPass.Clear();
        }

        private void tbCfPass_TextChanged(object sender, EventArgs e)
        {
            string pass = tbNewPass.Text; ;
            string cfPass = tbCfPass.Text;
            int num = cfPass.Length;

            if (num <= pass.Length)
            {
                for (int count = 0; count < num; count++)
                {
                    if (!cfPass[count].ToString().Equals(pass[count].ToString()))
                    {
                        lbCfPass.ForeColor = Color.Red;
                        lbCheck.Visible = true;
                        return;
                    }
                    else
                    {
                        lbCfPass.ForeColor = Color.Black;
                        lbCheck.Visible = false;
                    }
                }
            }
            else
            {
                lbCfPass.ForeColor = Color.Red;
                lbCheck.Visible = true;
            }
        }
    }
}
