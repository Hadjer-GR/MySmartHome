using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_GH
{
    public partial class Form1 : Form
    {
       public Client_Interface.Services obj;
        public Form1()
        {
            InitializeComponent();
            obj = (Client_Interface.Services)Activator.GetObject(typeof(Client_Interface.Services), "tcp://localhost:6500/obj_client");

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

         

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // result.Text =
            string user = username.Text;
            string pass=password.Text;
            bool is_account = false;

            if(!user.Equals("") && !pass.Equals(""))
            {
                is_account = obj.login(user, pass);
                if (is_account)
                {
                    label2.Text = "";
                    Form2 form2 = new Form2(obj);
                    form2.form1 = this;
                    form2.form1 = this;
                    Hide();
                    form2.Show();
                   
                }
                else
                {
                    label2.Text = "uncorrect password";
                }


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
