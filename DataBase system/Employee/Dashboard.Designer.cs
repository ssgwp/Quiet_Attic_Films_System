namespace DataBase_system
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.buttexit = new System.Windows.Forms.Button();
            this.buttlogout = new System.Windows.Forms.Button();
            this.menupanel = new System.Windows.Forms.Panel();
            this.labelaccount = new System.Windows.Forms.Label();
            this.labelproduct = new System.Windows.Forms.Label();
            this.labelhome = new System.Windows.Forms.Label();
            this.Productspanel = new System.Windows.Forms.Panel();
            this.textBoxproduct = new System.Windows.Forms.TextBox();
            this.labelProducts = new System.Windows.Forms.Label();
            this.customerspanel = new System.Windows.Forms.Panel();
            this.textBoxcustomers = new System.Windows.Forms.TextBox();
            this.labelCustomers = new System.Windows.Forms.Label();
            this.pimini = new System.Windows.Forms.PictureBox();
            this.piclose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.menupanel.SuspendLayout();
            this.Productspanel.SuspendLayout();
            this.customerspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pimini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclose)).BeginInit();
            this.SuspendLayout();
            // 
            // buttexit
            // 
            this.buttexit.BackColor = System.Drawing.Color.SkyBlue;
            this.buttexit.FlatAppearance.BorderSize = 0;
            this.buttexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttexit.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttexit.Location = new System.Drawing.Point(1163, 668);
            this.buttexit.Name = "buttexit";
            this.buttexit.Size = new System.Drawing.Size(105, 40);
            this.buttexit.TabIndex = 6;
            this.buttexit.Text = "Exit";
            this.buttexit.UseVisualStyleBackColor = false;
            this.buttexit.Click += new System.EventHandler(this.buttexit_Click);
            // 
            // buttlogout
            // 
            this.buttlogout.BackColor = System.Drawing.Color.SkyBlue;
            this.buttlogout.FlatAppearance.BorderSize = 0;
            this.buttlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttlogout.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.buttlogout.Location = new System.Drawing.Point(1163, 618);
            this.buttlogout.Name = "buttlogout";
            this.buttlogout.Size = new System.Drawing.Size(105, 40);
            this.buttlogout.TabIndex = 7;
            this.buttlogout.Text = "Logout";
            this.buttlogout.UseVisualStyleBackColor = false;
            this.buttlogout.Click += new System.EventHandler(this.buttlogout_Click);
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.SkyBlue;
            this.menupanel.Controls.Add(this.labelaccount);
            this.menupanel.Controls.Add(this.labelproduct);
            this.menupanel.Controls.Add(this.labelhome);
            this.menupanel.Location = new System.Drawing.Point(0, 0);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(1121, 61);
            this.menupanel.TabIndex = 8;
            // 
            // labelaccount
            // 
            this.labelaccount.AutoSize = true;
            this.labelaccount.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelaccount.ForeColor = System.Drawing.Color.White;
            this.labelaccount.Location = new System.Drawing.Point(961, 15);
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
            this.labelproduct.Location = new System.Drawing.Point(457, 15);
            this.labelproduct.Name = "labelproduct";
            this.labelproduct.Size = new System.Drawing.Size(124, 33);
            this.labelproduct.TabIndex = 12;
            this.labelproduct.Text = "Products";
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
            // Productspanel
            // 
            this.Productspanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Productspanel.Controls.Add(this.textBoxproduct);
            this.Productspanel.Controls.Add(this.labelProducts);
            this.Productspanel.Location = new System.Drawing.Point(97, 306);
            this.Productspanel.Name = "Productspanel";
            this.Productspanel.Size = new System.Drawing.Size(400, 210);
            this.Productspanel.TabIndex = 9;
            this.Productspanel.Click += new System.EventHandler(this.Productspanel_Click);
            // 
            // textBoxproduct
            // 
            this.textBoxproduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxproduct.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.textBoxproduct.Location = new System.Drawing.Point(301, 139);
            this.textBoxproduct.Name = "textBoxproduct";
            this.textBoxproduct.Size = new System.Drawing.Size(75, 39);
            this.textBoxproduct.TabIndex = 1;
            this.textBoxproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducts.Location = new System.Drawing.Point(11, 10);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(147, 38);
            this.labelProducts.TabIndex = 0;
            this.labelProducts.Text = "Products";
            // 
            // customerspanel
            // 
            this.customerspanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.customerspanel.Controls.Add(this.textBoxcustomers);
            this.customerspanel.Controls.Add(this.labelCustomers);
            this.customerspanel.Location = new System.Drawing.Point(782, 306);
            this.customerspanel.Name = "customerspanel";
            this.customerspanel.Size = new System.Drawing.Size(400, 210);
            this.customerspanel.TabIndex = 10;
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
            // labelCustomers
            // 
            this.labelCustomers.AutoSize = true;
            this.labelCustomers.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.labelCustomers.Location = new System.Drawing.Point(12, 10);
            this.labelCustomers.Name = "labelCustomers";
            this.labelCustomers.Size = new System.Drawing.Size(174, 38);
            this.labelCustomers.TabIndex = 0;
            this.labelCustomers.Text = "Customers";
            // 
            // pimini
            // 
            this.pimini.Image = global::DataBase_system.Properties.Resources.minimize_sign;
            this.pimini.Location = new System.Drawing.Point(1143, 12);
            this.pimini.Name = "pimini";
            this.pimini.Size = new System.Drawing.Size(39, 32);
            this.pimini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pimini.TabIndex = 2;
            this.pimini.TabStop = false;
            this.pimini.Click += new System.EventHandler(this.pimini_Click);
            this.pimini.MouseLeave += new System.EventHandler(this.pimini_MouseLeave);
            this.pimini.MouseHover += new System.EventHandler(this.pimini_MouseHover);
            // 
            // piclose
            // 
            this.piclose.Image = global::DataBase_system.Properties.Resources.cross;
            this.piclose.Location = new System.Drawing.Point(1229, 12);
            this.piclose.Name = "piclose";
            this.piclose.Size = new System.Drawing.Size(39, 32);
            this.piclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclose.TabIndex = 3;
            this.piclose.TabStop = false;
            this.piclose.Click += new System.EventHandler(this.piclose_Click);
            this.piclose.MouseLeave += new System.EventHandler(this.piclose_MouseLeave);
            this.piclose.MouseHover += new System.EventHandler(this.piclose_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Home";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.labelname.Location = new System.Drawing.Point(90, 193);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(102, 38);
            this.labelname.TabIndex = 13;
            this.labelname.Text = "Name";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerspanel);
            this.Controls.Add(this.Productspanel);
            this.Controls.Add(this.menupanel);
            this.Controls.Add(this.buttlogout);
            this.Controls.Add(this.buttexit);
            this.Controls.Add(this.pimini);
            this.Controls.Add(this.piclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiet Attic Films";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menupanel.ResumeLayout(false);
            this.menupanel.PerformLayout();
            this.Productspanel.ResumeLayout(false);
            this.Productspanel.PerformLayout();
            this.customerspanel.ResumeLayout(false);
            this.customerspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pimini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox piclose;
        private System.Windows.Forms.PictureBox pimini;
        private System.Windows.Forms.Button buttexit;
        private System.Windows.Forms.Button buttlogout;
        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.Panel Productspanel;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Panel customerspanel;
        private System.Windows.Forms.Label labelCustomers;
        private System.Windows.Forms.TextBox textBoxproduct;
        private System.Windows.Forms.TextBox textBoxcustomers;
        private System.Windows.Forms.Label labelhome;
        private System.Windows.Forms.Label labelproduct;
        private System.Windows.Forms.Label labelaccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelname;
    }
}