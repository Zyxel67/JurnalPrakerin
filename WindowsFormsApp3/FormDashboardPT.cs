using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class FormDashboardPT : Form
    {
        private string selectedSiswaPTIds = "";

        public FormDashboardPT(string nama = "Perusahaan")
        {
            InitializeComponent();
            lblTitle.Text = "DASHBOARD PERUSAHAAN (PT)";
            lblNamaPerusahaan.Text = $"Halo, {nama}";
            cmbStatusVerifikasi.SelectedIndex = 0; // "Semua"
            dtpTanggalPresensi.Value = DateTime.Today;

            LoadAllData();
        }

        private string GetPtId()
        {
            return string.IsNullOrWhiteSpace(Classdb.idUserLogin) ? "0" : Classdb.idUserLogin;
        }

        private void LoadAllData()
        {
            LoadStats();
            LoadPresensiData();
            LoadJurnalData();
            LoadPenilaianPT();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Classdb.idUserLogin = "";
                Form1 login = new Form1();
                login.Show();
                this.Close();
            }
        }

        // ==========================================
        // 1. STATISTIK RINGKASAN
        // ==========================================

        private void LoadStats()
        {
            try
            {
                string idPt = GetPtId();

                // Total Siswa Aktif di PT ini
                Classdb.crud("SELECT COUNT(DISTINCT s.Ids) AS total_students FROM siswa s WHERE s.Id_Pt = " + idPt);
                if (Classdb.ds.Tables.Count > 0 && Classdb.ds.Tables[0].Rows.Count > 0)
                {
                    lblActiveStudents.Text = Classdb.ds.Tables[0].Rows[0]["total_students"].ToString();
                }

                // Siswa Hadir / On-site Hari Ini (diverifikasi)
                string queryOnSite = "SELECT COUNT(*) AS onsite_count FROM presensi p " +
                                     "JOIN siswa s ON p.Ids = s.Ids " +
                                     "WHERE s.Id_Pt = " + idPt + " AND p.tanggal = CURDATE() " +
                                     "AND p.status_kehadiran = 'Hadir' AND p.status_verifikasi = 'Diverifikasi'";
                Classdb.crud(queryOnSite);
                if (Classdb.ds.Tables.Count > 0 && Classdb.ds.Tables[0].Rows.Count > 0)
                {
                    lblOnSiteCount.Text = Classdb.ds.Tables[0].Rows[0]["onsite_count"].ToString();
                }

                // Kehadiran Menunggu Verifikasi
                string queryPending = "SELECT COUNT(*) AS pending_count FROM presensi p " +
                                      "JOIN siswa s ON p.Ids = s.Ids " +
                                      "WHERE s.Id_Pt = " + idPt + " AND p.status_verifikasi = 'Menunggu'";
                Classdb.crud(queryPending);
                if (Classdb.ds.Tables.Count > 0 && Classdb.ds.Tables[0].Rows.Count > 0)
                {
                    lblPendingPresensiCount.Text = Classdb.ds.Tables[0].Rows[0]["pending_count"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat statistik: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // 2. VERIFIKASI KEHADIRAN (PRESENSI)
        // ==========================================

        private void LoadPresensiData()
        {
            try
            {
                string idPt = GetPtId();
                string filterTanggal = "";
                if (!chkSemuaTanggal.Checked)
                {
                    filterTanggal = " AND p.tanggal = '" + dtpTanggalPresensi.Value.ToString("yyyy-MM-dd") + "'";
                }

                string filterStatus = "";
                if (cmbStatusVerifikasi.SelectedIndex > 0)
                {
                    string statusPilihan = cmbStatusVerifikasi.SelectedItem.ToString();
                    filterStatus = " AND p.status_verifikasi = '" + statusPilihan + "'";
                }

                string query = "SELECT p.id_presensi, p.Ids, s.Nama AS NamaSiswa, s.Kelas, s.Jurusan, " +
                               "p.tanggal, p.jam_masuk, p.status_kehadiran, p.keterangan, " +
                               "p.status_verifikasi, p.catatan_pt " +
                               "FROM presensi p " +
                               "JOIN siswa s ON p.Ids = s.Ids " +
                               "WHERE s.Id_Pt = " + idPt + filterTanggal + filterStatus + " " +
                               "ORDER BY p.tanggal DESC, p.jam_masuk DESC";

                Classdb.crud(query);
                if (Classdb.ds.Tables.Count > 0)
                {
                    dgvPresensi.DataSource = Classdb.ds.Tables[0];
                    dgvPresensi.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data presensi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkSemuaTanggal_CheckedChanged(object sender, EventArgs e)
        {
            dtpTanggalPresensi.Enabled = !chkSemuaTanggal.Checked;
        }

        private void btnFilterPresensi_Click(object sender, EventArgs e)
        {
            LoadPresensiData();
        }

        private void btnRefreshPresensi_Click(object sender, EventArgs e)
        {
            LoadStats();
            LoadPresensiData();
        }

        private void btnVerifikasiHadir_Click(object sender, EventArgs e)
        {
            if (dgvPresensi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan pilih salah satu data presensi di tabel.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Verifikasi kehadiran siswa ini (Status: Diverifikasi)?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            string idPresensi = dgvPresensi.SelectedRows[0].Cells["id_presensi"].Value.ToString();

            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                using (var cmd = new MySqlCommand("UPDATE presensi SET status_verifikasi = 'Diverifikasi' WHERE id_presensi = @id", Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@id", idPresensi);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Kehadiran siswa berhasil diverifikasi!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memverifikasi presensi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
                LoadStats();
                LoadPresensiData();
            }
        }

        private void btnTolakPresensi_Click(object sender, EventArgs e)
        {
            if (dgvPresensi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan pilih salah satu data presensi di tabel.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idPresensi = dgvPresensi.SelectedRows[0].Cells["id_presensi"].Value.ToString();
            string note = "";

            using (var dlg = new FormNoteDialog("Alasan / Catatan Penolakan Kehadiran"))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    note = dlg.Note;
                }
                else
                {
                    return;
                }
            }

            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                using (var cmd = new MySqlCommand("UPDATE presensi SET status_verifikasi = 'Ditolak', catatan_pt = @catatan WHERE id_presensi = @id", Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@id", idPresensi);
                    cmd.Parameters.AddWithValue("@catatan", note);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Kehadiran ditandai Ditolak beserta catatan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menolak presensi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
                LoadStats();
                LoadPresensiData();
            }
        }

        // ==========================================
        // 3. MONITORING JURNAL SISWA
        // ==========================================

        private void LoadJurnalData()
        {
            try
            {
                string idPt = GetPtId();

                Classdb.crud("SELECT j.id_laporan, s.Nama AS NamaSiswa, s.Kelas, j.tanggal, j.kegiatan, j.status, j.catatan " +
                             "FROM jurnal_siswa j " +
                             "LEFT JOIN siswa s ON j.Ids = s.Ids " +
                             "WHERE s.Id_Pt = " + idPt + " " +
                             "ORDER BY j.tanggal DESC LIMIT 50");

                if (Classdb.ds.Tables.Count > 0)
                {
                    dgvJurnal.DataSource = Classdb.ds.Tables[0];
                    dgvJurnal.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat jurnal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvJurnal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih jurnal terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var id = dgvJurnal.SelectedRows[0].Cells["id_laporan"].Value.ToString();
            var detailForm = new FormDetailJurnal(id);
            detailForm.ShowDialog();
        }

        private void btnRefreshJurnal_Click(object sender, EventArgs e)
        {
            LoadJurnalData();
        }

        // ==========================================
        // 4. PENILAIAN DARI PEMBIMBING PT
        // ==========================================

        private void LoadPenilaianPT()
        {
            try
            {
                string idPt = GetPtId();

                string query = "SELECT s.Ids, s.Nama AS NamaSiswa, s.Kelas, s.Jurusan, " +
                               "COALESCE(n.nilai_pt, 0) AS NilaiPT, " +
                               "COALESCE(n.catatan_pt, '') AS CatatanPT, " +
                               "COALESCE(n.nilai_guru, 0) AS NilaiGuru, " +
                               "COALESCE(n.status_akhir, 'Menunggu Penilaian') AS StatusAkhir " +
                               "FROM siswa s " +
                               "LEFT JOIN nilai_pkl n ON s.Ids = n.Ids " +
                               "WHERE s.Id_Pt = " + idPt + " " +
                               "ORDER BY s.Nama ASC";

                Classdb.crud(query);
                if (Classdb.ds.Tables.Count > 0)
                {
                    dgvPenilaianPT.DataSource = Classdb.ds.Tables[0];
                    dgvPenilaianPT.AutoResizeColumns();
                }

                ResetFormNilaiPT();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data penilaian PT: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetFormNilaiPT()
        {
            selectedSiswaPTIds = "";
            lblSelectedSiswaPT.Text = "Pilih salah satu siswa di tabel untuk memberi nilai kinerja industri.";
            numNilaiPT.Value = 0;
            txtCatatanPT.Text = "";
        }

        private void dgvPenilaianPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvPenilaianPT.Rows[e.RowIndex];
                selectedSiswaPTIds = row.Cells["Ids"].Value.ToString();
                string nama = row.Cells["NamaSiswa"].Value.ToString();
                string kelas = row.Cells["Kelas"].Value.ToString();
                string jurusan = row.Cells["Jurusan"].Value.ToString();

                int nilaiPT = 0;
                int.TryParse(row.Cells["NilaiPT"].Value.ToString(), out nilaiPT);
                string catatan = row.Cells["CatatanPT"].Value.ToString();

                lblSelectedSiswaPT.Text = $"Nama: {nama}\nNIS: {selectedSiswaPTIds} | Kelas: {kelas} {jurusan}";
                numNilaiPT.Value = Math.Min(100, Math.Max(0, nilaiPT));
                txtCatatanPT.Text = catatan;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memilih siswa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpanNilaiPT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedSiswaPTIds))
            {
                MessageBox.Show("Silakan pilih siswa terlebih dahulu dari tabel di samping.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int score = (int)numNilaiPT.Value;
            string catatan = txtCatatanPT.Text.Trim();

            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();

                string query = "INSERT INTO nilai_pkl (Ids, nilai_pt, catatan_pt) " +
                               "VALUES (@Ids, @Nilai, @Catatan) " +
                               "ON DUPLICATE KEY UPDATE " +
                               "nilai_pt = @Nilai, catatan_pt = @Catatan";

                using (var cmd = new MySqlCommand(query, Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Ids", selectedSiswaPTIds);
                    cmd.Parameters.AddWithValue("@Nilai", score);
                    cmd.Parameters.AddWithValue("@Catatan", catatan);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show($"Nilai industri untuk siswa NIS '{selectedSiswaPTIds}' berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan nilai industri: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
                LoadPenilaianPT();
            }
        }

        private void btnRefreshNilaiPT_Click(object sender, EventArgs e)
        {
            LoadPenilaianPT();
        }

        private void tabControlPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStats();
            if (tabControlPT.SelectedTab == tabPresensi)
            {
                LoadPresensiData();
            }
            else if (tabControlPT.SelectedTab == tabJurnal)
            {
                LoadJurnalData();
            }
            else if (tabControlPT.SelectedTab == tabPenilaianPT)
            {
                LoadPenilaianPT();
            }
        }
    }
}

