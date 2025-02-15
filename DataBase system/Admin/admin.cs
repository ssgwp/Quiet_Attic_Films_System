using DataBase_system.Admin;
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

namespace DataBase_system
{
    public partial class admin : Form
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

        public admin()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=quiet_attic_films; Integrated Security=True;";


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

        private void Admin_Load(object sender, EventArgs e)
        {
            buttexit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttexit.Width, buttexit.Height, 20, 20));
            buttlogout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttlogout.Width, buttlogout.Height, 20, 20));
            menupanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, menupanel.Width, menupanel.Height, 20, 20));
            panelpayment.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelpayment.Width, panelpayment.Height, 40, 40));
            customerspanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, customerspanel.Width, customerspanel.Height, 40, 40));
            panelproduct.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelproduct.Width, panelproduct.Height, 40, 40));
            panelstaff.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelstaff.Width, panelstaff.Height, 40, 40));
            textBoxpayment.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxpayment.Width, textBoxpayment.Height, 30, 30));
            textBoxcustomers.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxcustomers.Width, textBoxcustomers.Height, 30, 30));
            textBoxproducts.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxproducts.Width, textBoxproducts.Height, 30, 30));
            textBoxstaff.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxstaff.Width, textBoxstaff.Height, 30, 30));

            try
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT f_name FROM staff WHERE emp_id = @empId";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@empId", tra);

                    object result = cmd.ExecuteScalar();
                    string name = result != null ? result.ToString() : "";

                    string query2 = "SELECT l_name FROM staff WHERE emp_id = @empId";
                    SqlCommand cmd2 = new SqlCommand(query2, Con);
                    cmd2.Parameters.AddWithValue("@empId", tra);

                    object result2 = cmd2.ExecuteScalar();
                    string name2 = result2 != null ? result2.ToString() : "";

                    if (!string.IsNullOrEmpty(name) || !string.IsNullOrEmpty(name2))
                    {
                        labelname.Text = "Hi! " + name + " " + name2;
                    }
                    Con.Close();
                }
            }
            catch
            {

            }

            // products count code
            if (tra != null)
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT COUNT(production_id) FROM production";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    int count = (int)cmd.ExecuteScalar();

                    textBoxproducts.Text = count.ToString();

                    Con.Close();
                }
            }
            else
            {
                // Handle the case where tra is null, such as displaying an error message or logging the issue
            }

            //customer count code
            if (tra != null)
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT COUNT(customer_id) FROM customer ";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    int count = (int)cmd.ExecuteScalar();

                    textBoxcustomers.Text = count.ToString();

                    Con.Close();
                }
            }
            else
            {
                // Handle the case where tra is null, such as displaying an error message or logging the issue
            }

            //payment count code
            if (tra != null)
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT COUNT(payment_id) FROM payment";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    int count = (int)cmd.ExecuteScalar();

                    textBoxpayment.Text = count.ToString();

                    Con.Close();
                }
            }
            else
            {
                // Handle the case where tra is null, such as displaying an error message or logging the issue
            }

            //staff count code
            if (tra != null)
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT COUNT(emp_id) FROM staff";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    int count = (int)cmd.ExecuteScalar();

                    textBoxstaff.Text = count.ToString();

                    Con.Close();
                }
            }
            else
            {
                // Handle the case where tra is null, such as displaying an error message or logging the issue
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

        private void labelprope_Click(object sender, EventArgs e)
        {
            this.Hide();
            ad_property dashboard = new ad_property();
            dashboard.tra = tra;
            dashboard.Show();
        }
    }
}
