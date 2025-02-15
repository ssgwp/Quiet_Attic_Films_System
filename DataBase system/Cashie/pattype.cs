using DataBase_system.Cashie;
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

namespace DataBase_system.Admin
{
    public partial class pattype : Form
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

        public pattype()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=quiet_attic_films; Integrated Security=True;";

        private void ad_pattype_Load(object sender, EventArgs e)
        {
            pictureBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 20, 20));
            buttlonback.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttlonback.Width, buttlonback.Height, 20, 20));
            buttonclandre.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonclandre.Width, buttonclandre.Height, 20, 20));
            buttonadddlog.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonadddlog.Width, buttonadddlog.Height, 20, 20));
            buttonedidet.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonedidet.Width, buttonedidet.Height, 20, 20));

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT DISTINCT payment_type_id, payment_type_name FROM payment_type";

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

            //payment_type id combo box button
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM payment_type", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxstid.DataSource = table1;
                    comboBoxstid.DisplayMember = "payment_type_id";
                    comboBoxstid.ValueMember = "payment_type_id";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void buttonclandre_Click(object sender, EventArgs e)
        {
            this.Hide();
            pattype dashboard = new pattype();
            dashboard.tra = tra;
            dashboard.Show();
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
            capayment dashboard = new capayment();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void buttlonback_Click(object sender, EventArgs e)
        {
            this.Hide();
            capayment dashboard = new capayment();
            dashboard.tra = tra;
            dashboard.Show();
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

                    cmd.CommandText = "SELECT payment_type_id, payment_type_name FROM payment_type WHERE payment_type_id = @payment_type_id";
                    cmd.Parameters.AddWithValue("@payment_type_id", proper);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        textBoxna.Text = dt.Rows[0]["payment_type_name"].ToString();
                    }
                    else
                    {
                        // Handle the case when no rows are returned
                    }
                    Con.Close();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                comboBoxstid.Text = row.Cells["payment_type_id"].Value.ToString();
                textBoxna.Text = row.Cells["payment_type_name"].Value.ToString();
            }
        }

        private void buttonadddlog_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxna.Text))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    // Use parameterized query to avoid SQL injection
                    cmd.CommandText = "INSERT INTO [payment_type] (payment_type_name) VALUES (@payment_type_name)";

                    // Add parameters
                    cmd.Parameters.AddWithValue("@payment_type_name", textBoxna.Text);

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Payment Type Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    pattype dashboard = new pattype();
                    dashboard.tra = tra;
                    dashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Error, Please fill all the field boxes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonedidet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxna.Text))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "UPDATE [payment_type] SET payment_type_name = @payment_type_name WHERE payment_type_id = @payment_type_id";

                    // Add parameters
                    cmd.Parameters.AddWithValue("@payment_type_name", textBoxna.Text);
                    cmd.Parameters.AddWithValue("@payment_type_id", comboBoxstid.SelectedValue);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Payment Type Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        pattype dashboard = new pattype();
                        dashboard.tra = tra;
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error updating payment type", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error, Please fill all the field boxes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
