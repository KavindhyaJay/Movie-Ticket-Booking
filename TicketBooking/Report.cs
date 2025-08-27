using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace TicketBooking
{
    public partial class Report : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=movieDB;Integrated Security=True";
        public Report()
        {
            InitializeComponent();
        }

        private List<MovieData> GetMovieData()
        {
            var list = new List<MovieData>();

            using (var conn = new SqlConnection(connectionString))
            {

                conn.Open();
                string query = "SELECT Movie, No_of_Tickets FROM Booking";

                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieData()
                        {
                            Movie = reader.GetString(0),
                            No_of_Tickets = reader.GetInt32(1)
                        });
                    }
                }
            }
            return list;


        }

        public class MovieData
        {
            public required string Movie { get; set; }
            public int No_of_Tickets { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer
            {
                Dock = DockStyle.Fill,
                ProcessingMode = ProcessingMode.Local
            };
            this.Controls.Add(reportViewer);

            reportViewer.LocalReport.ReportPath = "D:\\UOK\\5th sem\\Visual Programming\\project\\TicketBooking\\MovieTicketBooking\\TicketBooking\\Report1.rdlc";
            reportViewer.LocalReport.DataSources.Clear();

            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", GetMovieData()));

            reportViewer.RefreshReport();
        }
    }
}
