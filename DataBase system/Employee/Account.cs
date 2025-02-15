using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DataBase_system
{
    public partial class Account : Form
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

        public Account()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=quiet_attic_films; Integrated Security=True;";

        private void labelaccount_Click(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {
            buttexit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttexit.Width, buttexit.Height, 20, 20));
            buttlogout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttlogout.Width, buttlogout.Height, 20, 20));
            menupanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, menupanel.Width, menupanel.Height, 20, 20));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 20, 20));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
        }

        private void labelhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void labelproduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products dashboard = new Products();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void pimini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void piclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxcpass.Clear();
            textBoxnpass.Clear();
            textBoxrnpass.Clear();
            checkBoxcp.Checked = false;
            checkBoxnp.Checked = false;
            textBoxcpass.Focus();
        }

        private void checkBoxcp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxcp.Checked == true)
            {
                textBoxcpass.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxcpass.UseSystemPasswordChar = true;
            }
        }

        private void textBoxcpass_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxcp.Checked == true)
            {
                textBoxcpass.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxcpass.UseSystemPasswordChar = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxnp.Checked == true)
            {
                textBoxnpass.UseSystemPasswordChar = false;
                textBoxrnpass.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxnpass.UseSystemPasswordChar = true;
                textBoxrnpass.UseSystemPasswordChar = true;
            }
        }

        private void textBoxnpass_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxnp.Checked == true)
            {
                textBoxnpass.UseSystemPasswordChar = false;
                textBoxrnpass.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxnpass.UseSystemPasswordChar = true;
                textBoxrnpass.UseSystemPasswordChar = true;
            }
        }

        private void textBoxrnpass_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxnp.Checked == true)
            {
                textBoxnpass.UseSystemPasswordChar = false;
                textBoxrnpass.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxnpass.UseSystemPasswordChar = true;
                textBoxrnpass.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    String querry = "SELECT * FROM staff WHERE emp_id = @empid ";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.Parameters.AddWithValue("@empid", tra);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        string det = dt.Rows[0]["username"].ToString();

                        try
                        {
                            String querry2 = "SELECT * FROM login WHERE username = @user";
                            SqlCommand cmd2 = new SqlCommand(querry2, con);
                            cmd2.Parameters.AddWithValue("@user", det);

                            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                            DataTable dt2 = new DataTable();
                            sda2.Fill(dt2);

                            if (dt2.Rows.Count > 0)
                            {
                                string det3 = dt2.Rows[0]["passw"].ToString();

                                if ((textBoxcpass.Text == det3) && (textBoxnpass.Text == textBoxrnpass.Text))
                                {
                                    SqlCommand cmd3 = con.CreateCommand();
                                    cmd3.CommandType = CommandType.Text;
                                    cmd3.CommandText = "UPDATE [login] SET passw = @pass WHERE username = @user";

                                    cmd3.Parameters.AddWithValue("@pass", textBoxnpass.Text);
                                    cmd3.Parameters.AddWithValue("@user", det);
                                    cmd3.ExecuteNonQuery();

                                    MessageBox.Show("Password change Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    textBoxcpass.Text = "";
                                    textBoxnpass.Text = "";
                                    textBoxrnpass.Text = "";

                                    this.Hide();
                                    Account dashboard = new Account();
                                    dashboard.tra = tra;
                                    dashboard.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Passwords do not match or current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
