using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class FormPT : Form
    {
        public FormPT()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bersih();     // Ini otomatis menyembunyikan button4 dan memunculkan button1
            tampildata(); // Sekalian memuat isi DataGridView saat aplikasi pertama dibuka

            Button btnCetak = new Button();
            btnCetak.Text = "🖨️ Cetak Data";
            btnCetak.Size = new Size(114, 31);
            btnCetak.Location = new Point(button2.Right + 10, button2.Top);
            btnCetak.Click += (s, ev) => LaporanHelper.CetakKeBrowser(dataGridView1, "DATA PERUSAHAAN (PT) TEMPAT PKL");
            this.Controls.Add(btnCetak);
            btnCetak.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTnm.Text))
            {
                MessageBox.Show("Nama perusahaan tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO perusahaan (Nama, Alamat, Telepon, Nama_Pembimbing) VALUES (@Nama, @Alamat, @Telepon, @Pembimbing)", Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Nama", TXTnm.Text.Trim());
                    cmd.Parameters.AddWithValue("@Alamat", TXTalamat.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telepon", TXTtlp.Text.Trim());
                    cmd.Parameters.AddWithValue("@Pembimbing", TXTpembimbing.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Data perusahaan berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersih();
                tampildata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data perusahaan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
            }
        }

        private void bersih()
        {
            TXTtlp.Text = "";
            TXTnm.Text = "";
            TXTalamat.Text = "";
            TXTpembimbing.Text = "";
            label7.Text = ""; // Jangan lupa bersihkan juga label ID-nya

            // Mengatur tombol
            button1.Visible = true;  // Tombol Simpan dimunculkan
            button4.Visible = false; // Tombol Update disembunyikan
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT Id_Pt, Nama, Alamat, Telepon, Nama_Pembimbing FROM perusahaan ORDER BY Id_Pt ASC", Classdb.koneksi))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["Id_Pt"].ToString();
                        string nama = reader["Nama"].ToString();
                        string alamat = reader["Alamat"].ToString();
                        string telepon = reader["Telepon"].ToString();
                        string pmb = reader["Nama_Pembimbing"].ToString();
                        dataGridView1.Rows.Add(id, nama, alamat, telepon, pmb);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data perusahaan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(label7.Text))
            {
                MessageBox.Show("Pilih data perusahaan yang ingin diubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                using (MySqlCommand cmd = new MySqlCommand("UPDATE perusahaan SET Nama = @Nama, Alamat = @Alamat, Telepon = @Telepon, Nama_Pembimbing = @Pembimbing WHERE Id_Pt = @IdPt", Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Nama", TXTnm.Text.Trim());
                    cmd.Parameters.AddWithValue("@Alamat", TXTalamat.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telepon", TXTtlp.Text.Trim());
                    cmd.Parameters.AddWithValue("@Pembimbing", TXTpembimbing.Text.Trim());
                    cmd.Parameters.AddWithValue("@IdPt", label7.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Data perusahaan berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersih();
                tampildata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
            }
        }

        public void caridata(string lui)
        {
            dataGridView1.Rows.Clear();
            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT Id_Pt, Nama, Alamat, Telepon, Nama_Pembimbing FROM perusahaan WHERE Nama LIKE @Cari ORDER BY Id_Pt ASC", Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Cari", "%" + lui + "%");
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string id = reader["Id_Pt"].ToString();
                            string nama = reader["Nama"].ToString();
                            string alamat = reader["Alamat"].ToString();
                            string telepon = reader["Telepon"].ToString();
                            string pmb = reader["Nama_Pembimbing"].ToString();
                            dataGridView1.Rows.Add(id, nama, alamat, telepon, pmb);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencari data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            caridata(textBox2.Text);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indeksbaris = e.RowIndex;
            int indekskolom = e.ColumnIndex;
            if (indeksbaris < 0) return;
            string idp = dataGridView1.Rows[indeksbaris].Cells[0].Value?.ToString();

            if (indekskolom == 6)
            {
                DialogResult setuju1 = MessageBox.Show("Apakah yakin ingin menghapus data perusahaan ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (setuju1 == DialogResult.Yes)
                {
                    try
                    {
                        if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM perusahaan WHERE Id_Pt = @IdPt", Classdb.koneksi))
                        {
                            cmd.Parameters.AddWithValue("@IdPt", idp);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Data perusahaan berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersih();
                        tampildata();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menghapus data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
                    }
                }
            }

            if (indekskolom == 5)
            {
                try
                {
                    if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT Id_Pt, Nama, Alamat, Telepon, Nama_Pembimbing FROM perusahaan WHERE Id_Pt = @IdPt", Classdb.koneksi))
                    {
                        cmd.Parameters.AddWithValue("@IdPt", idp);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                label7.Text = reader["Id_Pt"].ToString();
                                TXTnm.Text = reader["Nama"].ToString();
                                TXTalamat.Text = reader["Alamat"].ToString();
                                TXTtlp.Text = reader["Telepon"].ToString();
                                TXTpembimbing.Text = reader["Nama_Pembimbing"].ToString();
                                button1.Visible = false; // Sembunyikan tombol Simpan
                                button4.Visible = true;  // Munculkan tombol Update
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data perusahaan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TXTtlp_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTnm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TXTnip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
