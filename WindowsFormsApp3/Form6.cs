using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            // INI KUNCI UTAMANYA: Paksa hubungkan event CellClick secara manual!
            this.dataGridView1.CellClick -= new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            btnUpdate.Visible = false;
            btnSimpanJurnal.Visible = true;
        }

        // --- 1. Fungsi Bersihkan Form ---
        private void bersih()
        {
            txtDeskripsi.Text = "";
            txtKegiatan.Text = "";
            if (picFoto.Image != null) picFoto.Image = null;
            fotoBytes = null;
            idLaporanEdit = "";
            dtpTanggal.Value = DateTime.Now;

            // Mengatur visibilitas tombol
            btnSimpanJurnal.Visible = true;
            btnUpdate.Visible = false;
        }

        // --- 2. Saat Form Pertama Kali Dibuka ---
        private void Form6_Load(object sender, EventArgs e)
        {
            tampildata();
            bersih();
        }

        // --- 3. Event Tombol Upload Foto ---
        private void btnUploadFoto_Click_1(object sender, EventArgs e)
        {
            ProsesPilihFoto();
        }

        private void btnPilihFoto_Click(object sender, EventArgs e)
        {
            ProsesPilihFoto();
        }

        private void ProsesPilihFoto()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Format Gambar (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(open.FileName);
                fotoBytes = File.ReadAllBytes(open.FileName);
            }
        }

        // --- 4. Event Tombol Simpan Jurnal Baru ---
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

                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();

                string queryInput = "INSERT INTO jurnal_siswa (Ids, tanggal, kegiatan, deskripsi, gambar, status) VALUES (@Ids, @Tanggal, @Kegiatan, @Deskripsi, @Gambar, 'Menunggu')";

                using (MySqlCommand cmd = new MySqlCommand(queryInput, Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Ids", idSiswa);
                    cmd.Parameters.AddWithValue("@Tanggal", dtpTanggal.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Kegiatan", txtKegiatan.Text);
                    cmd.Parameters.AddWithValue("@Deskripsi", txtDeskripsi.Text);

                    if (fotoBytes != null)
                        cmd.Parameters.AddWithValue("@Gambar", fotoBytes);
                    else
                        cmd.Parameters.AddWithValue("@Gambar", DBNull.Value);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Mantap! Jurnal berhasil dikirim dan sedang menunggu persetujuan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bersih();
                tampildata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan sistem: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
            }
        }

        public string sus;
        // --- 5. Fungsi Tampil Data ke Tabel ---
        private void tampildata()
        {
            dataGridView1.Rows.Clear();

            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();

                string idSiswa = Classdb.idUserLogin;
                string queryTampil = "SELECT id_laporan, tanggal, kegiatan, deskripsi, status, catatan FROM jurnal_siswa WHERE Ids = @Ids ORDER BY tanggal DESC";

                using (MySqlCommand cmd = new MySqlCommand(queryTampil, Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Ids", idSiswa);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int baris = dataGridView1.Rows.Add();

                            // Penempatan sel presisi sesuai urutan kolom
                            dataGridView1.Rows[baris].Cells[0].Value = reader["id_laporan"].ToString();

                            DateTime tgl = Convert.ToDateTime(reader["tanggal"]);
                            dataGridView1.Rows[baris].Cells[1].Value = tgl.ToString("dd MMM yyyy");

                            dataGridView1.Rows[baris].Cells[2].Value = reader["kegiatan"].ToString();
                            dataGridView1.Rows[baris].Cells[3].Value = reader["deskripsi"].ToString();
                            dataGridView1.Rows[baris].Cells[4].Value = reader["status"].ToString();
                            dataGridView1.Rows[baris].Cells[5].Value = reader["catatan"].ToString();
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
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
            }
        }

        // --- 6. Event Klik Tabel MENGGUNAKAN CELLCLICK (SESUAI REQUEST) ---
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;

            // Abaikan kalau yang diklik adalah header atas atau area kosong
            if (baris < 0 || kolom < 0) return;

            string idp = dataGridView1.Rows[baris].Cells[0].Value?.ToString();
            string status = dataGridView1.Rows[baris].Cells[4].Value?.ToString();

            // Pakai Trim() buat jaga-jaga kalau nama kolom di Designer lu ada kelebihan spasi ("Edit " / "Delete ")
            string namaHeader = dataGridView1.Columns[kolom].HeaderText.Trim();

            // --- A. KLIK TOMBOL EDIT ---
            if (namaHeader == "Edit")
            {
                if (status != "Menunggu")
                {
                    MessageBox.Show("Jurnal sudah diperiksa, tidak bisa diedit!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                idLaporanEdit = idp;
                txtKegiatan.Text = dataGridView1.Rows[baris].Cells[2].Value?.ToString();
                txtDeskripsi.Text = dataGridView1.Rows[baris].Cells[3].Value?.ToString();

                btnSimpanJurnal.Visible = false;
                btnUpdate.Visible = true;
            }

            // --- B. KLIK TOMBOL DELETE / HAPUS ---
            else if (namaHeader == "Delete" || namaHeader == "Hapus")
            {
                if (status != "Menunggu")
                {
                    MessageBox.Show("Jurnal yang sudah diperiksa tidak boleh dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult setuju = MessageBox.Show("Yakin mau menghapus jurnal harian ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (setuju == DialogResult.Yes)
                {
                    try
                    {
                        if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();

                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM jurnal_siswa WHERE id_laporan = @id", Classdb.koneksi))
                        {
                            cmd.Parameters.AddWithValue("@id", idp);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Jurnal berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tampildata();
                        bersih();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menghapus: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
                    }
                }
            }
            //ttt
            // --- C. KLIK KOLOM LAINNYA (Buka Pop-up) ---
            else
            {
                // Kalau yang diklik bukan Edit dan bukan Delete (misal klik Catatan, Judul, Tanggal), 
                // langsung panggil Form Pop-up yang nampilin foto & pesan evaluasi dari guru.
                FormDetailJurnal detailPopup = new FormDetailJurnal(idp);
                detailPopup.ShowDialog();
            }
        }

        // --- 7. Event Tombol Update Jurnal ---

        private void Form6_Load_1(object sender, EventArgs e)
        {
            tampildata();
            bersih();
            //1pp
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idLaporanEdit))
            {
                MessageBox.Show("Pilih dulu jurnal yang mau diupdate dari tabel!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();

                string queryUpdate = "";

                if (fotoBytes != null)
                {
                    queryUpdate = "UPDATE jurnal_siswa SET kegiatan = @Kegiatan, deskripsi = @Deskripsi, gambar = @Gambar WHERE id_laporan = @IdLaporan";
                }
                else
                {
                    queryUpdate = "UPDATE jurnal_siswa SET kegiatan = @Kegiatan, deskripsi = @Deskripsi WHERE id_laporan = @IdLaporan";
                }

                using (MySqlCommand cmd = new MySqlCommand(queryUpdate, Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@IdLaporan", idLaporanEdit);
                    cmd.Parameters.AddWithValue("@Kegiatan", txtKegiatan.Text);
                    cmd.Parameters.AddWithValue("@Deskripsi", txtDeskripsi.Text);

                    if (fotoBytes != null) cmd.Parameters.AddWithValue("@Gambar", fotoBytes);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Data jurnal berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bersih();
                tampildata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat update: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
            }
        }
    }
}