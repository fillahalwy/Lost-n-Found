using Lost_n_Found.Controllers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lost_n_Found.Models.Database;
using System.Windows.Forms;
using Lost_n_Found.Models.Entity;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.Common;
using System.Net.Mail;
using System.Net;
using System.IO;
using Microsoft.VisualBasic;

namespace Lost_n_Found.Models.Repository
{
    internal class UserRepository
    {
        DatabaseConnection conn = new DatabaseConnection();

        public bool UserValidation(string username)
        {
            bool available = false;
            try
            {
                conn.OpenConnection();
                MySqlConnection connection = conn.GetConnection();

                string query = "SELECT username FROM users WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    available = true;
                }
                else
                {
                    available = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.CloseConnection();
            }
            return available;
        }

        // Proses Register
        public int Register(Users user)
        {
            int result = 0;
            try
            {
                // koneksi database
                conn.OpenConnection();
                MySqlConnection connection = conn.GetConnection();

                // memasukkan data ke database
                string query = "INSERT INTO users (email,name,username,password,gender,address,phone) values (@email,@name,@username,@password,@gender,@address,@phone)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@gender", user.Gender);
                cmd.Parameters.AddWithValue("@address", user.Address);
                cmd.Parameters.AddWithValue("@phone", user.Phone);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                result = 1;
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

        // Proses Login
        public bool Login(Users user)
        {
            bool result = false;
            try
            {
                conn.OpenConnection();
                MySqlConnection connection = conn.GetConnection();

                string query = "SELECT * FROM users WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    CurrentUser.UserId = reader["id_user"].ToString();
                    CurrentUser.Username = reader["username"].ToString();
                    CurrentUser.Password = reader["password"].ToString();
                    CurrentUser.Name = reader["name"].ToString();
                    CurrentUser.Email = reader["email"].ToString();
                    CurrentUser.Address = reader["address"].ToString();
                    CurrentUser.Image = reader["image_profile"].ToString();
                    CurrentUser.Gender = reader["gender"].ToString();
                    CurrentUser.Phone = reader["phone"].ToString();

                    result = true;
                }
                else
                {
                    result = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Get User and Pass Error: {0}", ex.Message);
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.CloseConnection();
            }
            return result;
        }

        // Read data user


        public void GenerateSendToken(string email)
        {
            try
            {
                conn.OpenConnection();
                MySqlConnection connect = conn.GetConnection();

                // cek apakah email benar
                string checkEmail = "SELECT COUNT(*) FROM users WHERE email = @email";
                MySqlCommand checkCmd = new MySqlCommand(checkEmail, connect);
                checkCmd.Parameters.AddWithValue("@email", email);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count == 0)
                {
                    MessageBox.Show("Email not found");
                    return;
                }

                //string resetToken = Guid.NewGuid().ToString(); //token unik
                string resetToken = GenerateToken(5);
                DateTime expiryTime = DateTime.Now.AddMinutes(10); //berlaku 10 menit

                // simpan token ke database
                string updateToken = "UPDATE users SET reset_token = @token, token_expiry = @expiry WHERE email = @email";
                MySqlCommand updateCmd = new MySqlCommand(updateToken, connect);
                updateCmd.Parameters.AddWithValue("@token", resetToken);
                updateCmd.Parameters.AddWithValue("@Expiry", expiryTime);
                updateCmd.Parameters.AddWithValue("@Email", email);
                updateCmd.ExecuteNonQuery();

                SendEmail(email, resetToken);
                MessageBox.Show("Reset Token Sent to Your Email", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        // generate token
        public string GenerateToken(int length)
        {
            const string kode = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(kode, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        // fungsi untuk mengirim email
        public void SendEmail(string email, string token)
        {
            string fromEmail = "ahmadfillahalwy12@gmail.com"; // email pengirim
            string fromPass = "sjxr trcg wclv juup"; // password email pengirim (password apps)
            string subject = "Password Reset Token";
            string body = $"Your password reset token is : {token}\n\n This token is valid for 10 minutes.";

            try
            {
                // kirim email ke user
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(email);
                mail.Subject = subject;
                mail.Body = body;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(fromEmail, fromPass);
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email : {ex.Message}");
            }
        }

        public bool VerifyToken(string email, string token)
        {
            try
            {
                conn.OpenConnection();
                MySqlConnection connection = conn.GetConnection();

                // Periksa token dan waktu kadaluarsa
                string query = "SELECT reset_token, token_expiry FROM users WHERE email = @Email";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Email", email);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedToken = reader["reset_token"]?.ToString();
                        DateTime? tokenExpiry = reader["token_expiry"] as DateTime?;

                        if (storedToken == token && tokenExpiry.HasValue && tokenExpiry > DateTime.Now)
                        {
                            return true; // Token valid
                        }
                    }
                }

                return false; // Token invalid atau kadaluarsa
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        public void UpdatePassword(string email, string newPassword)
        {
            try
            {
                conn.OpenConnection();
                MySqlConnection connection = conn.GetConnection();

                // Update password dan reset token
                string query = "UPDATE users SET password = @Password, reset_token = NULL, token_expiry = NULL WHERE email = @Email";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Password", newPassword); // Bisa ditambahkan hashing
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Password successfully reset.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        public string UserImage(string defaultImage, string imagesFolder)
        {
            string userImage;
            if(CurrentUser.Image == null)
            {
                userImage = defaultImage;
            }
            else
            {
                userImage = CurrentUser.Image.ToString();
            }
            // Ambil nama file dari database
            //conn.OpenConnection();
            //MySqlConnection connect = conn.GetConnection();

            //string query = "SELECT image_profile FROM users WHERE id_user = @UserId";
            //MySqlCommand cmd = new MySqlCommand(query, connect);
            //cmd.Parameters.AddWithValue("@UserId", CurrentUser.UserId);

            //using (MySqlDataReader reader = cmd.ExecuteReader())
            //{
            //    if (reader.Read())
            //    {
            //        userImage = reader["image_profile"].ToString();
            //    }
            //    else
            //    {
            //        userImage = defaultImage; // Jika tidak ditemukan, gunakan default
            //    }
            //}
            //conn.CloseConnection();


            // Path file gambar
            string userPhotoPath = Path.Combine(imagesFolder, userImage);

            // Jika file tidak ditemukan, gunakan default
            if (!File.Exists(userPhotoPath))
            {
                userPhotoPath = Path.Combine(imagesFolder, defaultImage);
            }

            return userPhotoPath;
        }

        public void AddImage(string sourceFile, string newFileName, string destinationFile)
        {

            // Simpan file baru
            File.Copy(sourceFile, destinationFile);

            // Hapus foto lama (jika ada)
            //DeletePreviousPhoto();

            // Simpan nama file baru ke database
            conn.OpenConnection();
            MySqlConnection connect = conn.GetConnection();

            string query = "UPDATE users SET image_profile = @FileName WHERE id_user = @UserId";
            MySqlCommand cmd = new MySqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@FileName", newFileName);
            cmd.Parameters.AddWithValue("@UserId", CurrentUser.UserId);
            cmd.ExecuteNonQuery();

            conn.CloseConnection();
        }

        //private void DeletePreviousPhoto(string imagesFolder)
        //{
        //    string previousPhotoFileName;

        //    // Ambil nama file lama dari database
        //    conn.OpenConnection();
        //    MySqlConnection connect = conn.GetConnection();

        //    string query = "SELECT image_profile FROM users WHERE id_user = @UserId";
        //    MySqlCommand cmd = new MySqlCommand(query, connect);
        //    cmd.Parameters.AddWithValue("@UserId", CurrentUser.UserId);

        //    using (MySqlDataReader reader = cmd.ExecuteReader())
        //    {
        //        if (reader.Read())
        //        {
        //            previousPhotoFileName = reader["image_profile"].ToString();
        //        }
        //        else
        //        {
        //            conn.CloseConnection();
        //            return;
        //        }
        //    }
        //    conn.CloseConnection();

        //    // Jangan hapus foto default
        //    if (previousPhotoFileName == "default.jpeg")
        //        return;

        //    // Path file lama
        //    string previousPhotoPath = Path.Combine(imagesFolder, previousPhotoFileName);

        //    // Hapus file lama jika ada
        //    if (File.Exists(previousPhotoPath))
        //    {
        //        try
        //        {
        //            // Dispose gambar dari PictureBox jika masih digunakan
        //            if (pbUser.Image != null)
        //            {
        //                pbUser.Image.Dispose();
        //                pbUser.Image = null;
        //            }

        //            // Hapus file
        //            File.Delete(previousPhotoPath);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error deleting previous photo: {ex.Message}");
        //        }
        //    }
        //}

    }
}
