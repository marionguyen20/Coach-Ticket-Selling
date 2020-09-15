using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.DAO;

namespace TicketSelling
{
    public partial class fBill : Form
    {
        private SQL sql;
        string default_query = /*"select ID_Bill, " +
                                    "Name," +
                                    "Bank," +
                                    "Card_Number," +
                                    "Card_Type," +
                                    "Date_Pay," +
                                    "ID_Ticket " +
                                    "from PAYMENT ";*/
                                "SELECT P.ID_Bill, P.Name, P.Bank, P.Card_Number,P.Card_Type, P.Date_Pay, P.ID_Ticket, T.Total_Price FROM dbo.PAYMENT AS P, dbo.TICKET AS T WHERE P.ID_Ticket = T.ID_Ticket ";
        public fBill(SQL sql)
        {
            InitializeComponent();
            this.sql = sql;

            init();

        }

        private void init()
        {
            pnSearch.Show();
            dtgvBill.DataSource = sql.Read(default_query).Tables[0];
            tbTotal.Text = TotalBill();
            tbTotalPrice.Text = TotalPrice();
        }

        string TotalBill()
        {
            int row = (int)dtgvBill.Rows.Count;
            row--;
            return row.ToString();
        }

        //Load ID Bill
        void LoadIDBill ()
        {
            string query = "SELECT ID_Bill FROM dbo.PAYMENT ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            cbID.DataSource = data;

            cbID.DisplayMember = "ID_Bill";
        }

        //Load ID Ticket
        void LoadIDTicket ()
        {
            string query = "SELECT ID_Ticket FROM dbo.TICKET";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            cbID.DataSource = data;

            cbID.DisplayMember = "ID_Ticket";
        }

        //Check Search is blank or not
        private bool isBlank(ComboBox cb)
        {
            if (cb.SelectedItem == null)
            {
                cb.BackColor = Color.LightCoral;
                return true;
            }
            else
                cb.BackColor = Color.White;
            return false;
        }

        //Check value is blank or not
        private bool isBlank(TextBox tb)
        {
            if (string.IsNullOrEmpty(tb.Text))
            {
                tb.BackColor = Color.LightCoral;
                return true;
            }
            else
                tb.BackColor = Color.White;
            return false;
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.Equals(cbSearch.SelectedItem.ToString(), "Date_Pay"))
            {
                dtgvBill.DataSource = null;
                pnSearch.Hide();
                pnDate.Show();
                pnID.Hide();
            }
            else if (string.Equals(cbSearch.SelectedItem.ToString(), "ID_Bill"))
            {
                LoadIDBill();

                dtgvBill.DataSource = null;
                pnDate.Hide();
                pnSearch.Hide();
                pnID.Show();
            }
            else if (string.Equals(cbSearch.SelectedItem.ToString(), "ID_Ticket"))
            {
                LoadIDTicket();

                dtgvBill.DataSource = null;
                pnDate.Hide();
                pnSearch.Hide();
                pnID.Show();
            }

            else
            {
                pnID.Hide();
                dtgvBill.DataSource = null;
                pnDate.Hide();
                pnSearch.Show();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string col;
            string query;// from = default, search = default;
            bool blank = false;

            if (isBlank(cbSearch))
                blank = true;

            if (blank)
            {
                dtgvBill.DataSource = sql.Read(default_query).Tables[0];
                tbTotal.Text = TotalBill();
                tbTotalPrice.Text = TotalPrice();
                return;
            }

            col = cbSearch.SelectedItem.ToString();

            if (string.Equals(col, "Date_Pay"))
            {
                string start = dtPickFrom.Value.ToString("yyyy-MM-dd");
                string end = dtPickTo.Value.ToString("yyyy-MM-dd");

                query = string.Format("{0} AND P.Date_Pay >= '{1}' AND P.Date_Pay <= '{2}' ", default_query, start, end);
            }
            else if (col.Equals("All Bills"))
            {
                query = default_query;
            }
            else if (col.Equals("ID_Ticket") || col.Equals("ID_Bill"))
            {
                query = string.Format("{0} AND P.{1} like '{2}%'", default_query, col, cbID.Text.ToString());

            }
            else
            {
                isBlank(tbValue);
                query = string.Format("{0} AND P.{1} like '{2}%'", default_query, col, tbValue.Text.ToString());
            }

            dtgvBill.DataSource = sql.Read(query).Tables[0];
            tbTotal.Text = TotalBill();
            tbTotalPrice.Text = TotalPrice();
        }

        private void dtgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dtgvBill.RowCount - 1) //Return when user click on top of col or row
                return;
            try
            {
                tbBillID.Text = dtgvBill[0, e.RowIndex].Value.ToString();
                tbName.Text = dtgvBill[1, e.RowIndex].Value.ToString();
                tbBank.Text = dtgvBill[2, e.RowIndex].Value.ToString();
                tbCardNum.Text = dtgvBill[3, e.RowIndex].Value.ToString();
                tbCardType.Text = dtgvBill[4, e.RowIndex].Value.ToString();
                dtDatePay.Value = (DateTime) dtgvBill[5, e.RowIndex].Value;
                tbIDTicket.Text = dtgvBill[6, e.RowIndex].Value.ToString();
                tbPrice.Text = dtgvBill[7, e.RowIndex].Value.ToString() + "£";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

       private string TotalPrice ()
        {
            float sum = 0;
            for (int i = 0; i < dtgvBill.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dtgvBill.Rows[i].Cells[7].Value);
            }

            return sum.ToString("c", new CultureInfo ("en-GB"));
        }

        private void cbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
