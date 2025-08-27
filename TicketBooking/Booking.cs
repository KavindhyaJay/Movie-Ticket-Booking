using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TicketBooking
{
    public partial class Booking : Form
    {

        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private void ClearFields()
        {
            txtName.Text = "";
            txtNIC.Text = "";
            txtMovie.Text = "";
            txtPNo.Text = "";
            txtPrice.Text = "";
            txtseat.Text = "";
            txtticketNo.Text = "";
            txttime.Text = "";
            txtdate.Text = "";
        }
        private void ApplyCreativeStyle()
        {
           
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            // Column width and row height
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 35;

            // Header styling
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 0, 0); // Dark maroon
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeight = 40;

            // Cell style
            dataGridView1.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(153, 51, 51); // Lighter maroon for selection
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Grid line styling
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.BorderStyle = BorderStyle.None;

            // Remove row headers
            dataGridView1.RowHeadersVisible = false;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]



        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
        );
        bool expand = false;

        private void LoadMoviesToComboBox()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=movieDB;Integrated Security=True";
            string query = "SELECT MovieName FROM Movies";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        txtMovie.Items.Add(reader["MovieName"].ToString());
                    }
                }
            }
        }

        public Booking()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seat f3 = new Seat();
            f3.ShowDialog();


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {


        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=movieDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            string sql = @"INSERT INTO Booking ( Name, NIC_No, Phone_No, Movie, Date, Time, Seat, No_of_Tickets,[Total_Price]) VALUES (@Name, @NIC, @PNo, @Movie, @date, @time, @seat, @ticketNo, @Price)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
            cmd.Parameters.AddWithValue("@PNo", txtPNo.Text);
            cmd.Parameters.AddWithValue("@Movie", txtMovie.Text);
            cmd.Parameters.AddWithValue("@date", txtdate.Text);
            cmd.Parameters.AddWithValue("@time", txttime.Text);
            cmd.Parameters.AddWithValue("@Seat", txtseat.Text);
            cmd.Parameters.AddWithValue("@ticketNo", txtticketNo.Text);
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
            conn.Open();
            cmd.ExecuteNonQuery();

            ClearFields();
            this.Hide();
            success f1 = new success();
            f1.ShowDialog();





        }

        private void Booking_Load(object sender, EventArgs e)
        {
            confirm.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, confirm.Width, confirm.Height, 50, 50));

        }

        private void confirm_MouseHover(object sender, EventArgs e)
        {
            confirm.BackColor = Color.Green;
        }

        private void confirm_MouseLeave(object sender, EventArgs e)
        {
            confirm.BackColor = Color.Maroon;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            menu f2 = new menu();
            f2.ShowDialog();
        }

        private void txtticketNo_TextChanged(object sender, EventArgs e)
        {
            int a;
            int b = 1000;
            if (int.TryParse(txtticketNo.Text, out a))
            {
                int t = b * a;
                txtPrice.Text = "Rs:" + t.ToString();
            }
            else
            {
                txtPrice.Text = "Rs: 0";
            }

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Booking_Load_1(object sender, EventArgs e)
        {
            LoadMoviesToComboBox();

        }

        private void btnseat_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=movieDB;Integrated Security=True";
            string query = "SELECT Seat FROM Booking WHERE Movie = @Movie AND [Date] = @Date";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                string movieName = txtMovie.Text.Trim();
                DateTime selectedDate = txtdate.Value.Date;

                cmd.Parameters.AddWithValue("@Movie", movieName);
                cmd.Parameters.AddWithValue("@Date", selectedDate);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                ApplyCreativeStyle();
            }
        }

        private void txtMovie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report f1 = new Report();
            f1.ShowDialog();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Green;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.SteelBlue;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.SteelBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor= Color.Maroon;
        }
    }
}
