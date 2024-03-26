using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ItprogerApp
{
    internal class DB
    {
        MySqlConnection db = new MySqlConnection("server=localhost;port=3306;user=root;password=root;database=winforms");

        /*private const string HOST = "localhost";
        private const string PORT = "3306";
        private const string DATABASE = "itproger";
        private const string USER = "root";
        private const string PASS = "root";*/

        
        //public object db = $"Server={HOST};User={USER};Password={PASS};Database={DATABASE};Port={PORT}";


        public void OpenConnection()
        {
            if (db.State == System.Data.ConnectionState.Closed)

                db.Open();
        }

        public void CloseConnection()
        {
            if (db.State == System.Data.ConnectionState.Open)

                db.Close();
        }

        public MySqlConnection GetConnection()
        {
         return db;
        }
    }
}

