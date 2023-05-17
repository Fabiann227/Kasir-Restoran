namespace b1
{
    partial class FrmEntryMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntryMenu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbox_cari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_hargamenu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_namamenu = new System.Windows.Forms.TextBox();
            this.tbox_idmenu = new System.Windows.Forms.TextBox();
            this.tbl_menu = new System.Windows.Forms.DataGridView();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbox_cari);
            this.groupBox1.Location = new System.Drawing.Point(22, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 53);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Data Pelanggan";
            // 
            // tbox_cari
            // 
            this.tbox_cari.Location = new System.Drawing.Point(6, 22);
            this.tbox_cari.Name = "tbox_cari";
            this.tbox_cari.Size = new System.Drawing.Size(318, 20);
            this.tbox_cari.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Harga Menu";
            // 
            // tbox_hargamenu
            // 
            this.tbox_hargamenu.Location = new System.Drawing.Point(153, 115);
            this.tbox_hargamenu.Name = "tbox_hargamenu";
            this.tbox_hargamenu.Size = new System.Drawing.Size(199, 20);
            this.tbox_hargamenu.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nama Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "ID Menu";
            // 
            // tbox_namamenu
            // 
            this.tbox_namamenu.Location = new System.Drawing.Point(153, 86);
            this.tbox_namamenu.Name = "tbox_namamenu";
            this.tbox_namamenu.Size = new System.Drawing.Size(199, 20);
            this.tbox_namamenu.TabIndex = 38;
            // 
            // tbox_idmenu
            // 
            this.tbox_idmenu.Location = new System.Drawing.Point(153, 57);
            this.tbox_idmenu.Name = "tbox_idmenu";
            this.tbox_idmenu.Size = new System.Drawing.Size(199, 20);
            this.tbox_idmenu.TabIndex = 37;
            // 
            // tbl_menu
            // 
            this.tbl_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_menu.Location = new System.Drawing.Point(12, 264);
            this.tbl_menu.Name = "tbl_menu";
            this.tbl_menu.Size = new System.Drawing.Size(757, 355);
            this.tbl_menu.TabIndex = 36;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.DimGray;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(482, 115);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(101, 52);
            this.btn_reset.TabIndex = 46;
            this.btn_reset.TabStop = false;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.DimGray;
            this.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hapus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_hapus.Image = ((System.Drawing.Image)(resources.GetObject("btn_hapus.Image")));
            this.btn_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hapus.Location = new System.Drawing.Point(377, 115);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(99, 52);
            this.btn_hapus.TabIndex = 45;
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
            this.btn_ubah.Location = new System.Drawing.Point(482, 57);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(101, 52);
            this.btn_ubah.TabIndex = 44;
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
            this.btn_simpan.Location = new System.Drawing.Point(375, 57);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(101, 52);
            this.btn_simpan.TabIndex = 43;
            this.btn_simpan.TabStop = false;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_simpan.UseVisualStyleBackColor = false;
            // 
            // FrmEntryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 631);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_ubah);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbox_hargamenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_namamenu);
            this.Controls.Add(this.tbox_idmenu);
            this.Controls.Add(this.tbl_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEntryMenu";
            this.Text = "FrmEntryMenu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbox_cari;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_hargamenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_namamenu;
        private System.Windows.Forms.TextBox tbox_idmenu;
        private System.Windows.Forms.DataGridView tbl_menu;
    }
}