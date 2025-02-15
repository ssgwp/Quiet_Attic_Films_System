using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBase_system.Cashie
{
    public partial class cacustomer : Form
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

        public cacustomer()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=quiet_attic_films; Integrated Security=True;";

        private void labelhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cashier.Cashier dashboard = new Cashier.Cashier();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void labelproduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            capayment dashboard = new capayment();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void labelaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            caaccount dashboard = new caaccount();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void cacustomer_Load(object sender, EventArgs e)
        {
            buttexit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttexit.Width, buttexit.Height, 20, 20));
            buttlogout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttlogout.Width, buttlogout.Height, 20, 20));
            menupanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, menupanel.Width, menupanel.Height, 20, 20));
            buttonclandre.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonclandre.Width, buttonclandre.Height, 20, 20));
            buttonedit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonedit.Width, buttonedit.Height, 20, 20));
            buttonsc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonsc.Width, buttonsc.Height, 20, 20));

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT DISTINCT customer_id, f_name, l_name, nic, phone_no1, phone_no2 FROM customer";

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

            //customer combo box button

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

        private void piclose_MouseHover(object sender, EventArgs e)
        {
            piclose.BackColor = Color.Red;
        }

        private void piclose_MouseLeave(object sender, EventArgs e)
        {
            piclose.BackColor = Color.WhiteSmoke;
        }

        private void pimini_MouseHover(object sender, EventArgs e)
        {
            pimini.BackColor = Color.Gray;
        }

        private void pimini_MouseLeave(object sender, EventArgs e)
        {
            pimini.BackColor = Color.WhiteSmoke;
        }

        private void labelproduc_Click(object sender, EventArgs e)
        {
            this.Hide();
            caproduct dashboard = new caproduct();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void buttonclandre_Click(object sender, EventArgs e)
        {
            this.Hide();
            cacustomer dashboard = new cacustomer();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void comboBoxcusid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int customer_id;
            try
            {
                if (int.TryParse(comboBoxcusid.SelectedValue?.ToString(), out customer_id))
                {
                    // Conversion successful, use productid
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();
                        SqlCommand cmd = Con.CreateCommand();
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "SELECT * FROM customer WHERE customer_id = @customer_id";
                        cmd.Parameters.AddWithValue("@customer_id", customer_id);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            textBoxfn.Text = dt.Rows[0]["f_name"].ToString();
                            textBoxln.Text = dt.Rows[0]["l_name"].ToString();
                            textBoxnic.Text = dt.Rows[0]["nic"].ToString();
                            textBoxadd.Text = dt.Rows[0]["addressis"].ToString();
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
                if (int.TryParse(comboBoxcusid.SelectedValue?.ToString(), out customer_id))
                {
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();

                        string query = "SELECT customer_id, production_id, product_name, price, start__date, no_of_date, production_type, complete FROM view9 WHERE customer_id = @customer_id";

                        using (SqlCommand cmda = new SqlCommand(query, Con))
                        {

                            cmda.Parameters.AddWithValue("@customer_id", customer_id);

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT customer_id, production_id, product_name, price, start__date, no_of_date, production_type, complete FROM view9 WHERE customer_id = @customer_id";

                    using (SqlCommand cmda = new SqlCommand(query, Con))
                    {

                        int productionId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["customer_id"].Value);

                        cmda.Parameters.AddWithValue("@customer_id", productionId);

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

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                comboBoxcusid.Text = row.Cells["customer_id"].Value.ToString();
                textBoxfn.Text = row.Cells["f_name"].Value.ToString();
                textBoxln.Text = row.Cells["l_name"].Value.ToString();
                
                textBoxpn1.Text = row.Cells["phone_no1"].Value.ToString();
                textBoxpn2.Text = row.Cells["phone_no2"].Value.ToString();

                if (int.TryParse(row.Cells["customer_id"].Value.ToString(), out int pid))
                {
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();
                        SqlCommand cmd = Con.CreateCommand();
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "SELECT customer_id, nic, addressis, email FROM customer WHERE customer_id = @customer_id";
                        cmd.Parameters.AddWithValue("@customer_id", pid);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            textBoxnic.Text = row.Cells["nic"].Value.ToString();
                            textBoxadd.Text = dt.Rows[0]["addressis"].ToString();
                            textBoxema.Text = dt.Rows[0]["email"].ToString();
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
                    // Handle parsing error
                }
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

                    // Use parameterized query
                    cmd.CommandText = "UPDATE [customer] SET f_name = @f_name, l_name = @l_name, nic = @nic, addressis = @addressis, email = @email, phone_no1 = @phone_no1, phone_no2 = @phone_no2 WHERE customer_id = @customer_id";

                    // Add parameters
                    cmd.Parameters.AddWithValue("@customer_id", comboBoxcusid.Text);
                    cmd.Parameters.AddWithValue("@f_name", textBoxfn.Text);
                    cmd.Parameters.AddWithValue("@l_name", textBoxln.Text);
                    cmd.Parameters.AddWithValue("@nic", textBoxnic.Text);
                    cmd.Parameters.AddWithValue("@addressis", textBoxadd.Text);
                    cmd.Parameters.AddWithValue("@email", textBoxema.Text);
                    cmd.Parameters.AddWithValue("@phone_no1", textBoxpn1.Text);
                    cmd.Parameters.AddWithValue("@phone_no2", textBoxpn2.Text);

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    DialogResult dialogResult = MessageBox.Show("Details Edit Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Con.Close();
                    this.Hide();
                    cacustomer dashboard = new cacustomer();
                    dashboard.tra = tra;
                    dashboard.Show();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Error, Please fill the all field boxes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonsc_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string queryn = "SELECT DISTINCT customer_id, f_name, l_name, nic, phone_no1, phone_no2 FROM customer WHERE f_name LIKE '%' + @f_name + '%' OR l_name LIKE '%' + @l_name + '%' ;";

                    using (SqlCommand cmdn = new SqlCommand(queryn, Con))
                    {
                        cmdn.Parameters.AddWithValue("@f_name", textBoxsc.Text);
                        cmdn.Parameters.AddWithValue("@l_name", textBoxsc.Text);

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

        private void textBoxnic_KeyPress(object sender, KeyPressEventArgs e)
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
