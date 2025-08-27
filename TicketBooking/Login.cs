using Microsoft.VisualBasic.Devices;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=movieDB;Integrated Security=True");
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Register f3 = new Register();
            f3.ShowDialog();

        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.SteelBlue;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Maroon;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnregister.BackColor = Color.SteelBlue;
        }

        private void btnregister_MouseLeave(object sender, EventArgs e)
        {
            btnregister.BackColor = Color.Maroon;
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdmin f4 = new LoginAdmin();
            f4.ShowDialog();
        }

        private void btnadmin_MouseHover(object sender, EventArgs e)
        {
            btnadmin.BackColor = Color.SteelBlue;
        }

        private void btnadmin_MouseLeave(object sender, EventArgs e)
        {
            btnadmin.BackColor = Color.Maroon;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            String email, password;

            email = txtEmail.Text;
            password = txtPassword.Text;

            try
            {
                String querry = "SELECT *  FROM login  WHERE Email = '" + txtEmail.Text + "' AND Password = '" + txtPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    email = txtEmail.Text;
                    password = txtPassword.Text;


                    this.Hide();
                    menu f2 = new menu();
                    f2.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Clear();
                    txtPassword.Clear();


                    txtEmail.Focus();
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

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
