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

namespace TicketSelling.Manager
{
    public partial class ControlForm : Form
    {
        private SQL sql;
        private string ID_Mana, ID_Trip, func;
        string default_query = "select Source, " +
                                    "Destination," +
                                    "Date_Trip," +
                                    "Start_Time," +
                                    "Arrival_Time," +
                                    "Duration," +
                                    "Total_Seat," +
                                    "Available_Seat," +
                                    "Price," +
                                    "Discount," +
                                    "ID_Driver, " +
                                    "ID_Trip, " +
                                    "ID_Manager " +
                                    "from TRIP ";
        public ControlForm(SQL sql, string ID_Mana)
        {
            InitializeComponent();
            this.sql = sql;
            this.ID_Mana = ID_Mana;
            
            init();
            LoadIDDriver();
            
        }

        private void init()
        {
            pnSearch.Show();
            DataShow.DataSource = sql.Read(default_query).Tables[0];
            tbTotal.Text = TotalTrip();
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
                DataShow.DataSource = sql.Read(default_query).Tables[0];
                tbTotal.Text = TotalTrip();
                return;
            }

            col = SearchCB.SelectedItem.ToString();

            if (string.Equals(col, "Source - Destination"))
            {
                query = string.Format("{0} WHERE Source like '{1}%' AND Destination like '{2}%'", default_query, cbSource.Text.ToString(), cbDestination.Text.ToString());
            } else if (string.Equals(col, "Date Trip"))
            {
                string start = dtPickFrom.Value.ToString("yyyy-MM-dd");
                string end = dtPickTo.Value.ToString("yyyy-MM-dd");

                query = string.Format("{0} WHERE Date_Trip >= '{1}' AND Date_Trip <= '{2}' ", default_query, start, end);
            }
            else if (col.Equals("All Trips"))
            {
                query = default_query;
            } else if (col.Equals("ID_Driver") || col.Equals("ID_Trip"))
            {
                query = string.Format("{0} WHERE {1} like '{2}%'", default_query, col, cbDriver.Text.ToString());
                
            }
            else
            {
                isBlank(tbValue); 
               query = string.Format("{0} WHERE {1} like '{2}%'", default_query, col, tbValue.Text.ToString());
            }
                
            DataShow.DataSource = sql.Read(query).Tables[0];
            tbTotal.Text = TotalTrip();
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
        private bool isBlank (TextBox tb)
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

        private void SearchCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.Equals(SearchCB.SelectedItem.ToString(), "Source - Destination"))
            {
                DataShow.DataSource = null;
                pnDate.Hide();
                pnSearch.Hide();
                pnIDDriver.Hide();
                pnSourceDes.Show();
                LoadSource(); //Load Source List
                LoadDestination(); //Load Destination list
            }
            else if (string.Equals(SearchCB.SelectedItem.ToString(), "Date Trip"))
            {
                DataShow.DataSource = null;
                pnSourceDes.Hide();
                pnSearch.Hide();
                pnDate.Show();
                pnIDDriver.Hide();
            } else if (string.Equals(SearchCB.SelectedItem.ToString(), "ID_Driver")) 
            {
                LoadIDDriverSearch();
                
                DataShow.DataSource = null;
                pnSourceDes.Hide();
                pnDate.Hide();
                pnSearch.Hide();
                pnIDDriver.Show();
            }
            else if (string.Equals(SearchCB.SelectedItem.ToString(), "ID_Trip"))
            {
                LoadIDTrip();
                DataShow.DataSource = null;
                pnSourceDes.Hide();
                pnDate.Hide();
                pnSearch.Hide();
                pnIDDriver.Show();
            }

