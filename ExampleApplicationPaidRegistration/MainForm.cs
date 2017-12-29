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
            AutoUpdateResponse aur = new AutoUpdateResponse();

            // Auto Update
            if (aur.CheckForUpdate("1.0.0.0"))
            {
                if (aur.DownloadUpdate(@"Updates\Update.rar"))
                {
                    MessageBox.Show("The update has now been downloaded please replace all olf files with the newely download files before re-opening the program to avoid this message again. THe program will now close!");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("THe update has failed please try again at a later time.");
                    Application.Exit();
                }
            }

            // Program statistics
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
                MessageBox.Show(lr.info);
                Process.GetCurrentProcess().Kill();
            }
        }
    }
}
