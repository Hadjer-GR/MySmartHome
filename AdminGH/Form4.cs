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
    public partial class Form4 : Form

    {
        public Form1 form1;
        public Form2 form2;
         public Form3 form3;
        public Form5 form5;
         public  Admin_Interface.Services obj;
        public Form4(Admin_Interface.Services obj)
        {
            InitializeComponent();
            this.obj = obj;
            this.get_door_list();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void flex_door_Paint(object sender, PaintEventArgs e)
        {

        }

        public void  get_door_list()
        {

            List<Door> list_door = new List<Door>();

            list_door = obj.get_door_list();

            if (list_door != null)
            {
                foreach (var x in list_door)
                {


                    DateTime d = new DateTime(x.getTime_t().Ticks);
                    
                    

                    Guna.UI2.WinForms.Guna2Panel panel = new Guna.UI2.WinForms.Guna2Panel
                    {
                        Width = 500,
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
                        
                        Text = x.getDate(),
                        ForeColor = Color.Black,
                        Width = 120,
                        Height = 28,
                        Font = new Font(" Century", 14, FontStyle.Bold),
                        Margin = new Padding(35, 30, 0, 0),
                        Padding = new Padding(15, 0, 0, 0),
                        Location = new Point(80, 10),
                        TabIndex = 10

                    }; Label time_tt = new Label()
                    {
                        Text = d.ToLongTimeString(),
                        ForeColor = Color.Black,
                        Width = 150,
                        Height = 28,
                        Margin = new Padding(3, 0, 3, 0),
                        Font = new Font(" Century", 14, FontStyle.Bold),
                        Location = new Point(200, 10),
                        TabIndex = 10

                    };

                    panel.Controls.Add(btn_id);
                    panel.Controls.Add(username);
                    panel.Controls.Add(time_tt);
                    flex_door.Controls.Add(panel);

                }
            }







        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (this.form3 == null)
            {
                Form3 form_3 = new Form3(obj);
                this.form3 = form_3;
                Hide();
                form3.Show();
            }
            else
            {
                Hide();
                this.form3.Show();
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (this.form2 == null)
            {
                Form2 form_2 = new Form2(obj);
                form_2.form4 = this;
                this.form2 = form_2;

            }
            Hide();
            this.form2.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Hide();
            this.form1.Show();
            if (this.form2 != null)
            {
                this.form2.Close();

            }
            if (this.form3 != null)
            {
                this.form3.Close();

            }
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            flex_door.Controls.Clear();
            this.get_door_list();

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if(this.form5 == null)
            {
                Form5 form_5 = new Form5(obj);
                this.form5 = form_5;
                form_5.form4 = this;
            }
         
            Hide();
            this.form5.Show();
        }
    }
}
