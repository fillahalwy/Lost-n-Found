using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Lost_n_Found.Models.Database
{
    internal class DatabaseConnection
    {
        private MySqlConnection connection;


        // koneksi ke database
        public DatabaseConnection()
        {
            string server = "localhost";
            string database = "db_lnf"; // nama database
            string username = "root"; // username server
            string password = "";

            string connectionString = $"Server={server};Database={database};User ID={username};password={password};";

            connection = new MySqlConnection(connectionString);
        }

        // fungsi untuk open koneksi
        public void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to Open Connection : {ex.Message}");
            }
        }

        // fungsi menutup koneksi
        public void CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to Close Connection: {ex.Message}");
            }
        }

        // fungsi untuk mengambil koneksi
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
