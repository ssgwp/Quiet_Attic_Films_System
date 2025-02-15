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
    public partial class ad_newtype : Form
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

        public ad_newtype()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=quiet_attic_films; Integrated Security=True;";

        private void ad_newtype_Load(object sender, EventArgs e)
        {
            pictureBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 20, 20));
            buttlonback.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttlonback.Width, buttlonback.Height, 20, 20));
            buttonadddst.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonadddst.Width, buttonadddst.Height, 20, 20));
            buttonedist.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonedist.Width, buttonedist.Height, 20, 20));
            buttondest.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttondest.Width, buttondest.Height, 20, 20));
            buttonclandre.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonclandre.Width, buttonclandre.Height, 20, 20));

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT DISTINCT stuff_type_id, typename FROM stuff_type";

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

            //staff_login_type id combo box button
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM stuff_type", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxstid.DataSource = table1;
                    comboBoxstid.DisplayMember = "stuff_type_id";
                    comboBoxstid.ValueMember = "stuff_type_id";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_staff dashboard = new ad_staff();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void buttlonback_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_staff dashboard = new ad_staff();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                comboBoxstid.Text = row.Cells["stuff_type_id"].Value.ToString();
                textBoxstn.Text = row.Cells["typename"].Value.ToString();
            }
        }

        private void buttonclandre_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_newtype dashboard = new ad_newtype();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void comboBoxstid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stid;
            try
            {
                if (int.TryParse(comboBoxstid.SelectedValue?.ToString(), out stid))
                {
                    // Conversion successful, use productid
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();
                        SqlCommand cmd = Con.CreateCommand();
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "SELECT * FROM stuff_type WHERE stuff_type_id = @stuff_type_id";

                        cmd.Parameters.AddWithValue("@stuff_type_id", stid);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            textBoxstn.Text = dt.Rows[0]["typename"].ToString();
                        }
                        else
                        {
                            // Handle the case when no rows are returned
                        }
                        Con.Close();
                    }
                }
                else
                {
                    // Handle the case when the SelectedValue is not a valid integer
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
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
                    cmd.CommandText = "INSERT INTO [stuff_type] (typename) VALUES (@typename)";

                    // Add parameters
                    cmd.Parameters.AddWithValue("@typename", textBoxstn.Text);

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Stuff Type Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ad_newtype dashboard = new ad_newtype();
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
            if (!string.IsNullOrEmpty(comboBoxstid.Text) && !string.IsNullOrEmpty(textBoxstn.Text))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    // Use parameterized query to avoid SQL injection
                    cmd.CommandText = "UPDATE [stuff_type] SET typename = @typename WHERE stuff_type_id = @stuff_type_id";

                    // Add parameters
                    cmd.Parameters.AddWithValue("@typename", textBoxstn.Text);
                    cmd.Parameters.AddWithValue("@stuff_type_id", comboBoxstid.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Stuff Type Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        ad_newtype dashboard = new ad_newtype();
                        dashboard.tra = tra;
                        dashboard.Show();
                    }
                    else
                    {

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
                    cmd.CommandText = "DELETE FROM [stuff_type] WHERE stuff_type_id = @stuff_type_id";

                    // Add parameters
                    cmd.Parameters.AddWithValue("@stuff_type_id", comboBoxstid.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Stuff Type Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        ad_newtype dashboard = new ad_newtype();
                        dashboard.tra = tra;
                        dashboard.Show();
                    }
                    else
                    {

                    }
                }
            }
            else
            {
                MessageBox.Show("Error, Please select an ID to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
