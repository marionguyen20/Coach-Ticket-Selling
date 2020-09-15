using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TicketSelling
{

    public partial class fSignUp : Form
    {
        private SQL sql;
        private List<TextBox> tbList;
        private List<Label> lbList;
        
        public fSignUp()
        {
            sql = new SQL("DESKTOP-IV065AL", "sa", "123456", "TicketSelling");
            this.sql = sql;
            InitializeComponent();
            init();
        }

        private void init()
        {
            tbList = new List<TextBox>()
            {
                tbFirstName, tbLastName, tbAddress, tbPhone, tbEmail, tbUserSignUp, tbPassSignUp, tbCfPass
            };

            lbList = new List<Label>()
            {
                lbFirstName, lbLastName, lbAddress, lbPhone, lbEmail, lbUserName, lbPass, lbCfPass
            };

        }

        private void checkPwLb_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddressTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PwTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PwCfTb_TextChanged(object sender, EventArgs e)
        {
            string pass = tbPassSignUp.Text.ToString();
            string cfPass = tbCfPass.Text.ToString();
            int num = cfPass.Length;
 
            if (num <= pass.Length)
            {
                for (int count = 0; count < num; count++)
                {
                    if (!cfPass[count].ToString().Equals(pass[count].ToString()))
                    {
                        lbCfPass.ForeColor = Color.Red;
                        checkPwLb.Visible = true;
                        return;
                    }
                    else
                    {
                        lbCfPass.ForeColor = Color.Black;
                        checkPwLb.Visible = false;
                    }
                }
            } else
            {
                lbCfPass.ForeColor = Color.Red;
                checkPwLb.Visible = true;
            }

        }

        private Boolean IsBlank(TextBox t, int idx)
        {
            if (string.IsNullOrWhiteSpace(t.Text))
            {
                lbList[idx].ForeColor = Color.Red;
                lbMissing.Show();
                return true;
            }
            else
            {
                lbList[idx].ForeColor = Color.Black;
            }
            return false;
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
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

        private void ConfirmBt_Click(object sender, EventArgs e)
        {
            //Check blank name
            bool blank = false;
            int index = 0;
            foreach (TextBox tb in tbList)
            {
                if (IsBlank(tb, index++))
                {
                    blank = true;
                }
                tb.Text = sql.checkQuote(tb.Text);
            }

            if (cbGender.SelectedItem == null)
            {
                lbGender.ForeColor = Color.Red;
                blank = true;
            }
            if (blank) return;
            else lbMissing.Hide();

            if (!IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show("Wrong Email format");
                return;
            }

            //Check dumplicate username
            string query = string.Format("SELECT Username FROM ACCOUNT WHERE username='{0}' COLLATE Latin1_General_CS_AS", tbUserSignUp.Text.ToString());
            string check = sql.Read(0, query);
            if (!string.IsNullOrEmpty(check))
            {
                lbUserName.ForeColor = Color.Red;
                MessageBox.Show("The username is existed!! ");
                return;
            }

            //Check password
            if (!tbPassSignUp.Text.Equals(tbCfPass.Text))
            {
                MessageBox.Show("The confirm Password is different!! ");
                return;
            }

            //Adding user infomations into database
            query = string.Format("INSERT INTO USERS VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','User')",
                tbFirstName.Text,
                tbLastName.Text,
                tbPhone.Text,
                tbAddress.Text,
                tbEmail.Text,
                cbGender.SelectedItem.ToString(),
                dtDOB.Value.ToString("yyyy-MM-dd"));
            sql.Add(query);

            //Get user ID
            query = String.Format("SELECT TOP 1 * FROM USERS ORDER BY ID DESC;");
            string ID = sql.Read(1, query);

            //Add user login infomation into Account table
            query = String.Format("INSERT INTO ACCOUNT VALUES ('{0}','{1}','{2}')",
            tbUserSignUp.Text, tbPassSignUp.Text, ID);
            sql.Add(query);
            MessageBox.Show("Sign up successfull!!");
            this.Close();
        }

        private void cbGender_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
    
}
