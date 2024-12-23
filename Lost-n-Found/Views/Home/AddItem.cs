using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lost_n_Found.Controllers;
using Lost_n_Found.Models.Entity;
using TheArtOfDev.HtmlRenderer.Adapters;

namespace Lost_n_Found.Views.Home
{
    public partial class AddItem : UserControl
    {
        private ItemController itemController = new ItemController();
        private Items item = new Items();
        string sourceFile;
        string fileName;

        public AddItem()
        {
            InitializeComponent();
            LoadCategories();
        }


        private void btnImage_Click(object sender, EventArgs e)
        {
            if (openFileImage.ShowDialog() == DialogResult.OK)
            {
                openFileImage.Filter = "Image File|*.jpg;*.jpeg;*.png;*.bmp";
                sourceFile = openFileImage.FileName;
                string imagesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ItemImages"); // Folder gambar
                fileName = Guid.NewGuid().ToString() + Path.GetExtension(sourceFile); // Nama file unik
                string destinationFile = Path.Combine(imagesFolder, fileName);
                File.Copy(sourceFile, destinationFile);
                string itemImagePath = Path.Combine(imagesFolder, fileName);

                btnImage.Image = Image.FromFile(itemImagePath);
            }
        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //var selectedCategory = cmbItemsCategory.SelectedItem as Category;
            item.Id_user = int.Parse(CurrentUser.UserId);
            item.Item_name = txtItemName.Text;
            item.Item_description = txtItemDescription.Text;
            item.Item_date = dateItemDate.Value;
            item.Item_location = txtItemLocation.Text;
            item.Item_note = txtItemNote.Text;
            item.Item_type = GetItemType();
            item.Item_status = GetItemStatus();
            item.Item_img = fileName;
            //MessageBox.Show($"data : {item.Id_category}");
            itemController.AddItem(item);
        }

        private string GetItemType()
        {
            string type = null;
            if (rbLost.Checked)
            {
                type="Lost";
            }
            else if (rbFound.Checked)
            {
                type="Found";
            }
            return type;
        }

        private string GetItemStatus()
        {
            string status = null;
            if (rbClaimed.Checked)
            {
                status = "Claimed";
            }
            else if (rbUnclaimed.Checked)
            {
                status = "Unclaimed";
            }
            return status;
        }

        private void LoadCategories()
        {
            cmbItemsCategory.DisplayMember = "Name"; // Nama kategori yang akan ditampilkan
            cmbItemsCategory.ValueMember = "Id";    // ID kategori sebagai value
            try
            {
                // Ambil data kategori dari controller
                var categories = itemController.GetCategoryList();
                // Tambahkan data ke dropdown
                cmbItemsCategory.Items.Clear();
                foreach (var category in categories)
                {
                    cmbItemsCategory.Items.Add(category);
                }

                //Set default selected item
                if (cmbItemsCategory.Items.Count > 0)
                {
                    cmbItemsCategory.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbItemsCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategoryId = cmbItemsCategory.SelectedItem as Category;
            if (selectedCategoryId != null)
            {
                item.Id_category = selectedCategoryId.Id;
            }

        }
    }
}
