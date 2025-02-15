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

namespace DataBase_system.Cashier
{
    public partial class Cashier : Form
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

        public Cashier()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=quiet_attic_films; Integrated Security=True;";

        private void Cashier_Load(object sender, EventArgs e)
        {
            buttexit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttexit.Width, buttexit.Height, 20, 20));
            buttlogout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttlogout.Width, buttlogout.Height, 20, 20));
            menupanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, menupanel.Width, menupanel.Height, 20, 20));
            Productspanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Productspanel.Width, Productspanel.Height, 40, 40));
            customerspanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, customerspanel.Width, customerspanel.Height, 40, 40));
            panelproduct.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelproduct.Width, panelproduct.Height, 40, 40));
            textBoxpayment.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxpayment.Width, textBoxpayment.Height, 30, 30));
            textBoxcustomers.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxcustomers.Width, textBoxcustomers.Height, 30, 30));
            textBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 30, 30));

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

            if (tra != null)
            {
                using (SqlConnection Con = new SqlConnection(connectionString))
                {
                    Con.Open();

                    string query = "SELECT COUNT(production_id) FROM production";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    int count = (int)cmd.ExecuteScalar();

                    textBox1.Text = count.ToString();

                    Con.Close();
                }
            }
            else
            {
                // Handle the case where tra is null, such as displaying an error message or logging the issue
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

        private void labelproduc_Click(object sender, EventArgs e)
        {
            this.Hide();
            caproduct dashboard = new caproduct();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void Productspanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            capayment dashboard = new capayment();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void customerspanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            cacustomer dashboard = new cacustomer();
            dashboard.tra = tra;
            dashboard.Show();
        }

        private void panelproduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            caproduct dashboard = new caproduct();
            dashboard.tra = tra;
            dashboard.Show();
        }
    }
}
