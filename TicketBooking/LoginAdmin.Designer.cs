namespace TicketBooking
{
    partial class LoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            Loginbtn = new Button();
            Passwordtxt = new TextBox();
            Emailtxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(702, 585);
            label1.Name = "label1";
            label1.Size = new Size(274, 50);
            label1.TabIndex = 15;
            label1.Text = "ADMIN LOGIN";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(589, 176);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(468, 438);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // Loginbtn
            // 
            Loginbtn.BackColor = Color.Maroon;
            Loginbtn.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbtn.ForeColor = SystemColors.ButtonFace;
            Loginbtn.Location = new Point(670, 916);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(328, 55);
            Loginbtn.TabIndex = 13;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += Loginbtn_Click;
            Loginbtn.MouseLeave += Loginbtn_MouseLeave;
            Loginbtn.MouseHover += Loginbtn_MouseHover;
            // 
            // Passwordtxt
            // 
            Passwordtxt.Location = new Point(792, 796);
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.Size = new Size(280, 39);
            Passwordtxt.TabIndex = 12;
            // 
            // Emailtxt
            // 
            Emailtxt.Location = new Point(792, 695);
            Emailtxt.Name = "Emailtxt";
            Emailtxt.Size = new Size(280, 39);
            Emailtxt.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(561, 796);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(179, 46);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(561, 695);
            label2.Name = "label2";
            label2.Size = new Size(115, 46);
            label2.TabIndex = 9;
            label2.Text = "Email";
            // 
            // LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1883;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1666, 1111);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(Loginbtn);
            Controls.Add(Passwordtxt);
            Controls.Add(Emailtxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "LoginAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private Button Loginbtn;
        private TextBox Passwordtxt;
        private TextBox Emailtxt;
        private Label label3;
        private Label label2;
    }
}