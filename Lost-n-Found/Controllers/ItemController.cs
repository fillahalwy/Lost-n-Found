using Lost_n_Found.Models.Entity;
using Lost_n_Found.Models.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lost_n_Found.Controllers
{
    internal class ItemController
    {
        //private void LoadItems()
        //{
        //    List<Items> items = ItemRepository.GetAllItems();
        //    panelHomeContainer.Controls.Clear(); // Bersihkan panel sebelum menambahkan data

        //    if (items.Count == 0)
        //    {
        //        Label noDataLabel = new Label
        //        {
        //            Text = "Data tidak ada.",
        //            AutoSize = true,
        //            Font = new Font("Arial", 16, FontStyle.Bold),
        //            ForeColor = Color.Gray,
        //            Dock = DockStyle.Top,
        //            TextAlign = ContentAlignment.MiddleCenter
        //        };
        //        panelHomeContainer.Controls.Add(noDataLabel);
        //        return;
        //    }

        //    foreach (var item in items)
        //    {
        //        Panel card = new Panel
        //        {
        //            Size = new Size(200, 300),
        //            BorderStyle = BorderStyle.FixedSingle,
        //            Margin = new Padding(10)
        //        };

        //        PictureBox pictureBox = new PictureBox
        //        {
        //            Size = new Size(180, 180),
        //            Location = new Point(10, 10),
        //            //Image = File.Exists(item.Item_img) ? Image.FromFile(item.ImagePath) : Properties.Resources.DefaultImage,
        //            SizeMode = PictureBoxSizeMode.Zoom
        //        };

        //        Label nameLabel = new Label
        //        {
        //            Text = item.Item_name,
        //            Location = new Point(10, 200),
        //            AutoSize = true,
        //            Font = new Font("Arial", 10, FontStyle.Bold)
        //        };

        //        Label descriptionLabel = new Label
        //        {
        //            Text = item.Item_description,
        //            Location = new Point(10, 220),
        //            AutoSize = true,
        //            Font = new Font("Arial", 8),
        //            ForeColor = Color.Gray
        //        };

        //        LinkLabel detailLink = new LinkLabel
        //        {
        //            Text = "View Details",
        //            Location = new Point(10, 260),
        //            AutoSize = true,
        //            Tag = item.Id_item // Simpan ID untuk digunakan saat diklik
        //        };
        //        detailLink.Click += (s, e) => ViewDetails((int)((LinkLabel)s).Tag);

        //        card.Controls.Add(pictureBox);
        //        card.Controls.Add(nameLabel);
        //        card.Controls.Add(descriptionLabel);
        //        card.Controls.Add(detailLink);

        //        panelHomeContainer.Controls.Add(card);
        //        panelHomeContainer.AutoScroll = true;
        //        panelHomeContainer.WrapContents = true; // Menjadikan layout membungkus ke baris baru jika melebihi lebar panel
        //        panelHomeContainer.FlowDirection = FlowDirection.LeftToRight;

        //    }
        //}
    }
}
