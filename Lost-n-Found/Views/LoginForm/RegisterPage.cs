using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lost_n_Found.Models.Repository;
using Lost_n_Found.Controllers;
using Lost_n_Found.Models.Entity;
using System.Security.Cryptography.X509Certificates;

namespace Lost_n_Found.Views.LoginForm
{
    public partial class RegisterPage : UserControl
    {
        Users user = new Users();
        UserController userController = new UserController();

        public event Action ShowLogin;

        public RegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {
            CenterPanel(registerCard, registerPanel);
        }

        private void CenterPanel(Panel childPanel, Panel basePanel)
        {
            // Hitung posisi tengah
            int centerX = (basePanel.Width - childPanel.Width) / 2;
            int centerY = (basePanel.Height - childPanel.Height) / 2;

            // Set posisi panel
            childPanel.Left = centerX;
            childPanel.Top = centerY;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            user.Email = txtEmail.Text;
            user.Name = txtName.Text;
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            user.Gender = GetGender();
            user.Address = txtAddress.Text;
            user.Phone = txtPhone.Text;

            int result = userController.Register(user);
            if (result > 0)
            {
                ShowLogin?.Invoke();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtName.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }

        // Fung untuk mengambil Gender
        private int GetGender()
        {
            if (rbMale.Checked)
            {
                return 1;
            }
            else if (rbFemale.Checked)
            {
                return 2;
            }
            return 0;
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLogin?.Invoke();
        }
    }
}
