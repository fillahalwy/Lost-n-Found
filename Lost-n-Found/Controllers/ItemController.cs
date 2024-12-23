using Lost_n_Found.Models.Entity;
using Lost_n_Found.Models.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lost_n_Found.Controllers
{
    internal class ItemController
    {
        private ItemRepository itemRepository = new ItemRepository();

        public List<Category> GetCategoryList()
        {
            return itemRepository.GetCategories();
        }


        public int AddItem(Items item)
        {
            int result = 0;
            if (string.IsNullOrWhiteSpace(item.Item_name) ||
                string.IsNullOrWhiteSpace(item.Item_description) ||
                item.Item_date == null ||
                string.IsNullOrWhiteSpace(item.Item_location) || 
                string.IsNullOrWhiteSpace(item.Item_note) ||
                string.IsNullOrWhiteSpace(item.Item_type) ||
                string.IsNullOrWhiteSpace(item.Item_status))
            {
                MessageBox.Show("Please input all data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show($"data : {item.Item_name}, {item.Item_description}, {item.Item_date}, {item.Item_location}, {item.Item_note}, {item.Item_type}, {item.Item_status}");
            }
            itemRepository.AddItem(item);

            //MessageBox.Show("Item Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Jika data berhasil disimpan
            if (result > 0)
            {
                MessageBox.Show("Successfully Saved Data !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return result;
        }
    }
}
