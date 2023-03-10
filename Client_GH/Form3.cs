using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client_Interface;


namespace Client_GH
{
    public partial class Form3 : Form
    {
        Client_Interface.Services obj;
        public Form1 form1;
        public Form2 form2;

        public Form3(Client_Interface.Services obj)
        {
            InitializeComponent();
            this.obj = obj;

            // see if the measure of carbon is normal or not 

            bool result = obj.carbon_is_normal(); ;
            if (result)
            {
                carbon_text.Text = "CO2 <1000";
                carbon_circle.FillColor = Color.SpringGreen;


            }
            else
            {
                carbon_text.Text = "CO2 >1000";
                carbon_circle.FillColor = Color.Red;
            }

            // Display Carbon List 
            display_carbon_list();


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


        public void display_carbon_list()
        {

            List<Carbon> carbon_list = new List<Carbon>();

            carbon_list = obj.carbon_list();

            if (carbon_list != null)
            {
                foreach (var x in carbon_list)
                {



                    Guna.UI2.WinForms.Guna2Panel panel = new Guna.UI2.WinForms.Guna2Panel
                    {
                        Width = 700,
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

                        Text = "SV :" + x.getSv().ToString(),
                        ForeColor = Color.Black,
                        Width = 100,
                        Height = 28,
                        Font = new Font(" Century", 14, FontStyle.Bold),
                        Margin = new Padding(35, 30, 0, 0),
                        Padding = new Padding(15, 0, 0, 0),
                        Location = new Point(80, 10),
                        TabIndex = 10

                    }; Label time_tt = new Label()
                    {
                        Text = "Rzero : " + x.getRzero().ToString(),
                        ForeColor = Color.Black,
                        Width = 200,
                        Height = 28,
                        Margin = new Padding(3, 0, 3, 0),
                        Font = new Font(" Century", 14, FontStyle.Bold),
                        Location = new Point(200, 10),
                        TabIndex = 10

                    };
                    Label ppm = new Label()
                    {
                        Text = "PPM : " + x.getPpm().ToString(),
                        ForeColor = Color.Black,
                        Width = 200,
                        Height = 28,
                        Margin = new Padding(3, 0, 3, 0),
                        Font = new Font(" Century", 14, FontStyle.Bold),
                        Location = new Point(450, 10),
                        TabIndex = 10

                    };

                    panel.Controls.Add(btn_id);
                    panel.Controls.Add(username);
                    panel.Controls.Add(time_tt);
                    panel.Controls.Add(ppm);

                    flex_carbon.Controls.Add(panel);

                }
            }



        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            flex_carbon.Controls.Clear();
            // see if the measure of carbon is normal or not 

            bool result = obj.carbon_is_normal(); ;
            if (result)
            {
                carbon_text.Text = "CO2 <1000";
                carbon_circle.FillColor = Color.SpringGreen;


            }
            else
            {
                carbon_text.Text = "CO2 >1000";
                carbon_circle.FillColor = Color.Red;
            }

            // Display Carbon List 
            display_carbon_list();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (this.form1 == null)
            {
                Form1 form_1 = new Form1();
                this.form1 = form_1;
            }

            Hide();
            this.form1.Show();
            if (this.form2!= null)
            {
                this.form2.Close();
            }

            this.Close();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(this.form2 == null)
            {
                Form2 form_2 = new Form2(obj);
                form_2.form3 = this;
                this.form2 = form_2;

            }
            Hide();
            this.form2.Show();
        }
    }
}