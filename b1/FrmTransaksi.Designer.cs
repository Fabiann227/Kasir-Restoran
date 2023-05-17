namespace b1
{
    partial class FrmTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransaksi));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_hitung = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbox_kembalian = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_bayar = new System.Windows.Forms.TextBox();
            this.tbox_namapelanggan = new System.Windows.Forms.TextBox();
            this.tbl_transaksi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbox_cari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_jh = new System.Windows.Forms.TextBox();
            this.cbox_idpesanan = new System.Windows.Forms.ComboBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_idtransaksi = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_transaksi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(348, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 76);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Kembalian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rp0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(346, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 76);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Pembayaran";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 39);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rp0";
            // 
            // btn_hitung
            // 
            this.btn_hitung.BackColor = System.Drawing.Color.DimGray;
            this.btn_hitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hitung.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_hitung.Image = ((System.Drawing.Image)(resources.GetObject("btn_hitung.Image")));
            this.btn_hitung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hitung.Location = new System.Drawing.Point(151, 226);
            this.btn_hitung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_hitung.Name = "btn_hitung";
            this.btn_hitung.Size = new System.Drawing.Size(175, 49);
            this.btn_hitung.TabIndex = 77;
            this.btn_hitung.TabStop = false;
            this.btn_hitung.Text = "Hitung Kembalian";
            this.btn_hitung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hitung.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Kembalian";
            // 
            // tbox_kembalian
            // 
            this.tbox_kembalian.Location = new System.Drawing.Point(151, 196);
            this.tbox_kembalian.Name = "tbox_kembalian";
            this.tbox_kembalian.Size = new System.Drawing.Size(175, 20);
            this.tbox_kembalian.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Bayar";
            // 
            // tbox_bayar
            // 
            this.tbox_bayar.Location = new System.Drawing.Point(151, 167);
            this.tbox_bayar.Name = "tbox_bayar";
            this.tbox_bayar.Size = new System.Drawing.Size(175, 20);
            this.tbox_bayar.TabIndex = 73;
            // 
            // tbox_namapelanggan
            // 
            this.tbox_namapelanggan.Location = new System.Drawing.Point(151, 109);
            this.tbox_namapelanggan.Name = "tbox_namapelanggan";
            this.tbox_namapelanggan.Size = new System.Drawing.Size(175, 20);
            this.tbox_namapelanggan.TabIndex = 71;
            // 
            // tbl_transaksi
            // 
            this.tbl_transaksi.AllowUserToAddRows = false;
            this.tbl_transaksi.AllowUserToDeleteRows = false;
            this.tbl_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_transaksi.Location = new System.Drawing.Point(14, 367);
            this.tbl_transaksi.Name = "tbl_transaksi";
            this.tbl_transaksi.ReadOnly = true;
            this.tbl_transaksi.Size = new System.Drawing.Size(757, 252);
            this.tbl_transaksi.TabIndex = 69;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbox_cari);
            this.groupBox1.Location = new System.Drawing.Point(20, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 53);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Data Transaksi";
            // 
            // tbox_cari
            // 
            this.tbox_cari.Location = new System.Drawing.Point(6, 22);
            this.tbox_cari.Name = "tbox_cari";
            this.tbox_cari.Size = new System.Drawing.Size(294, 20);
            this.tbox_cari.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Jumlah Harga Pesan";
            // 
            // tbox_jh
            // 
            this.tbox_jh.Location = new System.Drawing.Point(151, 138);
            this.tbox_jh.Name = "tbox_jh";
            this.tbox_jh.Size = new System.Drawing.Size(175, 20);
            this.tbox_jh.TabIndex = 66;
            // 
            // cbox_idpesanan
            // 
            this.cbox_idpesanan.FormattingEnabled = true;
            this.cbox_idpesanan.Location = new System.Drawing.Point(151, 79);
            this.cbox_idpesanan.Name = "cbox_idpesanan";
            this.cbox_idpesanan.Size = new System.Drawing.Size(175, 21);
            this.cbox_idpesanan.TabIndex = 65;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.DimGray;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(453, 108);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(99, 53);
            this.btn_reset.TabIndex = 64;
            this.btn_reset.TabStop = false;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reset.UseVisualStyleBackColor = false;
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.DimGray;
            this.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hapus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_hapus.Image = ((System.Drawing.Image)(resources.GetObject("btn_hapus.Image")));
            this.btn_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hapus.Location = new System.Drawing.Point(453, 49);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(99, 49);
            this.btn_hapus.TabIndex = 63;
            this.btn_hapus.TabStop = false;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hapus.UseVisualStyleBackColor = false;
            // 
            // btn_ubah
            // 
            this.btn_ubah.BackColor = System.Drawing.Color.DimGray;
            this.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ubah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ubah.Image = ((System.Drawing.Image)(resources.GetObject("btn_ubah.Image")));
            this.btn_ubah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ubah.Location = new System.Drawing.Point(346, 105);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(101, 53);
            this.btn_ubah.TabIndex = 62;
            this.btn_ubah.TabStop = false;
            this.btn_ubah.Text = "Ubah";
            this.btn_ubah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ubah.UseVisualStyleBackColor = false;
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.Color.DimGray;
            this.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simpan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_simpan.Image = ((System.Drawing.Image)(resources.GetObject("btn_simpan.Image")));
            this.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_simpan.Location = new System.Drawing.Point(346, 50);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(101, 49);
            this.btn_simpan.TabIndex = 61;
            this.btn_simpan.TabStop = false;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_simpan.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Nama Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "ID Pesanan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "ID Transaksi";
            // 
            // tbox_idtransaksi
            // 
            this.tbox_idtransaksi.Location = new System.Drawing.Point(151, 50);
            this.tbox_idtransaksi.Name = "tbox_idtransaksi";
            this.tbox_idtransaksi.Size = new System.Drawing.Size(175, 20);
            this.tbox_idtransaksi.TabIndex = 57;
            // 
            // FrmTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 631);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_hitung);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbox_kembalian);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbox_bayar);
            this.Controls.Add(this.tbox_namapelanggan);
            this.Controls.Add(this.tbl_transaksi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbox_jh);
            this.Controls.Add(this.cbox_idpesanan);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_ubah);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_idtransaksi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTransaksi";
            this.Text = "FrmTransaksi";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_transaksi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_hitung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbox_kembalian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_bayar;
        private System.Windows.Forms.TextBox tbox_namapelanggan;
        private System.Windows.Forms.DataGridView tbl_transaksi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbox_cari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_jh;
        private System.Windows.Forms.ComboBox cbox_idpesanan;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_idtransaksi;
    }
}