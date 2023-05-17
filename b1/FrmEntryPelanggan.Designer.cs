namespace b1
{
    partial class FrmEntryPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntryPelanggan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbox_cari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_alamat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_nohp = new System.Windows.Forms.TextBox();
            this.cbox_jk = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_namapelanggan = new System.Windows.Forms.TextBox();
            this.tbox_idpelanggan = new System.Windows.Forms.TextBox();
            this.tbl_pelanggan = new System.Windows.Forms.DataGridView();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pelanggan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.tbox_cari);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 63);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Data Pelanggan";
            // 
            // tbox_cari
            // 
            this.tbox_cari.Location = new System.Drawing.Point(6, 22);
            this.tbox_cari.Name = "tbox_cari";
            this.tbox_cari.Size = new System.Drawing.Size(316, 21);
            this.tbox_cari.TabIndex = 33;
            this.tbox_cari.TextChanged += new System.EventHandler(this.tbox_cari_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "Alamat";
            // 
            // tbox_alamat
            // 
            this.tbox_alamat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbox_alamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_alamat.Location = new System.Drawing.Point(179, 168);
            this.tbox_alamat.Name = "tbox_alamat";
            this.tbox_alamat.Size = new System.Drawing.Size(193, 21);
            this.tbox_alamat.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "No. Telpon";
            // 
            // tbox_nohp
            // 
            this.tbox_nohp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbox_nohp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_nohp.Location = new System.Drawing.Point(179, 137);
            this.tbox_nohp.Name = "tbox_nohp";
            this.tbox_nohp.Size = new System.Drawing.Size(193, 21);
            this.tbox_nohp.TabIndex = 46;
            // 
            // cbox_jk
            // 
            this.cbox_jk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbox_jk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_jk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_jk.FormattingEnabled = true;
            this.cbox_jk.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.cbox_jk.Location = new System.Drawing.Point(179, 107);
            this.cbox_jk.Name = "cbox_jk";
            this.cbox_jk.Size = new System.Drawing.Size(193, 23);
            this.cbox_jk.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nama Pelanggan";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "ID Pelanggan";
            // 
            // tbox_namapelanggan
            // 
            this.tbox_namapelanggan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbox_namapelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_namapelanggan.Location = new System.Drawing.Point(179, 78);
            this.tbox_namapelanggan.Name = "tbox_namapelanggan";
            this.tbox_namapelanggan.Size = new System.Drawing.Size(193, 21);
            this.tbox_namapelanggan.TabIndex = 37;
            // 
            // tbox_idpelanggan
            // 
            this.tbox_idpelanggan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbox_idpelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_idpelanggan.Location = new System.Drawing.Point(179, 52);
            this.tbox_idpelanggan.Name = "tbox_idpelanggan";
            this.tbox_idpelanggan.Size = new System.Drawing.Size(193, 21);
            this.tbox_idpelanggan.TabIndex = 36;
            // 
            // tbl_pelanggan
            // 
            this.tbl_pelanggan.AllowUserToAddRows = false;
            this.tbl_pelanggan.AllowUserToDeleteRows = false;
            this.tbl_pelanggan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbl_pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_pelanggan.Location = new System.Drawing.Point(12, 312);
            this.tbl_pelanggan.Name = "tbl_pelanggan";
            this.tbl_pelanggan.ReadOnly = true;
            this.tbl_pelanggan.Size = new System.Drawing.Size(759, 307);
            this.tbl_pelanggan.TabIndex = 35;
            this.tbl_pelanggan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_pelanggan_CellClick);
            this.tbl_pelanggan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_pelanggan_CellContentClick);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_reset.BackColor = System.Drawing.Color.DimGray;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(630, 110);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(87, 46);
            this.btn_reset.TabIndex = 44;
            this.btn_reset.TabStop = false;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click_1);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_hapus.BackColor = System.Drawing.Color.DimGray;
            this.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_hapus.Image = ((System.Drawing.Image)(resources.GetObject("btn_hapus.Image")));
            this.btn_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hapus.Location = new System.Drawing.Point(630, 55);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(87, 46);
            this.btn_hapus.TabIndex = 43;
            this.btn_hapus.TabStop = false;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_ubah
            // 
            this.btn_ubah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ubah.BackColor = System.Drawing.Color.DimGray;
            this.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ubah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ubah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ubah.Image = ((System.Drawing.Image)(resources.GetObject("btn_ubah.Image")));
            this.btn_ubah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ubah.Location = new System.Drawing.Point(523, 110);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(87, 46);
            this.btn_ubah.TabIndex = 42;
            this.btn_ubah.TabStop = false;
            this.btn_ubah.Text = "Ubah";
            this.btn_ubah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ubah.UseVisualStyleBackColor = false;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_simpan.BackColor = System.Drawing.Color.DimGray;
            this.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_simpan.Image = ((System.Drawing.Image)(resources.GetObject("btn_simpan.Image")));
            this.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_simpan.Location = new System.Drawing.Point(523, 55);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(87, 46);
            this.btn_simpan.TabIndex = 41;
            this.btn_simpan.TabStop = false;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // FrmEntryPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 631);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbox_alamat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_nohp);
            this.Controls.Add(this.cbox_jk);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_ubah);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_namapelanggan);
            this.Controls.Add(this.tbox_idpelanggan);
            this.Controls.Add(this.tbl_pelanggan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEntryPelanggan";
            this.Text = "FrmEntryPelanggan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_pelanggan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbox_cari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_alamat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_nohp;
        private System.Windows.Forms.ComboBox cbox_jk;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_namapelanggan;
        private System.Windows.Forms.TextBox tbox_idpelanggan;
        private System.Windows.Forms.DataGridView tbl_pelanggan;
    }
}