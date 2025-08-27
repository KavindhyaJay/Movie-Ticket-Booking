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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=movieDB;Integrated Security=True");

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            String email, password;

            email = Emailtxt.Text;
            password = Passwordtxt.Text;

            try
            {
                String querry = "SELECT *  FROM AdminLogin  WHERE Email = '" + Emailtxt.Text + "' AND Password = '" + Passwordtxt.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                   
                    this.Hide();
                    Admin f2 = new Admin();
                    f2.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Emailtxt.Clear();
                    Passwordtxt.Clear();

                    
                    Emailtxt.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Loginbtn_MouseHover(object sender, EventArgs e)
        {
            Loginbtn.BackColor = Color.SteelBlue;
        }

        private void Loginbtn_MouseLeave(object sender, EventArgs e)
        {
            Loginbtn.BackColor = Color.Maroon;
        }
    }
}
