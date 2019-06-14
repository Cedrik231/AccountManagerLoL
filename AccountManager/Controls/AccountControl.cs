using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountManager
{
    internal  partial class AccountControl : UserControl
    {
        Account acc;
        public event EventHandler on_delete;
        public AccountControl(Account acc)
        {
            InitializeComponent();
            this.acc = acc;            
        }

        private void AccountControl_Load(object sender, EventArgs e)
        {
            label_user.Text = acc.Username;
        }

        private void on_mouse_down(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var menu = new ContextMenuStrip();
                var item = new ToolStripMenuItem("Copy User");
                item.Image = new Bitmap(Constants.PicturePath + "user.png");
                item.Click += copy_user_Click;
                
                var item1 = new ToolStripMenuItem("Copy Password");
                item1.Image = new Bitmap(Constants.PicturePath + "password.png");
                item1.Click += copy_password_Click;

                var item2 = new ToolStripMenuItem("Delete User");
                item2.Image = new Bitmap(Constants.PicturePath + "delete.png");
                item2.Click += delete_user_Click;


                menu.Items.AddRange(new ToolStripItem[] {item,item1,item2 });
                menu.Show(this, this.PointToClient(MousePosition));
            }
        }

        private void copy_user_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(acc.Username);
        }
        private void copy_password_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(acc.Password);
        }
        private void delete_user_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Möchten Sie den Nutzer " + acc.Username + " löschen ?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(AccountController.DeleteAccount(acc))
                {
                    on_delete(null, null);
                }
                else
                {

                }
            }
        }
    }
}
