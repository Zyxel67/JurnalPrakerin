using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class FormDashboardPT : Form
    {
        private string selectedSiswaPTIds = "";

        private Button btnNavPresensi;
        private Button btnNavJurnal;
        private Button btnNavPenilaian;

        // Custom UI Controls for PT
        private Button btnVerifikasiSemuaHadir;
        private TextBox txtCariPresensiPT;
        private TextBox txtCariJurnalPT;
        private NumericUpDown numDisiplin;
        private NumericUpDown numSikap;
        private NumericUpDown numTeknis;
        private NumericUpDown numInisiatif;

        public FormDashboardPT(string nama = "Perusahaan")
        {
            InitializeComponent();
            lblTitle.Text = "DASHBOARD PERUSAHAAN (PT)";
            lblNamaPerusahaan.Text = $"Halo, {nama}";
            cmbStatusVerifikasi.SelectedIndex = 0; // "Semua"
            dtpTanggalPresensi.Value = DateTime.Today;

            InitCustomControlsPT();
            LoadAllData();
            BuildSidebar();
        }

        private void InitCustomControlsPT()
        {
            // --- 1. BATCH VERIFICATION BUTTON & SEARCH DI TAB PRESENSI ---
            btnVerifikasiSemuaHadir = new Button
            {
                Text = "⚡ Verifikasi Semua Hadir",
                Size = new Size(180, 32),
                Location = new Point(btnVerifikasiHadir.Right + 10, btnVerifikasiHadir.Top),
                BackColor = Color.FromArgb(16, 185, 129),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            btnVerifikasiSemuaHadir.FlatAppearance.BorderSize = 0;
            btnVerifikasiSemuaHadir.Click += btnVerifikasiSemuaHadir_Click;
            pnlFilterPresensi.Controls.Add(btnVerifikasiSemuaHadir);

            Label lblCariPresensi = new Label { Text = "Cari Siswa:", Location = new Point(btnTolakPresensi.Right + 20, btnTolakPresensi.Top + 6), AutoSize = true, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            txtCariPresensiPT = new TextBox { Location = new Point(lblCariPresensi.Right + 5, btnTolakPresensi.Top + 4), Width = 140 };
            txtCariPresensiPT.TextChanged += (s, e) => LoadPresensiData();
            pnlFilterPresensi.Controls.Add(lblCariPresensi);
            pnlFilterPresensi.Controls.Add(txtCariPresensiPT);

            // --- 2. SEARCH & DOUBLE CLICK DI TAB JURNAL ---
            Panel pnlFilterJurnal = new Panel { Dock = DockStyle.Top, Height = 45, BackColor = Color.FromArgb(248, 250, 252), Padding = new Padding(10, 8, 10, 8) };
            Label lblCariJurnal = new Label { Text = "Cari Siswa/Kegiatan:", Location = new Point(15, 12), AutoSize = true, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            txtCariJurnalPT = new TextBox { Location = new Point(160, 10), Width = 200 };
            txtCariJurnalPT.TextChanged += (s, e) => LoadJurnalData();

            pnlFilterJurnal.Controls.Add(lblCariJurnal);
            pnlFilterJurnal.Controls.Add(txtCariJurnalPT);
            tabJurnal.Controls.Add(pnlFilterJurnal);
            pnlFilterJurnal.BringToFront();

            dgvJurnal.CellDoubleClick += (s, e) => {
                if (e.RowIndex >= 0) btnViewDetails_Click(s, e);
            };

            // --- 3. MULTI-CRITERIA SCORING RUBRIC DI TAB PENILAIAN ---
            Panel pnlRubrik = new Panel
            {
                Size = new Size(380, 130),
                Location = new Point(lblNilaiPTInput.Left, lblNilaiPTInput.Bottom + 5),
                BackColor = Color.FromArgb(241, 245, 249),
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(8)
            };

            Label lblRubrikHeader = new Label { Text = "Rubrik Penilaian Kinerja Industri:", Font = new Font("Segoe UI", 8.5F, FontStyle.Bold), AutoSize = true, Location = new Point(8, 6), ForeColor = Color.FromArgb(30, 41, 59) };
            pnlRubrik.Controls.Add(lblRubrikHeader);

            // 4 Kriteria Penilaian
            Label lblD = new Label { Text = "Kedisiplinan (25%):", Location = new Point(8, 30), AutoSize = true, Font = new Font("Segoe UI", 8F) };
            numDisiplin = new NumericUpDown { Location = new Point(140, 28), Width = 50, Maximum = 100, Value = 80 };
            numDisiplin.ValueChanged += (s, e) => HitungNilaiRubrik();

            Label lblS = new Label { Text = "Etika/Sikap (25%):", Location = new Point(200, 30), AutoSize = true, Font = new Font("Segoe UI", 8F) };
            numSikap = new NumericUpDown { Location = new Point(320, 28), Width = 50, Maximum = 100, Value = 85 };
            numSikap.ValueChanged += (s, e) => HitungNilaiRubrik();

            Label lblT = new Label { Text = "Keahlian Teknis (30%):", Location = new Point(8, 60), AutoSize = true, Font = new Font("Segoe UI", 8F) };
            numTeknis = new NumericUpDown { Location = new Point(140, 58), Width = 50, Maximum = 100, Value = 85 };
            numTeknis.ValueChanged += (s, e) => HitungNilaiRubrik();

            Label lblI = new Label { Text = "Inisiatif/Kreatif (20%):", Location = new Point(200, 60), AutoSize = true, Font = new Font("Segoe UI", 8F) };
            numInisiatif = new NumericUpDown { Location = new Point(320, 58), Width = 50, Maximum = 100, Value = 80 };
            numInisiatif.ValueChanged += (s, e) => HitungNilaiRubrik();

            Button btnTerapkanRubrik = new Button
            {
                Text = "Terapkan ke Catatan",
                Size = new Size(160, 24),
                Location = new Point(8, 92),
                BackColor = Color.FromArgb(79, 70, 229),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold)
            };
            btnTerapkanRubrik.FlatAppearance.BorderSize = 0;
            btnTerapkanRubrik.Click += (s, e) => TerapkanCatatanRubrik();

            pnlRubrik.Controls.Add(lblD);
            pnlRubrik.Controls.Add(numDisiplin);
            pnlRubrik.Controls.Add(lblS);
            pnlRubrik.Controls.Add(numSikap);
            pnlRubrik.Controls.Add(lblT);
            pnlRubrik.Controls.Add(numTeknis);
            pnlRubrik.Controls.Add(lblI);
            pnlRubrik.Controls.Add(numInisiatif);
            pnlRubrik.Controls.Add(btnTerapkanRubrik);

            pnlPenilaianPT.Controls.Add(pnlRubrik);
            pnlRubrik.BringToFront();
        }

        private void HitungNilaiRubrik()
        {
            double d = (double)numDisiplin.Value;
            double s = (double)numSikap.Value;
            double t = (double)numTeknis.Value;
            double i = (double)numInisiatif.Value;

            double total = (d * 0.25) + (s * 0.25) + (t * 0.30) + (i * 0.20);
            numNilaiPT.Value = Math.Min(100, Math.Max(0, (decimal)Math.Round(total)));
        }

        private void TerapkanCatatanRubrik()
        {
            string rubrikSummary = $"[Evaluasi PT] Disiplin: {numDisiplin.Value}, Etika: {numSikap.Value}, Teknis: {numTeknis.Value}, Inisiatif: {numInisiatif.Value}.";
            if (string.IsNullOrWhiteSpace(txtCatatanPT.Text))
            {
                txtCatatanPT.Text = rubrikSummary;
            }
            else
            {
                txtCatatanPT.Text = rubrikSummary + " " + txtCatatanPT.Text;
            }
        }

        private void BuildSidebar()
        {
            tabControlPT.Appearance = TabAppearance.FlatButtons;
            tabControlPT.ItemSize = new Size(0, 1);
            tabControlPT.SizeMode = TabSizeMode.Fixed;

            Panel pnlSidebar = new Panel();
            pnlSidebar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Width = 200;

            Label lblLogo = new Label();
            lblLogo.Text = "PERUSAHAAN";
            lblLogo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblLogo.ForeColor = System.Drawing.Color.DodgerBlue;
            lblLogo.Dock = DockStyle.Top;
            lblLogo.Height = 80;
            lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            pnlSidebar.Controls.Add(lblLogo);
            lblLogo.SendToBack();

            btnNavPresensi = CreateSidebarButton("Presensi Siswa");
            btnNavPresensi.Click += (s, e) => {
                tabControlPT.SelectedIndex = 0;
                SetActiveNavButton(btnNavPresensi);
                LoadPresensiData();
            };
            pnlSidebar.Controls.Add(btnNavPresensi);
            btnNavPresensi.SendToBack();

            btnNavJurnal = CreateSidebarButton("Jurnal Siswa");
            btnNavJurnal.Click += (s, e) => {
                tabControlPT.SelectedIndex = 1;
                SetActiveNavButton(btnNavJurnal);
                LoadJurnalData();
            };
            pnlSidebar.Controls.Add(btnNavJurnal);
            btnNavJurnal.SendToBack();

            btnNavPenilaian = CreateSidebarButton("Penilaian");
            btnNavPenilaian.Click += (s, e) => {
                tabControlPT.SelectedIndex = 2;
                SetActiveNavButton(btnNavPenilaian);
                LoadPenilaianPT();
            };
            pnlSidebar.Controls.Add(btnNavPenilaian);
            btnNavPenilaian.SendToBack();

            Button btnNavCetak = CreateSidebarButton("🖨️ Cetak Laporan");
            btnNavCetak.Click += (s, e) => {
                if (tabControlPT.SelectedIndex == 0)
                {
                    LaporanHelper.CetakKeBrowser(dgvPresensi, "REKAPITULASI PRESENSI SISWA PKL PERUSAHAAN", "ID Perusahaan: " + Classdb.idUserLogin);
                }
                else if (tabControlPT.SelectedIndex == 1)
                {
                    LaporanHelper.CetakKeBrowser(dgvJurnal, "REKAPITULASI JURNAL HARIAN SISWA PKL PERUSAHAAN", "ID Perusahaan: " + Classdb.idUserLogin);
                }
                else
                {
                    LaporanHelper.CetakKeBrowser(dgvPenilaianPT, "REKAPITULASI PENILAIAN SISWA PKL PERUSAHAAN", "ID Perusahaan: " + Classdb.idUserLogin);
                }
            };
            pnlSidebar.Controls.Add(btnNavCetak);
            btnNavCetak.SendToBack();

            Button btnLogout = CreateSidebarButton("Keluar (Logout)");
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.ForeColor = System.Drawing.Color.IndianRed;
            btnLogout.Click += btnLogout_Click;
            pnlSidebar.Controls.Add(btnLogout);

            this.Controls.Add(pnlSidebar);
            pnlSidebar.SendToBack();

            SetActiveNavButton(btnNavPresensi);
        }

        private void SetActiveNavButton(Button activeBtn)
        {
            if (btnNavPresensi != null) btnNavPresensi.BackColor = Color.Transparent;
            if (btnNavJurnal != null) btnNavJurnal.BackColor = Color.Transparent;
            if (btnNavPenilaian != null) btnNavPenilaian.BackColor = Color.Transparent;

            if (activeBtn != null)
            {
                activeBtn.BackColor = Color.FromArgb(30, 41, 59);
            }
        }

        private Button CreateSidebarButton(string text)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Dock = DockStyle.Top;
            btn.Height = 50;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            btn.Font = new System.Drawing.Font("Segoe UI", 11F);
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(20, 0, 0, 0);
            return btn;
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

                // Siswa Hadir Hari Ini (diverifikasi)
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

                string filterSearch = "";
                if (txtCariPresensiPT != null && !string.IsNullOrWhiteSpace(txtCariPresensiPT.Text))
                {
                    string kw = txtCariPresensiPT.Text.Replace("'", "''");
                    filterSearch = $" AND (s.Nama LIKE '%{kw}%' OR s.Ids LIKE '%{kw}%' OR s.Kelas LIKE '%{kw}%')";
                }

                string query = "SELECT p.id_presensi, p.Ids, s.Nama AS NamaSiswa, s.Kelas, s.Jurusan, " +
                               "p.tanggal, p.jam_masuk, p.status_kehadiran, p.keterangan, " +
                               "p.status_verifikasi, p.catatan_pt " +
                               "FROM presensi p " +
                               "JOIN siswa s ON p.Ids = s.Ids " +
                               "WHERE s.Id_Pt = " + idPt + filterTanggal + filterStatus + filterSearch + " " +
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
            if (dgvPresensi.SelectedRows.Count == 0 && dgvPresensi.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih salah satu data presensi di tabel.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvPresensi.SelectedRows.Count > 0 ? dgvPresensi.SelectedRows[0] : dgvPresensi.CurrentRow;
            var confirm = MessageBox.Show("Verifikasi kehadiran siswa ini (Status: Diverifikasi)?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            string idPresensi = row.Cells["id_presensi"].Value.ToString();

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

        private void btnVerifikasiSemuaHadir_Click(object sender, EventArgs e)
        {
            string idPt = GetPtId();
            string tglStr = dtpTanggalPresensi.Value.ToString("yyyy-MM-dd");
            string confirmMsg = chkSemuaTanggal.Checked 
                ? "Apakah Anda yakin ingin memverifikasi SEMUA presensi yang berstatus Menunggu?" 
                : $"Apakah Anda yakin ingin memverifikasi SEMUA presensi hadir pada tanggal {tglStr}?";

            var confirm = MessageBox.Show(confirmMsg, "Konfirmasi Verifikasi Massal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();

                string query = "UPDATE presensi p JOIN siswa s ON p.Ids = s.Ids " +
                               "SET p.status_verifikasi = 'Diverifikasi' " +
                               "WHERE s.Id_Pt = @IdPt AND p.status_verifikasi = 'Menunggu'";

                if (!chkSemuaTanggal.Checked)
                {
                    query += " AND p.tanggal = @Tgl";
                }

                using (var cmd = new MySqlCommand(query, Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@IdPt", idPt);
                    if (!chkSemuaTanggal.Checked)
                    {
                        cmd.Parameters.AddWithValue("@Tgl", tglStr);
                    }
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show($"Berhasil memverifikasi {rows} data presensi siswa!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memverifikasi massal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dgvPresensi.SelectedRows.Count == 0 && dgvPresensi.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih salah satu data presensi di tabel.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvPresensi.SelectedRows.Count > 0 ? dgvPresensi.SelectedRows[0] : dgvPresensi.CurrentRow;
            string idPresensi = row.Cells["id_presensi"].Value.ToString();
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
                string filterSearch = "";
                if (txtCariJurnalPT != null && !string.IsNullOrWhiteSpace(txtCariJurnalPT.Text))
                {
                    string kw = txtCariJurnalPT.Text.Replace("'", "''");
                    filterSearch = $" AND (s.Nama LIKE '%{kw}%' OR j.kegiatan LIKE '%{kw}%' OR s.Ids LIKE '%{kw}%')";
                }

                Classdb.crud("SELECT j.id_laporan, s.Nama AS NamaSiswa, s.Kelas, j.tanggal, j.kegiatan, j.status, j.catatan " +
                             "FROM jurnal_siswa j " +
                             "LEFT JOIN siswa s ON j.Ids = s.Ids " +
                             "WHERE s.Id_Pt = " + idPt + filterSearch + " " +
                             "ORDER BY j.tanggal DESC LIMIT 100");

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
            if (dgvJurnal.SelectedRows.Count == 0 && dgvJurnal.CurrentRow == null)
            {
                MessageBox.Show("Pilih jurnal terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dgvJurnal.SelectedRows.Count > 0 ? dgvJurnal.SelectedRows[0] : dgvJurnal.CurrentRow;
            var id = row.Cells["id_laporan"].Value.ToString();
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
            if (numDisiplin != null) numDisiplin.Value = 80;
            if (numSikap != null) numSikap.Value = 85;
            if (numTeknis != null) numTeknis.Value = 85;
            if (numInisiatif != null) numInisiatif.Value = 80;
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

            int scorePT = (int)numNilaiPT.Value;
            string catatan = txtCatatanPT.Text.Trim();

            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();

                string query = "INSERT INTO nilai_pkl (Ids, nilai_pt, catatan_pt) " +
                               "VALUES (@Ids, @NilaiPT, @CatatanPT) " +
                               "ON DUPLICATE KEY UPDATE " +
                               "nilai_pt = @NilaiPT, catatan_pt = @CatatanPT";

                using (var cmd = new MySqlCommand(query, Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Ids", selectedSiswaPTIds);
                    cmd.Parameters.AddWithValue("@NilaiPT", scorePT);
                    cmd.Parameters.AddWithValue("@CatatanPT", catatan);

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
            if (tabControlPT.SelectedTab == tabPenilaianPT)
                LoadPenilaianPT();
            else if (tabControlPT.SelectedTab == tabJurnal)
                LoadJurnalData();
            else
                LoadPresensiData();
        }
    }
}