            else
            {
                pnIDDriver.Hide();
                DataShow.DataSource = null;
                pnSourceDes.Hide();
                pnDate.Hide();
                pnSearch.Show();
            }
        }

        //Load Source
        void LoadSource()
        {
            //Get datasource
            cbSource.DataSource = TripDAO.Instance.LoadSource();

            //Display
            cbSource.DisplayMember = "Source";
            
        }

        //Load Destination
        void LoadDestination ()
        {
            //Get datasource
            cbDestination.DataSource = TripDAO.Instance.LoadDestination();

            //Display
            cbDestination.DisplayMember = "Destination";
        }

        //Total trip
        string TotalTrip ()
        {
            int row = (int) DataShow.Rows.Count;
            row--;
            return row.ToString();
        }

        private void AddBt_Click(object sender, EventArgs e)
        {

            func = "Add";
            DetailGB.Enabled = true;
            btnSave.Text = "Add";
        }

        private void EditBt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SourceTb.Text))
                DetailGB.Enabled = true;

            func = "Edit";
            btnSave.Text = "Save";
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is updating!");
        }

        private void cancelBt_Click(object sender, EventArgs e)
        {
            DetailGB.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (var x in DetailGB.Controls.OfType<TextBox>())
            {
                if (isBlank(x))
                {
                    MessageBox.Show("Please fill the blank field ==\"");
                    return;
                }
            }
            DateTime start = DateTime.ParseExact(StartTimeTb.Text, "HH:mm:ss", new DateTimeFormatInfo());
            DateTime end = DateTime.ParseExact(ArrivalTimeTb.Text, "HH:mm:ss", new DateTimeFormatInfo());
            TimeSpan Duration = end.Subtract(start);
            string query = default;
            if (func == "Edit")
            {
                if (DateTripTb.Value < DateTime.Today)
                {
                    MessageBox.Show(" The date is out!!");
                    return;
                }

                if (CheckDriver(SourceTb.Text, LastestPosition(cbIDDriver.Text, DateTripTb.Value.ToString("yyyy-MM-dd")), CheckDate(cbIDDriver.Text, DateTripTb.Value.ToString("yyyy-MM-dd"))) || LastestPosition(cbIDDriver.Text, DateTripTb.Value.ToString("yyyy-MM-dd")).Equals(""))
                {
                    query = string.Format("UPDATE TRIP SET Source = '{0}', Destination = '{1}', Date_Trip = '{2}', Start_Time = '{3}', Arrival_Time = '{4}', " +
                    "Duration = '{5}', Total_Seat = '{6}', Price = '{7}', Discount = '{8}', ID_Driver = '{9}', ID_Manager = '{10}' " +
                    "WHERE ID_Trip = '{11}'",
                    SourceTb.Text, DestinationTb.Text, DateTripTb.Value, start.ToString(), end.ToString(), Duration.ToString(),
                    TotalSeatTb.Text, PriceTb.Text, DiscountTb.Text, cbIDDriver.Text, this.ID_Mana, this.ID_Trip);
                    sql.Add(query);
                    MessageBox.Show("Successfully!!");
                } 
                else if (!CheckDate(cbIDDriver.Text, DateTripTb.Value.ToString("yyyy-MM-dd")))
                {
                    MessageBox.Show("Driver has a trip on this day!");
                }
                else if (!string.Equals(SourceTb.Text, LastestPosition(cbIDDriver.Text, DateTripTb.Value.ToString("yyyy-MM-dd"))))
                {
                    MessageBox.Show("Driver is not in " + SourceTb.Text.ToString());
                }

            }
            else if (func == "Add")
            {       
                    if (DateTripTb.Value < DateTime.Today)
                {
                    MessageBox.Show(" The date is out!!");
                    return;
                }    

                    query = string.Format("INSERT INTO TRIP VALUES('{0}', '{1}', '{2}', '{3}', '{4}', " +
                    "'{5}', {6}, {7}, {8}, {9}, '{10}','{11}') ",
                    SourceTb.Text, DestinationTb.Text, DateTripTb.Value.ToString(), start.ToString(), end.ToString(), Duration.ToString(),
                    TotalSeatTb.Text, TotalSeatTb.Text, PriceTb.Text, DiscountTb.Text, cbIDDriver.Text.ToString(), this.ID_Mana);
                    sql.Add(query);
                    MessageBox.Show("Successfully!!");
            }
              
            DetailGB.Enabled = false;
            DataShow.DataSource = sql.Read(default_query).Tables[0];
        }

        private void DataShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= DataShow.RowCount - 1) //Return when user click on top of col or row
                return;
            try
            {
                SourceTb.Text = DataShow[0, e.RowIndex].Value.ToString();
                DestinationTb.Text = DataShow[1, e.RowIndex].Value.ToString();
                DateTripTb.Value = (DateTime)DataShow[2, e.RowIndex].Value;
                StartTimeTb.Text = DataShow[3, e.RowIndex].Value.ToString();
                ArrivalTimeTb.Text = DataShow[4, e.RowIndex].Value.ToString();
                TotalSeatTb.Text = DataShow[6, e.RowIndex].Value.ToString();
                AvailableTb.Text = DataShow[7, e.RowIndex].Value.ToString();
                PriceTb.Text = DataShow[8, e.RowIndex].Value.ToString();
                DiscountTb.Text = DataShow[9, e.RowIndex].Value.ToString();
                cbIDDriver.Text = DataShow[10, e.RowIndex].Value.ToString();
                ID_Trip = DataShow[11, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Check Valid Driver
        bool CheckDriver(string source, string position, bool check)
        {
            if (string.Equals(source, position) && check) return true;
            else return false;
        }
        
        //Get the lastest position
        string LastestPosition(string ID_Driver,string date)
        {
            string query = string.Format( "SELECT TOP 1 Destination FROM dbo.TRIP WHERE Date_Trip <= '{0}' AND ID_Driver = '{1}' ORDER BY (Date_Trip) DESC",date, ID_Driver);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0) return data.Rows[0].ItemArray[0].ToString();
            else return "";
        }

        private void pnSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        //Check date of Driver
        bool CheckDate (string ID_Driver, string date)
        {
            string query = string.Format("SELECT * FROM trip WHERE ID_Driver = '{0}'  AND Date_Trip = '{1}'",ID_Driver, date);
            return DataProvider.Instance.ExecuteQuery(query).Rows.Count == 0;
        }

        //Load ID Driver
        void LoadIDDriver()
        {
            string query = "SELECT ID_User FROM dbo.USERS WHERE Role_User = 'Driver'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            cbIDDriver.DataSource = data;

            cbIDDriver.DisplayMember = "ID_User";
        }

        private void PriceTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Char is not CTRL or not number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void DiscountTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Char is not CTRL or not number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {   
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void SearchCB_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbIDDriver_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        void LoadIDDriverSearch()
        {
            string query = "SELECT ID_User FROM dbo.USERS WHERE Role_User = 'Driver'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            cbDriver.DataSource = data;

            cbDriver.DisplayMember = "ID_User";
        }

        //Load ID Manage
        void LoadIDTrip ()
        {
            
            string query = "SELECT ID_Trip FROM dbo.TRIP";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            cbDriver.DataSource = data;

            cbDriver.DisplayMember = "ID_Trip";
        }

    }
}
