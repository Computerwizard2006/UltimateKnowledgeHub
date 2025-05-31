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

namespace UltimateKnowledgeHub
{
    public partial class CareerControl : UserControl
    {
        public CareerControl()
        {
            InitializeComponent();
            this.Load += CareerControl_Load;
        }
        private void CareerControl_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-F2UA273\\SQLEXPRESS01;Initial Catalog=KnowledgeDB;Integrated Security=True;";
            string query = "SELECT DISTINCT Interest FROM CareerPaths";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbInterest.Items.Add(reader["Interest"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading interests: " + ex.Message);
                }
            }
        }
        

        private void btnFindJobs_Click(object sender, EventArgs e)
        {
            if (cmbInterest.SelectedItem == null)
            {
                MessageBox.Show("Please select an interest.");
                return;
            }

            string connectionString = "Data Source=DESKTOP-F2UA273\\SQLEXPRESS01;Initial Catalog=KnowledgeDB;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT SuggestedJob FROM CareerPaths WHERE Interest = @Interest";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Interest", cmbInterest.SelectedItem.ToString());

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    lstJobs.Items.Clear(); // Clear previous results
                    while (reader.Read())
                    {
                        lstJobs.Items.Add(reader["SuggestedJob"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
