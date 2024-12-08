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
using Lost_n_Found.Controllers.UserControllers;

namespace Lost_n_Found.Views.LoginForm
{
    public partial class LoginPage : UserControl
    {
        private LoginController login = new LoginController();


        public event Action ShowForgotPass;
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
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if(login.LoginProcess(username, password))
            {
                ShowHomepage?.Invoke();
                txtUsername.Text = null;
                txtPassword.Text = null;
            }
        }
    }
}
