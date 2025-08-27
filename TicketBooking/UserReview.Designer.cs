namespace TicketBooking
{
    partial class userReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userReview));
            label1 = new Label();
            PastReview = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            panelHeader = new Panel();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            NewReview = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)PastReview).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(157, 202);
            label1.Name = "label1";
            label1.Size = new Size(287, 45);
            label1.TabIndex = 0;
            label1.Text = "Past User Reviews";
            // 
            // PastReview
            // 
            PastReview.BackgroundColor = SystemColors.ControlLight;
            PastReview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PastReview.GridColor = SystemColors.MenuText;
            PastReview.Location = new Point(157, 293);
            PastReview.Name = "PastReview";
            PastReview.RowHeadersWidth = 82;
            PastReview.Size = new Size(1716, 250);
            PastReview.TabIndex = 1;
            PastReview.CellContentClick += PastReview_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(932, 567);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 2;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(932, 1007);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 5;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(157, 705);
            label2.Name = "label2";
            label2.Size = new Size(275, 45);
            label2.TabIndex = 3;
            label2.Text = "Add New Review";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(854, 102);
            label3.Name = "label3";
            label3.Size = new Size(302, 65);
            label3.TabIndex = 6;
            label3.Text = "User Review";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.DarkRed;
            panelHeader.Controls.Add(label10);
            panelHeader.Controls.Add(pictureBox2);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(2030, 74);
            panelHeader.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkRed;
            label10.Font = new Font("Lucida Bright", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SandyBrown;
            label10.Location = new Point(877, 14);
            label10.Name = "label10";
            label10.Size = new Size(247, 42);
            label10.TabIndex = 2;
            label10.Text = "MOVIEMINT";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, -17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1943, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // NewReview
            // 
            NewReview.Location = new Point(157, 775);
            NewReview.Name = "NewReview";
            NewReview.Size = new Size(1716, 192);
            NewReview.TabIndex = 30;
            NewReview.Text = "";
            NewReview.TextChanged += richTextBox1_TextChanged;
            // 
            // userReview
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2030, 1097);
            Controls.Add(NewReview);
            Controls.Add(panelHeader);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(PastReview);
            Controls.Add(label1);
            Name = "userReview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Review";
            ((System.ComponentModel.ISupportInitialize)PastReview).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView PastReview;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Panel panelHeader;
        private Label label10;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private RichTextBox NewReview;
    }
}