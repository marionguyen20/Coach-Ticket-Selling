using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSelling.DAO
{
    public class DataProvider
    {
        //Desgin Singleton
        private static DataProvider instance; //Ctrl + R + E -> Encapsulate

        public static DataProvider Instance 
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        
        private DataProvider () {}

         //Connect to the Database
        private string connectionSTR = @"Data Source=DESKTOP-IV065AL;Initial Catalog=TicketSelling;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter = null )
        {
            //Create a table set contain data
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                //Open connection
                connection.Open();

                //Execute query on the connection
                SqlCommand command = new SqlCommand(query, connection);

                //Create Parameter
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                //Get the data from query
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                //Fill data to datatable
                adapter.Fill(data);

                //Close Connection
                connection.Close();

            }
            return data;
        }

        //Return the number of succes row
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                //Create Parameter
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
                connection.Close();
                
            }
            return data;
        }

        //First column of first row or Select count(*)
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                //Create Parameter
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                connection.Close();

            }
            return data;
        }
    }
}
