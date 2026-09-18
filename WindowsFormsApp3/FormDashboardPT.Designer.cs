namespace WindowsFormsApp3
{
    partial class FormDashboardPT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblNamaPerusahaan = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.cardActiveStudents = new System.Windows.Forms.Panel();
            this.lblActiveStudents = new System.Windows.Forms.Label();
            this.lblActiveTitle = new System.Windows.Forms.Label();
            this.cardOnSite = new System.Windows.Forms.Panel();
            this.lblOnSiteCount = new System.Windows.Forms.Label();
            this.lblOnSiteTitle = new System.Windows.Forms.Label();
            this.cardPendingPresensi = new System.Windows.Forms.Panel();
            this.lblPendingPresensiCount = new System.Windows.Forms.Label();
            this.lblPendingPresensiTitle = new System.Windows.Forms.Label();
            this.tabControlPT = new System.Windows.Forms.TabControl();
            this.tabPresensi = new System.Windows.Forms.TabPage();
            this.pnlFilterPresensi = new System.Windows.Forms.Panel();
            this.btnRefreshPresensi = new System.Windows.Forms.Button();
            this.btnTolakPresensi = new System.Windows.Forms.Button();
            this.btnVerifikasiHadir = new System.Windows.Forms.Button();
            this.btnFilterPresensi = new System.Windows.Forms.Button();
            this.cmbStatusVerifikasi = new System.Windows.Forms.ComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.chkSemuaTanggal = new System.Windows.Forms.CheckBox();
            this.dtpTanggalPresensi = new System.Windows.Forms.DateTimePicker();
            this.lblFilterTanggal = new System.Windows.Forms.Label();
            this.dgvPresensi = new System.Windows.Forms.DataGridView();
            this.tabJurnal = new System.Windows.Forms.TabPage();
            this.btnRefreshJurnal = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.dgvJurnal = new System.Windows.Forms.DataGridView();
            this.tabPenilaianPT = new System.Windows.Forms.TabPage();
            this.dgvPenilaianPT = new System.Windows.Forms.DataGridView();
            this.pnlPenilaianPT = new System.Windows.Forms.Panel();
            this.btnRefreshNilaiPT = new System.Windows.Forms.Button();
            this.btnSimpanNilaiPT = new System.Windows.Forms.Button();
            this.txtCatatanPT = new System.Windows.Forms.TextBox();
            this.lblCatatanPT = new System.Windows.Forms.Label();
            this.numNilaiPT = new System.Windows.Forms.NumericUpDown();
            this.lblNilaiPTInput = new System.Windows.Forms.Label();
            this.lblSelectedSiswaPT = new System.Windows.Forms.Label();
            this.lblHeaderNilaiPT = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.cardActiveStudents.SuspendLayout();
            this.cardOnSite.SuspendLayout();
            this.cardPendingPresensi.SuspendLayout();
            this.tabControlPT.SuspendLayout();
            this.tabPresensi.SuspendLayout();
            this.pnlFilterPresensi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresensi)).BeginInit();
            this.tabJurnal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJurnal)).BeginInit();
            this.tabPenilaianPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenilaianPT)).BeginInit();
            this.pnlPenilaianPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNilaiPT)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.panelHeader.Controls.Add(this.btnLogout);
            this.panelHeader.Controls.Add(this.lblNamaPerusahaan);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(984, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(884, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 30);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Keluar";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblNamaPerusahaan
            // 
            this.lblNamaPerusahaan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamaPerusahaan.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNamaPerusahaan.ForeColor = System.Drawing.Color.White;
            this.lblNamaPerusahaan.Location = new System.Drawing.Point(580, 24);
            this.lblNamaPerusahaan.Name = "lblNamaPerusahaan";
            this.lblNamaPerusahaan.Size = new System.Drawing.Size(290, 21);
            this.lblNamaPerusahaan.TabIndex = 1;
            this.lblNamaPerusahaan.Text = "Halo, Perusahaan";
            this.lblNamaPerusahaan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(325, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DASHBOARD PERUSAHAAN (PT)";
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlStats.Controls.Add(this.cardActiveStudents);
            this.pnlStats.Controls.Add(this.cardOnSite);
            this.pnlStats.Controls.Add(this.cardPendingPresensi);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStats.Location = new System.Drawing.Point(0, 70);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlStats.Size = new System.Drawing.Size(984, 115);
            this.pnlStats.TabIndex = 1;
            // 
            // cardActiveStudents
            // 
            this.cardActiveStudents.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cardActiveStudents.Controls.Add(this.lblActiveStudents);
            this.cardActiveStudents.Controls.Add(this.lblActiveTitle);
            this.cardActiveStudents.Location = new System.Drawing.Point(15, 10);
            this.cardActiveStudents.Name = "cardActiveStudents";
            this.cardActiveStudents.Size = new System.Drawing.Size(295, 95);
            this.cardActiveStudents.TabIndex = 0;
            // 
            // lblActiveStudents
            // 
            this.lblActiveStudents.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblActiveStudents.ForeColor = System.Drawing.Color.White;
            this.lblActiveStudents.Location = new System.Drawing.Point(0, 32);
            this.lblActiveStudents.Name = "lblActiveStudents";
            this.lblActiveStudents.Size = new System.Drawing.Size(295, 45);
            this.lblActiveStudents.TabIndex = 1;
            this.lblActiveStudents.Text = "0";
            this.lblActiveStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActiveTitle
            // 
            this.lblActiveTitle.AutoSize = true;
            this.lblActiveTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblActiveTitle.ForeColor = System.Drawing.Color.White;
            this.lblActiveTitle.Location = new System.Drawing.Point(12, 10);
            this.lblActiveTitle.Name = "lblActiveTitle";
            this.lblActiveTitle.Size = new System.Drawing.Size(183, 17);
            this.lblActiveTitle.TabIndex = 0;
            this.lblActiveTitle.Text = "TOTAL SISWA PKL AKTIF DI PT";
            // 
            // cardOnSite
            // 
            this.cardOnSite.BackColor = System.Drawing.Color.SteelBlue;
            this.cardOnSite.Controls.Add(this.lblOnSiteCount);
            this.cardOnSite.Controls.Add(this.lblOnSiteTitle);
            this.cardOnSite.Location = new System.Drawing.Point(330, 10);
            this.cardOnSite.Name = "cardOnSite";
            this.cardOnSite.Size = new System.Drawing.Size(295, 95);
            this.cardOnSite.TabIndex = 1;
            // 
            // lblOnSiteCount
            // 
            this.lblOnSiteCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblOnSiteCount.ForeColor = System.Drawing.Color.White;
            this.lblOnSiteCount.Location = new System.Drawing.Point(0, 32);
            this.lblOnSiteCount.Name = "lblOnSiteCount";
            this.lblOnSiteCount.Size = new System.Drawing.Size(295, 45);
            this.lblOnSiteCount.TabIndex = 1;
            this.lblOnSiteCount.Text = "0";
            this.lblOnSiteCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOnSiteTitle
            // 
            this.lblOnSiteTitle.AutoSize = true;
            this.lblOnSiteTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblOnSiteTitle.ForeColor = System.Drawing.Color.White;
            this.lblOnSiteTitle.Location = new System.Drawing.Point(12, 10);
            this.lblOnSiteTitle.Name = "lblOnSiteTitle";
            this.lblOnSiteTitle.Size = new System.Drawing.Size(176, 17);
            this.lblOnSiteTitle.TabIndex = 0;
            this.lblOnSiteTitle.Text = "SISWA HADIR / ON-SITE HARI INI";
            // 
            // cardPendingPresensi
            // 
            this.cardPendingPresensi.BackColor = System.Drawing.Color.DarkOrange;
            this.cardPendingPresensi.Controls.Add(this.lblPendingPresensiCount);
            this.cardPendingPresensi.Controls.Add(this.lblPendingPresensiTitle);
            this.cardPendingPresensi.Location = new System.Drawing.Point(645, 10);
            this.cardPendingPresensi.Name = "cardPendingPresensi";
            this.cardPendingPresensi.Size = new System.Drawing.Size(320, 95);
            this.cardPendingPresensi.TabIndex = 2;
            // 
            // lblPendingPresensiCount
            // 
            this.lblPendingPresensiCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblPendingPresensiCount.ForeColor = System.Drawing.Color.White;
            this.lblPendingPresensiCount.Location = new System.Drawing.Point(0, 32);
            this.lblPendingPresensiCount.Name = "lblPendingPresensiCount";
            this.lblPendingPresensiCount.Size = new System.Drawing.Size(320, 45);
            this.lblPendingPresensiCount.TabIndex = 1;
            this.lblPendingPresensiCount.Text = "0";
            this.lblPendingPresensiCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPendingPresensiTitle
            // 
            this.lblPendingPresensiTitle.AutoSize = true;
            this.lblPendingPresensiTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPendingPresensiTitle.ForeColor = System.Drawing.Color.White;
            this.lblPendingPresensiTitle.Location = new System.Drawing.Point(12, 10);
            this.lblPendingPresensiTitle.Name = "lblPendingPresensiTitle";
            this.lblPendingPresensiTitle.Size = new System.Drawing.Size(206, 17);
            this.lblPendingPresensiTitle.TabIndex = 0;
            this.lblPendingPresensiTitle.Text = "KEHADIRAN MENUNGGU VERIFIKASI";
            // 
            // tabControlPT
            // 
            this.tabControlPT.Controls.Add(this.tabPresensi);
            this.tabControlPT.Controls.Add(this.tabJurnal);
            this.tabControlPT.Controls.Add(this.tabPenilaianPT);
            this.tabControlPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlPT.Location = new System.Drawing.Point(0, 185);
            this.tabControlPT.Name = "tabControlPT";
            this.tabControlPT.SelectedIndex = 0;
            this.tabControlPT.Size = new System.Drawing.Size(984, 396);
            this.tabControlPT.TabIndex = 2;
            this.tabControlPT.SelectedIndexChanged += new System.EventHandler(this.tabControlPT_SelectedIndexChanged);
            // 
            // tabPresensi
            // 
            this.tabPresensi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabPresensi.Controls.Add(this.pnlFilterPresensi);
            this.tabPresensi.Controls.Add(this.dgvPresensi);
            this.tabPresensi.Location = new System.Drawing.Point(4, 26);
            this.tabPresensi.Name = "tabPresensi";
            this.tabPresensi.Padding = new System.Windows.Forms.Padding(15);
            this.tabPresensi.Size = new System.Drawing.Size(976, 366);
            this.tabPresensi.TabIndex = 0;
            this.tabPresensi.Text = "Verifikasi Kehadiran (Presensi)";
            // 
            // pnlFilterPresensi
            // 
            this.pnlFilterPresensi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilterPresensi.BackColor = System.Drawing.Color.White;
            this.pnlFilterPresensi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilterPresensi.Controls.Add(this.btnRefreshPresensi);
            this.pnlFilterPresensi.Controls.Add(this.btnTolakPresensi);
            this.pnlFilterPresensi.Controls.Add(this.btnVerifikasiHadir);
            this.pnlFilterPresensi.Controls.Add(this.btnFilterPresensi);
            this.pnlFilterPresensi.Controls.Add(this.cmbStatusVerifikasi);
            this.pnlFilterPresensi.Controls.Add(this.lblFilterStatus);
            this.pnlFilterPresensi.Controls.Add(this.chkSemuaTanggal);
            this.pnlFilterPresensi.Controls.Add(this.dtpTanggalPresensi);
            this.pnlFilterPresensi.Controls.Add(this.lblFilterTanggal);
            this.pnlFilterPresensi.Location = new System.Drawing.Point(15, 12);
            this.pnlFilterPresensi.Name = "pnlFilterPresensi";
            this.pnlFilterPresensi.Size = new System.Drawing.Size(946, 50);
            this.pnlFilterPresensi.TabIndex = 0;
            // 
            // btnRefreshPresensi
            // 
            this.btnRefreshPresensi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshPresensi.BackColor = System.Drawing.Color.SlateGray;
            this.btnRefreshPresensi.FlatAppearance.BorderSize = 0;
            this.btnRefreshPresensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPresensi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefreshPresensi.ForeColor = System.Drawing.Color.White;
            this.btnRefreshPresensi.Location = new System.Drawing.Point(858, 10);
            this.btnRefreshPresensi.Name = "btnRefreshPresensi";
            this.btnRefreshPresensi.Size = new System.Drawing.Size(75, 28);
            this.btnRefreshPresensi.TabIndex = 8;
            this.btnRefreshPresensi.Text = "Refresh";
            this.btnRefreshPresensi.UseVisualStyleBackColor = false;
            this.btnRefreshPresensi.Click += new System.EventHandler(this.btnRefreshPresensi_Click);
            // 
            // btnTolakPresensi
            // 
            this.btnTolakPresensi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTolakPresensi.BackColor = System.Drawing.Color.IndianRed;
            this.btnTolakPresensi.FlatAppearance.BorderSize = 0;
            this.btnTolakPresensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTolakPresensi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnTolakPresensi.ForeColor = System.Drawing.Color.White;
            this.btnTolakPresensi.Location = new System.Drawing.Point(745, 10);
            this.btnTolakPresensi.Name = "btnTolakPresensi";
            this.btnTolakPresensi.Size = new System.Drawing.Size(105, 28);
            this.btnTolakPresensi.TabIndex = 7;
            this.btnTolakPresensi.Text = "Tolak / Catatan";
            this.btnTolakPresensi.UseVisualStyleBackColor = false;
            this.btnTolakPresensi.Click += new System.EventHandler(this.btnTolakPresensi_Click);
            // 
            // btnVerifikasiHadir
            // 
            this.btnVerifikasiHadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerifikasiHadir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnVerifikasiHadir.FlatAppearance.BorderSize = 0;
            this.btnVerifikasiHadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifikasiHadir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnVerifikasiHadir.ForeColor = System.Drawing.Color.White;
            this.btnVerifikasiHadir.Location = new System.Drawing.Point(620, 10);
            this.btnVerifikasiHadir.Name = "btnVerifikasiHadir";
            this.btnVerifikasiHadir.Size = new System.Drawing.Size(118, 28);
            this.btnVerifikasiHadir.TabIndex = 6;
            this.btnVerifikasiHadir.Text = "Verifikasi Hadir";
            this.btnVerifikasiHadir.UseVisualStyleBackColor = false;
            this.btnVerifikasiHadir.Click += new System.EventHandler(this.btnVerifikasiHadir_Click);
            // 
            // btnFilterPresensi
            // 
            this.btnFilterPresensi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFilterPresensi.FlatAppearance.BorderSize = 0;
            this.btnFilterPresensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterPresensi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterPresensi.ForeColor = System.Drawing.Color.White;
            this.btnFilterPresensi.Location = new System.Drawing.Point(530, 10);
            this.btnFilterPresensi.Name = "btnFilterPresensi";
            this.btnFilterPresensi.Size = new System.Drawing.Size(70, 28);
            this.btnFilterPresensi.TabIndex = 5;
            this.btnFilterPresensi.Text = "Terapkan";
            this.btnFilterPresensi.UseVisualStyleBackColor = false;
            this.btnFilterPresensi.Click += new System.EventHandler(this.btnFilterPresensi_Click);
            // 
            // cmbStatusVerifikasi
            // 
            this.cmbStatusVerifikasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusVerifikasi.FormattingEnabled = true;
            this.cmbStatusVerifikasi.Items.AddRange(new object[] {
            "Semua",
            "Menunggu",
            "Diverifikasi",
            "Ditolak"});
            this.cmbStatusVerifikasi.Location = new System.Drawing.Point(405, 12);
            this.cmbStatusVerifikasi.Name = "cmbStatusVerifikasi";
            this.cmbStatusVerifikasi.Size = new System.Drawing.Size(115, 25);
            this.cmbStatusVerifikasi.TabIndex = 4;
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterStatus.Location = new System.Drawing.Point(355, 16);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(42, 15);
            this.lblFilterStatus.TabIndex = 3;
            this.lblFilterStatus.Text = "Status:";
            // 
            // chkSemuaTanggal
            // 
            this.chkSemuaTanggal.AutoSize = true;
            this.chkSemuaTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkSemuaTanggal.Location = new System.Drawing.Point(235, 16);
            this.chkSemuaTanggal.Name = "chkSemuaTanggal";
            this.chkSemuaTanggal.Size = new System.Drawing.Size(107, 19);
            this.chkSemuaTanggal.TabIndex = 2;
            this.chkSemuaTanggal.Text = "Semua Tanggal";
            this.chkSemuaTanggal.UseVisualStyleBackColor = true;
            this.chkSemuaTanggal.CheckedChanged += new System.EventHandler(this.chkSemuaTanggal_CheckedChanged);
            // 
            // dtpTanggalPresensi
            // 
            this.dtpTanggalPresensi.CustomFormat = "dd/MM/yyyy";
            this.dtpTanggalPresensi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalPresensi.Location = new System.Drawing.Point(75, 12);
            this.dtpTanggalPresensi.Name = "dtpTanggalPresensi";
            this.dtpTanggalPresensi.Size = new System.Drawing.Size(150, 25);
            this.dtpTanggalPresensi.TabIndex = 1;
            // 
            // lblFilterTanggal
            // 
            this.lblFilterTanggal.AutoSize = true;
            this.lblFilterTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterTanggal.Location = new System.Drawing.Point(12, 16);
            this.lblFilterTanggal.Name = "lblFilterTanggal";
            this.lblFilterTanggal.Size = new System.Drawing.Size(52, 15);
            this.lblFilterTanggal.TabIndex = 0;
            this.lblFilterTanggal.Text = "Tanggal:";
            // 
            // dgvPresensi
            // 
            this.dgvPresensi.AllowUserToAddRows = false;
            this.dgvPresensi.AllowUserToDeleteRows = false;
            this.dgvPresensi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPresensi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPresensi.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPresensi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPresensi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresensi.Location = new System.Drawing.Point(15, 70);
            this.dgvPresensi.MultiSelect = false;
            this.dgvPresensi.Name = "dgvPresensi";
            this.dgvPresensi.ReadOnly = true;
            this.dgvPresensi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPresensi.Size = new System.Drawing.Size(946, 280);
            this.dgvPresensi.TabIndex = 1;
            // 
            // tabJurnal
            // 
            this.tabJurnal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabJurnal.Controls.Add(this.btnRefreshJurnal);
            this.tabJurnal.Controls.Add(this.btnViewDetails);
            this.tabJurnal.Controls.Add(this.dgvJurnal);
            this.tabJurnal.Location = new System.Drawing.Point(4, 26);
            this.tabJurnal.Name = "tabJurnal";
            this.tabJurnal.Padding = new System.Windows.Forms.Padding(15);
            this.tabJurnal.Size = new System.Drawing.Size(976, 366);
            this.tabJurnal.TabIndex = 1;
            this.tabJurnal.Text = "Monitoring Jurnal Siswa";
            // 
            // btnRefreshJurnal
            // 
            this.btnRefreshJurnal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshJurnal.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRefreshJurnal.FlatAppearance.BorderSize = 0;
            this.btnRefreshJurnal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshJurnal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRefreshJurnal.ForeColor = System.Drawing.Color.White;
            this.btnRefreshJurnal.Location = new System.Drawing.Point(861, 15);
            this.btnRefreshJurnal.Name = "btnRefreshJurnal";
            this.btnRefreshJurnal.Size = new System.Drawing.Size(100, 32);
            this.btnRefreshJurnal.TabIndex = 2;
            this.btnRefreshJurnal.Text = "Segarkan";
            this.btnRefreshJurnal.UseVisualStyleBackColor = false;
            this.btnRefreshJurnal.Click += new System.EventHandler(this.btnRefreshJurnal_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(15, 15);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(140, 32);
            this.btnViewDetails.TabIndex = 1;
            this.btnViewDetails.Text = "Lihat Detail Jurnal";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // dgvJurnal
            // 
            this.dgvJurnal.AllowUserToAddRows = false;
            this.dgvJurnal.AllowUserToDeleteRows = false;
            this.dgvJurnal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJurnal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJurnal.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJurnal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJurnal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJurnal.Location = new System.Drawing.Point(15, 58);
            this.dgvJurnal.MultiSelect = false;
            this.dgvJurnal.Name = "dgvJurnal";
            this.dgvJurnal.ReadOnly = true;
            this.dgvJurnal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJurnal.Size = new System.Drawing.Size(946, 290);
            this.dgvJurnal.TabIndex = 0;
            // 
            // tabPenilaianPT
            // 
            this.tabPenilaianPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabPenilaianPT.Controls.Add(this.dgvPenilaianPT);
            this.tabPenilaianPT.Controls.Add(this.pnlPenilaianPT);
            this.tabPenilaianPT.Location = new System.Drawing.Point(4, 26);
            this.tabPenilaianPT.Name = "tabPenilaianPT";
            this.tabPenilaianPT.Padding = new System.Windows.Forms.Padding(15);
            this.tabPenilaianPT.Size = new System.Drawing.Size(976, 366);
            this.tabPenilaianPT.TabIndex = 2;
            this.tabPenilaianPT.Text = "Penilaian Pembimbing Industri";
            // 
            // dgvPenilaianPT
            // 
            this.dgvPenilaianPT.AllowUserToAddRows = false;
            this.dgvPenilaianPT.AllowUserToDeleteRows = false;
            this.dgvPenilaianPT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPenilaianPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPenilaianPT.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPenilaianPT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPenilaianPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenilaianPT.Location = new System.Drawing.Point(15, 15);
            this.dgvPenilaianPT.MultiSelect = false;
            this.dgvPenilaianPT.Name = "dgvPenilaianPT";
            this.dgvPenilaianPT.ReadOnly = true;
            this.dgvPenilaianPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPenilaianPT.Size = new System.Drawing.Size(590, 335);
            this.dgvPenilaianPT.TabIndex = 0;
            this.dgvPenilaianPT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPenilaianPT_CellClick);
            // 
            // pnlPenilaianPT
            // 
            this.pnlPenilaianPT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPenilaianPT.BackColor = System.Drawing.Color.White;
            this.pnlPenilaianPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPenilaianPT.Controls.Add(this.btnRefreshNilaiPT);
            this.pnlPenilaianPT.Controls.Add(this.btnSimpanNilaiPT);
            this.pnlPenilaianPT.Controls.Add(this.txtCatatanPT);
            this.pnlPenilaianPT.Controls.Add(this.lblCatatanPT);
            this.pnlPenilaianPT.Controls.Add(this.numNilaiPT);
            this.pnlPenilaianPT.Controls.Add(this.lblNilaiPTInput);
            this.pnlPenilaianPT.Controls.Add(this.lblSelectedSiswaPT);
            this.pnlPenilaianPT.Controls.Add(this.lblHeaderNilaiPT);
            this.pnlPenilaianPT.Location = new System.Drawing.Point(620, 15);
            this.pnlPenilaianPT.Name = "pnlPenilaianPT";
            this.pnlPenilaianPT.Padding = new System.Windows.Forms.Padding(15);
            this.pnlPenilaianPT.Size = new System.Drawing.Size(341, 335);
            this.pnlPenilaianPT.TabIndex = 1;
            // 
            // btnRefreshNilaiPT
            // 
            this.btnRefreshNilaiPT.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRefreshNilaiPT.FlatAppearance.BorderSize = 0;
            this.btnRefreshNilaiPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshNilaiPT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRefreshNilaiPT.ForeColor = System.Drawing.Color.White;
            this.btnRefreshNilaiPT.Location = new System.Drawing.Point(18, 285);
            this.btnRefreshNilaiPT.Name = "btnRefreshNilaiPT";
            this.btnRefreshNilaiPT.Size = new System.Drawing.Size(140, 34);
            this.btnRefreshNilaiPT.TabIndex = 7;
            this.btnRefreshNilaiPT.Text = "Batal / Refresh";
            this.btnRefreshNilaiPT.UseVisualStyleBackColor = false;
            this.btnRefreshNilaiPT.Click += new System.EventHandler(this.btnRefreshNilaiPT_Click);
            // 
            // btnSimpanNilaiPT
            // 
            this.btnSimpanNilaiPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSimpanNilaiPT.FlatAppearance.BorderSize = 0;
            this.btnSimpanNilaiPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpanNilaiPT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSimpanNilaiPT.ForeColor = System.Drawing.Color.White;
            this.btnSimpanNilaiPT.Location = new System.Drawing.Point(170, 285);
            this.btnSimpanNilaiPT.Name = "btnSimpanNilaiPT";
            this.btnSimpanNilaiPT.Size = new System.Drawing.Size(150, 34);
            this.btnSimpanNilaiPT.TabIndex = 6;
            this.btnSimpanNilaiPT.Text = "Simpan Nilai PT";
            this.btnSimpanNilaiPT.UseVisualStyleBackColor = false;
            this.btnSimpanNilaiPT.Click += new System.EventHandler(this.btnSimpanNilaiPT_Click);
            // 
            // txtCatatanPT
            // 
            this.txtCatatanPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatatanPT.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCatatanPT.Location = new System.Drawing.Point(18, 205);
            this.txtCatatanPT.Multiline = true;
            this.txtCatatanPT.Name = "txtCatatanPT";
            this.txtCatatanPT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCatatanPT.Size = new System.Drawing.Size(302, 65);
            this.txtCatatanPT.TabIndex = 5;
            // 
            // lblCatatanPT
            // 
            this.lblCatatanPT.AutoSize = true;
            this.lblCatatanPT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCatatanPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblCatatanPT.Location = new System.Drawing.Point(15, 185);
            this.lblCatatanPT.Name = "lblCatatanPT";
            this.lblCatatanPT.Size = new System.Drawing.Size(175, 17);
            this.lblCatatanPT.TabIndex = 4;
            this.lblCatatanPT.Text = "Catatan Kinerja Perusahaan:";
            // 
            // numNilaiPT
            // 
            this.numNilaiPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numNilaiPT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.numNilaiPT.Location = new System.Drawing.Point(18, 145);
            this.numNilaiPT.Name = "numNilaiPT";
            this.numNilaiPT.Size = new System.Drawing.Size(120, 29);
            this.numNilaiPT.TabIndex = 3;
            // 
            // lblNilaiPTInput
            // 
            this.lblNilaiPTInput.AutoSize = true;
            this.lblNilaiPTInput.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNilaiPTInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblNilaiPTInput.Location = new System.Drawing.Point(15, 122);
            this.lblNilaiPTInput.Name = "lblNilaiPTInput";
            this.lblNilaiPTInput.Size = new System.Drawing.Size(183, 17);
            this.lblNilaiPTInput.TabIndex = 2;
            this.lblNilaiPTInput.Text = "Nilai Industri PT (Skala 0-100):";
            // 
            // lblSelectedSiswaPT
            // 
            this.lblSelectedSiswaPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.lblSelectedSiswaPT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelectedSiswaPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblSelectedSiswaPT.Location = new System.Drawing.Point(18, 45);
            this.lblSelectedSiswaPT.Name = "lblSelectedSiswaPT";
            this.lblSelectedSiswaPT.Padding = new System.Windows.Forms.Padding(8);
            this.lblSelectedSiswaPT.Size = new System.Drawing.Size(302, 65);
            this.lblSelectedSiswaPT.TabIndex = 1;
            this.lblSelectedSiswaPT.Text = "Pilih siswa di tabel untuk memberi nilai kinerja.";
            // 
            // lblHeaderNilaiPT
            // 
            this.lblHeaderNilaiPT.AutoSize = true;
            this.lblHeaderNilaiPT.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblHeaderNilaiPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblHeaderNilaiPT.Location = new System.Drawing.Point(15, 12);
            this.lblHeaderNilaiPT.Name = "lblHeaderNilaiPT";
            this.lblHeaderNilaiPT.Size = new System.Drawing.Size(186, 21);
            this.lblHeaderNilaiPT.TabIndex = 0;
            this.lblHeaderNilaiPT.Text = "Form Penilaian Industri";
            // 
            // FormDashboardPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.tabControlPT);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormDashboardPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Pembimbing Lapangan Perusahaan (PT)";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.cardActiveStudents.ResumeLayout(false);
            this.cardActiveStudents.PerformLayout();
            this.cardOnSite.ResumeLayout(false);
            this.cardOnSite.PerformLayout();
            this.cardPendingPresensi.ResumeLayout(false);
            this.cardPendingPresensi.PerformLayout();
            this.tabControlPT.ResumeLayout(false);
            this.tabPresensi.ResumeLayout(false);
            this.pnlFilterPresensi.ResumeLayout(false);
            this.pnlFilterPresensi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresensi)).EndInit();
            this.tabJurnal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJurnal)).EndInit();
            this.tabPenilaianPT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenilaianPT)).EndInit();
            this.pnlPenilaianPT.ResumeLayout(false);
            this.pnlPenilaianPT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNilaiPT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblNamaPerusahaan;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel cardActiveStudents;
        private System.Windows.Forms.Label lblActiveStudents;
        private System.Windows.Forms.Label lblActiveTitle;
        private System.Windows.Forms.Panel cardOnSite;
        private System.Windows.Forms.Label lblOnSiteCount;
        private System.Windows.Forms.Label lblOnSiteTitle;
        private System.Windows.Forms.Panel cardPendingPresensi;
        private System.Windows.Forms.Label lblPendingPresensiCount;
        private System.Windows.Forms.Label lblPendingPresensiTitle;
        private System.Windows.Forms.TabControl tabControlPT;
        private System.Windows.Forms.TabPage tabPresensi;
        private System.Windows.Forms.Panel pnlFilterPresensi;
        private System.Windows.Forms.Label lblFilterTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggalPresensi;
        private System.Windows.Forms.CheckBox chkSemuaTanggal;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cmbStatusVerifikasi;
        private System.Windows.Forms.Button btnFilterPresensi;
        private System.Windows.Forms.Button btnVerifikasiHadir;
        private System.Windows.Forms.Button btnTolakPresensi;
        private System.Windows.Forms.Button btnRefreshPresensi;
        private System.Windows.Forms.DataGridView dgvPresensi;
        private System.Windows.Forms.TabPage tabJurnal;
        private System.Windows.Forms.Button btnRefreshJurnal;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.DataGridView dgvJurnal;
        private System.Windows.Forms.TabPage tabPenilaianPT;
        private System.Windows.Forms.DataGridView dgvPenilaianPT;
        private System.Windows.Forms.Panel pnlPenilaianPT;
        private System.Windows.Forms.Label lblHeaderNilaiPT;
        private System.Windows.Forms.Label lblSelectedSiswaPT;
        private System.Windows.Forms.Label lblNilaiPTInput;
        private System.Windows.Forms.NumericUpDown numNilaiPT;
        private System.Windows.Forms.Label lblCatatanPT;
        private System.Windows.Forms.TextBox txtCatatanPT;
        private System.Windows.Forms.Button btnSimpanNilaiPT;
        private System.Windows.Forms.Button btnRefreshNilaiPT;
    }
}

