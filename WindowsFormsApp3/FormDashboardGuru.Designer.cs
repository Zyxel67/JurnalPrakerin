namespace WindowsFormsApp3
{
    partial class FormDashboardGuru
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblNamaPengguna = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControlGuru = new System.Windows.Forms.TabControl();
            this.tabJurnal = new System.Windows.Forms.TabPage();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.cardPending = new System.Windows.Forms.Panel();
            this.lblPendingCount = new System.Windows.Forms.Label();
            this.lblPendingTitle = new System.Windows.Forms.Label();
            this.cardApproved = new System.Windows.Forms.Panel();
            this.lblApprovedCount = new System.Windows.Forms.Label();
            this.lblApprovedTitle = new System.Windows.Forms.Label();
            this.cardRevisions = new System.Windows.Forms.Panel();
            this.lblRevisionCount = new System.Windows.Forms.Label();
            this.lblRevisionTitle = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvRecent = new System.Windows.Forms.DataGridView();
            this.lblRecent = new System.Windows.Forms.Label();
            this.tabPenilaian = new System.Windows.Forms.TabPage();
            this.dgvPenilaian = new System.Windows.Forms.DataGridView();
            this.pnlPenilaianForm = new System.Windows.Forms.Panel();
            this.btnRefreshNilai = new System.Windows.Forms.Button();
            this.btnSimpanNilai = new System.Windows.Forms.Button();
            this.lblStatusPreview = new System.Windows.Forms.Label();
            this.lblStatusLabel = new System.Windows.Forms.Label();
            this.txtCatatanGuru = new System.Windows.Forms.TextBox();
            this.lblCatatan = new System.Windows.Forms.Label();
            this.numNilaiGuru = new System.Windows.Forms.NumericUpDown();
            this.lblNilai = new System.Windows.Forms.Label();
            this.lblSelectedSiswa = new System.Windows.Forms.Label();
            this.lblPenilaianHeader = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.tabControlGuru.SuspendLayout();
            this.tabJurnal.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.cardPending.SuspendLayout();
            this.cardApproved.SuspendLayout();
            this.cardRevisions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
            this.tabPenilaian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenilaian)).BeginInit();
            this.pnlPenilaianForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNilaiGuru)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.panelHeader.Controls.Add(this.btnLogout);
            this.panelHeader.Controls.Add(this.lblNamaPengguna);
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
            // lblNamaPengguna
            // 
            this.lblNamaPengguna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamaPengguna.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNamaPengguna.ForeColor = System.Drawing.Color.White;
            this.lblNamaPengguna.Location = new System.Drawing.Point(580, 24);
            this.lblNamaPengguna.Name = "lblNamaPengguna";
            this.lblNamaPengguna.Size = new System.Drawing.Size(290, 21);
            this.lblNamaPengguna.TabIndex = 1;
            this.lblNamaPengguna.Text = "Halo, Guru";
            this.lblNamaPengguna.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(264, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DASHBOARD GURU PKL";
            // 
            // tabControlGuru
            // 
            this.tabControlGuru.Controls.Add(this.tabJurnal);
            this.tabControlGuru.Controls.Add(this.tabPenilaian);
            this.tabControlGuru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlGuru.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlGuru.Location = new System.Drawing.Point(0, 70);
            this.tabControlGuru.Name = "tabControlGuru";
            this.tabControlGuru.SelectedIndex = 0;
            this.tabControlGuru.Size = new System.Drawing.Size(984, 511);
            this.tabControlGuru.TabIndex = 1;
            this.tabControlGuru.SelectedIndexChanged += new System.EventHandler(this.tabControlGuru_SelectedIndexChanged);
            // 
            // tabJurnal
            // 
            this.tabJurnal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabJurnal.Controls.Add(this.pnlSummary);
            this.tabJurnal.Controls.Add(this.btnApprove);
            this.tabJurnal.Controls.Add(this.btnReject);
            this.tabJurnal.Controls.Add(this.btnRefresh);
            this.tabJurnal.Controls.Add(this.dgvRecent);
            this.tabJurnal.Controls.Add(this.lblRecent);
            this.tabJurnal.Location = new System.Drawing.Point(4, 26);
            this.tabJurnal.Name = "tabJurnal";
            this.tabJurnal.Padding = new System.Windows.Forms.Padding(15);
            this.tabJurnal.Size = new System.Drawing.Size(976, 481);
            this.tabJurnal.TabIndex = 0;
            this.tabJurnal.Text = "Verifikasi Jurnal Siswa";
            // 
            // pnlSummary
            // 
            this.pnlSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSummary.Controls.Add(this.cardPending);
            this.pnlSummary.Controls.Add(this.cardApproved);
            this.pnlSummary.Controls.Add(this.cardRevisions);
            this.pnlSummary.Location = new System.Drawing.Point(15, 15);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(946, 110);
            this.pnlSummary.TabIndex = 0;
            // 
            // cardPending
            // 
            this.cardPending.BackColor = System.Drawing.Color.DarkOrange;
            this.cardPending.Controls.Add(this.lblPendingCount);
            this.cardPending.Controls.Add(this.lblPendingTitle);
            this.cardPending.Location = new System.Drawing.Point(0, 0);
            this.cardPending.Name = "cardPending";
            this.cardPending.Size = new System.Drawing.Size(290, 110);
            this.cardPending.TabIndex = 0;
            // 
            // lblPendingCount
            // 
            this.lblPendingCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblPendingCount.ForeColor = System.Drawing.Color.White;
            this.lblPendingCount.Location = new System.Drawing.Point(0, 35);
            this.lblPendingCount.Name = "lblPendingCount";
            this.lblPendingCount.Size = new System.Drawing.Size(290, 50);
            this.lblPendingCount.TabIndex = 1;
            this.lblPendingCount.Text = "0";
            this.lblPendingCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPendingTitle
            // 
            this.lblPendingTitle.AutoSize = true;
            this.lblPendingTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPendingTitle.ForeColor = System.Drawing.Color.White;
            this.lblPendingTitle.Location = new System.Drawing.Point(12, 12);
            this.lblPendingTitle.Name = "lblPendingTitle";
            this.lblPendingTitle.Size = new System.Drawing.Size(130, 17);
            this.lblPendingTitle.TabIndex = 0;
            this.lblPendingTitle.Text = "JURNAL MENUNGGU";
            // 
            // cardApproved
            // 
            this.cardApproved.BackColor = System.Drawing.Color.RoyalBlue;
            this.cardApproved.Controls.Add(this.lblApprovedCount);
            this.cardApproved.Controls.Add(this.lblApprovedTitle);
            this.cardApproved.Location = new System.Drawing.Point(325, 0);
            this.cardApproved.Name = "cardApproved";
            this.cardApproved.Size = new System.Drawing.Size(290, 110);
            this.cardApproved.TabIndex = 1;
            // 
            // lblApprovedCount
            // 
            this.lblApprovedCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblApprovedCount.ForeColor = System.Drawing.Color.White;
            this.lblApprovedCount.Location = new System.Drawing.Point(0, 35);
            this.lblApprovedCount.Name = "lblApprovedCount";
            this.lblApprovedCount.Size = new System.Drawing.Size(290, 50);
            this.lblApprovedCount.TabIndex = 1;
            this.lblApprovedCount.Text = "0";
            this.lblApprovedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApprovedTitle
            // 
            this.lblApprovedTitle.AutoSize = true;
            this.lblApprovedTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblApprovedTitle.ForeColor = System.Drawing.Color.White;
            this.lblApprovedTitle.Location = new System.Drawing.Point(12, 12);
            this.lblApprovedTitle.Name = "lblApprovedTitle";
            this.lblApprovedTitle.Size = new System.Drawing.Size(121, 17);
            this.lblApprovedTitle.TabIndex = 0;
            this.lblApprovedTitle.Text = "JURNAL DISETUJUI";
            // 
            // cardRevisions
            // 
            this.cardRevisions.BackColor = System.Drawing.Color.MediumVioletRed;
            this.cardRevisions.Controls.Add(this.lblRevisionCount);
            this.cardRevisions.Controls.Add(this.lblRevisionTitle);
            this.cardRevisions.Location = new System.Drawing.Point(650, 0);
            this.cardRevisions.Name = "cardRevisions";
            this.cardRevisions.Size = new System.Drawing.Size(290, 110);
            this.cardRevisions.TabIndex = 2;
            // 
            // lblRevisionCount
            // 
            this.lblRevisionCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblRevisionCount.ForeColor = System.Drawing.Color.White;
            this.lblRevisionCount.Location = new System.Drawing.Point(0, 35);
            this.lblRevisionCount.Name = "lblRevisionCount";
            this.lblRevisionCount.Size = new System.Drawing.Size(290, 50);
            this.lblRevisionCount.TabIndex = 1;
            this.lblRevisionCount.Text = "0";
            this.lblRevisionCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRevisionTitle
            // 
            this.lblRevisionTitle.AutoSize = true;
            this.lblRevisionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRevisionTitle.ForeColor = System.Drawing.Color.White;
            this.lblRevisionTitle.Location = new System.Drawing.Point(12, 12);
            this.lblRevisionTitle.Name = "lblRevisionTitle";
            this.lblRevisionTitle.Size = new System.Drawing.Size(89, 17);
            this.lblRevisionTitle.TabIndex = 0;
            this.lblRevisionTitle.Text = "PERLU REVISI";
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(15, 140);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(120, 32);
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "Setujui Jurnal";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.IndianRed;
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(145, 140);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(120, 32);
            this.btnReject.TabIndex = 2;
            this.btnReject.Text = "Minta Revisi";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(861, 140);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 32);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Segarkan";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvRecent
            // 
            this.dgvRecent.AllowUserToAddRows = false;
            this.dgvRecent.AllowUserToDeleteRows = false;
            this.dgvRecent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecent.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecent.Location = new System.Drawing.Point(15, 185);
            this.dgvRecent.MultiSelect = false;
            this.dgvRecent.Name = "dgvRecent";
            this.dgvRecent.ReadOnly = true;
            this.dgvRecent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecent.Size = new System.Drawing.Size(946, 280);
            this.dgvRecent.TabIndex = 4;
            // 
            // lblRecent
            // 
            this.lblRecent.AutoSize = true;
            this.lblRecent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRecent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblRecent.Location = new System.Drawing.Point(280, 146);
            this.lblRecent.Name = "lblRecent";
            this.lblRecent.Size = new System.Drawing.Size(183, 20);
            this.lblRecent.TabIndex = 5;
            this.lblRecent.Text = "Daftar Jurnal Bimbingan";
            // 
            // tabPenilaian
            // 
            this.tabPenilaian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabPenilaian.Controls.Add(this.dgvPenilaian);
            this.tabPenilaian.Controls.Add(this.pnlPenilaianForm);
            this.tabPenilaian.Location = new System.Drawing.Point(4, 26);
            this.tabPenilaian.Name = "tabPenilaian";
            this.tabPenilaian.Padding = new System.Windows.Forms.Padding(15);
            this.tabPenilaian.Size = new System.Drawing.Size(976, 481);
            this.tabPenilaian.TabIndex = 1;
            this.tabPenilaian.Text = "Penilaian Siswa PKL";
            // 
            // dgvPenilaian
            // 
            this.dgvPenilaian.AllowUserToAddRows = false;
            this.dgvPenilaian.AllowUserToDeleteRows = false;
            this.dgvPenilaian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPenilaian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPenilaian.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPenilaian.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPenilaian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenilaian.Location = new System.Drawing.Point(15, 15);
            this.dgvPenilaian.MultiSelect = false;
            this.dgvPenilaian.Name = "dgvPenilaian";
            this.dgvPenilaian.ReadOnly = true;
            this.dgvPenilaian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPenilaian.Size = new System.Drawing.Size(590, 450);
            this.dgvPenilaian.TabIndex = 0;
            this.dgvPenilaian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPenilaian_CellClick);
            // 
            // pnlPenilaianForm
            // 
            this.pnlPenilaianForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPenilaianForm.BackColor = System.Drawing.Color.White;
            this.pnlPenilaianForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPenilaianForm.Controls.Add(this.btnRefreshNilai);
            this.pnlPenilaianForm.Controls.Add(this.btnSimpanNilai);
            this.pnlPenilaianForm.Controls.Add(this.lblStatusPreview);
            this.pnlPenilaianForm.Controls.Add(this.lblStatusLabel);
            this.pnlPenilaianForm.Controls.Add(this.txtCatatanGuru);
            this.pnlPenilaianForm.Controls.Add(this.lblCatatan);
            this.pnlPenilaianForm.Controls.Add(this.numNilaiGuru);
            this.pnlPenilaianForm.Controls.Add(this.lblNilai);
            this.pnlPenilaianForm.Controls.Add(this.lblSelectedSiswa);
            this.pnlPenilaianForm.Controls.Add(this.lblPenilaianHeader);
            this.pnlPenilaianForm.Location = new System.Drawing.Point(620, 15);
            this.pnlPenilaianForm.Name = "pnlPenilaianForm";
            this.pnlPenilaianForm.Padding = new System.Windows.Forms.Padding(15);
            this.pnlPenilaianForm.Size = new System.Drawing.Size(341, 450);
            this.pnlPenilaianForm.TabIndex = 1;
            // 
            // btnRefreshNilai
            // 
            this.btnRefreshNilai.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRefreshNilai.FlatAppearance.BorderSize = 0;
            this.btnRefreshNilai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefreshNilai.ForeColor = System.Drawing.Color.White;
            this.btnRefreshNilai.Location = new System.Drawing.Point(18, 395);
            this.btnRefreshNilai.Name = "btnRefreshNilai";
            this.btnRefreshNilai.Size = new System.Drawing.Size(140, 36);
            this.btnRefreshNilai.TabIndex = 9;
            this.btnRefreshNilai.Text = "Batal / Refresh";
            this.btnRefreshNilai.UseVisualStyleBackColor = false;
            this.btnRefreshNilai.Click += new System.EventHandler(this.btnRefreshNilai_Click);
            // 
            // btnSimpanNilai
            // 
            this.btnSimpanNilai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSimpanNilai.FlatAppearance.BorderSize = 0;
            this.btnSimpanNilai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpanNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimpanNilai.ForeColor = System.Drawing.Color.White;
            this.btnSimpanNilai.Location = new System.Drawing.Point(170, 395);
            this.btnSimpanNilai.Name = "btnSimpanNilai";
            this.btnSimpanNilai.Size = new System.Drawing.Size(150, 36);
            this.btnSimpanNilai.TabIndex = 8;
            this.btnSimpanNilai.Text = "Simpan Nilai";
            this.btnSimpanNilai.UseVisualStyleBackColor = false;
            this.btnSimpanNilai.Click += new System.EventHandler(this.btnSimpanNilai_Click);
            // 
            // lblStatusPreview
            // 
            this.lblStatusPreview.AutoSize = true;
            this.lblStatusPreview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatusPreview.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblStatusPreview.Location = new System.Drawing.Point(100, 348);
            this.lblStatusPreview.Name = "lblStatusPreview";
            this.lblStatusPreview.Size = new System.Drawing.Size(146, 20);
            this.lblStatusPreview.TabIndex = 7;
            this.lblStatusPreview.Text = "Belum Diperbaharui";
            // 
            // lblStatusLabel
            // 
            this.lblStatusLabel.AutoSize = true;
            this.lblStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblStatusLabel.Location = new System.Drawing.Point(15, 350);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new System.Drawing.Size(79, 17);
            this.lblStatusLabel.TabIndex = 6;
            this.lblStatusLabel.Text = "Status Akhir:";
            // 
            // txtCatatanGuru
            // 
            this.txtCatatanGuru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCatatanGuru.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCatatanGuru.Location = new System.Drawing.Point(18, 235);
            this.txtCatatanGuru.Multiline = true;
            this.txtCatatanGuru.Name = "txtCatatanGuru";
            this.txtCatatanGuru.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCatatanGuru.Size = new System.Drawing.Size(302, 95);
            this.txtCatatanGuru.TabIndex = 5;
            // 
            // lblCatatan
            // 
            this.lblCatatan.AutoSize = true;
            this.lblCatatan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCatatan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblCatatan.Location = new System.Drawing.Point(15, 212);
            this.lblCatatan.Name = "lblCatatan";
            this.lblCatatan.Size = new System.Drawing.Size(171, 17);
            this.lblCatatan.TabIndex = 4;
            this.lblCatatan.Text = "Catatan / Evaluasi Pembimbing:";
            // 
            // numNilaiGuru
            // 
            this.numNilaiGuru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numNilaiGuru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.numNilaiGuru.Location = new System.Drawing.Point(18, 170);
            this.numNilaiGuru.Name = "numNilaiGuru";
            this.numNilaiGuru.Size = new System.Drawing.Size(120, 29);
            this.numNilaiGuru.TabIndex = 3;
            this.numNilaiGuru.ValueChanged += new System.EventHandler(this.numNilaiGuru_ValueChanged);
            // 
            // lblNilai
            // 
            this.lblNilai.AutoSize = true;
            this.lblNilai.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNilai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblNilai.Location = new System.Drawing.Point(15, 147);
            this.lblNilai.Name = "lblNilai";
            this.lblNilai.Size = new System.Drawing.Size(144, 17);
            this.lblNilai.TabIndex = 2;
            this.lblNilai.Text = "Nilai Bimbingan (0 - 100):";
            // 
            // lblSelectedSiswa
            // 
            this.lblSelectedSiswa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.lblSelectedSiswa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelectedSiswa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblSelectedSiswa.Location = new System.Drawing.Point(18, 48);
            this.lblSelectedSiswa.Name = "lblSelectedSiswa";
            this.lblSelectedSiswa.Padding = new System.Windows.Forms.Padding(8);
            this.lblSelectedSiswa.Size = new System.Drawing.Size(302, 85);
            this.lblSelectedSiswa.TabIndex = 1;
            this.lblSelectedSiswa.Text = "Pilih siswa dari tabel untuk memberi nilai.";
            // 
            // lblPenilaianHeader
            // 
            this.lblPenilaianHeader.AutoSize = true;
            this.lblPenilaianHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPenilaianHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblPenilaianHeader.Location = new System.Drawing.Point(15, 15);
            this.lblPenilaianHeader.Name = "lblPenilaianHeader";
            this.lblPenilaianHeader.Size = new System.Drawing.Size(161, 21);
            this.lblPenilaianHeader.TabIndex = 0;
            this.lblPenilaianHeader.Text = "Form Evaluasi Siswa";
            // 
            // FormDashboardGuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.tabControlGuru);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormDashboardGuru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Guru Pembimbing PKL";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControlGuru.ResumeLayout(false);
            this.tabJurnal.ResumeLayout(false);
            this.tabJurnal.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.cardPending.ResumeLayout(false);
            this.cardPending.PerformLayout();
            this.cardApproved.ResumeLayout(false);
            this.cardApproved.PerformLayout();
            this.cardRevisions.ResumeLayout(false);
            this.cardRevisions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
            this.tabPenilaian.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenilaian)).EndInit();
            this.pnlPenilaianForm.ResumeLayout(false);
            this.pnlPenilaianForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNilaiGuru)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblNamaPengguna;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControlGuru;
        private System.Windows.Forms.TabPage tabJurnal;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Panel cardPending;
        private System.Windows.Forms.Label lblPendingCount;
        private System.Windows.Forms.Label lblPendingTitle;
        private System.Windows.Forms.Panel cardApproved;
        private System.Windows.Forms.Label lblApprovedCount;
        private System.Windows.Forms.Label lblApprovedTitle;
        private System.Windows.Forms.Panel cardRevisions;
        private System.Windows.Forms.Label lblRevisionCount;
        private System.Windows.Forms.Label lblRevisionTitle;
        private System.Windows.Forms.DataGridView dgvRecent;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblRecent;
        private System.Windows.Forms.TabPage tabPenilaian;
        private System.Windows.Forms.DataGridView dgvPenilaian;
        private System.Windows.Forms.Panel pnlPenilaianForm;
        private System.Windows.Forms.Label lblPenilaianHeader;
        private System.Windows.Forms.Label lblSelectedSiswa;
        private System.Windows.Forms.Label lblNilai;
        private System.Windows.Forms.NumericUpDown numNilaiGuru;
        private System.Windows.Forms.Label lblCatatan;
        private System.Windows.Forms.TextBox txtCatatanGuru;
        private System.Windows.Forms.Label lblStatusLabel;
        private System.Windows.Forms.Label lblStatusPreview;
        private System.Windows.Forms.Button btnSimpanNilai;
        private System.Windows.Forms.Button btnRefreshNilai;
    }
}

