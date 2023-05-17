using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace b1
{
    public partial class FrmEntryPelanggan : Form
    {
        public FrmEntryPelanggan()
        {
            InitializeComponent();
            btn_hapus.BackColor = Color.FromArgb(51, 51, 76);
            btn_reset.BackColor = Color.FromArgb(51, 51, 76);
            btn_simpan.BackColor = Color.FromArgb(51, 51, 76);
            btn_ubah.BackColor = Color.FromArgb(51, 51, 76);
            showData();
        }


        void clearData()
        {
            tbox_idpelanggan.Enabled = true;
            tbox_idpelanggan.Text = "";
            tbox_namapelanggan.Text = "";
            cbox_jk.SelectedIndex = -1;
            tbox_nohp.Text = "";
            tbox_alamat.Text = "";
        }
        void showData()
        {
            Koneksi con = new Koneksi();
            SqlConnection conn = con.GetConn();

            try
            {
                conn.Open();
                string cmdSelect = "SELECT * FROM tb_pelanggan";
                SqlCommand cmd = new SqlCommand(cmdSelect, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tb_pelanggan");

                tbl_pelanggan.DataSource = ds;
                tbl_pelanggan.DataMember = "tb_pelanggan";
                tbl_pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception g)
            {
                MessageBox.Show(g.ToString(), "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();
            }

        }

        void cariData()
        {
            Koneksi con = new Koneksi();
            SqlConnection conn = con.GetConn();

            try
            {
                conn.Open();
                string cmdSelect = "SELECT * FROM tb_pelanggan WHERE id_pelanggan like '%" + tbox_cari.Text + "%' OR nama_pelanggan like '%" + tbox_cari.Text + "%' OR jenis_kelamin like '%" + tbox_cari.Text + "%' OR no_telpon like '%" + tbox_cari.Text + "%' OR alamat like '%" + tbox_cari.Text + "%' ";
                SqlCommand cmd = new SqlCommand(cmdSelect, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tb_pelanggan");

                tbl_pelanggan.DataSource = ds;
                tbl_pelanggan.DataMember = "tb_pelanggan";
                tbl_pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception g)
            {
                MessageBox.Show(g.ToString(), "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();
            }

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (tbox_idpelanggan.Text.Trim() == "" || tbox_namapelanggan.Text.Trim() == "" || cbox_jk.Text.Trim() == "" || tbox_nohp.Text.Trim() == "" || tbox_alamat.Text.Trim() == "")
            {
                MessageBox.Show("Isi Semua Data !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Koneksi Con = new Koneksi();
                SqlConnection Conn = Con.GetConn();

                Conn.Open();
                string kueri = "INSERT INTO tb_pelanggan VALUES ('" + tbox_idpelanggan.Text + "','" + tbox_namapelanggan.Text + "','" + cbox_jk.Text + "', '" + tbox_nohp.Text + "', '" + tbox_alamat.Text + "')";
                SqlCommand cmd = new SqlCommand(kueri, Conn);

                cmd.ExecuteNonQuery();

                Conn.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showData();
                clearData();
                tbox_idpelanggan.Focus();
            }
            
        }


        private void btn_reset_Click_1(object sender, EventArgs e)
        {
            clearData();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            Koneksi Con = new Koneksi();
            SqlConnection Conn = Con.GetConn();


            if (tbox_idpelanggan.Text.Trim() == "" || tbox_namapelanggan.Text.Trim() == "" || cbox_jk.Text.Trim() == "" || tbox_nohp.Text.Trim() == "" || tbox_alamat.Text.Trim() == "")
            {
                MessageBox.Show("Isi Semua Data !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                DialogResult result = MessageBox.Show("Apa kamu yakin ingin menghapus Data Ini ?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Conn.Open();
                        string cmdSelect = "DELETE FROM tb_pelanggan WHERE id_pelanggan='" + tbox_idpelanggan.Text + "'";
                        SqlCommand cmd = new SqlCommand(cmdSelect, Conn);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                        clearData();
                        tbox_idpelanggan.Focus();

                    }
                    catch (Exception g)
                    {
                        MessageBox.Show(g.ToString(), "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        Conn.Close();
                    }
                }




            }
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            Koneksi Con = new Koneksi();
            SqlConnection Conn = Con.GetConn();


            if (tbox_idpelanggan.Text.Trim() == "" || tbox_namapelanggan.Text.Trim() == "" || cbox_jk.Text.Trim() == "" || tbox_nohp.Text.Trim() == "" || tbox_alamat.Text.Trim() == "")
            {
                MessageBox.Show("Isi Semua Data !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    Conn.Open();
                    string cmdUpdate = "UPDATE tb_pelanggan SET id_pelanggan='" + tbox_idpelanggan.Text + "', nama_pelanggan='" + tbox_namapelanggan.Text + "', jenis_kelamin='" + cbox_jk.SelectedItem.ToString() + "',  no_telpon='" + tbox_nohp.Text + "',  alamat='" + tbox_alamat.Text + "' WHERE id_pelanggan='" + tbox_idpelanggan.Text + "'";
                    SqlCommand cmd = new SqlCommand(cmdUpdate, Conn);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Diubah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                    clearData();
                    tbox_idpelanggan.Focus();

                }
                catch (Exception g)
                {
                    MessageBox.Show(g.ToString(), "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    Conn.Close();
                }
            }
        }

        private void tbl_pelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tbl_pelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbox_idpelanggan.Enabled = false;
            DataGridViewRow row = this.tbl_pelanggan.Rows[e.RowIndex];
            tbox_idpelanggan.Text = row.Cells["id_pelanggan"].Value.ToString();
            tbox_namapelanggan.Text = row.Cells["nama_pelanggan"].Value.ToString();
            cbox_jk.Text = row.Cells["jenis_kelamin"].Value.ToString();
            tbox_nohp.Text = row.Cells["no_telpon"].Value.ToString();
            tbox_alamat.Text = row.Cells["alamat"].Value.ToString();
        }

        private void tbox_cari_TextChanged(object sender, EventArgs e)
        {
            cariData();
        }
    }
}
