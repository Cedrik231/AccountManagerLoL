using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountManager
{
    public partial class Main : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
        );

        private bool mouseDown;
        private Point lastLocation;


        public Main()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            label_user.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;           
            visulizeUser();           
        }

        private void visulizeUser()
        {
            int counter = 0;
            foreach (var user in AccountController.GetAccounts())
            {
                AccountControl acc_panel = new AccountControl(user);
                acc_panel.on_delete += _refresh;
                acc_panel.Size = new Size(225, 50);               
                acc_panel.Location = new Point(10, (counter * acc_panel.Height) + (counter * 10));

                panel_accounts.Controls.Add(acc_panel);

                counter++;
            }

            
        }

        private void on_focus(object sender, EventArgs e)
        {
            (sender as TextBox).Clear();
            if ((sender as TextBox).Name == tb_password.Name)
                (sender as TextBox).PasswordChar = '*';
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;

            if (username == "" || username == "Username")
            {
                panel5.BackColor = Color.Red;
                return;
            }
            if (password == "" || password == "Password")
            {
                panel7.BackColor = Color.Red;
                return;
            }

            string created = DateTime.Now.ToString();
            string id = (AccountController.GetAccounts().Count + 1).ToString();

            Account ac = new Account()
            {
                Username = username,
                Password = password,
                Created = created,
                Id = id
            };

            if(AccountController.AddAccount(ac))
            {
                panel_accounts.Controls.Clear();
                visulizeUser();
            }
            else
            {

            }
        }

        private void btn_close_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _refresh(object sender, EventArgs e)
        {
            panel_accounts.Controls.Clear();
            visulizeUser();
        }

        #region Move

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion

        private void Btn_open_client_Click(object sender, EventArgs e)
        {
            var z = IsProgramInstalled("Google Chrome");


        }
        public static bool IsProgramInstalled(string programDisplayName)
        {
            List<string> progs = new List<string>();
            Console.WriteLine(string.Format("Checking install status of: {0}", programDisplayName));
            foreach (var item in Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall").GetSubKeyNames())
            {


                object programName = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\" + item).GetValue("DisplayName");
                if (programName!= null)
                    progs.Add(programName.ToString());
                Console.WriteLine(programName);

                if (string.Equals(programName, programDisplayName))
                {
                    Console.WriteLine("Install status: INSTALLED");
                    return true;
                }
            }
            Console.WriteLine("Install status: NOT INSTALLED");
            return false;
        }

    }
}
