namespace TicketBooking
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            editmovie = new Button();
            edituser = new Button();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtId = new TextBox();
            txtMovie = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNIC = new TextBox();
            txtSeat = new TextBox();
            Deletebtn = new Button();
            btnreviews = new Button();
            Dbtn = new Button();
            pictureBox2 = new PictureBox();
            label10 = new Label();
            panelHeader = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // editmovie
            // 
            editmovie.BackColor = Color.Maroon;
            editmovie.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editmovie.ForeColor = Color.White;
            editmovie.Location = new Point(276, 130);
            editmovie.Name = "editmovie";
            editmovie.Size = new Size(150, 58);
            editmovie.TabIndex = 0;
            editmovie.Text = "Movies";
            editmovie.UseVisualStyleBackColor = false;
            editmovie.Click += editmovie_Click;
            editmovie.MouseLeave += editmovie_MouseLeave;
            editmovie.MouseHover += editmovie_MouseHover;
            // 
            // edituser
            // 
            edituser.BackColor = Color.Maroon;
            edituser.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edituser.ForeColor = Color.White;
            edituser.Location = new Point(935, 130);
            edituser.Name = "edituser";
            edituser.Size = new Size(184, 58);
            edituser.TabIndex = 1;
            edituser.Text = "Bookings";
            edituser.UseVisualStyleBackColor = false;
            edituser.Click += edituser_Click;
            edituser.MouseLeave += edituser_MouseLeave;
            edituser.MouseHover += edituser_MouseHover;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Maroon;
            dataGridView1.Location = new Point(38, 257);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1883, 346);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(134, 896);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button3_Click;
            btnAdd.MouseLeave += btnAdd_MouseLeave;
            btnAdd.MouseHover += btnAdd_MouseHover;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(334, 896);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseLeave += btnDelete_MouseLeave;
            btnDelete.MouseHover += btnDelete_MouseHover;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(845, 899);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdate.MouseLeave += btnUpdate_MouseLeave;
            btnUpdate.MouseHover += btnUpdate_MouseHover;
            // 
            // txtId
            // 
            txtId.Location = new Point(304, 662);
            txtId.Name = "txtId";
            txtId.Size = new Size(200, 39);
            txtId.TabIndex = 6;
            // 
            // txtMovie
            // 
            txtMovie.Location = new Point(304, 777);
            txtMovie.Name = "txtMovie";
            txtMovie.Size = new Size(200, 39);
            txtMovie.TabIndex = 7;
            txtMovie.TextChanged += txtId_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 10.125F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(122, 662);
            label1.Name = "label1";
            label1.Size = new Size(124, 31);
            label1.TabIndex = 8;
            label1.Text = "Movie ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 10.125F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(122, 780);
            label2.Name = "label2";
            label2.Size = new Size(162, 31);
            label2.TabIndex = 9;
            label2.Text = "Movie Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 10.125F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(845, 662);
            label3.Name = "label3";
            label3.Size = new Size(105, 31);
            label3.TabIndex = 10;
            label3.Text = "NIC No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 10.125F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(862, 777);
            label4.Name = "label4";
            label4.Size = new Size(64, 31);
            label4.TabIndex = 11;
            label4.Text = "Seat";
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(1005, 665);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(200, 39);
            txtNIC.TabIndex = 12;
            // 
            // txtSeat
            // 
            txtSeat.Location = new Point(1005, 780);
            txtSeat.Name = "txtSeat";
            txtSeat.Size = new Size(200, 39);
            txtSeat.TabIndex = 13;
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.SteelBlue;
            Deletebtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Deletebtn.ForeColor = Color.White;
            Deletebtn.Location = new Point(1055, 899);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(150, 46);
            Deletebtn.TabIndex = 14;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            Deletebtn.MouseLeave += Deletebtn_MouseLeave;
            Deletebtn.MouseHover += Deletebtn_MouseHover;
            // 
            // btnreviews
            // 
            btnreviews.BackColor = Color.Maroon;
            btnreviews.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnreviews.ForeColor = Color.White;
            btnreviews.Location = new Point(1525, 130);
            btnreviews.Name = "btnreviews";
            btnreviews.Size = new Size(217, 58);
            btnreviews.TabIndex = 15;
            btnreviews.Text = "User Reviews";
            btnreviews.UseVisualStyleBackColor = false;
            btnreviews.Click += btnreviews_Click;
            btnreviews.MouseLeave += btnreviews_MouseLeave;
            btnreviews.MouseHover += btnreviews_MouseHover;
            // 
            // Dbtn
            // 
            Dbtn.BackColor = Color.SteelBlue;
            Dbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Dbtn.ForeColor = Color.White;
            Dbtn.Location = new Point(1561, 748);
            Dbtn.Name = "Dbtn";
            Dbtn.Size = new Size(150, 46);
            Dbtn.TabIndex = 16;
            Dbtn.Text = "Delete";
            Dbtn.UseVisualStyleBackColor = false;
            Dbtn.Click += Dbtn_Click;
            Dbtn.MouseLeave += Dbtn_MouseLeave;
            Dbtn.MouseHover += Dbtn_MouseHover;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Asset_1;
            pictureBox2.Location = new Point(3, -14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(97, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkRed;
            label10.Font = new Font("Lucida Bright", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.SandyBrown;
            label10.Location = new Point(922, 12);
            label10.Name = "label10";
            label10.Size = new Size(247, 42);
            label10.TabIndex = 3;
            label10.Text = "MOVIEMINT";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.DarkRed;
            panelHeader.Controls.Add(pictureBox3);
            panelHeader.Controls.Add(pictureBox2);
            panelHeader.Controls.Add(label10);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1966, 74);
            panelHeader.TabIndex = 17;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1895, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 57);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2037, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1883;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1966, 1127);
            Controls.Add(panelHeader);
            Controls.Add(Dbtn);
            Controls.Add(btnreviews);
            Controls.Add(Deletebtn);
            Controls.Add(txtSeat);
            Controls.Add(txtNIC);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMovie);
            Controls.Add(txtId);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(edituser);
            Controls.Add(editmovie);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button editmovie;
        private Button edituser;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtId;
        private TextBox txtMovie;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNIC;
        private TextBox txtSeat;
        private Button Deletebtn;
        private Button btnreviews;
        private Button Dbtn;
        private PictureBox pictureBox2;
        private Label label10;
        private Panel panelHeader;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}