namespace TicketBooking
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            imageList3 = new ImageList(components);
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btnregister = new Button();
            btnadmin = new Button();
            chkShowPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(477, 455);
            label2.Name = "label2";
            label2.Size = new Size(115, 46);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(477, 556);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(179, 46);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(708, 455);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 39);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(708, 556);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 39);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Maroon;
            btnLogin.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(585, 729);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(328, 55);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            btnLogin.MouseHover += btnLogin_MouseHover;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "movie.jpg");
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // imageList3
            // 
            imageList3.ColorDepth = ColorDepth.Depth32Bit;
            imageList3.ImageStream = (ImageListStreamer)resources.GetObject("imageList3.ImageStream");
            imageList3.TransparentColor = Color.Transparent;
            imageList3.Images.SetKeyName(0, "movie.jpg");
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(503, -30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(468, 438);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(616, 358);
            label1.Name = "label1";
            label1.Size = new Size(237, 50);
            label1.TabIndex = 8;
            label1.Text = "USER LOGIN";
            // 
            // btnregister
            // 
            btnregister.BackColor = Color.Maroon;
            btnregister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregister.ForeColor = SystemColors.ButtonHighlight;
            btnregister.Location = new Point(1204, 822);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(193, 46);
            btnregister.TabIndex = 9;
            btnregister.Text = "Register Now";
            btnregister.UseVisualStyleBackColor = false;
            btnregister.Click += button1_Click;
            btnregister.MouseLeave += btnregister_MouseLeave;
            btnregister.MouseHover += button1_MouseHover;
            // 
            // btnadmin
            // 
            btnadmin.BackColor = Color.Maroon;
            btnadmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadmin.ForeColor = SystemColors.ButtonHighlight;
            btnadmin.Location = new Point(1204, 889);
            btnadmin.Name = "btnadmin";
            btnadmin.Size = new Size(193, 46);
            btnadmin.TabIndex = 11;
            btnadmin.Text = "Admin Login";
            btnadmin.UseVisualStyleBackColor = false;
            btnadmin.Click += btnadmin_Click;
            btnadmin.MouseLeave += btnadmin_MouseLeave;
            btnadmin.MouseHover += btnadmin_MouseHover;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.ForeColor = Color.White;
            chkShowPassword.Location = new Point(780, 610);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(208, 36);
            chkShowPassword.TabIndex = 12;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            BackgroundImage = Properties.Resources._1883;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1464, 970);
            Controls.Add(chkShowPassword);
            Controls.Add(btnadmin);
            Controls.Add(btnregister);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private ImageList imageList1;
        private ImageList imageList2;
        private ImageList imageList3;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btnregister;
        private Button btnadmin;
        private CheckBox chkShowPassword;
    }
}
