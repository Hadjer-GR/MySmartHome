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

namespace Client_GH
{
    public partial class Form2 : Form
    {
        public   Client_Interface.Services obj;
        public Form1 form1;
        public Form3 form3;
        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo;
        public Form2(Client_Interface.Services obj)
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
                btn_start.Enabled = true;
                msg_camera.Text = "Athourized access";
            }
            else
            {
                msg_camera.Text = "access is denied";
                btn_start.Enabled = false;
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            FinalVideo = new VideoCaptureDevice(VideoCaptureDevices[com_box.SelectedIndex].MonikerString);
            FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
            FinalVideo.Start();
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
            if (this.form3 != null)
            {
                this.form3.Close();
            }
           
            this.Close();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Form3 form_3 = new Form3(obj);
            form_3.form2 = this;
            form_3.form1 = this.form1;
            this.form3 = form_3;
            Hide();
            this.form3.Show();

        }
    }
}
