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
    public partial class SendToken : Form
    {
        UserRepository userRepository =  new UserRepository();

        public event Action ShowResetPass;

        public SendToken()
        {
            InitializeComponent();
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if(string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please Enter Your Email");
                return;
            }

            userRepository.GenerateSendToken(email);

            ShowResetPass?.Invoke();
            DialogResult = DialogResult.OK;
        }
    }
}
