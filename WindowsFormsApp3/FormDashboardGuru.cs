using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class FormDashboardGuru : Form
    {
        private string selectedIds = "";

        // Nav Buttons
        private Button btnNavJurnal;
        private Button btnNavSiswa;
        private Button btnNavPresensi;
        private Button btnNavPenilaian;

        // Custom UI Controls for Guru
        private TabPage tabSiswaBimbingan;
        private TabPage tabPresensiGuru;
        private DataGridView dgvSiswaBimbingan;
        private DataGridView dgvPresensiGuru;
        private ComboBox cmbFilterStatusJurnal;
        private TextBox txtCariJurnal;
        private TextBox txtCariSiswa;
        private DateTimePicker dtpPresensiGuru;
        private CheckBox chkSemuaTanggalPresensi;

        public FormDashboardGuru(string nama = "Guru")
        {
            InitializeComponent();
            lblTitle.Text = "DASHBOARD GURU PEMBIMBING PKL";
            lblNamaPengguna.Text = $"Halo, {nama}";

            InitExtraTabsAndControls();
            BuildSidebar();

            LoadData();
            LoadDataNilai();
            LoadSiswaBimbingan();
            LoadPresensiGuru();
        }

        private string GetGuruFilter()
        {
            if (string.IsNullOrWhiteSpace(Classdb.idUserLogin)) return "";
            return " AND j.Ids IN (SELECT Ids FROM siswa WHERE Id_Gr = " + Classdb.idUserLogin + ")";
        }

        private void InitExtraTabsAndControls()
        {
            // --- 1. SETUP JURNAL TAB CONTROLS (SEARCH & FILTER & DETAIL BUTTON) ---
            Panel pnlFilterJurnal = new Panel();
            pnlFilterJurnal.Height = 40;
            pnlFilterJurnal.Dock = DockStyle.Top;
            pnlFilterJurnal.BackColor = Color.FromArgb(248, 250, 252);
            pnlFilterJurnal.Padding = new Padding(10, 5, 10, 5);

            Label lblFilter = new Label { Text = "Status:", AutoSize = true, Location = new Point(10, 10), Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            cmbFilterStatusJurnal = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Location = new Point(60, 7), Width = 120 };
            cmbFilterStatusJurnal.Items.AddRange(new object[] { "Semua Status", "Menunggu", "Disetujui", "Revisi" });
            cmbFilterStatusJurnal.SelectedIndex = 0;
            cmbFilterStatusJurnal.SelectedIndexChanged += (s, e) => LoadData();

            Label lblCari = new Label { Text = "Cari Siswa/Kegiatan:", AutoSize = true, Location = new Point(200, 10), Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            txtCariJurnal = new TextBox { Location = new Point(330, 7), Width = 180 };
            txtCariJurnal.TextChanged += (s, e) => LoadData();

            Button btnLihatDetail = new Button
            {
                Text = "🔍 Lihat Foto & Detail",
                Size = new Size(150, 27),
                Location = new Point(530, 6),
                BackColor = Color.FromArgb(14, 165, 233),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold)
            };
            btnLihatDetail.FlatAppearance.BorderSize = 0;
            btnLihatDetail.Click += (s, e) => BukaDetailJurnalTerpilih();

            pnlFilterJurnal.Controls.Add(lblFilter);
            pnlFilterJurnal.Controls.Add(cmbFilterStatusJurnal);
            pnlFilterJurnal.Controls.Add(lblCari);
            pnlFilterJurnal.Controls.Add(txtCariJurnal);
            pnlFilterJurnal.Controls.Add(btnLihatDetail);

            tabJurnal.Controls.Add(pnlFilterJurnal);
            pnlFilterJurnal.BringToFront();

            // Double-click row di dgvRecent buka pop-up foto
            dgvRecent.CellDoubleClick += (s, e) => {
                if (e.RowIndex >= 0) BukaDetailJurnalTerpilih();
            };

            // --- 2. SETUP TAB SISWA BIMBINGAN ---
            tabSiswaBimbingan = new TabPage("Siswa Bimbingan");
            tabSiswaBimbingan.BackColor = Color.White;

            Panel pnlTopSiswa = new Panel { Dock = DockStyle.Top, Height = 55, BackColor = Color.FromArgb(248, 250, 252), Padding = new Padding(15, 10, 15, 10) };
            Label lblHeaderSiswa = new Label { Text = "DAFTAR SISWA BIMBINGAN PKL", Font = new Font("Segoe UI", 12F, FontStyle.Bold), Location = new Point(15, 15), AutoSize = true, ForeColor = Color.FromArgb(15, 23, 42) };
            
            Label lblCariSiswa = new Label { Text = "Cari:", Location = new Point(320, 18), AutoSize = true, Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            txtCariSiswa = new TextBox { Location = new Point(360, 15), Width = 180 };
            txtCariSiswa.TextChanged += (s, e) => LoadSiswaBimbingan();

            Button btnCetakSiswa = new Button
            {
                Text = "🖨️ Cetak Daftar Siswa",
                Location = new Point(560, 13),
                Size = new Size(160, 28),
                BackColor = Color.FromArgb(14, 165, 233),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            btnCetakSiswa.FlatAppearance.BorderSize = 0;
            btnCetakSiswa.Click += (s, e) => LaporanHelper.CetakKeBrowser(dgvSiswaBimbingan, "DAFTAR SISWA BIMBINGAN PKL", "Guru Pembimbing ID: " + Classdb.idUserLogin);

            pnlTopSiswa.Controls.Add(lblHeaderSiswa);
            pnlTopSiswa.Controls.Add(lblCariSiswa);
            pnlTopSiswa.Controls.Add(txtCariSiswa);
            pnlTopSiswa.Controls.Add(btnCetakSiswa);

            dgvSiswaBimbingan = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            dgvSiswaBimbingan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);

            tabSiswaBimbingan.Controls.Add(dgvSiswaBimbingan);
            tabSiswaBimbingan.Controls.Add(pnlTopSiswa);
            tabControlGuru.TabPages.Add(tabSiswaBimbingan);

            // --- 3. SETUP TAB MONITORING PRESENSI ---
            tabPresensiGuru = new TabPage("Presensi Siswa");
            tabPresensiGuru.BackColor = Color.White;

            Panel pnlTopPresensi = new Panel { Dock = DockStyle.Top, Height = 55, BackColor = Color.FromArgb(248, 250, 252), Padding = new Padding(15, 10, 15, 10) };
            Label lblHeaderPresensi = new Label { Text = "MONITORING PRESENSI", Font = new Font("Segoe UI", 12F, FontStyle.Bold), Location = new Point(15, 15), AutoSize = true, ForeColor = Color.FromArgb(15, 23, 42) };

            dtpPresensiGuru = new DateTimePicker { Location = new Point(230, 15), Width = 130, Format = DateTimePickerFormat.Short, Value = DateTime.Today };
            dtpPresensiGuru.ValueChanged += (s, e) => LoadPresensiGuru();

            chkSemuaTanggalPresensi = new CheckBox { Text = "Semua Tanggal", Location = new Point(370, 17), AutoSize = true, Font = new Font("Segoe UI", 9F) };
            chkSemuaTanggalPresensi.CheckedChanged += (s, e) => {
                dtpPresensiGuru.Enabled = !chkSemuaTanggalPresensi.Checked;
                LoadPresensiGuru();
            };

            Button btnCetakPresensi = new Button
            {
                Text = "🖨️ Cetak Presensi",
                Location = new Point(500, 13),
                Size = new Size(140, 28),
                BackColor = Color.FromArgb(14, 165, 233),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            btnCetakPresensi.FlatAppearance.BorderSize = 0;
            btnCetakPresensi.Click += (s, e) => LaporanHelper.CetakKeBrowser(dgvPresensiGuru, "REKAPITULASI PRESENSI SISWA BIMBINGAN PKL", "Guru Pembimbing ID: " + Classdb.idUserLogin);

            pnlTopPresensi.Controls.Add(lblHeaderPresensi);
            pnlTopPresensi.Controls.Add(dtpPresensiGuru);
            pnlTopPresensi.Controls.Add(chkSemuaTanggalPresensi);
            pnlTopPresensi.Controls.Add(btnCetakPresensi);

            dgvPresensiGuru = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            dgvPresensiGuru.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);

            tabPresensiGuru.Controls.Add(dgvPresensiGuru);
            tabPresensiGuru.Controls.Add(pnlTopPresensi);
            tabControlGuru.TabPages.Add(tabPresensiGuru);
        }

        private void BukaDetailJurnalTerpilih()
        {
            if (dgvRecent.SelectedRows.Count == 0 && dgvRecent.CurrentRow == null)
            {
                MessageBox.Show("Pilih salah satu jurnal dari tabel terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dgvRecent.SelectedRows.Count > 0 ? dgvRecent.SelectedRows[0] : dgvRecent.CurrentRow;
            if (row != null && row.Cells["id_laporan"] != null && row.Cells["id_laporan"].Value != null)
            {
                string idLaporan = row.Cells["id_laporan"].Value.ToString();
                FormDetailJurnal detail = new FormDetailJurnal(idLaporan);
                detail.ShowDialog();
                LoadData();
            }
        }

        private void BuildSidebar()
        {
            tabControlGuru.Appearance = TabAppearance.FlatButtons;
            tabControlGuru.ItemSize = new Size(0, 1);
            tabControlGuru.SizeMode = TabSizeMode.Fixed;

            Panel pnlSidebar = new Panel();
            pnlSidebar.BackColor = Color.FromArgb(15, 23, 42);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Width = 200;

            Label lblLogo = new Label();
            lblLogo.Text = "GURU PKL";
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLogo.ForeColor = Color.DodgerBlue;
            lblLogo.Dock = DockStyle.Top;
            lblLogo.Height = 80;
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            pnlSidebar.Controls.Add(lblLogo);
            lblLogo.SendToBack();

            btnNavJurnal = CreateSidebarButton("Jurnal Siswa");
            btnNavJurnal.Click += (s, e) => {
                tabControlGuru.SelectedTab = tabJurnal;
                SetActiveNavButton(btnNavJurnal);
                LoadData();
            };
            pnlSidebar.Controls.Add(btnNavJurnal);
            btnNavJurnal.SendToBack();

            btnNavSiswa = CreateSidebarButton("Siswa Bimbingan");
            btnNavSiswa.Click += (s, e) => {
                tabControlGuru.SelectedTab = tabSiswaBimbingan;
                SetActiveNavButton(btnNavSiswa);
                LoadSiswaBimbingan();
            };
            pnlSidebar.Controls.Add(btnNavSiswa);
            btnNavSiswa.SendToBack();

            btnNavPresensi = CreateSidebarButton("Presensi Siswa");
            btnNavPresensi.Click += (s, e) => {
                tabControlGuru.SelectedTab = tabPresensiGuru;
                SetActiveNavButton(btnNavPresensi);
                LoadPresensiGuru();
            };
            pnlSidebar.Controls.Add(btnNavPresensi);
            btnNavPresensi.SendToBack();

            btnNavPenilaian = CreateSidebarButton("Penilaian");
            btnNavPenilaian.Click += (s, e) => {
                tabControlGuru.SelectedTab = tabPenilaian;
                SetActiveNavButton(btnNavPenilaian);
                LoadDataNilai();
            };
            pnlSidebar.Controls.Add(btnNavPenilaian);
            btnNavPenilaian.SendToBack();

            Button btnNavCetak = CreateSidebarButton("🖨️ Cetak Laporan");
            btnNavCetak.Click += (s, e) => {
                if (tabControlGuru.SelectedTab == tabJurnal)
                    LaporanHelper.CetakKeBrowser(dgvRecent, "REKAPITULASI JURNAL SISWA PKL", "Guru Pembimbing ID: " + Classdb.idUserLogin);
                else if (tabControlGuru.SelectedTab == tabSiswaBimbingan)
                    LaporanHelper.CetakKeBrowser(dgvSiswaBimbingan, "DAFTAR SISWA BIMBINGAN PKL", "Guru Pembimbing ID: " + Classdb.idUserLogin);
                else if (tabControlGuru.SelectedTab == tabPresensiGuru)
                    LaporanHelper.CetakKeBrowser(dgvPresensiGuru, "REKAPITULASI PRESENSI SISWA PKL", "Guru Pembimbing ID: " + Classdb.idUserLogin);
                else
                    LaporanHelper.CetakKeBrowser(dgvPenilaian, "REKAPITULASI PENILAIAN SISWA PKL", "Guru Pembimbing ID: " + Classdb.idUserLogin);
            };
            pnlSidebar.Controls.Add(btnNavCetak);
            btnNavCetak.SendToBack();

            Button btnLogout = CreateSidebarButton("Keluar (Logout)");
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.ForeColor = Color.IndianRed;
            btnLogout.Click += btnLogout_Click;
            pnlSidebar.Controls.Add(btnLogout);

            this.Controls.Add(pnlSidebar);
            pnlSidebar.SendToBack();

            SetActiveNavButton(btnNavJurnal);
        }

        private void SetActiveNavButton(Button activeBtn)
        {
            if (btnNavJurnal != null) btnNavJurnal.BackColor = Color.Transparent;
            if (btnNavSiswa != null) btnNavSiswa.BackColor = Color.Transparent;
            if (btnNavPresensi != null) btnNavPresensi.BackColor = Color.Transparent;
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
            btn.Height = 48;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = Color.WhiteSmoke;
            btn.Font = new Font("Segoe UI", 10.5F);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(20, 0, 0, 0);
            return btn;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
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

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvRecent.SelectedRows.Count == 0 && dgvRecent.CurrentRow == null)
            {
                MessageBox.Show("Pilih jurnal terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dgvRecent.SelectedRows.Count > 0 ? dgvRecent.SelectedRows[0] : dgvRecent.CurrentRow;
            var confirm = MessageBox.Show("Setujui jurnal ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var id = row.Cells["id_laporan"].Value.ToString();
            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                using (var cmd = new MySqlCommand("UPDATE jurnal_siswa SET status = 'Disetujui' WHERE id_laporan = @id", Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Jurnal disetujui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
                LoadData();
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvRecent.SelectedRows.Count == 0 && dgvRecent.CurrentRow == null)
            {
                MessageBox.Show("Pilih jurnal terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dgvRecent.SelectedRows.Count > 0 ? dgvRecent.SelectedRows[0] : dgvRecent.CurrentRow;
            var confirm = MessageBox.Show("Tandai jurnal ini sebagai Revisi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            string note = "";
            using (var dlg = new FormNoteDialog("Catatan Revisi"))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    note = dlg.Note;
                }
            }

            var id = row.Cells["id_laporan"].Value.ToString();
            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();
                using (var cmd = new MySqlCommand("UPDATE jurnal_siswa SET status = 'Revisi', catatan = @catatan WHERE id_laporan = @id", Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@catatan", note);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Jurnal diberi status Revisi.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
                LoadData();
            }
        }

        // ==========================================
        // 1. DATA JURNAL SISWA (DENGAN FILTER & SEARCH)
        // ==========================================
        private void LoadData()
        {
            try
            {
                string guruFilter = GetGuruFilter();

                // 1. Hitung Statistik Ringkasan
                Classdb.crud("SELECT j.status, COUNT(*) AS cnt FROM jurnal_siswa j WHERE 1=1" + guruFilter + " GROUP BY j.status");
                lblPendingCount.Text = "0";
                lblApprovedCount.Text = "0";
                lblRevisionCount.Text = "0";
                if (Classdb.ds.Tables.Count > 0)
                {
                    foreach (DataRow r in Classdb.ds.Tables[0].Rows)
                    {
                        var status = r["status"].ToString();
                        var cnt = r["cnt"].ToString();
                        if (status == "Menunggu") lblPendingCount.Text = cnt;
                        else if (status == "Disetujui") lblApprovedCount.Text = cnt;
                        else if (status == "Revisi") lblRevisionCount.Text = cnt;
                    }
                }

                // 2. Filter status & search keyword
                string filterStatus = "";
                if (cmbFilterStatusJurnal != null && cmbFilterStatusJurnal.SelectedIndex > 0)
                {
                    filterStatus = " AND j.status = '" + cmbFilterStatusJurnal.SelectedItem.ToString() + "'";
                }

                string filterSearch = "";
                if (txtCariJurnal != null && !string.IsNullOrWhiteSpace(txtCariJurnal.Text))
                {
                    string safeKeyword = txtCariJurnal.Text.Replace("'", "''");
                    filterSearch = $" AND (s.Nama LIKE '%{safeKeyword}%' OR j.kegiatan LIKE '%{safeKeyword}%' OR s.Ids LIKE '%{safeKeyword}%')";
                }

                string queryJurnal = "SELECT j.id_laporan, s.Nama AS NamaSiswa, s.Kelas, j.tanggal, j.kegiatan, j.status, j.catatan " +
                                     "FROM jurnal_siswa j LEFT JOIN siswa s ON j.Ids = s.Ids WHERE 1=1" + guruFilter + filterStatus + filterSearch + " ORDER BY j.tanggal DESC LIMIT 100";

                Classdb.crud(queryJurnal);
                if (Classdb.ds.Tables.Count > 0)
                {
                    dgvRecent.DataSource = Classdb.ds.Tables[0];
                    dgvRecent.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data jurnal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // 2. DAFTAR SISWA BIMBINGAN (ROSTER)
        // ==========================================
        private void LoadSiswaBimbingan()
        {
            try
            {
                string idGuru = string.IsNullOrWhiteSpace(Classdb.idUserLogin) ? "0" : Classdb.idUserLogin;
                string filterCari = "";
                if (txtCariSiswa != null && !string.IsNullOrWhiteSpace(txtCariSiswa.Text))
                {
                    string safeCari = txtCariSiswa.Text.Replace("'", "''");
                    filterCari = $" AND (s.Nama LIKE '%{safeCari}%' OR s.Ids LIKE '%{safeCari}%' OR s.Kelas LIKE '%{safeCari}%' OR p.Nama LIKE '%{safeCari}%')";
                }

                string query = @"SELECT s.Ids AS NIS, s.Nama AS NamaSiswa, s.Kelas, s.Jurusan, s.Telepon AS KontakSiswa, 
                                        COALESCE(p.Nama, 'Belum Ditempatkan') AS NamaPerusahaan, 
                                        COALESCE(p.Nama_Pembimbing, '-') AS PembimbingPT, 
                                        COALESCE(p.Telepon, '-') AS KontakPT, 
                                        COALESCE(COUNT(CASE WHEN j.status = 'Disetujui' THEN 1 END), 0) AS JurnalDisetujui, 
                                        COALESCE(COUNT(CASE WHEN j.status = 'Menunggu' THEN 1 END), 0) AS JurnalMenunggu, 
                                        COALESCE(n.nilai_guru, 0) AS NilaiGuru, 
                                        COALESCE(n.nilai_pt, 0) AS NilaiPT, 
                                        COALESCE(n.status_akhir, 'Belum Dinilai') AS StatusKelulusan 
                                 FROM siswa s 
                                 LEFT JOIN perusahaan p ON s.Id_Pt = p.Id_Pt 
                                 LEFT JOIN jurnal_siswa j ON s.Ids = j.Ids 
                                 LEFT JOIN nilai_pkl n ON s.Ids = n.Ids 
                                 WHERE s.Id_Gr = '" + idGuru + @"' " + filterCari + @" 
                                 GROUP BY s.Ids, s.Nama, s.Kelas, s.Jurusan, s.Telepon, p.Nama, p.Nama_Pembimbing, p.Telepon, n.nilai_guru, n.nilai_pt, n.status_akhir 
                                 ORDER BY s.Nama ASC";

                Classdb.crud(query);
                if (Classdb.ds.Tables.Count > 0 && dgvSiswaBimbingan != null)
                {
                    dgvSiswaBimbingan.DataSource = Classdb.ds.Tables[0];
                    dgvSiswaBimbingan.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat siswa bimbingan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // 3. MONITORING PRESENSI SISWA OLEH GURU
        // ==========================================
        private void LoadPresensiGuru()
        {
            try
            {
                string idGuru = string.IsNullOrWhiteSpace(Classdb.idUserLogin) ? "0" : Classdb.idUserLogin;
                string filterTgl = "";
                if (chkSemuaTanggalPresensi != null && !chkSemuaTanggalPresensi.Checked && dtpPresensiGuru != null)
                {
                    filterTgl = " AND pr.tanggal = '" + dtpPresensiGuru.Value.ToString("yyyy-MM-dd") + "'";
                }

                string query = @"SELECT pr.tanggal AS Tanggal, pr.jam_masuk AS JamMasuk, s.Ids AS NIS, s.Nama AS NamaSiswa, s.Kelas, 
                                        COALESCE(p.Nama, '-') AS TempatPKL, 
                                        pr.status_kehadiran AS Kehadiran, pr.keterangan AS Keterangan, 
                                        pr.status_verifikasi AS VerifikasiPT, pr.catatan_pt AS CatatanPT 
                                 FROM presensi pr 
                                 JOIN siswa s ON pr.Ids = s.Ids 
                                 LEFT JOIN perusahaan p ON s.Id_Pt = p.Id_Pt 
                                 WHERE s.Id_Gr = '" + idGuru + @"' " + filterTgl + @" 
                                 ORDER BY pr.tanggal DESC, pr.jam_masuk DESC";

                Classdb.crud(query);
                if (Classdb.ds.Tables.Count > 0 && dgvPresensiGuru != null)
                {
                    dgvPresensiGuru.DataSource = Classdb.ds.Tables[0];
                    dgvPresensiGuru.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat presensi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // 4. PENILAIAN SISWA OLEH GURU
        // ==========================================
        private void LoadDataNilai()
        {
            try
            {
                string idGuru = string.IsNullOrWhiteSpace(Classdb.idUserLogin) ? "0" : Classdb.idUserLogin;

                string query = "SELECT s.Ids, s.Nama AS NamaSiswa, s.Kelas, s.Jurusan, " +
                               "COALESCE(p.Nama, '-') AS NamaPerusahaan, " +
                               "COALESCE(n.nilai_guru, 0) AS NilaiGuru, " +
                               "COALESCE(n.catatan_guru, '') AS CatatanGuru, " +
                               "COALESCE(n.nilai_pt, 0) AS NilaiPT, " +
                               "COALESCE(n.status_akhir, 'Menunggu Penilaian') AS StatusAkhir " +
                               "FROM siswa s " +
                               "LEFT JOIN perusahaan p ON s.Id_Pt = p.Id_Pt " +
                               "LEFT JOIN nilai_pkl n ON s.Ids = n.Ids " +
                               "WHERE s.Id_Gr = '" + idGuru + "' " +
                               "ORDER BY s.Nama ASC";

                Classdb.crud(query);
                if (Classdb.ds.Tables.Count > 0)
                {
                    dgvPenilaian.DataSource = Classdb.ds.Tables[0];
                    dgvPenilaian.AutoResizeColumns();
                }

                ResetFormNilai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data penilaian siswa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetFormNilai()
        {
            selectedIds = "";
            lblSelectedSiswa.Text = "Pilih salah satu siswa di tabel untuk memasukkan atau mengubah nilai.";
            numNilaiGuru.Value = 0;
            txtCatatanGuru.Text = "";
            lblStatusPreview.Text = "Belum Diperbaharui";
            lblStatusPreview.ForeColor = Color.DarkOrange;
        }

        private void dgvPenilaian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvPenilaian.Rows[e.RowIndex];
                selectedIds = row.Cells["Ids"].Value.ToString();
                string nama = row.Cells["NamaSiswa"].Value.ToString();
                string kelas = row.Cells["Kelas"].Value.ToString();
                string jurusan = row.Cells["Jurusan"].Value.ToString();
                string pt = row.Cells["NamaPerusahaan"].Value.ToString();

                int nilaiGuru = 0;
                int.TryParse(row.Cells["NilaiGuru"].Value.ToString(), out nilaiGuru);
                string catatan = row.Cells["CatatanGuru"].Value.ToString();

                lblSelectedSiswa.Text = $"Nama: {nama}\nNIS: {selectedIds} | Kelas: {kelas} {jurusan}\nTempat PKL: {pt}";
                numNilaiGuru.Value = Math.Min(100, Math.Max(0, nilaiGuru));
                txtCatatanGuru.Text = catatan;

                UpdateStatusPreview((int)numNilaiGuru.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memilih siswa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numNilaiGuru_ValueChanged(object sender, EventArgs e)
        {
            UpdateStatusPreview((int)numNilaiGuru.Value);
        }

        private void UpdateStatusPreview(int score)
        {
            if (string.IsNullOrEmpty(selectedIds))
            {
                lblStatusPreview.Text = "Belum Ada Siswa";
                lblStatusPreview.ForeColor = Color.Gray;
                return;
            }

            if (score >= 75)
            {
                lblStatusPreview.Text = "LULUS";
                lblStatusPreview.ForeColor = Color.LimeGreen;
            }
            else
            {
                lblStatusPreview.Text = "TIDAK LULUS";
                lblStatusPreview.ForeColor = Color.IndianRed;
            }
        }

        private void btnSimpanNilai_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedIds))
            {
                MessageBox.Show("Silakan pilih siswa terlebih dahulu dari tabel di samping.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int score = (int)numNilaiGuru.Value;
            string catatan = txtCatatanGuru.Text.Trim();
            string status = (score >= 75) ? "LULUS" : "TIDAK LULUS";

            try
            {
                if (Classdb.koneksi.State == ConnectionState.Closed) Classdb.koneksi.Open();

                string query = "INSERT INTO nilai_pkl (Ids, nilai_guru, catatan_guru, status_akhir) " +
                               "VALUES (@Ids, @Nilai, @Catatan, @Status) " +
                               "ON DUPLICATE KEY UPDATE " +
                               "nilai_guru = @Nilai, catatan_guru = @Catatan, status_akhir = @Status";

                using (var cmd = new MySqlCommand(query, Classdb.koneksi))
                {
                    cmd.Parameters.AddWithValue("@Ids", selectedIds);
                    cmd.Parameters.AddWithValue("@Nilai", score);
                    cmd.Parameters.AddWithValue("@Catatan", catatan);
                    cmd.Parameters.AddWithValue("@Status", status);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show($"Nilai untuk siswa NIS '{selectedIds}' berhasil disimpan!\nStatus: {status}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan nilai: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Classdb.koneksi.State == ConnectionState.Open) Classdb.koneksi.Close();
                LoadDataNilai();
            }
        }

        private void btnRefreshNilai_Click(object sender, EventArgs e)
        {
            LoadDataNilai();
        }

        private void tabControlGuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlGuru.SelectedTab == tabPenilaian)
                LoadDataNilai();
            else if (tabControlGuru.SelectedTab == tabSiswaBimbingan)
                LoadSiswaBimbingan();
            else if (tabControlGuru.SelectedTab == tabPresensiGuru)
                LoadPresensiGuru();
            else
                LoadData();
        }
    }
}

