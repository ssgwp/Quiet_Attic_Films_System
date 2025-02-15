namespace DataBase_system
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pimini = new System.Windows.Forms.PictureBox();
            this.piclose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textuser = new System.Windows.Forms.TextBox();
            this.textpas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttlog = new System.Windows.Forms.Button();
            this.buttexit = new System.Windows.Forms.Button();
            this.buttclrear = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pimini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pimini
            // 
            this.pimini.Image = global::DataBase_system.Properties.Resources.minimize_sign;
            this.pimini.Location = new System.Drawing.Point(455, 13);
            this.pimini.Name = "pimini";
            this.pimini.Size = new System.Drawing.Size(39, 32);
            this.pimini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pimini.TabIndex = 1;
            this.pimini.TabStop = false;
            this.pimini.Click += new System.EventHandler(this.pimini_Click);
            this.pimini.MouseLeave += new System.EventHandler(this.pimini_MouseLeave);
            this.pimini.MouseHover += new System.EventHandler(this.pimini_MouseHover);
            // 
            // piclose
            // 
            this.piclose.Image = global::DataBase_system.Properties.Resources.cross;
            this.piclose.Location = new System.Drawing.Point(541, 13);
            this.piclose.Name = "piclose";
            this.piclose.Size = new System.Drawing.Size(39, 32);
            this.piclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclose.TabIndex = 1;
            this.piclose.TabStop = false;
            this.piclose.Click += new System.EventHandler(this.piclose_Click);
            this.piclose.MouseLeave += new System.EventHandler(this.piclose_MouseLeave);
            this.piclose.MouseHover += new System.EventHandler(this.piclose_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataBase_system.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(5, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quiet Attic Films";
            // 
            // textuser
            // 
            this.textuser.Font = new System.Drawing.Font("Roboto", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textuser.Location = new System.Drawing.Point(63, 317);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(472, 43);
            this.textuser.TabIndex = 3;
            // 
            // textpas
            // 
            this.textpas.Font = new System.Drawing.Font("Roboto", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpas.Location = new System.Drawing.Point(63, 437);
            this.textpas.Name = "textpas";
            this.textpas.Size = new System.Drawing.Size(472, 43);
            this.textpas.TabIndex = 3;
            this.textpas.TextChanged += new System.EventHandler(this.textpas_TextChanged);
            this.textpas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textpas_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // buttlog
            // 
            this.buttlog.BackColor = System.Drawing.Color.SkyBlue;
            this.buttlog.FlatAppearance.BorderSize = 0;
            this.buttlog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.buttlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttlog.Font = new System.Drawing.Font("Roboto", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttlog.Location = new System.Drawing.Point(63, 594);
            this.buttlog.Name = "buttlog";
            this.buttlog.Size = new System.Drawing.Size(472, 60);
            this.buttlog.TabIndex = 5;
            this.buttlog.Text = "Login";
            this.buttlog.UseVisualStyleBackColor = false;
            this.buttlog.Click += new System.EventHandler(this.buttlog_Click);
            // 
            // buttexit
            // 
            this.buttexit.BackColor = System.Drawing.Color.SkyBlue;
            this.buttexit.FlatAppearance.BorderSize = 0;
            this.buttexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttexit.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttexit.Location = new System.Drawing.Point(25, 740);
            this.buttexit.Name = "buttexit";
            this.buttexit.Size = new System.Drawing.Size(105, 40);
            this.buttexit.TabIndex = 5;
            this.buttexit.Text = "Exit";
            this.buttexit.UseVisualStyleBackColor = false;
            this.buttexit.Click += new System.EventHandler(this.buttexit_Click);
            // 
            // buttclrear
            // 
            this.buttclrear.BackColor = System.Drawing.Color.SkyBlue;
            this.buttclrear.FlatAppearance.BorderSize = 0;
            this.buttclrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.buttclrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttclrear.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttclrear.Location = new System.Drawing.Point(450, 486);
            this.buttclrear.Name = "buttclrear";
            this.buttclrear.Size = new System.Drawing.Size(85, 31);
            this.buttclrear.TabIndex = 5;
            this.buttclrear.Text = "Clear";
            this.buttclrear.UseVisualStyleBackColor = false;
            this.buttclrear.Click += new System.EventHandler(this.buttclrear_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(69, 487);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(472, 774);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sineth Sandeepa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 755);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Developed by";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 800);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttclrear);
            this.Controls.Add(this.buttexit);
            this.Controls.Add(this.buttlog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textpas);
            this.Controls.Add(this.pimini);
            this.Controls.Add(this.piclose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiet Attic Films";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pimini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox piclose;
        private System.Windows.Forms.PictureBox pimini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.TextBox textpas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttlog;
        private System.Windows.Forms.Button buttexit;
        private System.Windows.Forms.Button buttclrear;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

