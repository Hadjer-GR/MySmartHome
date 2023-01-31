
namespace Client_GH
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.com_box = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_start = new Guna.UI2.WinForms.Guna2Button();
            this.msg_camera = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(195)))), ((int)(((byte)(254)))));
            this.guna2Panel1.CausesValidation = false;
            this.guna2Panel1.Controls.Add(this.guna2Button6);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.btnlogin);
            this.guna2Panel1.Location = new System.Drawing.Point(1, -5);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(285, 732);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2Button6
            // 
            this.guna2Button6.Animated = true;
            this.guna2Button6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(195)))), ((int)(((byte)(254)))));
            this.guna2Button6.BorderRadius = 5;
            this.guna2Button6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.White;
            this.guna2Button6.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.Black;
            this.guna2Button6.Location = new System.Drawing.Point(15, 153);
            this.guna2Button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Padding = new System.Windows.Forms.Padding(13, 6, 7, 12);
            this.guna2Button6.Size = new System.Drawing.Size(251, 50);
            this.guna2Button6.TabIndex = 12;
            this.guna2Button6.Text = "Co2";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(195)))), ((int)(((byte)(254)))));
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(15, 633);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Padding = new System.Windows.Forms.Padding(13, 6, 7, 12);
            this.guna2Button1.Size = new System.Drawing.Size(251, 50);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "Logout ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Animated = true;
            this.btnlogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(195)))), ((int)(((byte)(254)))));
            this.btnlogin.BorderRadius = 5;
            this.btnlogin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlogin.FillColor = System.Drawing.Color.White;
            this.btnlogin.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Location = new System.Drawing.Point(0, 55);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Padding = new System.Windows.Forms.Padding(13, 6, 7, 12);
            this.btnlogin.Size = new System.Drawing.Size(296, 50);
            this.btnlogin.TabIndex = 8;
            this.btnlogin.Text = "Camera";
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Black;
            this.pic.Location = new System.Drawing.Point(303, 27);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1144, 542);
            this.pic.TabIndex = 3;
            this.pic.TabStop = false;
            // 
            // com_box
            // 
            this.com_box.BackColor = System.Drawing.Color.Transparent;
            this.com_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.com_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_box.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.com_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.com_box.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.com_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.com_box.ItemHeight = 30;
            this.com_box.Location = new System.Drawing.Point(352, 618);
            this.com_box.Name = "com_box";
            this.com_box.Size = new System.Drawing.Size(140, 36);
            this.com_box.TabIndex = 15;
            this.com_box.Visible = false;
            // 
            // btn_start
            // 
            this.btn_start.AccessibleName = "btn_start";
            this.btn_start.BorderRadius = 10;
            this.btn_start.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_start.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Location = new System.Drawing.Point(567, 618);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(180, 45);
            this.btn_start.TabIndex = 16;
            this.btn_start.Text = "Start";
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // msg_camera
            // 
            this.msg_camera.AccessibleName = "msg_camera";
            this.msg_camera.AutoSize = true;
            this.msg_camera.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_camera.Location = new System.Drawing.Point(817, 621);
            this.msg_camera.Name = "msg_camera";
            this.msg_camera.Size = new System.Drawing.Size(267, 33);
            this.msg_camera.TabIndex = 17;
            this.msg_camera.Text = "Authorized Access";
            this.msg_camera.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 726);
            this.Controls.Add(this.msg_camera);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.com_box);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private System.Windows.Forms.PictureBox pic;
        private Guna.UI2.WinForms.Guna2ComboBox com_box;
        private Guna.UI2.WinForms.Guna2Button btn_start;
        private System.Windows.Forms.Label msg_camera;
    }
}