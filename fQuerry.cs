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
    public partial class fQuerry : Form
    {
        public fQuerry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querry = tbQuerry.Text;
            DataTable data = DataProvider.Instance.ExecuteQuery(querry);

            dtgvQuerry.DataSource = data;

            tbTotal.Text = (dtgvQuerry.Rows.Count - 1).ToString();

        }

    }
}
