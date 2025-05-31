using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UltimateKnowledgeHub
{
    public partial class PlantsControl : UserControl
    {
        private string connectionString = "Data Source=DESKTOP-F2UA273\\SQLEXPRESS01;Initial Catalog=HerbsDB;Integrated Security=True;";

        public PlantsControl()
        {
            InitializeComponent();
            InitializeComponent();

            // Attach event handler if not set in designer
            btnFind.Click += btnFind_Click;
         
        }
      


        private void btnFind_Click(object sender, EventArgs e)
        {
            string herbName = txtHerb.Text.Trim();
            if (!string.IsNullOrEmpty(herbName))
            {
                MessageBox.Show("Please enter an herb name.");
                return;
            }
            {
                string query = "SELECT Benefit FROM Herbs WHERE HerbName = @name";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", herbName);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            rtbBenefit.Text = reader["Benefit"].ToString();
                        }
                        else
                        {
                            rtbBenefit.Text = "Herb not found.";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
           
        }

    }
}

