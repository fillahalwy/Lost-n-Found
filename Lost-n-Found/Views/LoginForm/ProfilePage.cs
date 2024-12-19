using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lost_n_Found.Controllers;

namespace Lost_n_Found.Views.LoginForm
{
    public partial class ProfilePage : UserControl
    {
        UserController userController = new UserController();

        public event Action ShowLogin;
        public event Action ShowHomepage;
        public event Action UpdateImage;

        public ProfilePage()
        {
            InitializeComponent();
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            pbImage.Image = Image.FromFile(userController.LoadUserImage());
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            lblName.Text = CurrentUser.Name;
            lblEmail.Text = CurrentUser.Email;
            lblUsername.Text = CurrentUser.Username;
            lblPhone.Text = CurrentUser.Phone;
            txtAddress.Text = CurrentUser.Address;
            lblGender.Text = (CurrentUser.Gender == "0") ? "Male" : "Female";
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            if (openFileImage.ShowDialog() == DialogResult.OK)
            {
                openFileImage.Filter = "Image File|*.jpg;*.jpeg;*.png;*.bmp";
                string sourceFile = openFileImage.FileName;
                userController.UpdateUserImage(sourceFile);
                pbImage.Image = Image.FromFile(userController.LoadUserImage());

                UpdateImage?.Invoke();
            }
       
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowHomepage?.Invoke();
        }
    }
}
