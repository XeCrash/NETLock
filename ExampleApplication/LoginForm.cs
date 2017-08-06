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

        private void Form1_Load(object sender, EventArgs e)
        {
            AuthResponse response = new AuthResponse();
            if (response.AuthenticateProgram("DX=WmOTuBM$Ff$9pXqzj0BkBq"))
            {
                MessageBox.Show("Program has been authenticated!");
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
            if(login.Login(textBox1.Text, textBox2.Text))
            {
                Hide();
                new MainForm().Show();                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new RegistrationForm().Show();
        }
    }
}
