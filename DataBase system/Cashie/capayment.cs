using DataBase_system.Admin;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DataBase_system.Cashie
{
    public partial class capayment : Form
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

        public capayment()
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

        private void capayment_Load(object sender, EventArgs e)
        {
            buttexit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttexit.Width, buttexit.Height, 20, 20));
            buttlogout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttlogout.Width, buttlogout.Height, 20, 20));
            menupanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, menupanel.Width, menupanel.Height, 20, 20));
            buttonclandre.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonclandre.Width, buttonclandre.Height, 20, 20));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
            buttonpaytype.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonpaytype.Width, buttonpaytype.Height, 20, 20));

            //data gridview1
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT DISTINCT production_id, product_name, customer_id, payment_id, amount, date_is, payment_type_name, invoice_id FROM view11";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            //filter combobox product id
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT DISTINCT production_id, production_price, customer_id, payment_id, amount, date_is, payment_type_name, invoice_id FROM view11", Con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable table1 = new DataTable();
                    da.Fill(table1);

                    DataTable uniqueTable = table1.AsEnumerable()
                                                  .GroupBy(row => row.Field<int>("production_id"))
                                                  .Select(group => group.First())
                                                  .CopyToDataTable();

                    comboBoxpid.DataSource = uniqueTable;
                    comboBoxpid.DisplayMember = "production_id";
                    comboBoxpid.ValueMember = "production_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            //filter combobox customer id
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT DISTINCT production_id, production_price, customer_id, payment_id, amount, date_is, payment_type_name, invoice_id FROM view11", Con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable table1 = new DataTable();
                    da.Fill(table1);

                    DataTable uniqueTable = table1.AsEnumerable()
                                              .GroupBy(row => row.Field<int>("customer_id"))
                                              .Select(group => group.First())
                                              .CopyToDataTable();

                    comboBoxcid.DataSource = uniqueTable;
                    comboBoxcid.DisplayMember = "customer_id";
                    comboBoxcid.ValueMember = "customer_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            //combobox product id
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT DISTINCT production_id FROM production", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);
                    DataTable uniqueTable = table1.AsEnumerable()
                                              .GroupBy(row => row.Field<int>("production_id"))
                                              .Select(group => group.First())
                                              .CopyToDataTable();

                    comboBoxppid.DataSource = uniqueTable;
                    comboBoxppid.DisplayMember = "production_id";
                    comboBoxppid.ValueMember = "production_id";

                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            //combobox customer id
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT DISTINCT customer_id FROM customer", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);
                    DataTable uniqueTable = table1.AsEnumerable()
                                              .GroupBy(row => row.Field<int>("customer_id"))
                                              .Select(group => group.First())
                                              .CopyToDataTable();

                    comboBoxpcid.DataSource = uniqueTable;
                    comboBoxpcid.DisplayMember = "customer_id";
                    comboBoxpcid.ValueMember = "customer_id";

                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            //combobox payment type
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT payment_type_id, payment_type_name FROM payment_type", Con);
                    SqlDataAdapter dac = new SqlDataAdapter(cmdc);
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    var uniqueRows = table1.AsEnumerable()
                                            .GroupBy(row => row.Field<string>("payment_type_name"))
                                            .Select(group => group.First())
                                            .CopyToDataTable();

                    comboBoxptype.DataSource = uniqueRows;
                    comboBoxptype.DisplayMember = "payment_type_name";
                    comboBoxptype.ValueMember = "payment_type_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


            //combobox payment id
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    SqlCommand cmdc = new SqlCommand("SELECT production_id, production_price, customer_id, payment_id, amount, date_is, payment_type_name, invoice_id FROM view11", Con);
                    SqlDataAdapter dac = new SqlDataAdapter();
                    dac.SelectCommand = cmdc;
                    DataTable table1 = new DataTable();
                    dac.Fill(table1);

                    comboBoxpayid.DataSource = table1;
                    comboBoxpayid.DisplayMember = "payment_id";
                    comboBoxpayid.ValueMember = "payment_id";
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
            capayment dashboard = new capayment();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT production_id, customer_id, payment_id, invoice_id, invoice_date, invoice_amount, emp_id FROM view11 WHERE production_id = @production_id";

                    using (SqlCommand cmda = new SqlCommand(query, Con))
                    {
                        // Get the production_id from the selected row
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

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (int.TryParse(row.Cells["payment_id"].Value.ToString(), out int pid))
                {
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();
                        SqlCommand cmd = Con.CreateCommand();
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "SELECT production_id, customer_id, payment_id, amount, date_is, payment_type_name, invoice_id, invoice_date, invoice_amount, emp_id FROM view11 WHERE payment_id = @payment_id";
                        cmd.Parameters.AddWithValue("@payment_id", pid);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            comboBoxppid.Text = dt.Rows[0]["production_id"].ToString();
                            comboBoxpcid.Text = dt.Rows[0]["customer_id"].ToString();
                            comboBoxpayid.Text = dt.Rows[0]["payment_id"].ToString();
                            textBoxamo.Text = dt.Rows[0]["amount"].ToString();
                            dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["date_is"]);
                            comboBoxptype.Text = dt.Rows[0]["payment_type_name"].ToString();
                            textBoxinid.Text = dt.Rows[0]["invoice_id"].ToString();
                            dateTimePicker2.Value = Convert.ToDateTime(dt.Rows[0]["invoice_date"]);
                            textBoxinamo.Text = dt.Rows[0]["invoice_amount"].ToString();
                            textBoxemid.Text = dt.Rows[0]["emp_id"].ToString();
                        }
                        else
                        {
                            // Handle the error
                        }
                        Con.Close();
                    }
                }
                else
                {
                    // Handle the error
                }
            }
        }

        private void comboBoxpid_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Refresh();

            int productid;
            if (int.TryParse(comboBoxpid.SelectedValue?.ToString(), out productid))
            {
                try
                {
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();

                        string querya = "SELECT DISTINCT production_id, production_price, customer_id, payment_id, amount, date_is, payment_type_name, invoice_id FROM view11 WHERE production_id = @production_id";

                        using (SqlCommand cmda = new SqlCommand(querya, Con))
                        {
                            // Get the production_id from the selected row
                            int productionId = Convert.ToInt32(productid);

                            cmda.Parameters.AddWithValue("@production_id", productionId);

                            using (SqlDataAdapter daa = new SqlDataAdapter(cmda))
                            {
                                DataTable dta = new DataTable();
                                daa.Fill(dta);

                                dataGridView1.DataSource = dta;
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

        private void comboBoxcid_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Refresh();

            int customer_id;
            if (int.TryParse(comboBoxcid.SelectedValue?.ToString(), out customer_id))
            {
                try
                {
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();

                        string querya = "SELECT DISTINCT customer_id, production_id, production_price, payment_id, amount, date_is, payment_type_name, invoice_id FROM view11 WHERE customer_id = @customer_id";

                        using (SqlCommand cmda = new SqlCommand(querya, Con))
                        {
                            // Get the production_id from the selected row
                            int productionId = Convert.ToInt32(customer_id);

                            cmda.Parameters.AddWithValue("@customer_id", customer_id);

                            using (SqlDataAdapter daa = new SqlDataAdapter(cmda))
                            {
                                DataTable dta = new DataTable();
                                daa.Fill(dta);

                                dataGridView1.DataSource = dta;
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

        private void comboBoxpayid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int payment_id;
            if (int.TryParse(comboBoxpayid.SelectedValue?.ToString(), out payment_id))
            {
                try
                {
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();

                        string productionQuery = "SELECT production_id FROM production_payment WHERE payment_id = @payment_id";
                        using (SqlCommand productionCmd = new SqlCommand(productionQuery, Con))
                        {
                            productionCmd.Parameters.AddWithValue("@payment_id", payment_id);

                            int productionId = Convert.ToInt32(productionCmd.ExecuteScalar());

                            
                            string query2 = "SELECT production_id, customer_id, payment_id, invoice_id, invoice_date, invoice_amount, emp_id FROM view11 WHERE production_id = @production_id";
                            using (SqlCommand cmda2 = new SqlCommand(query2, Con))
                            {
                                cmda2.Parameters.AddWithValue("@production_id", productionId);

                                using (SqlDataAdapter daa2 = new SqlDataAdapter(cmda2))
                                {
                                    DataTable dta2 = new DataTable();
                                    daa2.Fill(dta2);

                                    label10.Visible = true;
                                    
                                    dataGridView2.DataSource = dta2;
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
                // Handle the error
            }

            try
            {
                if (int.TryParse(comboBoxpayid.SelectedValue?.ToString(), out payment_id))
                {
                    // Conversion successful, use productid
                    using (SqlConnection Con = new SqlConnection(connectionString))
                    {
                        Con.Open();
                        SqlCommand cmd = Con.CreateCommand();
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "SELECT production_id, customer_id, payment_id, amount, date_is, payment_type_name, invoice_id, invoice_date, invoice_amount, emp_id FROM view11 WHERE payment_id = @payment_id";
                        cmd.Parameters.AddWithValue("@payment_id", payment_id);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            comboBoxppid.Text = dt.Rows[0]["production_id"].ToString();
                            comboBoxpcid.Text = dt.Rows[0]["customer_id"].ToString();
                            comboBoxpayid.Text = dt.Rows[0]["payment_id"].ToString();
                            textBoxamo.Text = dt.Rows[0]["amount"].ToString();
                            dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["date_is"]);
                            comboBoxptype.Text = dt.Rows[0]["payment_type_name"].ToString();
                            textBoxinid.Text = dt.Rows[0]["invoice_id"].ToString();
                            dateTimePicker2.Value = Convert.ToDateTime(dt.Rows[0]["invoice_date"]);
                            textBoxinamo.Text = dt.Rows[0]["invoice_amount"].ToString();
                            textBoxemid.Text = dt.Rows[0]["emp_id"].ToString();
                        }
                        else
                        {
                            // Handle the error
                        }
                        Con.Close();
                    }
                }
                else
                {
                    // Handle the error
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(comboBoxppid.Text)) && (!string.IsNullOrEmpty(comboBoxpcid.Text)) && (!string.IsNullOrEmpty(textBoxamo.Text)) && (!string.IsNullOrEmpty(comboBoxptype.Text)) && (!string.IsNullOrEmpty(textBoxinamo.Text)))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    //1st query
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    
                    cmd.CommandText = "INSERT INTO [invoice] (date_is, amount, emp_id) VALUES " +
                        "(@date_is, @amount, @emp_id)";

                    // Add parameters
                    cmd.Parameters.AddWithValue("@amount", textBoxinamo.Text);

                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_is", today);
                    cmd.Parameters.AddWithValue("@emp_id", tra);

                    cmd.ExecuteNonQuery();

                    //select max value in invoice id
                    SqlCommand cmdss = Con.CreateCommand();
                    cmdss.CommandText = "SELECT MAX(invoice_id) AS highest_invoice_id FROM invoice;";
                    int highestInvoiceId = 0;
                    using (SqlDataReader reader = cmdss.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            highestInvoiceId = reader.GetInt32(0);
                        }
                    }

                    //2nd query
                    SqlCommand cmda = Con.CreateCommand();
                    cmda.CommandType = CommandType.Text;

                    
                    cmda.CommandText = "INSERT INTO [payment] (amount, date_is, invoice_id, payment_type_id) VALUES " +
                        "(@amount, @date_is, @invoice_id, @payment_type)";

                    // Add parameters
                    cmda.Parameters.AddWithValue("@amount", textBoxamo.Text);
                    cmda.Parameters.AddWithValue("@date_is", today);
                    cmda.Parameters.AddWithValue("@invoice_id", highestInvoiceId);

                    string selectedPaymentType = comboBoxptype.Text;

                    
                    using (SqlCommand cmdr = new SqlCommand("SELECT payment_type_id FROM payment_type WHERE payment_type_name = @PaymentType", Con))
                    {
                        cmdr.Parameters.AddWithValue("@PaymentType", selectedPaymentType);
                        object result = cmdr.ExecuteScalar();

                        if (result != null)
                        {
                            int paymentTypeId = Convert.ToInt32(result);

                            cmda.Parameters.AddWithValue("@payment_type", paymentTypeId);

                            cmda.ExecuteNonQuery();

                            // 3rd query
                            SqlCommand cmdv = Con.CreateCommand();
                            cmdv.CommandType = CommandType.Text;

                            
                            cmdv.CommandText = "INSERT INTO [production_payment] (production_id, payment_id) VALUES " +
                                "(@production_id, @payment_id)";

                            // Add parameters
                            cmdv.Parameters.AddWithValue("@production_id", comboBoxppid.Text);

                            // Get the highest payment ID from the invoice table
                            int highestpayId = 0;
                            using (SqlCommand cmdpi = Con.CreateCommand())
                            {
                                cmdpi.CommandText = "SELECT MAX(payment_id) AS highest_payment_id FROM payment;";
                                using (SqlDataReader reader2 = cmdpi.ExecuteReader())
                                {
                                    if (reader2.Read())
                                    {
                                        highestpayId = reader2.GetInt32(0);
                                    }
                                }
                            }
                            cmdv.Parameters.AddWithValue("@payment_id", highestpayId);

                            cmdv.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Payment type not found.");
                        }
                    }

                    Con.Close();
                    MessageBox.Show("Record Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    comboBoxpayid.Text = "";
                    comboBoxppid.Text = "";
                    comboBoxpcid.Text = "";
                    textBoxamo.Text = "";
                    comboBoxptype.Text = "";
                    textBoxinid.Text = "";
                    textBoxinamo.Text = "";
                    textBoxemid.Text = "";

                    this.Hide();
                    capayment dashboard = new capayment();
                    dashboard.tra = tra;
                    dashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Error, Please fill all the field boxes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxppid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ppid;
            if (int.TryParse(comboBoxppid.SelectedValue?.ToString(), out ppid))
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "SELECT production_id, customer_id FROM view11 WHERE production_id = @production_id";
                    cmd.Parameters.AddWithValue("@production_id", ppid);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        comboBoxpcid.Text = dt.Rows[0]["customer_id"].ToString();
                    }
                    else
                    {
                        // Handle the error
                    }
                    Con.Close();
                }
            }
        }

        private void textBoxinamo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxamo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxinid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxemid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonpaytype_Click(object sender, EventArgs e)
        {
            this.Hide();
            pattype dashboard = new pattype();
            dashboard.tra = tra;
            dashboard.Show();
        }
    }
}
