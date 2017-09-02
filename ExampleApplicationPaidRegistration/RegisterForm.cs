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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterResponse register = new RegisterResponse();
            if (register.PaidRegister(textBox1.Text, textBox2.Text, textBox3.Text))
            {
                MessageBox.Show("Registration was successful!");
                Hide();
                new LoginForm().Show();
            }
            else
            {
                MessageBox.Show("Registration failed. Please make sure the license match's the one sent to you. If it is this could mean the license has already been redeemed before.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
