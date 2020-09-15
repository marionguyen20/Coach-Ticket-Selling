using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace TicketSelling
{
    public class SQL
    {
        private SqlConnection sql;
        public SQL(string Source, string user, string password, string database)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = Source;
            builder.UserID = user;
            builder.Password = password;
            builder.InitialCatalog = database;

            sql = new SqlConnection(builder.ConnectionString);
        }
        public string checkQuote(string str)
        {
            if (str.Contains("'"))
            {
                str = str.Insert(str.IndexOf("'"), "'");
            }
            return str;
        }
        public string Read(int index, string query)
        {
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand(query, sql);
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    string value = (string)dataReader.GetValue(index);
                    sql.Close();
                    return value;
                }
                sql.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
            return null;
        }

        public DataSet Read(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand(query, sql);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(ds);
                sql.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
            return ds;
        }
        public bool Add(string query)
        {
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand(query, sql);
                cmd.ExecuteNonQuery();
                sql.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
            return true;
        }

        public bool IsValidEmail(string email)
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
    }
}
