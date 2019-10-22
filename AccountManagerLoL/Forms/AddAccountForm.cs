using AccountManagerLoL.Source.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountManagerLoL.Forms
{
    public partial class AddAccountForm : Form
    {
        public event EventHandler userAdded;

        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void AddAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            userAdded(new Account(tb_name.Text, tb_username.Text, tb_password.Text), e);
            Close();
        }

        private void Tb_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
