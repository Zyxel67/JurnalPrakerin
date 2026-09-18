using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class FormPresensiSiswa : Form
    {
        public FormPresensiSiswa()
        {
            InitializeComponent();
        }

        private void FormPresensiSiswa_Load(object sender, EventArgs e)
        {
            lblTanggalHariIni.Text = "Tanggal: " + DateTime.Today.ToString("dd MMMM yyyy");
            if (cmbStatus.Items.Count > 0)
            {
                cmbStatus.SelectedIndex = 0; // "Hadir"
            }

            CekPresensiHariIni();
            LoadRiwayatPresensi();
        }

        private void CekPresensiHariIni()
        {
            try
            {
                string idSiswa = Classdb.idUserLogin;
                if (string.IsNullOrEmpty(idSiswa)) return;

                if (Classdb.koneksi.State == ConnectionState.Closed)
                    Classdb.koneksi.Open();

                string query = "SELECT * FROM presensi WHERE Ids = @Ids AND tanggal = CURDATE()";
                using (MySqlCommand cmd = new MySqlCommand(query, Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Ids", idSiswa);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string statusHadir = reader["status_kehadiran"].ToString();
                            string jam = reader["jam_masuk"].ToString();
                            string verif = reader["status_verifikasi"].ToString();
                            string catatanPT = reader["catatan_pt"] == DBNull.Value || string.IsNullOrEmpty(reader["catatan_pt"].ToString()) 
                                               ? "-" : reader["catatan_pt"].ToString();

                            lblStatusVerifikasiHariIni.Text = verif.ToUpper();
                            if (verif == "Diverifikasi")
                                lblStatusVerifikasiHariIni.ForeColor = Color.LimeGreen;
                            else if (verif == "Ditolak")
                                lblStatusVerifikasiHariIni.ForeColor = Color.IndianRed;
                            else
                                lblStatusVerifikasiHariIni.ForeColor = Color.DarkOrange;

                            lblInfoHariIni.Text = $"Status: {statusHadir} (Jam {jam})\nCatatan PT: {catatanPT}";

                            btnKirimPresensi.Enabled = false;
                            btnKirimPresensi.Text = "Sudah Absen Hari Ini";
                            btnKirimPresensi.BackColor = Color.Gray;
                        }
                        else
                        {
                            lblStatusVerifikasiHariIni.Text = "BELUM ABSEN";
                            lblStatusVerifikasiHariIni.ForeColor = Color.DarkOrange;
                            lblInfoHariIni.Text = "Anda belum melakukan presensi hari ini. Silakan pilih status dan klik tombol kirim.";

                            btnKirimPresensi.Enabled = true;
                            btnKirimPresensi.Text = "Kirim Presensi Sekarang";
                            btnKirimPresensi.BackColor = Color.FromArgb(16, 185, 129);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengecek status presensi hari ini: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open)
                    Classdb.koneksi.Close();
            }
        }

        private void btnKirimPresensi_Click(object sender, EventArgs e)
        {
            string idSiswa = Classdb.idUserLogin;
            if (string.IsNullOrEmpty(idSiswa))
            {
                MessageBox.Show("Sesi login siswa tidak valid. Silakan login ulang!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = cmbStatus.SelectedItem == null ? "Hadir" : cmbStatus.SelectedItem.ToString();
            string ket = txtKeterangan.Text.Trim();

            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed)
                    Classdb.koneksi.Open();

                string query = "INSERT INTO presensi (Ids, tanggal, jam_masuk, status_kehadiran, keterangan, status_verifikasi) " +
                               "VALUES (@Ids, CURDATE(), CURTIME(), @Status, @Ket, 'Menunggu')";

                using (MySqlCommand cmd = new MySqlCommand(query, Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Ids", idSiswa);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Ket", ket);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Presensi berhasil dikirim! Menunggu verifikasi dari pembimbing PT.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKeterangan.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengirim presensi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open)
                    Classdb.koneksi.Close();

                CekPresensiHariIni();
                LoadRiwayatPresensi();
            }
        }

        private void LoadRiwayatPresensi()
        {
            try
            {
                string idSiswa = Classdb.idUserLogin;
                if (string.IsNullOrEmpty(idSiswa)) return;

                string query = "SELECT tanggal, jam_masuk, status_kehadiran, keterangan, status_verifikasi, catatan_pt " +
                               "FROM presensi " +
                               "WHERE Ids = '" + idSiswa + "' " +
                               "ORDER BY tanggal DESC, jam_masuk DESC";

                Classdb.crud(query);
                if (Classdb.ds.Tables.Count > 0)
                {
                    dgvRiwayatPresensi.DataSource = Classdb.ds.Tables[0];
                    dgvRiwayatPresensi.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat riwayat presensi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CekPresensiHariIni();
            LoadRiwayatPresensi();
        }
    }
}

