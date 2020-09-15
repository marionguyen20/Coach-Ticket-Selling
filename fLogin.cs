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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        private string idUser;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Get Username and Password
            string userName = tbUserName.Text;
            string passWord = tbPassLog.Text;

            if (Login(userName, passWord) )
            {
                MessageBox.Show("Login Success!! Welcome " + showName(userName) + " to E-Ticket Selling !!");
                idUser = getID(userName);

                if (getRole(userName).Equals("User"))
                {
                    fUserFrame fUserFrame = new fUserFrame(this.idUser);
                    this.Hide();
                    fUserFrame.ShowDialog();
                    //this.Close();
                    this.Show();
                } else if (getRole(userName).Equals("Driver"))
                {
                    fDriver fDriver = new fDriver(this.idUser);
                    this.Hide();
                    fDriver.ShowDialog();
                    this.Show();
                } else 
                {
                    ManagerForm managerForm = new ManagerForm(this.idUser);
                    this.Hide();
                    
                    managerForm.ShowDialog();
                    //this.Close();
                    this.Show();
                }
                
            } else 
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }
        //Check Login
        bool Login (string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        //showName
        string showName (string userName)
        {
            DataTable result = AccountDAO.Instance.showName(userName);

            return (result.Rows[0].ItemArray[0].ToString() + " " + result.Rows[0].ItemArray[1].ToString());

            /*
            for (int i = 0; i < result.Rows.Count; i++)
                for (int j = 0; j < result.Columns.Count; j++)
                {
                    object o = result.Rows[i].ItemArray[j];

                    //if you want to get the string
                    string s = result.Rows[i].ItemArray[j].ToString();
                }
                */
        }

        //getRole
        string getRole (string userName)
        {
            DataTable result = AccountDAO.Instance.getRole(userName);

            return (result.Rows[0].ItemArray[0].ToString());
        }

        //getIDUser
        string getID (string userName)
        {
            DataTable result = AccountDAO.Instance.getID(userName);

            return (result.Rows[0].ItemArray[0].ToString());
        }

       
    }
}
