using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TicketBooking
{
    public partial class userReview : Form
    {

        private void ApplyCreativeStyle()
        {
           
            PastReview.ReadOnly = true;
            PastReview.AllowUserToAddRows = false;
            PastReview.AllowUserToDeleteRows = false;
            PastReview.AllowUserToResizeRows = false;
            PastReview.RowHeadersVisible = true;
            PastReview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PastReview.MultiSelect = false;

            // Column width and row height
            PastReview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PastReview.RowTemplate.Height = 35;

            // Header styling
            PastReview.EnableHeadersVisualStyles = false;
            PastReview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 0, 0); // Dark maroon
            PastReview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            PastReview.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            PastReview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PastReview.ColumnHeadersHeight = 40;

            // Cell style
            PastReview.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            PastReview.DefaultCellStyle.ForeColor = Color.Black;
            PastReview.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            PastReview.DefaultCellStyle.SelectionBackColor = Color.FromArgb(153, 51, 51); // Lighter maroon for selection
            PastReview.DefaultCellStyle.SelectionForeColor = Color.White;
            PastReview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            
            PastReview.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            // Grid line styling
            PastReview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            PastReview.GridColor = Color.Black;
            PastReview.BorderStyle = BorderStyle.None;

            // Remove row headers 
            PastReview.RowHeadersVisible = false;
        }

        private void ClearFields()
        {
            NewReview.Text = "";

        }
        public userReview()
        {
            InitializeComponent();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu f1 = new menu();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=movieDB;Integrated Security=True";
            string query = "SELECT Review FROM UserReview";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                PastReview.DataSource = dt;
                PastReview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                ApplyCreativeStyle();


            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=movieDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            string sql = @"INSERT INTO UserReview(Review) VALUES (@Review)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Review", NewReview.Text);
            conn.Open();
            cmd.ExecuteNonQuery();

            ClearFields();
        }

        private void PastReview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
