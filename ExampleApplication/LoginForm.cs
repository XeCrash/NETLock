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
                MessageBox.Show("Login Was successful!");
            }
            else
            {
                MessageBox.Show("Login has failed :(");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new RegistrationForm().Show();
        }
    }
}
