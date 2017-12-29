using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AdminPanel
{
    public partial class AppVersionandUpdateForm : Form
    {
        private bool EditVersion = false;
        private bool EditDownloadLink = false;
        public string VersionInfo;
        public string DownloadLinkInfo;
        ConnectionMethods cm = new ConnectionMethods();
        public AppVersionandUpdateForm()
        {
            InitializeComponent();
        }

        private void AppVersionandUpdateForm_Load(object sender, EventArgs e)
        {
            if(!ApplicationVersion())
            {
                MessageBox.Show("Something went wrong please make sure you are connected to the database.");
            }

            if(!ApplicationUpdateLink())
            {
                MessageBox.Show("Something went wrong please make sure you are connected to the database.");
            }

            VersionInfo = textBox1.Text;
            DownloadLinkInfo = textBox2.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (EditVersion == false)
            {
                linkLabel1.Text = "Cancel";
                textBox1.ReadOnly = false;
                EditVersion = true;
            }
            else
            {
                linkLabel1.Text = "Edit";
                textBox1.ReadOnly = true;
                EditVersion = false;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (EditDownloadLink == false)
            {
                linkLabel2.Text = "Cancel";
                textBox2.ReadOnly = false;
                EditDownloadLink = true;
            }
            else
            {
                linkLabel2.Text = "Edit";
                textBox2.ReadOnly = true;
                EditDownloadLink = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!SubmitChanges())
            {
                MessageBox.Show("Something went wrong please make sure you are connected to the database.");
            }
            else
            {
                MessageBox.Show("Application Version and Download Link have been updated successfully!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = VersionInfo;
            textBox2.Text = DownloadLinkInfo;
            linkLabel1.Text = "Edit";
            linkLabel2.Text = "Edit";
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            EditVersion = false;
            EditDownloadLink = false;
        }

        #region Grab Info From database
        public bool ApplicationVersion()
        {
            if(cm.OpenConnection())
            {
                string GrabAppVersion = "SELECT appversion FROM administration";
                MySqlCommand cmd = new MySqlCommand(GrabAppVersion, cm.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if(reader.HasRows)
                {
                    textBox1.Text = reader.GetString(0);
                    reader.Close();
                    cm.CloseConnection();
                    return true;
                }
                else
                {
                    textBox1.Text = "";
                    reader.Close();
                    cm.CloseConnection();
                    return false;
                }
            }
            else
            {
                cm.CloseConnection();
                return false;
            }
        }

        public bool ApplicationUpdateLink()
        {
            if (cm.OpenConnection())
            {
                string Grabdownloadlink = "SELECT downloadlink FROM administration";
                MySqlCommand cmd = new MySqlCommand(Grabdownloadlink, cm.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    textBox2.Text = reader.GetString(0);
                    reader.Close();
                    cm.CloseConnection();
                    return true;
                }
                else
                {
                    textBox2.Text = "";
                    reader.Close();
                    cm.CloseConnection();
                    return false;
                }
            }
            else
            {
                cm.CloseConnection();
                return false;
            }
        }

        public bool SubmitChanges()
        {
            try
            {
                if (cm.OpenConnection())
                {
                    string UpdateInfo = $"UPDATE `administration` SET `appversion`='{textBox1.Text}',`downloadlink`='{textBox2.Text}'";
                    MySqlCommand cmd = new MySqlCommand(UpdateInfo, cm.conn);
                    cmd.ExecuteNonQuery();
                    cm.CloseConnection();
                    VersionInfo = textBox1.Text;
                    DownloadLinkInfo = textBox2.Text;
                    linkLabel1.Text = "Edit";
                    linkLabel2.Text = "Edit";
                    textBox1.ReadOnly = true;
                    textBox2.ReadOnly = true;
                    EditVersion = false;
                    EditDownloadLink = false;
                    return true;
                }
                else
                {
                    cm.CloseConnection();
                    return false;
                }
            }
            catch
            {
                cm.CloseConnection();
                return false;
            }
        }
        #endregion
    }

    internal class ConnectionMethods
    {
        //The Connection string will vary from person to person so make sure to change it to fit your needs.
        //In the example below I will be using xampp to host the database on my local machine.
        public MySqlConnection conn = new MySqlConnection("Server=localhost; Uid=root; Pwd=; Database=mass;");

        public bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 1042:

                        break;
                    case 1045:

                        break;
                }
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
