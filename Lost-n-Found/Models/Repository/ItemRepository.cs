using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Lost_n_Found.Controllers;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic;
using Lost_n_Found.Views.Home;
using Lost_n_Found.Models.Entity;
using Lost_n_Found.Models.Database;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace Lost_n_Found.Models.Repository
{
    internal class ItemRepository
    {
        DatabaseConnection conn = new DatabaseConnection();
        public static List<Items> GetAllItems()
        {
            List<Items> items = new List<Items>();

            DatabaseConnection conn = new DatabaseConnection();
            MySqlConnection connection = conn.GetConnection();
 
            conn.OpenConnection();
            string query = "SELECT * FROM items";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    items.Add(new Items
                    {
                        Id_item = (int)reader["id_item"],
                        Id_user = (int)reader["id_user"],
                        Id_category = (int)reader["id_category"],
                        Item_name = reader["item_name"].ToString(),
                        Item_img = reader["item_img"].ToString(),
                        Item_description = reader["item_description"].ToString(),
                        Item_date = reader["item_date"].ToString(),
                        Item_location = reader["item_location"].ToString(),
                        Item_note = reader["item_note"].ToString(),
                        Item_type = reader["item_type"].ToString(),
                        Item_status = reader["item_status"].ToString(),
                        Created_at = reader["created_at"].ToString(),
                        Updated_at = reader["updated_at"].ToString()
                    });
                }
                return items;
            } 
        }

        public int AddItem(Items item)
        {
            int result = 0;
            try
            {
                // koneksi database
                conn.OpenConnection();
                MySqlConnection connection = conn.GetConnection();

                // memasukkan data ke database
                string query = "INSERT INTO items (id_user, id_category, item_name, item_img, item_description, item_date, item_location, item_note, item_type, item_status) values (@user,@category,@image,@description,@date,@location,@type,@status)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@user", CurrentUser.UserId);
                cmd.Parameters.AddWithValue("@category", item.Id_category);
                cmd.Parameters.AddWithValue("@image", item.Item_img);
                cmd.Parameters.AddWithValue("@description", item.Item_description);
                cmd.Parameters.AddWithValue("@date", item.Item_date);
                cmd.Parameters.AddWithValue("@location", item.Item_location);
                cmd.Parameters.AddWithValue("@type", item.Item_type);
                cmd.Parameters.AddWithValue("@status", item.Item_status);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfully Added", "Information", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Information);

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
    }
}
