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
    public partial class UserMana : Form
    {
        private SQL sql;
        private string ID_Mana, func,
            default_query = "select ID_User, First_Name, Last_Name, Phone, Address_User, " +
                "Email, Gender_User, Date_Of_Birth from USERS ";

        public UserMana(SQL sql, string ID)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID_Mana = ID;

            init();
        }

        private void init()
        {
            pnSearch.Show();
            LoadData();
            tbTotal.Text = TotalUser();
        }
        //Load data default 
        private bool LoadData()
        {
            DataShow.DataSource = sql.Read(default_query + " Where Role_User = 'User'").Tables[0];
            tbTotal.Text = TotalUser();
            return true;
        }

        //Total User
        string TotalUser()
        {
            int row = (int)DataShow.Rows.Count;
            row--;
            return row.ToString();
        }

        private void SearchCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.Equals(SearchCB.SelectedItem.ToString(), "Date Of Birth"))
            {
                DataShow.DataSource = null;

                pnSearch.Hide();
                pnDate.Show();
                pnIDDriver.Hide();
            }
            else if (string.Equals(SearchCB.SelectedItem.ToString(), "ID User"))
            {
                LoadIDUserr();

                DataShow.DataSource = null;

                pnDate.Hide();
                pnSearch.Hide();
                pnIDDriver.Show();
            }
            else if (string.Equals(SearchCB.SelectedItem.ToString(), "Gender"))
            {
                LoadGender();
                DataShow.DataSource = null;

                pnDate.Hide();
                pnSearch.Hide();
                pnIDDriver.Show();
            }

            else
            {
                pnIDDriver.Hide();
                DataShow.DataSource = null;

                pnDate.Hide();
                pnSearch.Show();
            }
        }

        private void DataShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= DataShow.RowCount - 1) //Return when user click on top of col or row
                return;
            try
            {
                tbUserID.Text = DataShow[0, e.RowIndex].Value.ToString();
                tbFirstName.Text = DataShow[1, e.RowIndex].Value.ToString();
                tbLastName.Text = DataShow[2, e.RowIndex].Value.ToString();
                tbPhone.Text = DataShow[3, e.RowIndex].Value.ToString();
                tbAddress.Text = DataShow[4, e.RowIndex].Value.ToString();
                tbEmail.Text = DataShow[5, e.RowIndex].Value.ToString();
                tbGender.Text = DataShow[6, e.RowIndex].Value.ToString();
                dtPickerDOB.Value = (DateTime)DataShow[7, e.RowIndex].Value;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void SearchBt_Click(object sender, EventArgs e)
        {
            string col;
            string query;// from = default, search = default;
            bool blank = false;

            if (isBlank(SearchCB))
                blank = true;

            if (blank)
            {
                LoadData();
                tbTotal.Text = TotalUser();
                return;
            }

            col = SearchCB.SelectedItem.ToString();

            if (string.Equals(col, "Date Of Birth"))
            {
                string start = dtPickFrom.Value.ToString("yyyy-MM-dd");
                string end = dtPickTo.Value.ToString("yyyy-MM-dd");

                query = string.Format("{0} WHERE Role_User = 'User' AND Date_Of_Birth >= '{1}' AND Date_Of_Birth <= '{2}' ", default_query, start, end);
            }
            else if (col.Equals("All Users"))
            {
                LoadData();
                return;
            }
            else if (col.Equals("ID User"))
            {
                query = string.Format("{0} WHERE Role_User = 'User' AND ID_User like '{1}%'", default_query, cbDriver.Text.ToString());

            }
            else if (col.Equals("Gender"))
            {
                query = string.Format("{0} WHERE Role_User = 'User' AND Gender_User like '{1}%'", default_query, cbDriver.Text.ToString());

            }

            else
            {
                isBlank(tbValue);
                query = string.Format("{0} WHERE Role_User = 'User' AND {1} like '{2}%'", default_query, col, tbValue.Text.ToString());
            }

            DataShow.DataSource = sql.Read(query).Tables[0];
            tbTotal.Text = TotalUser();
        }

        //Check is fill or not
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
        
        private void SearchCB_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        //Load ID User
        void LoadIDUserr()
        {
            string query = "SELECT ID_User FROM dbo.USERS WHERE Role_User = 'User'";
            cbDriver.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbDriver.DisplayMember = "ID_User";
        }

        //Load Gender
        void LoadGender()
        {
            string query = "SELECT DISTINCT Gender_User FROM dbo.USERS ";
            cbDriver.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbDriver.DisplayMember = "Gender_User";
        }


    }
}
