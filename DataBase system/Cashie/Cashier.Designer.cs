namespace DataBase_system.Cashier
{
    partial class Cashier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            this.menupanel = new System.Windows.Forms.Panel();
            this.labelproduc = new System.Windows.Forms.Label();
            this.labelcustomer = new System.Windows.Forms.Label();
            this.labelaccount = new System.Windows.Forms.Label();
            this.labelproduct = new System.Windows.Forms.Label();
            this.labelhome = new System.Windows.Forms.Label();
            this.buttlogout = new System.Windows.Forms.Button();
            this.buttexit = new System.Windows.Forms.Button();
            this.Productspanel = new System.Windows.Forms.Panel();
            this.textBoxpayment = new System.Windows.Forms.TextBox();
            this.labelProducts = new System.Windows.Forms.Label();
            this.customerspanel = new System.Windows.Forms.Panel();
            this.textBoxcustomers = new System.Windows.Forms.TextBox();
            this.labelprodu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.pimini = new System.Windows.Forms.PictureBox();
            this.piclose = new System.Windows.Forms.PictureBox();
            this.panelproduct = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menupanel.SuspendLayout();
            this.Productspanel.SuspendLayout();
            this.customerspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pimini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclose)).BeginInit();
            this.panelproduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.SkyBlue;
            this.menupanel.Controls.Add(this.labelproduc);
            this.menupanel.Controls.Add(this.labelcustomer);
            this.menupanel.Controls.Add(this.labelaccount);
            this.menupanel.Controls.Add(this.labelproduct);
            this.menupanel.Controls.Add(this.labelhome);
            this.menupanel.Location = new System.Drawing.Point(0, 0);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(1230, 61);
            this.menupanel.TabIndex = 17;
            // 
            // labelproduc
            // 
            this.labelproduc.AutoSize = true;
            this.labelproduc.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelproduc.ForeColor = System.Drawing.Color.White;
            this.labelproduc.Location = new System.Drawing.Point(535, 14);
            this.labelproduc.Name = "labelproduc";
            this.labelproduc.Size = new System.Drawing.Size(110, 33);
            this.labelproduc.TabIndex = 16;
            this.labelproduc.Text = "Product";
            this.labelproduc.Click += new System.EventHandler(this.labelproduc_Click);
            // 
            // labelcustomer
            // 
            this.labelcustomer.AutoSize = true;
            this.labelcustomer.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelcustomer.ForeColor = System.Drawing.Color.White;
            this.labelcustomer.Location = new System.Drawing.Point(793, 15);
            this.labelcustomer.Name = "labelcustomer";
            this.labelcustomer.Size = new System.Drawing.Size(134, 33);
            this.labelcustomer.TabIndex = 15;
            this.labelcustomer.Text = "Customer";
            this.labelcustomer.Click += new System.EventHandler(this.labelcustomer_Click);
            // 
            // labelaccount
            // 
            this.labelaccount.AutoSize = true;
            this.labelaccount.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelaccount.ForeColor = System.Drawing.Color.White;
            this.labelaccount.Location = new System.Drawing.Point(1075, 15);
            this.labelaccount.Name = "labelaccount";
            this.labelaccount.Size = new System.Drawing.Size(115, 33);
            this.labelaccount.TabIndex = 14;
            this.labelaccount.Text = "Account";
            this.labelaccount.Click += new System.EventHandler(this.labelaccount_Click);
            // 
            // labelproduct
            // 
            this.labelproduct.AutoSize = true;
            this.labelproduct.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelproduct.ForeColor = System.Drawing.Color.White;
            this.labelproduct.Location = new System.Drawing.Point(265, 15);
            this.labelproduct.Name = "labelproduct";
            this.labelproduct.Size = new System.Drawing.Size(122, 33);
            this.labelproduct.TabIndex = 12;
            this.labelproduct.Text = "Payment";
            this.labelproduct.Click += new System.EventHandler(this.labelproduct_Click);
            // 
            // labelhome
            // 
            this.labelhome.AutoSize = true;
            this.labelhome.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhome.Location = new System.Drawing.Point(30, 15);
            this.labelhome.Name = "labelhome";
            this.labelhome.Size = new System.Drawing.Size(87, 33);
            this.labelhome.TabIndex = 11;
            this.labelhome.Text = "Home";
            // 
            // buttlogout
            // 
            this.buttlogout.BackColor = System.Drawing.Color.SkyBlue;
            this.buttlogout.FlatAppearance.BorderSize = 0;
            this.buttlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttlogout.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.buttlogout.Location = new System.Drawing.Point(1283, 748);
            this.buttlogout.Name = "buttlogout";
            this.buttlogout.Size = new System.Drawing.Size(105, 40);
            this.buttlogout.TabIndex = 16;
            this.buttlogout.Text = "Logout";
            this.buttlogout.UseVisualStyleBackColor = false;
            this.buttlogout.Click += new System.EventHandler(this.buttlogout_Click);
            // 
            // buttexit
            // 
            this.buttexit.BackColor = System.Drawing.Color.SkyBlue;
            this.buttexit.FlatAppearance.BorderSize = 0;
            this.buttexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttexit.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttexit.Location = new System.Drawing.Point(1283, 798);
            this.buttexit.Name = "buttexit";
            this.buttexit.Size = new System.Drawing.Size(105, 40);
            this.buttexit.TabIndex = 15;
            this.buttexit.Text = "Exit";
            this.buttexit.UseVisualStyleBackColor = false;
            this.buttexit.Click += new System.EventHandler(this.buttexit_Click);
            // 
            // Productspanel
            // 
            this.Productspanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Productspanel.Controls.Add(this.textBoxpayment);
            this.Productspanel.Controls.Add(this.labelProducts);
            this.Productspanel.Location = new System.Drawing.Point(97, 306);
            this.Productspanel.Name = "Productspanel";
            this.Productspanel.Size = new System.Drawing.Size(400, 210);
            this.Productspanel.TabIndex = 18;
            this.Productspanel.Click += new System.EventHandler(this.Productspanel_Click);
            // 
            // textBoxpayment
            // 
            this.textBoxpayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxpayment.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.textBoxpayment.Location = new System.Drawing.Point(301, 139);
            this.textBoxpayment.Name = "textBoxpayment";
            this.textBoxpayment.Size = new System.Drawing.Size(75, 39);
            this.textBoxpayment.TabIndex = 1;
            this.textBoxpayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducts.Location = new System.Drawing.Point(11, 10);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(161, 38);
            this.labelProducts.TabIndex = 0;
            this.labelProducts.Text = "Payments";
            // 
            // customerspanel
            // 
            this.customerspanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.customerspanel.Controls.Add(this.textBoxcustomers);
            this.customerspanel.Controls.Add(this.labelprodu);
            this.customerspanel.Location = new System.Drawing.Point(902, 306);
            this.customerspanel.Name = "customerspanel";
            this.customerspanel.Size = new System.Drawing.Size(400, 210);
            this.customerspanel.TabIndex = 19;
            this.customerspanel.Click += new System.EventHandler(this.customerspanel_Click);
            // 
            // textBoxcustomers
            // 
            this.textBoxcustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxcustomers.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.textBoxcustomers.Location = new System.Drawing.Point(308, 139);
            this.textBoxcustomers.Name = "textBoxcustomers";
            this.textBoxcustomers.Size = new System.Drawing.Size(75, 39);
            this.textBoxcustomers.TabIndex = 2;
            this.textBoxcustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelprodu
            // 
            this.labelprodu.AutoSize = true;
            this.labelprodu.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.labelprodu.Location = new System.Drawing.Point(12, 10);
            this.labelprodu.Name = "labelprodu";
            this.labelprodu.Size = new System.Drawing.Size(158, 38);
            this.labelprodu.TabIndex = 0;
            this.labelprodu.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "Home";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.labelname.Location = new System.Drawing.Point(90, 210);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(102, 38);
            this.labelname.TabIndex = 22;
            this.labelname.Text = "Name";
            // 
            // pimini
            // 
            this.pimini.Image = global::DataBase_system.Properties.Resources.minimize_sign;
            this.pimini.Location = new System.Drawing.Point(1263, 12);
            this.pimini.Name = "pimini";
            this.pimini.Size = new System.Drawing.Size(39, 32);
            this.pimini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pimini.TabIndex = 13;
            this.pimini.TabStop = false;
            this.pimini.Click += new System.EventHandler(this.pimini_Click);
            this.pimini.MouseLeave += new System.EventHandler(this.pimini_MouseLeave);
            this.pimini.MouseHover += new System.EventHandler(this.pimini_MouseHover);
            // 
            // piclose
            // 
            this.piclose.Image = global::DataBase_system.Properties.Resources.cross;
            this.piclose.Location = new System.Drawing.Point(1349, 12);
            this.piclose.Name = "piclose";
            this.piclose.Size = new System.Drawing.Size(39, 32);
            this.piclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclose.TabIndex = 14;
            this.piclose.TabStop = false;
            this.piclose.Click += new System.EventHandler(this.piclose_Click);
            this.piclose.MouseLeave += new System.EventHandler(this.piclose_MouseLeave);
            this.piclose.MouseHover += new System.EventHandler(this.piclose_MouseHover);
            // 
            // panelproduct
            // 
            this.panelproduct.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelproduct.Controls.Add(this.textBox1);
            this.panelproduct.Controls.Add(this.label2);
            this.panelproduct.Location = new System.Drawing.Point(504, 549);
            this.panelproduct.Name = "panelproduct";
            this.panelproduct.Size = new System.Drawing.Size(400, 210);
            this.panelproduct.TabIndex = 19;
            this.panelproduct.Click += new System.EventHandler(this.panelproduct_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(301, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 39);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Products";
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1400, 850);
            this.Controls.Add(this.panelproduct);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.menupanel);
            this.Controls.Add(this.buttlogout);
            this.Controls.Add(this.buttexit);
            this.Controls.Add(this.Productspanel);
            this.Controls.Add(this.customerspanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pimini);
            this.Controls.Add(this.piclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiet Attic Films";
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.menupanel.ResumeLayout(false);
            this.menupanel.PerformLayout();
            this.Productspanel.ResumeLayout(false);
            this.Productspanel.PerformLayout();
            this.customerspanel.ResumeLayout(false);
            this.customerspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pimini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclose)).EndInit();
            this.panelproduct.ResumeLayout(false);
            this.panelproduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.Label labelaccount;
        private System.Windows.Forms.Label labelproduct;
        private System.Windows.Forms.Label labelhome;
        private System.Windows.Forms.Button buttlogout;
        private System.Windows.Forms.Button buttexit;
        private System.Windows.Forms.Panel Productspanel;
        private System.Windows.Forms.TextBox textBoxpayment;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Panel customerspanel;
        private System.Windows.Forms.TextBox textBoxcustomers;
        private System.Windows.Forms.Label labelprodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pimini;
        private System.Windows.Forms.PictureBox piclose;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelcustomer;
        private System.Windows.Forms.Label labelproduc;
        private System.Windows.Forms.Panel panelproduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}