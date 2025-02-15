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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace DataBase_system.Admin
{
    public partial class ad_logde : Form
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

        public ad_logde()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=quiet_attic_films; Integrated Security=True;";

        private void ad_logde_Load(object sender, EventArgs e)
        {
            pictureBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 20, 20));
            buttlonback.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttlonback.Width, buttlonback.Height, 20, 20));
            buttonclandre.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonclandre.Width, buttonclandre.Height, 20, 20));
            buttonadddlog.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonadddlog.Width, buttonadddlog.Height, 20, 20));
            buttondelog.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttondelog.Width, buttondelog.Height, 20, 20));
            buttonreslog.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonreslog.Width, buttonreslog.Height, 20, 20));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT DISTINCT emp_id, f_name, l_name FROM staff";

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

            //staff id combo box button
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM staff", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxstid.DataSource = table1;
                    comboBoxstid.DisplayMember = "emp_id";
                    comboBoxstid.ValueMember = "emp_id";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            //login_type combo box button
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM login_type", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxlogtype.DataSource = table1;
                    comboBoxlogtype.DisplayMember = "log_type";
                    comboBoxlogtype.ValueMember = "log_type";
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

        private void buttonclandre_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_logde dashboard = new ad_logde();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void comboBoxstid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int emp_id;
            try
            {
                if (int.TryParse(comboBoxstid.SelectedValue?.ToString(), out emp_id))
                {
                    // Conversion successful
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();
                        SqlCommand cmd = Con.CreateCommand();
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "SELECT emp_id, f_name, username, log_type, status FROM view16 WHERE emp_id = @emp_id";

                        cmd.Parameters.AddWithValue("@emp_id", emp_id);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            textBoxna.Text = dt.Rows[0]["f_name"].ToString();
                            textBoxuser.Text = dt.Rows[0]["username"].ToString();
                            textBoxpass.Text = "************";
                            textBoxlogstatus.Text = dt.Rows[0]["status"].ToString();
                            comboBoxlogtype.Text = dt.Rows[0]["log_type"].ToString();
                        }
                        else
                        {
                            // Handle the case
                        }
                        Con.Close();
                    }
                }
                else
                {
                    // Handle the case
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            try
            {
                if (int.TryParse(comboBoxstid.SelectedValue?.ToString(), out emp_id))
                {
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();

                        string query = "SELECT DISTINCT emp_id, f_name, username, status, log_type FROM view16 WHERE emp_id = @emp_id";

                        using (SqlCommand cmd = new SqlCommand(query, Con))
                        {
                            cmd.Parameters.AddWithValue("@emp_id", emp_id);

                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                                dataGridView2.DataSource = dt;

                                if (dataGridView2.Rows.Count > 0)
                                {
                                    DataGridViewRow row2 = dataGridView2.Rows[0];

                                    textBoxuser.Text = row2.Cells["username"].Value?.ToString();
                                    comboBoxlogtype.Text = row2.Cells["log_type"].Value?.ToString();
                                }
                            }
                        }
                        Con.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = dataGridView1.Rows[e.RowIndex];

                object empIdCellValue = clickedRow.Cells["emp_id"].Value;
                if (empIdCellValue != null)
                {
                    string empId = empIdCellValue.ToString();

                    comboBoxstid.Text = empId;
                    textBoxna.Text = clickedRow.Cells["f_name"].Value?.ToString();
                    textBoxpass.Text = "************";

                    try
                    {
                        using (SqlConnection Con = new SqlConnection(connectionString))
                        {
                            Con.Open();

                            string query = "SELECT DISTINCT emp_id, f_name, username, status, log_type FROM view16 WHERE emp_id = @emp_id";

                            using (SqlCommand cmd = new SqlCommand(query, Con))
                            {
                                cmd.Parameters.AddWithValue("@emp_id", empId);

                                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                                {
                                    DataTable dt = new DataTable();
                                    da.Fill(dt);
                                    dataGridView2.DataSource = dt;

                                    if (dataGridView2.Rows.Count > 0)
                                    {
                                        DataGridViewRow row2 = dataGridView2.Rows[0];

                                        textBoxuser.Text = row2.Cells["username"].Value?.ToString();
                                        comboBoxlogtype.Text = row2.Cells["log_type"].Value?.ToString();
                                    }
                                }
                            }
                            Con.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("emp_id value is null");
                }
            }
        }

        private void buttonadddlog_Click(object sender, EventArgs e)
        {
            int logty = 0; // Initialize logty with a default value

            if (!string.IsNullOrEmpty(textBoxuser.Text) && !string.IsNullOrEmpty(textBoxpass.Text) && !string.IsNullOrEmpty(comboBoxlogtype.Text) && !string.IsNullOrEmpty(comboBoxstid.Text))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand checkUserCmd = Con.CreateCommand();
                    checkUserCmd.CommandType = CommandType.Text;
                    checkUserCmd.CommandText = "SELECT COUNT(*) FROM [login] WHERE username = @username";
                    checkUserCmd.Parameters.AddWithValue("@username", textBoxuser.Text);

                    int userCount = (int)checkUserCmd.ExecuteScalar();
                    if (userCount > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    // Use parameterized query
                    cmd.CommandText = "SELECT login_type_id FROM login_type WHERE log_type = @log_type";
                    cmd.Parameters.AddWithValue("@log_type", comboBoxlogtype.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            logty = reader.GetInt32(0);
                        }
                    }

                    cmd.CommandText = "INSERT INTO [login] (username, passw, login_type_id, status) VALUES (@username, @passw, @login_type_id, @status)";
                    cmd.Parameters.AddWithValue("@status", "Online"); 
                    cmd.Parameters.AddWithValue("@username", textBoxuser.Text);
                    cmd.Parameters.AddWithValue("@passw", "1234");
                    cmd.Parameters.AddWithValue("@login_type_id", logty);

                    cmd.ExecuteNonQuery();

                    using (SqlCommand cmd3 = Con.CreateCommand())
                    {
                        cmd3.CommandType = CommandType.Text;

                        // Use parameterized query
                        cmd3.CommandText = "UPDATE [staff] SET username = @username WHERE emp_id = @emp_id";

                        // Add parameters
                        cmd3.Parameters.AddWithValue("@username", textBoxuser.Text);
                        cmd3.Parameters.AddWithValue("@emp_id", comboBoxstid.Text);

                        cmd3.ExecuteNonQuery();
                    }

                    MessageBox.Show("Login Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();

                    this.Hide();
                    ad_logde dashboard = new ad_logde();
                    dashboard.tra = tra;
                    dashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Error, Please fill all the field boxes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void buttondelog_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Use parameterized query
                cmd.CommandText = "UPDATE [login] SET status = @status WHERE username = @username";

                // Add parameters
                cmd.Parameters.AddWithValue("@status", "Offline");

                cmd.Parameters.AddWithValue("@username", textBoxuser.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                Con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Login Disable Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ad_logde dashboard = new ad_logde();
                    dashboard.tra = tra;
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Error, Can't disable login", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Use parameterized query
                cmd.CommandText = "UPDATE [login] SET status = @status WHERE username = @username";

                // Add parameters
                cmd.Parameters.AddWithValue("@status", "Online");

                cmd.Parameters.AddWithValue("@username", textBoxuser.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                Con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Login Enable Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ad_logde dashboard = new ad_logde();
                    dashboard.tra = tra;
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Error, Can't enable login", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonreslog_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Use parameterized query
                cmd.CommandText = "UPDATE [login] SET passw = @passw WHERE username = @username";

                // Add parameters
                cmd.Parameters.AddWithValue("@passw", "1234");

                cmd.Parameters.AddWithValue("@username", textBoxuser.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                Con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Login Reset Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ad_logde dashboard = new ad_logde();
                    dashboard.tra = tra;
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Error, Can't enable login", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
