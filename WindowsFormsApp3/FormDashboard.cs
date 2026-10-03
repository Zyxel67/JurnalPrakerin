using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();

            // Panggil semua data saat form pertama kali dimuat
            LoadDataDashboard();
            LoadRiwayatTerakhir();
            LoadProfilSiswa();

            // Permak tampilan DataGridView biar modern lewat kode
            DesainTabel();
        }

        // --- 1. AMBIL NAMA SISWA BUAT DI HEADER ---
        private void LoadProfilSiswa()
        {
            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();

                string query = "SELECT Nama FROM siswa WHERE Ids = @Ids";
                using (MySqlCommand cmd = new MySqlCommand(query, Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Ids", Classdb.idUserLogin);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // lblNamaSiswa itu Label yang ada di Header atas pojok kanan
                        lblNamaSiswa.Text = "Halo, " + result.ToString();
                    }
                }
            }
            catch (Exception)
            {
                lblNamaSiswa.Text = "Halo, Siswa"; // Fallback kalau gagal
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
            }
        }

        // --- 2. HITUNG STATISTIK (4 KOTAK WARNA) ---
        private void LoadDataDashboard()
        {
            try
            {
                string idSiswa = Classdb.idUserLogin;
                if (string.IsNullOrEmpty(idSiswa)) return;

                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();

                string queryStats = @"
                    SELECT 
                        COUNT(id_laporan) AS Total,
                        SUM(CASE WHEN status = 'Menunggu' THEN 1 ELSE 0 END) AS Menunggu,
                        SUM(CASE WHEN status = 'Disetujui' THEN 1 ELSE 0 END) AS Disetujui,
                        SUM(CASE WHEN status = 'Revisi' THEN 1 ELSE 0 END) AS Revisi
                    FROM jurnal_siswa 
                    WHERE Ids = @Ids";

                using (MySqlCommand cmd = new MySqlCommand(queryStats, Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Ids", idSiswa);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblTotalJurnal.Text = reader["Total"] != DBNull.Value ? reader["Total"].ToString() : "0";
                            lblMenunggu.Text = reader["Menunggu"] != DBNull.Value ? reader["Menunggu"].ToString() : "0";
                            lblDisetujui.Text = reader["Disetujui"] != DBNull.Value ? reader["Disetujui"].ToString() : "0";
                            lblRevisi.Text = reader["Revisi"] != DBNull.Value ? reader["Revisi"].ToString() : "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat statistik: " + ex.Message);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
            }
        }

        // --- 3. TABEL 5 RIWAYAT TERAKHIR ---
        private void LoadRiwayatTerakhir()
        {
            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();

                string queryRiwayat = "SELECT tanggal, kegiatan, status FROM jurnal_siswa WHERE Ids = @Ids ORDER BY tanggal DESC LIMIT 5";
                using (MySqlCommand cmd = new MySqlCommand(queryRiwayat, Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Ids", Classdb.idUserLogin);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvRiwayat.DataSource = dt;

                        dgvRiwayat.Columns["tanggal"].HeaderText = "Tanggal";
                        dgvRiwayat.Columns["kegiatan"].HeaderText = "Kegiatan Singkat";
                        dgvRiwayat.Columns["status"].HeaderText = "Status";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat riwayat: " + ex.Message);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
            }
        }

        // --- 4. PERMAK DESAIN TABEL LEWAT KODE BIAR GLOWING ---
        private void DesainTabel()
        {
            dgvRiwayat.BorderStyle = BorderStyle.None;
            dgvRiwayat.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvRiwayat.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRiwayat.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvRiwayat.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvRiwayat.BackgroundColor = Color.White;

            dgvRiwayat.EnableHeadersVisualStyles = false;
            dgvRiwayat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRiwayat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72); // Biru Gelap
            dgvRiwayat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRiwayat.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Kolom kegiatan dibikin menuhin ruang sisa
            if (dgvRiwayat.Columns.Contains("kegiatan"))
                dgvRiwayat.Columns["kegiatan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        // --- 5. EVENT KLIK TOMBOL TULIS JURNAL ---
        private void btnTulisJurnal_Click(object sender, EventArgs e)
        {
            // Buka Form6 (Form Input Jurnal)
            Form6 formInput = new Form6();

            // Tergantung sistem menu lu, kalau pakai panel utama (MDI/Panel), sesuaikan cara panggilnya.
            // Kalau stand alone, panggil pakai ShowDialog:
            formInput.ShowDialog();

            // Setelah Form6 ditutup, refresh data dashboard biar angkanya nambah!
            LoadDataDashboard();
            LoadRiwayatTerakhir();
        }

        // --- 6. EVENT KLIK TOMBOL LIHAT NILAI ---
        private void btnLihatNilai_Click(object sender, EventArgs e)
        {
            // Buka form nilai (Sesuaikan dengan nama form nilai lu, misal FormNilaiSiswa)
            MessageBox.Show("Sedang memuat halaman nilai...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // FormNilaiSiswa formNilai = new FormNilaiSiswa();
            // formNilai.ShowDialog();
        }
    }
}