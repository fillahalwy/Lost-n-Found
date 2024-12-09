using Lost_n_Found.Models.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using System.Xml.Linq;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Lost_n_Found.Controllers.UserControllers
{
    internal class RegisterController
    {
        DatabaseConnection conn = new DatabaseConnection();
        public bool Register(string email, string name, string username, string password, int gender, string address, string phone) 
        {
            bool result = false;
            try
            {
                // koneksi database
                conn.OpenConnection();
                MySqlConnection connection = conn.GetConnection();

                // memasukkan data ke database
                string query = "INSERT INTO users (email,name,username,password,gender,address,phone) values (@email,@name,@username,@password,@gender,@address,@phone)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Success");

                result = true;

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
        
    }
}
