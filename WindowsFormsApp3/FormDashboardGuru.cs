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

        public FormDashboardGuru(string nama = "Guru")
        {
            InitializeComponent();
            lblTitle.Text = "DASHBOARD GURU PKL";
            lblNamaPengguna.Text = $"Halo, {nama}";
            LoadData();
            LoadDataNilai();
            BuildSidebar();
        }

        private Button btnNavJurnal;
        private Button btnNavPenilaian;

        private void BuildSidebar()
        {
            // Hide TabControl Headers
            tabControlGuru.Appearance = TabAppearance.FlatButtons;
            tabControlGuru.ItemSize = new Size(0, 1);
            tabControlGuru.SizeMode = TabSizeMode.Fixed;

            Panel pnlSidebar = new Panel();
            pnlSidebar.BackColor = Color.FromArgb(15, 23, 42); // Match Form5
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
                tabControlGuru.SelectedIndex = 0;
                SetActiveNavButton(btnNavJurnal);
            };
            pnlSidebar.Controls.Add(btnNavJurnal);
            btnNavJurnal.SendToBack();

            btnNavPenilaian = CreateSidebarButton("Penilaian");
            btnNavPenilaian.Click += (s, e) => {
                tabControlGuru.SelectedIndex = 1;
                SetActiveNavButton(btnNavPenilaian);
            };
            pnlSidebar.Controls.Add(btnNavPenilaian);
            btnNavPenilaian.SendToBack();

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
            btn.ForeColor = Color.WhiteSmoke;
            btn.Font = new Font("Segoe UI", 11F);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(20, 0, 0, 0);
            return btn;
        }

        private string GetGuruFilter()
        {
            // Scope by students under this guru (siswa.Id_Gr = Classdb.idUserLogin)
            if (string.IsNullOrWhiteSpace(Classdb.idUserLogin)) return "";
            return " AND j.Ids IN (SELECT Ids FROM siswa WHERE Id_Gr = " + Classdb.idUserLogin + ")";
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
            if (dgvRecent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih jurnal terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show("Setujui jurnal ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var id = dgvRecent.SelectedRows[0].Cells["id_laporan"].Value.ToString();
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
            if (dgvRecent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih jurnal terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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

            var id = dgvRecent.SelectedRows[0].Cells["id_laporan"].Value.ToString();
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

        private void LoadData()
        {
            try
            {
                string guruFilter = GetGuruFilter();

                // summary counts (scoped to guru)
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

                // recent jurnal (scoped to guru, include siswa name)
                Classdb.crud("SELECT j.id_laporan, s.Nama AS NamaSiswa, j.tanggal, j.kegiatan, j.status, j.catatan " +
                             "FROM jurnal_siswa j LEFT JOIN siswa s ON j.Ids = s.Ids WHERE 1=1" + guruFilter + " ORDER BY j.tanggal DESC LIMIT 50");
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
        // FITUR PENILAIAN SISWA OLEH GURU
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
                string statusAkhir = row.Cells["StatusAkhir"].Value.ToString();

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
            {
                LoadDataNilai();
            }
            else
            {
                LoadData();
            }
        }
    }
}

