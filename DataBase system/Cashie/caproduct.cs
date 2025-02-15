using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DataBase_system.Cashie
{
    public partial class caproduct : Form
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

        public caproduct()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=quiet_attic_films; Integrated Security=True;";

        private void caproduct_Load(object sender, EventArgs e)
        {
            buttexit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttexit.Width, buttexit.Height, 20, 20));
            buttlogout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttlogout.Width, buttlogout.Height, 20, 20));
            menupanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, menupanel.Width, menupanel.Height, 20, 20));
            buttonclandre.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonclandre.Width, buttonclandre.Height, 20, 20));
            buttonsc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonsc.Width, buttonsc.Height, 20, 20));

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
        }

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

        private void labelcustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            cacustomer dashboard = new cacustomer();
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

        private void buttonclandre_Click(object sender, EventArgs e)
        {
            this.Hide();
            caproduct dashboard = new caproduct();
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
                        textBoxpna.Text = dt.Rows[0]["product_name"].ToString();
                        textBoxpt.Text = dt.Rows[0]["production_type"].ToString();
                        textBoxprice.Text = dt.Rows[0]["price"].ToString();
                        dateTimePickerstd.Value = Convert.ToDateTime(dt.Rows[0]["start__date"]);
                        textBoxnod.Text = dt.Rows[0]["no_of_date"].ToString();
                        textBoxcom.Text = dt.Rows[0]["complete"].ToString();
                        textBoxcusid.Text = dt.Rows[0]["customer_id"].ToString();

                        decimal pprice;
                        if (decimal.TryParse(dt.Rows[0]["price"].ToString(), out pprice))
                        {
                            textBoxpp.Text = pprice.ToString();

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
                textBoxpna.Text = row.Cells["product_name"].Value.ToString();
                textBoxpt.Text = row.Cells["production_type"].Value.ToString();
                textBoxprice.Text = row.Cells["price"].Value.ToString();
                textBoxcusid.Text = row.Cells["customer_id"].Value.ToString();

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

                textBoxpp.Text = row.Cells["price"].Value.ToString();

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
                            
                        }
                        Con.Close();
                    }
                }
            }
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

        private void buttonclandre_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            caproduct dashboard = new caproduct();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void textBoxprice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxnod_KeyPress(object sender, KeyPressEventArgs e)
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
