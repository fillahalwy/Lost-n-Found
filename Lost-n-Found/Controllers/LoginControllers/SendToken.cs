using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lost_n_Found.Models.Database;

using MessageBox = System.Windows.Forms.MessageBox;
using System.Net.Mail;
using System.Net;

namespace Lost_n_Found.Controllers.UserControllers
{

    internal class SendToken
    {
        private DatabaseConnection conn = new DatabaseConnection();

        public string GenerateToken(int length)
        {
            const string kode = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(kode, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

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
                DateTime expiryTime = DateTime.Now.AddMinutes(10); //berlaku 15 menit

                // simpan token ke database
                string updateToken = "UPDATE users SET reset_token = @token, token_expiry = @expiry WHERE email = @email";
                MySqlCommand updateCmd = new MySqlCommand(updateToken, connect);
                updateCmd.Parameters.AddWithValue("@token", resetToken);
                updateCmd.Parameters.AddWithValue("@Expiry", expiryTime);
                updateCmd.Parameters.AddWithValue("@Email", email);
                updateCmd.ExecuteNonQuery();

                SendEmail(email, resetToken);
                MessageBox.Show("Reset Token Sent to Your Email");
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

        public void SendEmail(string email, string token)
        {
            string fromEmail = "ahmadfillahalwy12@gmail.com"; // email pengirim
            string fromPass = "sjxr trcg wclv juup"; // password email pengirim (password apps)
            string subject = "Password Reset Token";
            string body = $"Your password reset token is : {token}\n\n. This token is valid for 10 minutes.";

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


    }
}
