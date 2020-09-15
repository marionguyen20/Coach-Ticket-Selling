using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.Manager;

namespace TicketSelling
{
    public partial class ManagerForm : Form
    {
        private SQL sql;
        private string ID;
        private List<Form> tempForm;
        public ManagerForm(string ID)
        {
            InitializeComponent();
            sql = new SQL("DESKTOP-IV065AL", "sa", "123456", "TicketSelling");
            this.ID = ID;
            tempForm = new List<Form>();
            ShowChildForm(new ControlForm(this.sql, this.ID));
        }

        private void ControlBt_Click(object sender, EventArgs e)
        {
            //RightPanel.Controls.Clear();
            ShowChildForm(new ControlForm(this.sql, this.ID));
        }

        private void ShowChildForm(Form child)
        {
            
            if (tempForm.Count != 0)
            {
                foreach (var x in tempForm)
                {
                    if (x.GetType() == child.GetType())
                    {
                        tempForm[tempForm.Count - 1].Hide();
                        x.BringToFront();
                        x.Show();
                        return;
                    }
                }
            }
            
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Top;
            RightPanel.Controls.Add(child);
            tempForm.Add(child);
            child.BringToFront();
            child.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RightPanel.Controls.Clear();
            ShowChildForm(new fBill(this.sql));
        }

        private void btnSearchTicket_Click(object sender, EventArgs e)
        {
            //RightPanel.Controls.Clear();
            ShowChildForm(new fSearchTicket());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //RightPanel.Controls.Clear();
            ShowChildForm(new fDriverMana(this.sql, this.ID));
        }

        private void btnManaUser_Click(object sender, EventArgs e)
        {
            //RightPanel.Controls.Clear();
            ShowChildForm(new UserMana(this.sql, this.ID));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            
            if (MessageBox.Show("Are you sure to exit the application?", "Annoucement", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Environment.Exit(0);
                //Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowChildForm(new fQuerry());
        }
    }
}
