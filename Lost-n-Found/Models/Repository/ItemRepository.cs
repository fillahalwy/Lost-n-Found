using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lost_n_Found.Models.Entity;
using System.Collections.Generic;
using Lost_n_Found.Models.Database;
using System.Data.SqlClient;
using Lost_n_Found.Controllers;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic;

namespace Lost_n_Found.Models.Repository
{
    internal class ItemRepository
    {

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
                        Id_item = (int)reader["id_items"],
                        Id_user = (int)reader["id_user"],
                        Id_category = (int)reader["id_category"],
                        Item_name = reader["item_name"].ToString(),
                        Item_img = reader["item_img"].ToString(),
                        Item_description = reader["item_description"].ToString(),
                        Item_date = reader["item_date"].ToString,
                        Item_location = reader["item_location"].ToString(),
                        Item_note = reader["item_note"].ToString(),
                        Item_type = reader["item_type"].ToString(),
                        Item_status = reader["item_status"].ToString(),
                        Created_at = (Timestamp)reader["created_at"],
                        Updated_at = (Timestamp)reader["updated_at"]
                    });


                }
                return items;
            } 
        }
    }
}
