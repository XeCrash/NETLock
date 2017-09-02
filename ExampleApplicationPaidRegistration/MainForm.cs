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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ProgramStatistics ps = new ProgramStatistics();
            label2.Text = ps.UsersOnline();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            LogoutResponse lr = new LogoutResponse();
            if (lr.LogoutUpdate())
            {
                Process.GetCurrentProcess().Kill();
            }
            else
            {
                Process.GetCurrentProcess().Kill();
            }
        }
    }
}
