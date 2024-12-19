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
using Lost_n_Found.Views.Home;
using Lost_n_Found.Views.LoginForm;
using Lost_n_Found.Views.DashboardAdmin;

namespace Lost_n_Found
{
    public partial class Main : Form
    {
        private UserController userController = new UserController();

        private LoginPage login = new LoginPage();
        private RegisterPage register = new RegisterPage();
        private ResetPass resetPass = new ResetPass();
        private HomePage homePage = new HomePage();
        private ProfilePage profilePage = new ProfilePage();
        private DetailItem detailItem = new DetailItem();
        private SendToken sendToken = new SendToken();

        public Main()
        {
            InitializeComponent();

            login.ShowHomepage += () => loadView(homePage);
            login.ShowRegister += () => loadView(register);
            login.ShowResetPass += () => loadView(resetPass);

            register.ShowLogin += () => loadView(login);

            resetPass.ShowLogin += () => loadView(login);
            sendToken.ShowResetPass += () => loadView(resetPass);

            homePage.ShowLogin += () => loadView(login);
            homePage.ShowProfile += () => loadView(profilePage);

            profilePage.ShowLogin += () => loadView(login);
            profilePage.ShowHomepage += () => loadView(homePage);

            profilePage.UpdateImage += homePage.UpdateProfileImage;

            if (userController.IsLogin())
            {
                loadView(homePage);
            }
            else
            {
                loadView(login);
            }

        }

        private void Login_ShowResetPass()
        {
            throw new NotImplementedException();
        }

        private void loadView()
        {
            throw new NotImplementedException();
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
