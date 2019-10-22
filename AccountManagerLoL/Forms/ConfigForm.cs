using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;
using AccountManagerLoL.Resources.Consts;
using RiotAPIv4;
using System.Runtime.InteropServices;
using System.Threading;

namespace AccountManagerLoL.Forms
{
    public partial class ConfigForm : Form
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        
        private static JObject config = JObject.Parse(File.ReadAllText(Constants.PATHTOCONFIG));

        public event EventHandler configSaved;

        RiotApi api;

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void Btn_test_key_Click(object sender, EventArgs e)
        {
            api = new RiotApi(tb_apikey.Text, Regions.EUW);
            if (api.IsValidApiKey)
            {
                tb_apikey.BackColor = Color.LawnGreen;
            }
            else
            {
                tb_apikey.BackColor = Color.Maroon;
            }
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            var apikeyJson = config.SelectToken("apikey");
            apikeyJson.Replace(tb_apikey.Text);
            config.SelectToken("kordsUser.X").Replace(tb_user_x.Text);
            config.SelectToken("kordsUser.Y").Replace(tb_user_y.Text);
            config.SelectToken("kordsPassword.X").Replace(tb_pw_x.Text);
            config.SelectToken("kordsPassword.Y").Replace(tb_pw_y.Text);
            File.WriteAllText(Constants.PATHTOCONFIG, config.ToString());
            configSaved(null, null);
            this.Close();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {           
            tb_apikey.Text = config.SelectToken("apikey").ToString();
            tb_user_x.Text = config.SelectToken("kordsUser.X").ToString();
            tb_user_y.Text = config.SelectToken("kordsUser.Y").ToString();
            tb_pw_x.Text = config.SelectToken("kordsPassword.X").ToString();
            tb_pw_y.Text = config.SelectToken("kordsPassword.Y").ToString();
            api = new RiotApi(tb_apikey.Text, Regions.EUW);
            if (!api.IsValidApiKey)
            {
                tb_apikey.BackColor = Color.Maroon;
            }
        }

        private void Btn_test_user_Click(object sender, EventArgs e)
        {
            Cursor.Position = new Point(Convert.ToInt32(tb_user_x.Text), Convert.ToInt32(tb_user_y.Text));

            new Thread(DoMouseClick).Start();

           
        }

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            long X = (long) Cursor.Position.X;
            long Y = (long) Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);           
        }

        private void Btn_test_pw_Click(object sender, EventArgs e)
        {
            Cursor.Position = new Point(Convert.ToInt32(tb_pw_x.Text), Convert.ToInt32(tb_pw_y.Text));
            new Thread(DoMouseClick).Start();
            
        }
    }
}
