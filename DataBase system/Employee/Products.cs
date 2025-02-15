using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DataBase_system
{
    public partial class Products : Form
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

        public Products()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=quiet_attic_films; Integrated Security=True;";

        private void labelhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            buttexit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttexit.Width, buttexit.Height, 20, 20));
            buttlogout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttlogout.Width, buttlogout.Height, 20, 20));
            menupanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, menupanel.Width, menupanel.Height, 20, 20));
            buttonsc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonsc.Width, buttonsc.Height, 20, 20));
            buttonclandre.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonclandre.Width, buttonclandre.Height, 20, 20));

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT production_id, product_name, production_type, start__date, no_of_date, complete FROM view3 WHERE emp_id = @EmpId";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@EmpId", tra);

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
                    SqlCommand cmdc = new SqlCommand("SELECT production_id, product_name, production_type, start__date, no_of_date, complete FROM view3 WHERE emp_id = @EmpId", Con);
                    cmdc.Parameters.AddWithValue("@EmpId", tra);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxpid.DataSource = table1;
                    comboBoxpid.DisplayMember = "view3";
                    comboBoxpid.ValueMember = "production_id";
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void labelaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account dashboard = new Account();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void pimini_MouseHover(object sender, EventArgs e)
        {
            pimini.BackColor = Color.Gray;
        }

        private void pimini_MouseLeave(object sender, EventArgs e)
        {
            pimini.BackColor = Color.WhiteSmoke;
        }

        private void piclose_MouseHover(object sender, EventArgs e)
        {
            piclose.BackColor = Color.Red;
        }

        private void piclose_MouseLeave(object sender, EventArgs e)
        {
            piclose.BackColor = Color.WhiteSmoke;
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

        private void buttexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonsc_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string queryn = "SELECT production_id, product_name, production_type, start__date, no_of_date, complete FROM view3 WHERE emp_id = @EmpId AND product_name LIKE '%' + @productn + '%';";

                    using (SqlCommand cmdn = new SqlCommand(queryn, Con))
                    {
                        cmdn.Parameters.AddWithValue("@EmpId", tra);
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

        private void buttonclandre_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products dashboard = new Products();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                comboBoxpid.Text = row.Cells["production_id"].Value.ToString();
                textBoxpna.Text = row.Cells["product_name"].Value.ToString();
                textBoxpt.Text = row.Cells["production_type"].Value.ToString();

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
                    textBoxcom.Text = row.Cells["complete"].Value.ToString();
                }
                else
                {
                    textBoxcom.Text = "";
                }

                try
                {
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();

                        string querya = "SELECT DISTINCT equip_id, name_is FROM view4 WHERE production_id = @production_id";

                        using (SqlCommand cmda = new SqlCommand(querya, Con))
                        {
                            // Get the production_id from the selected row
                            int productionId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["production_id"].Value);

                            cmda.Parameters.AddWithValue("@production_id", productionId);

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

                try
                {
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();

                        string queryb = "SELECT DISTINCT property_id, p_name, location_is, property_type FROM view4 WHERE production_id = @production_id";

                        using (SqlCommand cmdb = new SqlCommand(queryb, Con))
                        {
                            // Get the production_id from the selected row
                            int productionId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["production_id"].Value);

                            cmdb.Parameters.AddWithValue("@production_id", productionId);

                            using (SqlDataAdapter dab = new SqlDataAdapter(cmdb))
                            {
                                DataTable dtb = new DataTable();
                                dab.Fill(dtb);

                                // Assuming dataGridView2 is another DataGridView to display the results
                                dataGridView4.DataSource = dtb;
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

                        string querye = "SELECT DISTINCT act_id, f_name, l_name, gender FROM view5 WHERE production_id = @production_id";

                        using (SqlCommand cmde = new SqlCommand(querye, Con))
                        {
                            // Get the production_id from the selected row
                            int productionId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["production_id"].Value);

                            cmde.Parameters.AddWithValue("@production_id", productionId);

                            using (SqlDataAdapter dae = new SqlDataAdapter(cmde))
                            {
                                DataTable dte = new DataTable();
                                dae.Fill(dte);

                                // Assuming dataGridView2 is another DataGridView to display the results
                                dataGridView3.DataSource = dte;
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

        private void comboBoxpid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int productid;
            if (int.TryParse(comboBoxpid.SelectedValue?.ToString(), out productid))
            {
                // Conversion successful, use productid
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT production_id, product_name, production_type, start__date, no_of_date, complete FROM view3 WHERE production_id = @production_id";
                    cmd.Parameters.AddWithValue("@production_id", productid);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        textBoxpna.Text = dt.Rows[0]["product_name"].ToString();
                        textBoxpt.Text = dt.Rows[0]["production_type"].ToString();
                        dateTimePickerstd.Value = Convert.ToDateTime(dt.Rows[0]["start__date"]);
                        textBoxnod.Text = dt.Rows[0]["no_of_date"].ToString();
                        textBoxcom.Text = dt.Rows[0]["complete"].ToString();
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

            if (int.TryParse(comboBoxpid.SelectedValue?.ToString(), out productid))
            {
                try
                {
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();

                        string querya = "SELECT DISTINCT equip_id, name_is FROM view4 WHERE production_id = @production_id";

                        using (SqlCommand cmda = new SqlCommand(querya, Con))
                        {
                            // Get the production_id from the selected row
                            int productionId = Convert.ToInt32(productid);

                            cmda.Parameters.AddWithValue("@production_id", productionId);

                            using (SqlDataAdapter daa = new SqlDataAdapter(cmda))
                            {
                                DataTable dta = new DataTable();
                                daa.Fill(dta);

                                // Assuming dataGridView2 is another DataGridView to display the results
                                dataGridView2.DataSource = dta;

                                label8.Visible = true;
                                label9.Visible = true;
                                label10.Visible = true;
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

                        string queryb = "SELECT DISTINCT property_id, p_name, location_is, property_type FROM view4 WHERE production_id = @production_id";

                        using (SqlCommand cmdb = new SqlCommand(queryb, Con))
                        {
                            // Get the production_id from the selected row
                            int productionId = Convert.ToInt32(productid);

                            cmdb.Parameters.AddWithValue("@production_id", productionId);

                            using (SqlDataAdapter dab = new SqlDataAdapter(cmdb))
                            {
                                DataTable dtb = new DataTable();
                                dab.Fill(dtb);

                                // Assuming dataGridView2 is another DataGridView to display the results
                                dataGridView4.DataSource = dtb;
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

                        string querye = "SELECT DISTINCT act_id, f_name, l_name, gender FROM view5 WHERE production_id = @production_id";

                        using (SqlCommand cmde = new SqlCommand(querye, Con))
                        {
                            // Get the production_id from the selected row
                            int productionId = Convert.ToInt32(productid);

                            cmde.Parameters.AddWithValue("@production_id", productionId);

                            using (SqlDataAdapter dae = new SqlDataAdapter(cmde))
                            {
                                DataTable dte = new DataTable();
                                dae.Fill(dte);

                                // Assuming dataGridView2 is another DataGridView to display the results
                                dataGridView3.DataSource = dte;
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
    }
}
