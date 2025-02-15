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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBase_system.Admin
{
    public partial class ad_protype : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidhtEllipse,
                int nHeightEllipse
            );

        public string tra { get; set; }

        public ad_protype()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=quiet_attic_films; Integrated Security=True;";

        private void ad_protype_Load(object sender, EventArgs e)
        {
            pictureBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 20, 20));
            buttlonback.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttlonback.Width, buttlonback.Height, 20, 20));
            buttonclandre.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonclandre.Width, buttonclandre.Height, 20, 20));
            buttonadddst.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonadddst.Width, buttonadddst.Height, 20, 20));
            buttonedist.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonedist.Width, buttonedist.Height, 20, 20));
            buttondest.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttondest.Width, buttondest.Height, 20, 20));

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT DISTINCT property_type_id, property_type FROM property_type";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                        Con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            //property_type id combo box button
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM property_type", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxstid.DataSource = table1;
                    comboBoxstid.DisplayMember = "property_type_id";
                    comboBoxstid.ValueMember = "property_type_id";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Gray;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.WhiteSmoke;
        }

        private void buttlonback_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_property dashboard = new ad_property();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_property dashboard = new ad_property();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                comboBoxstid.Text = row.Cells["property_type_id"].Value.ToString();
                textBoxstn.Text = row.Cells["property_type"].Value.ToString();
            }
        }

        private void comboBoxstid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int proper;
            if (int.TryParse(comboBoxstid.SelectedValue?.ToString(), out proper))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT property_type_id, property_type FROM property_type WHERE property_type_id = @property_type_id";
                    cmd.Parameters.AddWithValue("@property_type_id", proper);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        textBoxstn.Text = dt.Rows[0]["property_type"].ToString();
                    }
                    else
                    {
                        // Handle the case when no rows are returned
                    }
                    Con.Close();
                }
            }
        }

        private void buttonclandre_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_protype dashboard = new ad_protype();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void buttonadddst_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxstn.Text))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    // Use parameterized query to avoid SQL injection
                    cmd.CommandText = "INSERT INTO [property_type] (property_type) VALUES (@property_type)";

                    // Add parameters
                    cmd.Parameters.AddWithValue("@property_type", textBoxstn.Text);

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Property Type Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ad_protype dashboard = new ad_protype();
                    dashboard.tra = tra;
                    dashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Error, Please fill all the field boxes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonedist_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxstn.Text))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    // Use parameterized query to avoid SQL injection
                    cmd.CommandText = "UPDATE [property_type] SET property_type = @property_type WHERE property_type_id = @property_type_id";

                    // Add parameters
                    cmd.Parameters.AddWithValue("@property_type", textBoxstn.Text);
                    cmd.Parameters.AddWithValue("@property_type_id", comboBoxstid.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Property Type Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optional: Close the current form and show the dashboard form
                        this.Hide();
                        ad_protype dashboard = new ad_protype();
                        dashboard.tra = tra;
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("No rows were updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error, Please fill all the field boxes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttondest_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxstid.Text))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    // Use parameterized query to avoid SQL injection
                    cmd.CommandText = "DELETE FROM [property_type] WHERE property_type_id = @property_type_id";

                    // Add parameters
                    cmd.Parameters.AddWithValue("@property_type_id", comboBoxstid.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Property Type Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optional: Close the current form and show the dashboard form
                        this.Hide();
                        ad_protype dashboard = new ad_protype();
                        dashboard.tra = tra;
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("No rows were deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error, Please select a property type to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
