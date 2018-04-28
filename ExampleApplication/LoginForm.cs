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

namespace ExampleApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            AuthResponse response = new AuthResponse();
            if (response.AuthenticateProgram("SHqMEAi6KDTi1H=Hcr$E9E#UQ")) //Change to match the Auth token you generate to use without error.
            {
                if (response.FreeModeActive) //This is only if you wish to have free mode implemented in your application
                {
                    response.ExecuteFreeMode(new MainForm(), this);
                }
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
            LoginResponse login = new LoginResponse();
            if(login.Login(tb_username.Text, tb_password.Text))
            {
                Hide();
                new MainForm().Show();                
            }
            else
            {
                MessageBox.Show(login.info);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new RegistrationForm().Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
