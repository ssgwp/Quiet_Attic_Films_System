namespace DataBase_system
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.menupanel = new System.Windows.Forms.Panel();
            this.labelaccount = new System.Windows.Forms.Label();
            this.labelproduct = new System.Windows.Forms.Label();
            this.labelhome = new System.Windows.Forms.Label();
            this.buttlogout = new System.Windows.Forms.Button();
            this.buttexit = new System.Windows.Forms.Button();
            this.pimini = new System.Windows.Forms.PictureBox();
            this.piclose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxcpass = new System.Windows.Forms.TextBox();
            this.textBoxnpass = new System.Windows.Forms.TextBox();
            this.textBoxrnpass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxcp = new System.Windows.Forms.CheckBox();
            this.checkBoxnp = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menupanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pimini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclose)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.menupanel.TabIndex = 15;
            // 
            // labelaccount
            // 
            this.labelaccount.AutoSize = true;
            this.labelaccount.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold);
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
            this.labelhome.ForeColor = System.Drawing.Color.White;
            this.labelhome.Location = new System.Drawing.Point(30, 15);
            this.labelhome.Name = "labelhome";
            this.labelhome.Size = new System.Drawing.Size(87, 33);
            this.labelhome.TabIndex = 11;
            this.labelhome.Text = "Home";
            this.labelhome.Click += new System.EventHandler(this.labelhome_Click);
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
            this.buttlogout.TabIndex = 14;
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
            this.buttexit.Location = new System.Drawing.Point(1163, 668);
            this.buttexit.Name = "buttexit";
            this.buttexit.Size = new System.Drawing.Size(105, 40);
            this.buttexit.TabIndex = 13;
            this.buttexit.Text = "Exit";
            this.buttexit.UseVisualStyleBackColor = false;
            this.buttexit.Click += new System.EventHandler(this.buttexit_Click);
            // 
            // pimini
            // 
            this.pimini.Image = global::DataBase_system.Properties.Resources.minimize_sign;
            this.pimini.Location = new System.Drawing.Point(1143, 12);
            this.pimini.Name = "pimini";
            this.pimini.Size = new System.Drawing.Size(39, 32);
            this.pimini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pimini.TabIndex = 11;
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
            this.piclose.TabIndex = 12;
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
            this.label1.Size = new System.Drawing.Size(138, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Current Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(23, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(23, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Re-Type New Password";
            // 
            // textBoxcpass
            // 
            this.textBoxcpass.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcpass.Location = new System.Drawing.Point(27, 50);
            this.textBoxcpass.Name = "textBoxcpass";
            this.textBoxcpass.Size = new System.Drawing.Size(371, 33);
            this.textBoxcpass.TabIndex = 0;
            this.textBoxcpass.TextChanged += new System.EventHandler(this.textBoxcpass_TextChanged);
            // 
            // textBoxnpass
            // 
            this.textBoxnpass.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnpass.Location = new System.Drawing.Point(27, 171);
            this.textBoxnpass.Name = "textBoxnpass";
            this.textBoxnpass.Size = new System.Drawing.Size(371, 33);
            this.textBoxnpass.TabIndex = 1;
            this.textBoxnpass.TextChanged += new System.EventHandler(this.textBoxnpass_TextChanged);
            // 
            // textBoxrnpass
            // 
            this.textBoxrnpass.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxrnpass.Location = new System.Drawing.Point(27, 249);
            this.textBoxrnpass.Name = "textBoxrnpass";
            this.textBoxrnpass.Size = new System.Drawing.Size(371, 33);
            this.textBoxrnpass.TabIndex = 2;
            this.textBoxrnpass.TextChanged += new System.EventHandler(this.textBoxrnpass_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(364, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(301, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 29);
            this.button2.TabIndex = 26;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxcp
            // 
            this.checkBoxcp.AutoSize = true;
            this.checkBoxcp.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxcp.Location = new System.Drawing.Point(27, 89);
            this.checkBoxcp.Name = "checkBoxcp";
            this.checkBoxcp.Size = new System.Drawing.Size(119, 19);
            this.checkBoxcp.TabIndex = 27;
            this.checkBoxcp.Text = "Show Password";
            this.checkBoxcp.UseVisualStyleBackColor = true;
            this.checkBoxcp.CheckedChanged += new System.EventHandler(this.checkBoxcp_CheckedChanged);
            // 
            // checkBoxnp
            // 
            this.checkBoxnp.AutoSize = true;
            this.checkBoxnp.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxnp.Location = new System.Drawing.Point(27, 288);
            this.checkBoxnp.Name = "checkBoxnp";
            this.checkBoxnp.Size = new System.Drawing.Size(119, 19);
            this.checkBoxnp.TabIndex = 28;
            this.checkBoxnp.Text = "Show Password";
            this.checkBoxnp.UseVisualStyleBackColor = true;
            this.checkBoxnp.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxnp);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBoxcpass);
            this.groupBox1.Controls.Add(this.textBoxrnpass);
            this.groupBox1.Controls.Add(this.textBoxnpass);
            this.groupBox1.Controls.Add(this.checkBoxcp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(55, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 432);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change password";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menupanel);
            this.Controls.Add(this.buttlogout);
            this.Controls.Add(this.buttexit);
            this.Controls.Add(this.pimini);
            this.Controls.Add(this.piclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiet Attic Films";
            this.Load += new System.EventHandler(this.Account_Load);
            this.menupanel.ResumeLayout(false);
            this.menupanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pimini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.PictureBox pimini;
        private System.Windows.Forms.PictureBox piclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxcpass;
        private System.Windows.Forms.TextBox textBoxnpass;
        private System.Windows.Forms.TextBox textBoxrnpass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxcp;
        private System.Windows.Forms.CheckBox checkBoxnp;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}