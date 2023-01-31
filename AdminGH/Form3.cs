using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace AdminGH
{
    public partial class Form3 : Form
    {
        public Form2 form2;
        public Form1 form1;
        public Form4 form4;
        public Form5 form5;
        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo;
        public Admin_Interface.Services obj;
        public Form3(Admin_Interface.Services obj)
        {
            InitializeComponent();
            this.obj = obj;

            /*
             *  set text button access
             * 
             */
            string result = obj.camera_access();
            if (result.Equals("true"))
            {
                btn_camera.Text = "Deny Access";
            }
            else
            {
                btn_camera.Text = "Allow Access";
            }

            /*
             * Start the video  
             * 
             */
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in VideoCaptureDevices)
            {
                com_box.Items.Add(VideoCaptureDevice.Name);
            }
            com_box.SelectedIndex = 0;
            
        }
        void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap video = (Bitmap)eventArgs.Frame.Clone();
            pic.Image = video;

        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            FinalVideo = new VideoCaptureDevice(VideoCaptureDevices[com_box.SelectedIndex].MonikerString);
            FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
            FinalVideo.Start();
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

        private void btn_camera_Click(object sender, EventArgs e)
        {
            string text_access = btn_camera.Text;
            if (text_access.Equals("Allow Access"))
            {
                //
                btn_camera.Text = "Deny Access";
                obj.turn_on_camera();
              


            }
            else
            {
                //
                btn_camera.Text = "Allow Access";
                obj.turn_off();
                
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Hide();
            this.form1.Show();
            this.form2.Close();
            Hide();
            this.form1.Show();
            if (this.form2 != null)
            {
                this.form2.Close();

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

        private void guna2Button5_Click(object sender, EventArgs e)
        {
          
                Form4 form_4 = new Form4(obj);
                this.form4 = form_4;
              
                form_4.form3 = this;
                Hide();
                form_4.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (this.form5 == null)
            {
                Form5 form_5 = new Form5(obj);
                form_5.form3 = this;
                this.form5 = form_5;

            }
            Hide();
            this.form5.Show();
        }
    }
}
