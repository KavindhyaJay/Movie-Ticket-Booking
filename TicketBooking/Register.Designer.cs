namespace TicketBooking
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            button1 = new Button();
            label4 = new Label();
            txtName = new TextBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(526, 477);
            label1.Name = "label1";
            label1.Size = new Size(476, 59);
            label1.TabIndex = 0;
            label1.Text = "New User Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(463, 655);
            label2.Name = "label2";
            label2.Size = new Size(250, 45);
            label2.TabIndex = 1;
            label2.Text = "Enter Your Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(463, 731);
            label3.Name = "label3";
            label3.Size = new Size(308, 45);
            label3.TabIndex = 2;
            label3.Text = "Enter New Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(845, 731);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(243, 39);
            txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(845, 659);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(243, 39);
            txtEmail.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(661, 835);
            button1.Name = "button1";
            button1.Size = new Size(198, 61);
            button1.TabIndex = 5;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(463, 586);
            label4.Name = "label4";
            label4.Size = new Size(259, 45);
            label4.TabIndex = 6;
            label4.Text = "Enter Your Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(845, 586);
            txtName.Name = "txtName";
            txtName.Size = new Size(243, 39);
            txtName.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(526, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(469, 455);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.BackgroundImage = Properties.Resources.Asset_1;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(42, 37);
            button2.Name = "button2";
            button2.Size = new Size(96, 90);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1883;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1470, 1033);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button button1;
        private Label label4;
        private TextBox txtName;
        private PictureBox pictureBox1;
        private Button button2;
    }
}