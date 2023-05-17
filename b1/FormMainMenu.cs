using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b1
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
            panelMenu.BackColor = Color.FromArgb(31, 31, 56);
            panelLogo.BackColor = Color.FromArgb(31, 31, 56);
            panelHeader.BackColor = Color.FromArgb(39, 39, 58);
            LoadUI();
        }

        private Button currentButton;

        public void SetupForm(string lvluser, string name)
        {
            if(lvluser == "Admin")
            {
                //btnEntryPelanggan.Enabled = false;
                //btnPesanMakanan.Enabled = false;
            }
            else if(lvluser == "Kasir")
            {
                btnEntryMenu.Enabled = false;
                btnEntryPelanggan.Enabled = false;
                btnPesanMakanan.Enabled = false;
            }

            lblUsername.Text = name;
            lblRole.Text = lvluser;
        }

        private void ActiveButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    LoadUI();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(51, 51, 76);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Bahnschrift", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void LoadUI()
        {
            btnEntryPelanggan.BackColor = Color.FromArgb(31, 31, 56);
            btnEntryPelanggan.ForeColor = Color.Gainsboro;
            btnEntryPelanggan.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btnEntryMenu.BackColor = Color.FromArgb(31, 31, 56);
            btnEntryMenu.ForeColor = Color.Gainsboro;
            btnEntryMenu.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btnLaporan.BackColor = Color.FromArgb(31, 31, 56);
            btnLaporan.ForeColor = Color.Gainsboro;
            btnLaporan.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btnPesanMakanan.BackColor = Color.FromArgb(31, 31, 56);
            btnPesanMakanan.ForeColor = Color.Gainsboro;
            btnPesanMakanan.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            btnTransaksi.BackColor = Color.FromArgb(31, 31, 56);
            btnTransaksi.ForeColor = Color.Gainsboro;
            btnTransaksi.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEntryPelanggan_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Entri Pelanggan | Kasir Restoran";
            ActiveButton(sender);
            loadForm(new FrmEntryPelanggan());
        }

        private void btnEntryMenu_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Entri Menu | Kasir Restoran";
            ActiveButton(sender);
            loadForm(new FrmEntryMenu());
        }

        private void btnPesanMakanan_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Pesan Makanan | Kasir Restoran";
            ActiveButton(sender);
            loadForm(new FrmPesanMakanan());
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Transaksi | Kasir Restoran";
            ActiveButton(sender);
            loadForm(new FrmTransaksi());
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Laporan | Kasir Restoran";
            ActiveButton(sender);
            loadForm(new FrmReport());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Kamu Yakin ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                this.Hide();
                login.Show();
            }
        }
    }
}
