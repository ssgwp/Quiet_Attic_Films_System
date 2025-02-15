using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DataBase_system.Admin
{
    public partial class ad_acters : Form
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

        public ad_acters()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=quiet_attic_films; Integrated Security=True;";

        private void ad_acters_Load(object sender, EventArgs e)
        {
            buttexit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttexit.Width, buttexit.Height, 20, 20));
            buttlogout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttlogout.Width, buttlogout.Height, 20, 20));
            menupanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, menupanel.Width, menupanel.Height, 20, 20));
            buttonsc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonsc.Width, buttonsc.Height, 20, 20));
            buttonclandre.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonclandre.Width, buttonclandre.Height, 20, 20));
            buttonadd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonadd.Width, buttonadd.Height, 20, 20));
            buttonedit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonedit.Width, buttonedit.Height, 20, 20));
            buttonaddde.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonaddde.Width, buttonaddde.Height, 20, 20));
            buttonded.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonded.Width, buttonded.Height, 20, 20));
            buttondel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttondel.Width, buttondel.Height, 20, 20));

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT DISTINCT act_id, f_name, l_name, nic, contact_no1, contact_no2, now_work FROM acter";

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

            //acter combo box button
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM acter", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxaid.DataSource = table1;
                    comboBoxaid.DisplayMember = "act_id";
                    comboBoxaid.ValueMember = "act_id";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            //acter id in acter_product 
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM acter", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxacid.DataSource = table1;
                    comboBoxacid.DisplayMember = "act_id";
                    comboBoxacid.ValueMember = "act_id";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            //product id in acter_product 
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM production", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxpid.DataSource = table1;
                    comboBoxpid.DisplayMember = "production_id";
                    comboBoxpid.ValueMember = "production_id";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void labelhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin dashboard = new admin();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void labelproduc_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_product dashboard = new ad_product();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_staff dashboard = new ad_staff();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void labelcustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_customer dashboard = new ad_customer();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void labelaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_account dashboard = new ad_account();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void labelpayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_payment dashboard = new ad_payment();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void buttexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void piclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pimini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want Logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Login form = new Login();
                form.Show();
            }
        }

        private void piclose_MouseLeave(object sender, EventArgs e)
        {
            piclose.BackColor = Color.WhiteSmoke;
        }

        private void piclose_MouseHover(object sender, EventArgs e)
        {
            piclose.BackColor = Color.Red;
        }

        private void pimini_MouseLeave(object sender, EventArgs e)
        {
            pimini.BackColor = Color.WhiteSmoke;
        }

        private void pimini_MouseHover(object sender, EventArgs e)
        {
            pimini.BackColor = Color.Gray;
        }

        private void labelprope_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_property dashboard = new ad_property();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonsc_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string queryn = "SELECT DISTINCT act_id, f_name, l_name, nic, contact_no1, contact_no2, now_work FROM acter WHERE f_name LIKE '%' + @f_name + '%' OR l_name LIKE '%' + @l_name + '%' ;";

                    using (SqlCommand cmdn = new SqlCommand(queryn, Con))
                    {
                        cmdn.Parameters.AddWithValue("@f_name", textBoxsc.Text);
                        cmdn.Parameters.AddWithValue("@l_name", textBoxsc.Text); // Assuming textBoxlc is for last name

                        using (SqlDataAdapter dan = new SqlDataAdapter(cmdn))
                        {
                            DataTable dtn = new DataTable();
                            dan.Fill(dtn);
                            dataGridView1.DataSource = dtn;
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

        private void buttonclandre_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_acters dashboard = new ad_acters();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void comboBoxaid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int acter_id;
            try
            {
                if (int.TryParse(comboBoxaid.SelectedValue?.ToString(), out acter_id))
                {
                    // Conversion successful, use productid
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();
                        SqlCommand cmd = Con.CreateCommand();
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "SELECT * FROM acter WHERE act_id = @act_id";
                        cmd.Parameters.AddWithValue("@act_id", acter_id);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            textBoxfn.Text = dt.Rows[0]["f_name"].ToString();
                            textBoxln.Text = dt.Rows[0]["l_name"].ToString();
                            dateTimePicker1.Text = dt.Rows[0]["dob"].ToString();
                            textBoxnic.Text = dt.Rows[0]["nic"].ToString();
                            textBoxadd.Text = dt.Rows[0]["act_address"].ToString();
                            comboBoxnw.Text = dt.Rows[0]["now_work"].ToString();
                            comboBoxgender.Text = dt.Rows[0]["gender"].ToString();
                            textBoxema.Text = dt.Rows[0]["email"].ToString();
                            textBoxpn1.Text = dt.Rows[0]["contact_no1"].ToString();
                            textBoxpn2.Text = dt.Rows[0]["contact_no2"].ToString();
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

            try
            {
                if (int.TryParse(comboBoxaid.SelectedValue?.ToString(), out acter_id))
                {
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();

                        string query = "SELECT act_id, f_name, production_id, product_name, production_type FROM view13 WHERE act_id = @act_id";

                        using (SqlCommand cmda = new SqlCommand(query, Con))
                        {

                            cmda.Parameters.AddWithValue("@act_id", acter_id);

                            using (SqlDataAdapter daa = new SqlDataAdapter(cmda))
                            {
                                DataTable dta = new DataTable();
                                daa.Fill(dta);

                                label19.Visible = true;
                                // Assuming dataGridView2 is another DataGridView to display the results
                                dataGridView2.DataSource = dta;
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
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT act_id, f_name, production_id, product_name, production_type FROM view13 WHERE act_id = @act_id";

                    using (SqlCommand cmda = new SqlCommand(query, Con))
                    {
                        // Get the production_id from the selected row
                        int productionId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["act_id"].Value);

                        cmda.Parameters.AddWithValue("@act_id", productionId);

                        using (SqlDataAdapter daa = new SqlDataAdapter(cmda))
                        {
                            DataTable dta = new DataTable();
                            daa.Fill(dta);

                            // Assuming dataGridView2 is another DataGridView to display the results
                            dataGridView2.DataSource = dta;
                        }
                    }
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                comboBoxacid.Text = row.Cells["act_id"].Value.ToString();
                comboBoxaid.Text = row.Cells["act_id"].Value.ToString();
                textBoxfn.Text = row.Cells["f_name"].Value.ToString(); // Use "Value" to get the cell value, not the cell itself
                textBoxln.Text = row.Cells["l_name"].Value.ToString(); // Use "Value" to get the cell value, not the cell itself
                textBoxnic.Text = row.Cells["nic"].Value.ToString(); // Use "Value" to get the cell value, not the cell itself
                textBoxpn1.Text = row.Cells["contact_no1"].Value.ToString(); // Use "Value" to get the cell value, not the cell itself
                textBoxpn2.Text = row.Cells["contact_no2"].Value.ToString(); // Use "Value" to get the cell value, not the cell itself

                if (int.TryParse(row.Cells["act_id"].Value.ToString(), out int pacid))
                {
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();
                        SqlCommand cmd = Con.CreateCommand();
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "SELECT * FROM acter WHERE act_id = @act_id";
                        cmd.Parameters.AddWithValue("@act_id", pacid);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dateTimePicker1.Text = dt.Rows[0]["dob"].ToString();
                            textBoxadd.Text = dt.Rows[0]["act_address"].ToString();
                            comboBoxnw.Text = dt.Rows[0]["now_work"].ToString();
                            comboBoxgender.Text = dt.Rows[0]["gender"].ToString();
                            textBoxema.Text = dt.Rows[0]["email"].ToString();
                        }
                        else
                        {
                            // Handle the case when no rows are returned
                            MessageBox.Show("No data found for act_id " + pacid.ToString(), "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Con.Close();
                    }
                }
                else
                {
                    // Handle parsing error
                }
            }

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(textBoxfn.Text)) && (!string.IsNullOrEmpty(textBoxln.Text)) && (!string.IsNullOrEmpty(textBoxnic.Text)) && (!string.IsNullOrEmpty(textBoxadd.Text)) && (!string.IsNullOrEmpty(textBoxema.Text)) && (!string.IsNullOrEmpty(textBoxpn1.Text)) && (!string.IsNullOrEmpty(textBoxpn2.Text)))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    // Use parameterized query to avoid SQL injection
                    cmd.CommandText = "INSERT INTO [acter] (f_name, l_name, dob, act_address, email, nic, gender, contact_no1, contact_no2, now_work) VALUES (@f_name, @l_name, @dob, @act_address, @email, @nic, @gender, @contact_no1, @contact_no2, @now_work)";

                    // Add parameters
                    cmd.Parameters.AddWithValue("@f_name", textBoxfn.Text);
                    cmd.Parameters.AddWithValue("@l_name", textBoxln.Text);
                    cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@act_address", textBoxadd.Text);
                    cmd.Parameters.AddWithValue("@email", textBoxema.Text);
                    cmd.Parameters.AddWithValue("@nic", textBoxnic.Text);
                    cmd.Parameters.AddWithValue("@gender", comboBoxgender.Text);
                    cmd.Parameters.AddWithValue("@contact_no1", textBoxpn1.Text);
                    cmd.Parameters.AddWithValue("@contact_no2", textBoxpn2.Text);
                    cmd.Parameters.AddWithValue("@now_work", comboBoxnw.Text);

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Acter Details Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ad_acters dashboard = new ad_acters();
                    // Assuming `tra` is a property of `ad_acters`
                    dashboard.tra = tra;
                    dashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Error, Please fill all the field boxes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(textBoxfn.Text)) && (!string.IsNullOrEmpty(textBoxln.Text)) && (!string.IsNullOrEmpty(textBoxnic.Text)) && (!string.IsNullOrEmpty(textBoxadd.Text)) && (!string.IsNullOrEmpty(textBoxema.Text)) && (!string.IsNullOrEmpty(textBoxpn1.Text)) && (!string.IsNullOrEmpty(textBoxpn2.Text)))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    // Use parameterized query to avoid SQL injection
                    cmd.CommandText = "UPDATE [acter] SET f_name = @f_name, l_name = @l_name, dob = @dob, act_address = @act_address, email = @email, nic = @nic, gender = @gender, contact_no1 = @contact_no1, contact_no2 = @contact_no2, now_work = @now_work WHERE act_id = @act_id";

                    // Add parameters
                    cmd.Parameters.AddWithValue("@f_name", textBoxfn.Text);
                    cmd.Parameters.AddWithValue("@l_name", textBoxln.Text);
                    cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@act_address", textBoxadd.Text);
                    cmd.Parameters.AddWithValue("@email", textBoxema.Text);
                    cmd.Parameters.AddWithValue("@nic", textBoxnic.Text);
                    cmd.Parameters.AddWithValue("@gender", comboBoxgender.Text);
                    cmd.Parameters.AddWithValue("@contact_no1", textBoxpn1.Text);
                    cmd.Parameters.AddWithValue("@contact_no2", textBoxpn2.Text);
                    cmd.Parameters.AddWithValue("@now_work", comboBoxnw.Text);
                    cmd.Parameters.AddWithValue("@act_id", comboBoxaid.Text); // Specify the ID of the record to update

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Acter Details Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ad_acters dashboard = new ad_acters();
                    // Assuming `tra` is a property of `ad_acters`
                    dashboard.tra = tra;
                    dashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Error, Please fill all the field boxes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void comboBoxacid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int acid;
            if (int.TryParse(comboBoxacid.SelectedValue?.ToString(), out acid))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT act_id, f_name FROM acter WHERE act_id = @act_id";
                    cmd.Parameters.AddWithValue("@act_id", acid);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        textBoxacname.Text = dt.Rows[0]["f_name"].ToString();
                    }
                    else
                    {
                        // Handle the case when no rows are returned
                    }
                    Con.Close();
                }
            }
        }

        private void comboBoxpid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pid;
            if (int.TryParse(comboBoxpid.SelectedValue?.ToString(), out pid))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT production_id, product_name FROM production WHERE production_id = @production_id";
                    cmd.Parameters.AddWithValue("@production_id", pid);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        textBoxpname.Text = dt.Rows[0]["product_name"].ToString();
                    }
                    else
                    {
                        // Handle the case when no rows are returned
                    }
                    Con.Close();
                }
            }
        }

        private void buttonaddde_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Use parameterized query to avoid SQL injection
                cmd.CommandText = "INSERT INTO [production_acter] (production_id, act_id) VALUES (@production_id, @act_id)";

                // Add parameters
                cmd.Parameters.AddWithValue("@production_id", comboBoxpid.Text);
                cmd.Parameters.AddWithValue("@act_id", comboBoxacid.Text);

                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Acter Details Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                ad_acters dashboard = new ad_acters();
                dashboard.tra = tra;
                dashboard.Show();
            }
        }

        private void buttonedid_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Use parameterized query to avoid SQL injection
                cmd.CommandText = "UPDATE [production_acter] SET production_id = @production_id WHERE act_id = @act_id";

                // Add parameters
                cmd.Parameters.AddWithValue("@production_id", comboBoxpid.Text);
                cmd.Parameters.AddWithValue("@act_id", comboBoxacid.Text);

                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Acter Details Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                ad_acters dashboard = new ad_acters();
                dashboard.tra = tra;
                dashboard.Show();
            }

        }

        private void buttonded_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Use parameterized query to avoid SQL injection
                cmd.CommandText = "DELETE FROM [production_acter] WHERE act_id = @act_id AND production_id = @production_id";

                // Add parameters
                cmd.Parameters.AddWithValue("@act_id", comboBoxacid.Text);
                cmd.Parameters.AddWithValue("@production_id", comboBoxpid.Text);

                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Acter Details Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                ad_acters dashboard = new ad_acters();
                dashboard.tra = tra;
                dashboard.Show();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                comboBoxacid.Text = row.Cells["act_id"].Value.ToString();
                textBoxacname.Text = row.Cells["f_name"].Value.ToString(); // Use "Value" to get the cell value, not the cell itself
                comboBoxpid.Text = row.Cells["production_id"].Value.ToString(); // Use "Value" to get the cell value, not the cell itself
                textBoxpname.Text = row.Cells["product_name"].Value.ToString(); // Use "Value" to get the cell value, not the cell itself
            }
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxacid.Text) && !string.IsNullOrEmpty(comboBoxpid.Text))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    // Use parameterized query to avoid SQL injection
                    cmd.CommandText = "DELETE FROM [production_acter] WHERE act_id = @act_id";

                    // Add parameters
                    cmd.Parameters.AddWithValue("@act_id", comboBoxacid.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Con.Close();

                    if (rowsAffected > 0)
                    {
                        this.Hide();
                        ad_acters dashboard = new ad_acters();
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
                MessageBox.Show("Error, Please select both Act ID and Production ID to delete from Production", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            if (!string.IsNullOrEmpty(comboBoxaid.Text))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    // Use parameterized query to avoid SQL injection
                    cmd.CommandText = "DELETE FROM [acter] WHERE act_id = @act_id";

                    // Add parameters
                    cmd.Parameters.AddWithValue("@act_id", comboBoxaid.Text); // Specify the ID of the record to delete

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Acter Details Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        ad_acters dashboard = new ad_acters();
                        // Assuming `tra` is a property of `ad_acters`
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

        private void textBoxpn1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.Contains('.')))
            {
                e.Handled = true;
            }
        }

        private void textBoxpn2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.Contains('.')))
            {
                e.Handled = true;
            }
        }

        private void textBoxnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.Contains('.')))
            {
                e.Handled = true;
            }
        }

        private void textBoxfn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void textBoxln_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }
    }
}
