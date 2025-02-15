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
using System.Windows.Forms.VisualStyles;

namespace DataBase_system.Admin
{
    public partial class ad_staff : Form
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

        public ad_staff()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=quiet_attic_films; Integrated Security=True;";

        private void adstaff_Load(object sender, EventArgs e)
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
            buttonstorlogt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonstorlogt.Width, buttonstorlogt.Height, 20, 20));
            buttonaddlogd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonaddlogd.Width, buttonaddlogd.Height, 20, 20));

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT DISTINCT emp_id, f_name, l_name, nic, phone_no1, phone_no2, now_work, staff_type FROM view14";

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

            //staff type combo box button
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM stuff_type", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);
                        
                    comboBoxstaty.DataSource = table1;
                    comboBoxstaty.DisplayMember = "typename";
                    comboBoxstaty.ValueMember = "typename";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            //staff id (staff_product) combo box button
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM staff", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxstaffid.DataSource = table1;
                    comboBoxstaffid.DisplayMember = "emp_id";
                    comboBoxstaffid.ValueMember = "emp_id";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            //product id in (staff_product) 
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

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_acters dashboard = new ad_acters();
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

        private void buttonclandre_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_staff dashboard = new ad_staff();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void buttonsc_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string queryn = "SELECT DISTINCT emp_id, f_name, l_name, nic, phone_no1, phone_no2, now_work, staff_type FROM view14 WHERE f_name LIKE '%' + @f_name + '%' OR l_name LIKE '%' + @l_name + '%' ;";

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

        private void comboBoxstid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int emp_id;
            try
            {
                if (int.TryParse(comboBoxstid.SelectedValue?.ToString(), out emp_id))
                {
                    // Conversion successful, use productid
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();
                        SqlCommand cmd = Con.CreateCommand();
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "SELECT * FROM view14 WHERE emp_id = @emp_id";
                        cmd.Parameters.AddWithValue("@emp_id", emp_id);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            textBoxfn.Text = dt.Rows[0]["f_name"].ToString();
                            textBoxln.Text = dt.Rows[0]["l_name"].ToString();
                            dateTimePicker1.Text = dt.Rows[0]["dob"].ToString();
                            textBoxnic.Text = dt.Rows[0]["nic"].ToString();
                            textBoxadd.Text = dt.Rows[0]["address"].ToString();
                            comboBoxstaty.Text = dt.Rows[0]["staff_type"].ToString();
                            comboBoxnw.Text = dt.Rows[0]["now_work"].ToString();
                            comboBoxgender.Text = dt.Rows[0]["gender"].ToString();
                            textBoxema.Text = dt.Rows[0]["email"].ToString();
                            textBoxpn1.Text = dt.Rows[0]["phone_no1"].ToString();
                            textBoxpn2.Text = dt.Rows[0]["phone_no2"].ToString();
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

                        string query = "SELECT emp_id, f_name, production_id, product_name FROM view15 WHERE emp_id = @emp_id";

                        using (SqlCommand cmda = new SqlCommand(query, Con))
                        {

                            cmda.Parameters.AddWithValue("@emp_id", emp_id);

                            using (SqlDataAdapter daa = new SqlDataAdapter(cmda))
                            {
                                DataTable dta = new DataTable();
                                daa.Fill(dta);

                                label16.Visible = true;
                                
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

        private void buttonstorlogt_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_newtype dashboard = new ad_newtype();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void buttonaddlogd_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_logde dashboard = new ad_logde();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                comboBoxstid.Text = row.Cells["emp_id"].Value.ToString();
                textBoxfn.Text = row.Cells["f_name"].Value.ToString();
                textBoxln.Text = row.Cells["l_name"].Value.ToString();
                textBoxnic.Text = row.Cells["nic"].Value.ToString();
                textBoxpn1.Text = row.Cells["phone_no1"].Value.ToString();
                textBoxpn2.Text = row.Cells["phone_no2"].Value.ToString();

                if (int.TryParse(row.Cells["emp_id"].Value.ToString(), out int pacid))
                {
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();
                        SqlCommand cmd = Con.CreateCommand();
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "SELECT * FROM view14 WHERE emp_id = @emp_id";
                        cmd.Parameters.AddWithValue("@emp_id", pacid);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["dob"]);
                            textBoxadd.Text = dt.Rows[0]["address"].ToString();
                            comboBoxnw.Text = dt.Rows[0]["now_work"].ToString();
                            comboBoxgender.Text = dt.Rows[0]["gender"].ToString();
                            comboBoxstaty.Text = dt.Rows[0]["staff_type"].ToString();
                            textBoxema.Text = dt.Rows[0]["email"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No data found for emp_id " + pacid.ToString(), "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid emp_id value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT emp_id, f_name, production_id, product_name FROM view15 WHERE emp_id = @emp_id";

                    using (SqlCommand cmda = new SqlCommand(query, Con))
                    {
                        // Get the production_id from the selected row
                        int productionId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["emp_id"].Value);

                        cmda.Parameters.AddWithValue("@emp_id", productionId);

                        using (SqlDataAdapter daa = new SqlDataAdapter(cmda))
                        {
                            DataTable dta = new DataTable();
                            daa.Fill(dta);

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
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                comboBoxstaffid.Text = row.Cells["emp_id"].Value.ToString();
                textBoxstaffna.Text = row.Cells["f_name"].Value.ToString();
                comboBoxpid.Text = row.Cells["production_id"].Value.ToString();
                textBoxpname.Text = row.Cells["product_name"].Value.ToString();
            }
        }

        private void comboBoxstaffid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int acid;
            if (int.TryParse(comboBoxstaffid.SelectedValue?.ToString(), out acid))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT emp_id, f_name FROM staff WHERE emp_id = @emp_id";
                    cmd.Parameters.AddWithValue("@emp_id", acid);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        textBoxstaffna.Text = dt.Rows[0]["f_name"].ToString();
                    }
                    else
                    {
                        // Handle the case
                    }
                    Con.Close();
                }
            }
        }

        private void comboBoxpid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int poid;
            if (int.TryParse(comboBoxpid.SelectedValue?.ToString(), out poid))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT production_id, product_name FROM production WHERE production_id = @production_id";
                    cmd.Parameters.AddWithValue("@production_id", poid);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        textBoxpname.Text = dt.Rows[0]["product_name"].ToString();
                    }
                    else
                    {
                        // Handle the case
                    }
                    Con.Close();
                }
            }
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(textBoxfn.Text)) && (!string.IsNullOrEmpty(textBoxln.Text)) && (!string.IsNullOrEmpty(textBoxnic.Text)) && (!string.IsNullOrEmpty(textBoxadd.Text)) && (!string.IsNullOrEmpty(comboBoxstaty.Text)) && (!string.IsNullOrEmpty(comboBoxnw.Text)) && (!string.IsNullOrEmpty(comboBoxgender.Text)) && (!string.IsNullOrEmpty(textBoxema.Text)) && (!string.IsNullOrEmpty(textBoxpn1.Text)) && (!string.IsNullOrEmpty(textBoxpn2.Text)))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    // Use parameterized query
                    cmd.CommandText = "INSERT INTO [staff] (f_name, l_name, nic, addressis, dob, email, phone_no1, phone_no2, staff_type_id, now_work, gender) VALUES (@f_name, @l_name, @nic, @addressis, @dob, @email, @phone_no1, @phone_no2, @staff_type_id, @now_work, @gender)";

                    // Add parameters
                    cmd.Parameters.AddWithValue("@f_name", textBoxfn.Text);
                    cmd.Parameters.AddWithValue("@l_name", textBoxln.Text);
                    cmd.Parameters.AddWithValue("@nic", textBoxnic.Text);
                    cmd.Parameters.AddWithValue("@addressis", textBoxadd.Text);
                    cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@email", textBoxema.Text);
                    cmd.Parameters.AddWithValue("@phone_no1", textBoxpn1.Text);
                    cmd.Parameters.AddWithValue("@phone_no2", textBoxpn2.Text);
                    cmd.Parameters.AddWithValue("@now_work", comboBoxnw.Text);
                    cmd.Parameters.AddWithValue("@gender", comboBoxgender.Text);

                    string selectedsttype = comboBoxstaty.Text;
                    int stafftype = -1; 


                    using (SqlCommand cmdr = new SqlCommand("SELECT stuff_type_id FROM stuff_type WHERE typename = @typename", Con))
                    {
                        cmdr.Parameters.AddWithValue("@typename", selectedsttype);
                        object result = cmdr.ExecuteScalar();

                        if (result != null)
                        {
                            stafftype = Convert.ToInt32(result); // Assign the value to stafftype
                        }
                        else
                        {
                            MessageBox.Show("Stuff type not found.");
                        }
                    }

                    cmd.Parameters.AddWithValue("@staff_type_id", stafftype); // Add stafftype as a parameter

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Staff Details Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ad_staff dashboard = new ad_staff();
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
            if ((!string.IsNullOrEmpty(textBoxfn.Text)) && (!string.IsNullOrEmpty(textBoxln.Text)) && (!string.IsNullOrEmpty(textBoxnic.Text)) && (!string.IsNullOrEmpty(textBoxadd.Text)) && (!string.IsNullOrEmpty(comboBoxstaty.Text)) && (!string.IsNullOrEmpty(comboBoxnw.Text)) && (!string.IsNullOrEmpty(comboBoxgender.Text)) && (!string.IsNullOrEmpty(textBoxema.Text)) && (!string.IsNullOrEmpty(textBoxpn1.Text)) && (!string.IsNullOrEmpty(textBoxpn2.Text)))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    // Use parameterized query to avoid SQL injection
                    cmd.CommandText = "UPDATE [staff] SET f_name = @f_name, l_name = @l_name, nic = @nic, addressis = @addressis, dob = @dob, email = @email, phone_no1 = @phone_no1, phone_no2 = @phone_no2, staff_type_id = @staff_type_id, now_work = @now_work, gender = @gender WHERE emp_id = @emp_id";

                    // Add parameters
                    cmd.Parameters.AddWithValue("@f_name", textBoxfn.Text);
                    cmd.Parameters.AddWithValue("@l_name", textBoxln.Text);
                    cmd.Parameters.AddWithValue("@nic", textBoxnic.Text);
                    cmd.Parameters.AddWithValue("@addressis", textBoxadd.Text);
                    cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@email", textBoxema.Text);
                    cmd.Parameters.AddWithValue("@phone_no1", textBoxpn1.Text);
                    cmd.Parameters.AddWithValue("@phone_no2", textBoxpn2.Text);
                    cmd.Parameters.AddWithValue("@now_work", comboBoxnw.Text);
                    cmd.Parameters.AddWithValue("@gender", comboBoxgender.Text);

                    string selectedsttype = comboBoxstaty.Text;
                    int stafftype = -1;

                    // Assuming Con is your SqlConnection object
                    using (SqlCommand cmdr = new SqlCommand("SELECT stuff_type_id FROM stuff_type WHERE typename = @typename", Con))
                    {
                        cmdr.Parameters.AddWithValue("@typename", selectedsttype);
                        object result = cmdr.ExecuteScalar();

                        if (result != null)
                        {
                            stafftype = Convert.ToInt32(result); // Assign the value to stafftype
                        }
                        else
                        {
                            MessageBox.Show("Stuff type not found.");
                        }
                    }

                    cmd.Parameters.AddWithValue("@staff_type_id", stafftype); // Add stafftype as a parameter
                    cmd.Parameters.AddWithValue("@emp_id", comboBoxstid.Text); // Assuming staff_id is the ID of the staff member want to update

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Staff Details Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ad_staff dashboard = new ad_staff();

                    dashboard.tra = tra;
                    dashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Error, Please fill all the field boxes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cmd.CommandText = "INSERT INTO [production_staff] (production_id, emp_id) VALUES (@production_id, @emp_id)";

                // Add parameters
                cmd.Parameters.AddWithValue("@production_id", comboBoxpid.Text);
                cmd.Parameters.AddWithValue("@emp_id", comboBoxstaffid.Text);

                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Acter Details Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                ad_staff dashboard = new ad_staff();
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
                cmd.CommandText = "UPDATE [production_staff] SET production_id = @production_id WHERE emp_id = @emp_id";

                // Add parameters
                cmd.Parameters.AddWithValue("@production_id", comboBoxpid.Text);
                cmd.Parameters.AddWithValue("@emp_id", comboBoxstaffid.Text);

                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Acter Details Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                ad_staff dashboard = new ad_staff();
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
                cmd.CommandText = "DELETE FROM [production_staff] WHERE emp_id = @emp_id AND production_id = @production_id";

                // Add parameters
                cmd.Parameters.AddWithValue("@production_id", comboBoxpid.Text);
                cmd.Parameters.AddWithValue("@emp_id", comboBoxstaffid.Text);

                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Acter Details Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                ad_staff dashboard = new ad_staff();
                dashboard.tra = tra;
                dashboard.Show();
            }

        }

        private void textBoxnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBoxpn1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

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
