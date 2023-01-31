using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Admin_Gh
{
    public partial class Form1 : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Txtusername_Enter(object sender, EventArgs e)
        {
            Txtusername.IconLeft = Properties.Resources.user_green;
        }

        private void Txtusername_Leave(object sender, EventArgs e)
        {
            Txtusername.IconLeft = Properties.Resources.user_off_white;
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.IconLeft = Properties.Resources.lock_green;
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.IconLeft = Properties.Resources.lock_off_white;
        }
    }
}
