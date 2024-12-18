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
using Lost_n_Found.Models.Entity;
using Lost_n_Found.Models.Repository;

namespace Lost_n_Found.Views.LoginForm
{
    public partial class LoginPage : UserControl
    {
        private Users user = new Users();
        private UserController userController = new UserController();

        public event Action ShowResetPass;
        public event Action ShowRegister;
        public event Action ShowHomepage;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            CenterPanel(loginCard, loginPanel);
        }

        // fungsi membuat card ke tengah
        private void CenterPanel(Panel childPanel, Panel basePanel)
        {
            // Hitung posisi tengah
            int centerX = (basePanel.Width - childPanel.Width) / 2;
            int centerY = (basePanel.Height - childPanel.Height) / 2;

            // Set posisi panel
            childPanel.Left = centerX;
            childPanel.Top = centerY;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            
            if(userController.Login(user))
            {
                txtUsername.Text = string.Empty; 
                txtPassword.Text = string.Empty;
                ShowHomepage?.Invoke();
            }
            
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowRegister?.Invoke();
        }

        private void linkToken_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendToken formEmail = new SendToken();
            formEmail.ShowDialog();
            ShowResetPass?.Invoke();
        }
    }
}
