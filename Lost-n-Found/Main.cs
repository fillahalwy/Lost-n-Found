using Lost_n_Found.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lost_n_Found.Views.LoginForm;
using Lost_n_Found.Views.DashboardAdmin;
using Lost_n_Found.Views.Home;
using Lost_n_Found.Controllers.UserControllers;
using Lost_n_Found.Views.User;
using Lost_n_Found.Models.UserLogin;

namespace Lost_n_Found
{
    public partial class Main : Form
    {
        private UserLogin loginController = new UserLogin();

        private LoginPage login = new LoginPage();
        private RegisterPage register = new RegisterPage();
        private ResetPass resetPass = new ResetPass();
        private HomePage homePage = new HomePage();
        private ProfilePage profilePage = new ProfilePage();
        private DetailItem detailItem = new DetailItem();

        public Main()
        {
            InitializeComponent();

            login.ShowHomepage += () => loadView(homePage);

            if (loginController.IsLogin())
            {
                loadView(homePage);
            }
            else
            {
                loadView(login);
            }
        }

        // Fungsi untuk menampilkan view
        private void loadView(UserControl userControl)
        {
            mainPanel.Controls.Clear();
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);
        }

    }
}
