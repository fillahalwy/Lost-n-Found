using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lost_n_Found.Models.UserLogin;
using Lost_n_Found.Models.Entity;
using System.Security.Cryptography.X509Certificates;

namespace Lost_n_Found.Views.LoginForm
{
    public partial class RegisterPage : UserControl
    {
        Users user = new Users();

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

            //user.Email = txtEmail.Text;
        }

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
    }
}
