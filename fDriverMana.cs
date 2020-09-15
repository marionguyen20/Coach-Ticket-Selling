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
    public partial class fDriverMana : Form
    {
        private SQL sql;
        private string ID_Mana, func,
            default_query = "select ID_User, First_Name, Last_Name, Phone, Address_User, " +
                "Email, Gender_User, Date_Of_Birth from USERS ";

        public fDriverMana(SQL sql, string ID)
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
            tbTotal.Text = TotalDriver();
        }
        //Load data default 
        private bool LoadData ()
        {
            DataShow.DataSource = sql.Read(default_query + " Where Role_User = 'Driver'").Tables[0];
            tbTotal.Text = TotalDriver();
            return true;
        }


        private void fDriverMana_Load(object sender, EventArgs e)
        {

        }

        private void DataShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DetailGB.Enabled = true;
            tbDriverID.Enabled = false;
            func = "Add";
            btnSave.Text = "Add";
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDriverID.Text))
                return;
            DetailGB.Enabled = true;
            func = "Edit";
            btnSave.Text = "Save";
        }

        private void tbPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        e.SuppressKeyPress = true;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DetailGB.Enabled = false;
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
            else if (string.Equals(SearchCB.SelectedItem.ToString(), "ID Driver"))
            {
                LoadIDDriver();

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

        //Load ID Driver
        void LoadIDDriver ()
        {
            string query = "SELECT ID_User FROM dbo.USERS WHERE Role_User = 'Driver'";
            cbDriver.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbDriver.DisplayMember = "ID_User";
        }

        //Load Gender
        void LoadGender ()
        {
            string query = "SELECT DISTINCT Gender_User FROM dbo.USERS ";
            cbDriver.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbDriver.DisplayMember = "Gender_User";
        }

        //Total Driver
        string TotalDriver ()
        {
            int row = (int)DataShow.Rows.Count;
            row--;
            return row.ToString();
        }
        private void tbDriverID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= DataShow.RowCount - 1) //Return when user click on top of col or row
                return;
            try
            {
                tbDriverID.Text = DataShow[0, e.RowIndex].Value.ToString();
                tbFirstName.Text = DataShow[1, e.RowIndex].Value.ToString();
                tbLastName.Text = DataShow[2, e.RowIndex].Value.ToString();
                tbPhone.Text = DataShow[3, e.RowIndex].Value.ToString();
                tbAddress.Text = DataShow[4, e.RowIndex].Value.ToString();
                tbEmail.Text = DataShow[5, e.RowIndex].Value.ToString();
                cbGender.SelectedItem = DataShow[6, e.RowIndex].Value.ToString().Trim();
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
                tbTotal.Text = TotalDriver();
                return;
            }

            col = SearchCB.SelectedItem.ToString();

            if (string.Equals(col, "Date Of Birth"))
            {
                string start = dtPickFrom.Value.ToString("yyyy-MM-dd");
                string end = dtPickTo.Value.ToString("yyyy-MM-dd");

                query = string.Format("{0} WHERE Role_User = 'Driver' AND Date_Of_Birth >= '{1}' AND Date_Of_Birth <= '{2}' ", default_query,start, end);
            }
            else if (col.Equals("All Drivers"))
            {
                LoadData();
                return;
            }
            else if (col.Equals("ID Driver")) 
            {
                query = string.Format("{0} WHERE Role_User = 'Driver' AND ID_User like '{1}%'", default_query,  cbDriver.Text.ToString());

            }
            else if (col.Equals("Gender"))
            {
                query = string.Format("{0} WHERE Role_User = 'Driver' AND Gender_User like '{1}%'", default_query, cbDriver.Text.ToString());

            }

            else
            {
                isBlank(tbValue);
                query = string.Format("{0} WHERE Role_User = 'Driver' AND {1} like '{2}%'", default_query, col, tbValue.Text.ToString());
            }

            DataShow.DataSource = sql.Read(query).Tables[0];
            tbTotal.Text = TotalDriver();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (var x in DetailGB.Controls.OfType<TextBox>()) //Check blank boxes
            {
                if (isBlank(x) && (x!= tbDriverID))
                {
                    MessageBox.Show("Please fill the blank field ==\"");
                    return;
                }
            }

            string query = default;

            if (!sql.IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show("Invalid Email");
                return;
            }

            if (func == "Edit")
            {
                query = string.Format("UPDATE USERS SET First_Name = '{0}', Last_Name = '{1}', Phone = {2}, Address_User = '{3}', Email = '{4}', " +
                    "Gender_User = '{5}', Date_Of_Birth = '{6}' " +
                    "WHERE ID_User = '{7}'",
                    sql.checkQuote(tbFirstName.Text), sql.checkQuote(tbLastName.Text), tbPhone.Text,
                    sql.checkQuote(tbAddress.Text), sql.checkQuote(tbEmail.Text), cbGender.SelectedItem.ToString(),
                    dtPickerDOB.Value.ToString("yyyy-MM-dd"), tbDriverID.Text.ToString());
            }
            else if (func == "Add")
            {
                query = string.Format("INSERT INTO USERS VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}') ",
                   sql.checkQuote(tbFirstName.Text), sql.checkQuote(tbLastName.Text), tbPhone.Text,
                   sql.checkQuote(tbAddress.Text), sql.checkQuote(tbEmail.Text), cbGender.SelectedItem.ToString(),
                    dtPickerDOB.Value.ToString("yyyy-MM-dd"), "Driver");
            }
            sql.Add(query);
            MessageBox.Show("Successfully!!");
            DetailGB.Enabled = false;
            LoadData();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is updating!!");
        }

        private void cbGender_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void SearchCB_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
