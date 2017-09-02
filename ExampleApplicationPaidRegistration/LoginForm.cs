using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NETLock;
using System.Diagnostics;

namespace ExampleApplicationPaidRegistration
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            AuthResponse response = new AuthResponse();
            if (response.AuthenticateProgram("O=WzXh0$d#Zr9b28GEQxj5ifC")) //Chnage to match the Auth token you generate to use without error.
            {
                
            }
            else
            {
                MessageBox.Show("Mismatch in program authentication tokens has been noticed. Program will now close for security purposes.");
                Application.Exit();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginResponse lr = new LoginResponse();
            if (lr.Login(tb_username.Text, tb_password.Text))
            {
                Hide();
                new MainForm().Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new RegisterForm().Show();
        }
    }
}
