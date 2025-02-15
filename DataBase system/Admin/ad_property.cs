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
using System.Windows.Forms.VisualStyles;

namespace DataBase_system.Admin
{
    public partial class ad_property : Form
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

        public ad_property()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=quiet_attic_films; Integrated Security=True;";

        private void ad_property_Load(object sender, EventArgs e)
        {
            buttexit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttexit.Width, buttexit.Height, 20, 20));
            buttlogout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttlogout.Width, buttlogout.Height, 20, 20));
            menupanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, menupanel.Width, menupanel.Height, 20, 20));
            buttonclandre.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonclandre.Width, buttonclandre.Height, 20, 20));
            buttonsc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonsc.Width, buttonsc.Height, 20, 20));
            buttonsc2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonsc2.Width, buttonsc2.Height, 20, 20));
            buttonadddpro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonadddpro.Width, buttonadddpro.Height, 20, 20));
            buttonedipro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonedipro.Width, buttonedipro.Height, 20, 20));
            buttondelpro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttondelpro.Width, buttondelpro.Height, 20, 20));
            buttonaddequ.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonaddequ.Width, buttonaddequ.Height, 20, 20));
            buttonedidequ.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonedidequ.Width, buttonedidequ.Height, 20, 20));
            buttondelequ.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttondelequ.Width, buttondelequ.Height, 20, 20));
            buttonaddproty.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonaddproty.Width, buttonaddproty.Height, 20, 20));

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT DISTINCT property_id, name_is, location_is, property_type FROM view17";

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

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT DISTINCT equip_id, name_is, quantity FROM equipment";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView2.DataSource = dt;
                        }
                        Con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            //property_id combo box button
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM property", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxproid.DataSource = table1;
                    comboBoxproid.DisplayMember = "property_id";
                    comboBoxproid.ValueMember = "property_id";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            //property_type combo box button
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM property_type", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxproytpe.DataSource = table1;
                    comboBoxproytpe.DisplayMember = "property_type";
                    comboBoxproytpe.ValueMember = "property_type";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            //equment id combo box button
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM equipment", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxequid.DataSource = table1;
                    comboBoxequid.DisplayMember = "equip_id";
                    comboBoxequid.ValueMember = "equip_id";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
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

        private void buttexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
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

        private void labelproduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_product dashboard = new ad_product();
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

        private void labelacter_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_acters dashboard = new ad_acters();
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

        private void panelproduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_product dashboard = new ad_product();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void customerspanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_customer dashboard = new ad_customer();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void panelstaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_staff dashboard = new ad_staff();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void panelpayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_payment dashboard = new ad_payment();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void buttonclandre_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_property dashboard = new ad_property();
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

                    string queryn = "SELECT DISTINCT property_id, name_is, location_is, property_type FROM view17 WHERE name_is LIKE '%' + @name_is + '%' ;";

                    using (SqlCommand cmdn = new SqlCommand(queryn, Con))
                    {
                        cmdn.Parameters.AddWithValue("@name_is", textBoxsc.Text);

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

        private void buttonsc2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string queryn = "SELECT DISTINCT equip_id, name_is, quantity FROM equipment WHERE name_is LIKE '%' + @name_is + '%' ;";

                    using (SqlCommand cmdn = new SqlCommand(queryn, Con))
                    {
                        cmdn.Parameters.AddWithValue("@name_is", textBoxsc2.Text);

                        using (SqlDataAdapter dan = new SqlDataAdapter(cmdn))
                        {
                            DataTable dtn = new DataTable();
                            dan.Fill(dtn);
                            dataGridView2.DataSource = dtn;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                comboBoxproid.Text = row.Cells["property_id"].Value.ToString();
                textBoxpron.Text = row.Cells["name_is"].Value.ToString();
                textBoxlo.Text = row.Cells["location_is"].Value.ToString();
                comboBoxproytpe.Text = row.Cells["property_type"].Value.ToString();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                comboBoxequid.Text = row.Cells["equip_id"].Value.ToString();
                textBoxequna.Text = row.Cells["name_is"].Value.ToString();
                textBoxeququan.Text = row.Cells["quantity"].Value.ToString();
            }
        }

        private void buttonadddpro_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Use parameterized query to avoid SQL injection
                cmd.CommandText = "INSERT INTO [property] (name_is, location_is, property_type_id) VALUES (@name_is, @location_is, @property_type_id)";

                // Add parameters
                cmd.Parameters.AddWithValue("@name_is", textBoxpron.Text);
                cmd.Parameters.AddWithValue("@location_is", textBoxlo.Text);

                string selectedPropertyType = comboBoxproytpe.Text;

                // Assuming Con is your SqlConnection object
                using (SqlCommand cmdr = new SqlCommand("SELECT property_type_id FROM property_type WHERE property_type = @property_type", Con))
                {
                    cmdr.Parameters.AddWithValue("@property_type", selectedPropertyType);
                    object result = cmdr.ExecuteScalar();

                    if (result != null)
                    {
                        int propertyTypeId = Convert.ToInt32(result);
                        cmd.Parameters.AddWithValue("@property_type_id", propertyTypeId);
                    }
                    else
                    {
                        MessageBox.Show("Error, Property type not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Property Details Inserted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                ad_property dashboard = new ad_property();
                dashboard.tra = tra;
                dashboard.Show();
            }
        }

        private void buttonedipro_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Use parameterized query to avoid SQL injection
                cmd.CommandText = "UPDATE [property] SET name_is = @name_is, location_is = @location_is, property_type_id = @property_type_id WHERE property_id = @property_id";

                // Add parameters
                cmd.Parameters.AddWithValue("@name_is", textBoxpron.Text);
                cmd.Parameters.AddWithValue("@location_is", textBoxlo.Text);

                string selectedPropertyType = comboBoxproytpe.Text;

                // Assuming Con is your SqlConnection object
                using (SqlCommand cmdr = new SqlCommand("SELECT property_type_id FROM property_type WHERE property_type = @property_type", Con))
                {
                    cmdr.Parameters.AddWithValue("@property_type", selectedPropertyType);
                    object result = cmdr.ExecuteScalar();

                    if (result != null)
                    {
                        int propertyTypeId = Convert.ToInt32(result);
                        cmd.Parameters.AddWithValue("@property_type_id", propertyTypeId);
                    }
                    else
                    {
                        MessageBox.Show("Error, Property type not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Assuming you have an id for the equipment you want to update
                cmd.Parameters.AddWithValue("@property_id", comboBoxproid.Text);

                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Property Details Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                ad_property dashboard = new ad_property();
                dashboard.tra = tra;
                dashboard.Show();
            }
        }

        private void buttondelpro_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Use parameterized query to avoid SQL injection
                cmd.CommandText = "DELETE FROM [property] WHERE property_id = @property_id";

                // Assuming you have an id for the property you want to delete
                cmd.Parameters.AddWithValue("@property_id", comboBoxproid.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                Con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Property Details Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error, Property not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Hide();
                ad_property dashboard = new ad_property();
                dashboard.tra = tra;
                dashboard.Show();
            }

        }

        private void comboBoxproid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int productid;
            if (int.TryParse(comboBoxproid.SelectedValue?.ToString(), out productid))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT DISTINCT property_id, name_is, location_is, property_type FROM view17 WHERE property_id = @property_id";
                    cmd.Parameters.AddWithValue("@property_id", productid);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        textBoxpron.Text = dt.Rows[0]["name_is"].ToString();
                        textBoxlo.Text = dt.Rows[0]["location_is"].ToString();
                        comboBoxproytpe.Text = dt.Rows[0]["property_type"].ToString();
                    }
                }
            }
        }

        private void comboBoxequid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int productid;
            if (int.TryParse(comboBoxequid.SelectedValue?.ToString(), out productid))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT DISTINCT equip_id, name_is, quantity FROM equipment WHERE equip_id = @equip_id";
                    cmd.Parameters.AddWithValue("@equip_id", productid);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        textBoxequna.Text = dt.Rows[0]["name_is"].ToString();
                        textBoxeququan.Text = dt.Rows[0]["quantity"].ToString();
                    }
                }
            }
        }

        private void buttonaddequ_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Use parameterized query to avoid SQL injection
                cmd.CommandText = "INSERT INTO [equipment] (name_is, quantity) VALUES (@name_is, @quantity)";

                // Add parameters
                cmd.Parameters.AddWithValue("@name_is", textBoxequna.Text);
                cmd.Parameters.AddWithValue("@quantity", textBoxeququan.Text);

                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Equipment Details Inserted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                ad_property dashboard = new ad_property();
                dashboard.tra = tra;
                dashboard.Show();
            }
        }

        private void buttonedidequ_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Use parameterized query to avoid SQL injection
                cmd.CommandText = "UPDATE [equipment] SET name_is = @name_is, quantity = @quantity WHERE equip_id = @equip_id";

                // Add parameters
                cmd.Parameters.AddWithValue("@name_is", textBoxequna.Text);
                cmd.Parameters.AddWithValue("@quantity", textBoxeququan.Text);

                // Assuming you have an id for the equipment you want to update
                cmd.Parameters.AddWithValue("@equip_id", comboBoxequid.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                Con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Equipment Details Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error, Equipment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Hide();
                ad_property dashboard = new ad_property();
                dashboard.tra = tra;
                dashboard.Show();
            }
        }

        private void buttondelequ_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Use parameterized query to avoid SQL injection
                cmd.CommandText = "DELETE FROM [equipment] WHERE equip_id = @equip_id";

                // Assuming you have an id for the equipment you want to delete
                cmd.Parameters.AddWithValue("@equip_id", comboBoxequid.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                Con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Equipment Details Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error, Equipment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Hide();
                ad_property dashboard = new ad_property();
                dashboard.tra = tra;
                dashboard.Show();
            }

        }

        private void buttonaddproty_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_protype dashboard = new ad_protype();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void textBoxeququan_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
