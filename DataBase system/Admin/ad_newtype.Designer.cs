namespace DataBase_system.Admin
{
    partial class ad_newtype
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ad_newtype));
            this.buttlonback = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxstid = new System.Windows.Forms.ComboBox();
            this.textBoxstn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttondest = new System.Windows.Forms.Button();
            this.buttonedist = new System.Windows.Forms.Button();
            this.buttonadddst = new System.Windows.Forms.Button();
            this.buttonclandre = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttlonback
            // 
            this.buttlonback.BackColor = System.Drawing.Color.SkyBlue;
            this.buttlonback.FlatAppearance.BorderSize = 0;
            this.buttlonback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttlonback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttlonback.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.buttlonback.Location = new System.Drawing.Point(983, 448);
            this.buttlonback.Name = "buttlonback";
            this.buttlonback.Size = new System.Drawing.Size(105, 40);
            this.buttlonback.TabIndex = 43;
            this.buttlonback.Text = "Back";
            this.buttlonback.UseVisualStyleBackColor = false;
            this.buttlonback.Click += new System.EventHandler(this.buttlonback_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(466, 70);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(622, 323);
            this.dataGridView1.TabIndex = 132;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBoxstid
            // 
            this.comboBoxstid.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxstid.FormattingEnabled = true;
            this.comboBoxstid.Location = new System.Drawing.Point(162, 168);
            this.comboBoxstid.Name = "comboBoxstid";
            this.comboBoxstid.Size = new System.Drawing.Size(298, 31);
            this.comboBoxstid.TabIndex = 0;
            this.comboBoxstid.SelectedIndexChanged += new System.EventHandler(this.comboBoxstid_SelectedIndexChanged);
            // 
            // textBoxstn
            // 
            this.textBoxstn.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxstn.Location = new System.Drawing.Point(162, 235);
            this.textBoxstn.Name = "textBoxstn";
            this.textBoxstn.Size = new System.Drawing.Size(298, 30);
            this.textBoxstn.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(27, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 23);
            this.label9.TabIndex = 146;
            this.label9.Text = "Type Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(27, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 23);
            this.label11.TabIndex = 144;
            this.label11.Text = "Staff Type ID";
            // 
            // buttondest
            // 
            this.buttondest.BackColor = System.Drawing.Color.SkyBlue;
            this.buttondest.FlatAppearance.BorderSize = 0;
            this.buttondest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttondest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondest.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondest.Location = new System.Drawing.Point(325, 318);
            this.buttondest.Name = "buttondest";
            this.buttondest.Size = new System.Drawing.Size(135, 30);
            this.buttondest.TabIndex = 4;
            this.buttondest.Text = "Delete Type";
            this.buttondest.UseVisualStyleBackColor = false;
            this.buttondest.Click += new System.EventHandler(this.buttondest_Click);
            // 
            // buttonedist
            // 
            this.buttonedist.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonedist.FlatAppearance.BorderSize = 0;
            this.buttonedist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonedist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonedist.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonedist.Location = new System.Drawing.Point(178, 318);
            this.buttonedist.Name = "buttonedist";
            this.buttonedist.Size = new System.Drawing.Size(135, 30);
            this.buttonedist.TabIndex = 3;
            this.buttonedist.Text = "Edit Details";
            this.buttonedist.UseVisualStyleBackColor = false;
            this.buttonedist.Click += new System.EventHandler(this.buttonedist_Click);
            // 
            // buttonadddst
            // 
            this.buttonadddst.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonadddst.FlatAppearance.BorderSize = 0;
            this.buttonadddst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonadddst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonadddst.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadddst.Location = new System.Drawing.Point(31, 318);
            this.buttonadddst.Name = "buttonadddst";
            this.buttonadddst.Size = new System.Drawing.Size(135, 30);
            this.buttonadddst.TabIndex = 2;
            this.buttonadddst.Text = "Add Type";
            this.buttonadddst.UseVisualStyleBackColor = false;
            this.buttonadddst.Click += new System.EventHandler(this.buttonadddst_Click);
            // 
            // buttonclandre
            // 
            this.buttonclandre.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonclandre.FlatAppearance.BorderSize = 0;
            this.buttonclandre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclandre.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclandre.Location = new System.Drawing.Point(997, 36);
            this.buttonclandre.Name = "buttonclandre";
            this.buttonclandre.Size = new System.Drawing.Size(91, 28);
            this.buttonclandre.TabIndex = 158;
            this.buttonclandre.Text = "Refresh";
            this.buttonclandre.UseVisualStyleBackColor = false;
            this.buttonclandre.Click += new System.EventHandler(this.buttonclandre_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataBase_system.Properties.Resources.back_button;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 33);
            this.label3.TabIndex = 159;
            this.label3.Text = "Staff Type";
            // 
            // ad_newtype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1100, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonclandre);
            this.Controls.Add(this.buttondest);
            this.Controls.Add(this.buttonedist);
            this.Controls.Add(this.buttonadddst);
            this.Controls.Add(this.comboBoxstid);
            this.Controls.Add(this.textBoxstn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttlonback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ad_newtype";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiet Attic Films";
            this.Load += new System.EventHandler(this.ad_newtype_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttlonback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxstid;
        private System.Windows.Forms.TextBox textBoxstn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttondest;
        private System.Windows.Forms.Button buttonedist;
        private System.Windows.Forms.Button buttonadddst;
        private System.Windows.Forms.Button buttonclandre;
        private System.Windows.Forms.Label label3;
    }
}