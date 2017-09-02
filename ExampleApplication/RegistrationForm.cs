using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using NETLock;

namespace ExampleApplication
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new LoginForm().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterResponse register = new RegisterResponse();
            if (register.FreeRegister(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("Registration was successful!");
            }
            else
            {
                MessageBox.Show("Registration Failed");
            }
        }
    }
}
