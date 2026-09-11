using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // Wajib ditambahkan untuk memproses file gambar ke byte[]
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class Form6 : Form
    {
        private byte[] fotoBytes = null;
        private string idLaporanEdit = "";
        public Form6()
        {
            InitializeComponent();
            tampildata();
        }

        // 1. Event Handler Tombol Upload Foto (Diperbaiki)
        private void btnUploadFoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "File Gambar (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                // Tampilkan preview foto di PictureBox (Pastikan nama PictureBox adalah picFoto)
                picFoto.Image = Image.FromFile(open.FileName);
                fotoBytes = File.ReadAllBytes(open.FileName);
            }
        }

        // 2. Event Handler Tombol Simpan Jurnal
        private void btnSimpanJurnal_Click_1(object sender, EventArgs e)
        {
            if (txtKegiatan.Text.Trim() == "" || txtDeskripsi.Text.Trim() == "")
            {
                MessageBox.Show("Kegiatan dan Deskripsi tidak boleh kosong, bro!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string idSiswa = Classdb.idUserLogin;

                if (string.IsNullOrEmpty(idSiswa))
                {
                    MessageBox.Show("Sesi login tidak valid, silakan login ulang!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Classdb.koneksi.State == ConnectionState.Closed)
                {
                    Classdb.koneksi.Open();
                }

                string queryInput = "INSERT INTO jurnal_siswa (Ids, tanggal, kegiatan, deskripsi, gambar, status) VALUES (@Ids, @Tanggal, @Kegiatan, @Deskripsi, @Gambar, 'Menunggu')";

                using (MySqlCommand cmd = new MySqlCommand(queryInput, Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Ids", idSiswa);
                    cmd.Parameters.AddWithValue("@Tanggal", dtpTanggal.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Kegiatan", txtKegiatan.Text);
                    cmd.Parameters.AddWithValue("@Deskripsi", txtDeskripsi.Text);

                    if (fotoBytes != null)
                    {
                        cmd.Parameters.AddWithValue("@Gambar", fotoBytes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Gambar", DBNull.Value);
                    }

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Mantap! Jurnal berhasil dikirim dan sedang menunggu persetujuan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset form
                txtKegiatan.Clear();
                txtDeskripsi.Clear();
                if (picFoto.Image != null) picFoto.Image = null;
                fotoBytes = null;
                dtpTanggal.Value = DateTime.Now;

                tampildata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open)
                {
                    Classdb.koneksi.Close();
                }
            }
        }

        // 3. Menampilkan Data (Termasuk kolom Catatan)
        private void tampildata()
        {
            dataGridView1.Rows.Clear();

            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed)
                {
                    Classdb.koneksi.Open();
                }

                string idSiswa = Classdb.idUserLogin;
                string queryTampil = "SELECT id_laporan, tanggal, kegiatan, deskripsi, status, catatan FROM jurnal_siswa WHERE Ids = @Ids ORDER BY tanggal DESC";

                using (MySqlCommand cmd = new MySqlCommand(queryTampil, Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Ids", idSiswa);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string idLaporan = reader["id_laporan"].ToString(); // Tarik id_laporannya
                            DateTime tgl = Convert.ToDateTime(reader["tanggal"]);
                            string tanggalTampil = tgl.ToString("dd MMM yyyy");
                            string kegiatan = reader["kegiatan"].ToString();
                            string deskripsi = reader["deskripsi"].ToString();
                            string status = reader["status"].ToString();
                            string catatan = reader["catatan"].ToString();

                            dataGridView1.Rows.Add(idLaporan, tanggalTampil, kegiatan, deskripsi, status, catatan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data riwayat jurnal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open)
                {
                    Classdb.koneksi.Close();
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Bisa diisi nanti kalau ada yang mau dimuat saat form pertama kali dibuka
        }

        // 4. Diperbaiki: Mencegah error hapus siswa. 
        // Sekarang kalau di-klik, data riwayat jurnalnya masuk ke TextBox biar gampang dibaca ulang.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indeksbaris = e.RowIndex;
            if (indeksbaris < 0) return;

            // Menarik data dari baris tabel yang diklik (asumsi susunan: Tanggal, Kegiatan, Deskripsi, Status, Catatan)
            string idLaporanTerpilih = dataGridView1.Rows[indeksbaris].Cells[0].Value?.ToString();
            string kegiatan = dataGridView1.Rows[indeksbaris].Cells[1].Value?.ToString();
            string deskripsi = dataGridView1.Rows[indeksbaris].Cells[2].Value?.ToString();
            string catatanGuru = dataGridView1.Rows[indeksbaris].Cells[4].Value?.ToString();

            idLaporanEdit = dataGridView1.Rows[indeksbaris].Cells[0].Value.ToString();
            string status = dataGridView1.Rows[indeksbaris].Cells[4].Value.ToString();

            if (status != "Menunggu")
            {
                MessageBox.Show("Jurnal yang sudah diperiksa tidak bisa diubah lagi!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FormDetailJurnal formDetail = new FormDetailJurnal(idLaporanTerpilih);
            formDetail.ShowDialog();        
            // Opsional: Tampilkan ke textbox jika kamu mau siswa bisa mereview ulang tulisan dan catatan gurunya
            txtKegiatan.Text = kegiatan;
            txtDeskripsi.Text = deskripsi;

            btnSimpanJurnal.Visible = false; // Sembunyikan tombol Simpan
            btnUpdate.Visible = true;        // Munculkan tombol Update
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idLaporanEdit))
            {
                MessageBox.Show("Pilih dulu jurnal yang mau diupdate dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed)
                    Classdb.koneksi.Open();

                string queryUpdate = "";

                // Jika user memilih foto baru, update gambarnya juga
                if (fotoBytes != null)
                {
                    queryUpdate = "UPDATE jurnal_siswa SET kegiatan = @Kegiatan, deskripsi = @Deskripsi, gambar = @Gambar WHERE id_laporan = @IdLaporan";
                }
                else
                {
                    // Jika tidak ada foto baru, JANGAN update kolom gambar agar foto lama tidak hilang
                    queryUpdate = "UPDATE jurnal_siswa SET kegiatan = @Kegiatan, deskripsi = @Deskripsi WHERE id_laporan = @IdLaporan";
                }

                using (MySqlCommand cmd = new MySqlCommand(queryUpdate, Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@IdLaporan", idLaporanEdit);
                    cmd.Parameters.AddWithValue("@Kegiatan", txtKegiatan.Text);
                    cmd.Parameters.AddWithValue("@Deskripsi", txtDeskripsi.Text);

                    if (fotoBytes != null)
                    {
                        cmd.Parameters.AddWithValue("@Gambar", fotoBytes);
                    }

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data jurnal berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset form kembali ke mode "Input Baru"
                txtKegiatan.Clear();
                txtDeskripsi.Clear();
                if (picFoto.Image != null) picFoto.Image = null;
                fotoBytes = null;
                idLaporanEdit = "";

                // Kembalikan tombol ke kondisi semula
                btnSimpanJurnal.Visible = true;
                btnUpdate.Visible = false;

                tampildata(); // Refresh tabel
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat update: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open)
                    Classdb.koneksi.Close();
            }
        }
    }
}