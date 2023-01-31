using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin_Interface;
using System.Collections;
namespace AdminGH
{
    public partial class Form2 : Form
    {
        public Admin_Interface.Services obj;
        public Form1 form1;
        public Form3 form3;
        public Form4 form4;
        public Form5 form5;

        public Form2(Admin_Interface.Services obj)
        {
            InitializeComponent();
          
            this.obj = obj;
            gat_list_account();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Hide();
            this.form1.Show();
  
            this.form1.Show();
            if (this.form3 != null)
            {
                this.form3.Close();

            }
            if (this.form4 != null)
            {
                this.form4.Close();

            }
            if (this.form5 != null)
            {
                this.form5.Close();

            }

            this.Close();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form3 form_3 = new Form3(obj);
            this.form3 = form_3;
           
            form_3.form2 = this;
            form_3.form1 = this.form1;
            Hide();
            form_3.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            string user = add_user.Text;
            string pass = add_pass.Text;

            if (!user.Equals("") && !pass.Equals(""))
            {
                obj.add_account(user, pass);
                add_user.Text = "";
                add_pass.Text = "";

            }
            flex.Controls.Clear();
            gat_list_account();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = delete_id.Text;
            if (!id.Equals("")) {
                obj.delete_account(int.Parse(id));
                delete_id.Text="";
            }
            flex.Controls.Clear();
            gat_list_account();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void gat_list_account() {

            List<Account> lisy_accounts = new List<Account>();
           
                lisy_accounts = obj.get_account_list();
            
                if (lisy_accounts != null)
                {
                    foreach (var x in lisy_accounts)
                    {



                        Guna.UI2.WinForms.Guna2Panel panel = new Guna.UI2.WinForms.Guna2Panel
                        {
                            Width = 360,
                            Height = 80,
                            BorderColor = Color.FromArgb(64, 64, 64),
                            BorderThickness = 2,
                            Margin = new Padding(3, 3, 3, 20),
                            BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash,
                            Enabled = true

                        };
                        Guna.UI2.WinForms.Guna2CircleButton btn_id = new Guna.UI2.WinForms.Guna2CircleButton
                        {
                            Text = x.getId().ToString(),
                            Width = 57,
                            Height = 54,
                            BackColor = Color.White,
                            Margin = new Padding(3, 3, 3, 3),
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            FillColor = Color.FromArgb(94, 148, 255),
                            Location = new Point(10, 10)
                        };
                        Label username = new Label()
                        {
                            Text = x.getUser().ToString(),
                            ForeColor = Color.Black,
                            Width = 95,
                            Height = 28,
                            Font = new Font(" Century", 14, FontStyle.Bold),
                            Margin = new Padding(35, 30, 0, 0),
                            Padding = new Padding(15, 0, 0, 0),
                            Location = new Point(80, 10),
                            TabIndex = 10

                        }; Label password = new Label()
                        {
                            Text = x.getPass().ToString(),
                            ForeColor = Color.Black,
                            Width = 95,
                            Height = 28,
                            Margin = new Padding(3, 0, 3, 0),
                            Font = new Font(" Century", 14, FontStyle.Bold),
                            Location = new Point(200, 10),
                            TabIndex = 10

                        };

                        panel.Controls.Add(btn_id);
                        panel.Controls.Add(username);
                        panel.Controls.Add(password);
                        flex.Controls.Add(panel);

                    }
                }
               
           
        
           
       
        
        
        }

        private void list_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void list_account_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form4 form_4 = new Form4(obj);
            this.form4 = form_4;
            form_4.form1 = this.form1;
            form_4.form2 = this;
            Hide();
            form_4.Show();
        }

        private void flex_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Form5 form_5 = new Form5(obj);
            this.form5 = form_5;
            form_5.form2 = this;
            Hide();
            form_5.Show();
        }
    }
}
