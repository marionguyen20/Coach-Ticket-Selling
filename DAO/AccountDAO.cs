using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSelling.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        { 
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO () { }

        //Login
        public bool Login (string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            
            return result.Rows.Count > 0; //Count the rows result
        }
        //Show Name by userName
        public DataTable showName (string userName)
        {

            string query = "USP_showName @userName ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });

            return data;
        }
        
        //Get Role
        public DataTable getRole (string userName)
        {
            string query = "USP_getRole @userName ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });

            return data;
        }
        //Get ID
        public DataTable getID (string userName)
        {
            string query = "USP_getID @userName ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });

            return data;
        }
        //Change Pass
        public bool UpdatePass (string idUser, string passWord, string newPassword)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_UpdateAccount @idUser , @passWord , @newPassWord", new object[] { idUser, passWord, newPassword });

            return result > 0;

        }
    }
}
