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

namespace Lost_n_Found.Views.LoginForm
{
    public partial class ResetPass : UserControl
    {
        UserRepository userRepository = new UserRepository();

        public event Action ShowLogin;

        public ResetPass()
        {
            InitializeComponent();
        }

        private void ResetPass_Load(object sender, EventArgs e)
        {
            CenterPanel(resetTokenCard, ResetPassPanel);
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string token = txtToken.Text.Trim();
            string newPass = txtPassword.Text;

            if (userRepository.VerifyToken(email, token))
            { 
                userRepository.UpdatePassword(email, newPass);
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtToken.Text = string.Empty;
                ShowLogin?.Invoke();
            }
            else
            {
                MessageBox.Show("Invalid or Expired token");
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtToken.Text = string.Empty;
            ShowLogin?.Invoke();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtToken.Text = string.Empty;
            ShowLogin?.Invoke();
        }
    }
}
