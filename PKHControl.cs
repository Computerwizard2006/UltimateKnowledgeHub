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

namespace UltimateKnowledgeHub
{
    public partial class PKHControl : UserControl
    {
        // Connection string (update if your instance name is different)
        string connStr = "Data Source=DESKTOP-F2UA273\\SQLEXPRESS01;Initial Catalog=KnowledgeDB;Integrated Security=True;";

        public PKHControl()
        {
            InitializeComponent();
        }
        private void PKHControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "SELECT * FROM PKH";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewPKH.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            LoadData(); // Already reloads DataGridView
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter both Title and Description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "INSERT INTO PKH (Title, Description) VALUES (@title, @desc)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTitle.Clear();
                txtDescription.Clear();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewPKH.CurrentRow == null)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            int id = Convert.ToInt32(dataGridViewPKH.CurrentRow.Cells["Id"].Value);

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "UPDATE PKH SET Title = @title, Description = @desc WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Updated successfully!");
            LoadData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPKH.CurrentRow == null)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            int id = Convert.ToInt32(dataGridViewPKH.CurrentRow.Cells["Id"].Value);

            var confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "DELETE FROM PKH WHERE Id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Deleted successfully!");
                LoadData();
            }
        }
        private void DataGridViewPKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPKH.Rows[e.RowIndex];
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
            }


        }
        private void txtTitle_TextChanged(object sender, EventArgs e) { }

        private void txtDescription_TextChanged(object sender, EventArgs e) { }

        private void lbldescription_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

    }

}
