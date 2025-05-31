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
    public partial class PoliticsControl : UserControl
    {
        public PoliticsControl()
        {
            InitializeComponent();
        }

        private void btnShow_Click1(object sender, EventArgs e)
        { }
            private void btnShow_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-F2UA273\\SQLEXPRESS01;Initial Catalog=KnowledgeDB;Integrated Security=True;";// update this with your DB connection
            string query = "SELECT UpdateInfo FROM Politics WHERE Country = @country";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@country", cmbCountry.SelectedItem?.ToString());
                if (cmbCountry.SelectedItem == null)
                {
                    MessageBox.Show("Please select a country first.");
                    return;
                }

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        rtbUpdate.Text = reader["UpdateInfo"].ToString();
                    }
                    else
                    {
                        rtbUpdate.Text = "No political update found for this country.";
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rtbUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void PoliticsControl_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-F2UA273\\SQLEXPRESS01;Initial Catalog=KnowledgeDB;Integrated Security=True;"; // Make sure this is the correct connection string for your database
            string query = "SELECT DISTINCT Country FROM Politics";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmbCountry.Items.Add(reader["Country"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading countries: " + ex.Message);
                }
            }

        }
    }
    }

