using DataBase_system.Cashier;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DataBase_system
{
    public partial class Login : Form
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


        public Login()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }
        string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=quiet_attic_films; Integrated Security=True;";

        private void Login_Load(object sender, EventArgs e)
        {
            buttlog.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttlog.Width, buttlog.Height, 30, 30));
            buttclrear.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttclrear.Width, buttclrear.Height, 20, 20));
            buttexit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttexit.Width, buttexit.Height, 20, 20));
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

        private void piclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pimini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttclrear_Click(object sender, EventArgs e)
        {
            textuser.Clear();
            textpas.Clear();
            checkBox1.Checked = false;
            textuser.Focus();
        }

        private void buttexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textpas.UseSystemPasswordChar = false;
            }
            else
            {
                textpas.UseSystemPasswordChar = true;
            }
        }

        private void textpas_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textpas.UseSystemPasswordChar = false;
            }
            else
            {
                textpas.UseSystemPasswordChar = true;
            }
        }

        private void buttlog_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    String querry = "SELECT * FROM login WHERE username = @username AND passw = @password AND status = @status AND login_type_id = @login_type_id";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.Parameters.AddWithValue("@username", textuser.Text);
                    cmd.Parameters.AddWithValue("@password", textpas.Text);
                    cmd.Parameters.AddWithValue("@status", "Online");
                    //check employee Login
                    cmd.Parameters.AddWithValue("@login_type_id", 2);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        try
                        {
                            String querry2 = "SELECT emp_id FROM staff WHERE username = @user";
                            SqlCommand cmd2 = new SqlCommand(querry2, con);
                            cmd2.Parameters.AddWithValue("@user", textuser.Text);

                            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                            DataTable dt2 = new DataTable();
                            sda2.Fill(dt2);
                            if (dt2.Rows.Count > 0)
                            {
                                this.Hide();
                                Dashboard dashboard = new Dashboard();
                                dashboard.tra = dt2.Rows[0][0].ToString();
                                dashboard.Show();
                                return; // Exit the method after successful login
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                            con.Close();
                            return;
                        }
                    }
                    //Cashier login
                    cmd.Parameters["@login_type_id"].Value = 3; // Change login_type_id for admin login
                    sda.SelectCommand = cmd;
                    dt.Clear(); // Clear previous results
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        try
                        {
                            String querry2 = "SELECT emp_id FROM staff WHERE username = @user";
                            SqlCommand cmd2 = new SqlCommand(querry2, con);
                            cmd2.Parameters.AddWithValue("@user", textuser.Text);

                            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                            DataTable dt2 = new DataTable();
                            sda2.Fill(dt2);
                            if (dt2.Rows.Count > 0)
                            {
                                this.Hide();
                                Cashier.Cashier dashboard = new Cashier.Cashier();
                                dashboard.tra = dt2.Rows[0][0].ToString();
                                dashboard.Show();
                                return; // Exit the method after successful login
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                            con.Close();
                            return;
                        }
                    }
                    // Check for admin login
                    cmd.Parameters["@login_type_id"].Value = 1; // Change login_type_id for admin login
                    sda.SelectCommand = cmd;
                    dt.Clear(); // Clear previous results
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        try
                        {
                            String querry2 = "SELECT emp_id FROM staff WHERE username = @user";
                            SqlCommand cmd2 = new SqlCommand(querry2, con);
                            cmd2.Parameters.AddWithValue("@user", textuser.Text);

                            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                            DataTable dt2 = new DataTable();
                            sda2.Fill(dt2);
                            if (dt2.Rows.Count > 0)
                            {
                                this.Hide();
                                admin admin = new admin();
                                admin.tra = dt2.Rows[0][0].ToString();
                                admin.Show();
                                return; // Exit the method after successful login
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                            con.Close();
                            return;
                        }
                    }

                    // If neither user nor admin login was successful
                    MessageBox.Show("Invalid Login Details and Please Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textuser.Clear();
                    textpas.Clear();
                    checkBox1.Checked = false;
                    textuser.Focus();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    con.Close();
                }
            }
        }

        private void textpas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Enter key pressed, trigger login

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();

                        String querry = "SELECT * FROM login WHERE username = @username AND passw = @password AND login_type_id = @login_type_id";
                        SqlCommand cmd = new SqlCommand(querry, con);
                        cmd.Parameters.AddWithValue("@username", textuser.Text);
                        cmd.Parameters.AddWithValue("@password", textpas.Text);
                        //check user Login
                        cmd.Parameters.AddWithValue("@login_type_id", 2);

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            try
                            {
                                String querry2 = "SELECT emp_id FROM staff WHERE username = @user";
                                SqlCommand cmd2 = new SqlCommand(querry2, con);
                                cmd2.Parameters.AddWithValue("@user", textuser.Text);

                                SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                                DataTable dt2 = new DataTable();
                                sda2.Fill(dt2);
                                if (dt2.Rows.Count > 0)
                                {
                                    this.Hide();
                                    Dashboard dashboard = new Dashboard();
                                    dashboard.tra = dt2.Rows[0][0].ToString();
                                    dashboard.Show();
                                    return; // Exit the method after successful login
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                                con.Close();
                                return;
                            }
                        }
                        //Cashier login
                        cmd.Parameters["@login_type_id"].Value = 3; // Change login_type_id for admin login
                        sda.SelectCommand = cmd;
                        dt.Clear(); // Clear previous results
                        sda.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            try
                            {
                                String querry2 = "SELECT emp_id FROM staff WHERE username = @user";
                                SqlCommand cmd2 = new SqlCommand(querry2, con);
                                cmd2.Parameters.AddWithValue("@user", textuser.Text);

                                SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                                DataTable dt2 = new DataTable();
                                sda2.Fill(dt2);
                                if (dt2.Rows.Count > 0)
                                {
                                    this.Hide();
                                    Cashier.Cashier dashboard = new Cashier.Cashier();
                                    dashboard.tra = dt2.Rows[0][0].ToString();
                                    dashboard.Show();
                                    return; // Exit the method after successful login
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                                con.Close();
                                return;
                            }
                        }
                        // Check for admin login
                        cmd.Parameters["@login_type_id"].Value = 1; // Change login_type_id for admin login
                        sda.SelectCommand = cmd;
                        dt.Clear(); // Clear previous results
                        sda.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            try
                            {
                                String querry2 = "SELECT emp_id FROM staff WHERE username = @user";
                                SqlCommand cmd2 = new SqlCommand(querry2, con);
                                cmd2.Parameters.AddWithValue("@user", textuser.Text);

                                SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                                DataTable dt2 = new DataTable();
                                sda2.Fill(dt2);
                                if (dt2.Rows.Count > 0)
                                {
                                    this.Hide();
                                    admin admin = new admin();
                                    admin.tra = dt2.Rows[0][0].ToString();
                                    admin.Show();
                                    return; // Exit the method after successful login
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                                con.Close();
                                return;
                            }
                        }

                        // If neither user nor admin login was successful
                        MessageBox.Show("Invalid Login Details and Please Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textuser.Clear();
                        textpas.Clear();
                        checkBox1.Checked = false;
                        textuser.Focus();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        con.Close();
                    }
                }

            }
        }
    }
}
