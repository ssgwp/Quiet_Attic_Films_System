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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBase_system.Admin
{
    public partial class ad_product : Form
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

        public ad_product()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=quiet_attic_films; Integrated Security=True;";

        private void ad_product_Load(object sender, EventArgs e)
        {
            buttexit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttexit.Width, buttexit.Height, 20, 20));
            buttlogout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttlogout.Width, buttlogout.Height, 20, 20));
            menupanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, menupanel.Width, menupanel.Height, 20, 20));
            buttonap.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonap.Width, buttonap.Height, 20, 20));
            buttonep.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonep.Width, buttonep.Height, 20, 20));
            buttonclandre.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonclandre.Width, buttonclandre.Height, 20, 20));
            buttonsc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonsc.Width, buttonsc.Height, 20, 20));
            buttonadddde.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonadddde.Width, buttonadddde.Height, 20, 20));
            buttondede.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttondede.Width, buttondede.Height, 20, 20));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 20, 20));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM view9", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxpid.DataSource = table1;
                    comboBoxpid.DisplayMember = "view9";
                    comboBoxpid.ValueMember = "production_id";
                    Con.Close();
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

                    string query = "SELECT * FROM view9";

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
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM production_type", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxproty.DataSource = table1;
                    comboBoxproty.DisplayMember = "production_type";
                    comboBoxproty.ValueMember = "production_type";
                    Con.Close();
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
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM customer", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxcusid.DataSource = table1;
                    comboBoxcusid.DisplayMember = "customer_id";
                    comboBoxcusid.ValueMember = "customer_id";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            //product_id in property
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM production", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxproidinpr.DataSource = table1;
                    comboBoxproidinpr.DisplayMember = "production_id";
                    comboBoxproidinpr.ValueMember = "production_id";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            //product_id in equment
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM production", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxproidequ.DataSource = table1;
                    comboBoxproidequ.DisplayMember = "production_id";
                    comboBoxproidequ.ValueMember = "production_id";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            //property id
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM property", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxstid.DataSource = table1;
                    comboBoxstid.DisplayMember = "property_id";
                    comboBoxstid.ValueMember = "property_id";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            //equment id
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT * FROM equipment", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxltid.DataSource = table1;
                    comboBoxltid.DisplayMember = "equip_id";
                    comboBoxltid.ValueMember = "equip_id";
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

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_staff dashboard = new ad_staff();
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

        private void comboBoxpid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int productid;
            if (int.TryParse(comboBoxpid.SelectedValue?.ToString(), out productid))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT * FROM view9 WHERE production_id = @production_id";
                    cmd.Parameters.AddWithValue("@production_id", productid);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        comboBoxproidinpr.Text = productid.ToString();
                        comboBoxproidequ.Text = productid.ToString();
                        textBoxpna.Text = dt.Rows[0]["product_name"].ToString();
                        comboBoxproty.Text = dt.Rows[0]["production_type"].ToString();
                        textBoxprice.Text = dt.Rows[0]["price"].ToString();
                        dateTimePickerstd.Value = Convert.ToDateTime(dt.Rows[0]["start__date"]);
                        textBoxnod.Text = dt.Rows[0]["no_of_date"].ToString();
                        comboBoxsts.Text = dt.Rows[0]["complete"].ToString();
                        comboBoxcusid.Text = dt.Rows[0]["customer_id"].ToString();

                        decimal pprice;
                        if (decimal.TryParse(dt.Rows[0]["price"].ToString(), out pprice))
                        {
                            // Calculate remaining amount
                            SqlCommand sumCmd = Con.CreateCommand();
                            sumCmd.CommandType = CommandType.Text;
                            sumCmd.CommandText = "SELECT SUM(amount) AS total_amount FROM view11 WHERE production_id = @production_id GROUP BY production_id";
                            sumCmd.Parameters.AddWithValue("@production_id", productid);

                            SqlDataAdapter sumDa = new SqlDataAdapter(sumCmd);
                            DataTable sumDt = new DataTable();
                            sumDa.Fill(sumDt);

                            if (sumDt.Rows.Count > 0)
                            {
                                decimal totalAmount = Convert.ToDecimal(sumDt.Rows[0]["total_amount"]);
                                textBoxcp.Text = totalAmount.ToString();

                                decimal remainingAmount = pprice - totalAmount;
                                textBoxpep.Text = remainingAmount.ToString();
                            }
                            else
                            {
                                textBoxpep.Text = pprice.ToString();
                                textBoxcp.Text = "0";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid price format.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No record found for the selected product.");
                    }
                    Con.Close();
                }

                try
                {
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();

                        string query = "SELECT property_id, name_is, property_type, production_id FROM view18 WHERE production_id = @production_id";

                        using (SqlCommand cmda = new SqlCommand(query, Con))
                        {

                            cmda.Parameters.AddWithValue("@production_id", productid);

                            using (SqlDataAdapter daa = new SqlDataAdapter(cmda))
                            {
                                DataTable dta = new DataTable();
                                daa.Fill(dta);

                                label20.Visible = true;
                                label21.Visible = true;

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

                try
                {
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();

                        string query = "SELECT equip_id, name_is, production_id FROM view19 WHERE production_id = @production_id";

                        using (SqlCommand cmda = new SqlCommand(query, Con))
                        {
                            cmda.Parameters.AddWithValue("@production_id", productid);

                            using (SqlDataAdapter daa = new SqlDataAdapter(cmda))
                            {
                                DataTable dta = new DataTable();
                                daa.Fill(dta);

                                dataGridView3.DataSource = dta;
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

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                comboBoxpid.Text = row.Cells["production_id"].Value.ToString();
                comboBoxproidinpr.Text = row.Cells["production_id"].Value.ToString();
                comboBoxproidequ.Text = row.Cells["production_id"].Value.ToString();
                textBoxpna.Text = row.Cells["product_name"].Value.ToString();
                comboBoxproty.Text = row.Cells["production_type"].Value.ToString();
                textBoxprice.Text = row.Cells["price"].Value.ToString();
                comboBoxcusid.Text = row.Cells["customer_id"].Value.ToString();

                if (row.Cells["start__date"].Value != DBNull.Value)
                {
                    dateTimePickerstd.Value = Convert.ToDateTime(row.Cells["start__date"].Value);
                }
                else
                {
                    dateTimePickerstd.Value = DateTimePicker.MinimumDateTime;
                }

                textBoxnod.Text = row.Cells["no_of_date"].Value.ToString();

                if (row.Cells["complete"].Value != DBNull.Value)
                {
                    comboBoxsts.Text = row.Cells["complete"].Value.ToString();
                }
                else
                {
                    comboBoxsts.Text = "";
                }


                string productionIdString = row.Cells["production_id"].Value.ToString();
                int produ;

                string priceString = row.Cells["price"].Value.ToString();
                int pprice;

                if ((int.TryParse(productionIdString, out produ)) && (int.TryParse(priceString, out pprice)))
                {
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();
                        SqlCommand cmd = Con.CreateCommand();
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "SELECT SUM(amount) AS total_amount FROM view11 WHERE production_id = @production_id GROUP BY production_id";
                        cmd.Parameters.AddWithValue("@production_id", produ);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            decimal totalAmount = Convert.ToDecimal(dt.Rows[0]["total_amount"]);
                            textBoxcp.Text = totalAmount.ToString();

                            decimal remainingAmount = pprice - totalAmount;
                            textBoxpep.Text = remainingAmount.ToString();
                        }
                        else
                        {
                            // Handle the case
                        }
                        Con.Close();
                    }
                }

                try
                {
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();

                        string query = "SELECT property_id, name_is, property_type, production_id FROM view18 WHERE production_id = @production_id";

                        using (SqlCommand cmda = new SqlCommand(query, Con))
                        {
                            
                            int productionId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["production_id"].Value);

                            cmda.Parameters.AddWithValue("@production_id", productionId);

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

                try
                {
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();

                        string query = "SELECT equip_id, name_is, production_id FROM view19 WHERE production_id = @production_id";

                        using (SqlCommand cmda = new SqlCommand(query, Con))
                        {
                            
                            int productionId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["production_id"].Value);

                            cmda.Parameters.AddWithValue("@production_id", productionId);

                            using (SqlDataAdapter daa = new SqlDataAdapter(cmda))
                            {
                                DataTable dta = new DataTable();
                                daa.Fill(dta);

                                dataGridView3.DataSource = dta;
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
        }

        private void buttonap_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(textBoxpna.Text)) && (!string.IsNullOrEmpty(comboBoxproty.Text)) && (!string.IsNullOrEmpty(textBoxprice.Text)) && (!string.IsNullOrEmpty(textBoxnod.Text)) && (!string.IsNullOrEmpty(comboBoxsts.Text)))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    //1st query
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    // Use parameterized query
                    cmd.CommandText = "INSERT INTO [production] (product_name, price, start__date, no_of_date, production_type_id, complete) VALUES " +
                        "(@product_name, @price, @start__date, @no_of_date, @production_type_id, @complete)";

                    // Add parameters
                    cmd.Parameters.AddWithValue("@product_name", textBoxpna.Text);
                    cmd.Parameters.AddWithValue("@price", textBoxprice.Text);
                    cmd.Parameters.AddWithValue("@start__date", dateTimePickerstd.Value);
                    cmd.Parameters.AddWithValue("@no_of_date", textBoxnod.Text);

                    string selectedProductionType = comboBoxproty.Text;

                    using (SqlCommand cmdr = new SqlCommand("SELECT production_type_id FROM production_type WHERE production_type = @production_type", Con))
                    {
                        cmdr.Parameters.AddWithValue("@production_type", selectedProductionType);
                        object result = cmdr.ExecuteScalar();

                        if (result != null)
                        {
                            int productionTypeId = Convert.ToInt32(result);
                            cmd.Parameters.AddWithValue("@production_type_id", productionTypeId);
                        }
                        else
                        {
                            MessageBox.Show("Error, Production type not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    cmd.Parameters.AddWithValue("@complete", comboBoxsts.Text);

                    cmd.ExecuteNonQuery();

                    //select max value in invoice id
                    SqlCommand cmdss = Con.CreateCommand();
                    cmdss.CommandText = "SELECT MAX(production_id) AS highest_production_id FROM production;";
                    int highestproId = 0;
                    using (SqlDataReader reader = cmdss.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            highestproId = reader.GetInt32(0);
                        }
                    }

                    //2nd query
                    SqlCommand cmda = Con.CreateCommand();
                    cmda.CommandType = CommandType.Text;

                    // Use parameterized query
                    cmda.CommandText = "INSERT INTO [customer_production] (customer_id, production_id) VALUES " +
                        "(@customer_id, @production_id)";

                    // Add parameters
                    cmda.Parameters.AddWithValue("@customer_id", comboBoxcusid.Text);
                    cmda.Parameters.AddWithValue("@production_id", highestproId);

                    cmda.ExecuteNonQuery();

                    MessageBox.Show("Production added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ad_product dashboard = new ad_product();
                    dashboard.tra = tra;
                    dashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Error, Please fill all the field boxes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void buttonclandre_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_product dashboard = new ad_product();
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

                    string queryn = "SELECT * FROM view9 WHERE product_name LIKE '%' + @productn + '%';";

                    using (SqlCommand cmdn = new SqlCommand(queryn, Con))
                    {
                        cmdn.Parameters.AddWithValue("@productn", textBoxsc.Text);

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

        private void buttonep_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(textBoxpna.Text)) && (!string.IsNullOrEmpty(comboBoxproty.Text)) && (!string.IsNullOrEmpty(textBoxprice.Text)) && (!string.IsNullOrEmpty(textBoxnod.Text)) && (!string.IsNullOrEmpty(comboBoxsts.Text)))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    if (!string.IsNullOrEmpty(comboBoxpid.Text))
                    {
                        int productionId;
                        if (!int.TryParse(comboBoxpid.Text, out productionId))
                        {
                            MessageBox.Show("Invalid production ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Update production table
                        SqlCommand cmdUpdate = Con.CreateCommand();
                        cmdUpdate.CommandType = CommandType.Text;
                        cmdUpdate.CommandText = "UPDATE production SET product_name = @product_name, price = @price, start__date = @start__date, no_of_date = @no_of_date, production_type_id = @production_type_id, complete = @complete WHERE production_id = @production_id";

                        // Add parameters
                        cmdUpdate.Parameters.AddWithValue("@product_name", textBoxpna.Text);
                        cmdUpdate.Parameters.AddWithValue("@price", textBoxprice.Text);
                        cmdUpdate.Parameters.AddWithValue("@start__date", dateTimePickerstd.Value);
                        cmdUpdate.Parameters.AddWithValue("@no_of_date", textBoxnod.Text);

                        string selectedProductionType = comboBoxproty.Text;

                        // Get production_type_id
                        using (SqlCommand cmdr = new SqlCommand("SELECT production_type_id FROM production_type WHERE production_type = @production_type", Con))
                        {
                            cmdr.Parameters.AddWithValue("@production_type", selectedProductionType);
                            object result = cmdr.ExecuteScalar();

                            if (result != null)
                            {
                                int productionTypeId = Convert.ToInt32(result);
                                cmdUpdate.Parameters.AddWithValue("@production_type_id", productionTypeId);
                            }
                            else
                            {
                                MessageBox.Show("Error, Production type not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        cmdUpdate.Parameters.AddWithValue("@complete", comboBoxsts.Text);
                        cmdUpdate.Parameters.AddWithValue("@production_id", productionId);

                        cmdUpdate.ExecuteNonQuery();

                        MessageBox.Show("Production updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        ad_product dashboard = new ad_product();
                        dashboard.tra = tra;
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error, Production ID is required for updating.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error, Please fill all the field boxes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                comboBoxproidinpr.Text = row.Cells["production_id"].Value.ToString();
                comboBoxstid.Text = row.Cells["property_id"].Value.ToString();
                textBoxstn.Text = row.Cells["name_is"].Value.ToString();
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];

                comboBoxproidequ.Text = row.Cells["production_id"].Value.ToString();
                comboBoxltid.Text = row.Cells["equip_id"].Value.ToString();
                textBoxltn.Text = row.Cells["name_is"].Value.ToString();
            }
        }

        private void buttonadddde_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Use parameterized query
                cmd.CommandText = "INSERT INTO [production_property] (production_id, property_id) VALUES (@production_id, @property_id)";

                // Add parameters
                cmd.Parameters.AddWithValue("@production_id", comboBoxproidinpr.Text);
                cmd.Parameters.AddWithValue("@property_id", comboBoxstid.Text);

                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Production Property Details Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                ad_product dashboard = new ad_product();
                dashboard.tra = tra;
                dashboard.Show();
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

                    cmd.CommandText = "SELECT property_id, name_is FROM property WHERE property_id = @property_id";
                    cmd.Parameters.AddWithValue("@property_id", proper);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        textBoxstn.Text = dt.Rows[0]["name_is"].ToString();
                    }
                    else
                    {
                        // Handle the case
                    }
                    Con.Close();
                }
            }
        }

        private void comboBoxltid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int proper;
            if (int.TryParse(comboBoxltid.SelectedValue?.ToString(), out proper))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT equip_id, name_is FROM equipment WHERE equip_id = @equip_id";
                    cmd.Parameters.AddWithValue("@equip_id", proper);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        textBoxltn.Text = dt.Rows[0]["name_is"].ToString();
                    }
                    else
                    {
                        // Handle the case
                    }
                    Con.Close();
                }
            }
        }

        private void buttonedide_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Use parameterized query
                cmd.CommandText = "UPDATE [production_property] SET property_id = @property_id WHERE production_id = @production_id";

                // Add parameters
                cmd.Parameters.AddWithValue("@production_id", comboBoxproidinpr.Text);
                cmd.Parameters.AddWithValue("@property_id", comboBoxstid.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                Con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Production Property Details Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ad_product dashboard = new ad_product();
                    dashboard.tra = tra;
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("No rows were updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void buttondede_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Use parameterized query
                cmd.CommandText = "DELETE FROM [production_property] WHERE production_id = @production_id AND property_id = @property_id";

                // Add parameter
                cmd.Parameters.AddWithValue("@production_id", comboBoxproidinpr.Text);
                cmd.Parameters.AddWithValue("@property_id", comboBoxstid.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                Con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Production Property Details Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ad_product dashboard = new ad_product();
                    dashboard.tra = tra;
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("No rows were deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Use parameterized query
                cmd.CommandText = "INSERT INTO [production_equipment] (production_id, equip_id) VALUES (@production_id, @equip_id)";

                // Add parameters
                cmd.Parameters.AddWithValue("@production_id", comboBoxproidequ.Text);
                cmd.Parameters.AddWithValue("@equip_id", comboBoxltid.Text);

                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Production Equipment Details Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                ad_product dashboard = new ad_product();
                dashboard.tra = tra;
                dashboard.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                SqlCommand cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Use parameterized query
                cmd.CommandText = "UPDATE [production_equipment] SET equip_id = @equip_id WHERE production_id = @production_id";

                // Add parameters
                cmd.Parameters.AddWithValue("@production_id", comboBoxproidequ.Text);
                cmd.Parameters.AddWithValue("@equip_id", comboBoxltid.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                Con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Production Equipment Details Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ad_product dashboard = new ad_product();
                    dashboard.tra = tra;
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("No rows were updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cmd.CommandText = "DELETE FROM [production_equipment] WHERE production_id = @production_id AND equip_id = @equip_id";

                // Add parameter
                cmd.Parameters.AddWithValue("@production_id", comboBoxproidequ.Text);
                cmd.Parameters.AddWithValue("@equip_id", comboBoxltid.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                Con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Production Equipment Details Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    ad_product dashboard = new ad_product();
                    dashboard.tra = tra;
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("No rows were deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void textBoxprice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxnod_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
