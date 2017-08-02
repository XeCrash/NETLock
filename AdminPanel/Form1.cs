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
    //The admin panel is for developer use only and should not be give to anyone
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthenticationMethods auth = new AuthenticationMethods();
            if(auth.InsertAuthToken())
            {
                tb_AuthToken.Clear();
                tb_AuthToken.Text = Properties.Settings.Default.AuthToken;
            }
            else
            {
                tb_AuthToken.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AuthenticationMethods auth = new AuthenticationMethods();
            if(auth.GrabCurrentAuthToken())
            {
                tb_AuthToken.Clear();
                tb_AuthToken.Text = Properties.Settings.Default.AuthToken;
            }
            else
            {
                tb_AuthToken.Clear();
            }
        }
    }

    public class AuthenticationMethods
    {
        ConnectionMethods cm = new ConnectionMethods();
        public string GenSerialKey(int length)
        {
            Random random = new Random();
            const string alphanumeric = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ=!#$1234567890";
            return new string(Enumerable.Repeat(alphanumeric, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public bool InsertAuthToken()
        {
            try
            {
                if(cm.OpenConnection())
                {
                    var SerialKey = GenSerialKey(25);
                    
                    string InsertAuthTokenToDatabase = $"INSERT INTO authentication(token) VALUES('{SerialKey}')";
                    if(!MultiAuthTokens())
                    {
                        MySqlCommand cmd = new MySqlCommand(InsertAuthTokenToDatabase, cm.conn);
                        cmd.ExecuteNonQuery();
                        cm.CloseConnection();
                        Properties.Settings.Default.AuthToken = SerialKey;
                        Properties.Settings.Default.Save();
                        return true;
                    }
                    else
                    {
                        cm.CloseConnection();
                        MessageBox.Show("There is an auth token that already exists.\nPlease grab the token from the database using the button below.");
                        return false;
                    }
                }
                else
                {
                    cm.CloseConnection();
                    return false;
                }
            }
            catch(Exception ex)
            {
                cm.CloseConnection();
                return false;
            }
        }

        public bool MultiAuthTokens()
        {
            try
            {
                string CheckAuthTokens = $"SELECT token FROM authentication";
                MySqlCommand cmd = new MySqlCommand(CheckAuthTokens, cm.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    cm.CloseConnection();
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                cm.CloseConnection();
                return false;
            }
        }

        public bool GrabCurrentAuthToken()
        {
            try
            {
                if (cm.OpenConnection())
                {
                    string GrabAuthToken = $"SELECT token FROM authentication";
                    MySqlCommand cmd = new MySqlCommand(GrabAuthToken, cm.conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        Properties.Settings.Default.AuthToken = reader.GetString(0);
                        Properties.Settings.Default.Save();
                        reader.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("No Auth token has been generated or stored in the database yet\nPlease generate a token using the button below!");
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                cm.CloseConnection();
                return false;
            }
        }
    }

    public class ConnectionMethods
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
