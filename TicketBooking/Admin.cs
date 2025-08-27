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

namespace TicketBooking
{
    public partial class Admin : Form
    {
        private void Load()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=movieDB;Integrated Security=True";
            string query = "SELECT * FROM Movies";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table); // Fetches data
                    dataGridView1.DataSource = table; // Binds to grid view
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ApplyCreativeStyle();
        }
        private void UserLoad()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=movieDB;Integrated Security=True";
            string query = "SELECT * FROM Booking";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table); 
                    dataGridView1.DataSource = table; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ApplyCreativeStyle();
        }
        private void reviewsLoad()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=movieDB;Integrated Security=True";
            string query = "SELECT * FROM UserReview";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table); 
                    dataGridView1.DataSource = table; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ApplyCreativeStyle();
        }

        private void ClearFields()
        {
            txtId.Clear();
            txtMovie.Clear();
            txtNIC.Clear();
            txtSeat.Clear();
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

            
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            // Grid line styling
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.BorderStyle = BorderStyle.None;

            // Remove row headers
            dataGridView1.RowHeadersVisible = false;
        }
        public Admin()
        {
            InitializeComponent();
        }

        private void editmovie_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=movieDB;Integrated Security=True";
            using SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Movies (MovieName, MovieID) VALUES (@MName, @MId)";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@MName", txtMovie.Text);
            cmd.Parameters.AddWithValue("@MId", txtId.Text);
            connection.Open();
            cmd.ExecuteNonQuery();
            Load();
            ClearFields();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=movieDB;Integrated Security=True";
            using SqlConnection connection = new SqlConnection(connectionString);
            string query = "DELETE FROM Movies WHERE MovieID=@MId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@MId", txtId.Text);
            connection.Open();
            cmd.ExecuteNonQuery();
            Load();
            ClearFields();
        }

        private void edituser_Click(object sender, EventArgs e)
        {
            UserLoad();
        }

        private void btnreviews_Click(object sender, EventArgs e)
        {
            reviewsLoad();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=movieDB;Integrated Security=True";
            using SqlConnection connection = new SqlConnection(connectionString);
            string query = "DELETE FROM Booking WHERE NIC_No=@NIC";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
            connection.Open();
            cmd.ExecuteNonQuery();
            UserLoad();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=movieDB;Integrated Security=True";
            using SqlConnection connection = new SqlConnection(connectionString);
            string query = "UPDATE Booking SET Seat=@seat WHERE NIC_No=@NIC";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
            cmd.Parameters.AddWithValue("@seat", txtSeat.Text);
            connection.Open();
            cmd.ExecuteNonQuery();
            UserLoad();
            ClearFields();
        }

        private void Dbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string review = dataGridView1.SelectedRows[0].Cells["Review"].Value.ToString();


                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=movieDB;Integrated Security=True";
                string query = "DELETE FROM UserReview WHERE Review=@UserReview";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserReview", review);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            reviewsLoad();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.ShowDialog();
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Maroon;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.SteelBlue;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Maroon;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.SteelBlue;
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.Maroon;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.SteelBlue;
        }

        private void Deletebtn_MouseHover(object sender, EventArgs e)
        {
            Deletebtn.BackColor = Color.Maroon;
        }

        private void Deletebtn_MouseLeave(object sender, EventArgs e)
        {
            Deletebtn.BackColor = Color.SteelBlue;
        }

        private void Dbtn_MouseHover(object sender, EventArgs e)
        {
            Dbtn.BackColor = Color.Maroon;
        }

        private void Dbtn_MouseLeave(object sender, EventArgs e)
        {
            Dbtn.BackColor = Color.SteelBlue;
        }

        private void editmovie_MouseHover(object sender, EventArgs e)
        {
            editmovie.BackColor = Color.SteelBlue;
        }

        private void editmovie_MouseLeave(object sender, EventArgs e)
        {
            editmovie.BackColor = Color.Maroon;
        }

        private void edituser_MouseHover(object sender, EventArgs e)
        {
            edituser.BackColor = Color.SteelBlue;
        }

        private void edituser_MouseLeave(object sender, EventArgs e)
        {
            edituser.BackColor = Color.Maroon;
        }

        private void btnreviews_MouseHover(object sender, EventArgs e)
        {
            btnreviews.BackColor = Color.SteelBlue;
        }

        private void btnreviews_MouseLeave(object sender, EventArgs e)
        {
            btnreviews.BackColor = Color.Maroon;
        }
    }
}
