using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Lost_n_Found.Models.Database;
using MySql.Data.MySqlClient;
using MessageBox = System.Windows.Forms.MessageBox;
using Lost_n_Found.Controllers;

namespace Lost_n_Found.Models.UserLogin
{
    internal class UserLogin
    {
        private DatabaseConnection conn = new DatabaseConnection(); // deklarasi objek database

        public bool LoginProcess(string username, string password)
        {
            bool result = false;
            try
            {
                conn.OpenConnection();
                MySqlConnection connection = conn.GetConnection();

                string query = "SELECT * FROM users WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    CurrentUser.UserId = reader["id_user"].ToString();
                    CurrentUser.Username = reader["username"].ToString();
                    CurrentUser.Email = reader["email"].ToString();

                    MessageBox.Show("Login Berhasil");

                    result = true;
                }
                else
                {
                    MessageBox.Show("Pastikan Username dan Password anda benar");
                    result = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.CloseConnection();
            }
            return result;
        }

        // proses logout
        public bool LogoutProcess()
        {
            bool result = false;
            var confirmResult = MessageBox.Show("Are you sure want to Logout?", "Logout", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                CurrentUser.UserId = null;
                CurrentUser.Username = null;
                CurrentUser.Email = null;
                result = true;
            }
            return result;
        }

        // cek session
        public bool IsLogin()
        {
            bool result = true;
            if (string.IsNullOrEmpty(CurrentUser.UserId))
            {
                //MessageBox.Show("Login First!!");
                result = false;
            }
            return result ;
        }


    }
}
