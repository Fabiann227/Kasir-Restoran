namespace b1
{
    partial class FormMainMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.btnPesanMakanan = new System.Windows.Forms.Button();
            this.btnEntryMenu = new System.Windows.Forms.Button();
            this.btnEntryPelanggan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.btnLaporan);
            this.panelMenu.Controls.Add(this.btnTransaksi);
            this.panelMenu.Controls.Add(this.btnPesanMakanan);
            this.panelMenu.Controls.Add(this.btnEntryMenu);
            this.panelMenu.Controls.Add(this.btnEntryPelanggan);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(201, 661);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DimGray;
            this.panelLogo.Controls.Add(this.lblRole);
            this.panelLogo.Controls.Add(this.lblUsername);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.SystemColors.Control;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(201, 54);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // lblRole
            // 
            this.lblRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRole.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(64, 26);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(132, 23);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Admin";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(63, 7);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(132, 23);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Farhan Febrian";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(201, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(783, 30);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(233, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(329, 23);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "HOME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(201, 30);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(783, 631);
            this.mainPanel.TabIndex = 2;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.Image = global::b1.Properties.Resources.logout;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 602);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(201, 59);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "     Logout";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLaporan.FlatAppearance.BorderSize = 0;
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLaporan.Image = global::b1.Properties.Resources.report__3_;
            this.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporan.Location = new System.Drawing.Point(0, 290);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLaporan.Size = new System.Drawing.Size(201, 59);
            this.btnLaporan.TabIndex = 5;
            this.btnLaporan.Text = "     Laporan";
            this.btnLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaksi.FlatAppearance.BorderSize = 0;
            this.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaksi.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaksi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTransaksi.Image = global::b1.Properties.Resources.transaction;
            this.btnTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaksi.Location = new System.Drawing.Point(0, 231);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTransaksi.Size = new System.Drawing.Size(201, 59);
            this.btnTransaksi.TabIndex = 4;
            this.btnTransaksi.Text = "     Transaksi";
            this.btnTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransaksi.UseVisualStyleBackColor = true;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);
            // 
            // btnPesanMakanan
            // 
            this.btnPesanMakanan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesanMakanan.FlatAppearance.BorderSize = 0;
            this.btnPesanMakanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesanMakanan.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesanMakanan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPesanMakanan.Image = global::b1.Properties.Resources.menu;
            this.btnPesanMakanan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesanMakanan.Location = new System.Drawing.Point(0, 172);
            this.btnPesanMakanan.Name = "btnPesanMakanan";
            this.btnPesanMakanan.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPesanMakanan.Size = new System.Drawing.Size(201, 59);
            this.btnPesanMakanan.TabIndex = 3;
            this.btnPesanMakanan.Text = "     Pesan Makanan";
            this.btnPesanMakanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesanMakanan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesanMakanan.UseVisualStyleBackColor = true;
            this.btnPesanMakanan.Click += new System.EventHandler(this.btnPesanMakanan_Click);
            // 
            // btnEntryMenu
            // 
            this.btnEntryMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntryMenu.FlatAppearance.BorderSize = 0;
            this.btnEntryMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntryMenu.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntryMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEntryMenu.Image = global::b1.Properties.Resources.order;
            this.btnEntryMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntryMenu.Location = new System.Drawing.Point(0, 113);
            this.btnEntryMenu.Name = "btnEntryMenu";
            this.btnEntryMenu.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEntryMenu.Size = new System.Drawing.Size(201, 59);
            this.btnEntryMenu.TabIndex = 2;
            this.btnEntryMenu.Text = "     Entry Menu";
            this.btnEntryMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntryMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntryMenu.UseVisualStyleBackColor = true;
            this.btnEntryMenu.Click += new System.EventHandler(this.btnEntryMenu_Click);
            // 
            // btnEntryPelanggan
            // 
            this.btnEntryPelanggan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEntryPelanggan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntryPelanggan.FlatAppearance.BorderSize = 0;
            this.btnEntryPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntryPelanggan.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntryPelanggan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEntryPelanggan.Image = global::b1.Properties.Resources.add_user__2_;
            this.btnEntryPelanggan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntryPelanggan.Location = new System.Drawing.Point(0, 54);
            this.btnEntryPelanggan.Name = "btnEntryPelanggan";
            this.btnEntryPelanggan.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEntryPelanggan.Size = new System.Drawing.Size(201, 59);
            this.btnEntryPelanggan.TabIndex = 1;
            this.btnEntryPelanggan.Text = "     Entry Pelanggan";
            this.btnEntryPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntryPelanggan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntryPelanggan.UseVisualStyleBackColor = false;
            this.btnEntryPelanggan.Click += new System.EventHandler(this.btnEntryPelanggan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::b1.Properties.Resources.user__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-14, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(864, 548);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Button btnPesanMakanan;
        private System.Windows.Forms.Button btnEntryMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEntryPelanggan;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRole;
    }
}

