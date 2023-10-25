using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ATM_Tiketing
{
    internal class BazaDate
    {
        private static BazaDate instance = null;
        private SqlConnection con;

        private BazaDate()
        {
            string constring = "Data Source=DESKTOP-6GJKG84; Initial Catalog=test_ts;Integrated Security=true";
            con = new SqlConnection(constring);
            try
            {
                con.Open();
                Console.WriteLine("Conexiune cu baza de date reușită!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }

        public static BazaDate GetInstance()
        {
            if (instance == null)
            {
                instance = new BazaDate();
            }
            return instance;
        }

        public SqlConnection GetCon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else if (con.State == System.Data.ConnectionState.Broken)
            {
                con.Close();
                con.Open();
            }
            return con;
        }

        public void CloseCon()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}
