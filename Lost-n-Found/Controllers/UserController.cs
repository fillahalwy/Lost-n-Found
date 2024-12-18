using Lost_n_Found.Models.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Windows.Forms;
using Lost_n_Found.Models.Repository;
using Lost_n_Found.Models.Database;

namespace Lost_n_Found.Controllers
{

    internal class UserController
    {
        DatabaseConnection conn = new DatabaseConnection();
        UserRepository userRepository = new UserRepository();

        // cek session
        public bool IsLogin()
        {
            bool result = true;
            if (string.IsNullOrEmpty(CurrentUser.UserId))
            {
                //MessageBox.Show("Login First!!");
                result = false;
            }
            return result;
        }
        
        // Daftar akun
        public int Register(Users user)
        {
            bool available = userRepository.UserValidation(user.Username);
            int result = 0;
            if (string.IsNullOrWhiteSpace(user.Name) ||
                string.IsNullOrWhiteSpace(user.Username) ||
                string.IsNullOrWhiteSpace(user.Email) ||
                string.IsNullOrWhiteSpace(user.Password) ||
                string.IsNullOrWhiteSpace(user.Phone) || 
                string.IsNullOrWhiteSpace(user.Address))
            {
                MessageBox.Show("Please input all data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if(!available)
            {
                result = userRepository.Register(user);
            }
            else
            {
                MessageBox.Show("Username already available", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return result;
            }

            // Jika data berhasil disimpan
            if(result > 0)
            {
                MessageBox.Show("Successfully Saved Data !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return result;
        }

        // Login
        public bool Login (Users user)
        {
            bool result = false;
            if(string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
            {
                MessageBox.Show("Input not valid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            result = userRepository.Login(user);
            return result;
        }

        // Proses Logout
        public bool Logout()
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

        public void UserImage()
        {
            string userImage;
            string defaultImage = "default.jpg";

            // Ambil nama file dari database
            conn.OpenConnection();
            MySqlConnection connect = conn.GetConnection();

            string query = "SELECT image_profile FROM users WHERE id_user = @UserId";
            MySqlCommand cmd = new MySqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@UserId", CurrentUser.UserId);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    userImage = reader["image_profile"].ToString();
                }
                else
                {
                    userImage = defaultImage; // Jika tidak ditemukan, gunakan default
                }
            }
            conn.CloseConnection();

            // Path file gambar
            //string userPhotoPath = Path.Combine(imagesFolder, userPhotoFileName);

            // Jika file tidak ditemukan, gunakan default
            //if (!File.Exists(userPhotoPath))
            //{
            //    userPhotoPath = Path.Combine(imagesFolder, defaultPhoto);
            //}

            // Tampilkan foto
            //pbUser.Image = Image.FromFile(userPhotoPath);
            //pbUser.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
